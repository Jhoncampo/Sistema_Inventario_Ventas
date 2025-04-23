namespace Sistema_Inventario_Ventas.Vistas
{
    partial class FormUsuarios
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cbEstados = new System.Windows.Forms.ComboBox();
            this.cbPermisos = new System.Windows.Forms.ComboBox();
            this.tbContrasena = new System.Windows.Forms.TextBox();
            this.tbUsuario = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.cbActEstados = new System.Windows.Forms.ComboBox();
            this.cbActPermisos = new System.Windows.Forms.ComboBox();
            this.tbActContrasena = new System.Windows.Forms.TextBox();
            this.tbActUsuario = new System.Windows.Forms.TextBox();
            this.tbActNombre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tbBuscarUsuario = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.DGVUsuarios = new System.Windows.Forms.DataGridView();
            this.txtTotalUsuarios = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.cbEstados);
            this.groupBox1.Controls.Add(this.cbPermisos);
            this.groupBox1.Controls.Add(this.tbContrasena);
            this.groupBox1.Controls.Add(this.tbUsuario);
            this.groupBox1.Controls.Add(this.tbNombre);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(35, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(273, 222);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "AGREGAR USUARIO";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(163, 193);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "AGREGAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // cbEstados
            // 
            this.cbEstados.FormattingEnabled = true;
            this.cbEstados.Location = new System.Drawing.Point(111, 149);
            this.cbEstados.Name = "cbEstados";
            this.cbEstados.Size = new System.Drawing.Size(143, 21);
            this.cbEstados.TabIndex = 9;
            // 
            // cbPermisos
            // 
            this.cbPermisos.FormattingEnabled = true;
            this.cbPermisos.Location = new System.Drawing.Point(111, 119);
            this.cbPermisos.Name = "cbPermisos";
            this.cbPermisos.Size = new System.Drawing.Size(143, 21);
            this.cbPermisos.TabIndex = 8;
            // 
            // tbContrasena
            // 
            this.tbContrasena.Location = new System.Drawing.Point(111, 87);
            this.tbContrasena.Name = "tbContrasena";
            this.tbContrasena.Size = new System.Drawing.Size(143, 20);
            this.tbContrasena.TabIndex = 7;
            // 
            // tbUsuario
            // 
            this.tbUsuario.Location = new System.Drawing.Point(111, 57);
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.Size = new System.Drawing.Size(143, 20);
            this.tbUsuario.TabIndex = 6;
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(111, 29);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(143, 20);
            this.tbNombre.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "ESTADO:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "PERMISO:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "CONTRASEÑA:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "USUARIO:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "NOMBRE:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.cbActEstados);
            this.groupBox2.Controls.Add(this.cbActPermisos);
            this.groupBox2.Controls.Add(this.tbActContrasena);
            this.groupBox2.Controls.Add(this.tbActUsuario);
            this.groupBox2.Controls.Add(this.tbActNombre);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(35, 287);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(273, 222);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "EDITAR USUARIO";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(163, 193);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "ACTUALIZAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // cbActEstados
            // 
            this.cbActEstados.FormattingEnabled = true;
            this.cbActEstados.Location = new System.Drawing.Point(111, 149);
            this.cbActEstados.Name = "cbActEstados";
            this.cbActEstados.Size = new System.Drawing.Size(143, 21);
            this.cbActEstados.TabIndex = 9;
            // 
            // cbActPermisos
            // 
            this.cbActPermisos.FormattingEnabled = true;
            this.cbActPermisos.Location = new System.Drawing.Point(111, 119);
            this.cbActPermisos.Name = "cbActPermisos";
            this.cbActPermisos.Size = new System.Drawing.Size(143, 21);
            this.cbActPermisos.TabIndex = 8;
            // 
            // tbActContrasena
            // 
            this.tbActContrasena.Location = new System.Drawing.Point(111, 87);
            this.tbActContrasena.Name = "tbActContrasena";
            this.tbActContrasena.Size = new System.Drawing.Size(143, 20);
            this.tbActContrasena.TabIndex = 7;
            // 
            // tbActUsuario
            // 
            this.tbActUsuario.Location = new System.Drawing.Point(111, 57);
            this.tbActUsuario.Name = "tbActUsuario";
            this.tbActUsuario.Size = new System.Drawing.Size(143, 20);
            this.tbActUsuario.TabIndex = 6;
            // 
            // tbActNombre
            // 
            this.tbActNombre.Location = new System.Drawing.Point(111, 29);
            this.tbActNombre.Name = "tbActNombre";
            this.tbActNombre.Size = new System.Drawing.Size(143, 20);
            this.tbActNombre.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "ESTADO:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "PERMISO:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "CONTRASEÑA:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "USUARIO:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "NOMBRE:";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.tbBuscarUsuario);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Location = new System.Drawing.Point(316, 35);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(743, 55);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Location = new System.Drawing.Point(605, 17);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(132, 23);
            this.button4.TabIndex = 12;
            this.button4.Text = "MOSTRAR TODOS";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.btnMostrarUsuarios_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(508, 19);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(91, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "BUSCAR";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnBuscarUsuario_Click);
            // 
            // tbBuscarUsuario
            // 
            this.tbBuscarUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbBuscarUsuario.Location = new System.Drawing.Point(115, 20);
            this.tbBuscarUsuario.Name = "tbBuscarUsuario";
            this.tbBuscarUsuario.Size = new System.Drawing.Size(387, 20);
            this.tbBuscarUsuario.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "BUSCAR USUARIO";
            // 
            // DGVUsuarios
            // 
            this.DGVUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVUsuarios.Location = new System.Drawing.Point(316, 96);
            this.DGVUsuarios.Name = "DGVUsuarios";
            this.DGVUsuarios.Size = new System.Drawing.Size(743, 514);
            this.DGVUsuarios.TabIndex = 13;
            this.DGVUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVUsuarios_CellClick);
            // 
            // txtTotalUsuarios
            // 
            this.txtTotalUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotalUsuarios.AutoSize = true;
            this.txtTotalUsuarios.Location = new System.Drawing.Point(918, 628);
            this.txtTotalUsuarios.Name = "txtTotalUsuarios";
            this.txtTotalUsuarios.Size = new System.Drawing.Size(41, 13);
            this.txtTotalUsuarios.TabIndex = 14;
            this.txtTotalUsuarios.Text = "label12";
            this.txtTotalUsuarios.Click += new System.EventHandler(this.label12_Click);
            // 
            // FormUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 661);
            this.Controls.Add(this.txtTotalUsuarios);
            this.Controls.Add(this.DGVUsuarios);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormUsuarios";
            this.Text = "FormUsuarios";
            this.Load += new System.EventHandler(this.FormUsuarios_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbEstados;
        private System.Windows.Forms.ComboBox cbPermisos;
        private System.Windows.Forms.TextBox tbContrasena;
        private System.Windows.Forms.TextBox tbUsuario;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cbActEstados;
        private System.Windows.Forms.ComboBox cbActPermisos;
        private System.Windows.Forms.TextBox tbActContrasena;
        private System.Windows.Forms.TextBox tbActUsuario;
        private System.Windows.Forms.TextBox tbActNombre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox tbBuscarUsuario;
        private System.Windows.Forms.DataGridView DGVUsuarios;
        private System.Windows.Forms.Label txtTotalUsuarios;
    }
}