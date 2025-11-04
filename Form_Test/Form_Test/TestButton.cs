using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Test
{
    public class TestButton:Button
    {
        private Color _onColor = Color.Black;
        private Color _offColor = Color.Violet;
        private bool _enable;

        private Form1 _form1;

        private int _x;

        private int _y;



        public void SetEnable(bool on)
        {
            _enable = on;
            
            if(on)
            {
                BackColor = _onColor;
            }
            else
            {
                BackColor = _offColor;
            }
        }

        public TestButton(Form1 form1,int x,int y,Point position, Size size, string texr)
        {
            _form1 = form1;

            _x = x;
            _y = y;
            

            Location = position;
            Size = size;
            Text = Text;

            SetEnable(false);

            Click += ClickEvent;
        }

        // 自分で作成することも可能
        private void ClickEvent(object sender, EventArgs e)
        {
            _form1.GetTestButton(_x, _y).SetEnable(true);
        }

    }
}
