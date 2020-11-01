using System.Windows.Forms;

namespace UM_Monitor
{
    public partial class FormFilter : Form
    {
        FilterConfig fc;

        public FormFilter()
        {
            InitializeComponent();
        }

        public FormFilter(FilterConfig fc)
            : this()
        {
            this.fc = fc;

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

            this.dateTimePicker1 = fc.dtmin;
            this.dateTimePicker1 = fc.dtmax;
        }

        private void numericUpDown1_ValueChanged(object sender, System.EventArgs e)
        {
            this.fc.seconds = (int)this.numericUpDown1.Value;
        }

        private void radioButton1_CheckedChanged(object sender, System.EventArgs e)
        {
            if (this.radioButton1.Checked)
                this.fc.mode = FilterConfig.FcMode.all;
        }

        private void radioButton2_CheckedChanged(object sender, System.EventArgs e)
        {
            if (this.radioButton2.Checked)
                this.fc.mode = FilterConfig.FcMode.lastxseconds;
        }

        private void radioButton3_CheckedChanged(object sender, System.EventArgs e)
        {
            if (this.radioButton3.Checked)
                this.fc.mode = FilterConfig.FcMode.fromto;
        }
    }
}
