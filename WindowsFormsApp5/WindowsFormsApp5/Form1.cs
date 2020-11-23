using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        int datorTal;
        int antal = 0;
        public Form1()
        {
            InitializeComponent();
            Random slump = new Random();
            datorTal = slump.Next(1, 101);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            antal++;
            label1.Text = ("Gissa ett tal mellan 1 och 100");
            int gissning = int.Parse(textBox1.Text);

            if(gissning>datorTal)
            {
                label1.Text = ("Gissa på ett lägre tal!");
            }
            else if(gissning<datorTal)
            {
                label1.Text = ("Gissa på ett högre tal!");
            }
            else
            {
                label1.Text = ("Du gissade rätt tal! Du behövde " + antal + " försök för att gissa rätt!");
            }
        }
    }
}
