namespace DönemlikStajProje
{
    partial class Mesajlaşma
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mesajlaşma));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.label1 = new System.Windows.Forms.Label();
			this.gönderen = new System.Windows.Forms.TextBox();
			this.alan = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.mesaj = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.btnGönder = new System.Windows.Forms.Button();
			this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.gridMesajlar = new System.Windows.Forms.DataGridView();
			this.timer2 = new System.Windows.Forms.Timer(this.components);
			this.KisiAdları = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.gridMesajlar)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(21, 37);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(129, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Gönderen Adı:";
			// 
			// gönderen
			// 
			this.gönderen.Location = new System.Drawing.Point(168, 38);
			this.gönderen.Name = "gönderen";
			this.gönderen.ReadOnly = true;
			this.gönderen.Size = new System.Drawing.Size(177, 22);
			this.gönderen.TabIndex = 1;
			// 
			// alan
			// 
			this.alan.FormattingEnabled = true;
			this.alan.Location = new System.Drawing.Point(168, 107);
			this.alan.Name = "alan";
			this.alan.Size = new System.Drawing.Size(177, 24);
			this.alan.TabIndex = 4;
			this.alan.SelectedIndexChanged += new System.EventHandler(this.alan_SelectedIndexChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(56, 107);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(58, 16);
			this.label2.TabIndex = 5;
			this.label2.Text = "Alıcı Adı:";
			// 
			// mesaj
			// 
			this.mesaj.Location = new System.Drawing.Point(30, 194);
			this.mesaj.Multiline = true;
			this.mesaj.Name = "mesaj";
			this.mesaj.Size = new System.Drawing.Size(315, 342);
			this.mesaj.TabIndex = 7;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(142, 155);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(47, 16);
			this.label3.TabIndex = 6;
			this.label3.Text = "Mesaj:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label4.Location = new System.Drawing.Point(747, 68);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(101, 20);
			this.label4.TabIndex = 8;
			this.label4.Text = "Mesajlarım";
			// 
			// btnGönder
			// 
			this.btnGönder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnGönder.ImageKey = "Gönder.png";
			this.btnGönder.ImageList = this.ımageList1;
			this.btnGönder.Location = new System.Drawing.Point(98, 543);
			this.btnGönder.Name = "btnGönder";
			this.btnGönder.Size = new System.Drawing.Size(166, 75);
			this.btnGönder.TabIndex = 2;
			this.btnGönder.Text = "Gönder";
			this.btnGönder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnGönder.UseVisualStyleBackColor = true;
			this.btnGönder.Click += new System.EventHandler(this.button2_Click);
			// 
			// ımageList1
			// 
			this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
			this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
			this.ımageList1.Images.SetKeyName(0, "Gönder.png");
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label5.Location = new System.Drawing.Point(56, 107);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(85, 20);
			this.label5.TabIndex = 5;
			this.label5.Text = "Alıcı Adı:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label6.Location = new System.Drawing.Point(142, 155);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(65, 20);
			this.label6.TabIndex = 6;
			this.label6.Text = "Mesaj:";
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Interval = 10000;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// gridMesajlar
			// 
			this.gridMesajlar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.gridMesajlar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.gridMesajlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.gridMesajlar.DefaultCellStyle = dataGridViewCellStyle2;
			this.gridMesajlar.Location = new System.Drawing.Point(370, 107);
			this.gridMesajlar.Name = "gridMesajlar";
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.gridMesajlar.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.gridMesajlar.RowHeadersWidth = 51;
			this.gridMesajlar.RowTemplate.Height = 24;
			this.gridMesajlar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.gridMesajlar.Size = new System.Drawing.Size(791, 472);
			this.gridMesajlar.TabIndex = 17;
			// 
			// timer2
			// 
			this.timer2.Interval = 2000;
			this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
			// 
			// KisiAdları
			// 
			this.KisiAdları.FormattingEnabled = true;
			this.KisiAdları.Location = new System.Drawing.Point(715, 12);
			this.KisiAdları.Name = "KisiAdları";
			this.KisiAdları.Size = new System.Drawing.Size(177, 24);
			this.KisiAdları.TabIndex = 18;
			this.KisiAdları.SelectedIndexChanged += new System.EventHandler(this.KisiAdları_SelectedIndexChanged);
			// 
			// Mesajlaşma
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1173, 630);
			this.Controls.Add(this.KisiAdları);
			this.Controls.Add(this.gridMesajlar);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.mesaj);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.alan);
			this.Controls.Add(this.btnGönder);
			this.Controls.Add(this.gönderen);
			this.Controls.Add(this.label1);
			this.Name = "Mesajlaşma";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Mesajlaşma";
			this.Load += new System.EventHandler(this.Mesajlaşma_Load);
			((System.ComponentModel.ISupportInitialize)(this.gridMesajlar)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox gönderen;
        private System.Windows.Forms.ComboBox alan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox mesaj;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGönder;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView gridMesajlar;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Timer timer2;
		private System.Windows.Forms.ComboBox KisiAdları;
	}
}