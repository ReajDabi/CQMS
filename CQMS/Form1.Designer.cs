namespace CQMS
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtRFV = new TextBox();
            txtAge = new TextBox();
            label1 = new Label();
            txtPatientType = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnAdd = new Button();
            btnClear = new Button();
            txtP_name = new TextBox();
            SuspendLayout();
            // 
            // txtRFV
            // 
            txtRFV.Location = new Point(162, 148);
            txtRFV.Multiline = true;
            txtRFV.Name = "txtRFV";
            txtRFV.Size = new Size(479, 76);
            txtRFV.TabIndex = 0;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(344, 86);
            txtAge.Multiline = true;
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(157, 23);
            txtAge.TabIndex = 0;
            txtAge.TextChanged += textBox5_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(151, 9);
            label1.Name = "label1";
            label1.Size = new Size(514, 34);
            label1.TabIndex = 1;
            label1.Text = "CLINIC QUEUE MANAGEMENT SYSTEM";
            // 
            // txtPatientType
            // 
            txtPatientType.FormattingEnabled = true;
            txtPatientType.Items.AddRange(new object[] { "Emergency", "Pregnant", "Senior", "Regular" });
            txtPatientType.Location = new Point(520, 86);
            txtPatientType.Name = "txtPatientType";
            txtPatientType.Size = new Size(121, 23);
            txtPatientType.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(162, 68);
            label2.Name = "label2";
            label2.Size = new Size(87, 15);
            label2.TabIndex = 3;
            label2.Text = "Patient's Name";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(344, 68);
            label3.Name = "label3";
            label3.Size = new Size(28, 15);
            label3.TabIndex = 3;
            label3.Text = "Age";
            label3.Click += label2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(520, 68);
            label4.Name = "label4";
            label4.Size = new Size(72, 15);
            label4.TabIndex = 3;
            label4.Text = "Patient Type";
            label4.Click += label2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(162, 130);
            label5.Name = "label5";
            label5.Size = new Size(87, 15);
            label5.TabIndex = 3;
            label5.Text = "Reason for visit";
            label5.Click += label2_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(192, 255, 192);
            btnAdd.Location = new Point(531, 252);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(110, 36);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "ADD TO QUEUE";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(255, 192, 192);
            btnClear.Location = new Point(162, 252);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(87, 36);
            btnClear.TabIndex = 4;
            btnClear.Text = "CLEAR";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // txtP_name
            // 
            txtP_name.Location = new Point(162, 86);
            txtP_name.Multiline = true;
            txtP_name.Name = "txtP_name";
            txtP_name.Size = new Size(157, 23);
            txtP_name.TabIndex = 0;
            txtP_name.TextChanged += textBox5_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(805, 348);
            Controls.Add(btnClear);
            Controls.Add(btnAdd);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtPatientType);
            Controls.Add(label1);
            Controls.Add(txtP_name);
            Controls.Add(txtAge);
            Controls.Add(txtRFV);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion


        private TextBox txtRFV;
        private TextBox txtAge;
        private Label label1;
        private ComboBox txtPatientType;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnAdd;
        private Button btnClear;
        private TextBox txtP_name;
    }
}
