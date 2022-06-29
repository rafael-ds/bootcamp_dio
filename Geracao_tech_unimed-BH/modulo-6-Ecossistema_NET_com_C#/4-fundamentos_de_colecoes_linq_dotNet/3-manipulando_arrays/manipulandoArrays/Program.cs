using manipulandoArrays.Helper;

op = OperacoesArrays();
int[] arrays = new int[5] { 5, 23, 81, 8, 41 };

System.Console.WriteLine("Array Original");
op.ImprimirArray(arrays);

op.OrdenarBubbleSort(ref arrays);

System.Console.WriteLine("Array Ordenado");
op.ImprimirArray(arrays);