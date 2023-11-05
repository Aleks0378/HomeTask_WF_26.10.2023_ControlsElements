//2.Создайте программу, в которой пользователь вводит дату своего рождения в элементы TextBox.
//Программа выделяет в элементе MonthCalendar и отображает указанный день.

namespace Task_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            monthCalendar1.SetDate(new DateTime(Int32.Parse(yearTextBox.Text), Int32.Parse(monthTextBox.Text),Int32.Parse(dayTextBox.Text)));
        }
    }
}