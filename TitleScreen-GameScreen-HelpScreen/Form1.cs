using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TitleScreen_GameScreen_HelpScreen
{
    public partial class Form1 : Form
    {
        // below the game screen form is being linked to this form
        gameScreen ingamescreen = new gameScreen();

        // below the help screen form is being linked to this form
        helpScreen inhelpscreen = new helpScreen();

        public Form1()
        {
            InitializeComponent();
        }

        private void startGame(object sender, EventArgs e)
        {
            // since they are linked now we can show them from an event
            ingamescreen.Show();
        }

        private void showHelp(object sender, EventArgs e)
        {
            // since they are linked now we can show them from an event
            inhelpscreen.Show();
        }
    }
}
