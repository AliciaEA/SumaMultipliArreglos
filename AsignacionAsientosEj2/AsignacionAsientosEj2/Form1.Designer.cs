namespace AsignacionAsientosEj2
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
            this.button1 = new System.Windows.Forms.Button();
            this.tbAsiento = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbSeccion = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MingLiU-ExtB", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(388, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Asignacion de Asientos";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.Image = global::AsignacionAsientosEj2.Properties.Resources.Avion;
            this.button1.Location = new System.Drawing.Point(101, 163);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(332, 316);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbAsiento
            // 
            this.tbAsiento.Location = new System.Drawing.Point(32, 541);
            this.tbAsiento.Name = "tbAsiento";
            this.tbAsiento.Size = new System.Drawing.Size(469, 31);
            this.tbAsiento.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 507);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Asiento Asignado:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 30);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sección:";
            // 
            // cmbSeccion
            // 
            this.cmbSeccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSeccion.FormattingEnabled = true;
            this.cmbSeccion.Items.AddRange(new object[] {
            "Fumadores",
            "No Fumadores"});
            this.cmbSeccion.Location = new System.Drawing.Point(179, 108);
            this.cmbSeccion.Name = "cmbSeccion";
            this.cmbSeccion.Size = new System.Drawing.Size(121, 28);
            this.cmbSeccion.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(532, 598);
            this.Controls.Add(this.cmbSeccion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbAsiento);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("MingLiU-ExtB", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbAsiento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbSeccion;
    }
}

