using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsTicTacToe
{
    
    public partial class Form2 : Form
    {
        private Form1 f1;
        public Form2(Form1 f1)
        {
            this.f1 = f1;
            InitializeComponent();
        }


        private void OK_Click(object sender, EventArgs e)
        {
            
            f1.SetAIvAI(numGames.Text, seconds.Text);
            this.Close();

        }


    }
}
