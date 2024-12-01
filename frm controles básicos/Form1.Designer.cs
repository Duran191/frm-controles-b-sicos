namespace frm_controles_básicos
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnCalcular = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lblVarlorUno = new System.Windows.Forms.Label();
            this.lblSuma = new System.Windows.Forms.Label();
            this.lblValorDos = new System.Windows.Forms.Label();
            this.textvalor1 = new System.Windows.Forms.TextBox();
            this.textSuma = new System.Windows.Forms.TextBox();
            this.textValor2 = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblResta = new System.Windows.Forms.Label();
            this.lblMultiplicacion = new System.Windows.Forms.Label();
            this.lblDivision = new System.Windows.Forms.Label();
            this.textMultiplicacion = new System.Windows.Forms.TextBox();
            this.textResta = new System.Windows.Forms.TextBox();
            this.textDivision = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(530, 125);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(115, 44);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // lblVarlorUno
            // 
            this.lblVarlorUno.AutoSize = true;
            this.lblVarlorUno.Font = new System.Drawing.Font("Times New Roman", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVarlorUno.Location = new System.Drawing.Point(145, 150);
            this.lblVarlorUno.Name = "lblVarlorUno";
            this.lblVarlorUno.Size = new System.Drawing.Size(87, 23);
            this.lblVarlorUno.TabIndex = 3;
            this.lblVarlorUno.Text = "1er Valor";
            this.lblVarlorUno.Click += new System.EventHandler(this.lblVarlorUno_Click);
            // 
            // lblSuma
            // 
            this.lblSuma.AutoSize = true;
            this.lblSuma.Font = new System.Drawing.Font("Times New Roman", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuma.Location = new System.Drawing.Point(38, 351);
            this.lblSuma.Name = "lblSuma";
            this.lblSuma.Size = new System.Drawing.Size(146, 23);
            this.lblSuma.TabIndex = 4;
            this.lblSuma.Text = "Resultado Suma";
            this.lblSuma.Click += new System.EventHandler(this.lblSuma_Click);
            // 
            // lblValorDos
            // 
            this.lblValorDos.AutoSize = true;
            this.lblValorDos.Font = new System.Drawing.Font("Times New Roman", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorDos.Location = new System.Drawing.Point(145, 208);
            this.lblValorDos.Name = "lblValorDos";
            this.lblValorDos.Size = new System.Drawing.Size(90, 23);
            this.lblValorDos.TabIndex = 5;
            this.lblValorDos.Text = "2do Valor";
            // 
            // textvalor1
            // 
            this.textvalor1.Location = new System.Drawing.Point(240, 150);
            this.textvalor1.Name = "textvalor1";
            this.textvalor1.Size = new System.Drawing.Size(100, 26);
            this.textvalor1.TabIndex = 6;
            // 
            // textSuma
            // 
            this.textSuma.Enabled = false;
            this.textSuma.Location = new System.Drawing.Point(207, 348);
            this.textSuma.Name = "textSuma";
            this.textSuma.Size = new System.Drawing.Size(100, 26);
            this.textSuma.TabIndex = 7;
            // 
            // textValor2
            // 
            this.textValor2.Location = new System.Drawing.Point(241, 208);
            this.textValor2.Name = "textValor2";
            this.textValor2.Size = new System.Drawing.Size(100, 26);
            this.textValor2.TabIndex = 8;
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(530, 265);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(115, 44);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(530, 196);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(115, 44);
            this.btnLimpar.TabIndex = 10;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lblResta
            // 
            this.lblResta.AutoSize = true;
            this.lblResta.Font = new System.Drawing.Font("Times New Roman", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResta.Location = new System.Drawing.Point(38, 408);
            this.lblResta.Name = "lblResta";
            this.lblResta.Size = new System.Drawing.Size(144, 23);
            this.lblResta.TabIndex = 11;
            this.lblResta.Text = "Resultado Resta";
            // 
            // lblMultiplicacion
            // 
            this.lblMultiplicacion.AutoSize = true;
            this.lblMultiplicacion.Font = new System.Drawing.Font("Times New Roman", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMultiplicacion.Location = new System.Drawing.Point(359, 351);
            this.lblMultiplicacion.Name = "lblMultiplicacion";
            this.lblMultiplicacion.Size = new System.Drawing.Size(222, 23);
            this.lblMultiplicacion.TabIndex = 12;
            this.lblMultiplicacion.Text = "Resultado Multiplicación";
            // 
            // lblDivision
            // 
            this.lblDivision.AutoSize = true;
            this.lblDivision.Font = new System.Drawing.Font("Times New Roman", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDivision.Location = new System.Drawing.Point(371, 399);
            this.lblDivision.Name = "lblDivision";
            this.lblDivision.Size = new System.Drawing.Size(167, 23);
            this.lblDivision.TabIndex = 13;
            this.lblDivision.Text = "Resultado División";
            // 
            // textMultiplicacion
            // 
            this.textMultiplicacion.Location = new System.Drawing.Point(603, 351);
            this.textMultiplicacion.Name = "textMultiplicacion";
            this.textMultiplicacion.Size = new System.Drawing.Size(100, 26);
            this.textMultiplicacion.TabIndex = 14;
            this.textMultiplicacion.TextChanged += new System.EventHandler(this.textMultiplicacion_TextChanged);
            // 
            // textResta
            // 
            this.textResta.Location = new System.Drawing.Point(207, 405);
            this.textResta.Name = "textResta";
            this.textResta.Size = new System.Drawing.Size(100, 26);
            this.textResta.TabIndex = 15;
            this.textResta.TextChanged += new System.EventHandler(this.textResta_TextChanged);
            // 
            // textDivision
            // 
            this.textDivision.Location = new System.Drawing.Point(603, 396);
            this.textDivision.Name = "textDivision";
            this.textDivision.Size = new System.Drawing.Size(100, 26);
            this.textDivision.TabIndex = 16;
            this.textDivision.TextChanged += new System.EventHandler(this.textDivision_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(282, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 28);
            this.label1.TabIndex = 17;
            this.label1.Text = "Diferentes Calculos:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textDivision);
            this.Controls.Add(this.textResta);
            this.Controls.Add(this.textMultiplicacion);
            this.Controls.Add(this.lblDivision);
            this.Controls.Add(this.lblMultiplicacion);
            this.Controls.Add(this.lblResta);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.textValor2);
            this.Controls.Add(this.textSuma);
            this.Controls.Add(this.textvalor1);
            this.Controls.Add(this.lblValorDos);
            this.Controls.Add(this.lblSuma);
            this.Controls.Add(this.lblVarlorUno);
            this.Controls.Add(this.btnCalcular);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label lblVarlorUno;
        private System.Windows.Forms.Label lblSuma;
        private System.Windows.Forms.Label lblValorDos;
        private System.Windows.Forms.TextBox textvalor1;
        private System.Windows.Forms.TextBox textSuma;
        private System.Windows.Forms.TextBox textValor2;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label lblResta;
        private System.Windows.Forms.Label lblMultiplicacion;
        private System.Windows.Forms.Label lblDivision;
        private System.Windows.Forms.TextBox textMultiplicacion;
        private System.Windows.Forms.TextBox textResta;
        private System.Windows.Forms.TextBox textDivision;
        private System.Windows.Forms.Label label1;
    }
}

