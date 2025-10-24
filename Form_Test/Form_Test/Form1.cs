using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


            for (int i = 0; i < 6; i++)


            {
                for (int j = 0; j < 4; j++)
                {


                    TestButton testButton = new TestButton();

                    Controls.Add(testButton);

                    testButton.Location = new Point(50 * i, j * 50);

                    testButton.Size = new Size( 50 ,30 );

                    testButton.Text = "AAAAA";

                }
            }


        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            MessageBox.Show("c#の世界へようこそ!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("C#の世界");
        }
    }
}
