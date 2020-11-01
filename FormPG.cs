using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UM_Monitor
{
    public partial class FormPG : Form
    {
        public FormPG()
        {
            InitializeComponent();
        }

        public FormPG(object o)
            : this()
        {
            this.propertyGrid1.SelectedObject = o;
        }
    }
}
