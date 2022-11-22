﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace PE21
{
    public partial class Form1 : Form
    {
        public Form1(MyEditorParent myEditorParent)
        {
            InitializeComponent();

            //PE23
            this.MdiParent = myEditorParent;

            //PE21
            //this.newToolStripMenuItem.Click += new EventHandler(NewToolStripMenu__Click);
            myEditorParent.openToolStripMenuItem.Click += new EventHandler(OpenToolStripMenu__Click);
            myEditorParent.saveToolStripMenuItem.Click += new EventHandler(SaveToolStripMenu__Click);
            //this.exitToolStripMenuItem.Click += new EventHandler(ExitToolStripMenu__Click);

            myEditorParent.copyToolStripMenuItem.Click += new EventHandler(CopyToolStripMenu__Click);
            myEditorParent.cutToolStripMenuItem.Click += new EventHandler(CutToolStripMenu__Click);
            myEditorParent.pasteToolStripMenuItem.Click += new EventHandler(PasteToolStripMenu__Click);

            myEditorParent.closeAllToolStripMenuItem.Click += new EventHandler(CloseAllToolStripMenuItem__Click);

            this.toolStrip.ItemClicked += new ToolStripItemClickedEventHandler(ToolStrip__ItemClicked);

            //PE22
            this.boldToolStripMenuItem.Click += new EventHandler(BoldToolStripMenuItem__Click);
            this.italicsToolStripMenuItem.Click += new EventHandler(ItalicsToolStripMenuItem__Click);
            this.underlineToolStripMenuItem.Click += new EventHandler(UnderlineToolStripMenuItem__Click);

            this.mSSanSerifToolStripMenuItem.Click += new EventHandler(MSSanSerifToolStripMenuItem__Click);
            this.timesNewRomanToolStripMenuItem.Click += new EventHandler(TimesNewRomanToolStripMenuItem__Click);

            this.richTextBox.SelectionChanged += new EventHandler(RichTextBox__SelectionChanged);

            this.countdownLabel.Visible = false;
            this.timer.Tick += new EventHandler(Timer__Tick);
            this.testToolStripButton.Click += new EventHandler(TestToolStripButton__Click);


            //PE21
            this.Text = "MyEditor";

            this.FormClosing += new FormClosingEventHandler(Form1__FormClosing);
        }

        //PE21
        private void NewToolStripMenu__Click(object sender, EventArgs e)
        {
            richTextBox.Clear();
            this.Text = "MyEditor";
        }

        //PE21
        private void OpenToolStripMenu__Click(object sender, EventArgs e)
        {
            //PE23
            if(this.MdiParent.ActiveMdiChild != this)
            {
                return;
            }


            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                RichTextBoxStreamType richTextBoxStreamType = RichTextBoxStreamType.RichText;

                if (openFileDialog.FileName.ToLower().Contains("*.txt"))
                {
                    richTextBoxStreamType = RichTextBoxStreamType.PlainText;
                }

                richTextBox.LoadFile(openFileDialog.FileName, richTextBoxStreamType);

                this.Text = "MyEditor (" + openFileDialog.FileName + ")";
            }
        }

        //PE21
        private void SaveToolStripMenu__Click(object sender, EventArgs e)
        {
            if (this.MdiParent.ActiveMdiChild != this)
            {
                return;
            }

            saveFileDialog.FileName = openFileDialog.FileName;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                RichTextBoxStreamType richTextBoxStreamType = RichTextBoxStreamType.RichText;

                if (saveFileDialog.FileName.ToLower().Contains("*.txt"))
                {
                    richTextBoxStreamType = RichTextBoxStreamType.PlainText;
                }

                richTextBox.SaveFile(saveFileDialog.FileName, richTextBoxStreamType);

                this.Text = "MyEditor (" + saveFileDialog.FileName + ")";
            }
        }

        //PE21
        private void ExitToolStripMenu__Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //PE21
        private void CopyToolStripMenu__Click(object sender, EventArgs e)
        {
            if (this.MdiParent.ActiveMdiChild != this)
            {
                return;
            }

            richTextBox.Copy();
        }

        //PE21
        private void CutToolStripMenu__Click(object sender, EventArgs e)
        {
            if (this.MdiParent.ActiveMdiChild != this)
            {
                return;
            }

            richTextBox.Cut();
        }

        //PE21
        private void PasteToolStripMenu__Click(object sender, EventArgs e)
        {
            if (this.MdiParent.ActiveMdiChild != this)
            {
                return;
            }

            richTextBox.Paste();
        }

        //PE21
        private void ToolStrip__ItemClicked(object senedr, ToolStripItemClickedEventArgs e)
        {
            FontStyle fontStyle = FontStyle.Regular;

            ToolStripButton toolStripButton = null;

            if (e.ClickedItem == this.boldToolStripButton)
            {
                fontStyle = FontStyle.Bold;
                toolStripButton = this.boldToolStripButton;
            }

            else if (e.ClickedItem == this.italicsToolStripButton)
            {
                fontStyle = FontStyle.Italic;
                toolStripButton = this.italicsToolStripButton;
            }

            else if (e.ClickedItem == this.underlineToolStripButton)
            {
                fontStyle = FontStyle.Underline;
                toolStripButton = this.underlineToolStripButton;
            }

            else if (e.ClickedItem == this.colorToolStripButton)
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    richTextBox.SelectionColor = colorDialog.Color;
                    colorToolStripButton.BackColor = colorDialog.Color;
                }
            }

            if (fontStyle != FontStyle.Regular)
            {
                toolStripButton.Checked = !toolStripButton.Checked;

                SetSelectionFont(fontStyle, toolStripButton.Checked);
            }
        }

        //PE21
        private void SetSelectionFont(FontStyle fontStyle, bool bSet)
        {
            Font newFont = null;
            Font selectionFont = null;

            selectionFont = richTextBox.SelectionFont;
            if (selectionFont == null)
            {
                selectionFont = richTextBox.Font;

            }

            if (bSet)
            {
                newFont = new Font(selectionFont, selectionFont.Style | fontStyle);
            }
            else
            {
                newFont = new Font(selectionFont, selectionFont.Style & ~fontStyle);
            }

            this.richTextBox.SelectionFont = newFont;
        }

        //PE22
        private void BoldToolStripMenuItem__Click(object sender, EventArgs e)
        {
            FontStyle fontStyle = FontStyle.Bold;
            Font selectionFont = null; 

            selectionFont= richTextBox.SelectionFont;

            if (selectionFont == null)
            {
                selectionFont = richTextBox.Font;

            }

            SetSelectionFont(fontStyle, !selectionFont.Bold);

        }

        //PE22
        private void ItalicsToolStripMenuItem__Click(object sender, EventArgs e)
        {
            FontStyle fontStyle = FontStyle.Italic;
            Font selectionFont = null;

            selectionFont = richTextBox.SelectionFont;

            if (selectionFont == null)
            {
                selectionFont = richTextBox.Font;

            }

            SetSelectionFont(fontStyle, !selectionFont.Italic);
        }

        //PE22
        private void UnderlineToolStripMenuItem__Click(object sender, EventArgs e)
        {
            FontStyle fontStyle = FontStyle.Underline;
            Font selectionFont = null;

            selectionFont = richTextBox.SelectionFont;

            if (selectionFont == null)
            {
                selectionFont = richTextBox.Font;

            }

            SetSelectionFont(fontStyle, !selectionFont.Underline);
        }

        //PE22
        private void MSSanSerifToolStripMenuItem__Click(object sender, EventArgs e)
        {
            Font newFont = new Font("MS Sans Serif", richTextBox.SelectionFont.Size, richTextBox.SelectionFont.Style);

            richTextBox.SelectionFont = newFont;

        }

        //PE22
        private void TimesNewRomanToolStripMenuItem__Click(object sender, EventArgs e)
        {
            Font newFont = new Font("Times New Roman", richTextBox.SelectionFont.Size, richTextBox.SelectionFont.Style);

            richTextBox.SelectionFont = newFont;
        }

        //PE22
        public void RichTextBox__SelectionChanged(object sender, EventArgs e)
        {
            if (this.richTextBox.SelectionFont == null)
            {
                this.boldToolStripButton.Checked = richTextBox.SelectionFont.Bold;
                this.italicsToolStripButton.Checked = richTextBox.SelectionFont.Italic;
                this.underlineToolStripButton.Checked = richTextBox.SelectionFont.Underline;
            }

            this.colorToolStripButton.BackColor = richTextBox.SelectionColor;
        }

        private void TestToolStripButton__Click(object sender, EventArgs e)
        {
            this.timer.Interval = 500;

            this.toolStripProgressBar.Value = 60;

            this.countdownLabel.Text = "3";
            this.countdownLabel.Visible = true;
            this.richTextBox.Visible = false;

            for (int i = 3; i > 0; i--)
            {
                this.countdownLabel.Text = i.ToString();
                this.Refresh();
                Thread.Sleep(1000);
            }

            this.countdownLabel.Visible = false;
            this.richTextBox.Visible = true;

            this.timer.Start();

        }

        private void Timer__Tick(object sender, EventArgs e)
        {
            --this.toolStripProgressBar.Value;

            if (this.toolStripProgressBar.Value == 0)
            {
                this.timer.Stop();
                

                string performance = "Congratulations! You typed " + Math.Round(this.richTextBox.TextLength  / 30.0, 2) + " letters per second!";
                MessageBox.Show(performance);

            }
        }

        //PE23
        private void CloseAllToolStripMenuItem__Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //PE23
        private void Form1__FormClosing(object sender, FormClosingEventArgs e)
        {
            MyEditorParent myEditorParent = (MyEditorParent)this.MdiParent;

            myEditorParent.openToolStripMenuItem.Click -= new EventHandler(OpenToolStripMenu__Click);
            myEditorParent.saveToolStripMenuItem.Click -= new EventHandler(SaveToolStripMenu__Click);

            myEditorParent.copyToolStripMenuItem.Click -= new EventHandler(CopyToolStripMenu__Click);
            myEditorParent.cutToolStripMenuItem.Click -= new EventHandler(CutToolStripMenu__Click);
            myEditorParent.pasteToolStripMenuItem.Click -= new EventHandler(PasteToolStripMenu__Click);

            myEditorParent.closeAllToolStripMenuItem.Click -= new EventHandler(CloseAllToolStripMenuItem__Click);
        }
    }
}
