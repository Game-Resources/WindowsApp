using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameResources
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            mainWebBrowser.Url = new System.Uri("https://game-resources.github.io/Content/Game/");
        }

        private void gamePageButton_Click(object sender, EventArgs e)
        {
            mainWebBrowser.Url = new System.Uri("https://game-resources.github.io/Content/Game/");
        }

        private void aboutPageButton_Click(object sender, EventArgs e)
        {
            mainWebBrowser.Url = new System.Uri("https://game-resources.github.io/Content/About/");
        }

        private void newsPageButton_Click(object sender, EventArgs e)
        {
            mainWebBrowser.Url = new System.Uri("https://game-resources.github.io/Post/categories/#general");
        }

        private void backToolButton_Click(object sender, EventArgs e)
        {
            mainWebBrowser.GoBack();
        }

        private void forwardToolButton_Click(object sender, EventArgs e)
        {
            mainWebBrowser.GoForward();
        }

        private void mainWebBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (mainWebBrowser.CanGoBack)
            {
                backToolButton.Enabled = true;
            }
            else
            {
                backToolButton.Enabled = false;
            }
            if (mainWebBrowser.CanGoForward)
            {
                forwardToolButton.Enabled = true;
            }
            else
            {
                forwardToolButton.Enabled = false;
            }
        }

        private void settingToolButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("この機能は現在開発中です。");
        }

        private void saveToolButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("この機能は現在開発中です。");
        }

        private void favoriteToolButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("この機能は現在開発中です。");
        }
    }
}
