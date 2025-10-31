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

        public TestButton(Point position, Size size, string texr)
        {
            Location = position;
            Size = size;
            Text = Text;

            Click += ClickEvent;
        }

        // 自分で作成することも可能
        private void ClickEvent(object sender, EventArgs e)
        {
            MessageBox.Show("くりっくされてしまいました");
        }

    }
}
