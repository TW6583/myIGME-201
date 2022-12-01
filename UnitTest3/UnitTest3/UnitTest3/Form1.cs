using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using System.Threading;
using System.Reflection;

namespace UnitTest3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //presidents
            this.benjaminHarrisonButton.CheckedChanged += new EventHandler(BenjaminHarrison__CheckedChanged);
            this.franklinDRooseveltButton.CheckedChanged += new EventHandler(FranklinDRooseveltButton__CheckedChanged);
            this.williamJClintonButton.CheckedChanged += new EventHandler(WilliamJClintonButton__CheckedChanged);
            this.jamesBuchananButton.CheckedChanged += new EventHandler(JamesBuchananButton__CheckedChanged);
            this.franklinPierceButton.CheckedChanged += new EventHandler(FranklinkPierceButton__CheckedChanged);
            this.georgeWBushButton.CheckedChanged += new EventHandler(GeorgeWBushButton__CheckedChanged);
            this.barackObamaButton.CheckedChanged += new EventHandler(BarackObamaButton__CheckedChanged);
            this.johnFKennedyButton.CheckedChanged += new EventHandler(JohnFKennedyButton__CheckedChanged);
            this.williamMcKinleyButton.CheckedChanged += new EventHandler(WilliamMcKinleyButton__CheckedChanged);
            this.ronaldReaganButton.CheckedChanged += new EventHandler(RonaldReaganButton__CheckedChanged);
            this.dwightDEisenhowerButton.CheckedChanged += new EventHandler(DwightDEisenhowerButton__CheckedChanged);
            this.martinVanBurenButton.CheckedChanged += new EventHandler(MartinVanBurenButton__CheckedChanged);
            this.georgeWashingtonButton.CheckedChanged += new EventHandler(GeorgeWashingtonButton__CheckedChanged);
            this.johnAdamsButton.CheckedChanged += new EventHandler(JohnAdamsButton__CheckedChanged);
            this.theodoreRooseveltButton.CheckedChanged += new EventHandler(TheodoreRooseveltButton__CheckedChanged);
            this.thomasJeffersonButton.CheckedChanged += new EventHandler(ThomasJeffersonButton__CheckedChanged);

            this.benjaminHarrisonButton.Checked = true;

            //filter
            this.allRadioButton.CheckedChanged += new EventHandler(AllRadioButton__CheckedChanged);
            this.republicanRadioButton.CheckedChanged += new EventHandler(RepublicanRadioButton__CheckedChanged);
            this.democratRadioButton.CheckedChanged += new EventHandler(DemocratRadioButton__CheckedChanged);
            this.democratRepublicanRadioButton.CheckedChanged += new EventHandler(DemocratRepublicanRadioButton__CheckedChanged);
            this.federalistRadioButton.CheckedChanged += new EventHandler(FederalistRadioButton__CheckedChanged);

            //textboxes
            this.harrisonTextBox.KeyPress += new KeyPressEventHandler(HarrisonTextBox__KeyPress);
            this.franklinDRooseveltTextBox.KeyPress += new KeyPressEventHandler(FranklinDRooseveltTextbox__KeyPress);
            this.clintonTextBox.KeyPress += new KeyPressEventHandler(ClintonTextBox__KeyPress);
            this.buchananTextBox.KeyPress += new KeyPressEventHandler(BuchananTextBox__KeyPress);
            this.pierceTextBox.KeyPress += new KeyPressEventHandler(PierceTextBox__KeyPress);
            this.bushTextBox.KeyPress += new KeyPressEventHandler(BushTextBox__KeyPress);
            this.obamaTextBox.KeyPress += new KeyPressEventHandler(ObamaTextBox__KeyPress);
            this.kennedyTextBox.KeyPress += new KeyPressEventHandler(KennedyTextBox__KeyPress);
            this.mcKinleyTextBox.KeyPress += new KeyPressEventHandler(McKinleyTextBox__KeyPress);
            this.reaganTextBox.KeyPress += new KeyPressEventHandler(ReaganTextBox__KeyPress);
            this.eisenhowerTextBox.KeyPress += new KeyPressEventHandler(EisenhowerTextBox__KeyPress);
            this.vanBurenTextBox.KeyPress += new KeyPressEventHandler(VanBurenTextBox__KeyPress);
            this.washingtonTextBox.KeyPress += new KeyPressEventHandler(WashingtonTextBox__KeyPress);
            this.adamsTextBox.KeyPress += new KeyPressEventHandler(AdamsTextBox__KeyPress);
            this.theodoreRooseveltTextBox.KeyPress += new KeyPressEventHandler(TheodoreRooseveltTextBox__KeyPress);
            this.jeffersonTextBox.KeyPress += new KeyPressEventHandler(JeffersonTextBox__KeyPress);

            //exit button
            this.exitButton.Click += new EventHandler(ExitButton__Click);

            //progress bar
            this.toolStripProgressBar.Value = 180;
            this.toolStripProgressBar.Maximum = 180;
            
            //picture box
            this.pictureBox1.MouseEnter += new EventHandler(PictureBox1__MouseEnter);
            this.pictureBox1.MouseLeave += new EventHandler(PictureBox1__MouseLeave);

            //web browser
            this.webBrowser1.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(WebBrowser__DocumentCompleted);

            //timer
            this.timer1.Tick += new EventHandler(Timer__Tick);
        }

        private void HarrisonTextBox__KeyPress(object sender, KeyPressEventArgs e)
        {
            if (this.toolStripProgressBar.Value == 180)
            {
                this.timer1.Start();
            }

            if (Char.IsDigit(e.KeyChar) || e.KeyChar == '\b')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void FranklinDRooseveltTextbox__KeyPress(object sender, KeyPressEventArgs e)
        {
            if (this.toolStripProgressBar.Value == 180)
            {
                this.timer1.Start();
            }

            if (Char.IsDigit(e.KeyChar) || e.KeyChar == '\b')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void ClintonTextBox__KeyPress(object sender, KeyPressEventArgs e)
        {
            if (this.toolStripProgressBar.Value == 180)
            {
                this.timer1.Start();
            }

            if (Char.IsDigit(e.KeyChar) || e.KeyChar == '\b')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void BuchananTextBox__KeyPress(object sender, KeyPressEventArgs e)
        {
            if (this.toolStripProgressBar.Value == 180)
            {
                this.timer1.Start();
            }

            if (Char.IsDigit(e.KeyChar) || e.KeyChar == '\b')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void PierceTextBox__KeyPress(object sender, KeyPressEventArgs e)
        {
            if (this.toolStripProgressBar.Value == 180)
            {
                this.timer1.Start();
            }

            if (Char.IsDigit(e.KeyChar) || e.KeyChar == '\b')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void BushTextBox__KeyPress(object sender, KeyPressEventArgs e)
        {
            if (this.toolStripProgressBar.Value == 180)
            {
                this.timer1.Start();
            }

            if (Char.IsDigit(e.KeyChar) || e.KeyChar == '\b')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void ObamaTextBox__KeyPress(object sender, KeyPressEventArgs e)
        {
            if (this.toolStripProgressBar.Value == 180)
            {
                this.timer1.Start();
            }

            if (Char.IsDigit(e.KeyChar) || e.KeyChar == '\b')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void KennedyTextBox__KeyPress(object sender, KeyPressEventArgs e)
        {
            if (this.toolStripProgressBar.Value == 180)
            {
                this.timer1.Start();
            }

            if (Char.IsDigit(e.KeyChar) || e.KeyChar == '\b')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void McKinleyTextBox__KeyPress(object sender, KeyPressEventArgs e)
        {
            if (this.toolStripProgressBar.Value == 180)
            {
                this.timer1.Start();
            }

            if (Char.IsDigit(e.KeyChar) || e.KeyChar == '\b')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void ReaganTextBox__KeyPress(object sender, KeyPressEventArgs e)
        {
            if (this.toolStripProgressBar.Value == 180)
            {
                this.timer1.Start();
            }

            if (Char.IsDigit(e.KeyChar) || e.KeyChar == '\b')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void EisenhowerTextBox__KeyPress(object sender, KeyPressEventArgs e)
        {
            if (this.toolStripProgressBar.Value == 180)
            {
                this.timer1.Start();
            }

            if (Char.IsDigit(e.KeyChar) || e.KeyChar == '\b')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void VanBurenTextBox__KeyPress(object sender, KeyPressEventArgs e)
        {
            if (this.toolStripProgressBar.Value == 180)
            {
                this.timer1.Start();
            }

            if (Char.IsDigit(e.KeyChar) || e.KeyChar == '\b')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void WashingtonTextBox__KeyPress(object sender, KeyPressEventArgs e)
        {
            if (this.toolStripProgressBar.Value == 180)
            {
                this.timer1.Start();
            }

            if (Char.IsDigit(e.KeyChar) || e.KeyChar == '\b')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void AdamsTextBox__KeyPress(object sender, KeyPressEventArgs e)
        {
            if (this.toolStripProgressBar.Value == 180)
            {
                this.timer1.Start();
            }

            if (Char.IsDigit(e.KeyChar) || e.KeyChar == '\b')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void TheodoreRooseveltTextBox__KeyPress(object sender, KeyPressEventArgs e)
        {
            if (this.toolStripProgressBar.Value == 180)
            {
                this.timer1.Start();
            }

            if (Char.IsDigit(e.KeyChar) || e.KeyChar == '\b')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void JeffersonTextBox__KeyPress(object sender, KeyPressEventArgs e)
        {
            if (this.toolStripProgressBar.Value == 180)
            {
                this.timer1.Start();
            }

            if (Char.IsDigit(e.KeyChar) || e.KeyChar == '\b')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void Timer__Tick(object sender, EventArgs e)
        {
            --this.toolStripProgressBar.Value;
        }

        private void WebBrowser__DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            WebBrowser wb = (WebBrowser)sender;

            HtmlElementCollection htmlElementCollection = wb.Document.GetElementsByTagName("a");

            foreach(HtmlElement element in htmlElementCollection)
            {
                element.SetAttribute("title", "Prof Schuh for President!");
            }
        }

        private void BenjaminHarrison__CheckedChanged(object sender, EventArgs e)
        {
            this.pictureBox1.Image = Properties.Resources.BenjaminHarrison;
            this.presidentGroupBox.Text = "https://en.m.wikipedia.org/wiki/Benjamin_Harrison";
            this.webBrowser1.Navigate("https://en.m.wikipedia.org/wiki/Benjamin_Harrison");

        }
        private void FranklinDRooseveltButton__CheckedChanged(object sender, EventArgs e)
        {
            this.pictureBox1.Image = Properties.Resources.FranklinDRoosevelt;
            this.presidentGroupBox.Text = "https://en.m.wikipedia.org/wiki/Franklin_D._Roosevelt";
            this.webBrowser1.Navigate("https://en.m.wikipedia.org/wiki/Franklin_D._Roosevelt");
        }
        private void WilliamJClintonButton__CheckedChanged(object sender, EventArgs e)
        {
            this.pictureBox1.Image = Properties.Resources.WilliamJClinton;
            this.presidentGroupBox.Text = "https://en.m.wikipedia.org/wiki/Bill_Clinton";
            this.webBrowser1.Navigate("https://en.m.wikipedia.org/wiki/Bill_Clinton");
        }

        private void JamesBuchananButton__CheckedChanged(object sender, EventArgs e)
        {
            this.pictureBox1.Image = Properties.Resources.JamesBuchanan;
            this.presidentGroupBox.Text = "https://en.m.wikipedia.org/wiki/James_Buchanan";
            this.webBrowser1.Navigate("https://en.m.wikipedia.org/wiki/James_Buchanan");
        }

        private void FranklinkPierceButton__CheckedChanged(object sender, EventArgs e)
        {
            this.pictureBox1.Image = Properties.Resources.FranklinPierce;
            this.presidentGroupBox.Text = "https://en.m.wikipedia.org/wiki/Franklin_Pierce";
            this.webBrowser1.Navigate("https://en.m.wikipedia.org/wiki/Franklin_Pierce");
        }

        private void GeorgeWBushButton__CheckedChanged(object sender, EventArgs e)
        {
            this.pictureBox1.Image = Properties.Resources.GeorgeWBush;
            this.presidentGroupBox.Text = "https://en.m.wikipedia.org/wiki/George_W._Bush";
            this.webBrowser1.Navigate("https://en.m.wikipedia.org/wiki/George_W._Bush");
        }

        private void BarackObamaButton__CheckedChanged(object sender, EventArgs e)
        {
            this.pictureBox1.Image = Properties.Resources.BarackObama;
            this.presidentGroupBox.Text = "https://en.m.wikipedia.org/wiki/Michelle_Obama";
            this.webBrowser1.Navigate("https://en.m.wikipedia.org/wiki/Michelle_Obama");
        }

        private void JohnFKennedyButton__CheckedChanged(object sender, EventArgs e)
        {
            this.pictureBox1.Image = Properties.Resources.JohnFKennedy;
            this.presidentGroupBox.Text = "https://en.m.wikipedia.org/wiki/John_F._Kennedy_International_Airport";
            this.webBrowser1.Navigate("https://en.m.wikipedia.org/wiki/John_F._Kennedy_International_Airport");
        }

        private void WilliamMcKinleyButton__CheckedChanged(object sender, EventArgs e)
        {
            this.pictureBox1.Image = Properties.Resources.WilliamMcKinley;
            this.presidentGroupBox.Text = "https://en.m.wikipedia.org/wiki/William_McKinley_Sr.";
            this.webBrowser1.Navigate("https://en.m.wikipedia.org/wiki/William_McKinley_Sr.");
        }

        private void RonaldReaganButton__CheckedChanged(object sender, EventArgs e)
        {
            this.pictureBox1.Image = Properties.Resources.RonaldReagan;
            this.presidentGroupBox.Text = "https://en.m.wikipedia.org/wiki/Ronald_Reagan";
            this.webBrowser1.Navigate("https://en.m.wikipedia.org/wiki/Ronald_Reagan");
        }

        private void DwightDEisenhowerButton__CheckedChanged(object sender, EventArgs e)
        {
            this.pictureBox1.Image = Properties.Resources.DwightDEisenhower;
            this.presidentGroupBox.Text = "https://en.m.wikipedia.org/wiki/Dwight_D._Eisenhower";
            this.webBrowser1.Navigate("https://en.m.wikipedia.org/wiki/Dwight_D._Eisenhower");
        }

        private void MartinVanBurenButton__CheckedChanged(object sender, EventArgs e)
        {
            this.pictureBox1.Image = Properties.Resources.MartinVanBuren;
            this.presidentGroupBox.Text = "https://en.m.wikipedia.org/wiki/Martin_VanBuren";
            this.webBrowser1.Navigate("https://en.m.wikipedia.org/wiki/Martin_VanBuren");
        }

        private void GeorgeWashingtonButton__CheckedChanged(object sender, EventArgs e)
        {
            this.pictureBox1.Image = Properties.Resources.GeorgeWashington;
            this.presidentGroupBox.Text = "https://en.m.wikipedia.org/wiki/George_Washington_Carver";
            this.webBrowser1.Navigate("https://en.m.wikipedia.org/wiki/George_Washington_Carver");
        }

        private void JohnAdamsButton__CheckedChanged(object sender, EventArgs e)
        {
            this.pictureBox1.Image = Properties.Resources.JohnAdams;
            this.presidentGroupBox.Text = "https://en.m.wikipedia.org/wiki/John_Adams";
            this.webBrowser1.Navigate("https://en.m.wikipedia.org/wiki/John_Adams");
        }

        private void TheodoreRooseveltButton__CheckedChanged(object sender, EventArgs e)
        {
            this.pictureBox1.Image = Properties.Resources.TheodoreRoosevelt;
            this.presidentGroupBox.Text = "https://en.m.wikipedia.org/wiki/Teddy_Bear";
            this.webBrowser1.Navigate("https://en.m.wikipedia.org/wiki/Teddy_Bear");
        }

        private void ThomasJeffersonButton__CheckedChanged(object sender, EventArgs e)
        {
            this.pictureBox1.Image = Properties.Resources.ThomasJefferson;
            this.presidentGroupBox.Text = "https://en.m.wikipedia.org/wiki/Thomas_Jefferson";
            this.webBrowser1.Navigate("https://en.m.wikipedia.org/wiki/Thomas_Jefferson");
        }

        private void AllRadioButton__CheckedChanged(object sender, EventArgs e)
        {
            //make all visible
            this.benjaminHarrisonButton.Visible = true;
            this.franklinDRooseveltButton.Visible = true;
            this.williamJClintonButton.Visible = true;
            this.jamesBuchananButton.Visible = true;
            this.franklinPierceButton.Visible = true;
            this.georgeWBushButton.Visible = true;
            this.barackObamaButton.Visible = true;
            this.johnFKennedyButton.Visible = true;
            this.williamMcKinleyButton.Visible = true;
            this.ronaldReaganButton.Visible = true;
            this.dwightDEisenhowerButton.Visible = true;
            this.martinVanBurenButton.Visible = true;
            this.georgeWashingtonButton.Visible = true;    
            this.johnAdamsButton.Visible = true;
            this.theodoreRooseveltButton.Visible = true;
            this.thomasJeffersonButton.Visible = true;
        }

        private void RepublicanRadioButton__CheckedChanged(object sender, EventArgs e)
        {
            //make invisible
            this.franklinDRooseveltButton.Visible = false;
            this.williamJClintonButton.Visible = false;
            this.jamesBuchananButton.Visible = false;
            this.franklinPierceButton.Visible = false;
            this.barackObamaButton.Visible = false;
            this.johnFKennedyButton.Visible = false;
            this.martinVanBurenButton.Visible = false;
            this.georgeWashingtonButton.Visible = false;
            this.johnAdamsButton.Visible = false;
            this.thomasJeffersonButton.Visible = false;

            //make visible
            this.benjaminHarrisonButton.Visible = true;
            this.georgeWBushButton.Visible = true;
            this.williamMcKinleyButton.Visible = true;
            this.ronaldReaganButton.Visible = true;
            this.dwightDEisenhowerButton.Visible = true;
            this.theodoreRooseveltButton.Visible = true;

        }

        private void DemocratRadioButton__CheckedChanged(object sender, EventArgs e)
        {
            //make invisible
            this.benjaminHarrisonButton.Visible = false;
            this.georgeWBushButton.Visible = false;
            this.williamMcKinleyButton.Visible = false;
            this.ronaldReaganButton.Visible = false;
            this.dwightDEisenhowerButton.Visible = false;
            this.theodoreRooseveltButton.Visible = false;
            this.georgeWashingtonButton.Visible = false;
            this.johnAdamsButton.Visible = false;
            this.thomasJeffersonButton.Visible = false;

            //make visible
            this.franklinDRooseveltButton.Visible = true;
            this.williamJClintonButton.Visible = true;
            this.jamesBuchananButton.Visible = true;
            this.franklinPierceButton.Visible = true;
            this.barackObamaButton.Visible = true;
            this.johnFKennedyButton.Visible = true;
            this.martinVanBurenButton.Visible = true;
        }

        private void DemocratRepublicanRadioButton__CheckedChanged(object sender, EventArgs e)
        {
            //make visible
            this.thomasJeffersonButton.Visible = true;

            //make invisible
            this.franklinDRooseveltButton.Visible = false;
            this.williamJClintonButton.Visible = false;
            this.jamesBuchananButton.Visible = false;
            this.franklinPierceButton.Visible = false;
            this.barackObamaButton.Visible = false;
            this.johnFKennedyButton.Visible = false;
            this.martinVanBurenButton.Visible = false;
            this.georgeWashingtonButton.Visible = false;
            this.benjaminHarrisonButton.Visible = false;
            this.georgeWBushButton.Visible = false;
            this.williamMcKinleyButton.Visible = false;
            this.ronaldReaganButton.Visible = false;
            this.dwightDEisenhowerButton.Visible = false;
            this.theodoreRooseveltButton.Visible = false;
            this.georgeWashingtonButton.Visible = false;
            this.johnAdamsButton.Visible = false;
        }

        private void FederalistRadioButton__CheckedChanged(object sender, EventArgs e)
        {
            //make visible
            this.georgeWashingtonButton.Visible = true;
            this.johnAdamsButton.Visible = true;

            //make invisible
            this.franklinDRooseveltButton.Visible = false;
            this.williamJClintonButton.Visible = false;
            this.jamesBuchananButton.Visible = false;
            this.franklinPierceButton.Visible = false;
            this.barackObamaButton.Visible = false;
            this.johnFKennedyButton.Visible = false;
            this.martinVanBurenButton.Visible = false;
            this.georgeWBushButton.Visible = false;
            this.benjaminHarrisonButton.Visible = false;
            this.williamMcKinleyButton.Visible = false;
            this.ronaldReaganButton.Visible = false;
            this.dwightDEisenhowerButton.Visible = false;
            this.theodoreRooseveltButton.Visible = false;
            this.thomasJeffersonButton.Visible = false;
        }

        private void PictureBox1__MouseEnter(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;

            pb.Height *= 3;
            pb.Width *= 3;
        }

        private void PictureBox1__MouseLeave(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;

            pb.Height /= 4;
            pb.Width /= 4;
        }

        private void ExitButton__Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
