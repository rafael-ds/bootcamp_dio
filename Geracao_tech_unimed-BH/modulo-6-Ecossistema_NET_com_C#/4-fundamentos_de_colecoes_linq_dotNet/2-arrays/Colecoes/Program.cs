﻿
// int[] arrayInteiros = new int[3];

// arrayInteiros[0] = 10;
// arrayInteiros[1] = 100;
// arrayInteiros[2] = int.Parse("1000"); // convertendo string para int
// arrayInteiros[3] = 2000;


// System.Console.WriteLine();
// System.Console.WriteLine("Pecorrendo o array com for");
// for (int i = 0; i < arrayInteiros.Length; i++)
// {
//     System.Console.WriteLine(arrayInteiros[i]);
// }

// System.Console.WriteLine();
// System.Console.WriteLine("Pecorrendo o array com foreach");
// foreach (int item in arrayInteiros)
// {
//     System.Console.WriteLine(item);
// }
// System.Console.WriteLine();


// Array contem 4 linhas e 2 colunas
// int[,] matriz = new int[4, 2]{
//     {4, 8},  // linha 0
//     {5, 10}, // linha 1
//     {6, 12}, // linha 2
//     {8, 16}, // linha 3
// };

// for (int linhas = 0; linhas < matriz.GetLength(0); linhas++)
// {
//     for (int colunas = 0; colunas < matriz.GetLength(1); colunas++) 
//     {
//         System.Console.WriteLine(matriz[linhas, colunas]);
//     }

// }


//* ************ Copiando  Arrayss ***********

int[] array = new int[5] { 6,8,1,12,33 };
int[] arrayCopia = new int[10];

System.Console.WriteLine("Array original");
for (int i = 0; i < array.Length; i++)
{
    System.Console.WriteLine(array[i]);
}

System.Console.WriteLine();
System.Console.WriteLine("Array copia");
Array.Copy(array, arrayCopia, array.Length);
for (int i = 0; i < arrayCopia.Length; i++)
{
    
    System.Console.WriteLine(arrayCopia[i]);
}
