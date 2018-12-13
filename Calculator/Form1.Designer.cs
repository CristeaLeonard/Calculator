namespace Calculator
{
    partial class Calculator
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
            this.TextBox = new System.Windows.Forms.TextBox();
            this.Calculeaza = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Mesaj = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TextBox
            // 
            this.TextBox.Location = new System.Drawing.Point(165, 77);
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(510, 20);
            this.TextBox.TabIndex = 0;
            this.TextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // Calculeaza
            // 
            this.Calculeaza.Location = new System.Drawing.Point(330, 294);
            this.Calculeaza.Name = "Calculeaza";
            this.Calculeaza.Size = new System.Drawing.Size(177, 50);
            this.Calculeaza.TabIndex = 1;
            this.Calculeaza.Text = "Calculeaza";
            this.Calculeaza.UseVisualStyleBackColor = true;
            this.Calculeaza.Click += new System.EventHandler(this.Calculeaza_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(356, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Calculeaza daca e prim";
            // 
            // Mesaj
            // 
            this.Mesaj.AutoSize = true;
            this.Mesaj.Location = new System.Drawing.Point(359, 202);
            this.Mesaj.Name = "Mesaj";
            this.Mesaj.Size = new System.Drawing.Size(0, 13);
            this.Mesaj.TabIndex = 3;
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Mesaj);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Calculeaza);
            this.Controls.Add(this.TextBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Calculator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBox;
        private System.Windows.Forms.Button Calculeaza;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Mesaj;
    }
}

