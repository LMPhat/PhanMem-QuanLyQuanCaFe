using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThietKeControl
{
    public class txt_SDT : TextBox
    {
        public txt_SDT()
        {
            this.KeyPress += txt_SDT_KeyPress;
        }

        private void txt_SDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Kiểm tra xem ký tự nhập vào có phải là số và không phải là ký tự điều khiển
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ngăn chặn ký tự nhập vào nếu không phải là số
            }

            // Kiểm tra độ dài của chuỗi, nếu đã nhập đủ 10 số thì ngăn chặn thêm
            TextBox textBox = (TextBox)sender;
            if (textBox.Text.Length >= 10 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
