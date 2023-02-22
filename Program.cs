using System;

namespace Ex {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine();

            Console.Write("Entre com a quantidade de linhas da matriz:  ");
            int l = int.Parse(Console.ReadLine());

            Console.Write("Entre com a quantidade de colunas da matriz:  ");
            int c = int.Parse(Console.ReadLine());

            int[,] mat = new int[l, c];

            Console.WriteLine("Entre com os valores da matriz:  ");

            for (int i = 0; i < l; i++) {
                string[] values = Console.ReadLine().Split(' ');
                for (int j = 0; j < c; j++) {
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            //for (int i = 0; i < l; i++) {
            //    for (int j = 0; j < c; j++) {
            //        Console.Write($"{mat[i, j]}  ");
            //    }
            //}

            Console.Write("Escolha um numero pertencente a matriz:  ");
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < l; i++) {
                for (int j = 0; j < c; j++) {
                    if (mat[i, j] == num) {
                        Console.WriteLine($"Position: {i},{j}");

                        if (j > 0) {
                            Console.WriteLine($"Left: {mat[i, j - 1]}");
                        }
                        if (j < c - 1) {
                            Console.WriteLine($"Right: {mat[i, j + 1]}");
                        }
                        if (i > 0) {
                            Console.WriteLine($"Up: {mat[i - 1, j]}");
                        }
                        if (i < l - 1) {
                            Console.WriteLine($"Down: {mat[i + 1, j]}");
                        }

                    Console.WriteLine();
                    }
                }
            }

        }
    }
}