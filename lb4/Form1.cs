using System;

namespace lb4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            double[] array = { -4, -3, -2, -1, 0, 1, 2, 3, 4, 5 };
            double sumOddIndex = 0;
            double sumBetweenNegatives = 0;
            int firstNegativeIndex = Array.FindIndex(array, x => x < 0);
            int lastNegativeIndex = Array.FindLastIndex(array, x => x < 0);

            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 != 0)
                {
                    sumOddIndex += array[i];
                }

                if (i > firstNegativeIndex && i < lastNegativeIndex)
                {
                    sumBetweenNegatives += array[i];
                }
            }

            array = array.Where(x => Math.Abs(x) > 1).ToArray();
            Array.Resize(ref array, array.Length + (array.Length - array.Count()));

            console1.Items.Add($"Сума елементів масиву з непарними номерами: {sumOddIndex}");
            console1.Items.Add($"Сума елементів масиву, розташованих між першим і останнім від’ємними елементами: {sumBetweenNegatives}");
            console1.Items.Add($"Масив після видалення елементів, модуль яких не перевищує 1: {string.Join(", ", array)}");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            double[,] array = { { 1, -2, 3 }, { 4, -5, 6 }, { 7, 8, -9 } };

            double topRight = array[0, 2];
            double compared = array[0, 1];

            double comparedAbs = Math.Abs(compared);
            double topRightAbs = Math.Abs(array[array.GetLength(0) - 1, 2]);

            console2.Items.Add("Масив:");
            for (int i = 0; i < array.GetLength(0); i++)
            {

                console2.Items.Add($"{array[i, 0]}, {array[i, 1]}, {array[i, 2]}");
            }

            console2.Items.Add($"Елемент для порівняння: {compared}");
            console2.Items.Add($"Абсолютна величина елемента, що порівнюється: {comparedAbs}");
            console2.Items.Add($"Абсолютна величина елемента у верхньому правому куті: {topRightAbs}");

            if (comparedAbs > topRightAbs)
            {
                console2.Items.Add("Абсолютна величина елемента, що порівнюється більша.");
            }
            else if (comparedAbs < topRightAbs)
            {
                console2.Items.Add("Абсолютна величина елемента у верхньому правому куті більша.");
            }
            else
            {
                console2.Items.Add("Абсолютні величини елементів рівні.");
            }

            console2.Items.Add($"Елемент у верхньому правому куті: {topRight}");
            console2.Items.Add($"Елемент для порівняння: {compared}");

            if (topRight < compared)
            {
                console2.Items.Add("Елемент у верхньому правому куті менший.");
            }
            else if (topRight > compared)
            {
                console2.Items.Add("Елемент у верхньому правому куті більший.");
            }
            else
            {
                console2.Items.Add("Елементи рівні.");
            }
        }
    }
}
