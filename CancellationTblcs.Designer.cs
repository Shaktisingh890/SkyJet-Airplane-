namespace Airline_Management_System
{
    partial class CancellationTblcs
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
            label2 = new Label();
            label1 = new Label();
            textBox2 = new TextBox();
            label8 = new Label();
            comboBox1 = new ComboBox();
            label7 = new Label();
            textBox3 = new TextBox();
            label5 = new Label();
            label4 = new Label();
            comboBox2 = new ComboBox();
            dataGridView1 = new DataGridView();
            label12 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(293, 68);
            label2.Name = "label2";
            label2.Size = new Size(226, 37);
            label2.TabIndex = 6;
            label2.Text = "Ticket Booking";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(293, 16);
            label1.Name = "label1";
            label1.Size = new Size(215, 37);
            label1.TabIndex = 5;
            label1.Text = "Sky Jet Airline";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            textBox2.Location = new Point(594, 203);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(195, 34);
            textBox2.TabIndex = 69;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.MidnightBlue;
            label8.Location = new Point(442, 213);
            label8.Name = "label8";
            label8.Size = new Size(65, 27);
            label8.TabIndex = 66;
            label8.Text = "Date";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(186, 216);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(195, 28);
            comboBox1.TabIndex = 65;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.MidnightBlue;
            label7.Location = new Point(35, 216);
            label7.Name = "label7";
            label7.Size = new Size(134, 27);
            label7.TabIndex = 63;
            label7.Text = "FlightCode";
            label7.Click += label7_Click;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            textBox3.Location = new Point(186, 128);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(195, 34);
            textBox3.TabIndex = 73;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.MidnightBlue;
            label5.Location = new Point(35, 135);
            label5.Name = "label5";
            label5.Size = new Size(99, 27);
            label5.TabIndex = 72;
            label5.Text = "TicketId";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.MidnightBlue;
            label4.Location = new Point(442, 131);
            label4.Name = "label4";
            label4.Size = new Size(99, 27);
            label4.TabIndex = 70;
            label4.Text = "Ticketid";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(594, 138);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(195, 28);
            comboBox2.TabIndex = 74;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(1, 376);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(835, 313);
            dataGridView1.TabIndex = 76;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.Red;
            label12.Location = new Point(303, 309);
            label12.Name = "label12";
            label12.Size = new Size(237, 34);
            label12.TabIndex = 75;
            label12.Text = "Cancellation List";
            // 
            // CancellationTblcs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(834, 701);
            Controls.Add(dataGridView1);
            Controls.Add(label12);
            Controls.Add(comboBox2);
            Controls.Add(textBox3);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label8);
            Controls.Add(comboBox1);
            Controls.Add(label7);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CancellationTblcs";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CancellationTblcs";
            Load += CancellationTblcs_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private TextBox textBox2;
        private Label label8;
        private ComboBox comboBox1;
        private Label label7;
        private TextBox textBox3;
        private Label label5;
        private Label label4;
        private ComboBox comboBox2;
        private DataGridView dataGridView1;
        private Label label12;
    }
}