using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB5OOP
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Creature Person = new Creature(textBox1.Text,100,60,1000," ");
            Person.Cname = textBox1.Text;
            Main newForm = new Main(Person.Cname,Person.Chealth,Person.Cmoney,Person.Cinventory);
            newForm.Show();
            

        }
    }
}
