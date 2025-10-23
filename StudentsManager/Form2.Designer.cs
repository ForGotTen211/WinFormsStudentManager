namespace StudentsManager
{
    partial class StudentChangeForm
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
            _nameBox = new TextBox();
            _ageBox = new TextBox();
            _groupBox = new TextBox();
            _averageBox = new TextBox();
            _addmissionDateBox = new TextBox();
            printDialog1 = new PrintDialog();
            printDialog2 = new PrintDialog();
            printDialog3 = new PrintDialog();
            button2 = new Button();
            textBox6 = new TextBox();
            label1 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            _nameBox.Location = new Point(3, 18);
            _nameBox.Name = "textBox1";
            _nameBox.Size = new Size(100, 23);
            _nameBox.TabIndex = 0;
            // 
            // textBox2
            // 
            _ageBox.Location = new Point(3, 62);
            _ageBox.Name = "textBox2";
            _ageBox.Size = new Size(100, 23);
            _ageBox.TabIndex = 1;
            // 
            // textBox3
            // 
            _groupBox.Location = new Point(3, 106);
            _groupBox.Name = "textBox3";
            _groupBox.Size = new Size(100, 23);
            _groupBox.TabIndex = 2;
            // 
            // textBox4
            // 
            _averageBox.Location = new Point(109, 18);
            _averageBox.Name = "textBox4";
            _averageBox.Size = new Size(100, 23);
            _averageBox.TabIndex = 3;
            // 
            // textBox5
            // 
            _addmissionDateBox.Location = new Point(109, 62);
            _addmissionDateBox.Name = "textBox5";
            _addmissionDateBox.Size = new Size(100, 23);
            _addmissionDateBox.TabIndex = 4;
            // 
            // printDialog1
            // 
            printDialog1.UseEXDialog = true;
            // 
            // printDialog2
            // 
            printDialog2.UseEXDialog = true;
            // 
            // printDialog3
            // 
            printDialog3.UseEXDialog = true;
            // 
            // button2
            // 
            button2.Location = new Point(67, 175);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 7;
            button2.Text = " сохранить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(540, 203);
            textBox6.Name = "textBox6";
            textBox6.ReadOnly = true;
            textBox6.Size = new Size(100, 23);
            textBox6.TabIndex = 8;
            textBox6.Text = "name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 5;
            label1.Text = "label1";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(_nameBox);
            flowLayoutPanel1.Controls.Add(label2);
            flowLayoutPanel1.Controls.Add(_ageBox);
            flowLayoutPanel1.Controls.Add(label3);
            flowLayoutPanel1.Controls.Add(_groupBox);
            flowLayoutPanel1.Controls.Add(label4);
            flowLayoutPanel1.Controls.Add(_averageBox);
            flowLayoutPanel1.Controls.Add(label5);
            flowLayoutPanel1.Controls.Add(_addmissionDateBox);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(377, 285);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(224, 139);
            flowLayoutPanel1.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 44);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 6;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 88);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 7;
            label3.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(109, 0);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 8;
            label4.Text = "label4";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(109, 44);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 9;
            label5.Text = "label5";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(textBox6);
            Controls.Add(button2);
            Name = "Form2";
            Text = "Form2";
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox _nameBox;
        private TextBox _ageBox;
        private TextBox _groupBox;
        private TextBox _averageBox;
        private TextBox _addmissionDateBox;
        private PrintDialog printDialog1;
        private PrintDialog printDialog2;
        private PrintDialog printDialog3;
        private Button button2;
        private TextBox textBox6;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}