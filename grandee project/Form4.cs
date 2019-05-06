using System;
using MaterialSkin.Controls;
using MaterialSkin;
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
    public partial class Form4 : MaterialForm
    {
        public Form4()
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

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            CLsPrint a = new CLsPrint();
            a.ClsPrint(dataGridView1, "Print");
        }
    }
}
