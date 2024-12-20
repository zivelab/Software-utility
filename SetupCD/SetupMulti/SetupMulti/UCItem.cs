using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace SetupMulti
{
    public partial class UCItem : UserControl
    {
        private string _runfile1;
        private string _runfile2;        

        public UCItem()
        {
            InitializeComponent();
        }

        public UCItem(bool enable1, string imgfile1, string runfile1, string tooltipText1, bool enable2, string imgfile2, string runfile2, string tooltipText2)
        {
            InitializeComponent();

            button1.Visible = enable1;
            button2.Visible = enable2;

            if (enable1)
            {
                if (File.Exists(imgfile1))
                {
                    button1.BackgroundImage = Image.FromFile(imgfile1);
                    button1.Text = "";
                }
                else
                {
                    button1.Text = string.Format("{0}x{1}", button1.Width, button1.Height);
                }

                _runfile1 = runfile1;

                toolTip.SetToolTip(button1, tooltipText1);
            }

            if (enable2)
            {
                if (File.Exists(imgfile2))
                {
                    button2.BackgroundImage = Image.FromFile(imgfile2);
                    button2.Text = "";
                }
                else
                {
                    button2.Text = string.Format("{0}x{1}", button2.Width, button2.Height);
                }

                _runfile2 = runfile2;

                toolTip.SetToolTip(button2, tooltipText2);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(_runfile1))
                    Process.Start(_runfile1);
                else
                    MessageBox.Show(string.Format("{0} file could not be found.", _runfile1));
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "WonATech");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(_runfile2))
                    Process.Start(_runfile2);
                else
                    MessageBox.Show(string.Format("{0} file could not be found.", _runfile2));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "WonATech");
            }
        }
    }
}
