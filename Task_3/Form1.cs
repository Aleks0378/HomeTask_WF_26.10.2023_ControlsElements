//2.�������� ���������, � ������� ������������ ������ ���� ������ �������� � �������� TextBox.
//��������� �������� � �������� MonthCalendar � ���������� ��������� ����.

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