using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlashCards
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void answer_Click(object sender, EventArgs e)
        {

        }

        private void question_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.MessageLoop)
            {
                // WinForms app
                Application.Exit();
            }
            else
            {
                // Console app
                Environment.Exit(1);
            }
        }

        private void manageFlashCardRecordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageFlashCards manageFlashCards = new ManageFlashCards();
            manageFlashCards.Show();
        }
    }
}
