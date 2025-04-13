using System;
using System.Windows.Forms;

namespace TiendaDeLibros
{
    public partial class FormularioCompra : Form
    {
        public FormularioCompra()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int total = 0;

            if (chk1.Checked) { listBox1.Items.Add("1984 - $10"); total += 10; }
            if (chk2.Checked) { listBox1.Items.Add("Crimen - $12"); total += 12; }
            if (chk3.Checked) { listBox1.Items.Add("GOT - $15"); total += 15; }
            if (chk4.Checked) { listBox1.Items.Add("Mistborn - $13"); total += 13; }
            if (chk5.Checked) { listBox1.Items.Add("Orgullo - $9"); total += 9; }

            lblTotal.Text = "Total: $" + total;
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gracias por tu compra!", "Compra finalizada");
        }
    }
}
