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
    public partial class ManageFlashCards : Form
    {
        public ManageFlashCards()
        {
            InitializeComponent();
        }

        private void manageCategoriesButton_Click(object sender, EventArgs e)
        {
            ManageCategories manageCategories = new ManageCategories();
            manageCategories.Show();
        }
    }
}
