
namespace ADO_OKUL_Form
{
    partial class KayıtOl
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
            this.KayıtOlbtn = new System.Windows.Forms.Button();
            this.KayıtSifretxt = new System.Windows.Forms.TextBox();
            this.KayıtAdıtxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.KayıtGirişbtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // KayıtOlbtn
            // 
            this.KayıtOlbtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.KayıtOlbtn.FlatAppearance.BorderSize = 3;
            this.KayıtOlbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KayıtOlbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KayıtOlbtn.Location = new System.Drawing.Point(185, 288);
            this.KayıtOlbtn.Name = "KayıtOlbtn";
            this.KayıtOlbtn.Size = new System.Drawing.Size(100, 31);
            this.KayıtOlbtn.TabIndex = 3;
            this.KayıtOlbtn.Text = "Kayıt Ol";
            this.KayıtOlbtn.UseVisualStyleBackColor = true;
            this.KayıtOlbtn.Click += new System.EventHandler(this.KayıtOlbtn_Click);
            // 
            // KayıtSifretxt
            // 
            this.KayıtSifretxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KayıtSifretxt.Location = new System.Drawing.Point(185, 194);
            this.KayıtSifretxt.Name = "KayıtSifretxt";
            this.KayıtSifretxt.Size = new System.Drawing.Size(100, 27);
            this.KayıtSifretxt.TabIndex = 6;
            // 
            // KayıtAdıtxt
            // 
            this.KayıtAdıtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KayıtAdıtxt.Location = new System.Drawing.Point(185, 157);
            this.KayıtAdıtxt.Name = "KayıtAdıtxt";
            this.KayıtAdıtxt.Size = new System.Drawing.Size(100, 27);
            this.KayıtAdıtxt.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(111, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Şifre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(34, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // KayıtGirişbtn
            // 
            this.KayıtGirişbtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.KayıtGirişbtn.FlatAppearance.BorderSize = 3;
            this.KayıtGirişbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KayıtGirişbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KayıtGirişbtn.Location = new System.Drawing.Point(68, 288);
            this.KayıtGirişbtn.Name = "KayıtGirişbtn";
            this.KayıtGirişbtn.Size = new System.Drawing.Size(100, 31);
            this.KayıtGirişbtn.TabIndex = 8;
            this.KayıtGirişbtn.Text = "Giriş";
            this.KayıtGirişbtn.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(102, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "KAYIT FORMU";
            // 
            // KayıtOl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(371, 454);
            this.Controls.Add(this.KayıtGirişbtn);
            this.Controls.Add(this.KayıtSifretxt);
            this.Controls.Add(this.KayıtAdıtxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.KayıtOlbtn);
            this.Name = "KayıtOl";
            this.Text = "KayıtOl";
           // this.Load += new System.EventHandler(this.KayıtOl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button KayıtOlbtn;
        private System.Windows.Forms.TextBox KayıtSifretxt;
        private System.Windows.Forms.TextBox KayıtAdıtxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button KayıtGirişbtn;
        private System.Windows.Forms.Label label3;
    }
}