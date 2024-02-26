using lb3;

SortArray sortArray = new SortArray();
sortArray.Add(5);
sortArray.Add(3);
sortArray.Add(5);
sortArray.Add(2);
sortArray.Process();
sortArray.ForEach(Console.WriteLine);

Console.WriteLine();

XorArray xorArray = new XorArray();
xorArray.Add(4);
xorArray.Add(9);
xorArray.Add(4);
xorArray.Process();
xorArray.ForEach(Console.WriteLine);
