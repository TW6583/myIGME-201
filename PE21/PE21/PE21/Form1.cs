using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PE21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            this.newToolStripMenuItem.Click += new EventHandler(NewToolStripMenu__Click);
            this.openToolStripMenuItem.Click += new EventHandler(OpenToolStripMenu__Click);
            this.saveToolStripMenuItem.Click += new EventHandler(SaveToolStripMenu__Click);
            this.exitToolStripMenuItem.Click += new EventHandler(ExitToolStripMenu__Click);

            this.copyToolStripMenuItem.Click += new EventHandler(CopyToolStripMenu__Click);
            this.cutToolStripMenuItem.Click += new EventHandler(CutToolStripMenu__Click);
            this.pasteToolStripMenuItem.Click += new EventHandler(PasteToolStripMenu__Click);

            this.toolStrip.ItemClicked += new ToolStripItemClickedEventHandler(ToolStrip__ItemClicked);



            this.Text = "MyEditor";

        }

        private void NewToolStripMenu__Click(object sender, EventArgs e)
        {
            richTextBox.Clear();
            this.Text = "MyEditor";
        }

        private void OpenToolStripMenu__Click(object sender, EventArgs e)
        {
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

        private void SaveToolStripMenu__Click(object sender, EventArgs e)
        {
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

        private void ExitToolStripMenu__Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CopyToolStripMenu__Click(object sender, EventArgs e)
        {
            richTextBox.Copy();
        }

        private void CutToolStripMenu__Click(object sender, EventArgs e)
        {
            richTextBox.Cut();
        }

        private void PasteToolStripMenu__Click(object sender, EventArgs e)
        {
            richTextBox.Paste();
        }

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
    }
}
