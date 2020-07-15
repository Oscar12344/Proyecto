namespace PublicarTrabajo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPais = new System.Windows.Forms.TextBox();
            this.txtRegion = new System.Windows.Forms.TextBox();
            this.txtCiudad = new System.Windows.Forms.TextBox();
            this.txtOficio = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Uighur", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(193, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Datos del trabajo";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(144, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Pais*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(144, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Region*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(144, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Ciudad/Distrito*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(143, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Tipo de Oficio*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(144, 284);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Descripcion";
            // 
            // txtPais
            // 
            this.txtPais.Location = new System.Drawing.Point(147, 110);
            this.txtPais.Multiline = true;
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(258, 27);
            this.txtPais.TabIndex = 11;
            // 
            // txtRegion
            // 
            this.txtRegion.Location = new System.Drawing.Point(146, 160);
            this.txtRegion.Multiline = true;
            this.txtRegion.Name = "txtRegion";
            this.txtRegion.Size = new System.Drawing.Size(258, 25);
            this.txtRegion.TabIndex = 12;
            // 
            // txtCiudad
            // 
            this.txtCiudad.Location = new System.Drawing.Point(146, 206);
            this.txtCiudad.Multiline = true;
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(258, 28);
            this.txtCiudad.TabIndex = 13;
            // 
            // txtOficio
            // 
            this.txtOficio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOficio.Location = new System.Drawing.Point(146, 256);
            this.txtOficio.Multiline = true;
            this.txtOficio.Name = "txtOficio";
            this.txtOficio.Size = new System.Drawing.Size(259, 25);
            this.txtOficio.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SteelBlue;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(200, 420);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button1.Size = new System.Drawing.Size(147, 59);
            this.button1.TabIndex = 15;
            this.button1.Text = "Publicar Trabajo";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(147, 313);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(257, 87);
            this.txtDescripcion.TabIndex = 16;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(394, 420);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 45);
            this.button2.TabIndex = 17;
            this.button2.Text = "Modificar Publicacion";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(561, 506);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtOficio);
            this.Controls.Add(this.txtCiudad);
            this.Controls.Add(this.txtRegion);
            this.Controls.Add(this.txtPais);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Publicar Trabajo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPais;
        private System.Windows.Forms.TextBox txtRegion;
        private System.Windows.Forms.TextBox txtCiudad;
        private System.Windows.Forms.TextBox txtOficio;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Button button2;
    }
}

