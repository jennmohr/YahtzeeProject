// Jennifer Mohr & Nazmun Nahar
// CIS 3309 Section 001
// Sunday, April 5th, 2020
// Game Project - Yahtzee Game

// Lower Section Form 
// Form that shows the rules for the lower section of the Yahtzee card

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yahtzee
{
    public partial class LowerSectionForm : Form
    {
        public LowerSectionForm()
        {
            InitializeComponent();
        }

 
        // Event handler for the exit button that exits the form
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
