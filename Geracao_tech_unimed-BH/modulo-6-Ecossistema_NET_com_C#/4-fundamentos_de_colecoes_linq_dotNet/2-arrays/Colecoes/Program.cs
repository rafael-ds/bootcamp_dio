int[] arrayInteiros = new int[3];

arrayInteiros[0] = 10;
arrayInteiros[1] = 100;
arrayInteiros[2] = 1000;

System.Console.WriteLine();
System.Console.WriteLine("Pecorrendo o array com for");
for (int i = 0; i < arrayInteiros.Length; i++)
{
    System.Console.WriteLine(arrayInteiros[i]);
}

System.Console.WriteLine();
System.Console.WriteLine("Pecorrendo o array com foreach");
foreach (int item in arrayInteiros)
{
    System.Console.WriteLine(item);
}
System.Console.WriteLine();

