using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosOAT31_1.cs
{
    
    
        public class Principal
        {

            public static void Main(string[] args)
            {

                int escolha;




                do
                {

                    Console.WriteLine("Questão 1              Questão 17");
                    Console.WriteLine("Questão 2              Questão 18");
                    Console.WriteLine("Questão 3              Questão 19");
                    Console.WriteLine("Questão 4              Questão 20");
                    Console.WriteLine("Questão 5              Questão 21");
                    Console.WriteLine("Questão 6              Questão 22");
                    Console.WriteLine("Questão 7              Questão 23");
                    Console.WriteLine("Questão 8              Questão 24");
                    Console.WriteLine("Questão 9              Questão 25");
                    Console.WriteLine("Questão 10             Questão 26");
                    Console.WriteLine("Questão 11             Questão 27");
                    Console.WriteLine("Questão 12             Questão 28");
                    Console.WriteLine("Questão 13             Questão 29");
                    Console.WriteLine("Questão 14             Questão 30");
                    Console.WriteLine("Questão 15             Questão 31");
                    Console.WriteLine("Questão 16             Questão 32");
                    Console.WriteLine("Escolha uma questão");
                    Console.WriteLine("Ou pressione 0 pra sair");

                    escolha = int.Parse(Console.ReadLine());

                    switch (escolha)
                    {
                        case 1:
                            Exercicios op1 = new Exercicios();
                            op1.Questao1();


                            break;
                        case 2:
                            Exercicios op2 = new Exercicios();
                            op2.Questao2();
                            break;
                        case 3:
                            Exercicios op3 = new Exercicios();
                            op3.Questao3();
                            break;
                        case 4:
                            Exercicios op4 = new Exercicios();
                            op4.Questao4();
                            break;
                        case 5:
                            Exercicios op5 = new Exercicios();
                            op5.Questao5();
                            break;
                        case 6:
                            Exercicios op6 = new Exercicios();
                            op6.Questao6();
                            break;
                        case 7:
                            Exercicios op7 = new Exercicios();
                            op7.Questao7();
                            break;
                        case 8:
                            Exercicios op8 = new Exercicios();
                            op8.Questao8();
                            break;
                        case 9:
                            Exercicios op9 = new Exercicios();
                            op9.Questao9();
                            break;
                        case 10:
                            Exercicios op10 = new Exercicios();
                            op10.Questao10();
                            break;
                        case 11:
                            Exercicios op11 = new Exercicios();
                            op11.Questao11();
                            break;
                        case 12:
                            Exercicios op12 = new Exercicios();
                            op12.Questao12();
                            break;
                        case 13:
                            Exercicios op13 = new Exercicios();
                            op13.Questao13();
                            break;
                        case 14:
                            Exercicios op14 = new Exercicios();
                            op14.Questao14();
                            break;
                        case 15:
                            Exercicios op15 = new Exercicios();
                            op15.Questao15();
                            break;
                        case 16:
                            Exercicios op16 = new Exercicios();
                            op16.Questao16();
                            break;
                        case 17:
                            Exercicios op17 = new Exercicios();
                            op17.Questao17();
                            break;
                        case 18:
                            Exercicios op18 = new Exercicios();
                            op18.Questao18();
                            break;
                        case 19:
                            Exercicios op19 = new Exercicios();
                            op19.Questao19();
                            break;
                        case 20:
                            Exercicios op20 = new Exercicios();
                            op20.Questao20();
                            break;
                        case 21:
                            Exercicios op21 = new Exercicios();
                            op21.Questao21();
                            break;
                        case 22:
                            Exercicios op22 = new Exercicios();
                            op22.Questao22();
                            break;
                        case 23:
                            Exercicios op23 = new Exercicios();
                            op23.Questao23();
                            break;
                        case 24:
                            Exercicios op24 = new Exercicios();
                            op24.Questao24();
                            break;
                        case 25:
                            Exercicios op25 = new Exercicios();
                            op25.Questao25();
                            break;
                        case 26:
                            Exercicios op26 = new Exercicios();
                            op26.Questao26();
                            break;
                        case 27:
                            Exercicios op27 = new Exercicios();
                            op27.Questao27();
                            break;
                        case 28:
                            Exercicios op28 = new Exercicios();
                            op28.Questao28();
                            break;
                        case 29:
                            Exercicios op29 = new Exercicios();
                            op29.Questao29();
                            break;
                        case 30:
                            Exercicios op30 = new Exercicios();
                            op30.Questao30();
                            break;
                        case 31:
                            Exercicios op31 = new Exercicios();
                            op31.Questao31();
                            break;
                        case 32:
                            Exercicios op32 = new Exercicios();
                            op32.Questao32();
                            break;


                        case 0:
                            Console.WriteLine("Sair!");
                            break;
                        default:
                            Console.WriteLine("Opção invalida");

                            break;





















                    }






                } while (escolha != 0);



            }
        }
    
}
