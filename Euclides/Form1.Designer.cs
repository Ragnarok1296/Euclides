namespace Euclides
{
    partial class frmPrincipal
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
            this.txtbModulo = new System.Windows.Forms.TextBox();
            this.lblModulo = new System.Windows.Forms.Label();
            this.btnPlay = new System.Windows.Forms.Button();
            this.dgvNumeros = new System.Windows.Forms.DataGridView();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Invertible = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblCalculadora = new System.Windows.Forms.Label();
            this.txtbNumero1 = new System.Windows.Forms.TextBox();
            this.txtbNumero2 = new System.Windows.Forms.TextBox();
            this.lblNumero1 = new System.Windows.Forms.Label();
            this.lblNumero2 = new System.Windows.Forms.Label();
            this.LblModuloC = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtbResultado = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNumeros)).BeginInit();
            this.SuspendLayout();
            // 
            // txtbModulo
            // 
            this.txtbModulo.Location = new System.Drawing.Point(63, 25);
            this.txtbModulo.Name = "txtbModulo";
            this.txtbModulo.Size = new System.Drawing.Size(77, 20);
            this.txtbModulo.TabIndex = 0;
            this.txtbModulo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbModulo_KeyPress);
            // 
            // lblModulo
            // 
            this.lblModulo.AutoSize = true;
            this.lblModulo.Location = new System.Drawing.Point(12, 28);
            this.lblModulo.Name = "lblModulo";
            this.lblModulo.Size = new System.Drawing.Size(45, 13);
            this.lblModulo.TabIndex = 1;
            this.lblModulo.Text = "Modulo:";
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(146, 22);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(75, 23);
            this.btnPlay.TabIndex = 2;
            this.btnPlay.Text = "Empezar";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // dgvNumeros
            // 
            this.dgvNumeros.AllowUserToAddRows = false;
            this.dgvNumeros.AllowUserToDeleteRows = false;
            this.dgvNumeros.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvNumeros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNumeros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Numero,
            this.Invertible});
            this.dgvNumeros.Location = new System.Drawing.Point(15, 67);
            this.dgvNumeros.Name = "dgvNumeros";
            this.dgvNumeros.ReadOnly = true;
            this.dgvNumeros.RowHeadersVisible = false;
            this.dgvNumeros.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvNumeros.Size = new System.Drawing.Size(206, 150);
            this.dgvNumeros.TabIndex = 5;
            // 
            // Numero
            // 
            this.Numero.HeaderText = "Numero";
            this.Numero.Name = "Numero";
            this.Numero.ReadOnly = true;
            // 
            // Invertible
            // 
            this.Invertible.HeaderText = "Invertible";
            this.Invertible.Name = "Invertible";
            this.Invertible.ReadOnly = true;
            // 
            // lblCalculadora
            // 
            this.lblCalculadora.AutoSize = true;
            this.lblCalculadora.Location = new System.Drawing.Point(12, 238);
            this.lblCalculadora.Name = "lblCalculadora";
            this.lblCalculadora.Size = new System.Drawing.Size(63, 13);
            this.lblCalculadora.TabIndex = 6;
            this.lblCalculadora.Text = "Calculadora";
            // 
            // txtbNumero1
            // 
            this.txtbNumero1.Location = new System.Drawing.Point(71, 266);
            this.txtbNumero1.Name = "txtbNumero1";
            this.txtbNumero1.Size = new System.Drawing.Size(150, 20);
            this.txtbNumero1.TabIndex = 7;
            this.txtbNumero1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbNumero1_KeyPress);
            // 
            // txtbNumero2
            // 
            this.txtbNumero2.Location = new System.Drawing.Point(71, 320);
            this.txtbNumero2.Name = "txtbNumero2";
            this.txtbNumero2.Size = new System.Drawing.Size(150, 20);
            this.txtbNumero2.TabIndex = 8;
            // 
            // lblNumero1
            // 
            this.lblNumero1.AutoSize = true;
            this.lblNumero1.Location = new System.Drawing.Point(12, 269);
            this.lblNumero1.Name = "lblNumero1";
            this.lblNumero1.Size = new System.Drawing.Size(53, 13);
            this.lblNumero1.TabIndex = 9;
            this.lblNumero1.Text = "Numero 1";
            // 
            // lblNumero2
            // 
            this.lblNumero2.AutoSize = true;
            this.lblNumero2.Location = new System.Drawing.Point(12, 323);
            this.lblNumero2.Name = "lblNumero2";
            this.lblNumero2.Size = new System.Drawing.Size(53, 13);
            this.lblNumero2.TabIndex = 10;
            this.lblNumero2.Text = "Numero 2";
            // 
            // LblModuloC
            // 
            this.LblModuloC.AutoSize = true;
            this.LblModuloC.Location = new System.Drawing.Point(31, 296);
            this.LblModuloC.Name = "LblModuloC";
            this.LblModuloC.Size = new System.Drawing.Size(15, 13);
            this.LblModuloC.TabIndex = 11;
            this.LblModuloC.Text = "%";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(12, 367);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(55, 13);
            this.lblResultado.TabIndex = 12;
            this.lblResultado.Text = "Resultado";
            // 
            // txtbResultado
            // 
            this.txtbResultado.Location = new System.Drawing.Point(71, 364);
            this.txtbResultado.Name = "txtbResultado";
            this.txtbResultado.Size = new System.Drawing.Size(150, 20);
            this.txtbResultado.TabIndex = 13;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(81, 403);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 14;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 443);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtbResultado);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.LblModuloC);
            this.Controls.Add(this.lblNumero2);
            this.Controls.Add(this.lblNumero1);
            this.Controls.Add(this.txtbNumero2);
            this.Controls.Add(this.txtbNumero1);
            this.Controls.Add(this.lblCalculadora);
            this.Controls.Add(this.dgvNumeros);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.lblModulo);
            this.Controls.Add(this.txtbModulo);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(249, 482);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(249, 482);
            this.Name = "frmPrincipal";
            this.Text = "Euclides";
            ((System.ComponentModel.ISupportInitialize)(this.dgvNumeros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbModulo;
        private System.Windows.Forms.Label lblModulo;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.DataGridView dgvNumeros;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Invertible;
        private System.Windows.Forms.Label lblCalculadora;
        private System.Windows.Forms.TextBox txtbNumero1;
        private System.Windows.Forms.TextBox txtbNumero2;
        private System.Windows.Forms.Label lblNumero1;
        private System.Windows.Forms.Label lblNumero2;
        private System.Windows.Forms.Label LblModuloC;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txtbResultado;
        private System.Windows.Forms.Button btnCalcular;
    }
}

