using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Test
{
    internal class TestButton:Button
    {
        private Color _onColor = Color.Black;
        private Color _offColor = Color.Violet;
        private bool _enable;


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

        public TestButton(Point position, Size size, string texr)
        {
            Location = position;
            Size = size;
            Text = Text;

            SetEnable(false);

            Click += ClickEvent;
        }

        // 自分で作成することも可能
        private void ClickEvent(object sender, EventArgs e)
        {
            SetEnable(!_enable);
        }

    }
}
