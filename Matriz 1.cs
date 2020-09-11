using System;

namespace matrix
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Random random = new Random();
            string[] valores = { "-", "-", "O", "X" };
            int n = 10;
            int m = 15;

            double contx = 0;
            double conto = 0;
            double contn = 0;
            double total = 0;

            
            string[,] tablero = new string[n, m];
            string[,] salida = new string[n, m];

            //Repartición de datos X O -
            for (int i = 0; i < tablero.GetLength(0); i++)
            {
                for (int j = 0; j < tablero.GetLength(1); j++)
                {
                    int indice = random.Next(0, valores.Length);
                    tablero[i, j] = valores[indice];
                    salida[i, j] = "-";
                }
            }
            //Entrada de estos datos a la matriz
            Console.WriteLine("ENTRADA:  ");
            for (int i = 0; i < tablero.GetLength(0); i++)
            {
                for (int j = 0; j < tablero.GetLength(1); j++)
                {
                    Console.Write("|" + tablero[i, j]);
                }
                Console.Write("|\n");
            }

            //Proceso
            for (int i = 0; i < tablero.GetLength(0) - 2; i++)
            {
                for (int j = 0; j < tablero.GetLength(1) - 2; j++)
                {
                    if (tablero[i, j] == "X")
                    {
                        contx++;
                    }
                    if (tablero[i, j] == "O")
                    {
                        conto++;
                    }
                    if (tablero[i, j] == "-")
                    {
                        contn++;
                    }
                    if (tablero[i, j + 0] == tablero[i, j + 1] && tablero[i, j + 1] == tablero[i, j + 2])
                    {
                        if (tablero[i, j] == "X")
                        {
                            salida[i, j + 0] = "1";
                            salida[i, j + 1] = "1";
                            salida[i, j + 2] = "1";
                        }
                        else if (tablero[i, j] == "O")
                        {
                            salida[i, j] = "2";
                            salida[i, j + 1] = "2";
                            salida[i, j + 2] = "2";
                        }

                    }
                    if (tablero[i + 0, j] == tablero[i + 1, j] && tablero[i + 1, j] == tablero[i + 2, j])
                    {
                        if (tablero[i, j] == "X")
                        {
                            salida[i + 0, j] = "2";
                            salida[i + 1, j] = "2";
                            salida[i + 2, j] = "2";
                        }
                        else if (tablero[i, j] == "O")
                        {
                            salida[i + 0, j] = "2";
                            salida[i + 1, j] = "2";
                            salida[i + 2, j] = "2";
                        }
                    }          
                }
            }

            //Conteo y Porcentajes de X,0,-           
            total = conto + contx + contn;

            double porcentajex = (100 * contx) / total;
            Console.WriteLine("PORCENTAJE DE X ES:  " + porcentajex);

            double porcentajeo = (100 * conto) / total;
            Console.WriteLine("EL PORCENTAJE DE O ES:  " + porcentajeo);

            double porcentajen = (100 * contn) / total;
            Console.WriteLine("EL PORCENTAJE DE - ES:  " + porcentajen);

            //Salida
            Console.WriteLine("\nSALIDA:  ");
            for (int i = 0; i < tablero.GetLength(0); i++)
            {
                for (int j = 0; j < tablero.GetLength(1); j++)
                {
                    Console.Write("|" + salida[i, j]);
                }
                Console.Write("|\n");
            }
            Console.Write("\n");
        }
    }
}
