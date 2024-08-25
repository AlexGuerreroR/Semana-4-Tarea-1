
namespace _06Publicaciones.Views.Empleados
{
    partial class frm_empleados
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_empid = new System.Windows.Forms.Label();
            this.lbl_fname = new System.Windows.Forms.Label();
            this.lbl_minit = new System.Windows.Forms.Label();
            this.lbl_lname = new System.Windows.Forms.Label();
            this.lbl_jobid = new System.Windows.Forms.Label();
            this.lbl_joblvl = new System.Windows.Forms.Label();
            this.lbl_pubid = new System.Windows.Forms.Label();
            this.lbl_hiredate = new System.Windows.Forms.Label();
            this.txt_empid = new System.Windows.Forms.TextBox();
            this.txt_fname = new System.Windows.Forms.TextBox();
            this.txt_lname = new System.Windows.Forms.TextBox();
            this.txt_minit = new System.Windows.Forms.TextBox();
            this.txt_jobid = new System.Windows.Forms.TextBox();
            this.txt_joblvl = new System.Windows.Forms.TextBox();
            this.txt_pubid = new System.Windows.Forms.TextBox();
            this.lst_Empleados = new System.Windows.Forms.ListBox();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.dtp_hiredate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(242, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestión de Empleados";
            // 
            // lbl_empid
            // 
            this.lbl_empid.AutoSize = true;
            this.lbl_empid.Location = new System.Drawing.Point(26, 110);
            this.lbl_empid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_empid.Name = "lbl_empid";
            this.lbl_empid.Size = new System.Drawing.Size(78, 25);
            this.lbl_empid.TabIndex = 1;
            this.lbl_empid.Text = "Emp_id";
            // 
            // lbl_fname
            // 
            this.lbl_fname.AutoSize = true;
            this.lbl_fname.Location = new System.Drawing.Point(31, 143);
            this.lbl_fname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_fname.Name = "lbl_fname";
            this.lbl_fname.Size = new System.Drawing.Size(73, 25);
            this.lbl_fname.TabIndex = 2;
            this.lbl_fname.Text = "Fname";
            // 
            // lbl_minit
            // 
            this.lbl_minit.AutoSize = true;
            this.lbl_minit.Location = new System.Drawing.Point(51, 223);
            this.lbl_minit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_minit.Name = "lbl_minit";
            this.lbl_minit.Size = new System.Drawing.Size(53, 25);
            this.lbl_minit.TabIndex = 3;
            this.lbl_minit.Text = "Minit";
            // 
            // lbl_lname
            // 
            this.lbl_lname.AutoSize = true;
            this.lbl_lname.Location = new System.Drawing.Point(32, 182);
            this.lbl_lname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_lname.Name = "lbl_lname";
            this.lbl_lname.Size = new System.Drawing.Size(72, 25);
            this.lbl_lname.TabIndex = 4;
            this.lbl_lname.Text = "Lname";
            // 
            // lbl_jobid
            // 
            this.lbl_jobid.AutoSize = true;
            this.lbl_jobid.Location = new System.Drawing.Point(33, 268);
            this.lbl_jobid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_jobid.Name = "lbl_jobid";
            this.lbl_jobid.Size = new System.Drawing.Size(71, 25);
            this.lbl_jobid.TabIndex = 5;
            this.lbl_jobid.Text = "Job_id";
            // 
            // lbl_joblvl
            // 
            this.lbl_joblvl.AutoSize = true;
            this.lbl_joblvl.Location = new System.Drawing.Point(30, 305);
            this.lbl_joblvl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_joblvl.Name = "lbl_joblvl";
            this.lbl_joblvl.Size = new System.Drawing.Size(74, 25);
            this.lbl_joblvl.TabIndex = 6;
            this.lbl_joblvl.Text = "Job_lvl";
            // 
            // lbl_pubid
            // 
            this.lbl_pubid.AutoSize = true;
            this.lbl_pubid.Location = new System.Drawing.Point(31, 347);
            this.lbl_pubid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_pubid.Name = "lbl_pubid";
            this.lbl_pubid.Size = new System.Drawing.Size(73, 25);
            this.lbl_pubid.TabIndex = 7;
            this.lbl_pubid.Text = "Pub_id";
            // 
            // lbl_hiredate
            // 
            this.lbl_hiredate.AutoSize = true;
            this.lbl_hiredate.Location = new System.Drawing.Point(8, 385);
            this.lbl_hiredate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_hiredate.Name = "lbl_hiredate";
            this.lbl_hiredate.Size = new System.Drawing.Size(96, 25);
            this.lbl_hiredate.TabIndex = 8;
            this.lbl_hiredate.Text = "Hire_date";
            // 
            // txt_empid
            // 
            this.txt_empid.Location = new System.Drawing.Point(111, 107);
            this.txt_empid.Name = "txt_empid";
            this.txt_empid.Size = new System.Drawing.Size(248, 30);
            this.txt_empid.TabIndex = 9;
            // 
            // txt_fname
            // 
            this.txt_fname.Location = new System.Drawing.Point(111, 143);
            this.txt_fname.Name = "txt_fname";
            this.txt_fname.Size = new System.Drawing.Size(248, 30);
            this.txt_fname.TabIndex = 10;
            // 
            // txt_lname
            // 
            this.txt_lname.Location = new System.Drawing.Point(111, 182);
            this.txt_lname.Name = "txt_lname";
            this.txt_lname.Size = new System.Drawing.Size(248, 30);
            this.txt_lname.TabIndex = 11;
            // 
            // txt_minit
            // 
            this.txt_minit.Location = new System.Drawing.Point(111, 223);
            this.txt_minit.Name = "txt_minit";
            this.txt_minit.Size = new System.Drawing.Size(248, 30);
            this.txt_minit.TabIndex = 12;
            // 
            // txt_jobid
            // 
            this.txt_jobid.Location = new System.Drawing.Point(111, 268);
            this.txt_jobid.Name = "txt_jobid";
            this.txt_jobid.Size = new System.Drawing.Size(248, 30);
            this.txt_jobid.TabIndex = 13;
            // 
            // txt_joblvl
            // 
            this.txt_joblvl.Location = new System.Drawing.Point(111, 305);
            this.txt_joblvl.Name = "txt_joblvl";
            this.txt_joblvl.Size = new System.Drawing.Size(248, 30);
            this.txt_joblvl.TabIndex = 14;
            // 
            // txt_pubid
            // 
            this.txt_pubid.Location = new System.Drawing.Point(111, 344);
            this.txt_pubid.Name = "txt_pubid";
            this.txt_pubid.Size = new System.Drawing.Size(248, 30);
            this.txt_pubid.TabIndex = 15;
            // 
            // lst_Empleados
            // 
            this.lst_Empleados.FormattingEnabled = true;
            this.lst_Empleados.ItemHeight = 25;
            this.lst_Empleados.Location = new System.Drawing.Point(408, 111);
            this.lst_Empleados.Name = "lst_Empleados";
            this.lst_Empleados.Size = new System.Drawing.Size(372, 304);
            this.lst_Empleados.TabIndex = 17;
            this.lst_Empleados.SelectedIndexChanged += new System.EventHandler(this.lst_Empleados_SelectedIndexChanged);
            this.lst_Empleados.DoubleClick += new System.EventHandler(this.lst_Empleados_DoubleClick);
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_guardar.Location = new System.Drawing.Point(111, 441);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(93, 36);
            this.btn_guardar.TabIndex = 18;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = false;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_limpiar.Location = new System.Drawing.Point(233, 441);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(87, 36);
            this.btn_limpiar.TabIndex = 19;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = false;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(503, 83);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(183, 25);
            this.label10.TabIndex = 20;
            this.label10.Text = "Lista de Empleados";
            // 
            // dtp_hiredate
            // 
            this.dtp_hiredate.Location = new System.Drawing.Point(111, 385);
            this.dtp_hiredate.Name = "dtp_hiredate";
            this.dtp_hiredate.Size = new System.Drawing.Size(248, 30);
            this.dtp_hiredate.TabIndex = 21;
            // 
            // frm_empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(813, 505);
            this.Controls.Add(this.dtp_hiredate);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.lst_Empleados);
            this.Controls.Add(this.txt_pubid);
            this.Controls.Add(this.txt_joblvl);
            this.Controls.Add(this.txt_jobid);
            this.Controls.Add(this.txt_minit);
            this.Controls.Add(this.txt_lname);
            this.Controls.Add(this.txt_fname);
            this.Controls.Add(this.txt_empid);
            this.Controls.Add(this.lbl_hiredate);
            this.Controls.Add(this.lbl_pubid);
            this.Controls.Add(this.lbl_joblvl);
            this.Controls.Add(this.lbl_jobid);
            this.Controls.Add(this.lbl_lname);
            this.Controls.Add(this.lbl_minit);
            this.Controls.Add(this.lbl_fname);
            this.Controls.Add(this.lbl_empid);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_empleados";
            this.Text = "Empleados";
            this.Load += new System.EventHandler(this.frm_empleados_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_empid;
        private System.Windows.Forms.Label lbl_fname;
        private System.Windows.Forms.Label lbl_minit;
        private System.Windows.Forms.Label lbl_lname;
        private System.Windows.Forms.Label lbl_jobid;
        private System.Windows.Forms.Label lbl_joblvl;
        private System.Windows.Forms.Label lbl_pubid;
        private System.Windows.Forms.Label lbl_hiredate;
        private System.Windows.Forms.TextBox txt_empid;
        private System.Windows.Forms.TextBox txt_fname;
        private System.Windows.Forms.TextBox txt_lname;
        private System.Windows.Forms.TextBox txt_minit;
        private System.Windows.Forms.TextBox txt_jobid;
        private System.Windows.Forms.TextBox txt_joblvl;
        private System.Windows.Forms.TextBox txt_pubid;
        private System.Windows.Forms.ListBox lst_Empleados;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtp_hiredate;
    }
}