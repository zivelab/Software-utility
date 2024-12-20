using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SetupMulti
{
    public partial class UCTitle : UserControl
    {
        public UCTitle()
        {
            InitializeComponent();
        }

        public UCTitle(string title)
        {
            InitializeComponent();

            label.Text = title;
        }
    }
}
