
namespace _06Publicaciones.Views.Autores
{
    partial class frm_Autores
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.labelIdAutor = new System.Windows.Forms.Label();
            this.labelApellido = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelTelefono = new System.Windows.Forms.Label();
            this.labelDireccion = new System.Windows.Forms.Label();
            this.labelCiudad = new System.Windows.Forms.Label();
            this.labelEstado = new System.Windows.Forms.Label();
            this.labelCodigoPostal = new System.Windows.Forms.Label();
            this.textBoxIdAutor = new System.Windows.Forms.TextBox();
            this.textBoxApellido = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxTelefono = new System.Windows.Forms.TextBox();
            this.textBoxDireccion = new System.Windows.Forms.TextBox();
            this.textBoxCiudad = new System.Windows.Forms.TextBox();
            this.textBoxEstado = new System.Windows.Forms.TextBox();
            this.textBoxCodigoPostal = new System.Windows.Forms.TextBox();
            this.buttonInsertar = new System.Windows.Forms.Button();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.lst_Autores = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.Location = new System.Drawing.Point(334, 19);
            this.lbl_Titulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(275, 32);
            this.lbl_Titulo.TabIndex = 0;
            this.lbl_Titulo.Text = "Gestión de Autores";
            // 
            // labelIdAutor
            // 
            this.labelIdAutor.AutoSize = true;
            this.labelIdAutor.Location = new System.Drawing.Point(32, 112);
            this.labelIdAutor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelIdAutor.Name = "labelIdAutor";
            this.labelIdAutor.Size = new System.Drawing.Size(89, 25);
            this.labelIdAutor.TabIndex = 0;
            this.labelIdAutor.Text = "ID Autor:";
            // 
            // labelApellido
            // 
            this.labelApellido.AutoSize = true;
            this.labelApellido.Location = new System.Drawing.Point(32, 159);
            this.labelApellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelApellido.Name = "labelApellido";
            this.labelApellido.Size = new System.Drawing.Size(88, 25);
            this.labelApellido.TabIndex = 1;
            this.labelApellido.Text = "Apellido:";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(32, 206);
            this.labelNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(87, 25);
            this.labelNombre.TabIndex = 2;
            this.labelNombre.Text = "Nombre:";
            // 
            // labelTelefono
            // 
            this.labelTelefono.AutoSize = true;
            this.labelTelefono.Location = new System.Drawing.Point(32, 253);
            this.labelTelefono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTelefono.Name = "labelTelefono";
            this.labelTelefono.Size = new System.Drawing.Size(95, 25);
            this.labelTelefono.TabIndex = 3;
            this.labelTelefono.Text = "Teléfono:";
            // 
            // labelDireccion
            // 
            this.labelDireccion.AutoSize = true;
            this.labelDireccion.Location = new System.Drawing.Point(32, 300);
            this.labelDireccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDireccion.Name = "labelDireccion";
            this.labelDireccion.Size = new System.Drawing.Size(99, 25);
            this.labelDireccion.TabIndex = 4;
            this.labelDireccion.Text = "Dirección:";
            // 
            // labelCiudad
            // 
            this.labelCiudad.AutoSize = true;
            this.labelCiudad.Location = new System.Drawing.Point(32, 347);
            this.labelCiudad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCiudad.Name = "labelCiudad";
            this.labelCiudad.Size = new System.Drawing.Size(81, 25);
            this.labelCiudad.TabIndex = 5;
            this.labelCiudad.Text = "Ciudad:";
            // 
            // labelEstado
            // 
            this.labelEstado.AutoSize = true;
            this.labelEstado.Location = new System.Drawing.Point(32, 393);
            this.labelEstado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEstado.Name = "labelEstado";
            this.labelEstado.Size = new System.Drawing.Size(79, 25);
            this.labelEstado.TabIndex = 6;
            this.labelEstado.Text = "Estado:";
            // 
            // labelCodigoPostal
            // 
            this.labelCodigoPostal.AutoSize = true;
            this.labelCodigoPostal.Location = new System.Drawing.Point(13, 439);
            this.labelCodigoPostal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCodigoPostal.Name = "labelCodigoPostal";
            this.labelCodigoPostal.Size = new System.Drawing.Size(140, 25);
            this.labelCodigoPostal.TabIndex = 7;
            this.labelCodigoPostal.Text = "Código Postal:";
            // 
            // textBoxIdAutor
            // 
            this.textBoxIdAutor.Location = new System.Drawing.Point(152, 108);
            this.textBoxIdAutor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxIdAutor.Name = "textBoxIdAutor";
            this.textBoxIdAutor.Size = new System.Drawing.Size(298, 30);
            this.textBoxIdAutor.TabIndex = 8;
            // 
            // textBoxApellido
            // 
            this.textBoxApellido.Location = new System.Drawing.Point(152, 154);
            this.textBoxApellido.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxApellido.Name = "textBoxApellido";
            this.textBoxApellido.Size = new System.Drawing.Size(298, 30);
            this.textBoxApellido.TabIndex = 9;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(152, 201);
            this.textBoxNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(298, 30);
            this.textBoxNombre.TabIndex = 10;
            // 
            // textBoxTelefono
            // 
            this.textBoxTelefono.Location = new System.Drawing.Point(152, 248);
            this.textBoxTelefono.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxTelefono.Name = "textBoxTelefono";
            this.textBoxTelefono.Size = new System.Drawing.Size(298, 30);
            this.textBoxTelefono.TabIndex = 11;
            // 
            // textBoxDireccion
            // 
            this.textBoxDireccion.Location = new System.Drawing.Point(152, 295);
            this.textBoxDireccion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxDireccion.Name = "textBoxDireccion";
            this.textBoxDireccion.Size = new System.Drawing.Size(298, 30);
            this.textBoxDireccion.TabIndex = 12;
            // 
            // textBoxCiudad
            // 
            this.textBoxCiudad.Location = new System.Drawing.Point(152, 342);
            this.textBoxCiudad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxCiudad.Name = "textBoxCiudad";
            this.textBoxCiudad.Size = new System.Drawing.Size(298, 30);
            this.textBoxCiudad.TabIndex = 13;
            // 
            // textBoxEstado
            // 
            this.textBoxEstado.Location = new System.Drawing.Point(152, 389);
            this.textBoxEstado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxEstado.Name = "textBoxEstado";
            this.textBoxEstado.Size = new System.Drawing.Size(298, 30);
            this.textBoxEstado.TabIndex = 14;
            // 
            // textBoxCodigoPostal
            // 
            this.textBoxCodigoPostal.Location = new System.Drawing.Point(152, 436);
            this.textBoxCodigoPostal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxCodigoPostal.Name = "textBoxCodigoPostal";
            this.textBoxCodigoPostal.Size = new System.Drawing.Size(298, 30);
            this.textBoxCodigoPostal.TabIndex = 15;
            // 
            // buttonInsertar
            // 
            this.buttonInsertar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonInsertar.Location = new System.Drawing.Point(152, 487);
            this.buttonInsertar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonInsertar.Name = "buttonInsertar";
            this.buttonInsertar.Size = new System.Drawing.Size(112, 36);
            this.buttonInsertar.TabIndex = 16;
            this.buttonInsertar.Text = "Guardar";
            this.buttonInsertar.UseVisualStyleBackColor = false;
            this.buttonInsertar.Click += new System.EventHandler(this.ButtonInsertar_Click);
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonLimpiar.Location = new System.Drawing.Point(340, 487);
            this.buttonLimpiar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(112, 36);
            this.buttonLimpiar.TabIndex = 17;
            this.buttonLimpiar.Text = "Limpiar";
            this.buttonLimpiar.UseVisualStyleBackColor = false;
            this.buttonLimpiar.Click += new System.EventHandler(this.ButtonLimpiar_Click);
            // 
            // lst_Autores
            // 
            this.lst_Autores.FormattingEnabled = true;
            this.lst_Autores.ItemHeight = 25;
            this.lst_Autores.Location = new System.Drawing.Point(523, 112);
            this.lst_Autores.Name = "lst_Autores";
            this.lst_Autores.Size = new System.Drawing.Size(413, 354);
            this.lst_Autores.TabIndex = 18;
            this.lst_Autores.SelectedIndexChanged += new System.EventHandler(this.lst_Autores_SelectedIndexChanged);
            this.lst_Autores.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(655, 84);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "Lista de Autores";
            // 
            // frm_Autores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1046, 591);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lst_Autores);
            this.Controls.Add(this.lbl_Titulo);
            this.Controls.Add(this.buttonInsertar);
            this.Controls.Add(this.buttonLimpiar);
            this.Controls.Add(this.textBoxCodigoPostal);
            this.Controls.Add(this.textBoxEstado);
            this.Controls.Add(this.textBoxCiudad);
            this.Controls.Add(this.textBoxDireccion);
            this.Controls.Add(this.textBoxTelefono);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.textBoxApellido);
            this.Controls.Add(this.textBoxIdAutor);
            this.Controls.Add(this.labelCodigoPostal);
            this.Controls.Add(this.labelEstado);
            this.Controls.Add(this.labelCiudad);
            this.Controls.Add(this.labelDireccion);
            this.Controls.Add(this.labelTelefono);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.labelApellido);
            this.Controls.Add(this.labelIdAutor);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frm_Autores";
            this.Text = "Insertar Autor";
            this.Load += new System.EventHandler(this.frm_Autores_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Titulo;
       
        private System.Windows.Forms.Label labelIdAutor;
        private System.Windows.Forms.Label labelApellido;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelTelefono;
        private System.Windows.Forms.Label labelDireccion;
        private System.Windows.Forms.Label labelCiudad;
        private System.Windows.Forms.Label labelEstado;
        private System.Windows.Forms.Label labelCodigoPostal;
        private System.Windows.Forms.TextBox textBoxIdAutor;
        private System.Windows.Forms.TextBox textBoxApellido;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxTelefono;
        private System.Windows.Forms.TextBox textBoxDireccion;
        private System.Windows.Forms.TextBox textBoxCiudad;
        private System.Windows.Forms.TextBox textBoxEstado;
        private System.Windows.Forms.TextBox textBoxCodigoPostal;
        private System.Windows.Forms.Button buttonInsertar;
        private System.Windows.Forms.Button buttonLimpiar;
        private System.Windows.Forms.ListBox lst_Autores;
        private System.Windows.Forms.Label label1;
    }
}