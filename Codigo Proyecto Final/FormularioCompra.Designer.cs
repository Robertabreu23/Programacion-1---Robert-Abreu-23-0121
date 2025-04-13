namespace TiendaDeLibros
{
    partial class FormularioCompra
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.CheckBox chk1;
        private System.Windows.Forms.CheckBox chk2;
        private System.Windows.Forms.CheckBox chk3;
        private System.Windows.Forms.CheckBox chk4;
        private System.Windows.Forms.CheckBox chk5;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lblTotal;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.chk1 = new System.Windows.Forms.CheckBox();
            this.chk2 = new System.Windows.Forms.CheckBox();
            this.chk3 = new System.Windows.Forms.CheckBox();
            this.chk4 = new System.Windows.Forms.CheckBox();
            this.chk5 = new System.Windows.Forms.CheckBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();

            string path = System.IO.Path.Combine(System.Windows.Forms.Application.StartupPath, "imagenes");
            this.pictureBox1.ImageLocation = System.IO.Path.Combine(path, "1984.jpg");
            this.pictureBox2.ImageLocation = System.IO.Path.Combine(path, "crimen.jpg");
            this.pictureBox3.ImageLocation = System.IO.Path.Combine(path, "got.jpg");
            this.pictureBox4.ImageLocation = System.IO.Path.Combine(path, "mistborn.jpg");
            this.pictureBox5.ImageLocation = System.IO.Path.Combine(path, "orgullo.jpg");

            System.Windows.Forms.PictureBox[] pbs = { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5 };
            for (int i = 0; i < pbs.Length; i++)
            {
                pbs[i].Size = new System.Drawing.Size(100, 150);
                pbs[i].SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                pbs[i].Location = new System.Drawing.Point(20 + i * 120, 20);
                this.Controls.Add(pbs[i]);
            }

            chk1.Text = "1984 - $10";
            chk2.Text = "Crimen - $12";
            chk3.Text = "GOT - $15";
            chk4.Text = "Mistborn - $13";
            chk5.Text = "Orgullo - $9";

            System.Windows.Forms.CheckBox[] chks = { chk1, chk2, chk3, chk4, chk5 };
            for (int i = 0; i < chks.Length; i++)
            {
                chks[i].Location = new System.Drawing.Point(20 + i * 120, 180);
                this.Controls.Add(chks[i]);
            }

            btnAgregar.Text = "Agregar al carrito";
            btnAgregar.Location = new System.Drawing.Point(650, 50);
            btnAgregar.Size = new System.Drawing.Size(200, 40);
            btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);

            btnFinalizar.Text = "Finalizar compra";
            btnFinalizar.Location = new System.Drawing.Point(650, 100);
            btnFinalizar.Size = new System.Drawing.Size(200, 40);
            btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);

            listBox1.Location = new System.Drawing.Point(650, 160);
            listBox1.Size = new System.Drawing.Size(200, 200);

            lblTotal.Text = "Total: $0";
            lblTotal.Location = new System.Drawing.Point(650, 370);
            lblTotal.Size = new System.Drawing.Size(200, 40);
            lblTotal.Font = new System.Drawing.Font("Segoe UI", 12, System.Drawing.FontStyle.Bold);

            this.Controls.Add(btnAgregar);
            this.Controls.Add(btnFinalizar);
            this.Controls.Add(listBox1);
            this.Controls.Add(lblTotal);

            this.ClientSize = new System.Drawing.Size(900, 450);
            this.Name = "FormularioCompra";
            this.Text = "Tienda de Libros";
            this.ResumeLayout(false);
        }
    }
}
