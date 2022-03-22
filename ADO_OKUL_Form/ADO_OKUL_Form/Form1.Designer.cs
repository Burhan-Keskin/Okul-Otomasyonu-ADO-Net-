
namespace ADO_OKUL_Form
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.TumLbtn = new System.Windows.Forms.Button();
            this.Silbtn = new System.Windows.Forms.Button();
            this.Guncellebtn = new System.Windows.Forms.Button();
            this.Arabtn = new System.Windows.Forms.Button();
            this.Eklebtn = new System.Windows.Forms.Button();
            this.Idtxt = new System.Windows.Forms.TextBox();
            this.soyadıtxt = new System.Windows.Forms.TextBox();
            this.Adıtxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.TumLbtn);
            this.panel1.Controls.Add(this.Silbtn);
            this.panel1.Controls.Add(this.Guncellebtn);
            this.panel1.Controls.Add(this.Arabtn);
            this.panel1.Controls.Add(this.Eklebtn);
            this.panel1.Controls.Add(this.Idtxt);
            this.panel1.Controls.Add(this.soyadıtxt);
            this.panel1.Controls.Add(this.Adıtxt);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(558, 138);
            this.panel1.TabIndex = 0;
            // 
            // TumLbtn
            // 
            this.TumLbtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.TumLbtn.FlatAppearance.BorderSize = 2;
            this.TumLbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cornsilk;
            this.TumLbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TumLbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TumLbtn.Location = new System.Drawing.Point(403, 95);
            this.TumLbtn.Name = "TumLbtn";
            this.TumLbtn.Size = new System.Drawing.Size(89, 32);
            this.TumLbtn.TabIndex = 2;
            this.TumLbtn.Text = "Tüm Liste";
            this.TumLbtn.UseVisualStyleBackColor = true;
            this.TumLbtn.Click += new System.EventHandler(this.TumLbtn_Click);
            // 
            // Silbtn
            // 
            this.Silbtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Silbtn.FlatAppearance.BorderSize = 2;
            this.Silbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cornsilk;
            this.Silbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Silbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Silbtn.Location = new System.Drawing.Point(308, 95);
            this.Silbtn.Name = "Silbtn";
            this.Silbtn.Size = new System.Drawing.Size(89, 32);
            this.Silbtn.TabIndex = 2;
            this.Silbtn.Text = "Sil";
            this.Silbtn.UseVisualStyleBackColor = true;
            this.Silbtn.Click += new System.EventHandler(this.Silbtn_Click);
            // 
            // Guncellebtn
            // 
            this.Guncellebtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Guncellebtn.FlatAppearance.BorderSize = 2;
            this.Guncellebtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cornsilk;
            this.Guncellebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Guncellebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Guncellebtn.Location = new System.Drawing.Point(213, 95);
            this.Guncellebtn.Name = "Guncellebtn";
            this.Guncellebtn.Size = new System.Drawing.Size(89, 32);
            this.Guncellebtn.TabIndex = 2;
            this.Guncellebtn.Text = "Güncelle";
            this.Guncellebtn.UseVisualStyleBackColor = true;
            this.Guncellebtn.Click += new System.EventHandler(this.Guncellebtn_Click);
            // 
            // Arabtn
            // 
            this.Arabtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Arabtn.FlatAppearance.BorderSize = 2;
            this.Arabtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cornsilk;
            this.Arabtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Arabtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Arabtn.Location = new System.Drawing.Point(118, 95);
            this.Arabtn.Name = "Arabtn";
            this.Arabtn.Size = new System.Drawing.Size(89, 32);
            this.Arabtn.TabIndex = 2;
            this.Arabtn.Text = "Ara";
            this.Arabtn.UseVisualStyleBackColor = true;
            this.Arabtn.Click += new System.EventHandler(this.Arabtn_Click);
            // 
            // Eklebtn
            // 
            this.Eklebtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Eklebtn.FlatAppearance.BorderSize = 2;
            this.Eklebtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cornsilk;
            this.Eklebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Eklebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Eklebtn.Location = new System.Drawing.Point(23, 95);
            this.Eklebtn.Name = "Eklebtn";
            this.Eklebtn.Size = new System.Drawing.Size(89, 32);
            this.Eklebtn.TabIndex = 2;
            this.Eklebtn.Text = "Ekle";
            this.Eklebtn.UseVisualStyleBackColor = true;
            this.Eklebtn.Click += new System.EventHandler(this.Eklebtn_Click);
            // 
            // Idtxt
            // 
            this.Idtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Idtxt.Location = new System.Drawing.Point(271, 9);
            this.Idtxt.Name = "Idtxt";
            this.Idtxt.Size = new System.Drawing.Size(100, 30);
            this.Idtxt.TabIndex = 1;
            this.Idtxt.Visible = false;
            // 
            // soyadıtxt
            // 
            this.soyadıtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.soyadıtxt.Location = new System.Drawing.Point(129, 45);
            this.soyadıtxt.Name = "soyadıtxt";
            this.soyadıtxt.Size = new System.Drawing.Size(100, 30);
            this.soyadıtxt.TabIndex = 1;
            // 
            // Adıtxt
            // 
            this.Adıtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Adıtxt.Location = new System.Drawing.Point(129, 9);
            this.Adıtxt.Name = "Adıtxt";
            this.Adıtxt.Size = new System.Drawing.Size(100, 30);
            this.Adıtxt.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(29, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Soyadı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(63, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adı:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 138);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(558, 255);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 371);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(558, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 393);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Okul Uygulaması";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button TumLbtn;
        private System.Windows.Forms.Button Silbtn;
        private System.Windows.Forms.Button Guncellebtn;
        private System.Windows.Forms.Button Arabtn;
        private System.Windows.Forms.Button Eklebtn;
        private System.Windows.Forms.TextBox Idtxt;
        private System.Windows.Forms.TextBox soyadıtxt;
        private System.Windows.Forms.TextBox Adıtxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

