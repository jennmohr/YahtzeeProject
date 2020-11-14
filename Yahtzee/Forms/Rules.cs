// Jennifer Mohr & Nazmun Nahar
// CIS 3309 Section 001
// Sunday, April 5th, 2020
// Game Project - Yahtzee Game

// Rules Form 
// Form that gives the users an overview of the game and allows them to access more specific rule forms for the upper
// and lower sections

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
    public partial class Rules : Form
    {
        public Rules()
        {
            InitializeComponent();
        }

        // Event handler for the Upper Section button, opens up the rules for the upper section
        private void btnUpperSection_Click(object sender, EventArgs e)
        {
            UpperForm upper = new UpperForm();
            upper.ShowDialog();
        }

        // Event handler for the Lower Section button, opens up the rules for the lower section
        private void btnLowerSection_Click(object sender, EventArgs e)
        {
            LowerSectionForm lower = new LowerSectionForm();
            lower.ShowDialog();
        }

        // Event handler for the Back button, closes the rule form
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
