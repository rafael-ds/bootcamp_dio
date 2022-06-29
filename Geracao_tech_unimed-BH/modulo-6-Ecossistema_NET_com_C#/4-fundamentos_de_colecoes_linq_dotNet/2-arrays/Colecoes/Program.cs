
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

// int[] arrayCopia = new int[10];

// System.Console.WriteLine("Array original");
// for (int i = 0; i < array.Length; i++)
// {
//     System.Console.WriteLine(array[i]);
// }

// System.Console.WriteLine();
// System.Console.WriteLine("Array copia");
// Array.Copy(array, arrayCopia, array.Length);
// for (int i = 0; i < arrayCopia.Length; i++)
// {
    
//     System.Console.WriteLine(arrayCopia[i]);
// }


//* ************ Verifiando Valores exitente no array ***********


// int valorBuscado = 38;
// bool exite =  Array.Exists(array, elemento => elemento == valorBuscado);

// System.Console.WriteLine();
// if(exite){
//     System.Console.WriteLine($"O valor {valorBuscado} existe no array");
// } else {
//     System.Console.WriteLine($"O valor {valorBuscado} não existe no array");

// }
// System.Console.WriteLine();



//* ************ Verifiando todos elementos no array ***********

int[] array = new int[5] { 6,8,15,12,33 };

int valor = 3;

bool maiorQue = Array.TrueForAll(array, e => e > valor);

if(maiorQue){
    System.Console.WriteLine();
    System.Console.WriteLine($"Todos os valores do array são maiores que {valor}");
    System.Console.WriteLine();
}else{
    System.Console.WriteLine();
    System.Console.WriteLine($"Existe valores no array que não são maiores que {valor}");
    System.Console.WriteLine();


}
