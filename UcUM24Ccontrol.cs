using System;
using System.Windows.Forms;

namespace UM_Monitor
{
    public partial class UcUM24Ccontrol : UserControl
    {
        public UcUM24Ccontrol()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SerialCom.ScreenNext();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SerialCom.ScreenRotate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SerialCom.GroupNext();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SerialCom.GroupClear();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SerialCom.f5();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            SerialCom.f6();
        }

    }
}
