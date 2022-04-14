namespace CarCheck
{
    partial class foremanPanel
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
            this.label12 = new System.Windows.Forms.Label();
            this.CBModel2 = new System.Windows.Forms.ComboBox();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.CBCategory4 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnProduce = new System.Windows.Forms.Button();
            this.TBProduce = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label12.Location = new System.Drawing.Point(27, 316);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 24);
            this.label12.TabIndex = 28;
            this.label12.Text = "Model";
            // 
            // CBModel2
            // 
            this.CBModel2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBModel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.CBModel2.FormattingEnabled = true;
            this.CBModel2.Location = new System.Drawing.Point(30, 343);
            this.CBModel2.Name = "CBModel2";
            this.CBModel2.Size = new System.Drawing.Size(682, 32);
            this.CBModel2.TabIndex = 27;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(1008, 42);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView3.Size = new System.Drawing.Size(377, 99);
            this.dataGridView3.TabIndex = 25;
            // 
            // CBCategory4
            // 
            this.CBCategory4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBCategory4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.CBCategory4.FormattingEnabled = true;
            this.CBCategory4.Location = new System.Drawing.Point(30, 269);
            this.CBCategory4.Name = "CBCategory4";
            this.CBCategory4.Size = new System.Drawing.Size(682, 32);
            this.CBCategory4.TabIndex = 24;
            this.CBCategory4.SelectedIndexChanged += new System.EventHandler(this.CBCategory4_SelectedIndexChanged_1);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label11.Location = new System.Drawing.Point(27, 241);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 24);
            this.label11.TabIndex = 23;
            this.label11.Text = "Категория";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(497, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(473, 61);
            this.label1.TabIndex = 22;
            this.label1.Text = "Панель бригадира";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox1.Location = new System.Drawing.Point(-2, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1477, 162);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // btnProduce
            // 
            this.btnProduce.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnProduce.Location = new System.Drawing.Point(32, 402);
            this.btnProduce.Name = "btnProduce";
            this.btnProduce.Size = new System.Drawing.Size(682, 56);
            this.btnProduce.TabIndex = 26;
            this.btnProduce.Text = "Произвести";
            this.btnProduce.UseVisualStyleBackColor = true;
            this.btnProduce.Click += new System.EventHandler(this.btnProduce_Click);
            // 
            // TBProduce
            // 
            this.TBProduce.BackColor = System.Drawing.SystemColors.Window;
            this.TBProduce.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.TBProduce.Location = new System.Drawing.Point(32, 204);
            this.TBProduce.Name = "TBProduce";
            this.TBProduce.Size = new System.Drawing.Size(349, 29);
            this.TBProduce.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(26, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(321, 24);
            this.label2.TabIndex = 30;
            this.label2.Text = "Количество техники произведено";
            // 
            // foremanPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1472, 861);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TBProduce);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.CBModel2);
            this.Controls.Add(this.CBCategory4);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnProduce);
            this.Controls.Add(this.dataGridView3);
            this.Name = "foremanPanel";
            this.Text = "foremanPanel";
            this.Load += new System.EventHandler(this.foremanPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox CBModel2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.ComboBox CBCategory4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnProduce;
        private System.Windows.Forms.TextBox TBProduce;
        private System.Windows.Forms.Label label2;
    }
}