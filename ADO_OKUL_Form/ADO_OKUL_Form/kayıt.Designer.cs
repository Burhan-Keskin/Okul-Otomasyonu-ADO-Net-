
namespace ADO_OKUL_Form
{
    partial class kayıt
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.KulAdıtxt = new System.Windows.Forms.TextBox();
            this.Girişbtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Gıdtxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(31, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(108, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "İD:";
            // 
            // KulAdıtxt
            // 
            this.KulAdıtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KulAdıtxt.Location = new System.Drawing.Point(182, 133);
            this.KulAdıtxt.Name = "KulAdıtxt";
            this.KulAdıtxt.Size = new System.Drawing.Size(100, 27);
            this.KulAdıtxt.TabIndex = 1;
            // 
            // Girişbtn
            // 
            this.Girişbtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Girişbtn.FlatAppearance.BorderSize = 3;
            this.Girişbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Girişbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Girişbtn.Location = new System.Drawing.Point(182, 262);
            this.Girişbtn.Name = "Girişbtn";
            this.Girişbtn.Size = new System.Drawing.Size(100, 31);
            this.Girişbtn.TabIndex = 2;
            this.Girişbtn.Text = "Giriş";
            this.Girişbtn.UseVisualStyleBackColor = true;
            this.Girişbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(94, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "GİRİŞ EKRANI";
            // 
            // Gıdtxt
            // 
            this.Gıdtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Gıdtxt.Location = new System.Drawing.Point(182, 167);
            this.Gıdtxt.Name = "Gıdtxt";
            this.Gıdtxt.Size = new System.Drawing.Size(100, 27);
            this.Gıdtxt.TabIndex = 1;
            // 
            // kayıt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(335, 370);
            this.Controls.Add(this.Girişbtn);
            this.Controls.Add(this.Gıdtxt);
            this.Controls.Add(this.KulAdıtxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "kayıt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "kayıt Ol";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox KulAdıtxt;
        private System.Windows.Forms.Button Girişbtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Gıdtxt;
    }
}