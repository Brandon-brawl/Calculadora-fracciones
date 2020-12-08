namespace Calculadora_fracciones
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
            this.NumNumerador1 = new System.Windows.Forms.NumericUpDown();
            this.NumDenominador1 = new System.Windows.Forms.NumericUpDown();
            this.NumDenominador2 = new System.Windows.Forms.NumericUpDown();
            this.NumNumerador2 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LblCalcularResultado = new System.Windows.Forms.Label();
            this.NumEntero1 = new System.Windows.Forms.NumericUpDown();
            this.NumEntero2 = new System.Windows.Forms.NumericUpDown();
            this.cboOperaccione = new System.Windows.Forms.ComboBox();
            this.LblEnteroRe = new System.Windows.Forms.Label();
            this.LblNumeradorRe = new System.Windows.Forms.Label();
            this.LblDenominadorRe = new System.Windows.Forms.Label();
            this.LblLinea = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NumNumerador1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumDenominador1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumDenominador2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumNumerador2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumEntero1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumEntero2)).BeginInit();
            this.SuspendLayout();
            // 
            // NumNumerador1
            // 
            this.NumNumerador1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumNumerador1.Location = new System.Drawing.Point(81, 69);
            this.NumNumerador1.Name = "NumNumerador1";
            this.NumNumerador1.Size = new System.Drawing.Size(120, 30);
            this.NumNumerador1.TabIndex = 0;
            // 
            // NumDenominador1
            // 
            this.NumDenominador1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumDenominador1.Location = new System.Drawing.Point(81, 121);
            this.NumDenominador1.Name = "NumDenominador1";
            this.NumDenominador1.Size = new System.Drawing.Size(120, 30);
            this.NumDenominador1.TabIndex = 1;
            // 
            // NumDenominador2
            // 
            this.NumDenominador2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumDenominador2.Location = new System.Drawing.Point(341, 121);
            this.NumDenominador2.Name = "NumDenominador2";
            this.NumDenominador2.Size = new System.Drawing.Size(120, 30);
            this.NumDenominador2.TabIndex = 2;
            // 
            // NumNumerador2
            // 
            this.NumNumerador2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumNumerador2.Location = new System.Drawing.Point(341, 69);
            this.NumNumerador2.Name = "NumNumerador2";
            this.NumNumerador2.Size = new System.Drawing.Size(120, 30);
            this.NumNumerador2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "___________________";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(338, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "___________________";
            // 
            // LblCalcularResultado
            // 
            this.LblCalcularResultado.AutoSize = true;
            this.LblCalcularResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCalcularResultado.Location = new System.Drawing.Point(477, 96);
            this.LblCalcularResultado.Name = "LblCalcularResultado";
            this.LblCalcularResultado.Size = new System.Drawing.Size(24, 25);
            this.LblCalcularResultado.TabIndex = 7;
            this.LblCalcularResultado.Text = "=";
            this.LblCalcularResultado.Click += new System.EventHandler(this.LblCalcularResultado_Click);
            // 
            // NumEntero1
            // 
            this.NumEntero1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumEntero1.Location = new System.Drawing.Point(29, 83);
            this.NumEntero1.Name = "NumEntero1";
            this.NumEntero1.Size = new System.Drawing.Size(46, 45);
            this.NumEntero1.TabIndex = 9;
            // 
            // NumEntero2
            // 
            this.NumEntero2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumEntero2.Location = new System.Drawing.Point(289, 80);
            this.NumEntero2.Name = "NumEntero2";
            this.NumEntero2.Size = new System.Drawing.Size(46, 45);
            this.NumEntero2.TabIndex = 11;
            // 
            // cboOperaccione
            // 
            this.cboOperaccione.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOperaccione.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboOperaccione.FormattingEnabled = true;
            this.cboOperaccione.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.cboOperaccione.Location = new System.Drawing.Point(229, 90);
            this.cboOperaccione.Name = "cboOperaccione";
            this.cboOperaccione.Size = new System.Drawing.Size(46, 33);
            this.cboOperaccione.TabIndex = 12;
            // 
            // LblEnteroRe
            // 
            this.LblEnteroRe.AutoSize = true;
            this.LblEnteroRe.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEnteroRe.Location = new System.Drawing.Point(507, 90);
            this.LblEnteroRe.Name = "LblEnteroRe";
            this.LblEnteroRe.Size = new System.Drawing.Size(34, 39);
            this.LblEnteroRe.TabIndex = 14;
            this.LblEnteroRe.Text = "x";
            // 
            // LblNumeradorRe
            // 
            this.LblNumeradorRe.AutoSize = true;
            this.LblNumeradorRe.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNumeradorRe.Location = new System.Drawing.Point(568, 83);
            this.LblNumeradorRe.Name = "LblNumeradorRe";
            this.LblNumeradorRe.Size = new System.Drawing.Size(22, 25);
            this.LblNumeradorRe.TabIndex = 15;
            this.LblNumeradorRe.Text = "x";
            // 
            // LblDenominadorRe
            // 
            this.LblDenominadorRe.AutoSize = true;
            this.LblDenominadorRe.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDenominadorRe.Location = new System.Drawing.Point(568, 123);
            this.LblDenominadorRe.Name = "LblDenominadorRe";
            this.LblDenominadorRe.Size = new System.Drawing.Size(22, 25);
            this.LblDenominadorRe.TabIndex = 16;
            this.LblDenominadorRe.Text = "x";
            // 
            // LblLinea
            // 
            this.LblLinea.AutoSize = true;
            this.LblLinea.Location = new System.Drawing.Point(535, 104);
            this.LblLinea.Name = "LblLinea";
            this.LblLinea.Size = new System.Drawing.Size(91, 13);
            this.LblLinea.TabIndex = 17;
            this.LblLinea.Text = "______________";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblLinea);
            this.Controls.Add(this.LblDenominadorRe);
            this.Controls.Add(this.LblNumeradorRe);
            this.Controls.Add(this.LblEnteroRe);
            this.Controls.Add(this.cboOperaccione);
            this.Controls.Add(this.NumEntero2);
            this.Controls.Add(this.NumEntero1);
            this.Controls.Add(this.LblCalcularResultado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NumNumerador2);
            this.Controls.Add(this.NumDenominador2);
            this.Controls.Add(this.NumDenominador1);
            this.Controls.Add(this.NumNumerador1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.NumNumerador1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumDenominador1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumDenominador2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumNumerador2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumEntero1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumEntero2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown NumNumerador1;
        private System.Windows.Forms.NumericUpDown NumDenominador1;
        private System.Windows.Forms.NumericUpDown NumDenominador2;
        private System.Windows.Forms.NumericUpDown NumNumerador2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblCalcularResultado;
        private System.Windows.Forms.NumericUpDown NumEntero1;
        private System.Windows.Forms.NumericUpDown NumEntero2;
        private System.Windows.Forms.ComboBox cboOperaccione;
        private System.Windows.Forms.Label LblEnteroRe;
        private System.Windows.Forms.Label LblNumeradorRe;
        private System.Windows.Forms.Label LblDenominadorRe;
        private System.Windows.Forms.Label LblLinea;
    }
}

