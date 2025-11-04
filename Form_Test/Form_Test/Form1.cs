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

        const int BUTTON_SIZE_X = 100;
        const int BUTTON_SIZE_Y = 100;

        const int BOARD_SIZE_X = 3;
        const int BOARD_SIZE_Y = 3;

        private TestButton[,] buttonArray;

        public Form1()
        { 
            InitializeComponent();
            buttonArray= new TestButton[BOARD_SIZE_Y, BOARD_SIZE_X];


            for (int i = 0; i < BOARD_SIZE_X; i++)
            {
                for (int j = 0; j < BOARD_SIZE_Y; j++)
                {
                    // インスタンスの生成
                    TestButton testButton =
                    new TestButton(this,
                        i,j,
                        new Point(BUTTON_SIZE_X * i, BUTTON_SIZE_Y * j)
                        ,new Size(BUTTON_SIZE_X, BUTTON_SIZE_Y), "A");

                    buttonArray[j, i] = testButton;

                    // ボタンの位置を設定


                    // ボタンの大きさを設定


                    // ボタン内のテキストを設定


                    // Click Eventに　hogehogeClick関数を登録



                    // コントロールにボタンを追加
                    Controls.Add(testButton);
                }
            }

           
           
        }
        public TestButton GetTestButton(int x, int y)
        {
            if (x < 0 || x >= BOARD_SIZE_X) return null;
            if (y < 0 || y >= BOARD_SIZE_Y) return null;


            return buttonArray[y, x];
        }
        



        // 自動生成
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("クリック");
        }
    }
}
