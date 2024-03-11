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

            console1.Items.Add($"���� �������� ������ � ��������� ��������: {sumOddIndex}");
            console1.Items.Add($"���� �������� ������, ������������ �� ������ � ������� �䒺����� ����������: {sumBetweenNegatives}");
            console1.Items.Add($"����� ���� ��������� ��������, ������ ���� �� �������� 1: {string.Join(", ", array)}");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            double[,] array = { { 1, -2, 3 }, { 4, -5, 6 }, { 7, 8, -9 } };

            double topRight = array[0, 2];
            double compared = array[0, 1];

            double comparedAbs = Math.Abs(compared);
            double topRightAbs = Math.Abs(array[array.GetLength(0) - 1, 2]);

            console2.Items.Add("�����:");
            for (int i = 0; i < array.GetLength(0); i++)
            {

                console2.Items.Add($"{array[i, 0]}, {array[i, 1]}, {array[i, 2]}");
            }

            console2.Items.Add($"������� ��� ���������: {compared}");
            console2.Items.Add($"��������� �������� ��������, �� �����������: {comparedAbs}");
            console2.Items.Add($"��������� �������� �������� � ��������� ������� ���: {topRightAbs}");

            if (comparedAbs > topRightAbs)
            {
                console2.Items.Add("��������� �������� ��������, �� ����������� �����.");
            }
            else if (comparedAbs < topRightAbs)
            {
                console2.Items.Add("��������� �������� �������� � ��������� ������� ��� �����.");
            }
            else
            {
                console2.Items.Add("�������� �������� �������� ���.");
            }

            console2.Items.Add($"������� � ��������� ������� ���: {topRight}");
            console2.Items.Add($"������� ��� ���������: {compared}");

            if (topRight < compared)
            {
                console2.Items.Add("������� � ��������� ������� ��� ������.");
            }
            else if (topRight > compared)
            {
                console2.Items.Add("������� � ��������� ������� ��� ������.");
            }
            else
            {
                console2.Items.Add("�������� ���.");
            }
        }
    }
}
