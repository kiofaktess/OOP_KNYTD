namespace OOPLAB2WIN
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button2 = new System.Windows.Forms.Button();
            this.listBoxStudents = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            this.txtExam3 = new System.Windows.Forms.TextBox();
            this.txtExam2 = new System.Windows.Forms.TextBox();
            this.txtExam1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(34, 324);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(346, 41);
            this.button2.TabIndex = 25;
            this.button2.Text = "Очистити список";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listBoxStudents
            // 
            this.listBoxStudents.FormattingEnabled = true;
            this.listBoxStudents.Location = new System.Drawing.Point(34, 249);
            this.listBoxStudents.Name = "listBoxStudents";
            this.listBoxStudents.Size = new System.Drawing.Size(346, 69);
            this.listBoxStudents.TabIndex = 24;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(34, 196);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(132, 27);
            this.btnAdd.TabIndex = 23;
            this.btnAdd.Text = "Додати студента";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // txtExam3
            // 
            this.txtExam3.Location = new System.Drawing.Point(205, 104);
            this.txtExam3.Name = "txtExam3";
            this.txtExam3.Size = new System.Drawing.Size(47, 20);
            this.txtExam3.TabIndex = 22;
            // 
            // txtExam2
            // 
            this.txtExam2.Location = new System.Drawing.Point(89, 155);
            this.txtExam2.Name = "txtExam2";
            this.txtExam2.Size = new System.Drawing.Size(47, 20);
            this.txtExam2.TabIndex = 21;
            // 
            // txtExam1
            // 
            this.txtExam1.Location = new System.Drawing.Point(89, 104);
            this.txtExam1.Name = "txtExam1";
            this.txtExam1.Size = new System.Drawing.Size(47, 20);
            this.txtExam1.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(149, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Оцінка 3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Оцінка 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Оцінка 1";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(103, 57);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(100, 20);
            this.txtPhone.TabIndex = 16;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(103, 23);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(100, 20);
            this.txtSurname.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Телефон";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Прізвище";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 379);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listBoxStudents);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtExam3);
            this.Controls.Add(this.txtExam2);
            this.Controls.Add(this.txtExam1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox listBoxStudents;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtExam3;
        private System.Windows.Forms.TextBox txtExam2;
        private System.Windows.Forms.TextBox txtExam1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

