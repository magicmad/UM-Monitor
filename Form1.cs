using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace UM_Monitor
{
    public partial class Form1 : Form
    {
        List<CMData> cmdata = new List<CMData>();
        FilterConfig fc;

        public delegate void UpdateChart();
        public UpdateChart myDelegate;


        public Form1()
        {
            InitializeComponent();

            this.Icon = Icon.FromHandle(Properties.Resources.um24c2.GetHicon());

            this.fc = this.ucFilter1.GetFilterConfig();

            myDelegate = new UpdateChart(updatechart);

            Properties.Settings.Default.Reload();
            if (!string.IsNullOrEmpty(Properties.Settings.Default.port))
                SerialCom.Connect(Properties.Settings.Default.port);

            this.updateConnectStatus();
        }


        /// <summary>
        /// select com port
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button8_Click_1(object sender, EventArgs e)
        {
            FormComSelect fcs = new FormComSelect();
            fcs.ShowDialog();

            updateConnectStatus();
        }

        /// <summary>
        /// show connect state
        /// </summary>
        private void updateConnectStatus()
        {
            this.btnCOM.BackColor = SerialCom.IsConnected ? Color.Green : Color.Red;
            this.btnCapture.Enabled = this.btnUM24C.Enabled = SerialCom.IsConnected;
        }

        /// <summary>
        /// run / stop timer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            this.timer1.Enabled = !this.timer1.Enabled;

            this.btnCapture.BackColor = this.timer1.Enabled ? Color.Green : Color.Red;
        }

        /// <summary>
        /// clear stored data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("clean all data?", "clean data", MessageBoxButtons.OKCancel);
            if (dr == DialogResult.OK)
                this.cmdata.Clear();
        }

        /// <summary>
        /// timer action
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            SerialCom.GetStatus(OnDataReceived);

            // set max to now.. meh
            this.fc.dtmin.MaxDate = DateTime.Now;
            this.fc.dtmax.MaxDate = DateTime.Now;
        }

        private void OnDataReceived(byte[] data)
        {
            // parse and store
            cmdata.Add(new CMData(data));

            // update gui
            this.Invoke(myDelegate);
        }

        /// <summary>
        /// update gui
        /// </summary>
        private void updatechart()
        {
            // show current values
            this.labelVolt.Text = cmdata[cmdata.Count - 1].Voltage.ToString("F");
            this.labelAmp.Text = cmdata[cmdata.Count - 1].Amperage.ToString("F");
            this.labelWatt.Text = cmdata[cmdata.Count - 1].Wattage.ToString("F");


            // clear chart
            this.chart1.Series[0].Points.Clear();
            this.chart1.Series[1].Points.Clear();
            this.chart1.Series[2].Points.Clear();

            DateTime min = DateTime.MinValue;
            DateTime max = DateTime.MaxValue;

            // check date range 
            if (fc.mode == FilterConfig.FcMode.fromto)
            {
                if (this.fc.dtmin.Checked)
                    min = this.fc.dtmin.Value;

                if (this.fc.dtmax.Checked)
                    max = this.fc.dtmax.Value;
            }
            else if (fc.mode == FilterConfig.FcMode.lastxseconds)
            {
                min = DateTime.Now.AddSeconds(-fc.seconds);
            }

            // fill chart
            foreach (CMData cd in cmdata)
            {
                if (cd.Timestamp > min && cd.Timestamp < max)
                {
                    this.chart1.Series[0].Points.AddY(cd.Voltage);
                    this.chart1.Series[1].Points.AddY(cd.Amperage);
                    this.chart1.Series[2].Points.AddY(cd.Wattage);
                }
            }
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            this.timer1.Interval = this.trackBar1.Value;
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            this.ucFilter1.Visible = !this.ucFilter1.Visible;

            // manually update. timer might be stopped
            //updatechart();
        }



        private void btnUM24C_Click(object sender, EventArgs e)
        {
            this.ucUM24Ccontrol1.Visible = !this.ucUM24Ccontrol1.Visible;
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            FormPG fpg = new FormPG(this.chart1);
            fpg.Show();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.AddExtension = true;
            sfd.Filter = "csv|*.csv";
            if (sfd.ShowDialog() != DialogResult.OK)
                return;


            StringBuilder sb = new StringBuilder();

            CMData[] data = this.cmdata.ToArray();

            foreach (CMData cmd in data)
            {
                string line = cmd.Timestamp.ToString(CultureInfo.InvariantCulture) + ",";
                line += cmd.Voltage.ToString(CultureInfo.InvariantCulture) + ",";
                line += cmd.Amperage.ToString(CultureInfo.InvariantCulture) + ",";
                line += cmd.Wattage.ToString(CultureInfo.InvariantCulture) + ",";

                sb.AppendLine(line);
            }

            File.WriteAllText(sfd.FileName, sb.ToString());
        }
    }
}

