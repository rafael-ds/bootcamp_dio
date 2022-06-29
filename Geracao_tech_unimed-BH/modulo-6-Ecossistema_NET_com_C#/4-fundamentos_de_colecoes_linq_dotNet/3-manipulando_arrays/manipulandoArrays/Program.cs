int[,] matriz = new int[4, 2]{
    {4, 8},  // linha 0
    {5, 10}, // linha 1
    {6, 12}, // linha 2
    {8, 16}, // linha 3
};

for (int linhas = 0; linhas < matriz.GetLength(0); linhas++)
{
    for (int colunas = 0; colunas < matriz.GetLength(1); colunas++) 
    {
        System.Console.WriteLine(matriz[linhas, colunas]);
    }
    
}