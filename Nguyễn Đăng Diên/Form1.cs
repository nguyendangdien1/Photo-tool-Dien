using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace phototool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnload_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "open file";
            dlg.Filter = "jpg files (*.jpg)|*.jpg|all files (*.*)| *.*";
            if (dlg.ShowDialog() == DialogResult.OK)
                try
                {
                    pbxphoto.Image = new Bitmap(dlg.OpenFile());

                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show("unable to load files:" + ex.Message);
                    pbxphoto.Image = null;

                }
            dlg.Dispose();
        }
        private void mnuexit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
