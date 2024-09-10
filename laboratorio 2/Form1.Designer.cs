namespace AnaPatriciaAparicio_Lab_1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelLogo1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelEncabezado1 = new System.Windows.Forms.Panel();
            this.txt1Encabezado = new System.Windows.Forms.Label();
            this.panelEncabezado2 = new System.Windows.Forms.Panel();
            this.labelTítulo = new System.Windows.Forms.Label();
            this.lbSalarioForm1 = new System.Windows.Forms.Label();
            this.BotónCalcular = new System.Windows.Forms.Button();
            this.lblNombreForm1 = new System.Windows.Forms.Label();
            this.lbCédulaForm1 = new System.Windows.Forms.Label();
            this.textSalario = new System.Windows.Forms.TextBox();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.textCédula = new System.Windows.Forms.TextBox();
            this.panelLogo1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelEncabezado1.SuspendLayout();
            this.panelEncabezado2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLogo1
            // 
            this.panelLogo1.BackColor = System.Drawing.Color.Ivory;
            this.panelLogo1.Controls.Add(this.pictureBox2);
            this.panelLogo1.Controls.Add(this.pictureBox1);
            this.panelLogo1.Controls.Add(this.panelEncabezado1);
            this.panelLogo1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLogo1.Location = new System.Drawing.Point(0, 0);
            this.panelLogo1.Name = "panelLogo1";
            this.panelLogo1.Size = new System.Drawing.Size(206, 363);
            this.panelLogo1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-47, 99);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(296, 190);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(-29, 62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 271);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_2);
            // 
            // panelEncabezado1
            // 
            this.panelEncabezado1.BackColor = System.Drawing.Color.LightSlateGray;
            this.panelEncabezado1.Controls.Add(this.txt1Encabezado);
            this.panelEncabezado1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEncabezado1.Location = new System.Drawing.Point(0, 0);
            this.panelEncabezado1.Name = "panelEncabezado1";
            this.panelEncabezado1.Size = new System.Drawing.Size(206, 44);
            this.panelEncabezado1.TabIndex = 0;
            // 
            // txt1Encabezado
            // 
            this.txt1Encabezado.AutoSize = true;
            this.txt1Encabezado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt1Encabezado.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt1Encabezado.Location = new System.Drawing.Point(12, 9);
            this.txt1Encabezado.Name = "txt1Encabezado";
            this.txt1Encabezado.Size = new System.Drawing.Size(0, 16);
            this.txt1Encabezado.TabIndex = 2;
            this.txt1Encabezado.Click += new System.EventHandler(this.label1_Click);
            // 
            // panelEncabezado2
            // 
            this.panelEncabezado2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panelEncabezado2.Controls.Add(this.labelTítulo);
            this.panelEncabezado2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEncabezado2.ForeColor = System.Drawing.Color.Transparent;
            this.panelEncabezado2.Location = new System.Drawing.Point(206, 0);
            this.panelEncabezado2.Name = "panelEncabezado2";
            this.panelEncabezado2.Size = new System.Drawing.Size(512, 44);
            this.panelEncabezado2.TabIndex = 1;
            // 
            // labelTítulo
            // 
            this.labelTítulo.AutoSize = true;
            this.labelTítulo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTítulo.ForeColor = System.Drawing.Color.White;
            this.labelTítulo.Location = new System.Drawing.Point(119, 9);
            this.labelTítulo.Name = "labelTítulo";
            this.labelTítulo.Size = new System.Drawing.Size(296, 22);
            this.labelTítulo.TabIndex = 2;
            this.labelTítulo.Text = "INFORMACIÓN DEL EMPLEADO";
            this.labelTítulo.Click += new System.EventHandler(this.labelTítulo_Click);
            // 
            // lbSalarioForm1
            // 
            this.lbSalarioForm1.AutoSize = true;
            this.lbSalarioForm1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSalarioForm1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbSalarioForm1.Location = new System.Drawing.Point(255, 214);
            this.lbSalarioForm1.Name = "lbSalarioForm1";
            this.lbSalarioForm1.Size = new System.Drawing.Size(201, 38);
            this.lbSalarioForm1.TabIndex = 5;
            this.lbSalarioForm1.Text = "SALARIO BRUTO MENSUAL\r\n\r\n";
            this.lbSalarioForm1.Click += new System.EventHandler(this.labelSalario_Click);
            // 
            // BotónCalcular
            // 
            this.BotónCalcular.BackColor = System.Drawing.Color.Gray;
            this.BotónCalcular.FlatAppearance.BorderSize = 0;
            this.BotónCalcular.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.BotónCalcular.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BotónCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotónCalcular.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotónCalcular.ForeColor = System.Drawing.Color.White;
            this.BotónCalcular.Location = new System.Drawing.Point(259, 282);
            this.BotónCalcular.Name = "BotónCalcular";
            this.BotónCalcular.Size = new System.Drawing.Size(427, 42);
            this.BotónCalcular.TabIndex = 6;
            this.BotónCalcular.Text = "CALCULAR  SALARIO NETO";
            this.BotónCalcular.UseVisualStyleBackColor = false;
            this.BotónCalcular.Click += new System.EventHandler(this.botonCalcular);
            // 
            // lblNombreForm1
            // 
            this.lblNombreForm1.AutoSize = true;
            this.lblNombreForm1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreForm1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblNombreForm1.Location = new System.Drawing.Point(255, 99);
            this.lblNombreForm1.Name = "lblNombreForm1";
            this.lblNombreForm1.Size = new System.Drawing.Size(190, 19);
            this.lblNombreForm1.TabIndex = 7;
            this.lblNombreForm1.Text = "NOMBRE DEL EMPLEADO";
            this.lblNombreForm1.Click += new System.EventHandler(this.labelNombre_Click);
            // 
            // lbCédulaForm1
            // 
            this.lbCédulaForm1.AutoSize = true;
            this.lbCédulaForm1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCédulaForm1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbCédulaForm1.Location = new System.Drawing.Point(255, 156);
            this.lbCédulaForm1.Name = "lbCédulaForm1";
            this.lbCédulaForm1.Size = new System.Drawing.Size(69, 19);
            this.lbCédulaForm1.TabIndex = 12;
            this.lbCédulaForm1.Text = "CÉDULA";
            this.lbCédulaForm1.Click += new System.EventHandler(this.labelCédula_Click);
            // 
            // textSalario
            // 
            this.textSalario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSalario.Location = new System.Drawing.Point(469, 214);
            this.textSalario.MaxLength = 7;
            this.textSalario.Multiline = true;
            this.textSalario.Name = "textSalario";
            this.textSalario.Size = new System.Drawing.Size(103, 32);
            this.textSalario.TabIndex = 15;
            this.textSalario.TextChanged += new System.EventHandler(this.textSalario_TextChanged_1);
            this.textSalario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textSalario_KeyPress);
            // 
            // textNombre
            // 
            this.textNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textNombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNombre.Location = new System.Drawing.Point(469, 96);
            this.textNombre.MaxLength = 45;
            this.textNombre.Multiline = true;
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(217, 32);
            this.textNombre.TabIndex = 13;
            this.textNombre.TextChanged += new System.EventHandler(this.textNombre_TextChanged);
            // 
            // textCédula
            // 
            this.textCédula.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCédula.Location = new System.Drawing.Point(469, 156);
            this.textCédula.MaxLength = 13;
            this.textCédula.Multiline = true;
            this.textCédula.Name = "textCédula";
            this.textCédula.Size = new System.Drawing.Size(217, 32);
            this.textCédula.TabIndex = 14;
            this.textCédula.TextChanged += new System.EventHandler(this.textCédula_TextChanged_1);
            this.textCédula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textCédula_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(718, 363);
            this.Controls.Add(this.textSalario);
            this.Controls.Add(this.textCédula);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.lbCédulaForm1);
            this.Controls.Add(this.lblNombreForm1);
            this.Controls.Add(this.BotónCalcular);
            this.Controls.Add(this.lbSalarioForm1);
            this.Controls.Add(this.panelEncabezado2);
            this.Controls.Add(this.panelLogo1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Opacity = 0.96D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Laboratorio 2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelLogo1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelEncabezado1.ResumeLayout(false);
            this.panelEncabezado1.PerformLayout();
            this.panelEncabezado2.ResumeLayout(false);
            this.panelEncabezado2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelLogo1;
        private System.Windows.Forms.Panel panelEncabezado1;
        private System.Windows.Forms.Panel panelEncabezado2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label txt1Encabezado;
        private System.Windows.Forms.Label labelTítulo;
        private System.Windows.Forms.Label lbSalarioForm1;
        private System.Windows.Forms.Button BotónCalcular;
        private System.Windows.Forms.Label lblNombreForm1;
        private System.Windows.Forms.Label lbCédulaForm1;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.TextBox textCédula;
        public System.Windows.Forms.TextBox textSalario;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

