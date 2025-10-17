namespace WnFormCalcDep
{
    public partial class CalcSalarDep : Form
    {
        public CalcSalarDep()
        {
            InitializeComponent();
        }

        private void btnCalcSalario_Click(object sender, EventArgs e)
        {
            // o salário que será mostrado
            double novoSalario = 0;
            
            // Nome do funcionário
            string nomeFunc = txtNomeFunc.Text;

            // o salario que será digitado no textBox
            string salarioDigitado = txtSalarioFunc.Text;

            // varivael booleana para realizar a validação do TryParse, para aceitar apenas números
            bool validarSalario = false;

            // valor do salario
            double salario = 0;

            // loop, que irá repetir enquanto não tiver um valor valido no campo que será informado o salario
            while (!validarSalario)
            {
                // conversão do salario de string para double
                if (double.TryParse(salarioDigitado, out salario))
                {
                    validarSalario = true;
                }
                else
                {
                    MessageBox.Show("Valor Inválido, Digite Apenas Números!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            // dependentes digitados no campo txt de dependentes
            string dependentesDigitados = txtQtnDependentes.Text;

            // varivael booleana para realizar a validação do TryParse, para aceitar apenas números
            bool validarDependentes = false;

            // variavel que irá armazenar a quantidade de dependentes
            double dependentes = 0;

            // loop, que irá repetir enquanto não tiver um valor valido no campo que será informado a quantidade de dependentes
            while (!validarDependentes)
            {
                // conversão de dependentes string para double
                if (double.TryParse(dependentesDigitados, out dependentes))
                {
                    validarDependentes = true;
                }
                else
                {
                    MessageBox.Show("Valor Inválido, Digite Apenas Números!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }


            // valor de 10%
            double mediaSalarial1 = salario + (salario * 10 / 100);

            // valor de 20%
            double mediaSalarial2 = salario + (salario * 20 / 100);

            // valor de 30%
            double mediaSalarial3 = salario + (salario * 30 / 100);

            // valor de 40%
            double mediaSalarial4 = salario + (salario * 40 / 100);

            // valor de 50%
            double mediaSalarial5 = salario + (salario * 50 / 100);

            // switch, que irá calcular de acordo com a quantidade de dependentes
            switch (dependentes)
            {
                // caso 0 dependentes, não será calculado
                case 0:
                    novoSalario = salario;
                    txtResultado.Text = $"  Olá Sr(a).{nomeFunc}, o seu salário é {salario:c}";
                    break;

                // caso 1 depdente, será calculado  10%
                case 1:
                    novoSalario = mediaSalarial1;
                    txtResultado.Text = $"Olá Sr(a).{nomeFunc}, o seu novo salário é de {novoSalario:c}";
                    break;

                // caso 2 dependentes, será calculado 20%
                case 2:
                    novoSalario = mediaSalarial2;
                    txtResultado.Text = $"Olá Sr(a).{nomeFunc}, o seu novo salário é de {novoSalario:c}";
                    break;

                // caso 3 dependentes, será calculado 30%
                case 3:
                    novoSalario = mediaSalarial3;
                    txtResultado.Text = $"Olá Sr(a).{nomeFunc}, o seu novo salário é de {novoSalario:c}";
                    break;

                // caso 4 dependetes, será calculado 40%
                case 4:
                    novoSalario = mediaSalarial4;
                    txtResultado.Text = $"Olá Sr(a).{nomeFunc}, o seu novo salário é de {novoSalario:c}";
                    break;

                // caso 5 dependentes ou mais, será calculado 50% valor final.
                default:
                    novoSalario = mediaSalarial5;
                    txtResultado.Text = $"Olá Sr(a).{nomeFunc}, o seu novo salário é de {novoSalario:c}";
                    break;
            }
        }

        // evento para limpar a tela
        private void btnLimparTela_Click(object sender, EventArgs e)
        {
            txtNomeFunc.Text = "";

            txtQtnDependentes.Text = "";

            txtResultado.Text = "";

            txtSalarioFunc.Text = "";
        }
    }
}
