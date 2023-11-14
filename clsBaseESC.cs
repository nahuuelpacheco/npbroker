using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prybroker23
{
    public class BaseForm : Form
    {
        public BaseForm()
        {
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(BaseForm_KeyDown);
        }

        private void BaseForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}




