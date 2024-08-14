namespace tuan1_btvn
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
            this.txt_input = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_output = new System.Windows.Forms.TextBox();
            this.btn_sx = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btn_lamlai = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_input
            // 
            this.txt_input.Location = new System.Drawing.Point(210, 64);
            this.txt_input.Margin = new System.Windows.Forms.Padding(5);
            this.txt_input.Multiline = true;
            this.txt_input.Name = "txt_input";
            this.txt_input.Size = new System.Drawing.Size(438, 50);
            this.txt_input.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 77);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhap Day So";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 165);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ket Qua";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_output
            // 
            this.txt_output.Enabled = false;
            this.txt_output.Location = new System.Drawing.Point(210, 151);
            this.txt_output.Margin = new System.Windows.Forms.Padding(5);
            this.txt_output.Multiline = true;
            this.txt_output.Name = "txt_output";
            this.txt_output.Size = new System.Drawing.Size(438, 50);
            this.txt_output.TabIndex = 3;
            // 
            // btn_sx
            // 
            this.btn_sx.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_sx.Location = new System.Drawing.Point(742, 69);
            this.btn_sx.Name = "btn_sx";
            this.btn_sx.Size = new System.Drawing.Size(90, 36);
            this.btn_sx.TabIndex = 4;
            this.btn_sx.Text = "Sap Xep";
            this.btn_sx.UseVisualStyleBackColor = false;
            this.btn_sx.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_lamlai
            // 
            this.btn_lamlai.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_lamlai.Location = new System.Drawing.Point(742, 157);
            this.btn_lamlai.Name = "btn_lamlai";
            this.btn_lamlai.Size = new System.Drawing.Size(90, 36);
            this.btn_lamlai.TabIndex = 5;
            this.btn_lamlai.Text = "Lam Lai";
            this.btn_lamlai.UseVisualStyleBackColor = false;
            this.btn_lamlai.Click += new System.EventHandler(this.btn_lamlai_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 364);
            this.Controls.Add(this.btn_lamlai);
            this.Controls.Add(this.btn_sx);
            this.Controls.Add(this.txt_output);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_input);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_input;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_output;
        private System.Windows.Forms.Button btn_sx;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btn_lamlai;
    }
}