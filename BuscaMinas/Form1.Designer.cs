namespace BuscaMinas
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.altoNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.minasNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.anchoNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.altoNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minasNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anchoNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(12, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(396, 261);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
            // 
            // altoNumericUpDown
            // 
            this.altoNumericUpDown.Location = new System.Drawing.Point(46, 9);
            this.altoNumericUpDown.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.altoNumericUpDown.Name = "altoNumericUpDown";
            this.altoNumericUpDown.Size = new System.Drawing.Size(59, 20);
            this.altoNumericUpDown.TabIndex = 1;
            this.altoNumericUpDown.Value = new decimal(new int[] {
            9,
            0,
            0,
            0});
            // 
            // minasNumericUpDown
            // 
            this.minasNumericUpDown.Location = new System.Drawing.Point(267, 9);
            this.minasNumericUpDown.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.minasNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.minasNumericUpDown.Name = "minasNumericUpDown";
            this.minasNumericUpDown.Size = new System.Drawing.Size(59, 20);
            this.minasNumericUpDown.TabIndex = 2;
            this.minasNumericUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // anchoNumericUpDown
            // 
            this.anchoNumericUpDown.Location = new System.Drawing.Point(158, 9);
            this.anchoNumericUpDown.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.anchoNumericUpDown.Name = "anchoNumericUpDown";
            this.anchoNumericUpDown.Size = new System.Drawing.Size(59, 20);
            this.anchoNumericUpDown.TabIndex = 3;
            this.anchoNumericUpDown.Value = new decimal(new int[] {
            9,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Alto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ancho:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(223, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Minas:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(332, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Modificar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 308);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.minasNumericUpDown);
            this.Controls.Add(this.anchoNumericUpDown);
            this.Controls.Add(this.altoNumericUpDown);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Buscaminas by rafael1193";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.altoNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minasNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anchoNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown altoNumericUpDown;
        private System.Windows.Forms.NumericUpDown minasNumericUpDown;
        private System.Windows.Forms.NumericUpDown anchoNumericUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}

