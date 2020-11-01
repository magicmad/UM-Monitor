namespace UM_Monitor
{
    using System;
    using System.IO.Ports;
    using System.Windows.Forms;


    public partial class FormComSelect : Form
    {
        public FormComSelect()
        {
            InitializeComponent();

            updateConnectStatus();

            this.button1_Click(null, null);
        }

        private void updateConnectStatus()
        {
            this.button2.Enabled = !SerialCom.IsConnected;
            this.button3.Enabled = SerialCom.IsConnected;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Get a list of serial port names.
            string[] ports = SerialPort.GetPortNames();
            this.listBox1.DataSource = ports;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool res = SerialCom.Connect((string)this.listBox1.SelectedItem);

            updateConnectStatus();

            if (res)
            {
                Properties.Settings.Default.port = (string)this.listBox1.SelectedItem;
                Properties.Settings.Default.Save();

                this.Close();
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            SerialCom.Disconnect();

            updateConnectStatus();
        }
    }
}
