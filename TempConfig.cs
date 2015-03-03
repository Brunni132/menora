using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Menora
{
    class TempConfig
    {
        public const int MaxMinutesFromDayStart = 24 * 60;

        public class TempEntry
        {
            public int TempKelvin;
            public int MinutesFromDayStart;
            public TempEntry() { }
            public TempEntry(int tempKelvin, int minutesFromDayStart) { TempKelvin = tempKelvin; MinutesFromDayStart = minutesFromDayStart; }
        }
        public readonly int DayStartMinutes;
        private List<TempEntry> entries = new List<TempEntry>();

        public TempConfig(string json)
        {
            JArray array = JArray.Parse(json);
            DayStartMinutes = 4 * 60;
            foreach (JObject obj in array.Children<JObject>())
            {
                var time = obj.Value<string>("time");
                var temp = obj.Value<int>("temp");
                var splits = time.Split(':');
                var parsedTime = Convert.ToInt32(splits[0]) * 60 + Convert.ToInt32(splits[1]) - DayStartMinutes;
                if (parsedTime < 0)
                    parsedTime += MaxMinutesFromDayStart;
                entries.Add(new TempEntry(temp, parsedTime));
            }
            SortAfterModification();
            if (array.Count < 1)
            {
                throw new ArgumentException("Must contain at least one entry");
            }
        }

        public List<TempEntry> Entries
        {
            get { return entries; }
        }

        public int TemperatureAt(int minutesFromDayStart)
        {
            WrapMinutesFromDayStart(ref minutesFromDayStart);
            if (minutesFromDayStart < entries[0].MinutesFromDayStart)
            {
                return entries[0].TempKelvin;
            }
            int entryId = EntryIdAt(minutesFromDayStart);
            if (entryId == entries.Count - 1)
            {
                return entries[entryId].TempKelvin;
            }
            int elapsedTimeForSection = minutesFromDayStart - entries[entryId].MinutesFromDayStart;
            int totalTimeForSection = entries[entryId + 1].MinutesFromDayStart - entries[entryId].MinutesFromDayStart;
            double alpha = (double) elapsedTimeForSection / totalTimeForSection;
            return (int) (alpha * entries[entryId + 1].TempKelvin + (1 - alpha) * entries[entryId].TempKelvin);
        }

        public string PrettyTimeForEntry(TempEntry entry) {
            return PrettyTime(entry.MinutesFromDayStart);
        }

        public string PrettyTime(int minutesFromDayStart)
        {
            minutesFromDayStart += DayStartMinutes;
            WrapMinutesFromDayStart(ref minutesFromDayStart);
            return String.Format("{00}:{1:00}", minutesFromDayStart / 60, minutesFromDayStart % 60);
        }

        private int EntryIdAt(int minutesFromDayStart)
        {
            int entryId;
            WrapMinutesFromDayStart(ref minutesFromDayStart);
            for (entryId = 0; entryId < entries.Count; entryId++)
            {
                if (entries[entryId].MinutesFromDayStart >= minutesFromDayStart)
                {
                    return Math.Max(0, entryId - 1);
                }
            }
            return entries.Count - 1;
        }

        private void SortAfterModification()
        {
            entries = entries.OrderBy(o => o.MinutesFromDayStart).ToList();
        }

        private void WrapMinutesFromDayStart(ref int minutesFromDayStart)
        {
            // Ensures that it is in a valid range (0..MaxMinutesFromDayStart)
            minutesFromDayStart = minutesFromDayStart % MaxMinutesFromDayStart;
            if (minutesFromDayStart < 0)
                minutesFromDayStart += MaxMinutesFromDayStart;
        }
    }
}
