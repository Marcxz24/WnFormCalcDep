namespace WnFormCalcDep
{
    partial class CalcSalarDep
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalcSalarDep));
            lblTitulo = new Label();
            lblInfoSal1 = new Label();
            lblInfoSal2 = new Label();
            lblInfoSal3 = new Label();
            lblInfoSal4 = new Label();
            lblInfo0 = new Label();
            lblInfo5 = new Label();
            lblNomeFunc = new Label();
            grpBoxCalc = new GroupBox();
            btnLimparTela = new Button();
            label3 = new Label();
            txtResultado = new TextBox();
            lblResultado = new Label();
            btnCalcSalario = new Button();
            txtQtnDependentes = new TextBox();
            lblQtnDependentes = new Label();
            txtSalarioFunc = new TextBox();
            lblSalarioFunc = new Label();
            txtNomeFunc = new TextBox();
            grpBoxCalc.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(26, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(696, 33);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Calculadora de Salário com Base em Dependentes";
            // 
            // lblInfoSal1
            // 
            lblInfoSal1.AutoSize = true;
            lblInfoSal1.Location = new Point(26, 102);
            lblInfoSal1.Name = "lblInfoSal1";
            lblInfoSal1.Size = new Size(463, 40);
            lblInfoSal1.TabIndex = 1;
            lblInfoSal1.Text = "Se possuir 1 Dependente, calcula o valor de 10% em cima do Salário\r\n\r\n";
            // 
            // lblInfoSal2
            // 
            lblInfoSal2.AutoSize = true;
            lblInfoSal2.Location = new Point(26, 132);
            lblInfoSal2.Name = "lblInfoSal2";
            lblInfoSal2.Size = new Size(469, 20);
            lblInfoSal2.TabIndex = 2;
            lblInfoSal2.Text = "Se possuir 2 Dependentes, calcula o valor de 20% em cima do Salário\r\n";
            // 
            // lblInfoSal3
            // 
            lblInfoSal3.AutoSize = true;
            lblInfoSal3.Location = new Point(26, 164);
            lblInfoSal3.Name = "lblInfoSal3";
            lblInfoSal3.Size = new Size(469, 20);
            lblInfoSal3.TabIndex = 3;
            lblInfoSal3.Text = "Se possuir 3 Dependentes, calcula o valor de 30% em cima do Salário\r\n";
            // 
            // lblInfoSal4
            // 
            lblInfoSal4.AutoSize = true;
            lblInfoSal4.Location = new Point(26, 193);
            lblInfoSal4.Name = "lblInfoSal4";
            lblInfoSal4.Size = new Size(469, 40);
            lblInfoSal4.TabIndex = 4;
            lblInfoSal4.Text = "Se possuir 4 Dependentes, calcula o valor de 40% em cima do Salário\r\n\r\n";
            // 
            // lblInfo0
            // 
            lblInfo0.AutoSize = true;
            lblInfo0.Location = new Point(26, 73);
            lblInfo0.Name = "lblInfo0";
            lblInfo0.Size = new Size(429, 20);
            lblInfo0.TabIndex = 5;
            lblInfo0.Text = "Se não possuir nenhum dependente, não irá aumentar o Salário";
            // 
            // lblInfo5
            // 
            lblInfo5.AutoSize = true;
            lblInfo5.Location = new Point(26, 222);
            lblInfo5.Name = "lblInfo5";
            lblInfo5.Size = new Size(525, 40);
            lblInfo5.TabIndex = 6;
            lblInfo5.Text = "Se possuir 5 Dependentes ou mais, calcula o valor de 50% em cima do Salário\r\n\r\n";
            // 
            // lblNomeFunc
            // 
            lblNomeFunc.AutoSize = true;
            lblNomeFunc.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNomeFunc.Location = new Point(19, 55);
            lblNomeFunc.Name = "lblNomeFunc";
            lblNomeFunc.Size = new Size(222, 18);
            lblNomeFunc.TabIndex = 7;
            lblNomeFunc.Text = "Digite o Nome do Funcionário:";
            // 
            // grpBoxCalc
            // 
            grpBoxCalc.Controls.Add(btnLimparTela);
            grpBoxCalc.Controls.Add(label3);
            grpBoxCalc.Controls.Add(txtResultado);
            grpBoxCalc.Controls.Add(lblResultado);
            grpBoxCalc.Controls.Add(btnCalcSalario);
            grpBoxCalc.Controls.Add(txtQtnDependentes);
            grpBoxCalc.Controls.Add(lblQtnDependentes);
            grpBoxCalc.Controls.Add(txtSalarioFunc);
            grpBoxCalc.Controls.Add(lblSalarioFunc);
            grpBoxCalc.Controls.Add(txtNomeFunc);
            grpBoxCalc.Controls.Add(lblNomeFunc);
            grpBoxCalc.Location = new Point(1, 288);
            grpBoxCalc.Name = "grpBoxCalc";
            grpBoxCalc.Size = new Size(757, 389);
            grpBoxCalc.TabIndex = 8;
            grpBoxCalc.TabStop = false;
            // 
            // btnLimparTela
            // 
            btnLimparTela.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimparTela.Location = new Point(180, 325);
            btnLimparTela.Name = "btnLimparTela";
            btnLimparTela.Size = new Size(348, 50);
            btnLimparTela.TabIndex = 16;
            btnLimparTela.Text = "Limpar Tela";
            btnLimparTela.UseVisualStyleBackColor = true;
            btnLimparTela.Click += btnLimparTela_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(267, 0);
            label3.Name = "label3";
            label3.Size = new Size(158, 24);
            label3.TabIndex = 9;
            label3.Text = "Calcular Salário";
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(109, 284);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(582, 27);
            txtResultado.TabIndex = 15;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResultado.Location = new Point(19, 289);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(84, 18);
            lblResultado.TabIndex = 14;
            lblResultado.Text = "Resultado:";
            // 
            // btnCalcSalario
            // 
            btnCalcSalario.Font = new Font("Arial", 9F, FontStyle.Bold);
            btnCalcSalario.Location = new Point(180, 210);
            btnCalcSalario.Name = "btnCalcSalario";
            btnCalcSalario.Size = new Size(348, 50);
            btnCalcSalario.TabIndex = 13;
            btnCalcSalario.Text = "Calcular Novo Salário";
            btnCalcSalario.UseVisualStyleBackColor = true;
            btnCalcSalario.Click += btnCalcSalario_Click;
            // 
            // txtQtnDependentes
            // 
            txtQtnDependentes.Location = new Point(407, 165);
            txtQtnDependentes.Name = "txtQtnDependentes";
            txtQtnDependentes.Size = new Size(284, 27);
            txtQtnDependentes.TabIndex = 12;
            // 
            // lblQtnDependentes
            // 
            lblQtnDependentes.AutoSize = true;
            lblQtnDependentes.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQtnDependentes.Location = new Point(19, 170);
            lblQtnDependentes.Name = "lblQtnDependentes";
            lblQtnDependentes.Size = new Size(382, 18);
            lblQtnDependentes.TabIndex = 11;
            lblQtnDependentes.Text = "Digite a Quantidade de dependentes do Funcionário:";
            // 
            // txtSalarioFunc
            // 
            txtSalarioFunc.Location = new Point(250, 110);
            txtSalarioFunc.Name = "txtSalarioFunc";
            txtSalarioFunc.Size = new Size(441, 27);
            txtSalarioFunc.TabIndex = 10;
            // 
            // lblSalarioFunc
            // 
            lblSalarioFunc.AutoSize = true;
            lblSalarioFunc.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSalarioFunc.Location = new Point(19, 115);
            lblSalarioFunc.Name = "lblSalarioFunc";
            lblSalarioFunc.Size = new Size(230, 18);
            lblSalarioFunc.TabIndex = 9;
            lblSalarioFunc.Text = "Digite o Salário do Funcionário:";
            // 
            // txtNomeFunc
            // 
            txtNomeFunc.Location = new Point(250, 50);
            txtNomeFunc.Name = "txtNomeFunc";
            txtNomeFunc.Size = new Size(441, 27);
            txtNomeFunc.TabIndex = 8;
            // 
            // CalcSalarDep
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(755, 701);
            Controls.Add(grpBoxCalc);
            Controls.Add(lblInfo5);
            Controls.Add(lblInfo0);
            Controls.Add(lblInfoSal4);
            Controls.Add(lblInfoSal3);
            Controls.Add(lblInfoSal2);
            Controls.Add(lblInfoSal1);
            Controls.Add(lblTitulo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CalcSalarDep";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora de Salário com Base em Dependentes";
            grpBoxCalc.ResumeLayout(false);
            grpBoxCalc.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblInfoSal1;
        private Label lblInfoSal2;
        private Label lblInfoSal3;
        private Label lblInfoSal4;
        private Label lblInfo0;
        private Label lblInfo5;
        private Label lblNomeFunc;
        private GroupBox grpBoxCalc;
        private Button btnCalcSalario;
        private TextBox txtQtnDependentes;
        private Label lblQtnDependentes;
        private TextBox txtSalarioFunc;
        private Label lblSalarioFunc;
        private TextBox txtNomeFunc;
        private TextBox txtResultado;
        private Label lblResultado;
        private Label label3;
        private Button btnLimparTela;
    }
}
