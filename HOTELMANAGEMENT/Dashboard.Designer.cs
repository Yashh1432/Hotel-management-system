namespace HOTELMANAGEMENT
{
    partial class Dashboard
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.rbtnAC = new System.Windows.Forms.RadioButton();
            this.tblRoomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rbtnNonac = new System.Windows.Forms.RadioButton();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRoomno = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tblRoomsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Single Bad ",
            "Double Bad",
            "Triple Bad"});
            this.comboBox1.Location = new System.Drawing.Point(782, 321);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(456, 45);
            this.comboBox1.TabIndex = 33;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // rbtnAC
            // 
            this.rbtnAC.AutoSize = true;
            this.rbtnAC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.rbtnAC.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Bold);
            this.rbtnAC.ForeColor = System.Drawing.Color.Gray;
            this.rbtnAC.Location = new System.Drawing.Point(843, 205);
            this.rbtnAC.Name = "rbtnAC";
            this.rbtnAC.Size = new System.Drawing.Size(72, 37);
            this.rbtnAC.TabIndex = 31;
            this.rbtnAC.TabStop = true;
            this.rbtnAC.Text = "AC";
            this.rbtnAC.UseVisualStyleBackColor = true;
            this.rbtnAC.CheckedChanged += new System.EventHandler(this.rbtnAC_CheckedChanged);
            // 
            // tblRoomsBindingSource
            // 
            this.tblRoomsBindingSource.DataMember = "tblRooms";
            // 
            // rbtnNonac
            // 
            this.rbtnNonac.AutoSize = true;
            this.rbtnNonac.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Bold);
            this.rbtnNonac.ForeColor = System.Drawing.Color.Gray;
            this.rbtnNonac.Location = new System.Drawing.Point(1007, 205);
            this.rbtnNonac.Name = "rbtnNonac";
            this.rbtnNonac.Size = new System.Drawing.Size(136, 37);
            this.rbtnNonac.TabIndex = 32;
            this.rbtnNonac.TabStop = true;
            this.rbtnNonac.Text = "Non-AC";
            this.rbtnNonac.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(12, 24);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(747, 638);
            this.dataGridView3.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 17F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(776, 382);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 36);
            this.label5.TabIndex = 29;
            this.label5.Text = "Price";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 17F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(776, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 36);
            this.label4.TabIndex = 28;
            this.label4.Text = "No of Bad";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 17F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(776, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 36);
            this.label3.TabIndex = 27;
            this.label3.Text = "Room Type";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 17F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(776, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 36);
            this.label2.TabIndex = 26;
            this.label2.Text = "Room Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 28F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(-15, -47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(397, 56);
            this.label1.TabIndex = 24;
            this.label1.Text = "Add New Room";
            // 
            // txtRoomno
            // 
            this.txtRoomno.Location = new System.Drawing.Point(782, 94);
            this.txtRoomno.Name = "txtRoomno";
            this.txtRoomno.Size = new System.Drawing.Size(456, 22);
            this.txtRoomno.TabIndex = 34;
            this.txtRoomno.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(782, 442);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(456, 22);
            this.txtPrice.TabIndex = 35;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(791, 514);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 43);
            this.button1.TabIndex = 36;
            this.button1.Text = "Add Room";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(953, 514);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 43);
            this.button2.TabIndex = 37;
            this.button2.Text = "Update Room";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1114, 514);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(124, 43);
            this.button3.TabIndex = 38;
            this.button3.Text = "DeleteRoom";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button4.Location = new System.Drawing.Point(791, 597);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(447, 43);
            this.button4.TabIndex = 39;
            this.button4.Text = "GO TO DASHBOARD";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1302, 674);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtRoomno);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.rbtnAC);
            this.Controls.Add(this.rbtnNonac);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblRoomsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RadioButton rbtnAC;
        private System.Windows.Forms.BindingSource tblRoomsBindingSource;
        private System.Windows.Forms.RadioButton rbtnNonac;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRoomno;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}