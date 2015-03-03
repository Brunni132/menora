using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menora
{
    public partial class TmpChangerForm : Form
    {
        private TempConfig currentConfig;
        private static readonly string[] presetConfigs =
        {
            "[\n    {\"time\": \"6:00\", \"temp\": 9500},\n    {\"time\": \"10:00\", \"temp\": 6500},\n    {\"time\": \"14:00\", \"temp\": 6500},\n    {\"time\": \"22:00\", \"temp\": 3000},\n]",
            "[\n    {\"time\": \"12:00\", \"temp\": 6500},\n    {\"time\": \"02:00\", \"temp\": 2000},\n]",
        };
        private bool shouldStartMinimized, isEnabled;

        public TmpChangerForm(bool minimized)
        {
            InitializeComponent();

            // Fill up presets
            cboPreset.Items.Add("From tempConfig.json file");
            cboPreset.Items.Add("From the source box (on the left)");
            for (int i = 1; i <= presetConfigs.Length; i++)
                cboPreset.Items.Add("Preset " + i);
            
            // Loads the default config
            cboPreset.SelectedIndex = 0;
            tbTestDay.Value = 360;
            if (currentConfig != null)
            {
                radioUse.Checked = true;
            }
            else
            {
                // Select a preset entry by default
                radioTestTemp.Checked = true;
                cboPreset.SelectedIndex = 2;
            }
            shouldStartMinimized = minimized;
        }

        #region Event handling
        private void TmpChangerForm_Load(object sender, EventArgs e)
        {
            if (shouldStartMinimized && currentConfig != null)
                this.WindowState = FormWindowState.Minimized;
        }

        private void cboPreset_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboPreset.SelectedIndex == 0)       // From file
                LoadConfigFromFile();
            else if (cboPreset.SelectedIndex == 1)  // From source
                LoadConfigFromTextBox();
            else
            {
                SetCodeText(presetConfigs[cboPreset.SelectedIndex - 2]);
                LoadConfigFromTextBox();
            }
        }

        private void txtCode_Leave(object sender, EventArgs e)
        {
            // Select "from source"
            cboPreset.SelectedIndex = 1;
            LoadConfigFromTextBox();
        }

        private void radioTestTemp_CheckedChanged(object sender, EventArgs e)
        {
            UpdateStatus();
        }

        private void radioTestDay_CheckedChanged(object sender, EventArgs e)
        {
            UpdateStatus();
        }

        private void radioUse_CheckedChanged(object sender, EventArgs e)
        {
            UpdateStatus();
        }

        private void tempTestTrackbar_Scroll(object sender, EventArgs e)
        {
            radioTestTemp.Checked = true;
            UpdateStatus();
        }

        private void dayTrackbar_Scroll(object sender, EventArgs e)
        {
            radioTestDay.Checked = true;
            UpdateStatus();
        }

        private void btnSaveCode_Click(object sender, EventArgs e)
        {
            System.IO.File.WriteAllText(@"tempConfig.json", txtCode.Text);
        }

        private void tmrMinute_Tick(object sender, EventArgs e)
        {
            UpdateStatus();
        }

        private void TmpChangerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Restore on exit
            TempUtils.ApplyGamma(6500);
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TmpChangerForm_Resize(object sender, EventArgs e)
        {
            ShowSystrayIcon(this.WindowState == FormWindowState.Minimized);
        }

        private void trayIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }
        #endregion

        private void EnableDayControls(bool enable, Exception error)
        {
            radioTestDay.Enabled = tbTestDay.Enabled = radioUse.Enabled = lblCurrentTime.Enabled = btnSaveCode.Enabled = enable;
            isEnabled = enable;
            if (!enable)
            {
                lblStatus.Text = error != null ? error.Message : "Error";
            }
            else
            {
                lblStatus.Text = "JSON is valid.";
            }
        }

        private void LoadConfigFromFile()
        {
            try
            {
                SetCodeText(ReadConfigFile());
                EnableDayControls(true, null);
                LoadConfigFromTextBox();
                UpdateStatus();
            }
            catch (Exception e)
            {
                EnableDayControls(false, e);
                MessageBox.Show("Unable to load the configuration properly. Loading preset config -- do not forget to click on the Save code button.\n" + e.Message);
            }
        }

        private void LoadConfigFromTextBox()
        {
            try
            {
                currentConfig = new TempConfig(txtCode.Text);
                EnableDayControls(true, null);
                UpdateStatus();
            }
            catch (Exception e)
            {
                EnableDayControls(false, e);
            }
        }

        private string ReadConfigFile()
        {
            return System.IO.File.ReadAllText(@"tempConfig.json");
        }

        private void SetCodeText(string code)
        {
            txtCode.Text = code.Replace("\n", Environment.NewLine);
            UpdateStatus();
        }

        private void ShowSystrayIcon(bool showOnSysTray)
        {
            if (showOnSysTray)
            {
                this.ShowInTaskbar = false;
                this.trayIcon.Visible = true;
            }
            else
            {
                this.ShowInTaskbar = true;
                this.trayIcon.Visible = false;
            }
        }

        private void UpdateStatus()
        {
            tmrMinute.Enabled = radioUse.Checked;
            if (radioTestTemp.Checked)
            {
                TempUtils.ApplyGamma(tbTestTemp.Value);
                lblTemperature.Text = tbTestTemp.Value + "K";
            }
            else if (radioTestDay.Checked)
            {
                int minutes = tbTestDay.Value;
                int temp = currentConfig.TemperatureAt(minutes);
                lblCurrentTime.Text = currentConfig.PrettyTime(minutes);
                TempUtils.ApplyGamma(temp);
            }
            else if (radioUse.Checked)
            {
                DateTime now = DateTime.Now;
                int temp = currentConfig.TemperatureAt(now.Hour * 60 + now.Minute - currentConfig.DayStartMinutes);
                TempUtils.ApplyGamma(temp);
            }
        }
    }
}
