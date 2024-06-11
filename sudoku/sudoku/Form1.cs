using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace sudoku
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            createCells();

            startNewGame();
        }

        SudokuCell[,] cells = new SudokuCell[9, 9];

        private void createCells()
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    // Створення 81 клітинки зі стилями та розташуванням на основі індексу
                    cells[i, j] = new SudokuCell();
                    cells[i, j].Font = new Font(SystemFonts.DefaultFont.FontFamily, 26);
                    cells[i, j].Size = new Size(60, 60);
                    cells[i, j].ForeColor = SystemColors.ControlDarkDark;
                    cells[i, j].Location = new Point(i * 60, j * 60);
                    cells[i, j].BackColor = ((i / 3) + (j / 3)) % 2 == 0 ? SystemColors.Control : Color.LightGray;
                    cells[i, j].FlatStyle = FlatStyle.Flat;
                    cells[i, j].FlatAppearance.BorderColor = Color.Black;
                    cells[i, j].X = i;
                    cells[i, j].Y = j;

                    // Прив'язка події натиску клавіші для кожної клітинки
                    cells[i, j].KeyPress += cell_keyPressed;

                    panel1.Controls.Add(cells[i, j]);
                }
            }
        }

        private void cell_keyPressed(object sender, KeyPressEventArgs e)
        {
            var cell = sender as SudokuCell;

            // Нічого не робити якщо клітинка замкнута
            if (cell.IsLocked)
                return;

            int value;

            if (e.KeyChar == (char)Keys.Delete || e.KeyChar == (char)Keys.Back)
            {
                cell.Clear();
            }
            else if (int.TryParse(e.KeyChar.ToString(), out value))
            {
                // Очистити значення клітинки якщо введено нуль
                if (value == 0)
                    cell.Clear();
                else
                    cell.Text = value.ToString();

                cell.ForeColor = SystemColors.ControlDarkDark;
            }
        }

        private void startNewGame()
        {
            loadValues();

            var hintsCount = 0;

            // Прив'язка підказок на основі обраного рівня складності
            if (beginnerLevel.Checked)
                hintsCount = 45;
            else if (IntermediateLevel.Checked)
                hintsCount = 30;
            else if (AdvancedLevel.Checked)
                hintsCount = 15;

            showRandomValuesHints(hintsCount);
        }

        private void showRandomValuesHints(int hintsCount)
        {
            // Показ значень у випадкових клітинках
            // Кількість підказок основана на обраному рівні складності
            for (int i = 0; i < hintsCount; i++)
            {
                var rX = random.Next(9);
                var rY = random.Next(9);

                // Відмінне форматування клітинок підказок та
                // їх блокування від користувача
                cells[rX, rY].Text = cells[rX, rY].Value.ToString();
                cells[rX, rY].ForeColor = Color.Black;
                cells[rX, rY].IsLocked = true;
            }
        }

        private void loadValues()
        {
            // Очищення значень у кожніфй клітинці
            foreach (var cell in cells)
            {
                cell.Value = 0;
                cell.Clear();
            }

            findValueForNextCell(0, -1);
        }

        Random random = new Random();

        private bool findValueForNextCell(int i, int j)
        {
            // Приріст значень i and j для переміщення до наступної клітинки
            // і якщо колонка закінчується, перейти до настувного ряду
            if (++j > 8)
            {
                j = 0;

                // Exit if the line ends
                if (++i > 8)
                    return true;
            }

            var value = 0;
            var numsLeft = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            // Знаходження випадкового і правильного значення для клітинки та перехід до наступної
            // і перевірка влаштування із іншим випадковим правильним значенням
            do
            {
                // Якщо не залишилося чисел у списку, пробувати наступний, 
                // повернутися до попередньої клітинки і влаштувати її з іншим числом
                if (numsLeft.Count < 1)
                {
                    cells[i, j].Value = 0;
                    return false;
                }

                // Взяття випадкового чисел, які залишилися у списку
                value = numsLeft[random.Next(0, numsLeft.Count)];
                cells[i, j].Value = value;

                // Прибрати влаштоване значення зі списку
                numsLeft.Remove(value);
            }
            while (!isValidNumber(value, i, j) || !findValueForNextCell(i, j));

            return true;
        }

        private bool isValidNumber(int value, int x, int y)
        {
            for (int i = 0; i < 9; i++)
            {
                // Перевірити всі клітинки у вертикальному напрямку
                if (i != y && cells[x, i].Value == value)
                    return false;

                // Перевірити всі клітинки у горизонтальному напрямку
                if (i != x && cells[i, y].Value == value)
                    return false;
            }

            // Перевірити всі клітинки у певному блоці
            for (int i = x - (x % 3); i < x - (x % 3) + 3; i++)
            {
                for (int j = y - (y % 3); j < y - (y % 3) + 3; j++)
                {
                    if (i != x && j != y && cells[i, j].Value == value)
                        return false;
                }
            }

            return true;
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            var wrongCells = new List<SudokuCell>();

            // Знайти неправильні введення
            foreach (var cell in cells)
            {
                if (!string.Equals(cell.Value.ToString(), cell.Text))
                {
                    wrongCells.Add(cell);
                }
            }

            // Перевірка неправильних введень, або гравець виграв
            if (wrongCells.Any())
            {
                // Виділити неправильні введення
                wrongCells.ForEach(x => x.ForeColor = Color.Red);
                MessageBox.Show("Неправильні введення");
            }
            else
            {
                MessageBox.Show("Ви перемогли!");
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            foreach (var cell in cells)
            {
                // Очистити клітинки які не замкнуті
                if (cell.IsLocked == false)
                    cell.Clear();
            }
        }

        private void newGameButton_Click(object sender, EventArgs e)
        {
            startNewGame();
        }
    }
}
