namespace MEdecineFinal
{
    partial class PacientInformation
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
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            button3 = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1123, 528);
            dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(12, 562);
            button1.Name = "button1";
            button1.Size = new Size(142, 50);
            button1.TabIndex = 1;
            button1.Text = "Узнать информацию";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.Location = new Point(191, 562);
            button2.Name = "button2";
            button2.Size = new Size(118, 50);
            button2.TabIndex = 2;
            button2.Text = "Информация о врачах";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(353, 577);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(134, 23);
            textBox1.TabIndex = 3;
            // 
            // button3
            // 
            button3.Location = new Point(493, 577);
            button3.Name = "button3";
            button3.Size = new Size(160, 23);
            button3.TabIndex = 4;
            button3.Text = "Посмотреть";
            button3.UseVisualStyleBackColor = true;
            button3.Click += Button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(353, 558);
            label1.Name = "label1";
            label1.Size = new Size(300, 15);
            label1.TabIndex = 5;
            label1.Text = "Введите ID доктора, чьих пациентов вы хотите видеть";
            // 
            // PacientInformation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1147, 624);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "PacientInformation";
            Text = "InfoPacients";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private Button button3;
        private Label label1;
    }
}