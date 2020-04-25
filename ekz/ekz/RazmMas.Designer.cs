namespace ekz
{
    partial class RazmMas
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
            this.f2ok = new System.Windows.Forms.Button();
            this.lrm = new System.Windows.Forms.Label();
            this.f2nudmas = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.f2nudmas)).BeginInit();
            this.SuspendLayout();
            // 
            // f2ok
            // 
            this.f2ok.Location = new System.Drawing.Point(45, 127);
            this.f2ok.Name = "f2ok";
            this.f2ok.Size = new System.Drawing.Size(75, 23);
            this.f2ok.TabIndex = 0;
            this.f2ok.Text = "OK";
            this.f2ok.UseVisualStyleBackColor = true;
            this.f2ok.Click += new System.EventHandler(this.f2ok_Click);
            // 
            // lrm
            // 
            this.lrm.AutoSize = true;
            this.lrm.Location = new System.Drawing.Point(27, 36);
            this.lrm.Name = "lrm";
            this.lrm.Size = new System.Drawing.Size(93, 13);
            this.lrm.TabIndex = 2;
            this.lrm.Text = "Размер массива";
            // 
            // f2nudmas
            // 
            this.f2nudmas.Location = new System.Drawing.Point(30, 70);
            this.f2nudmas.Name = "f2nudmas";
            this.f2nudmas.Size = new System.Drawing.Size(120, 20);
            this.f2nudmas.TabIndex = 3;
            // 
            // RazmMas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(211, 180);
            this.Controls.Add(this.f2nudmas);
            this.Controls.Add(this.lrm);
            this.Controls.Add(this.f2ok);
            this.Name = "RazmMas";
            this.Text = "RazmMas";
            ((System.ComponentModel.ISupportInitialize)(this.f2nudmas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button f2ok;
        private System.Windows.Forms.Label lrm;
        private System.Windows.Forms.NumericUpDown f2nudmas;
    }
}