namespace _911_RD
{
    partial class Seleccion_Und
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
            this.cb_ambulancia = new System.Windows.Forms.CheckBox();
            this.cb_policia = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cb_ambulancia
            // 
            this.cb_ambulancia.AutoSize = true;
            this.cb_ambulancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_ambulancia.ForeColor = System.Drawing.Color.Gray;
            this.cb_ambulancia.Image = global::_911_RD.Properties.Resources.ambulancia;
            this.cb_ambulancia.Location = new System.Drawing.Point(47, 94);
            this.cb_ambulancia.Name = "cb_ambulancia";
            this.cb_ambulancia.Size = new System.Drawing.Size(143, 88);
            this.cb_ambulancia.TabIndex = 0;
            this.cb_ambulancia.Text = "AMBULANCIA";
            this.cb_ambulancia.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cb_ambulancia.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.cb_ambulancia.UseVisualStyleBackColor = true;
            // 
            // cb_policia
            // 
            this.cb_policia.AutoSize = true;
            this.cb_policia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_policia.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.cb_policia.Image = global::_911_RD.Properties.Resources.policia;
            this.cb_policia.Location = new System.Drawing.Point(387, 94);
            this.cb_policia.Name = "cb_policia";
            this.cb_policia.Size = new System.Drawing.Size(98, 77);
            this.cb_policia.TabIndex = 2;
            this.cb_policia.Text = "POLICIA";
            this.cb_policia.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cb_policia.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.cb_policia.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.checkBox2.Image = global::_911_RD.Properties.Resources.bombero;
            this.checkBox2.Location = new System.Drawing.Point(224, 94);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(117, 88);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "BOMBERO";
            this.checkBox2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.checkBox2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(120, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "UNIDADES SOLICITADAS";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(282, 219);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 53);
            this.button1.TabIndex = 4;
            this.button1.Text = "ENVIAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Maroon;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(106, 219);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 53);
            this.button2.TabIndex = 5;
            this.button2.Text = "CANCELAR";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Seleccion_Und
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(537, 306);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_policia);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.cb_ambulancia);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Seleccion_Und";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seleccion_Und";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cb_ambulancia;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox cb_policia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}