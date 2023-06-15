using System.Data;
using System.Windows.Forms;
using System.ComponentModel;
using System.Linq;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics;
using System.Collections.Immutable;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Exam
{
    public partial class Form1 : Form
    {
        BindingList<Apartment> bindingList;
        public Form1()
        {
            InitializeComponent();
            var items = Base.Apartments;
            bindingList = new BindingList<Apartment>(items);
            apartmentsDataGridView.DataSource = bindingList;
            var order = Base.Apartments.OrderByDescending(i => i.Price).ToList();
            apartmentsDataGridView.DataSource = order;
            
        }

        private void findButton_Click(object sender, EventArgs e)
        {

            if (!int.TryParse(roomTextBox.Text, out int rooms))
            {
                rooms = Convert.ToInt32(roomTextBox.Text);
            }
            if (!double.TryParse(maxPriceTextBox.Text, out double price))
            {
                price = Convert.ToDouble(maxPriceTextBox.Text);
            }
            if (!double.TryParse(minAreaTextBox.Text, out double area))
            {
                area = Convert.ToDouble(minAreaTextBox.Text);
            }
            var categories = categoryCheckedListBox.CheckedItems;
            
            IEnumerable<Apartment> list;
            if (rooms == 0)
            {
                Base.Apartments.Where(x => x.Price <= price && x.Area >= area);
            }
            else
            {
                for (int i = 0; i <= Base.Apartments.Count; i++)
                {
                    if (Base.Apartments[i].Rooms == rooms && Base.Apartments[i].Price <= price && Base.Apartments[i].Area >= area && Base.Apartments[i].Category == categories.ToString())
                    {
                         bindingList.Add(Base.Apartments[i]);
                    }
                }
            }
           // bindingList = new BindingList<Apartment>(list.ToList());
            


        }


        private void buttonReset_Click(object sender, EventArgs e)
        {

            var items = Base.Apartments;
            bindingList = new BindingList<Apartment>(items);
            apartmentsDataGridView.DataSource = bindingList;
        }

        private void minAreaTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) & (e.KeyChar != ',') & (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void maxPriceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            if (!char.IsDigit(e.KeyChar) & (e.KeyChar != ',') & (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void roomTextBox_KeyPress(object sender, KeyPressEventArgs e)
        { 
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
            else if (char.IsDigit(e.KeyChar))
            {
                double kol = double.Parse(roomTextBox.Text + e.KeyChar);
                if (kol < 0 || kol > 10)
                {
                    e.Handled = true;
                }
            }
        }
    }
}