//Основная задача:

//Написать программу для сложения двух матриц. 
//У пользователя есть возможность выбрать размер матриц из заданных: 3х3, 6х6 и 9х9. 
//Пользователь вводит данные матриц, нажимает кнопку посчитать и получает третью, результирующую матрицу. 


using System.Windows.Forms;

namespace Task_1
{
    public partial class Form1 : Form
    {
        private int matrixSize = 3;
        private TableLayoutPanel leftTable;
        private TableLayoutPanel rightTable;
        private Panel centerPanel;
        public Form1()
        {
            InitializeComponent();
            (Height, Width) = (400, 480);
            (FormBorderStyle, MaximizeBox) = (FormBorderStyle.Fixed3D, false);
            matrixCombobox.Items.AddRange(new string[]
            {
                "3 x 3",
                "6 x 6",
                "9 x 9"
            });
            matrixCombobox.SelectedIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AddTables();
            AddNumericToTable(leftTable);
            AddNumericToTable(rightTable);

        }

        private void AddNumericToTable(TableLayoutPanel tableLayoutPanel)
        {
            tableLayoutPanel.Controls.Clear();
            tableLayoutPanel.RowCount = matrixSize;
            tableLayoutPanel.ColumnCount = matrixSize;

            for (int i = 0; i < matrixSize; i++)
            {
                for (int j = 0; j < matrixSize; j++)
                {
                    NumericUpDown numericUpDown = new NumericUpDown()
                    {
                        Width = 60,
                        Maximum = int.MaxValue,
                        Minimum = int.MinValue,
                    };
                    tableLayoutPanel.Controls.Add(numericUpDown);
                }
            }

        }

        private void AddTables()
        {
            leftTable = new TableLayoutPanel()
            {
                Dock = DockStyle.Left,
                BackColor = Color.FromArgb(254, 254, 233),
                Width = this.ClientSize.Width / 2 - 20
            };
            rightTable = new TableLayoutPanel()
            {
                Dock = DockStyle.Right,
                BackColor = Color.FromArgb(254, 254, 233),
                Width = this.ClientSize.Width / 2 - 20
            };
            centerPanel = new Panel()
            {
                Dock = DockStyle.Fill,
                BackColor = Color.FromArgb(254, 254, 233),
                Width = 20
            };
            panel1.Controls.Add(leftTable);
            panel1.Controls.Add(rightTable);
            panel1.Controls.Add(centerPanel);

            centerPanel.Controls.Add(new Label()
            {
                Text = "+",
                Font = new Font("Arial", 16, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter,
                Location = new Point((centerPanel.Width - 110) / 2, (matrixSize * 30 / 2))
            });
        }

        private void matrixCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string size = matrixCombobox.SelectedItem.ToString();
            matrixSize = size switch
            {
                "3 x 3" => 3,
                "6 x 6" => 6,
                "9 x 9" => 9
            };

            Width = matrixSize switch
            {
                3 => 480,
                6 => 880,
                9 => 1280,
            };

            if (leftTable is not null)
            {
                panel1.Controls.Clear();
                AddTables();
                AddNumericToTable(leftTable);
                AddNumericToTable(rightTable);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var leftMatrix = leftTable.Controls.OfType<NumericUpDown>().Select(e => e.Value).ToArray();
            var rightMatrix = rightTable.Controls.OfType<NumericUpDown>().Select(e => e.Value).ToArray();
            Form2 form2 = new Form2()
            {
                Width = this.Width / 2 - 20,
                StartPosition = FormStartPosition.CenterScreen,
            };

            TableLayoutPanel resultTable = new TableLayoutPanel()
            {
                Dock = DockStyle.Fill,
                BackColor = Color.FromArgb(254, 254, 233),
                Width = form2.ClientSize.Width
            };
            form2.Controls.Add(resultTable);

            resultTable.Controls.Clear();
            resultTable.RowCount = matrixSize;
            resultTable.ColumnCount = matrixSize;

            for (int i = 0; i < matrixSize; i++)
            {
                for (int j = 0; j < matrixSize; j++)
                {
                    TextBox result = new TextBox()
                    {
                        Width = 60,
                        ReadOnly = true,
                        Text = (leftMatrix[i * matrixSize + j] + rightMatrix[i * matrixSize + j]).ToString(),
                    };
                    resultTable.Controls.Add(result);
                }
            }

            form2.ShowDialog();

        }

    }
}