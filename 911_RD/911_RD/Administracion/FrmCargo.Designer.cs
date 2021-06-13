namespace _911_RD.Administracion
{
    partial class FrmCargo
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
            this.label10 = new System.Windows.Forms.Label();
            this.errorTxtBox5 = new _911_RD.ErrorTxtBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btn_buscar)).BeginInit();
            this.SuspendLayout();
            // 
            // label15
            // 
            this.label15.Size = new System.Drawing.Size(153, 19);
            this.label15.Text = "DATOS DEL CARGO";
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(12, 458);
            // 
            // label1
            // 
            this.lbl_titulo.Size = new System.Drawing.Size(267, 32);
            this.lbl_titulo.Text = "CARGO EMPLEADO";
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Location = new System.Drawing.Point(157, 458);
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(279, 458);
            // 
            // label3
            // 
            // 
            // errorTxtBox1
            // 
            this.errorTxtBox1.Location = new System.Drawing.Point(923, 108);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label10.Location = new System.Drawing.Point(9, 137);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 16);
            this.label10.TabIndex = 157;
            this.label10.Text = "CARGO";
            // 
            // errorTxtBox5
            // 
            this.errorTxtBox5.Enabled = false;
            this.errorTxtBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.errorTxtBox5.Limpiar = false;
            this.errorTxtBox5.Location = new System.Drawing.Point(9, 156);
            this.errorTxtBox5.Name = "errorTxtBox5";
            this.errorTxtBox5.Size = new System.Drawing.Size(148, 26);
            this.errorTxtBox5.TabIndex = 156;
            this.errorTxtBox5.Validar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(9, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 159;
            this.label2.Text = "SALARIO";
            // 
            // FrmCargo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 535);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.errorTxtBox5);
            this.Name = "FrmCargo";
            this.Text = "FrmCargo";
            this.Controls.SetChildIndex(this.errorTxtBox5, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.errorTxtBox1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.lbl_titulo, 0);
            this.Controls.SetChildIndex(this.btn_guardar, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.label15, 0);
            this.Controls.SetChildIndex(this.btn_buscar, 0);
            this.Controls.SetChildIndex(this.btn_limpiar, 0);
            this.Controls.SetChildIndex(this.btn_salir, 0);
            this.Controls.SetChildIndex(this.id_txt, 0);
            ((System.ComponentModel.ISupportInitialize)(this.btn_buscar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private ErrorTxtBox errorTxtBox5;
        private System.Windows.Forms.Label label2;
        private ErrorTxtBox errorTxtBox1;
    }
}