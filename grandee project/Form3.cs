using System;
using MaterialSkin.Controls;
using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace grandee_project
{
    public partial class Form3 : MaterialForm
    {
        public Form3()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            var skinmanager = MaterialSkinManager.Instance;
            skinmanager.AddFormToManage(this);
            skinmanager.Theme = MaterialSkinManager.Themes.LIGHT;
            SkinManager.ColorScheme = new ColorScheme(Primary.Teal500, Primary.Teal300,
                Primary.Teal500, Accent.LightBlue200,
                TextShade.WHITE);
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void materialTabSelector1_Click(object sender, EventArgs e)
        {
           
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            Form4 n = new Form4();
            n.Show();
        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        { 
            Form5 n = new Form5();
            n.Show();
        }
    }
}
