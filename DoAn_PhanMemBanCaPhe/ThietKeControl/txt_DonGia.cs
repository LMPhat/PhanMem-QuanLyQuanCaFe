using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThietKeControl
{
    public class txt_DonGia : TextBox
    {
        public txt_DonGia()
        {
            this.KeyPress += txt_DonGia_KeyPress;
        }

        private void txt_DonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Kiểm tra xem ký tự nhập vào có phải là số và không phải là ký tự điều khiển
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ngăn chặn ký tự nhập vào nếu không phải là số
            }
        }
    }
}
