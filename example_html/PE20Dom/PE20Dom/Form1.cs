using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PE20Dom
{
    public partial class Form1 : Form
    {
        
        readonly WebBrowser webBrowser1 = new WebBrowser();
        
        public Form1()
        {
            
            InitializeComponent();
            try
            {
                Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(@"SOFTWARE\\WOW6432Node\\Microsoft\\Internet Explorer\\MAIN\\FeatureControl\\FEATURE_BROWSER_EMULATION", true);
                key.SetValue(Application.ExecutablePath.Replace(Application.StartupPath+"\\", ""), 12001, Microsoft.Win32.RegistryValueKind.DWord);
                key.Close();
            }
            catch
            {

            }

            // add the delegate method to be called after the webpage loads, set this up before Navigate()
            this.webBrowser1.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(this.WebBrowser1__DocumentCompleted);

            // or if you want to use the URL (only use one of these Navigate() statements)
            this.webBrowser1.Navigate("people.rit.edu/dxsigm/example.html");


        }
        public void WebBrowser1__DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            

            WebBrowser wb = (WebBrowser)sender;

            if (wb.Document.Title == "DOM-3")
            {

                HtmlElementCollection htmlElementCollection;
                HtmlElement htmlElement;

                htmlElementCollection = wb.Document.GetElementsByTagName("h1");
                htmlElement = htmlElementCollection[0];

                htmlElement.InnerText = "My UFO Page";

                htmlElementCollection = wb.Document.GetElementsByTagName("h2");

                htmlElementCollection[0].InnerText = "My UFO Info";
                htmlElementCollection[1].InnerText = "My UFO Pictures";
                htmlElementCollection[2].InnerText = "";

                htmlElement = wb.Document.Body;

                htmlElement.Style += "font-family: sans-serif; color: #a54657";

                htmlElement = wb.Document.GetElementById("firstParagraph");

                htmlElementCollection[0].InnerText = "Report your UFO sightings here <a href=' https://www.nufroc.org'></a>";
                htmlElement.Style += "font-color: green; font-weight: bold; font-size: 2em; text-transform: uppercase; text-shadow: 3px 2px #A44";

                htmlElement = wb.Document.GetElementById("secondParagraph");

                htmlElementCollection[1].InnerText = "";

                htmlElement = wb.Document.GetElementById("thirdParagraph");
                htmlElement.SetAttribute("src", "https://en.wikipedia.org/wiki/Unidentified_flying_object#/media/File:PurportedUFO2.jpg");

                htmlElement = wb.Document.CreateElement("footer");
                htmlElement.InnerHtml = "&copy;2022 <a href='https://en.wikipedia.org/wiki/Unidentified_flying_object' > T. Wu</a>";
            }

        }
    }
}
