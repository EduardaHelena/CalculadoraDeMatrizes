using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraDeMatriz
{
    class Calculos
    {

        #region Soma de matrizes
        /// <summary>
        /// método de somar as matrízes
        /// </summary>
        /// <param name="matriz1"></matriz1 em float>
        /// <param name="matriz2"></matriz2 em float>
        /// <returns></returns>
        public static float[,] SomandoMatrizes(float[,] matriz1, float[,] matriz2)
        {
            float[,] matrizResultado = new float[matriz1.GetLongLength(0), matriz1.GetLength(1)];
            for (int x = 0; x < matrizResultado.GetLength(0); x++)
            {
                for (int y = 0; y < matrizResultado.GetLength(1); y++)
                {
                    matrizResultado[x, y] = matriz1[x, y] += matriz2[x, y];
                }
            }
            return matrizResultado;
        }
        #endregion
        /// <summary>
        /// método de somar as matrízes
        /// </summary>
        /// <param name="matriz1"></matriz1 em float>
        /// <param name="matriz2"></matriz2 em float>
        /// <returns></returns>
        #region Subtração de matrizes
        /// <summary>
        /// método de subtrair as matrízes
        /// </summary>
        /// <param name="matriz1"></matriz1 em float>
        /// <param name="matriz2"></matriz2 em float>
        /// <returns></returns>
        public static float[,] SubtraindoMatrizes(float[,] matriz1, float[,] matriz2)
        {
            float[,] matrizResultado = new float[matriz1.GetLongLength(0), matriz1.GetLength(1)];
            for (int x = 0; x < matrizResultado.GetLength(0); x++)
            {
                for (int y = 0; y < matrizResultado.GetLength(1); y++)
                {
                    matrizResultado[x, y] = matriz1[x, y] -= matriz2[x, y];
                }
            }
            return matrizResultado;
        }
        #endregion

        #region Multiplicacao de Matrizes
        /// <summary>
        /// método de multiplicar as matrízes
        /// </summary>
        /// <param name="matriz1"></matriz1 em float>
        /// <param name="matriz2"></matriz2 em float>
        /// <returns></returns>
        public static float[,] MultiplicandoMatrizes(float[,] matriz1, float[,] matriz2)
        {
            float[,] matrizResultado = new float[matriz1.GetLength(0), matriz2.GetLength(1)];
            for (int x = 0; x < matrizResultado.GetLength(0); x++)
            {
                for (int y = 0; y < matrizResultado.GetLength(1); y++)
                {
                    for (int n = 0; n < matriz2.GetLength(0); n++)
                    {
                        string i = "" + matriz1[x, n];
                        matrizResultado[x, y] += matriz1[x, n] * matriz2[n, y];
                    }
                }
            }
            return matrizResultado;
        }
        #endregion

        #region Mutiplicacao Escalar
        /// <summary>
        /// método de multiplicação de uma matriz por um número escalar
        /// </summary>
        /// <param name="matriz1"></matriz escolhida em float>
        /// <param name="valor"></número escalar em float>
        /// <returns></returns>
        public static float[,] EscalarMatriz(float[,] matriz, float valor)
        {
            float[,] matrixfinal = new float[matriz.GetLength(0), matriz.GetLength(1)];
            int lin = matriz.GetLength(0);
            int col = matriz.GetLength(1);
            for (int i = 0; i < lin; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    matrixfinal[i, j] = matriz[i, j] * valor;
                }
            }
            return matrixfinal;
        }
        #endregion

        #region Matriz Oposta
        /// <summary>
        /// método de obter a matriz oposta de uma matriz
        /// </summary>
        /// <param name="matriz"></matriz escolhida em float>
        /// <returns></returns>
        public static float[,] GerarOposta(float[,] matriz)
        {
            float[,] matrizOposta = new float[matriz.GetLength(0), matriz.GetLength(1)];
            for (int x = 0; x < matrizOposta.GetLength(0); x++)
            {
                for (int y = 0; y < matrizOposta.GetLength(1); y++)
                {
                    matrizOposta[x, y] += matriz[x, y] * -1;
                }
            }
            return matrizOposta;
        }
        #endregion 

        #region matriz Inversa
        /// <summary>
        /// método de obter a matriz inversa de uma matriz
        /// </summary>
        /// <param name="determinante"></determinante da matriz escolhida em float>
        /// <param name="mmatriz"></matriz escolhida em float>
        /// <returns></returns>
        public static float[,] GerarInversa(float determinante, float[,] matriz)
        {
            float[,] matrizInversa = new float[matriz.GetLength(0), matriz.GetLength(1)];
            for (int x = 0; x < matriz.GetLength(0); x++)
            {
                for (int y = 0; y < matriz.GetLength(1); y++)
                {
                    float n = matriz[x, y];
                    n = n / determinante;
                    matrizInversa[x, y] += n;
                }
            }

            return matrizInversa;
        }
        #endregion

        #region Matriz Transposta
        /// <summary>
        /// método de subtrair as matrízes
        /// </summary>
        /// <param name="matriz"></matriz escolhida em float>
        /// <returns></returns>
        public static float[,] GerarTransposta(float[,] matriz)
        {
            float[,] matrizTransposta = new float[matriz.GetLength(1), matriz.GetLength(0)];
            for (int x = 0; x < matrizTransposta.GetLength(0); x++)
            {
                for (int y = 0; y < matrizTransposta.GetLength(1); y++)
                {
                    matrizTransposta[x, y] += matriz[y, x];
                }
            }
            return matrizTransposta;
        }
        #endregion

        #region Cofatora 2x2
        public static float[,] GerarCofatora2x2(float[,] matriz1)
        {
            float[,] matrizCofatora = new float[matriz1.GetLength(0), matriz1.GetLength(1)];
            float determinanteDaVez = 0;

            for (int x = 0; x < matriz1.GetLength(0); x++)
            {
                for (int y = 0; y < matriz1.GetLength(1); y++)
                {
                    if (x == 0 && y == 0)
                    {
                        determinanteDaVez = matriz1[x + 1, y + 1];
                    }
                    else if (x == 0 && y == 1)
                    {
                        determinanteDaVez = matriz1[x + 1, y - 1];
                    }
                    else if (x == 1 && y == 0)
                    {
                        determinanteDaVez = matriz1[x - 1, y + 1];
                    }
                    else if (x == 1 && y == 1)
                    {
                        determinanteDaVez = matriz1[x - 1, y - 1];
                    }
                    double i = Math.Pow(-1, (x + y));
                    matrizCofatora[x, y] += (float)i * determinanteDaVez;
                }
            }
            return matrizCofatora;
        }
        #endregion

        #region Cofatora 3x3
        public static float[,] GerarCofatora3x3(float[,] matriz1)
        {
            float[,] matrizCofatora = new float[matriz1.GetLength(0), matriz1.GetLength(1)];
            float determinanteDaVez = 0;

            for (int x = 0; x < matriz1.GetLength(0); x++)
            {
                for (int y = 0; y < matriz1.GetLength(1); y++)
                {
                    determinanteDaVez = DeterminanteCofator(x, y, matriz1);
                    double i = Math.Pow(-1, (x + y));
                    matrizCofatora[x, y] += (float)i * determinanteDaVez;
                }
            }
            return matrizCofatora;
        }
        #endregion

        #region Determinante Cofatora
        private static float DeterminanteCofator(int posX, int posY, float[,] matriz)
        {
            float[,] matrizResultante = new float[2, 2];
            int id = 0;
            for (int x = 0; x < matriz.GetLength(0); x++)
            {
                for (int y = 0; y < matriz.GetLength(1); y++)
                {
                    if (x != posX && y != posY)
                    {
                        if (id == 0)
                        {
                            matrizResultante[0, 0] += matriz[x, y];
                        }
                        else if (id == 1)
                        {
                            matrizResultante[0, 1] += matriz[x, y];
                        }
                        else if (id == 2)
                        {
                            matrizResultante[1, 0] += matriz[x, y];
                        }
                        else if (id == 3)
                        {
                            matrizResultante[1, 1] += matriz[x, y];
                        }
                        id++;
                    }
                }
            }
            float determinate = GerarDeterminante2x2(matrizResultante);
            return determinate;
        }
        #endregion

        #region Determinante 2x2
        /// <summary>
        /// método de obter determinante de matrizes 2x2
        /// </summary>
        /// <param name="matriz"></matriz escolhida em float>
        /// <returns></returns>
        public static float GerarDeterminante2x2(float[,] matriz)
        {
            float diagonalPrincipal = 1;
            float diagonalSecundaria = 1;
            float determinanteFinal = 0;
            for (int x = 0; x < matriz.GetLength(0); x++)
            {
                for (int y = 0; y < matriz.GetLength(1); y++)
                {
                    if (x == y)
                    {
                        diagonalPrincipal *= matriz[x, y];
                    }
                }
            }
            for (int x = 0; x < matriz.GetLength(0); x++)
            {
                for (int y = 0; y < matriz.GetLength(1); y++)
                {
                    if (x != y)
                    {
                        diagonalSecundaria *= matriz[x, y];
                    }
                }
            }
            determinanteFinal = diagonalPrincipal - diagonalSecundaria;
            return determinanteFinal;
        }
        #endregion

        #region Determinante 3x3
        /// <summary>
        /// método de obter determinante de matrizes 3x3
        /// </summary>
        /// <param name="matriz"></matriz escolhida em float>
        /// <returns></returns>
        public static float GerarDeterminante3x3(float[,] matriz)
        {
            float diagonalPrincipal = 0;
            float diagonalSecundaria = 0;
            float determinanteFinal = 0;
            int tamanhoSarrus = (((matriz.GetLength(0) * matriz.GetLength(1)) * 2) / 3) - 1;
            float[,] Sarrus = new float[matriz.GetLength(0), tamanhoSarrus];
            for (int x = 0; x < Sarrus.GetLength(0); x++)
            {
                for (int y = 0; y < Sarrus.GetLength(1); y++)
                {
                    if (y > matriz.GetLength(0) - 1)
                    {
                        Sarrus[x, y] += matriz[x, y - matriz.GetLength(0)];
                    }
                    else
                    {
                        Sarrus[x, y] += matriz[x, y];
                    }
                }
            }
            int voltas = 3;
            for (int i = 0; i < voltas; i++)
            {
                int numero = i;
                float mDiagonal = 1;
                for (int x = 0; x < Sarrus.GetLength(0); x++)
                {
                    for (int y = 0; y < Sarrus.GetLength(1); y++)
                    {
                        if (x == y)
                        {
                            string z = "" + Sarrus[x, y + numero];
                            mDiagonal *= Sarrus[x, y + numero];
                        }
                    }
                }
                diagonalPrincipal += mDiagonal;
            }

            for (int i = 0; i < voltas; i++)
            {
                int numero = i;
                float mDiagonal = 1;
                for (int x = 0; x < Sarrus.GetLength(0); x++)
                {
                    for (int y = Sarrus.GetLength(1) - 1; y > 0; y--)
                    {
                        if (x == (Sarrus.GetLength(1) - 1) - y)
                        {
                            string z = "" + Sarrus[x, y - numero];
                            mDiagonal *= Sarrus[x, y - numero];
                        }
                    }
                }
                diagonalSecundaria += mDiagonal;
            }
            determinanteFinal = diagonalPrincipal - diagonalSecundaria;
            return determinanteFinal;
        }
        #endregion

        /// <summary>
        /// método de gerar matrizes a partir da lei de formação
        /// </summary>
        /// <param name="Lei"></string digitada pelo usuário>
        /// <param name="lines"></quantidade de linhas em int>
        /// <param name="col"></quantidade de colunas em int>
        /// <returns></returns>
        #region Lei De Formação
        public static float[,] LeiDeFormacao(string lei, int lines, int col)
        {
            
            char[] expression = lei.ToCharArray();
            float[,] matriz = new float[lines, col];
            char conta = 'a';
            float result = 0;
            for (int i = 0; i < lines; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    foreach (char s in expression)
                    {
                        switch (s)
                        {
                            case '+':
                                conta = s;
                                break;
                            case '-':
                                conta = s;
                                break;
                            case '*':
                                conta = s;
                                break;
                            case '/':
                                conta = s;
                                break;
                            case '^':
                                conta = s;
                                break;
                            case 'i':
                                if (result == 0)
                                {
                                    result = i + 1;
                                }
                                else
                                {
                                    switch (conta)
                                    {
                                        case '+':
                                            result += i + 1;
                                            break;
                                        case '-':
                                            result -= i + 1;
                                            break;
                                        case '*':
                                            result *= i + 1;
                                            break;
                                        case '/':
                                            result /= i + 1;
                                            break;
                                        case '^':
                                            result = (float)Math.Pow(result, i + 1);
                                            break;
                                    }
                                }
                                break;
                            case 'j':
                                if (result == 0)
                                {
                                    result = j + 1;
                                }
                                else
                                {
                                    switch (conta)
                                    {
                                        case '+':
                                            result += j + 1;
                                            break;
                                        case '-':
                                            result -= j + 1;
                                            break;
                                        case '*':
                                            result *= j + 1;
                                            break;
                                        case '/':
                                            result /= j + 1;
                                            break;
                                        case '^':
                                            result = (float)Math.Pow(result, j + 1);
                                            break;
                                    }
                                }
                                break;
                            default:
                                if (result == 0)
                                {
                                    result = int.Parse(s.ToString());
                                }
                                else
                                {
                                    switch (conta)
                                    {
                                        case '+':
                                            result += int.Parse(s.ToString());
                                            break;
                                        case '-':
                                            result -= int.Parse(s.ToString());
                                            break;
                                        case '*':
                                            result *= int.Parse(s.ToString());
                                            break;
                                        case '/':
                                            result /= int.Parse(s.ToString());
                                            break;
                                        case '^':
                                            result = (float)Math.Pow(result, int.Parse(s.ToString()));
                                            break;
                                    }
                                }
                                break;
                        }
                    }
                    matriz[i, j] = result;
                    result = 0;
                }
            }
            return matriz;
        }
        #endregion
    }
}
