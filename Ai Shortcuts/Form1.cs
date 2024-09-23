using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Ai_Shortcuts
{
    public partial class Ai_Shortcuts : Form
    {
        public Ai_Shortcuts()
        {
            InitializeComponent();
        }

        //Chatbots
        private void openChatGPT_Click(object sender, EventArgs e)
        {
            string url = "https://chatgpt.com/"; // The URL you want to open
            OpenUrl(url);
        }

        private void openGemini_Click(object sender, EventArgs e)
        {
            string url = "https://gemini.google.com/app"; // The URL you want to open
            OpenUrl(url);
        }

        private void openClaude_Click(object sender, EventArgs e)
        {
            string url = "https://claude.ai/new"; // The URL you want to open
            OpenUrl(url);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string url = "https://www.perplexity.ai/"; // The URL you want to open
            OpenUrl(url);
        }

        //Art Generators
        private void openMidjourney_Click(object sender, EventArgs e)
        {
            string url = "https://www.midjourney.com/explore?tab=top"; // The URL you want to open
            OpenUrl(url);
        }

        //Music Generators
        private void openSunoAi_Click(object sender, EventArgs e)
        {
            string url = "https://suno.com/"; // The URL you want to open
            OpenUrl(url);
        }

        //Ai Apps
        private void openFuturepedia_Click(object sender, EventArgs e)
        {
            string url = "https://www.futurepedia.io/"; // The URL you want to open
            OpenUrl(url);
        }

        // Method to open the URL
        public void OpenUrl(string url)
        {
            try
            {
                Process.Start(new ProcessStartInfo("cmd", $"/c start {url}") { CreateNoWindow = true });
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
    }
}
