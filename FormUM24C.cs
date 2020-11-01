using System.Drawing;
using System.Windows.Forms;

namespace UM_Monitor
{
    public partial class FormUM24C : Form
    {
        public FormUM24C()
        {
            InitializeComponent();

            // Convert to an icon and use for the form's icon.
            this.Icon = Icon.FromHandle(Properties.Resources.um24c2.GetHicon());
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
