namespace FormProje_G221210039_DilaraÇetin
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbSekil1 = new System.Windows.Forms.ComboBox();
            this.cmbSekil2 = new System.Windows.Forms.ComboBox();
            this.btnDraw = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbSekil1
            // 
            this.cmbSekil1.FormattingEnabled = true;
            this.cmbSekil1.Location = new System.Drawing.Point(1351, 110);
            this.cmbSekil1.Name = "cmbSekil1";
            this.cmbSekil1.Size = new System.Drawing.Size(185, 28);
            this.cmbSekil1.TabIndex = 0;
            // 
            // cmbSekil2
            // 
            this.cmbSekil2.FormattingEnabled = true;
            this.cmbSekil2.Location = new System.Drawing.Point(1351, 188);
            this.cmbSekil2.Name = "cmbSekil2";
            this.cmbSekil2.Size = new System.Drawing.Size(185, 28);
            this.cmbSekil2.TabIndex = 1;
            // 
            // btnDraw
            // 
            this.btnDraw.Location = new System.Drawing.Point(1403, 237);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(94, 29);
            this.btnDraw.TabIndex = 2;
            this.btnDraw.Text = "Çiz";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1351, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cisim 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1351, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cisim 2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1565, 551);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDraw);
            this.Controls.Add(this.cmbSekil2);
            this.Controls.Add(this.cmbSekil1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cmbSekil1;
        private ComboBox cmbSekil2;
        private Button btnDraw;
        private Label label1;
        private Label label2;
    }
}