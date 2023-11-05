//1.Создайте приложение размером до 720х480 пикселов
//и разместите на главной форме необходимые элементы управления для получения информации:

//■ Фамилия
//■ Имя 
//■ Отчество 
//■ Пол 
//■ Год и дата рождения 
//■ Семейный статус 
//■ Дополнительная информация

//Добавьте кнопку Save и обработчик нажатия кнопки для сохранения информации из элементов управления в файл.


namespace Task_2
{
    public partial class Form1 : Form
    {
        GroupBox groupBox;
        public Form1()
        {
            InitializeComponent();
            Text = "Анкета";
            (Height, Width) = (720, 480);
            (FormBorderStyle, MaximizeBox) = (FormBorderStyle.Fixed3D, false);
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            groupBox = new GroupBox()
            {
                Text = "",
                Padding = new Padding(10),
                Size = new Size(ClientSize.Width - 20, ClientSize.Height - 50),
                Location = new Point(10, 10)
            };

            int labelWith = (int)(groupBox.ClientSize.Width / 2.5), labelHeight = 20;
            string[] texts = { "Фамилия", "Имя", "Отчество", "Пол", "Год и дата рождения","Семейный статус", "Доп. информация"};
            string[] textBoxNames = {"SurnameTextbox", "NameTextBox","SecondNameTextBox","","DateOfBirthTextBox","MaritalStatusTextbox","AdditionalInfoTextBox"};
            float padding = 2;

            for (int i = 0; i < texts.Length; i++)
            {
                if (i == 3 || i==4 || i == 6)
                    padding += 1.5f;
                groupBox.Controls.Add(new Label
                {
                    Text = texts[i],
                    Size = new Size(labelWith, labelHeight),
                    Location = new Point(5, (int)(labelHeight * (i*2 + padding)))

                });

                if (i < texts.Length-1)
                {
                    if (i == 3)
                    {
                        groupBox.Controls.Add(new RadioButton
                        {
                            Name = "Man",
                            Text = "Мужской",
                            Checked = true,
                            Location = new Point(labelWith + 5, (int)(labelHeight * (i*2 + padding))),
                            Width = 100
                        });
                        groupBox.Controls.Add(new RadioButton
                        {
                            Name = "Woman",
                            Text = "Женский",
                            Location = new Point(labelWith + 120, (int)(labelHeight * (i*2 + padding))),
                            Width = 100
                        });

                    }
                    else
                    {
                        groupBox.Controls.Add(new TextBox()
                        {
                            Name = textBoxNames[i],
                            Size = new Size((int)(labelWith * 1.4), labelHeight),
                            Location = new Point(labelWith + 5, (int)(labelHeight * (i*2 + padding))),
                            Tag = texts[i]
                        });
                    }   
                }
                else
                {
                    groupBox.Controls.Add(new TextBox()
                    {
                        Name = textBoxNames[i],
                        Multiline = true,
                        Size = new Size((int)(labelWith * 1.4), labelHeight*6),
                        Location = new Point(labelWith + 5, (int)(labelHeight * (i * 2 + padding))),
                        Tag = texts[i]
                    });
                }
            }

            this.Controls.Add(groupBox);

            Button button = new Button
            {
                Height = 30,
                Width = groupBox.Width,
                Location = new Point(groupBox.Left,groupBox.Bottom+5),
                Text = "Сохранить в файл"
            };
            button.Click += (sender, e) =>
            {
                var textBoxesTexts = groupBox.Controls.OfType<TextBox>().Select(e => e.Text).ToArray();
                SaveFileDialog save = new SaveFileDialog();
                if (save.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter writer = new StreamWriter(save.FileName);
                    for (int i = 0;i< textBoxesTexts.Length; i++)
                    {
                        if (i<3)
                            writer.Write(texts[i]+": " + textBoxesTexts[i] + ", ");
                        else if (i==3)
                            writer.Write(texts[i]+": " + groupBox.Controls.OfType<RadioButton>().FirstOrDefault(e=>e.Checked).Text +", ");
                        else
                            writer.Write(texts[i+1] + ": " + textBoxesTexts[i] + ", ");
                    }
                   
                    writer.Close();
                }
            };
            this.Controls.Add(button);

        }
    }
}