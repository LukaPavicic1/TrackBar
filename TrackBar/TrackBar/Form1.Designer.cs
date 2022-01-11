namespace TrackBar
{
    partial class Form1
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
            this.trackVolumen = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIspis = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackVolumen)).BeginInit();
            this.SuspendLayout();
            // 
            // trackVolumen
            // 
            this.trackVolumen.LargeChange = 20;
            this.trackVolumen.Location = new System.Drawing.Point(71, 62);
            this.trackVolumen.Maximum = 100;
            this.trackVolumen.Name = "trackVolumen";
            this.trackVolumen.Size = new System.Drawing.Size(186, 45);
            this.trackVolumen.TabIndex = 0;
            this.trackVolumen.Scroll += new System.EventHandler(this.trackVolumen_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Postavljena vrijednost je: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtIspis
            // 
            this.txtIspis.Location = new System.Drawing.Point(201, 122);
            this.txtIspis.Name = "txtIspis";
            this.txtIspis.Size = new System.Drawing.Size(66, 20);
            this.txtIspis.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtIspis);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackVolumen);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trackVolumen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trackVolumen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIspis;
    }
}

