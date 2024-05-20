using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aplikasi_massa
{
    public partial class AplikasiKonversiMassa : Form
    {
        public AplikasiKonversiMassa()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            txtNilai.Text = "";
            cmbDari.Text = "";
            cmbKe.Text = "";
            txtHasil.Text = "";
        }

        private void txtHasil_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void btnHitung_Click(object sender, EventArgs e)
        {
            if (cmbDari.Text == "Select Unit" || cmbKe.Text == "Select Unit")
            {
                MessageBox.Show("Harap Pilih Untuk di Konversi");
            }
            {
                if (cmbDari.SelectedItem == "Ton" && cmbKe.SelectedItem == "Kilogram" )
                {
                    txtHasil.Text = Convert.ToString(Convert.ToDouble(txtNilai.Text) * 1000);
                }
                else if (cmbDari.SelectedItem == "Kilogram" && cmbKe.SelectedItem == "Ton")
                {
                    txtHasil.Text = Convert.ToString(Convert.ToDouble(txtNilai.Text) / 1000);
                }
                else if (cmbDari.SelectedItem == "Ton" && cmbKe.SelectedItem == "Gram")
                {
                    txtHasil.Text = Convert.ToString(Convert.ToDouble(txtNilai.Text) * (1000 * 1000));
                }
                else if (cmbDari.SelectedItem == "Gram" && cmbKe.SelectedItem == "Ton")
                {
                    txtHasil.Text = Convert.ToString(Convert.ToDouble(txtNilai.Text) / (1000 * 1000));
                }
                 else if (cmbDari.SelectedItem == "Ton" && cmbKe.SelectedItem == "Ons")
                {
                    txtHasil.Text = Convert.ToString(Convert.ToDouble(txtNilai.Text) * 35273.96195);
                }
                else if (cmbDari.SelectedItem == "Ons" && cmbKe.SelectedItem == "Ton")
                {
                    txtHasil.Text = Convert.ToString(Convert.ToDouble(txtNilai.Text) / 35273.96195);
                }
                else if (cmbDari.SelectedItem == "Kilogram" && cmbKe.SelectedItem == "Gram")
                {
                    txtHasil.Text = Convert.ToString(Convert.ToDouble(txtNilai.Text) * 1000);
                }
                else if (cmbDari.SelectedItem == "Gram" && cmbKe.SelectedItem == "Kilogram")
                {
                    txtHasil.Text = Convert.ToString(Convert.ToDouble(txtNilai.Text) / 1000);
                }
                else if (cmbDari.SelectedItem == "Kilogram" && cmbKe.SelectedItem == "Ons")
                {
                    txtHasil.Text = Convert.ToString(Convert.ToDouble(txtNilai.Text) * 35.27396);
                }
                else if (cmbDari.SelectedItem == "Ons" && cmbKe.SelectedItem == "Kilogram")
                {
                    txtHasil.Text = Convert.ToString(Convert.ToDouble(txtNilai.Text) * 0.0283495 );
                }
                else if (cmbDari.SelectedItem == "Gram" && cmbKe.SelectedItem == "Ons")
                {
                    txtHasil.Text = Convert.ToString(Convert.ToDouble(txtNilai.Text) * 0.03527396);
                }
                else if (cmbDari.SelectedItem == "Ons" && cmbKe.SelectedItem == "Gram")
                {
                    txtHasil.Text = Convert.ToString(Convert.ToDouble(txtNilai.Text) * 28.3495 );                                                                    
                }
            }
        }

        private void txtNilai_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
