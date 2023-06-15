using Microsoft.VisualBasic.Devices;
using System.ComponentModel.Design;

namespace Exam
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
            components = new System.ComponentModel.Container();
            apartmentsDataGridView = new DataGridView();
            addressDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            categoryDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            areaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            roomsDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            apartmentBindingSource = new BindingSource(components);
            filterGroupBox = new GroupBox();
            buttonReset = new Button();
            label1 = new Label();
            roomTextBox = new TextBox();
            maxPriceTextBox = new TextBox();
            minAreaTextBox = new TextBox();
            maxPriceLabel = new Label();
            minAreaLabel = new Label();
            categoryCheckedListBox = new CheckedListBox();
            categoryLabel = new Label();
            findButton = new Button();
            ((System.ComponentModel.ISupportInitialize)apartmentsDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)apartmentBindingSource).BeginInit();
            filterGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // apartmentsDataGridView
            // 
            apartmentsDataGridView.AllowUserToAddRows = false;
            apartmentsDataGridView.AllowUserToDeleteRows = false;
            apartmentsDataGridView.AutoGenerateColumns = false;
            apartmentsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            apartmentsDataGridView.Columns.AddRange(new DataGridViewColumn[] { addressDataGridViewTextBoxColumn, categoryDataGridViewTextBoxColumn, areaDataGridViewTextBoxColumn, priceDataGridViewTextBoxColumn, roomsDataGridViewTextBoxColumn });
            apartmentsDataGridView.DataSource = apartmentBindingSource;
            apartmentsDataGridView.Location = new Point(15, 15);
            apartmentsDataGridView.Margin = new Padding(4, 3, 4, 3);
            apartmentsDataGridView.Name = "apartmentsDataGridView";
            apartmentsDataGridView.RowHeadersWidth = 62;
            apartmentsDataGridView.Size = new Size(903, 308);
            apartmentsDataGridView.TabIndex = 0;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            addressDataGridViewTextBoxColumn.HeaderText = "Адрес";
            addressDataGridViewTextBoxColumn.MinimumWidth = 8;
            addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            addressDataGridViewTextBoxColumn.Width = 250;
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            categoryDataGridViewTextBoxColumn.HeaderText = "Категория";
            categoryDataGridViewTextBoxColumn.MinimumWidth = 8;
            categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            categoryDataGridViewTextBoxColumn.Width = 170;
            // 
            // areaDataGridViewTextBoxColumn
            // 
            areaDataGridViewTextBoxColumn.DataPropertyName = "Area";
            areaDataGridViewTextBoxColumn.HeaderText = "Площадь";
            areaDataGridViewTextBoxColumn.MinimumWidth = 8;
            areaDataGridViewTextBoxColumn.Name = "areaDataGridViewTextBoxColumn";
            areaDataGridViewTextBoxColumn.Width = 150;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            priceDataGridViewTextBoxColumn.HeaderText = "Цена";
            priceDataGridViewTextBoxColumn.MinimumWidth = 8;
            priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            priceDataGridViewTextBoxColumn.Width = 150;
            // 
            // roomsDataGridViewTextBoxColumn
            // 
            roomsDataGridViewTextBoxColumn.DataPropertyName = "Rooms";
            roomsDataGridViewTextBoxColumn.HeaderText = "Количество комнат";
            roomsDataGridViewTextBoxColumn.MinimumWidth = 8;
            roomsDataGridViewTextBoxColumn.Name = "roomsDataGridViewTextBoxColumn";
            roomsDataGridViewTextBoxColumn.Width = 150;
            // 
            // apartmentBindingSource
            // 
            apartmentBindingSource.DataSource = typeof(Apartment);
            // 
            // filterGroupBox
            // 
            filterGroupBox.Controls.Add(buttonReset);
            filterGroupBox.Controls.Add(label1);
            filterGroupBox.Controls.Add(roomTextBox);
            filterGroupBox.Controls.Add(maxPriceTextBox);
            filterGroupBox.Controls.Add(minAreaTextBox);
            filterGroupBox.Controls.Add(maxPriceLabel);
            filterGroupBox.Controls.Add(minAreaLabel);
            filterGroupBox.Controls.Add(categoryCheckedListBox);
            filterGroupBox.Controls.Add(categoryLabel);
            filterGroupBox.Controls.Add(findButton);
            filterGroupBox.Location = new Point(15, 330);
            filterGroupBox.Margin = new Padding(4, 3, 4, 3);
            filterGroupBox.Name = "filterGroupBox";
            filterGroupBox.Padding = new Padding(4, 3, 4, 3);
            filterGroupBox.Size = new Size(903, 171);
            filterGroupBox.TabIndex = 1;
            filterGroupBox.TabStop = false;
            filterGroupBox.Text = "Фильтрация квартир";
            // 
            // buttonReset
            // 
            buttonReset.Location = new Point(782, 138);
            buttonReset.Margin = new Padding(4, 3, 4, 3);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(113, 27);
            buttonReset.TabIndex = 9;
            buttonReset.Text = "Сбросить";
            buttonReset.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 120);
            label1.Name = "label1";
            label1.Size = new Size(89, 15);
            label1.TabIndex = 8;
            label1.Text = "Кол-во комнат";
            // 
            // roomTextBox
            // 
            roomTextBox.Location = new Point(136, 112);
            roomTextBox.Name = "roomTextBox";
            roomTextBox.Size = new Size(116, 23);
            roomTextBox.TabIndex = 7;
            roomTextBox.KeyPress += roomTextBox_KeyPress;
            // 
            // maxPriceTextBox
            // 
            maxPriceTextBox.Location = new Point(136, 68);
            maxPriceTextBox.Margin = new Padding(4, 3, 4, 3);
            maxPriceTextBox.Name = "maxPriceTextBox";
            maxPriceTextBox.Size = new Size(116, 23);
            maxPriceTextBox.TabIndex = 6;
            maxPriceTextBox.KeyPress += maxPriceTextBox_KeyPress;
            // 
            // minAreaTextBox
            // 
            minAreaTextBox.Location = new Point(136, 19);
            minAreaTextBox.Margin = new Padding(4, 3, 4, 3);
            minAreaTextBox.Name = "minAreaTextBox";
            minAreaTextBox.Size = new Size(116, 23);
            minAreaTextBox.TabIndex = 5;
            minAreaTextBox.KeyPress += minAreaTextBox_KeyPress;
            // 
            // maxPriceLabel
            // 
            maxPriceLabel.AutoSize = true;
            maxPriceLabel.Location = new Point(8, 76);
            maxPriceLabel.Margin = new Padding(4, 0, 4, 0);
            maxPriceLabel.Name = "maxPriceLabel";
            maxPriceLabel.Size = new Size(112, 15);
            maxPriceLabel.TabIndex = 4;
            maxPriceLabel.Text = "Макс. цена за м.кв.";
            // 
            // minAreaLabel
            // 
            minAreaLabel.AutoSize = true;
            minAreaLabel.Location = new Point(8, 27);
            minAreaLabel.Margin = new Padding(4, 0, 4, 0);
            minAreaLabel.Name = "minAreaLabel";
            minAreaLabel.Size = new Size(91, 15);
            minAreaLabel.TabIndex = 3;
            minAreaLabel.Text = "Мин. площадь:";
            // 
            // categoryCheckedListBox
            // 
            categoryCheckedListBox.FormattingEnabled = true;
            categoryCheckedListBox.Items.AddRange(new object[] { "Кирпичный", "Монолитный", "Панельный" });
            categoryCheckedListBox.Location = new Point(549, 10);
            categoryCheckedListBox.Margin = new Padding(4, 3, 4, 3);
            categoryCheckedListBox.Name = "categoryCheckedListBox";
            categoryCheckedListBox.Size = new Size(194, 58);
            categoryCheckedListBox.TabIndex = 2;
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.Location = new Point(474, 27);
            categoryLabel.Margin = new Padding(4, 0, 4, 0);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new Size(67, 15);
            categoryLabel.TabIndex = 1;
            categoryLabel.Text = "Категории:";
            // 
            // findButton
            // 
            findButton.Location = new Point(270, 138);
            findButton.Margin = new Padding(4, 3, 4, 3);
            findButton.Name = "findButton";
            findButton.Size = new Size(113, 27);
            findButton.TabIndex = 0;
            findButton.Text = "Найти";
            findButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(931, 515);
            Controls.Add(filterGroupBox);
            Controls.Add(apartmentsDataGridView);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Квартиры на продажу";
            ((System.ComponentModel.ISupportInitialize)apartmentsDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)apartmentBindingSource).EndInit();
            filterGroupBox.ResumeLayout(false);
            filterGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView apartmentsDataGridView;
        private GroupBox filterGroupBox;
        private Label categoryLabel;
        private Button findButton;
        private CheckedListBox categoryCheckedListBox;
        private Label minAreaLabel;
        private Label maxPriceLabel;
        private TextBox minAreaTextBox;
        private TextBox maxPriceTextBox;
        private Label label1;
        private TextBox roomTextBox;
        private BindingSource apartmentBindingSource;
        private Button buttonReset;
        private DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn areaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn roomsDataGridViewTextBoxColumn;
    }
}