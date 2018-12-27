
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlourideCare
{
    class validasi
    {
        ErrorProvider eValidasi;
        Control.ControlCollection collection;

        public validasi(Control.ControlCollection ctl, ErrorProvider eValidasi)
        {
            this.collection = ctl;
            this.eValidasi = eValidasi;
        }

        public void clear(String skip)
        {
            foreach(Control ctl in this.collection)
            {
                if (ctl.GetType() == typeof(TextBox) || ctl.GetType() == typeof(RichTextBox))
                {
                    if (ctl.Name == skip) continue;
                    ctl.Text = "";
                }
                else if (ctl.GetType() == typeof(ComboBox))
                    ((ComboBox)ctl).Text = "";
                else if (ctl.GetType() == typeof(NumericUpDown))
                    ((NumericUpDown)ctl).Minimum = 1;
                else if (ctl.GetType() == typeof(DateTimePicker))
                    ((DateTimePicker)ctl).Value = DateTime.Now;
            }
        }

        public bool doValidation()
        {
            foreach(Control ctl in this.collection)
            {
                if(ctl.GetType() == typeof(TextBox))
                {
                    if(String.IsNullOrEmpty(ctl.Text))
                    {
                        MessageBox.Show("Semua harus terisi", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.eValidasi.SetError(ctl, "Tidak boleh kosong");
                        return false;
                    }

                    else
                    {
                        this.eValidasi.SetError(ctl, "");
                    }
                }

                else if(ctl.GetType() == typeof(ComboBox))
                {
                    if(((ComboBox)ctl).SelectedIndex < 0)
                    {
                        MessageBox.Show("Semua harus terisi", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.eValidasi.SetError(ctl, "Tidak boleh kosong");
                        return false;
                    }

                    else
                    {
                        this.eValidasi.SetError(ctl, "");
                    }
                }

                else if(ctl.GetType() == typeof(NumericUpDown))
                {
                    if(String.IsNullOrEmpty(((NumericUpDown)ctl).Value.ToString()) || ((NumericUpDown)ctl).Value == 0)
                    {
                        MessageBox.Show("Semua harus terisi", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.eValidasi.SetError(ctl, "Tidak boleh kosong");
                        return false;
                    }

                    else
                    {
                        this.eValidasi.SetError(ctl, "");
                    }
                }
            }
            return true;
        }

        public void numberFormat(KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if(!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }
    }
}
