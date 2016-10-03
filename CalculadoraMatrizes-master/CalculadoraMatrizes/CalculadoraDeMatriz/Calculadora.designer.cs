namespace CalculadoraDeMatriz
{
    partial class Calculadora
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculadora));
            this.Plano = new System.Windows.Forms.TabControl();
            this.NLinhas2 = new System.Windows.Forms.TabPage();
            this.Colunas1 = new System.Windows.Forms.NumericUpDown();
            this.Nucolunas2 = new System.Windows.Forms.Label();
            this.Linhas2 = new System.Windows.Forms.NumericUpDown();
            this.Nulinhas2 = new System.Windows.Forms.Label();
            this.NColunas1 = new System.Windows.Forms.Label();
            this.NLinhas1 = new System.Windows.Forms.Label();
            this.Colunas2 = new System.Windows.Forms.NumericUpDown();
            this.Linhas1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.MatrizResultante = new System.Windows.Forms.GroupBox();
            this.Matriz2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LimparResult = new System.Windows.Forms.Button();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.BotaoSubtrair = new System.Windows.Forms.Button();
            this.LimparB = new System.Windows.Forms.Button();
            this.BotaoAlternar = new System.Windows.Forms.Button();
            this.BotaoSoma = new System.Windows.Forms.Button();
            this.BotaoMultipicacao = new System.Windows.Forms.Button();
            this.LimpaB = new System.Windows.Forms.Button();
            this.LimparA = new System.Windows.Forms.Button();
            this.PlanoCartesiano = new System.Windows.Forms.TabPage();
            this.LeideForma = new System.Windows.Forms.Label();
            this.LeideFor = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Gerar = new System.Windows.Forms.Button();
            this.Gerar2 = new System.Windows.Forms.Button();
            this.Plano.SuspendLayout();
            this.NLinhas2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Colunas1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Linhas2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Colunas2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Linhas1)).BeginInit();
            this.SuspendLayout();
            // 
            // Plano
            // 
            this.Plano.Controls.Add(this.NLinhas2);
            this.Plano.Controls.Add(this.PlanoCartesiano);
            this.Plano.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Plano.Location = new System.Drawing.Point(0, 4);
            this.Plano.Name = "Plano";
            this.Plano.SelectedIndex = 0;
            this.Plano.Size = new System.Drawing.Size(1427, 678);
            this.Plano.TabIndex = 18;
            // 
            // NLinhas2
            // 
            this.NLinhas2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.NLinhas2.Controls.Add(this.Gerar2);
            this.NLinhas2.Controls.Add(this.Gerar);
            this.NLinhas2.Controls.Add(this.textBox1);
            this.NLinhas2.Controls.Add(this.label2);
            this.NLinhas2.Controls.Add(this.LeideFor);
            this.NLinhas2.Controls.Add(this.LeideForma);
            this.NLinhas2.Controls.Add(this.Colunas1);
            this.NLinhas2.Controls.Add(this.Nucolunas2);
            this.NLinhas2.Controls.Add(this.Linhas2);
            this.NLinhas2.Controls.Add(this.Nulinhas2);
            this.NLinhas2.Controls.Add(this.NColunas1);
            this.NLinhas2.Controls.Add(this.NLinhas1);
            this.NLinhas2.Controls.Add(this.Colunas2);
            this.NLinhas2.Controls.Add(this.Linhas1);
            this.NLinhas2.Controls.Add(this.label1);
            this.NLinhas2.Controls.Add(this.MatrizResultante);
            this.NLinhas2.Controls.Add(this.Matriz2);
            this.NLinhas2.Controls.Add(this.groupBox1);
            this.NLinhas2.Controls.Add(this.LimparResult);
            this.NLinhas2.Controls.Add(this.comboBox3);
            this.NLinhas2.Controls.Add(this.comboBox2);
            this.NLinhas2.Controls.Add(this.comboBox1);
            this.NLinhas2.Controls.Add(this.BotaoSubtrair);
            this.NLinhas2.Controls.Add(this.LimparB);
            this.NLinhas2.Controls.Add(this.BotaoAlternar);
            this.NLinhas2.Controls.Add(this.BotaoSoma);
            this.NLinhas2.Controls.Add(this.BotaoMultipicacao);
            this.NLinhas2.Controls.Add(this.LimpaB);
            this.NLinhas2.Controls.Add(this.LimparA);
            this.NLinhas2.ForeColor = System.Drawing.Color.Teal;
            this.NLinhas2.Location = new System.Drawing.Point(4, 25);
            this.NLinhas2.Name = "NLinhas2";
            this.NLinhas2.Padding = new System.Windows.Forms.Padding(3);
            this.NLinhas2.Size = new System.Drawing.Size(1419, 649);
            this.NLinhas2.TabIndex = 0;
            this.NLinhas2.Text = "Operações";
            this.NLinhas2.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // Colunas1
            // 
            this.Colunas1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.Colunas1.ForeColor = System.Drawing.Color.Teal;
            this.Colunas1.Location = new System.Drawing.Point(163, 68);
            this.Colunas1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.Colunas1.Name = "Colunas1";
            this.Colunas1.Size = new System.Drawing.Size(120, 24);
            this.Colunas1.TabIndex = 42;
            // 
            // Nucolunas2
            // 
            this.Nucolunas2.AutoSize = true;
            this.Nucolunas2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nucolunas2.ForeColor = System.Drawing.Color.Teal;
            this.Nucolunas2.Location = new System.Drawing.Point(562, 65);
            this.Nucolunas2.Name = "Nucolunas2";
            this.Nucolunas2.Size = new System.Drawing.Size(72, 23);
            this.Nucolunas2.TabIndex = 41;
            this.Nucolunas2.Text = "Colunas:";
            // 
            // Linhas2
            // 
            this.Linhas2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.Linhas2.ForeColor = System.Drawing.Color.Teal;
            this.Linhas2.Location = new System.Drawing.Point(655, 29);
            this.Linhas2.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.Linhas2.Name = "Linhas2";
            this.Linhas2.Size = new System.Drawing.Size(120, 24);
            this.Linhas2.TabIndex = 40;
            // 
            // Nulinhas2
            // 
            this.Nulinhas2.AutoSize = true;
            this.Nulinhas2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nulinhas2.ForeColor = System.Drawing.Color.Teal;
            this.Nulinhas2.Location = new System.Drawing.Point(570, 29);
            this.Nulinhas2.Name = "Nulinhas2";
            this.Nulinhas2.Size = new System.Drawing.Size(64, 23);
            this.Nulinhas2.TabIndex = 39;
            this.Nulinhas2.Text = "Linhas:";
            // 
            // NColunas1
            // 
            this.NColunas1.AutoSize = true;
            this.NColunas1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NColunas1.ForeColor = System.Drawing.Color.Teal;
            this.NColunas1.Location = new System.Drawing.Point(56, 65);
            this.NColunas1.Name = "NColunas1";
            this.NColunas1.Size = new System.Drawing.Size(72, 23);
            this.NColunas1.TabIndex = 38;
            this.NColunas1.Text = "Colunas:";
            // 
            // NLinhas1
            // 
            this.NLinhas1.AutoSize = true;
            this.NLinhas1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NLinhas1.ForeColor = System.Drawing.Color.Teal;
            this.NLinhas1.Location = new System.Drawing.Point(60, 29);
            this.NLinhas1.Name = "NLinhas1";
            this.NLinhas1.Size = new System.Drawing.Size(64, 23);
            this.NLinhas1.TabIndex = 37;
            this.NLinhas1.Text = "Linhas:";
            // 
            // Colunas2
            // 
            this.Colunas2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.Colunas2.ForeColor = System.Drawing.Color.Teal;
            this.Colunas2.Location = new System.Drawing.Point(655, 68);
            this.Colunas2.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.Colunas2.Name = "Colunas2";
            this.Colunas2.Size = new System.Drawing.Size(120, 24);
            this.Colunas2.TabIndex = 36;
            // 
            // Linhas1
            // 
            this.Linhas1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.Linhas1.ForeColor = System.Drawing.Color.Teal;
            this.Linhas1.Location = new System.Drawing.Point(163, 29);
            this.Linhas1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.Linhas1.Name = "Linhas1";
            this.Linhas1.Size = new System.Drawing.Size(120, 24);
            this.Linhas1.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(878, 304);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "==";
            // 
            // MatrizResultante
            // 
            this.MatrizResultante.ForeColor = System.Drawing.Color.Teal;
            this.MatrizResultante.Location = new System.Drawing.Point(926, 142);
            this.MatrizResultante.Name = "MatrizResultante";
            this.MatrizResultante.Size = new System.Drawing.Size(341, 329);
            this.MatrizResultante.TabIndex = 34;
            this.MatrizResultante.TabStop = false;
            this.MatrizResultante.Text = "MatrizResultante";
            this.MatrizResultante.UseCompatibleTextRendering = true;
            // 
            // Matriz2
            // 
            this.Matriz2.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Matriz2.ForeColor = System.Drawing.Color.Teal;
            this.Matriz2.Location = new System.Drawing.Point(510, 142);
            this.Matriz2.Name = "Matriz2";
            this.Matriz2.Size = new System.Drawing.Size(342, 329);
            this.Matriz2.TabIndex = 33;
            this.Matriz2.TabStop = false;
            this.Matriz2.Text = "Matriz2";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.groupBox1.ForeColor = System.Drawing.Color.Teal;
            this.groupBox1.Location = new System.Drawing.Point(17, 140);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(342, 322);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Matriz 1";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // LimparResult
            // 
            this.LimparResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.LimparResult.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LimparResult.ForeColor = System.Drawing.Color.Teal;
            this.LimparResult.Location = new System.Drawing.Point(1126, 501);
            this.LimparResult.Name = "LimparResult";
            this.LimparResult.Size = new System.Drawing.Size(112, 25);
            this.LimparResult.TabIndex = 31;
            this.LimparResult.Text = "Limpar";
            this.LimparResult.UseVisualStyleBackColor = false;
            // 
            // comboBox3
            // 
            this.comboBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.comboBox3.ForeColor = System.Drawing.Color.Teal;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Oposta",
            "Inversa",
            "Transposta",
            "Simétrica",
            "Determinante"});
            this.comboBox3.Location = new System.Drawing.Point(981, 503);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 24);
            this.comboBox3.TabIndex = 30;
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.comboBox2.ForeColor = System.Drawing.Color.Teal;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Oposta",
            "Inversa",
            "Transposta",
            "Simétrica",
            "Determinante"});
            this.comboBox2.Location = new System.Drawing.Point(555, 502);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 24);
            this.comboBox2.TabIndex = 29;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.comboBox1.ForeColor = System.Drawing.Color.Teal;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Oposta",
            "Inversa",
            "Transposta",
            "Simétrica",
            "Determinante"});
            this.comboBox1.Location = new System.Drawing.Point(57, 503);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 28;
            // 
            // BotaoSubtrair
            // 
            this.BotaoSubtrair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.BotaoSubtrair.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotaoSubtrair.ForeColor = System.Drawing.Color.Teal;
            this.BotaoSubtrair.Location = new System.Drawing.Point(378, 271);
            this.BotaoSubtrair.Name = "BotaoSubtrair";
            this.BotaoSubtrair.Size = new System.Drawing.Size(114, 28);
            this.BotaoSubtrair.TabIndex = 27;
            this.BotaoSubtrair.Text = "A - B";
            this.BotaoSubtrair.UseVisualStyleBackColor = false;
            // 
            // LimparB
            // 
            this.LimparB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.LimparB.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LimparB.ForeColor = System.Drawing.Color.Teal;
            this.LimparB.Location = new System.Drawing.Point(704, 501);
            this.LimparB.Name = "LimparB";
            this.LimparB.Size = new System.Drawing.Size(112, 25);
            this.LimparB.TabIndex = 26;
            this.LimparB.Text = "Limpar";
            this.LimparB.UseVisualStyleBackColor = false;
            // 
            // BotaoAlternar
            // 
            this.BotaoAlternar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.BotaoAlternar.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotaoAlternar.ForeColor = System.Drawing.Color.Teal;
            this.BotaoAlternar.Location = new System.Drawing.Point(378, 335);
            this.BotaoAlternar.Name = "BotaoAlternar";
            this.BotaoAlternar.Size = new System.Drawing.Size(114, 28);
            this.BotaoAlternar.TabIndex = 25;
            this.BotaoAlternar.Text = "Alternar";
            this.BotaoAlternar.UseVisualStyleBackColor = false;
            // 
            // BotaoSoma
            // 
            this.BotaoSoma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.BotaoSoma.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotaoSoma.ForeColor = System.Drawing.Color.Teal;
            this.BotaoSoma.Location = new System.Drawing.Point(378, 303);
            this.BotaoSoma.Name = "BotaoSoma";
            this.BotaoSoma.Size = new System.Drawing.Size(114, 28);
            this.BotaoSoma.TabIndex = 24;
            this.BotaoSoma.Text = "A + B";
            this.BotaoSoma.UseVisualStyleBackColor = false;
            // 
            // BotaoMultipicacao
            // 
            this.BotaoMultipicacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.BotaoMultipicacao.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotaoMultipicacao.ForeColor = System.Drawing.Color.Teal;
            this.BotaoMultipicacao.Location = new System.Drawing.Point(378, 237);
            this.BotaoMultipicacao.Name = "BotaoMultipicacao";
            this.BotaoMultipicacao.Size = new System.Drawing.Size(114, 28);
            this.BotaoMultipicacao.TabIndex = 23;
            this.BotaoMultipicacao.Text = "A * B";
            this.BotaoMultipicacao.UseVisualStyleBackColor = false;
            // 
            // LimpaB
            // 
            this.LimpaB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.LimpaB.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LimpaB.ForeColor = System.Drawing.Color.Teal;
            this.LimpaB.Location = new System.Drawing.Point(203, 501);
            this.LimpaB.Name = "LimpaB";
            this.LimpaB.Size = new System.Drawing.Size(114, 27);
            this.LimpaB.TabIndex = 9;
            this.LimpaB.Text = "Limpar";
            this.LimpaB.UseVisualStyleBackColor = false;
            // 
            // LimparA
            // 
            this.LimparA.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LimparA.BackgroundImage")));
            this.LimparA.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LimparA.ForeColor = System.Drawing.Color.Teal;
            this.LimparA.Location = new System.Drawing.Point(1622, 424);
            this.LimparA.Name = "LimparA";
            this.LimparA.Size = new System.Drawing.Size(129, 39);
            this.LimparA.TabIndex = 8;
            this.LimparA.Text = "Limpar";
            this.LimparA.UseVisualStyleBackColor = true;
            // 
            // PlanoCartesiano
            // 
            this.PlanoCartesiano.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.PlanoCartesiano.Location = new System.Drawing.Point(4, 25);
            this.PlanoCartesiano.Name = "PlanoCartesiano";
            this.PlanoCartesiano.Padding = new System.Windows.Forms.Padding(3);
            this.PlanoCartesiano.Size = new System.Drawing.Size(1419, 649);
            this.PlanoCartesiano.TabIndex = 1;
            this.PlanoCartesiano.Text = "Plano Cartesiano";
            // 
            // LeideForma
            // 
            this.LeideForma.AutoSize = true;
            this.LeideForma.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeideForma.ForeColor = System.Drawing.Color.Teal;
            this.LeideForma.Location = new System.Drawing.Point(16, 103);
            this.LeideForma.Name = "LeideForma";
            this.LeideForma.Size = new System.Drawing.Size(138, 23);
            this.LeideForma.TabIndex = 43;
            this.LeideForma.Text = "lei de Formação:";
            this.LeideForma.Click += new System.EventHandler(this.LeideForma_Click);
            // 
            // LeideFor
            // 
            this.LeideFor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.LeideFor.ForeColor = System.Drawing.Color.Teal;
            this.LeideFor.Location = new System.Drawing.Point(161, 105);
            this.LeideFor.Name = "LeideFor";
            this.LeideFor.Size = new System.Drawing.Size(122, 24);
            this.LeideFor.TabIndex = 44;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.textBox1.ForeColor = System.Drawing.Color.Teal;
            this.textBox1.Location = new System.Drawing.Point(655, 105);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(122, 24);
            this.textBox1.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(510, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 23);
            this.label2.TabIndex = 45;
            this.label2.Text = "lei de Formação:";
            // 
            // Gerar
            // 
            this.Gerar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.Gerar.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gerar.ForeColor = System.Drawing.Color.Teal;
            this.Gerar.Location = new System.Drawing.Point(295, 103);
            this.Gerar.Name = "Gerar";
            this.Gerar.Size = new System.Drawing.Size(114, 28);
            this.Gerar.TabIndex = 47;
            this.Gerar.Text = "Gerar";
            this.Gerar.UseVisualStyleBackColor = false;
            this.Gerar.Click += new System.EventHandler(this.Gerar_Click);
            // 
            // Gerar2
            // 
            this.Gerar2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.Gerar2.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gerar2.ForeColor = System.Drawing.Color.Teal;
            this.Gerar2.Location = new System.Drawing.Point(796, 103);
            this.Gerar2.Name = "Gerar2";
            this.Gerar2.Size = new System.Drawing.Size(114, 28);
            this.Gerar2.TabIndex = 48;
            this.Gerar2.Text = "Gerar";
            this.Gerar2.UseVisualStyleBackColor = false;
            // 
            // Calculadora
            // 
            this.AccessibleName = "Calculadora";
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1299, 650);
            this.Controls.Add(this.Plano);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Calculadora";
            this.Text = "Calculadora de Matrizes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Sair);
            this.Load += new System.EventHandler(this.Calculadora_Load);
            this.Plano.ResumeLayout(false);
            this.NLinhas2.ResumeLayout(false);
            this.NLinhas2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Colunas1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Linhas2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Colunas2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Linhas1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Plano;
        private System.Windows.Forms.TabPage PlanoCartesiano;
        private System.Windows.Forms.TabPage NLinhas2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button BotaoSubtrair;
        private System.Windows.Forms.Button LimparB;
        private System.Windows.Forms.Button BotaoAlternar;
        private System.Windows.Forms.Button BotaoSoma;
        private System.Windows.Forms.Button BotaoMultipicacao;
        private System.Windows.Forms.Button LimpaB;
        private System.Windows.Forms.Button LimparA;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button LimparResult;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label NColunas1;
        private System.Windows.Forms.Label NLinhas1;
        private System.Windows.Forms.NumericUpDown Colunas2;
        private System.Windows.Forms.NumericUpDown Linhas1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox MatrizResultante;
        private System.Windows.Forms.GroupBox Matriz2;
        private System.Windows.Forms.Label Nulinhas2;
        private System.Windows.Forms.NumericUpDown Linhas2;
        private System.Windows.Forms.Label Nucolunas2;
        private System.Windows.Forms.NumericUpDown Colunas1;
        private System.Windows.Forms.Label LeideForma;
        private System.Windows.Forms.TextBox LeideFor;
        private System.Windows.Forms.Button Gerar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Gerar2;
    }
}