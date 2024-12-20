using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace SetupMulti
{
    public partial class SetupForm : Form
    {
        private string _iniFile;
        private string _resPath;
        private string _runPath;

        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);

        [DllImport("shell32.dll", CharSet = CharSet.Unicode)]
        static extern IntPtr ExtractAssociatedIcon(IntPtr hInst, StringBuilder lpIconPath, out ushort lpiIcon);
        public SetupForm()
        {
            InitializeComponent();

            _iniFile = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "setup.ini");
            _runPath = Path.GetDirectoryName(Application.ExecutablePath);
            _resPath = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "img");

            Height = ReadInt32IniFile("MAIN", "HEIGHT", 200, _iniFile);

            if (File.Exists(_iniFile))
            {
                SetMain();
                SetInstall();
            }
            else
            {
                MessageBox.Show("setup.ini is not exist.");
            }
        }

        private void SetMain()
        {
            // Set Title
            Text = IniRead("MAIN", "TITLE", _iniFile);
            //Icon = Icon.ExtractAssociatedIcon(Path.Combine(_resPath, IniRead("MAIN", "ICON_FILE", _iniFile)));
            string iconfile = Path.Combine(_resPath, IniRead("MAIN", "ICON_FILE", _iniFile));

            ushort uicon;
            StringBuilder strB = new StringBuilder(260); // Allocate MAX_PATH chars
            strB.Append(iconfile);
            IntPtr handle = ExtractAssociatedIcon(IntPtr.Zero, strB, out uicon);
            Icon = Icon.FromHandle(handle);            

            // Set Logo
            string logofile = Path.Combine(_resPath, IniRead("MAIN", "LOGO_FILE", _iniFile));
            if (File.Exists(logofile))
            {
                pBoxLogo.BackgroundImage = Image.FromFile(logofile);
                pBoxLogo.BorderStyle = BorderStyle.None;
                labelLogoSize.Visible = false;
            }
            else
            {
                pBoxLogo.BorderStyle = BorderStyle.FixedSingle;
                labelLogoSize.Visible = true;
                labelLogoSize.Text = string.Format("{0}x{1}", pBoxLogo.Width, pBoxLogo.Height);
            }

            // Set Image
            string imagefile = Path.Combine(_resPath, IniRead("MAIN", "IMAGE_FILE", _iniFile));
            if (File.Exists(imagefile))
            {
                pBoxMain.BackgroundImage = Image.FromFile(imagefile);
                pBoxMain.BorderStyle = BorderStyle.None;
                labelImageSize.Visible = false;
            }
            else
            {
                pBoxMain.BorderStyle = BorderStyle.FixedSingle;
                labelImageSize.Visible = true;
                labelImageSize.Text = string.Format("{0}x{1}", pBoxMain.Width, pBoxMain.Height);
            }

            // Background Color
            BackColor = Color.FromName(IniRead("MAIN", "BACKCOLOR", _iniFile));
        }

        private void SetInstall()
        {
            for (int i = 1; i <= 10; i++)
            {
                string section = string.Format("INSTALL{0}", i);
                bool enable = IniReadBool(section, "ENABLE", _iniFile);
                if(enable)
                {
                    string title = IniRead(section, "TITLE", _iniFile);

                    UCTitle uct = new UCTitle(title);
                    uct.Width = flPanel.Width - 25;

                    flPanel.Controls.Add(uct);

                    for(int j = 1; j <= 10; j++)
                    {
                        bool[] itemenable = new bool[2];

                        for (int k = 1; k <= 2; k++)
                        {
                            string key = string.Format("ITEM{0}_{1}", j, k);

                            itemenable[k-1] = IniReadBool(section, key + "_ENABLE", _iniFile);                            
                        }

                        if(itemenable[0] == true || itemenable[1] == true)
                        {
                            string[] imgfile = new string[2];
                            string[] runfile = new string[2];
                            string[] tooltip = new string[2];

                            for(int k = 1; k <= 2; k++)
                            {
                                string key = string.Format("ITEM{0}_{1}", j, k);

                                imgfile[k-1] = Path.Combine(_resPath, IniRead(section, key + "_IMG", _iniFile));
                                runfile[k-1] = Path.Combine(_runPath, IniRead(section, key + "_EXEFILE", _iniFile));
                                tooltip[k-1] = IniRead(section, key + "_TOOLTIP", _iniFile);
                            }

                            UCItem ucitem = new UCItem(itemenable[0], imgfile[0], runfile[0], tooltip[0], itemenable[1], imgfile[1], runfile[1], tooltip[1]);
                            ucitem.Width = flPanel.Width - 25;

                            flPanel.Controls.Add(ucitem);
                        }
                    }
                }
            }
        }

        private String IniRead(String Section, String Key, string avsPath)
        {

            StringBuilder temp = new StringBuilder(2000);

            int i = GetPrivateProfileString(Section, Key, "", temp, 2000, avsPath);

            return temp.ToString();

        }

        private bool IniReadBool(String section, String key, string inifile)
        {

            StringBuilder sb = new StringBuilder(255, 1000);
            GetPrivateProfileString(section, key, "", sb, sb.Capacity, inifile);

            string value = sb.ToString().ToLower();

            if (value == "true")
                return true;

            return false;
        }

        public static int ReadInt32IniFile(string section, string key, int def, string path)
        {
            StringBuilder sb = new StringBuilder(255);
            GetPrivateProfileString(section, key, def.ToString(), sb, sb.Capacity, path);

            string value = sb.ToString();

            int val;

            if (int.TryParse(value, out val))
                return val;

            return def;
        }

        private void linkLabelW_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://www.wonatech.com");
        }

        private void linkLabelZ_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://www.zivelab.com");
        }
    }
}
