using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosOAT31_1.cs
{
    internal class Exercicios
    {

        public void Questao1()
        {
            int estoqueMedio;
            int quantidadeMinima;
            int quantidadeMaxima;

            Console.Write("Informe a quantidade mínima do estoque: ");
            quantidadeMinima = int.Parse(Console.ReadLine());
            Console.Write("Informe a quantidade máxima do estoque: ");
            quantidadeMaxima = int.Parse(Console.ReadLine());
            estoqueMedio = (quantidadeMinima + quantidadeMaxima) / 2;
            Console.WriteLine("O estoque médio dessa peça é: " + estoqueMedio + ".");


        }

        public void Questao2()
        {

            double cotacaododolar;
            double valordolares;
            double conversao;

            Console.Write("Informe o valor atual do Dólar, em RS: ");
            cotacaododolar = double.Parse(Console.ReadLine());
            Console.Write("Informe qual será o valor a ser convertido: ");
            valordolares = double.Parse(Console.ReadLine());
            conversao = cotacaododolar * valordolares;
            Console.Write("O valor de $" + valordolares + "convertidos para reais é de R$" + conversao);


        }



        public void Questao3()
        {
            double comissao, precoPeca, totalvendas;
            int codigoPeca, quantidadeVendida;
            string vendedor;
            Console.Write("Informe o nome do(a) vendedor: ");
            vendedor = Console.ReadLine();
            Console.Write("Informe o código da peça vendida: ");
            codigoPeca = int.Parse(Console.ReadLine());
            Console.Write("Informe o preço unitário da peça: ");
            precoPeca = int.Parse(Console.ReadLine());
            Console.Write("Informe a quantidade de peças vendidas: ");
            quantidadeVendida = int.Parse(Console.ReadLine());
            totalvendas = precoPeca * quantidadeVendida;
            comissao = totalvendas * 0.05;
            Console.Write(" O valor total da venda é de R$ " + totalvendas + ", e a comissão para o(a) " + vendedor + " é de R$ " + comissao + ".");


        }
        public void Questao4()
        {
            int somaAB, somaAC, somaAD, somaBC, somaBD, somaCD, multAB, multAC, multAD, multBC, multBD, multCD, valorA, valorB, valorC, valorD;

            Console.Write("Informe o valor de A: ");
            valorA = int.Parse(Console.ReadLine());
            Console.Write("Informe o valor de B: ");
            valorB = int.Parse(Console.ReadLine());
            Console.Write("Informe o valor de C: ");
            valorC = int.Parse(Console.ReadLine());
            Console.Write("Informe o valor de D: ");
            valorD = int.Parse(Console.ReadLine());
            somaAB = valorA + valorB;
            somaAC = valorA + valorC;
            somaAD = valorA + valorD;
            somaBC = valorB + valorC;
            somaBD = valorB + valorD;
            somaCD = valorC + valorD;
            multAB = valorA * valorB;
            multAC = valorA * valorC;
            multAD = valorA * valorD;
            multBC = valorB * valorC;
            multBD = valorB * valorD;
            multCD = valorC * valorD;
            Console.WriteLine("A soma de A e B é:" + somaAB);
            Console.WriteLine("A soma de A e C é:" + somaAC);
            Console.WriteLine("A soma de A e D é:" + somaAD);
            Console.WriteLine("A soma de B e C é:" + somaBC);
            Console.WriteLine("A soma de B e D é:" + somaBD);
            Console.WriteLine("A soma de C e D é:" + somaCD);
            Console.WriteLine("A multiplicação de A e B é:" + multAB);
            Console.WriteLine("A multiplicação de A e C é:" + multAC);
            Console.WriteLine("A multiplicação de A e D é:" + multAD);
            Console.WriteLine("A multiplicação de B e C é:" + multBC);
            Console.WriteLine("A multiplicação de B e D é:" + multBD);
            Console.WriteLine("A multiplicação de C e D é:" + multCD);


        }
        public void Questao5()
        {
            double quantidadeLitros;
            double tempo;
            double velocidade;
            double distancia;
            double litrosUsados;

            Console.Write("Informe o tempo de viagem: ");
            tempo = double.Parse(Console.ReadLine());
            Console.Write("Informe a velocidade média: ");
            velocidade = double.Parse(Console.ReadLine());
            distancia = tempo * velocidade;
            litrosUsados = distancia / 12;
            Console.Write("Sua velocidade média é " + velocidade + ", seu tempo gasto foi de " + tempo + ", a distância percorrida foi de " + distancia + " e a quantidade de gasolina em litros usados foi de " + litrosUsados + ".");


        }
        public void Questao6()
        {
            double celsius, fahrenheit;

            Console.WriteLine("Informe a temperatura em C (Celsius) a ser convertida para F (Fahrenheit): ");
            celsius = double.Parse(Console.ReadLine());
            fahrenheit = (9 * celsius + 160) / 5;
            Console.WriteLine("O valor C " + celsius + "convertido para F é igual a " + fahrenheit + ".");

        }
        public void Questao7()
        {
            double celsius, fahrenheit;

            Console.WriteLine("Informe a temperatura em F (Fahrenheit) a ser convertida para C (Celsius): ");
            fahrenheit = double.Parse(Console.ReadLine());
            celsius = (fahrenheit - 32) * 5 / 9;
            Console.WriteLine("O valor F " + fahrenheit + "convertido para C é igual a  " + celsius + ".");


        }
        public void Questao8()
        {
            double volume;
            double raio;
            double altura;

            Console.WriteLine("Informe o raio da lata de óleo:");
            raio = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a altura da lata de óleo:");
            altura = double.Parse(Console.ReadLine());
            volume = 3.14159 * raio * raio * altura;
            Console.WriteLine("O valor do volume dessa lata de óleo é de: " + volume + ".");

        }
        public void Questao9()
        {
            int anos, meses, dias, total;

            Console.WriteLine("Informe sua idade:");
            anos = int.Parse(Console.ReadLine());
            Console.WriteLine("Você tem " + anos + " anos e quantos meses?");
            meses = int.Parse(Console.ReadLine());
            Console.WriteLine("Você tem " + anos + " anos, " + meses + " meses e quantos dias?");
            dias = int.Parse(Console.ReadLine());
            total = (anos * 365) + (meses * 30) + dias;
            Console.WriteLine("Sua idade em dias é " + total + ".");


        }
        public void Questao10()
        {
            int valor1, valor2;

            Console.WriteLine("Informe o primeiro valor:");
            valor1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o segundo valor:");
            valor2 = int.Parse(Console.ReadLine());
            if (valor1 == valor2)
            {
                Console.WriteLine("Os valores são iguais.");
            }
            else if (valor1 > valor2)
            {
                Console.Write("Os valores são diferentes e o primeiro é maior que o segundo");
            }
            else if (valor1 < valor2)
            {
                Console.Write("Os valores são diferentes e o segundo é maior que o primeiro.");
            }


        }
        public void Questao11()
        {
            int a, b, c;

            Console.WriteLine("Informe o valor de A:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor de B:");
            b = int.Parse(Console.ReadLine());
            c = a;
            a = b;
            b = c;
            Console.WriteLine("O valor de A é " + a + " e o valor de B é: " + b + ".");


        }
        public void Questao12()
        {
            int x;

            Console.WriteLine("Informe o valor de A:");
            x = int.Parse(Console.ReadLine());
            if (x >= 0)
            {
                Console.WriteLine("O módulo do número é:" + x + ".");
            }
            else
            {
                x = x * -1;
                Console.WriteLine("O módolo do número é:" + x + ".");
            }


        }

        public void Questao13()
        {

            int valor1, valor2, valor3;

            Console.WriteLine("Informe o primeiro valor:");
            valor1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o segundo valor:");
            valor2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o terceiro valor:");
            valor3 = int.Parse(Console.ReadLine());
            if (valor1 >= valor2 && valor2 >= valor3)
            {
                Console.WriteLine("A ordem decrescente dos valores é:" + valor1 + "," + valor2 + "," + valor3 + ".");
            }
            else if (valor1 <= valor2 && valor1 >= valor3)
            {
                Console.WriteLine("A ordem decrescente dos valores é:" + valor2 + "," + valor1 + "," + valor3 + ".");
            }
            else if (valor3 >= valor2 && valor2 >= valor1)
            {
                Console.WriteLine("A ordem decrescente dos valores é:" + valor3 + "," + valor2 + "," + valor1 + ".");
            }
            else if (valor1 >= valor2 && valor2 <= valor3)
            {
                Console.WriteLine("A ordem decrescente dos valores é:" + valor1 + "," + valor3 + "," + valor2 + ",");
            }



        }



        public void Questao14()
        {
            int valor1, valor2, diferenca;

            Console.WriteLine("Informe o primeiro valor:");
            valor1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o segundo valor:");
            valor2 = int.Parse(Console.ReadLine());
            if (valor1 > valor2)
            {
                diferenca = valor1 - valor2;
                Console.WriteLine("O valor da diferença entre o primeiro e o segundo valor é de: " + diferenca + ".");
            }
            else if (valor1 < valor2)
            {
                diferenca = valor2 - valor1;
                Console.WriteLine("O valor da diferença entre o segundo e o primeiro valor é de: " + diferenca + ".");
            }


        }
        public void Questao15()
        {
            double nota1, nota2, nota3, nota4, media, recuperacao;

            Console.WriteLine("Informe o valor da primeira nota:");
            nota1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor da segunda nota:");
            nota2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor da terceira nota:");
            nota3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor da quarta nota:");
            nota4 = double.Parse(Console.ReadLine());
            media = (nota1 + nota2 + nota3 + nota4) / 4;
            if (media >= 7)
            {
                Console.WriteLine("Parabéns, aluno aprovado! Sua média foi de: " + media + ".");
            }
            else if (media < 7)
            {
                Console.WriteLine("Infome a nota da recuperação:");
                recuperacao = double.Parse(Console.ReadLine());
                media = media + recuperacao;
                if (media >= 7)
                {
                    Console.WriteLine("Aluno aprovado na recuperação com a média: " + media + ".");
                }
                else
                    Console.WriteLine("Aluno reprovado na recuperação com a média: " + media + ".");
            }


        }
        public void Questao16()
        {
            int valor1, valor2;

            Console.WriteLine("Informe o primeiro valor:");
            valor1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o segundo valor:");
            valor2 = int.Parse(Console.ReadLine());
            if (valor1 > valor2)
            {
                Console.WriteLine("O maior número é o " + valor1 + ", e o menor número é o " + valor2 + ".");
            }
            else if (valor1 < valor2)
            {
                Console.WriteLine("O maior número é o " + valor2 + ", e o menor número é o " + valor1 + ".");
            }
            else
                Console.WriteLine("Ambos os números são iguais.");

        }
        public void Questao17()
        {
            int valor1;

            Console.WriteLine("Informe o primeiro valor:");
            valor1 = int.Parse(Console.ReadLine());
            if (valor1 >= 0 && valor1 <= 9)
            {
                Console.WriteLine("Valor válido!");
            }
            else
                Console.WriteLine("Valor inválido!");


        }
        public void Questao18()
        {
            int codigo;

            Console.WriteLine("Informe um valor:");
            codigo = int.Parse(Console.ReadLine());
            if (codigo != 1 && codigo != 2 && codigo != 3)
            {
                Console.WriteLine("Código inválido!");
            }

            switch (codigo)
            {
                case 1:
                    Console.WriteLine("um");
                    break;
                case 2:
                    Console.WriteLine("dois");
                    break;
                case 3:
                    Console.WriteLine("três");
                    break;
            }

        }
        public void Questao19()
        {
            int A, B, C;

            Console.Write("Informe o primeiro valor: ");
            A = int.Parse(Console.ReadLine());
            Console.Write("Informe o segundo valor: ");
            B = int.Parse(Console.ReadLine());
            Console.Write("Informe o terceiro valor: ");
            C = int.Parse(Console.ReadLine());

            if (A == B && A == C)
            {
                Console.WriteLine("O triângulo é equilátero.");
            }
            else if (A == B || A == C || B == C)
            {
                Console.WriteLine("O triângulo é isósceles.");
            }
            else
                Console.WriteLine("O triângulo é escaleno.");


        }
        public void Questao20()
        {
            int A, B, C, maior, menor, mult;
            double divi;

            Console.Write("Informe o primeiro valor (diferente de 0): ");
            A = int.Parse(Console.ReadLine());
            if (A == 0)
            {
                Console.Write("Infome um valor valido: ");
                A = int.Parse(Console.ReadLine());
            }
            Console.Write("Informe o segundo valor (diferente de 0): ");
            B = int.Parse(Console.ReadLine());
            if (B == 0)
            {
                Console.Write("Infome um valor valido: ");
                B = int.Parse(Console.ReadLine());
            }
            Console.Write("Informe o terceiro valor (diferente de 0): ");
            C = int.Parse(Console.ReadLine());
            if (C == 0)
            {
                Console.Write("Infome um valor valido: ");
                C = int.Parse(Console.ReadLine());
            }
            maior = A;
            menor = A;
            if (B > maior)
                maior = B;
            else if (B < menor)
                menor = B;
            else if (C > maior)
                maior = C;
            else if (C < menor)
                menor = C;
            mult = maior * menor;
            divi = maior / menor;
            Console.WriteLine("O maior valor multiplicado pelo menor é " + mult + " e o maior valor dividido para o menor é " + divi + ".");




        }
        public void Questao21()
        {
            int valor, i;
            string res;

            res = "sim";
            for (i = 1; i > 0; i++)
            {
                if (res == "sim" || res == "Sim")
                {
                    Console.WriteLine("Informe o número:");
                    valor = int.Parse(Console.ReadLine());
                    if (valor >= 0)
                    {
                        Console.WriteLine("O valor é positivo!");
                    }
                    else
                        Console.WriteLine("O valor é negativo.");
                    Console.WriteLine("Deseja continuar?");
                    res = Console.ReadLine();
                }
                else
                    break;
            }


        }
        public void Questao22()
        {
            int valor, A, B;

            Console.WriteLine("Informe o número:");
            valor = int.Parse(Console.ReadLine());
            if (valor >= 0)
            {
                A = valor;
                Console.WriteLine("O valor " + A + " é positivo!");
            }
            else if (valor <= 0)
            {
                B = valor;
                Console.WriteLine("O valor " + B + " é negativo!");
            }

        }
        public void Questao23()
        {
            double valor1, valor2, adicao, subtracao, mult, divi;
            int opcao;

            Console.WriteLine("Informe a opção desejada:");
            Console.WriteLine("1- Adição");
            Console.WriteLine("2- Subtração");
            Console.WriteLine("3- Multiplicação");
            Console.WriteLine("4- Divisão");
            opcao = int.Parse(Console.ReadLine());
            if (opcao == 1)
            {
                Console.WriteLine("Informe o primeiro valor:");
                valor1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Informe o segundo valor:");
                valor2 = double.Parse(Console.ReadLine());
                adicao = valor1 + valor2;
                Console.WriteLine("O valor da soma de " + valor1 + " e " + valor2 + " é " + adicao + ".");
            }
            else if (opcao == 2)
            {
                Console.WriteLine("Informe o primeiro valor:");
                valor1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Informe o segundo valor:");
                valor2 = double.Parse(Console.ReadLine());
                subtracao = valor1 - valor2;
                Console.WriteLine("O valor da subtração de " + valor1 + " e " + valor2 + " é " + subtracao + ".");
            }
            else if (opcao == 3)
            {
                Console.WriteLine("Informe o primeiro valor:");
                valor1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Informe o segundo valor:");
                valor2 = double.Parse(Console.ReadLine());
                mult = valor1 * valor2;
                Console.WriteLine("O valor da multiplicação de " + valor1 + " e " + valor2 + " é " + mult + ".");
            }
            else if (opcao == 4)
            {
                Console.WriteLine("Informe o primeiro valor:");
                valor1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Informe o segundo valor:");
                valor2 = double.Parse(Console.ReadLine());
                divi = valor1 / valor2;
                Console.WriteLine("O valor da divisão de " + valor1 + " e " + valor2 + " é " + divi + ".");
            }
            else
                Console.WriteLine("Informe uma opção correta!");



        }

        public void Questao24()
        {

            int valor1, valor2, opcao;
            double media;

            Console.Write("Informe o primeiro valor: ");
            valor1 = int.Parse(Console.ReadLine());
            Console.Write("Informe o segundo valor: ");
            valor2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Escolha uma das opções:");
            Console.WriteLine("1 - Verificar se um dos números é múltiplo do outro:");
            Console.WriteLine("2 - Verificar se os dois números são pares:");
            Console.WriteLine("3 - Verificar se a média dos números é maior ou igual a 7:");
            Console.WriteLine("4 - Sair.");
            opcao = int.Parse(Console.ReadLine());
            switch (opcao)
            {
                case 1:
                    if (valor1 % valor2 == 0)
                    {
                        Console.WriteLine("O primeiro valor é multiplo do segundo.");
                    }
                    else if (valor2 % valor1 == 0)
                    {
                        Console.WriteLine("O segundo valor é multiplo do primeiro.");
                    }
                    else
                    {
                        Console.WriteLine("Nenhum dos valores é múltiplo do outro.");
                    }
                    break;
                case 2:
                    if (valor1 % 2 == 0 && valor2 % 2 == 0)
                    {
                        Console.WriteLine("Os dois valores são pares.");
                    }
                    else
                    {
                        Console.WriteLine("Um dos valores é par.");
                    }
                    break;
                case 3:
                    media = (valor1 + valor2) / 2;
                    if (media >= 7)
                    {
                        Console.WriteLine("A média dos valores é maior ou igual a 7.");
                    }
                    else
                    {
                        Console.WriteLine("A média dos valores é menor que 7.");
                    }
                    break;
                case 4:
                    Console.WriteLine("Operação Finalizada");
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }

        }



        public void Questao25()
        {
            double altura, homens, mulheres;
            string sexo;

            Console.WriteLine("Informe sua altura:");
            altura = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe seu sexo");
            Console.WriteLine("M para masculino e F para feminino:");
            sexo = Console.ReadLine();
            if (sexo == "M" || sexo == "m")
            {
                homens = (72 * altura) - 58;
                Console.WriteLine("Seu peso ideal é de " + homens + "Kg.");
            }
            else if (sexo == "F" || sexo == "f")
            {
                mulheres = (62.1 * altura) - 44.7;
                Console.WriteLine("Seu peso ideal é de " + mulheres + "Kg.");
            }
            else
                Console.WriteLine("Sexo inválido!");

        }
        public void Questao26()
        {
            int i;

            for (i = 100; i >= 1; i--)
            {
                Console.Write(i + ",");
            }


        }
        public void Questao27()
        {
            int x, i, ii, valor, valorFatorado;

            Console.WriteLine("Informe quantos valores você prentede rodar:");
            ii = int.Parse(Console.ReadLine());
            for (x = 1; x <= ii; x++)
            {
                Console.WriteLine("Informe o " + x + "º valor:");
                valor = int.Parse(Console.ReadLine());
                valorFatorado = valor;
                for (i = valor - 1; i >= 1; i--)
                {
                    Console.WriteLine($"{valorFatorado} * {i}");
                    valorFatorado = valorFatorado * i;
                }
                Console.WriteLine("O calculo fatorial do seu número é " + valorFatorado + ".");
            }

        }
        public void Questao28()
        {
            int i;
            for (i = 101; i <= 200; i += 2)
            {
                Console.WriteLine(i);
            }

        }
        public void Questao29()
        {
            int i;

            for (i = 1; i <= 2000; i++)
            {
                Console.Write(i + ",");
            }


        }
        public void Questao30()
        {
            int i, valor, result;

            Console.WriteLine("Informe um valor que queira saber a tabuada de multiplicação até 100:");
            valor = int.Parse(Console.ReadLine());
            Console.WriteLine("Tabuada do :" + valor);

            for (i = 1; i <= 100; i++)
            {
                result = valor * i;
                Console.WriteLine(valor + " x " + i + " = " + result);
            }


        }
        public void Questao31()
        {
            int valor, pares, impares;

            {
                pares = 0;
                impares = 0;
                Console.WriteLine("Informe um conjunto de números positivos ou use um número negativo para encerrar:");
                while (true)
                {
                    Console.Write("Informe um número: ");
                    valor = Convert.ToInt32(Console.ReadLine());
                    if (valor < 0)
                        break;
                    if (valor % 2 == 0)
                    {
                        Console.WriteLine("O número " + valor + " é par.");
                        pares += valor;
                    }
                    else
                    {
                        Console.WriteLine($"O número " + valor + " é ímpar.");
                        impares += valor;
                    }
                }
                Console.WriteLine("O valor da soma dos números pares é: " + pares + ".");
                Console.WriteLine("O valor da soma dos números ímpares é " + impares + ".");
            }

        }
        public void Questao32()
        {
            int i, valor, soma, contador;

            {
                Console.Write("Informe um número que esteja entre 0 e 10: ");
                valor = Convert.ToInt32(Console.ReadLine());
                if (valor > 0 && valor < 10)
                {
                    soma = 0;
                    contador = 0;
                    for (i = valor; contador < 20; i++)
                    {
                        if (i % 2 != 0)
                        {
                            soma += i * i;
                            contador++;
                        }
                    }
                    Console.WriteLine("A soma dos quadrados dos 20 primeiros números ímpares a partir de " + valor + "é: " + soma + ".");
                }
                else
                {
                    Console.WriteLine("O número informado não corresponde aos valores entre 0 e 10.");
                }
            }



        }











    }
}










