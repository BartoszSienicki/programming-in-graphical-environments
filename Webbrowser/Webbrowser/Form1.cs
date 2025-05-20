using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Webbrowser
{
    public partial class Form1 : Form
    {
        private List<string> history = new List<string>();
        public Form1()
        {
            InitializeComponent();
            webBrowser.ScriptErrorsSuppressed = true;
            webBrowser.DocumentCompleted += WebBrowser_DocumentCompleted;
        }
        private void btnBack_Click(object sender, EventArgs e) => webBrowser.GoBack();
        private void btnForward_Click(object sender, EventArgs e) => webBrowser.GoForward();
        private void BtnHome_Click(object sender, EventArgs e) => webBrowser.GoHome();
        private void btnRefresh_Click(object sender, EventArgs e) => webBrowser.Refresh();
        private void ComboBoxUrl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                NavigateToUrl(comboBoxUrl.Text);
            }
        }
        private void NavigateToUrl(string url)
        {
            if (!url.StartsWith("http://") && !url.StartsWith("https://"))
                url = "http://" + url;

            webBrowser.Navigate(url);
        }

        
        private void WebBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            comboBoxUrl.Text = webBrowser.Url.ToString();

            if (!history.Contains(webBrowser.Url.ToString()))
            {
                history.Add(webBrowser.Url.ToString());
                comboBoxUrl.Items.Add(webBrowser.Url.ToString());
            }

            textBoxHtml.Text = webBrowser.DocumentText;
            toolStripStatusLabel.Text = "Ready";
        }
        private void comboBoxUrl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string url = comboBoxUrl.Text;
                if (!url.StartsWith("http"))
                {
                    url = "https://" + url;
                }
                webBrowser.Navigate(url);
            }
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            webBrowser.Navigate("https://www.google.pl");
        }


        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

    }
}
