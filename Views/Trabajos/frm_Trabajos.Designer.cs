
namespace _06Publicaciones.Views.Trabajos
{
    partial class frm_Trabajos
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
            this.lbl_idtrabajo = new System.Windows.Forms.Label();
            this.lbl_descripcion = new System.Windows.Forms.Label();
            this.lbl_nivelmin = new System.Windows.Forms.Label();
            this.lbl_nivelmax = new System.Windows.Forms.Label();
            this.txt_idtrabajo = new System.Windows.Forms.TextBox();
            this.txt_trabajo = new System.Windows.Forms.TextBox();
            this.txt_nivelmin = new System.Windows.Forms.TextBox();
            this.txt_nivelmax = new System.Windows.Forms.TextBox();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.lst_Trabajos = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.Location = new System.Drawing.Point(273, 23);
            this.lbl_Titulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(274, 32);
            this.lbl_Titulo.TabIndex = 0;
            this.lbl_Titulo.Text = "Gestión de Trabajo";
            // 
            // lbl_idtrabajo
            // 
            this.lbl_idtrabajo.AutoSize = true;
            this.lbl_idtrabajo.Location = new System.Drawing.Point(32, 121);
            this.lbl_idtrabajo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_idtrabajo.Name = "lbl_idtrabajo";
            this.lbl_idtrabajo.Size = new System.Drawing.Size(103, 25);
            this.lbl_idtrabajo.TabIndex = 1;
            this.lbl_idtrabajo.Text = "ID Trabajo";
            // 
            // lbl_descripcion
            // 
            this.lbl_descripcion.AutoSize = true;
            this.lbl_descripcion.Location = new System.Drawing.Point(16, 168);
            this.lbl_descripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_descripcion.Name = "lbl_descripcion";
            this.lbl_descripcion.Size = new System.Drawing.Size(119, 25);
            this.lbl_descripcion.TabIndex = 2;
            this.lbl_descripcion.Text = "Descripción ";
            // 
            // lbl_nivelmin
            // 
            this.lbl_nivelmin.AutoSize = true;
            this.lbl_nivelmin.Location = new System.Drawing.Point(12, 218);
            this.lbl_nivelmin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_nivelmin.Name = "lbl_nivelmin";
            this.lbl_nivelmin.Size = new System.Drawing.Size(123, 25);
            this.lbl_nivelmin.TabIndex = 3;
            this.lbl_nivelmin.Text = "Nivel Minimo";
            // 
            // lbl_nivelmax
            // 
            this.lbl_nivelmax.AutoSize = true;
            this.lbl_nivelmax.Location = new System.Drawing.Point(6, 264);
            this.lbl_nivelmax.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_nivelmax.Name = "lbl_nivelmax";
            this.lbl_nivelmax.Size = new System.Drawing.Size(129, 25);
            this.lbl_nivelmax.TabIndex = 4;
            this.lbl_nivelmax.Text = "Nivel Máximo";
            // 
            // txt_idtrabajo
            // 
            this.txt_idtrabajo.Location = new System.Drawing.Point(142, 118);
            this.txt_idtrabajo.Name = "txt_idtrabajo";
            this.txt_idtrabajo.Size = new System.Drawing.Size(245, 30);
            this.txt_idtrabajo.TabIndex = 5;
            // 
            // txt_trabajo
            // 
            this.txt_trabajo.Location = new System.Drawing.Point(142, 168);
            this.txt_trabajo.Name = "txt_trabajo";
            this.txt_trabajo.Size = new System.Drawing.Size(245, 30);
            this.txt_trabajo.TabIndex = 6;
            // 
            // txt_nivelmin
            // 
            this.txt_nivelmin.Location = new System.Drawing.Point(142, 215);
            this.txt_nivelmin.Name = "txt_nivelmin";
            this.txt_nivelmin.Size = new System.Drawing.Size(245, 30);
            this.txt_nivelmin.TabIndex = 7;
            // 
            // txt_nivelmax
            // 
            this.txt_nivelmax.Location = new System.Drawing.Point(142, 264);
            this.txt_nivelmax.Name = "txt_nivelmax";
            this.txt_nivelmax.Size = new System.Drawing.Size(245, 30);
            this.txt_nivelmax.TabIndex = 8;
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_guardar.Location = new System.Drawing.Point(142, 342);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(93, 41);
            this.btn_guardar.TabIndex = 9;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = false;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_limpiar.Location = new System.Drawing.Point(258, 342);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(86, 41);
            this.btn_limpiar.TabIndex = 10;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = false;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // lst_Trabajos
            // 
            this.lst_Trabajos.FormattingEnabled = true;
            this.lst_Trabajos.ItemHeight = 25;
            this.lst_Trabajos.Location = new System.Drawing.Point(423, 118);
            this.lst_Trabajos.Name = "lst_Trabajos";
            this.lst_Trabajos.Size = new System.Drawing.Size(315, 229);
            this.lst_Trabajos.TabIndex = 11;
            this.lst_Trabajos.DoubleClick += new System.EventHandler(this.lst_Trabajos_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(502, 90);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Lista de Trabajos";
            // 
            // frm_Trabajos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(778, 410);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lst_Trabajos);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.txt_nivelmax);
            this.Controls.Add(this.txt_nivelmin);
            this.Controls.Add(this.txt_trabajo);
            this.Controls.Add(this.txt_idtrabajo);
            this.Controls.Add(this.lbl_nivelmax);
            this.Controls.Add(this.lbl_nivelmin);
            this.Controls.Add(this.lbl_descripcion);
            this.Controls.Add(this.lbl_idtrabajo);
            this.Controls.Add(this.lbl_Titulo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frm_Trabajos";
            this.Text = "frm_trabajo";
            this.Load += new System.EventHandler(this.frm_Trabajos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.Label lbl_idtrabajo;
        private System.Windows.Forms.Label lbl_descripcion;
        private System.Windows.Forms.Label lbl_nivelmin;
        private System.Windows.Forms.Label lbl_nivelmax;
        private System.Windows.Forms.TextBox txt_idtrabajo;
        private System.Windows.Forms.TextBox txt_trabajo;
        private System.Windows.Forms.TextBox txt_nivelmin;
        private System.Windows.Forms.TextBox txt_nivelmax;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.ListBox lst_Trabajos;
        private System.Windows.Forms.Label label1;
    }
}