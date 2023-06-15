namespace Exam
{
    partial class Form3
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
            components = new System.ComponentModel.Container();
            addressTextBox = new TextBox();
            roomsNumericUpDown = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            categoryComboBox = new ComboBox();
            areaTextBox = new TextBox();
            label4 = new Label();
            addButton = new Button();
            priceTextBox = new TextBox();
            label5 = new Label();
            labelStatus = new Label();
            button1 = new Button();
            label6 = new Label();
            textBox1 = new TextBox();
            label7 = new Label();
            toolTip1 = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)roomsNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // addressTextBox
            // 
            addressTextBox.Location = new Point(9, 43);
            addressTextBox.Name = "addressTextBox";
            addressTextBox.Size = new Size(137, 23);
            addressTextBox.TabIndex = 0;
            addressTextBox.KeyPress += addressTextBox_KeyPress;
            // 
            // roomsNumericUpDown
            // 
            roomsNumericUpDown.Location = new Point(8, 175);
            roomsNumericUpDown.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            roomsNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            roomsNumericUpDown.Name = "roomsNumericUpDown";
            roomsNumericUpDown.Size = new Size(136, 23);
            roomsNumericUpDown.TabIndex = 1;
            roomsNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 25);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 2;
            label1.Text = "Адрес";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 69);
            label2.Name = "label2";
            label2.Size = new Size(94, 15);
            label2.TabIndex = 3;
            label2.Text = "Категория дома";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 201);
            label3.Name = "label3";
            label3.Size = new Size(115, 15);
            label3.TabIndex = 4;
            label3.Text = "Площадь квартиры";
            // 
            // categoryComboBox
            // 
            categoryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            categoryComboBox.Items.AddRange(new object[] { "Панельный", "Кирпичный", "Монолитный" });
            categoryComboBox.Location = new Point(7, 87);
            categoryComboBox.Name = "categoryComboBox";
            categoryComboBox.Size = new Size(137, 23);
            categoryComboBox.TabIndex = 5;
            // 
            // areaTextBox
            // 
            areaTextBox.Location = new Point(9, 219);
            areaTextBox.Name = "areaTextBox";
            areaTextBox.Size = new Size(137, 23);
            areaTextBox.TabIndex = 6;
            areaTextBox.KeyPress += areaTextBox_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 157);
            label4.Name = "label4";
            label4.Size = new Size(115, 15);
            label4.TabIndex = 7;
            label4.Text = "Количество комнат";
            // 
            // addButton
            // 
            addButton.Location = new Point(15, 284);
            addButton.Name = "addButton";
            addButton.Size = new Size(118, 24);
            addButton.TabIndex = 8;
            addButton.Text = "Добавить";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // priceTextBox
            // 
            priceTextBox.Location = new Point(7, 131);
            priceTextBox.Name = "priceTextBox";
            priceTextBox.Size = new Size(137, 23);
            priceTextBox.TabIndex = 9;
            priceTextBox.KeyPress += priceTextBox_KeyPress_1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(36, 113);
            label5.Name = "label5";
            label5.Size = new Size(67, 15);
            label5.TabIndex = 10;
            label5.Text = "Цена за м2";
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Location = new Point(15, 266);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(0, 15);
            labelStatus.TabIndex = 11;
            // 
            // button1
            // 
            button1.Location = new Point(221, 81);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 12;
            button1.Text = " Ввести";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(172, 35);
            label6.Name = "label6";
            label6.Size = new Size(184, 15);
            label6.TabIndex = 13;
            label6.Text = "Введите N (количество квартир)";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(208, 53);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 14;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(240, 131);
            label7.Name = "label7";
            label7.Size = new Size(0, 15);
            label7.TabIndex = 15;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(436, 327);
            Controls.Add(label7);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(button1);
            Controls.Add(labelStatus);
            Controls.Add(label5);
            Controls.Add(priceTextBox);
            Controls.Add(addButton);
            Controls.Add(label4);
            Controls.Add(areaTextBox);
            Controls.Add(categoryComboBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(roomsNumericUpDown);
            Controls.Add(addressTextBox);
            Name = "Form3";
            Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)roomsNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox addressTextBox;
        private NumericUpDown roomsNumericUpDown;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox categoryComboBox;
        private TextBox areaTextBox;
        private Label label4;
        private Button addButton;
        private TextBox priceTextBox;
        private Label label5;
        private Label labelStatus;
        private Button button1;
        private Label label6;
        private TextBox textBox1;
        private Label label7;
        private ToolTip toolTip1;
    }
}