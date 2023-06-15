using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam
{
    public partial class Form3 : Form
    {
      
        public Form3()
        {
            InitializeComponent();


            addressTextBox.Enabled = false; areaTextBox.Enabled = false; categoryComboBox.Enabled = false; roomsNumericUpDown.Enabled = false; priceTextBox.Enabled = false; addButton.Enabled = false;

        }
        int index = 1;

        private void addButton_Click(object sender, EventArgs e)
        {
            int N = Convert.ToInt32(textBox1.Text);


            if (N >= index)
            {
                addressTextBox.Enabled = true; areaTextBox.Enabled = true; categoryComboBox.Enabled = true; roomsNumericUpDown.Enabled = true; priceTextBox.Enabled = true; addButton.Enabled = true;
                try
                {
                    var newApartment = new Apartment()
                    {
                        Address = addressTextBox.Text,
                        Category = categoryComboBox.Text.ToString(),
                        Area = Math.Round(Convert.ToDouble(areaTextBox.Text), 2),
                        Rooms = (int)roomsNumericUpDown.Value,
                        Price = Math.Round(Convert.ToDouble(priceTextBox.Text),2)
                    };
                    if (newApartment is not null && addressTextBox.Text != "" && categoryComboBox.Text.ToString() != "" && priceTextBox.Text != "")
                    {
                        Base.Apartments.Add(newApartment);
                        labelStatus.Text = $"Квартира по адресу: {newApartment.Address} добавлена.";
                        label7.Text = $"Добавлено {index} квартир";
                        index++;
                    }
                    else { labelStatus.Text = "Заполните все поля"; }
                }
                catch
                {
                    labelStatus.Text = "Ошибка.";
                };

                addressTextBox.Clear(); areaTextBox.Clear(); priceTextBox.Clear(); roomsNumericUpDown.Value = 1; categoryComboBox.SelectedIndex = 0;

            }
            else { label7.Text = "Превышено кол-во вводимых квартир"; }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "")
            {

                label7.Text = "Введите значения для N!";

            }
            else
            {
                addressTextBox.Enabled = true; areaTextBox.Enabled = true; categoryComboBox.Enabled = true; roomsNumericUpDown.Enabled = true; priceTextBox.Enabled = true; addButton.Enabled = true;
            }
        }


        private void priceTextBox_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) & (e.KeyChar != ',') & (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            { e.Handled = true; }
        }

        private void areaTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (!char.IsDigit(e.KeyChar) & (e.KeyChar != ',') & (e.KeyChar != (char)Keys.Back))
             {
             e.Handled = true;
            }        
            
        }
        private void addressTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 43 || e.KeyChar >= 58) & !char.IsLetter(e.KeyChar) & (e.KeyChar != (char)Keys.Back))
            { e.Handled = true; }
        }

        
    }

}
