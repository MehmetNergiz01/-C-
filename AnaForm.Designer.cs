namespace OtobusBiletSatisi
{
    partial class AnaForm
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
            this.components = new System.ComponentModel.Container();
            this.txt_duzen = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_otobus = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.koltukDüzenPatternAlanıGösterGizleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_duzen
            // 
            this.txt_duzen.Dock = System.Windows.Forms.DockStyle.Left;
            this.txt_duzen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_duzen.Location = new System.Drawing.Point(224, 47);
            this.txt_duzen.Multiline = true;
            this.txt_duzen.Name = "txt_duzen";
            this.txt_duzen.Size = new System.Drawing.Size(54, 500);
            this.txt_duzen.TabIndex = 0;
            this.txt_duzen.Text = "** **\r\n** **\r\n** **\r\n** **\r\n** **\r\n**\r\n** **\r\n** **\r\n** **\r\n** **\r\n** **\r\n*****\r\n" +
    "";
            this.txt_duzen.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(224, 500);
            this.panel1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(278, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(963, 500);
            this.dataGridView1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.cmb_otobus);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1241, 47);
            this.panel2.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Tomato;
            this.button3.Dock = System.Windows.Forms.DockStyle.Right;
            this.button3.Location = new System.Drawing.Point(893, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(87, 47);
            this.button3.TabIndex = 4;
            this.button3.Text = "Boş";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.GreenYellow;
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.Location = new System.Drawing.Point(980, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 47);
            this.button1.TabIndex = 2;
            this.button1.Text = "Satıldı";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gösterilecek Otobüsü Seçin";
            // 
            // cmb_otobus
            // 
            this.cmb_otobus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmb_otobus.FormattingEnabled = true;
            this.cmb_otobus.Location = new System.Drawing.Point(251, 11);
            this.cmb_otobus.Name = "cmb_otobus";
            this.cmb_otobus.Size = new System.Drawing.Size(152, 28);
            this.cmb_otobus.TabIndex = 0;
            this.cmb_otobus.SelectedIndexChanged += new System.EventHandler(this.cmb_otobus_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Yellow;
            this.button2.Dock = System.Windows.Forms.DockStyle.Right;
            this.button2.Location = new System.Drawing.Point(1067, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 47);
            this.button2.TabIndex = 3;
            this.button2.Text = "Rezerve";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.koltukDüzenPatternAlanıGösterGizleToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(289, 26);
            // 
            // koltukDüzenPatternAlanıGösterGizleToolStripMenuItem
            // 
            this.koltukDüzenPatternAlanıGösterGizleToolStripMenuItem.Name = "koltukDüzenPatternAlanıGösterGizleToolStripMenuItem";
            this.koltukDüzenPatternAlanıGösterGizleToolStripMenuItem.Size = new System.Drawing.Size(288, 22);
            this.koltukDüzenPatternAlanıGösterGizleToolStripMenuItem.Text = "Koltuk Düzen Pattern Alanı Göster / Gizle";
            this.koltukDüzenPatternAlanıGösterGizleToolStripMenuItem.Click += new System.EventHandler(this.koltukDüzenPatternAlanıGösterGizleToolStripMenuItem_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Black;
            this.button4.Dock = System.Windows.Forms.DockStyle.Right;
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(1154, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(87, 47);
            this.button4.TabIndex = 5;
            this.button4.Text = "Kullanılamaz";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 547);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_duzen);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "AnaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AnaForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_duzen;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_otobus;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem koltukDüzenPatternAlanıGösterGizleToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

