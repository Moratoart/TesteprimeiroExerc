using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ExercDochefe2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            Console.WriteLine("Digite o valor de A");
            int A = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Digite o valor de B");
            int B = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Digite o valor de C");
            int C = Convert.ToInt32(Console.ReadLine());

            int soma = A + B;
            Console.WriteLine("A soma de A+B é =  " + soma);

            if (soma < C)

            {
                Console.WriteLine("A soma de A+B é menor que C");
            }
            else
            {
                Console.WriteLine("A soma de A+B é maior que C");




            }

            //2
            Console.WriteLine("Forneça um numero qualquer");
            int numero = int.Parse(Console.ReadLine());
            if (numero % 2 == 0)
            {
                Console.WriteLine("O número é par");
            }
            else
            {
                Console.WriteLine("O número não é par");
            }
            if (numero > 0)
            {
                Console.WriteLine("O " + numero + " é positivo");
            }
            else if (numero < 0)
            {
                Console.WriteLine("O " + numero + " é negativo");
            }
            else 
            {
                Console.WriteLine("O " + numero + " é Zero");

            }


            //3
            Console.WriteLine("Digite o valor de A");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor de B");
            int b = int.Parse(Console.ReadLine());
            int c = 1;

            if (a == b)
            {
                c = a + b;
            }
            else
            {
                c = a * b;
            }

            Console.WriteLine("O valor de C é " + c);

            //4
            Console.WriteLine("Digite um numero inteiro");
            int numerow = int.Parse(Console.ReadLine());

            int antecessor = numerow - 1;
            int sucessor = numerow + 1;

            Console.WriteLine("O antecessor do " + numerow + " é " + antecessor);
            Console.WriteLine("O sucessor do " + numerow + " é " + sucessor);

            //5
            decimal salariomin = 1293.20m;
            Console.WriteLine("O valor do salário mínimo é " + salariomin);
            Console.WriteLine("Digite o valor do seu salário");
            decimal salariouser = decimal.Parse(Console.ReadLine());
            decimal qtdesalariosmin = salariouser / salariomin;
            Console.WriteLine("Seu salário equivale a  " + qtdesalariosmin + " salários minimos");

            //6
            Console.WriteLine("Digite um valor qualquer");
            decimal valorqlq = decimal.Parse(Console.ReadLine());
            decimal valorreajust = valorqlq + (valorqlq * 0.05m);
            Console.WriteLine("O valor com o reajuste de 5% é " + valorreajust);


            //7
            Console.WriteLine("Digite o primeiro valor booleano");
            bool valor1 = bool.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor booleano");
            bool valor2 = bool.Parse(Console.ReadLine());
            if (valor1 == true && valor2 == true)
                Console.WriteLine("Ambos os valore são verdadeiros");
            else if (valor1 == false && valor2 == false)
                Console.WriteLine("Ambos os valores são falsos");
            else
            {
                Console.WriteLine("Os valores são diferentes");
            }

            //8
            Console.WriteLine("Digite o primeiro número inteiro");
            int nume1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número inteiro");
            int nume2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o terceiro número inteiro");
            int nume3 = int.Parse(Console.ReadLine());

            int[] numes = { nume1, nume2, nume3 };

            Array.Sort(numes);
            Array.Reverse(numes);

            Console.WriteLine("Os valores em ordem decrescente ficam assim: ");
            foreach (int nume in numes)
            {
                Console.WriteLine(nume);
            }


            //9
            Console.WriteLine("Informe o seu peso em kg:");
            double peso = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a sua altura em metros:");
            double altura = double.Parse(Console.ReadLine());

            double imc = peso / (altura * altura);
            Console.WriteLine($"Seu IMC é: {imc:F2}");

            if (imc < 18.5)
            {
                Console.WriteLine("Condição: Abaixo do peso.");
            }
            else if (imc >= 18.6 && imc <= 24.9)
            {
                Console.WriteLine("Condição: Peso ideal (parabéns).");
            }
            else if (imc >= 25.0 && imc <= 29.9)
            {
                Console.WriteLine("Condição: Levemente acima do peso.");
            }
            else if (imc >= 30.0 && imc <= 34.9)
            {
                Console.WriteLine("Condição: Obesidade grau I.");
            }
            else if (imc >= 35.0 && imc <= 39.9)
            {
                Console.WriteLine("Condição: Obesidade grau II (severa).");
            }
            else if (imc >= 40.0)
            {
                Console.WriteLine("Condição: Obesidade grau III (mórbida).");
            }


            //10
            Console.WriteLine("Digite sua primeira nota");
            double nota1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite sua segunda nota");
            double nota2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite sua terceira nota");
            double nota3 = double.Parse(Console.ReadLine());

            double media = (nota1 + nota2 + nota3) / 3;
            Console.WriteLine("Sua média é " + media);

            //11
            Console.WriteLine("Digite o seu nome");
            string name = Console.ReadLine();
            Console.WriteLine("Digite sua primeira nota");
            double nota4 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite sua segunda nota");
            double nota5 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite sua terceira nota");
            double nota6 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite sua quarta nota");
            double nota7 = double.Parse(Console.ReadLine());


            double media2 = (nota4 + nota5 + nota6 + nota7) / 4;
            Console.WriteLine("Sua média é " + media2);
            if (media >= 7)
            {
                Console.WriteLine("Olá " + name + "você foi aprovado");
            }
            else
            {
                Console.WriteLine("Olá " + name + "você foi reprovado");
            }



            //12
            Console.WriteLine("Informe o seu nome");
            string name2 = Console.ReadLine();
            Console.WriteLine("Informe a sua idade");
            int idade = int.Parse(Console.ReadLine());

            if (idade >= 18)
            {
                Console.WriteLine("Olá" + name2 + " você é maior de idade");
            }
            else
            {
                Console.WriteLine("Olá" + name2 + " você é menor de idade");

            }

            //13
            Console.WriteLine("Digite o valor de A");
            int Aa = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de B");
            int Bb = int.Parse(Console.ReadLine());

            Console.WriteLine(Aa);
            Console.WriteLine(Bb);

            int temp = Aa;
            Aa = Bb;
            Bb = temp;

            Console.WriteLine(Aa);
            Console.WriteLine(Bb);

            //14
            Console.WriteLine("Digite o ano em que você nasceu");
            int anonascimento = int.Parse(Console.ReadLine());
            int anoatual = DateTime.Now.Year;
            int anosidade = anoatual - anonascimento;

            int mesesdevida = anosidade * 12;
            int diasdevida = anosidade * 365;

            Console.WriteLine("Você ja viveu" + anosidade + " anos" + mesesdevida + " meses" + diasdevida + " dias");


            //15
            Console.WriteLine("Informe o valor do primeiro lado");
            double lado1 = double.Parse(Console.ReadLine());
            Console.Write("Informe o valor do segundo lado");
            double lado2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor do terceiro lado");
            double lado3 = double.Parse(Console.ReadLine());

            
            //A condição de existência de um triângulo é que a soma das medidas de dois lados seja maior que a medida do terceiro lado.

            if ((lado1 + lado2 > lado3) && (lado1 + lado3 > lado2) && (lado2 + lado3 > lado1))
            {
                if (lado1 == lado2 && lado2 == lado3)
                {
                    Console.WriteLine("O triângulo é equilátero");
                }
                else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
                {
                    Console.WriteLine("O triângulo é isósceles");
                }
                else
                {
                    Console.WriteLine("O triângulo é escaleno");
                }



                Console.WriteLine("Digite a temperatura em Fahrenheit");
                double tempfahr = double.Parse(Console.ReadLine());
                double tempcels = (5 * (tempfahr - 32)) / 9;

                Console.WriteLine("A temperatura em Fahrenheit convertida em celsius é:" + tempcels);



                //16 enunciado errado
                double alturaxico = 1.10;
                double alturasara = 1.50;
                double crescimentoxico = 0.03;
                double crecismentosara = 0.02;

                int anos = 0;

                while (alturaxico <= alturasara)
                {
                    alturaxico += crescimentoxico;
                    alturasara += crecismentosara;
                    anos++;
                }
                Console.WriteLine("Serão necessarios " + anos + "anos para que Xiquinho passe a altura de Sara");




                //17
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine("Tabuada do" + i);

                    for (int j = 1; j <= 10; j++)
                    {
                        Console.WriteLine(i + "x" + j + " = " + (i * j));
                    }
                    Console.WriteLine();
                }



                Console.WriteLine("Forneça um número inteiro");
                int numerotabu = int.Parse(Console.ReadLine());
                Console.WriteLine("Tabuada do numero " + numerotabu);

                for (int i = 1; i <= 10; i++)
                {
                    int resulttabu = numerotabu * i;    
                    Console.WriteLine( numerotabu + "x" + i + " = " + resulttabu);  
                }

                //18
                Random random = new Random();
                int valoraleatorio = random.Next(0, 101);
                Console.WriteLine("O número aleatório entre 0 e 100 gerado é:" + valoraleatorio);   





                //19
                Console.WriteLine("Digite um valor inteiro para A");
                int aA = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite um valor inteiro para B");
                int bB = int.Parse(Console.ReadLine());

                int quociente = aA / bB;
                int resto = aA % bB;    
                Console.WriteLine("O quociente da divisão de A por B é :" + quociente);
                Console.WriteLine("O resto da divisão de A por B é: " + resto); 


                //20
                Console.WriteLine("Digite o valor da hora-aula");
                double valorhoraaula = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite a quantidade de aulas por mês");
                double qtddAulasMes = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite o percentual de desconto do INSS:");
                double percentualInss = double.Parse(Console.ReadLine());

                double salarioBruto = valorhoraaula * qtddAulasMes;
                double descontoInss = salarioBruto * (percentualInss / 100);
                double salarioLiquido = salarioBruto - descontoInss;
                Console.WriteLine("O seu salário liquido é: " + salarioLiquido);    


                //21
                Console.WriteLine("Digite o tempo gasto na viagem");
                double tempoViagem = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite a velocidade média durante a viagem");
                double velocidadeMedia = double.Parse(Console.ReadLine());

                double distancia = tempoViagem * velocidadeMedia;
                double litrosGastos = distancia / 12;
                Console.WriteLine("A quantidade de litros gastos foi de : " + litrosGastos);


                











                Console.ReadKey();
            }
        }
    }
}


