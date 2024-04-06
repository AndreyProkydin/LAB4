namespace Lab_4
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox2DArray = new System.Windows.Forms.TextBox();
            this.ResultButton2 = new System.Windows.Forms.Button();
            this.ResultLabel2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.ResultButton = new System.Windows.Forms.Button();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.textBoxArray = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(833, 472);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.textBoxArray);
            this.tabPage1.Controls.Add(this.ResultLabel);
            this.tabPage1.Controls.Add(this.ResultButton);
            this.tabPage1.Controls.Add(this.pictureBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(825, 446);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Завдання 1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.ResultLabel2);
            this.tabPage2.Controls.Add(this.ResultButton2);
            this.tabPage2.Controls.Add(this.textBox2DArray);
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(825, 446);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Завдання 2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Lab_4.Properties.Resources.Снимок_экрана_2024_04_04_182547;
            this.pictureBox1.Location = new System.Drawing.Point(48, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(736, 149);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // textBox2DArray
            // 
            this.textBox2DArray.Location = new System.Drawing.Point(169, 240);
            this.textBox2DArray.Name = "textBox2DArray";
            this.textBox2DArray.Size = new System.Drawing.Size(100, 20);
            this.textBox2DArray.TabIndex = 1;
            // 
            // ResultButton2
            // 
            this.ResultButton2.Location = new System.Drawing.Point(48, 315);
            this.ResultButton2.Name = "ResultButton2";
            this.ResultButton2.Size = new System.Drawing.Size(75, 23);
            this.ResultButton2.TabIndex = 2;
            this.ResultButton2.Text = "Ок";
            this.ResultButton2.UseVisualStyleBackColor = true;
            this.ResultButton2.Click += new System.EventHandler(this.ResultButton2_Click);
            // 
            // ResultLabel2
            // 
            this.ResultLabel2.AutoSize = true;
            this.ResultLabel2.Location = new System.Drawing.Point(180, 315);
            this.ResultLabel2.Name = "ResultLabel2";
            this.ResultLabel2.Size = new System.Drawing.Size(0, 13);
            this.ResultLabel2.TabIndex = 3;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Lab_4.Properties.Resources.Снимок_экрана_2024_04_04_182446;
            this.pictureBox2.Location = new System.Drawing.Point(50, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(732, 221);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // ResultButton
            // 
            this.ResultButton.Location = new System.Drawing.Point(50, 352);
            this.ResultButton.Name = "ResultButton";
            this.ResultButton.Size = new System.Drawing.Size(75, 23);
            this.ResultButton.TabIndex = 1;
            this.ResultButton.Text = "Ок";
            this.ResultButton.UseVisualStyleBackColor = true;
            this.ResultButton.Click += new System.EventHandler(this.ResultButton_Click);
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Location = new System.Drawing.Point(149, 357);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(0, 13);
            this.ResultLabel.TabIndex = 2;
            // 
            // textBoxArray
            // 
            this.textBoxArray.Location = new System.Drawing.Point(156, 280);
            this.textBoxArray.Name = "textBoxArray";
            this.textBoxArray.Size = new System.Drawing.Size(100, 20);
            this.textBoxArray.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 283);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ввести масив : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Введіть масив : ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 496);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label ResultLabel2;
        private System.Windows.Forms.Button ResultButton2;
        private System.Windows.Forms.TextBox textBox2DArray;
        private System.Windows.Forms.TextBox textBoxArray;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.Button ResultButton;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

