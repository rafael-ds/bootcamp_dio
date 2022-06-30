
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


// int valor = 3;

// bool maiorQue = Array.TrueForAll(array, e => e > valor);

// if(maiorQue){
//     System.Console.WriteLine();
//     System.Console.WriteLine($"Todos os valores do array são maiores que {valor}");
//     System.Console.WriteLine();
// }else{
//     System.Console.WriteLine();
//     System.Console.WriteLine($"Existe valores no array que não são maiores que {valor}");
//     System.Console.WriteLine();


// }


//* ************ Encontrando um elementos no array ***********



// int busca = Array.Find(array, e => e == valor);

// if(busca == 0){

//     System.Console.WriteLine();
//     System.Console.WriteLine($"O numero {valor} não existe no array");
//     System.Console.WriteLine();

// } 
// else {

//     System.Console.WriteLine();
//     System.Console.WriteLine($"O numero {valor} existe no array");
//     System.Console.WriteLine();

// }


//* ************ Encontrando um indice no array ***********

// int valor = 33;

// int index = Array.IndexOf(array, valor);

// if(index == -1){
//     System.Console.WriteLine();
//     System.Console.WriteLine($"O numero {valor} não existe no array, por isso não é possuvel encontrar sua posição");
//     System.Console.WriteLine();
// }
// else {
//     System.Console.WriteLine();
//     System.Console.WriteLine($"O número {valor} esta na posição {index} do array");
//     System.Console.WriteLine();
// }


//* ************ Redimensionando um array ***********


// System.Console.WriteLine();
// System.Console.WriteLine($"Capacidade atual do array: {array.Length}");
// System.Console.WriteLine();

// Array.Resize(ref array, array.Length * 2);    
// System.Console.WriteLine($"Capacidade apois o redimensionamento: {array.Length}");
// System.Console.WriteLine();



//* ************ Convertendo um array ***********

// int[] array = new int[5] { 6,8,15,12,33 };

// string[] conversao = Array.ConvertAll(array, e => e.ToString());

// for (int i = 0; i < conversao.Length; i++)
// {
//     System.Console.WriteLine(conversao[i]);

// }

//* ************ Declarando e acessando uma lista ***********

// using System.Collections.Generic; 

List<string> estados = new List<string>();
estados.Add("RJ");
estados.Add("SC");
estados.Add("SP");
estados.Add("MG");


//* ************ Removendo elementos de uma lista ***********

// estados.Remove("MG");


//* ************ Adicionando coleções a uma lista ***********
// string[] estadosArray = new string[2] {"RS", "BA"};

// estados.AddRange(estadosArray);


//* ************ Adicionando elemento em um indice informado a lista ***********
// estados.Insert(2, "ES");

// System.Console.WriteLine($"Quantidade atual de elementos na lista: {estados.Count}");
// foreach (var item in estados)
// {
//     System.Console.WriteLine(item);
// }



//* ************ Queue ***********

// Queue<string> fila = new Queue<string>();

// fila.Enqueue("Manu");
// fila.Enqueue("Kira");
// fila.Enqueue("Tobias");

// System.Console.WriteLine($"Pessoas na fila: {fila.Count}");
// System.Console.WriteLine();

// while(fila.Count > 0){
//     System.Console.WriteLine($"Vez de: {fila.Peek()}");
//     System.Console.WriteLine($"{fila.Dequeue()} atendido");
//     System.Console.WriteLine();
// }

// System.Console.WriteLine($"Pessoas na fila: {fila.Count}");
// System.Console.WriteLine();


//* ************ Stack ***********


Stack<string> pilhas = new Stack<string>();
pilhas.Push("HTML");
pilhas.Push("CSS");
pilhas.Push("Js");
pilhas.Push("Ts");
pilhas.Push("Angular");

// while(pilhas.Count > 0){
//     System.Console.WriteLine();
//     System.Console.WriteLine($"Proximo: {pilhas.Peek()}");
//     System.Console.WriteLine($"{pilhas.Pop()} removido");
//     // System.Console.WriteLine();

// }

