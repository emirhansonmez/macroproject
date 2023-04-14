
namespace WinFormsApp1
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_R = new System.Windows.Forms.Button();
            this.btn_2 = new System.Windows.Forms.Button();
            this.btn_T = new System.Windows.Forms.Button();
            this.btn_Q = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_start);
            this.panel1.Controls.Add(this.btn_R);
            this.panel1.Controls.Add(this.btn_2);
            this.panel1.Controls.Add(this.btn_T);
            this.panel1.Controls.Add(this.btn_Q);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(313, 262);
            this.panel1.TabIndex = 0;
            // 
            // btn_start
            // 
            this.btn_start.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_start.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_start.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_start.Location = new System.Drawing.Point(12, 203);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(277, 47);
            this.btn_start.TabIndex = 8;
            this.btn_start.Text = "Başlat(Capslock)";
            this.btn_start.UseVisualStyleBackColor = false;
            // 
            // btn_R
            // 
            this.btn_R.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_R.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_R.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_R.Location = new System.Drawing.Point(178, 12);
            this.btn_R.Name = "btn_R";
            this.btn_R.Size = new System.Drawing.Size(111, 67);
            this.btn_R.TabIndex = 7;
            this.btn_R.Text = "R";
            this.btn_R.UseVisualStyleBackColor = false;
            this.btn_R.Click += new System.EventHandler(this.btn_R_Click);
            // 
            // btn_2
            // 
            this.btn_2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_2.Location = new System.Drawing.Point(12, 118);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(111, 67);
            this.btn_2.TabIndex = 6;
            this.btn_2.Text = "2";
            this.btn_2.UseVisualStyleBackColor = false;
            this.btn_2.Click += new System.EventHandler(this.btn_2_Click);
            // 
            // btn_T
            // 
            this.btn_T.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_T.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_T.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_T.Location = new System.Drawing.Point(178, 118);
            this.btn_T.Name = "btn_T";
            this.btn_T.Size = new System.Drawing.Size(111, 67);
            this.btn_T.TabIndex = 5;
            this.btn_T.Text = "T";
            this.btn_T.UseVisualStyleBackColor = false;
            this.btn_T.Click += new System.EventHandler(this.btn_T_Click);
            // 
            // btn_Q
            // 
            this.btn_Q.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_Q.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Q.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Q.Location = new System.Drawing.Point(12, 12);
            this.btn_Q.Name = "btn_Q";
            this.btn_Q.Size = new System.Drawing.Size(111, 67);
            this.btn_Q.TabIndex = 0;
            this.btn_Q.Text = "Q";
            this.btn_Q.UseVisualStyleBackColor = false;
            this.btn_Q.Click += new System.EventHandler(this.btn_Q_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 262);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Hesap Makinesi";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Q;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_R;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.Button btn_T;
        private System.Windows.Forms.Timer timer1;
    }
}

