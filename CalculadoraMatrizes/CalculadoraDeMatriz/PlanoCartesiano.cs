using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraDeMatriz
{
   static class PlanoCartesiano
   {
        #region Simetria
       public static float[,] SimetriaX = new float[2, 2] { { 1, 0 }, { 0, -1 } };
        public static float[,] SimetriaY = new float[2, 2] { { -1, 0 }, { 0, 1 } };
        #endregion 

        #region Desenhar No Plano
        /// <summary>
        /// Função para desenhar no plano cartesiano
        /// </summary>
        /// <param name="chart">Plano cartesiano em que a forma será desenhada</param>
        /// <param name="matriz">Matriz com as posições para se desenhar no plano cartesiano</param>
        /// <param name="series">Series do chart que se desenha</param>
        public static void DrawInChart(System.Windows.Forms.DataVisualization.Charting.Chart chart, float[,] matriz, string series)
        {
            if (matriz.Length < 6)
            {
                throw new NoMatrixException();
            }
            // para redimensionar o plano
            float high = 0;
            if (high < 10)
            {

                chart.ChartAreas[0].AxisX.Minimum = -10;
                chart.ChartAreas[0].AxisX.Maximum = 10;
                chart.ChartAreas[0].AxisY.Minimum = -10;
                chart.ChartAreas[0].AxisY.Maximum = 10;
                chart.ChartAreas[0].AxisX2.Minimum = -10;
                chart.ChartAreas[0].AxisX2.Maximum = 10;
                chart.ChartAreas[0].AxisY2.Minimum = -10;
                chart.ChartAreas[0].AxisY2.Maximum = 10;
                chart.Series["Eixos"].Points[0].SetValueXY(-10, 0);
                chart.Series["Eixos"].Points[1].SetValueXY(10, 0);
                chart.Series["Eixos"].Points[2].SetValueXY(0, 0);
                chart.Series["Eixos"].Points[3].SetValueXY(0, -10);
                chart.Series["Eixos"].Points[4].SetValueXY(0, 10);
            }
            else if (high > 50)
            {
                chart.ChartAreas[0].AxisX.Minimum = -Math.Round(high * 1.1f);
                chart.ChartAreas[0].AxisX.Maximum = Math.Round(high * 1.1f);
                chart.ChartAreas[0].AxisY.Minimum = -Math.Round(high * 1.1f);
                chart.ChartAreas[0].AxisY.Maximum = Math.Round(high * 1.1f);
                chart.ChartAreas[0].AxisX2.Minimum = -Math.Round(high * 1.1f);
                chart.ChartAreas[0].AxisX2.Maximum = Math.Round(high * 1.1f);
                chart.ChartAreas[0].AxisY2.Minimum = -Math.Round(high * 1.1f);
                chart.ChartAreas[0].AxisY2.Maximum = Math.Round(high * 1.1f);
                chart.Series["Eixos"].Points[0].SetValueXY(-Math.Round(high * 1.1f), 0);
                chart.Series["Eixos"].Points[1].SetValueXY(Math.Round(high * 1.1f), 0);
                chart.Series["Eixos"].Points[2].SetValueXY(0, 0);
                chart.Series["Eixos"].Points[3].SetValueXY(0, -Math.Round(high * 1.1f));
                chart.Series["Eixos"].Points[4].SetValueXY(0, Math.Round(high * 1.1f));
            }
            else
            {
                chart.ChartAreas[0].AxisX.Minimum = -50;
                chart.ChartAreas[0].AxisX.Maximum = 50;
                chart.ChartAreas[0].AxisY.Minimum = -50;
                chart.ChartAreas[0].AxisY.Maximum = 50;
                chart.ChartAreas[0].AxisX2.Minimum = -50;
                chart.ChartAreas[0].AxisX2.Maximum = 50;
                chart.ChartAreas[0].AxisY2.Minimum = -50;
                chart.ChartAreas[0].AxisY2.Maximum = 50;
                chart.Series["Eixos"].Points[0].SetValueXY(-50, 0);
                chart.Series["Eixos"].Points[1].SetValueXY(50, 0);
                chart.Series["Eixos"].Points[2].SetValueXY(0, 0);
                chart.Series["Eixos"].Points[3].SetValueXY(0, -50);
                chart.Series["Eixos"].Points[4].SetValueXY(0, 50);
            }
            chart.Series[series].Points.Clear();
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                chart.Series[series].Points.AddXY(matriz[0, j], matriz[1, j]);
            }
            chart.Series[series].Points.AddXY(matriz[0, 0], matriz[1, 0]);

        }
        #endregion

        #region Rotaçao
        /// <summary>
        /// Função para rotacionar uma forma a um angulo
        /// </summary>
        /// <param name="angulo">Angulo para se rotacionar a formula</param>
        /// <returns>A matriz com as posições da forma rotacionada</returns>
        public static float[,] Rotaçao(float angulo)
        {
            double angle = DegreeToRadian(angulo);
            float[,] result = new float[2, 2] { { (float)Math.Cos(angle), (float)Math.Sin(angle) }, { (float)-Math.Sin(angle), (float)Math.Cos(angle) } };

            return result;
        }
        #endregion

        #region Escalar
        /// <summary>
        /// Função para aumentar a forma a um numero
        /// </summary>
        /// <param name="value">Número pelo qual a forma aumentará</param>
        /// <returns>Retorna uma matriz com as posições da forma aumentada</returns>
        public static float[,] Escalar(float value)
        {
            float[,] result = new float[2, 2] { { value, 0 }, { 0, value } };
            return result;
        }
        #endregion

        #region Somar para translação
        public static float[,] SomarMatriz(float[,] matriz, float valorx, float valory)
        {
            float[,] matrixfinal = matriz;
            int lin = matriz.GetLength(0);
            int col = matriz.GetLength(1);
            for (int j = 0; j < col; j++)
            {
                matrixfinal[0, j] += valorx;
                matrixfinal[1, j] += valory;
            }
            return matrixfinal;
        }
        #endregion

        #region Graus para Radianos
        static double DegreeToRadian(float angle)
        {
            return (Math.PI * angle) / 180;
        }
        #endregion
        class NoMatrixException : Exception
        {
        }
    }
}
