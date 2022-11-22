using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PE21
{
    public partial class MyEditorParent : Form
    {
        public MyEditorParent()
        {
            InitializeComponent();

            //PE23
            this.newToolStripMenuItem.Click += new EventHandler(NewToolStripMenuItem__Click);
            this.tileToolStripMenuItem.Click += new EventHandler(TileToolStripMenuItem__Click);
            this.cascadeToolStripMenuItem.Click += new EventHandler(CascadeToolStripMenuItem__Click);

            this.exitToolStripMenuItem.Click += new EventHandler(ExitToolStripMenuItem__Click);

            Form1 form1 = new Form1(this);
            form1.Show();


        }

        //PE23
        private void NewToolStripMenuItem__Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(this);
            form1.Show();


        }

        //PE23
        private void TileToolStripMenuItem__Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        //PE23
        private void CascadeToolStripMenuItem__Click(object sender, EventArgs e)
        {

            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ExitToolStripMenuItem__Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
