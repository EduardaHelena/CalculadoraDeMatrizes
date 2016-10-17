using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraDeMatriz
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        private TextBox[,] Matriz1;
        private TextBox[,] Matriz2;
        private TextBox[,] matrizResultado;


        #region CriarMatrizes
        private void Gerar_Click(object sender, EventArgs e)
        {
            groupBox1.Controls.Clear();


            int linha1 = Convert.ToInt32(Linhas1.Value);
            int coluna1 = Convert.ToInt32(Colunas1.Value);
            if (formula1.TextLength < 1)
            {
                Matriz1 = new TextBox[linha1, coluna1];
                int TamanhoText = groupBox1.Width / coluna1;
                for (int x = 0; x < Matriz1.GetLength(0); x++)
                {
                    for (int y = 0; y < Matriz1.GetLength(1); y++)
                    {
                        Matriz1[x, y] = new TextBox();
                        Matriz1[x, y].Text = "0";
                        Matriz1[x, y].Top = (x * Matriz1[x, y].Height) + 20;
                        Matriz1[x, y].Left = y * TamanhoText + 6;
                        Matriz1[x, y].Width = TamanhoText;
                        groupBox1.Controls.Add(Matriz1[x, y]);
                    }
                }
            }
            else
            {
                Matriz1 = new TextBox[linha1, coluna1];
                float[,] matriz = Calculos.LeiDeFormacao(formula1.Text, linha1, coluna1);
                int TamanhoText = groupBox1.Width / coluna1;
                for (int x = 0; x < Matriz1.GetLength(0); x++)
                {
                    for (int y = 0; y < Matriz1.GetLength(1); y++)
                    {
                        Matriz1[x, y] = new TextBox();
                        Matriz1[x, y].Text = "0";
                        Matriz1[x, y].Top = (x * Matriz1[x, y].Height) + 20;
                        Matriz1[x, y].Left = y * TamanhoText + 6;
                        Matriz1[x, y].Width = TamanhoText;
                        Matriz1[x, y].Text = Convert.ToString(matriz[x, y]);
                        groupBox1.Controls.Add(Matriz1[x, y]);
                    }
                }
            }
        }


        private void Gerar2_Click(object sender, EventArgs e)
        {
            groupBox2.Controls.Clear();

            int linha2 = Convert.ToInt32(Linhas2.Value);
            int coluna2 = Convert.ToInt32(Colunas2.Value);

            if (formula2.TextLength < 1)
            {
                Matriz2 = new TextBox[linha2, coluna2];
                int TamanhoText = groupBox2.Width / coluna2;
                for (int x = 0; x < Matriz2.GetLength(0); x++)
                {
                    for (int y = 0; y < Matriz2.GetLength(1); y++)
                    {
                        Matriz2[x, y] = new TextBox();
                        Matriz2[x, y].Text = "0";
                        Matriz2[x, y].Top = (x * Matriz2[x, y].Height) + 20;
                        Matriz2[x, y].Left = y * TamanhoText + 6;
                        Matriz2[x, y].Width = TamanhoText;
                        groupBox2.Controls.Add(Matriz2[x, y]);
                    }
                }
            }
            else
            {
                Matriz2 = new TextBox[linha2, coluna2];
                float[,] matriz = Calculos.LeiDeFormacao(formula2.Text, linha2, coluna2);
                int TamanhoText = groupBox2.Width / coluna2;
                for (int x = 0; x < Matriz2.GetLength(0); x++)
                {
                    for (int y = 0; y < Matriz2.GetLength(1); y++)
                    {
                        Matriz2[x, y] = new TextBox();
                        Matriz2[x, y].Text = "0";
                        Matriz2[x, y].Top = (x * Matriz2[x, y].Height) + 20;
                        Matriz2[x, y].Left = y * TamanhoText + 6;
                        Matriz2[x, y].Width = TamanhoText;
                        Matriz2[x, y].Text = Convert.ToString(matriz[x, y]);
                        groupBox2.Controls.Add(Matriz2[x, y]);
                    }
                }
            }
       
        }
        #endregion

        #region Limpar
        private void LimparResult_Click_1(object sender, EventArgs e)
        {
            groupBox3.Controls.Clear();
        }

        private void Limpar2_Click(object sender, EventArgs e)
        {
            groupBox2.Controls.Clear();
        }

        private void Limpa_Click(object sender, EventArgs e)
        {
            groupBox1.Controls.Clear();
        }

        #endregion

        #region Soma Matrizes

        private void BotaoSoma_Click(object sender, EventArgs e)
        {
           if (Matriz1 == null || Matriz2 == null)
            {
                MessageBox.Show("Matriz nula !", "Error - Matriz");
                return;
            }
            float[,] tempMatriz1 = new float[Matriz1.GetLength(0), Matriz1.GetLength(1)];
            float[,] tempMatriz2 = new float[Matriz2.GetLength(0), Matriz2.GetLength(1)];
            if (tempMatriz1.GetLength(0) != tempMatriz2.GetLength(0) || tempMatriz1.GetLength(1) != tempMatriz2.GetLength(1))
            {
                MessageBox.Show("Só é possível somar matrizes de mesma ordem !", "Erro - Soma Matrizes");
                return;
            }

            for (int x = 0; x < Matriz1.GetLength(0); x++)
            {
                for (int y = 0; y < Matriz1.GetLength(1); y++)
                {
                    float n = 0;
                    float.TryParse(Matriz1[x, y].Text, out n);
                    tempMatriz1[x, y] = n;
                }
            }
            for (int x = 0; x < Matriz2.GetLength(0); x++)
            {
                for (int y = 0; y < Matriz2.GetLength(1); y++)
                {
                    float n = 0;
                    float.TryParse(Matriz2[x, y].Text, out n);
                    tempMatriz2[x, y] = n;
                }
            }

            float[,] tempMatrizResultante = Calculos.SomandoMatrizes(tempMatriz1, tempMatriz2);
            matrizResultado = new TextBox[tempMatrizResultante.GetLength(0), tempMatrizResultante.GetLength(1)];
            int TamanhoText = groupBox3.Width / matrizResultado.GetLength(1);
            groupBox3.Controls.Clear();
            for (int x = 0; x < matrizResultado.GetLength(0); x++)
            {
                for (int y = 0; y < matrizResultado.GetLength(1); y++)
                {
                    matrizResultado[x, y] = new TextBox();
                    matrizResultado[x, y].Text = tempMatrizResultante[x, y].ToString();
                    matrizResultado[x, y].Top = (x * matrizResultado[x, y].Height) + 20;
                    matrizResultado[x, y].Left = y * TamanhoText + 6;
                    matrizResultado[x, y].Width = TamanhoText;
                    groupBox3.Controls.Add(matrizResultado[x, y]);
                }
            }
        }
        
        

        #endregion

        #region Subtração Matrizes
        private void BotaoSubtrair_Click(object sender, EventArgs e)
        {
            if (Matriz1 == null || Matriz2 == null)
            {
                MessageBox.Show("Matriz nula !");
                return;
            }
            float[,] tempMatriz1 = new float[Matriz1.GetLength(0), Matriz1.GetLength(1)];
            float[,] tempMatriz2 = new float[Matriz2.GetLength(0), Matriz2.GetLength(1)];
            if (tempMatriz1.GetLength(0) != tempMatriz2.GetLength(0) || tempMatriz1.GetLength(1) != tempMatriz2.GetLength(1))
            {
                MessageBox.Show("Somente é possível a subtração de matrizes de mesma ordem !");
                return;
            }

            for (int x = 0; x < Matriz1.GetLength(0); x++)
            {
                for (int y = 0; y < Matriz1.GetLength(1); y++)
                {
                    float n = 0;
                    float.TryParse(Matriz1[x, y].Text, out n);
                    tempMatriz1[x, y] = n;
                }
            }
            for (int x = 0; x < Matriz2.GetLength(0); x++)
            {
                for (int y = 0; y < Matriz2.GetLength(1); y++)
                {
                    float n = 0;
                    float.TryParse(Matriz2[x, y].Text, out n);
                    tempMatriz2[x, y] = n;
                }
            }

            float[,] tempMatrizResultante = Calculos.SubtraindoMatrizes(tempMatriz1, tempMatriz2);
            matrizResultado = new TextBox[tempMatrizResultante.GetLength(0), tempMatrizResultante.GetLength(1)];
            int TamanhoText = groupBox3.Width / matrizResultado.GetLength(1);
            groupBox3.Controls.Clear();
            for (int x = 0; x < matrizResultado.GetLength(0); x++)
            {
                for (int y = 0; y < matrizResultado.GetLength(1); y++)
                {
                    matrizResultado[x, y] = new TextBox();
                    matrizResultado[x, y].Text = tempMatrizResultante[x, y].ToString();
                    matrizResultado[x, y].Top = (x * matrizResultado[x, y].Height) + 20;
                    matrizResultado[x, y].Left = y * TamanhoText + 6;
                    matrizResultado[x, y].Width = TamanhoText;
                    groupBox3.Controls.Add(matrizResultado[x, y]);
                }
            }
        }
        #endregion

        #region Multiplicacao de Matrizes
        private void Multiplica_Click(object sender, EventArgs e)
        {
             if (Matriz1 == null || Matriz2 == null)
            {
                MessageBox.Show("Matriz nula !", "Error - Matriz");
                return;
            }
            float[,] tempMatriz1 = new float[Matriz1.GetLength(0), Matriz1.GetLength(1)];
            float[,] tempMatriz2 = new float[Matriz2.GetLength(0), Matriz2.GetLength(1)];
            if (tempMatriz1.GetLength(1) != tempMatriz2.GetLength(0))
            {
                MessageBox.Show("Só é possível a multiplicação de matrizes onde, a coluna da matriz 1 e igual a linha da matriz 2  !", "Erro - Multiplicação Matrizes");
                return;
            }

            for (int x = 0; x < Matriz1.GetLength(0); x++)
            {
                for (int y = 0; y < Matriz1.GetLength(1); y++)
                {
                    float n = 0;
                    float.TryParse(Matriz1[x, y].Text, out n);
                    tempMatriz1[x, y] = n;
                }
            }
            for (int x = 0; x < Matriz2.GetLength(0); x++)
            {
                for (int y = 0; y < Matriz2.GetLength(1); y++)
                {
                    float n = 0;
                    float.TryParse(Matriz2[x, y].Text, out n);
                    tempMatriz2[x, y] = n;
                }
            }

            float[,] tempMatrizResultante = Calculos.MultiplicandoMatrizes(tempMatriz1, tempMatriz2);
            matrizResultado = new TextBox[tempMatrizResultante.GetLength(0), tempMatrizResultante.GetLength(1)];
            int TamanhoText = groupBox3.Width / matrizResultado.GetLength(1);
            groupBox3.Controls.Clear();
            for (int x = 0; x < matrizResultado.GetLength(0); x++)
            {
                for (int y = 0; y < matrizResultado.GetLength(1); y++)
                {
                    matrizResultado[x, y] = new TextBox();
                    matrizResultado[x, y].Text = tempMatrizResultante[x, y].ToString();
                    matrizResultado[x, y].Top = (x * matrizResultado[x, y].Height) + 20;
                    matrizResultado[x, y].Left = y * TamanhoText + 6;
                    matrizResultado[x, y].Width = TamanhoText;
                    groupBox3.Controls.Add(matrizResultado[x, y]);
                }
            }
        
        }

        #endregion 



        #region EscolhaMatriz1
       
        private void oper_SelectedIndexChanged(object sender, EventArgs e)
        {

                    switch (oper.Text) {
     

                    case "Oposta Matriz 1":
                        
                        Oposta(); 
                        break;

                    case "Inversa Matriz 1":
                        Inversa();
                        break;

                    case "Transposta Matriz 1":
                        Transposta();
                        break;

                    case "Determinante Matriz 1":
                        Determinante();
                        break;              

                    default:
                        Console.WriteLine(" Erro na matriz!");
                        break;
                }

        }
        #endregion 

        #region Multiplicacao Escalar1
        private void MultiEscalar_Click(object sender, EventArgs e)
        {
            if (Matriz1 == null)
            {
                MessageBox.Show("Matriz nula !", "Error - Matriz");
                return;
            }

            float[,] tempResultante = new float[Matriz1.GetLength(0), Matriz1.GetLength(1)];

            for (int x = 0; x < Matriz1.GetLength(0); x++)
            {
                for (int y = 0; y < Matriz1.GetLength(1); y++)
                {
                    float n = 0;
                    float.TryParse(Matriz1[x, y].Text, out n);
                    tempResultante[x, y] = n;
                }
            }

            float[,] tempMatrizResultante = Calculos.EscalarMatriz(tempResultante, (float)NuEscalar1.Value); ;
            int TamanhoText = groupBox1.Width / Matriz1.GetLength(1);
            for (int x = 0; x < Matriz1.GetLength(0); x++)
            {
                for (int y = 0; y < Matriz1.GetLength(1); y++)
                {
                    Matriz1[x, y].Text = tempMatrizResultante[x, y].ToString();
                }
            }

        }

        #endregion

        #region ChamaOposta1
        public void Oposta()
        {
            if (Matriz1 == null)
            {
                MessageBox.Show("Matriz nula !", "Error - Matriz");
                return;
            }
            float[,] tempResultante = new float[Matriz1.GetLength(0), Matriz1.GetLength(1)];

            for (int x = 0; x < Matriz1.GetLength(0); x++)
            {
                for (int y = 0; y < Matriz1.GetLength(1); y++)
                {
                    float n = 0;
                    float.TryParse(Matriz1[x, y].Text, out n);
                    tempResultante[x, y] = n;
                }
            }

            float[,] tempMatrizResultante = Calculos.GerarOposta(tempResultante);
            int TamanhoText = groupBox1.Width / Matriz1.GetLength(1);
            for (int x = 0; x < Matriz1.GetLength(0); x++)
            {
                for (int y = 0; y < Matriz1.GetLength(1); y++)
                {
                    Matriz1[x, y].Text = tempMatrizResultante[x, y].ToString();
                }
            }
        }

        #endregion

        #region ChamaInversa1
        public void Inversa()
        {
            if (Matriz1 == null)
            {
                MessageBox.Show("Matriz nula !", "Error - Matriz");
                return;
            }

            float[,] tempResultante = new float[Matriz1.GetLength(0), Matriz1.GetLength(1)];
            float[,] matrizAdjunta = new float[Matriz1.GetLength(0), Matriz1.GetLength(1)];
            float[,] matrizCofatora = new float[Matriz1.GetLength(0), Matriz1.GetLength(1)];
            float determinante = 0;

            if (tempResultante.GetLength(0) != 2 || tempResultante.GetLength(1) != 2)
            {
                if (tempResultante.GetLength(0) != 3 || tempResultante.GetLength(1) != 3)
                {
                    MessageBox.Show("Matriz invalida !", "Error - Matriz");
                    return;
                }
            }

            for (int x = 0; x < Matriz1.GetLength(0); x++)
            {
                for (int y = 0; y < Matriz1.GetLength(1); y++)
                {
                    float n = 0;
                    float.TryParse(Matriz1[x, y].Text, out n);
                    tempResultante[x, y] = n;
                }
            }

            if (tempResultante.GetLength(0) == 2 && tempResultante.GetLength(1) == 2)
            {
                matrizCofatora = Calculos.GerarCofatora2x2(tempResultante);
                matrizAdjunta = Calculos.GerarTransposta(matrizCofatora);
                determinante = Calculos.GerarDeterminante2x2(tempResultante);
            }
            else if (tempResultante.GetLength(0) == 3 && tempResultante.GetLength(1) == 3)
            {
                matrizCofatora = Calculos.GerarCofatora3x3(tempResultante);
                matrizAdjunta = Calculos.GerarTransposta(matrizCofatora);
                determinante = Calculos.GerarDeterminante3x3(tempResultante);
            }
            else
            {
                MessageBox.Show("Matriz invalida !", "Error - Matriz");
                return;
            }
            if (determinante == 0)
            {
                MessageBox.Show("Matriz invalida, determinante igual a 0 !", "Error - Matriz");
                return;
            }
            float[,] tempMatrizResultante = Calculos.GerarInversa(determinante, matrizAdjunta);
            int TamanhoText = groupBox1.Width / Matriz1.GetLength(1);
            for (int x = 0; x < Matriz1.GetLength(0); x++)
            {
                for (int y = 0; y < Matriz1.GetLength(1); y++)
                {
                    Matriz1[x, y].Text = tempMatrizResultante[x, y].ToString();
                }
            }
        }
        #endregion

        #region ChamaTransposta1

        public void Transposta()
        {
            if (Matriz1 == null)
            {
                MessageBox.Show("Matriz nula !", "Error - Matriz");
                return;
            }
            float[,] tempResultante = new float[Matriz1.GetLength(0), Matriz1.GetLength(1)];

            for (int x = 0; x < Matriz1.GetLength(0); x++)
            {
                for (int y = 0; y < Matriz1.GetLength(1); y++)
                {
                    float n = 0;
                    float.TryParse(Matriz1[x, y].Text, out n);
                    tempResultante[x, y] = n;
                }
            }

            float[,] tempMatrizResultante = Calculos.GerarTransposta(tempResultante);
            int TamanhoText = groupBox1.Width / Matriz1.GetLength(1);
            Matriz1 = new TextBox[tempMatrizResultante.GetLength(0), tempMatrizResultante.GetLength(1)];
            groupBox1.Controls.Clear();
            for (int x = 0; x < Matriz1.GetLength(0); x++)
            {
                for (int y = 0; y < Matriz1.GetLength(1); y++)
                {
                    Matriz1[x, y] = new TextBox();
                    Matriz1[x, y].Text = tempMatrizResultante[x, y].ToString();
                    Matriz1[x, y].Top = (x * Matriz1[x, y].Height) + 20;
                    Matriz1[x, y].Left = y * TamanhoText + 6;
                    Matriz1[x, y].Width = TamanhoText;
                    groupBox1.Controls.Add(Matriz1[x, y]);
                }
            }
        }

        #endregion

        #region ChamaDeterminate1

        public void Determinante()
        {
            if (Matriz1 == null)
            {
                MessageBox.Show("Matriz nula !", "Error - Matriz");
                return;
            }
            float[,] tempResultante = new float[Matriz1.GetLength(0), Matriz1.GetLength(1)];

            for (int x = 0; x < Matriz1.GetLength(0); x++)
            {
                for (int y = 0; y < Matriz1.GetLength(1); y++)
                {
                    float n = 0;
                    float.TryParse(Matriz1[x, y].Text, out n);
                    tempResultante[x, y] = n;
                }
            }
            if (tempResultante.GetLength(0) == 2 && tempResultante.GetLength(1) == 2)
            {
                float determinante = Calculos.GerarDeterminante2x2(tempResultante);
                MessageBox.Show("" + determinante, "Determinante...");
            }
            else if (tempResultante.GetLength(0) == 3 && tempResultante.GetLength(1) == 3)
            {
                float determinante = Calculos.GerarDeterminante3x3(tempResultante);
                MessageBox.Show("" + determinante, "Determinante...");
            }
            else
            {
                MessageBox.Show("Não é possível gerar determinante !", "Error - Matriz invalida ");
            }
        }

        #endregion


        #region EscolhaMatriz2

        private void oper2_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (oper2.Text)
            {


                case "Oposta Matriz 2":

                    Oposta2();
                    break;

                case "Inversa Matriz 2":
                    Inversa2();
                    break;

                case "Transposta Matriz 2":
                    Transposta2();
                    break;

                case "Determinante Matriz 2":
                    Determinante2();
                    break;

                default:
                    Console.WriteLine(" Erro na matriz!");
                    break;
            }

        }
        #endregion

        #region Mutilpicacao Escalar2
        private void MultiEscalar2_Click(object sender, EventArgs e)
        {


            if (Matriz2 == null)
            {
                MessageBox.Show("Matriz nula !", "Error - Matriz");
                return;
            }

            float[,] tempResultante = new float[Matriz2.GetLength(0), Matriz2.GetLength(1)];

            for (int x = 0; x < Matriz2.GetLength(0); x++)
            {
                for (int y = 0; y < Matriz2.GetLength(1); y++)
                {
                    float n = 0;
                    float.TryParse(Matriz2[x, y].Text, out n);
                    tempResultante[x, y] = n;
                }
            }

            float[,] tempMatrizResultante = Calculos.EscalarMatriz(tempResultante, (float)NuEscalar2.Value); ;
            int TamanhoText = groupBox2.Width / Matriz2.GetLength(1);
            for (int x = 0; x < Matriz2.GetLength(0); x++)
            {
                for (int y = 0; y < Matriz2.GetLength(1); y++)
                {
                    Matriz2[x, y].Text = tempMatrizResultante[x, y].ToString();
                }
            }

        }
        #endregion

        #region ChamaOposta2
        public void Oposta2()
        {
            if (Matriz2 == null)
            {
                MessageBox.Show("Matriz nula !", "Error - Matriz");
                return;
            }
            float[,] tempResultante = new float[Matriz2.GetLength(0), Matriz2.GetLength(1)];

            for (int x = 0; x < Matriz2.GetLength(0); x++)
            {
                for (int y = 0; y < Matriz2.GetLength(1); y++)
                {
                    float n = 0;
                    float.TryParse(Matriz2[x, y].Text, out n);
                    tempResultante[x, y] = n;
                }
            }

            float[,] tempMatrizResultante = Calculos.GerarOposta(tempResultante);
            int TamanhoText = groupBox2.Width / Matriz2.GetLength(1);
            for (int x = 0; x < Matriz2.GetLength(0); x++)
            {
                for (int y = 0; y < Matriz2.GetLength(1); y++)
                {
                    Matriz2[x, y].Text = tempMatrizResultante[x, y].ToString();
                }
            }
        }

        #endregion

        #region ChamaInversa2
        public void Inversa2()
        {
            if (Matriz2 == null)
            {
                MessageBox.Show("Matriz nula !", "Error - Matriz");
                return;
            }

            float[,] tempResultante = new float[Matriz2.GetLength(0), Matriz2.GetLength(1)];
            float[,] matrizAdjunta = new float[Matriz2.GetLength(0), Matriz2.GetLength(1)];
            float[,] matrizCofatora = new float[Matriz2.GetLength(0), Matriz2.GetLength(1)];
            float determinante = 0;

            if (tempResultante.GetLength(0) != 2 || tempResultante.GetLength(1) != 2)
            {
                if (tempResultante.GetLength(0) != 3 || tempResultante.GetLength(1) != 3)
                {
                    MessageBox.Show("Matriz invalida !", "Error - Matriz");
                    return;
                }
            }

            for (int x = 0; x < Matriz2.GetLength(0); x++)
            {
                for (int y = 0; y < Matriz2.GetLength(1); y++)
                {
                    float n = 0;
                    float.TryParse(Matriz2[x, y].Text, out n);
                    tempResultante[x, y] = n;
                }
            }

            if (tempResultante.GetLength(0) == 2 && tempResultante.GetLength(1) == 2)
            {
                matrizCofatora = Calculos.GerarCofatora2x2(tempResultante);
                matrizAdjunta = Calculos.GerarTransposta(matrizCofatora);
                determinante = Calculos.GerarDeterminante2x2(tempResultante);
            }
            else if (tempResultante.GetLength(0) == 3 && tempResultante.GetLength(1) == 3)
            {
                matrizCofatora = Calculos.GerarCofatora3x3(tempResultante);
                matrizAdjunta = Calculos.GerarTransposta(matrizCofatora);
                determinante = Calculos.GerarDeterminante3x3(tempResultante);
            }
            else
            {
                MessageBox.Show("Matriz invalida !", "Error - Matriz");
                return;
            }
            if (determinante == 0)
            {
                MessageBox.Show("Matriz invalida, determinante igual a 0 !", "Error - Matriz");
                return;
            }
            float[,] tempMatrizResultante = Calculos.GerarInversa(determinante, matrizAdjunta);
            int TamanhoText = groupBox2.Width / Matriz2.GetLength(1);
            for (int x = 0; x < Matriz2.GetLength(0); x++)
            {
                for (int y = 0; y < Matriz2.GetLength(1); y++)
                {
                    Matriz2[x, y].Text = tempMatrizResultante[x, y].ToString();
                }
            }
        }
        #endregion

        #region ChamaTransposta2

        public void Transposta2()
        {
            if (Matriz2 == null)
            {
                MessageBox.Show("Matriz nula !", "Error - Matriz");
                return;
            }
            float[,] tempResultante = new float[Matriz2.GetLength(0), Matriz2.GetLength(1)];

            for (int x = 0; x < Matriz2.GetLength(0); x++)
            {
                for (int y = 0; y < Matriz2.GetLength(1); y++)
                {
                    float n = 0;
                    float.TryParse(Matriz2[x, y].Text, out n);
                    tempResultante[x, y] = n;
                    //tempResultante[x, y] = Convert.ToInt32(Matriz2[x, y].Text);
                }
            }

            float[,] tempMatrizResultante = Calculos.GerarTransposta(tempResultante);
            int TamanhoText = groupBox2.Width / Matriz2.GetLength(1);
            Matriz2 = new TextBox[tempMatrizResultante.GetLength(0), tempMatrizResultante.GetLength(1)];
            groupBox2.Controls.Clear();
            for (int x = 0; x < Matriz2.GetLength(0); x++)
            {
                for (int y = 0; y < Matriz2.GetLength(1); y++)
                {
                    Matriz2[x, y] = new TextBox();
                    Matriz2[x, y].Text = tempMatrizResultante[x, y].ToString();
                    Matriz2[x, y].Top = (x * Matriz2[x, y].Height) + 20;
                    Matriz2[x, y].Left = y * TamanhoText + 6;
                    Matriz2[x, y].Width = TamanhoText;
                    groupBox2.Controls.Add(Matriz2[x, y]);
                }
            }
        }

        #endregion

        #region ChamaDeterminate2

        public void Determinante2()
        {
            if (Matriz2 == null)
            {
                MessageBox.Show("Matriz nula !", "Error - Matriz");
                return;
            }
            float[,] tempResultante = new float[Matriz2.GetLength(0), Matriz2.GetLength(1)];

            for (int x = 0; x < Matriz2.GetLength(0); x++)
            {
                for (int y = 0; y < Matriz2.GetLength(1); y++)
                {
                    float n = 0;
                    float.TryParse(Matriz2[x, y].Text, out n);
                    tempResultante[x, y] = n;
                }
            }
            if (tempResultante.GetLength(0) == 2 && tempResultante.GetLength(1) == 2)
            {
                float determinante = Calculos.GerarDeterminante2x2(tempResultante);
                MessageBox.Show("" + determinante, "Determinante...");
            }
            else if (tempResultante.GetLength(0) == 3 && tempResultante.GetLength(1) == 3)
            {
                float determinante = Calculos.GerarDeterminante3x3(tempResultante);
                MessageBox.Show("" + determinante, "Determinante...");
            }
            else
            {
                MessageBox.Show("Não é possível gerar determinante !", "Error - Matriz invalida ");
            }
        }

        #endregion


        #region EscolhaMatrizResultante

        private void operResultante_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (operResultante.Text)
            {


                case "Oposta MatrizR":

                    OpostaResultante();
                    break;

                case "Inversa MatrizR":
                    InversaResultante();
                    break;

                case "Transposta MatrizR":
                    TranspostaResultante();
                    break;

                case "Determinante MatrizR":
                    DeterminanteResultante();
                    break;

                default:
                    Console.WriteLine(" Erro na matriz!");
                    break;
            }

        }
        #endregion

        #region Multipicacao Escalar Resultante
        private void MultiEscalar3_Click(object sender, EventArgs e)
        {
            if (matrizResultado == null)
            {
                MessageBox.Show("Matriz nula !", "Error - Matriz");
                return;
            }

            float[,] tempResultante = new float[matrizResultado.GetLength(0), matrizResultado.GetLength(1)];

            for (int x = 0; x < matrizResultado.GetLength(0); x++)
            {
                for (int y = 0; y < matrizResultado.GetLength(1); y++)
                {
                    float n = 0;
                    float.TryParse(matrizResultado[x, y].Text, out n);
                    tempResultante[x, y] = n;
                }
            }

            float[,] tempMatrizResultante = Calculos.EscalarMatriz(tempResultante, (float)NuEscalar3.Value); ;
            int TamanhoText = groupBox3.Width / matrizResultado.GetLength(1);
            for (int x = 0; x < matrizResultado.GetLength(0); x++)
            {
                for (int y = 0; y < matrizResultado.GetLength(1); y++)
                {
                    matrizResultado[x, y].Text = tempMatrizResultante[x, y].ToString();
                }
            }

        }
        #endregion

        #region ChamaOpostaResultante
        public void OpostaResultante()
        {
            if (matrizResultado == null)
            {
                MessageBox.Show("Matriz nula !", "Error - Matriz");
                return;
            }
            float[,] tempResultante = new float[matrizResultado.GetLength(0), matrizResultado.GetLength(1)];

            for (int x = 0; x < matrizResultado.GetLength(0); x++)
            {
                for (int y = 0; y < matrizResultado.GetLength(1); y++)
                {
                    float n = 0;
                    float.TryParse(matrizResultado[x, y].Text, out n);
                    tempResultante[x, y] = n;
                }
            }

            float[,] tempMatrizResultante = Calculos.GerarOposta(tempResultante);
            int TamanhoText = groupBox3.Width / matrizResultado.GetLength(1);
            for (int x = 0; x < matrizResultado.GetLength(0); x++)
            {
                for (int y = 0; y < matrizResultado.GetLength(1); y++)
                {
                    matrizResultado[x, y].Text = tempMatrizResultante[x, y].ToString();
                }
            }
        }

        #endregion

        #region ChamaInversaResultante
        public void InversaResultante()
        {
            if (matrizResultado == null)
            {
                MessageBox.Show("Matriz nula !", "Error - Matriz");
                return;
            }

            float[,] tempResultante = new float[matrizResultado.GetLength(0), matrizResultado.GetLength(1)];
            float[,] matrizAdjunta = new float[matrizResultado.GetLength(0), matrizResultado.GetLength(1)];
            float[,] matrizCofatora = new float[matrizResultado.GetLength(0), matrizResultado.GetLength(1)];
            float determinante = 0;

            if (tempResultante.GetLength(0) != 2 || tempResultante.GetLength(1) != 2)
            {
                if (tempResultante.GetLength(0) != 3 || tempResultante.GetLength(1) != 3)
                {
                    MessageBox.Show("Matriz invalida !", "Error - Matriz");
                    return;
                }
            }

            for (int x = 0; x < matrizResultado.GetLength(0); x++)
            {
                for (int y = 0; y < matrizResultado.GetLength(1); y++)
                {
                    float n = 0;
                    float.TryParse(matrizResultado[x, y].Text, out n);
                    tempResultante[x, y] = n;
                }
            }

            if (tempResultante.GetLength(0) == 2 && tempResultante.GetLength(1) == 2)
            {
                matrizCofatora = Calculos.GerarCofatora2x2(tempResultante);
                matrizAdjunta = Calculos.GerarTransposta(matrizCofatora);
                determinante = Calculos.GerarDeterminante2x2(tempResultante);
            }
            else if (tempResultante.GetLength(0) == 3 && tempResultante.GetLength(1) == 3)
            {
                matrizCofatora = Calculos.GerarCofatora3x3(tempResultante);
                matrizAdjunta = Calculos.GerarTransposta(matrizCofatora);
                determinante = Calculos.GerarDeterminante3x3(tempResultante);
            }
            else
            {
                MessageBox.Show("Matriz invalida !", "Error - Matriz");
                return;
            }
            if (determinante == 0)
            {
                MessageBox.Show("Matriz invalida, determinante igual a 0 !", "Error - Matriz");
                return;
            }
            float[,] tempMatrizResultante = Calculos.GerarInversa(determinante, matrizAdjunta);
            int TamanhoText = groupBox3.Width / matrizResultado.GetLength(1);
            for (int x = 0; x < matrizResultado.GetLength(0); x++)
            {
                for (int y = 0; y < matrizResultado.GetLength(1); y++)
                {
                    matrizResultado[x, y].Text = tempMatrizResultante[x, y].ToString();
                }
            }
        }
        #endregion

        #region ChamaTranspostaResultante

        public void TranspostaResultante()
        {
            if (matrizResultado == null)
            {
                MessageBox.Show("Matriz nula !", "Error - Matriz");
                return;
            }
            float[,] tempResultante = new float[matrizResultado.GetLength(0), matrizResultado.GetLength(1)];

            for (int x = 0; x < matrizResultado.GetLength(0); x++)
            {
                for (int y = 0; y < matrizResultado.GetLength(1); y++)
                {
                    float n = 0;
                    float.TryParse(matrizResultado[x, y].Text, out n);
                    tempResultante[x, y] = n;
                }
            }

            float[,] tempMatrizResultante = Calculos.GerarTransposta(tempResultante);
            int TamanhoText = groupBox3.Width / matrizResultado.GetLength(1);
            matrizResultado = new TextBox[tempMatrizResultante.GetLength(0), tempMatrizResultante.GetLength(1)];
            groupBox3.Controls.Clear();
            for (int x = 0; x < matrizResultado.GetLength(0); x++)
            {
                for (int y = 0; y < matrizResultado.GetLength(1); y++)
                {
                    matrizResultado[x, y] = new TextBox();
                    matrizResultado[x, y].Text = tempMatrizResultante[x, y].ToString();
                    matrizResultado[x, y].Top = (x * Matriz1[x, y].Height) + 20;
                    matrizResultado[x, y].Left = y * TamanhoText + 6;
                    matrizResultado[x, y].Width = TamanhoText;
                    groupBox3.Controls.Add(matrizResultado[x, y]);
                }
            }
        }

        #endregion

        #region ChamaDeterminateResultante

        public void DeterminanteResultante()
        {
            if (matrizResultado == null)
            {
                MessageBox.Show("Matriz nula !", "Error - Matriz");
                return;
            }
            float[,] tempResultante = new float[matrizResultado.GetLength(0), matrizResultado.GetLength(1)];

            for (int x = 0; x < matrizResultado.GetLength(0); x++)
            {
                for (int y = 0; y < matrizResultado.GetLength(1); y++)
                {
                    float n = 0;
                    float.TryParse(Matriz2[x, y].Text, out n);
                    tempResultante[x, y] = n;
                }
            }
            if (tempResultante.GetLength(0) == 2 && tempResultante.GetLength(1) == 2)
            {
                float determinante = Calculos.GerarDeterminante2x2(tempResultante);
                MessageBox.Show("" + determinante, "Determinante...");
            }
            else if (tempResultante.GetLength(0) == 3 && tempResultante.GetLength(1) == 3)
            {
                float determinante = Calculos.GerarDeterminante3x3(tempResultante);
                MessageBox.Show("" + determinante, "Determinante...");
            }
            else
            {
                MessageBox.Show("Não é possível gerar determinante !", "Error - Matriz invalida ");
            }
        }

        #endregion




        private void Calculadora_Load(object sender, EventArgs e)
        {

        }

      
        internal static void Showmodal()
        {
            throw new NotImplementedException();
        }
  
        private void Sair(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void NLinhas2_Click(object sender, EventArgs e)
        {

        }

        



        



         
       













    }
}