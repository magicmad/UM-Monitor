
namespace UM_Monitor
{
    using System.Windows.Forms;

    public partial class UcFilter : UserControl
    {
        FilterConfig fc;

        public UcFilter()
        {
            InitializeComponent();


            this.initFilterconfig();
        }


        public void initFilterconfig()
        {
            this.fc = new FilterConfig(this.dateTimePicker1, this.dateTimePicker2);

            switch (fc.mode)
            {
                case FilterConfig.FcMode.fromto:
                    this.radioButton3.Checked = true;
                    break;
                case FilterConfig.FcMode.lastxseconds:
                    this.radioButton2.Checked = true;
                    break;
                default:
                    this.radioButton1.Checked = true;
                    break;
            }

            this.numericUpDown1.Value = fc.seconds;
        }


        public FilterConfig GetFilterConfig()
        {
            return this.fc;
        }


        private void numericUpDown1_ValueChanged(object sender, System.EventArgs e)
        {
            if (this.fc != null)
                this.fc.seconds = (int)this.numericUpDown1.Value;
        }

        private void radioButton1_CheckedChanged(object sender, System.EventArgs e)
        {
            if (this.fc != null && this.radioButton1.Checked)
                this.fc.mode = FilterConfig.FcMode.all;
        }

        private void radioButton2_CheckedChanged(object sender, System.EventArgs e)
        {
            if (this.fc != null && this.radioButton2.Checked)
                this.fc.mode = FilterConfig.FcMode.lastxseconds;
        }

        private void radioButton3_CheckedChanged(object sender, System.EventArgs e)
        {
            if (this.fc != null && this.radioButton3.Checked)
                this.fc.mode = FilterConfig.FcMode.fromto;
        }
    }
}
