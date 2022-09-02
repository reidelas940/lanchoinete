using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int opção, opçãoLanches;
            double subtotal = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("DÚ LANCHES");
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("1- LANCHES E PORÇÕES ");
                Console.WriteLine("2- BEBIDAS");
                Console.WriteLine("3- COMBOS");
                Console.WriteLine("4- FINALIZAÇÃO");
                opção = Convert.ToInt32(Console.ReadLine());

                if (opção == 1)
                {
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("LANCHES");
                        Console.WriteLine("-----------------------------------");
                        Console.WriteLine("1- LANCHE SIMPLES - 5.00");
                        Console.WriteLine("2- SMASH BURGUER - 7.00");
                        Console.WriteLine("3- SUPREMO BURGUER - 10.00");
                        Console.WriteLine("4- QUARTEIRÃO DUPLO - 12.00");
                        Console.WriteLine("5- TRIPLO CHEDDAR - 12.00");
                        Console.WriteLine("6- TRIPLO BACON - 14.00");
                        Console.WriteLine("7- SUPREMO BACON - 15.00");
                        Console.WriteLine("8- PORÇÃO DE FRITAS COM BACON E CATUPIRY - 16.00");
                        Console.WriteLine("9- X-SALADA  - 19.99");
                        Console.WriteLine("0- SAIR");
                        opçãoLanches = Convert.ToInt32(Console.ReadLine());

                        if (opçãoLanches == 1)
                        {
                            Console.Clear();
                            subtotal = subtotal + 5.00;
                            Console.WriteLine("Você selecionou o lanche " +
                                "Simples seu subtotal foi de: " + subtotal);
                            Console.ReadLine();
                        }

                        else if (opçãoLanches == 2)
                        {
                            Console.Clear();
                            subtotal = subtotal + 7.00;
                            Console.WriteLine("Você selecionou o  SMASH " +
                                "BURGUER seu subtotal foi de: " + subtotal);
                            Console.ReadLine();
                        }

                        else if (opçãoLanches == 3)
                        {
                            Console.Clear();
                            subtotal = subtotal + 10.00;
                            Console.WriteLine("Você selecionou o SUPREMO " +
                                "BURGUER seu subtotal foi de: " + subtotal);
                            Console.ReadLine();
                        }

                        else if (opçãoLanches == 4)
                        {
                            Console.Clear();
                            subtotal = subtotal + 12.00;
                            Console.WriteLine("Você selecionou o QUARTEIRÃO " +
                                "DUPLO seu subtotal foi de: " + subtotal);
                            Console.ReadLine();
                        }
                        else if (opçãoLanches == 5)
                        {
                            Console.Clear();
                            subtotal = subtotal + 12.00;
                            Console.WriteLine("Você selecionou o TRIPLO " +
                                "CHEDDAR seu subtotal foi de: " + subtotal);
                            Console.ReadLine();
                        }
                        else if (opçãoLanches == 6)
                        {
                            Console.Clear();
                            subtotal = subtotal + 14.00;
                            Console.WriteLine("Você selecionou o TRIPLO " +
                                "BACON seu subtotal foi de: " + subtotal);
                            Console.ReadLine();
                        }
                        else if (opçãoLanches == 7)
                        {
                            Console.Clear();
                            subtotal = subtotal + 15.00;
                            Console.WriteLine("Você selecionou o SUPREMO " +
                                "BACON seu subtotal foi de: " + subtotal);
                            Console.ReadLine();
                        }
                        else if (opçãoLanches == 8)
                        {
                            Console.Clear();
                            subtotal = subtotal + 16.00;
                            Console.WriteLine("Você selecionou o PORÇÃO DE FRITAS " +
                                "COM BACON E CATUPIRY seu subtotal foi de: " + subtotal);
                            Console.ReadLine();
                        }
                        else if (opçãoLanches == 9)
                        {
                            Console.Clear();
                            subtotal = subtotal + 19.99;
                            Console.WriteLine("Você selecionou o X- " +
                                "SALADA seu subtotal foi de: " + subtotal);
                            Console.ReadLine();
                        }

                    } while(opçãoLanches != 0); 

                    }

                if (opção == 2)
                {
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("BEBIDAS");
                        Console.WriteLine("--------------------------------");
                        Console.WriteLine("1- COCA COLA LATINHA - 5.00");
                        Console.WriteLine("2- ITAIPAVA 1L - 15.00");
                        Console.WriteLine("3- PEPSI TWISTER LATINHA - 10.00");
                        Console.WriteLine("4- HEINEKEN 1L - 19.99");
                        Console.WriteLine("5- ÁGUA - 6.00");
                        Console.WriteLine("0- SAIR");
                        Console.WriteLine("0- SAIR");
                        opçãoLanches = Convert.ToInt32(Console.ReadLine());

                        if (opçãoLanches == 1)
                        {
                            Console.Clear();
                            subtotal = subtotal + 5.00;
                            Console.WriteLine("Você selecionou o COCA COLA " +
                                "LATINHA seu subtotal foi de: " + subtotal);
                            Console.ReadLine();
                        }

                        if (opçãoLanches == 2)
                        {
                            Console.Clear();
                            subtotal = subtotal + 15.00;
                            Console.WriteLine("Você selecionou o  ITAIPAVA " +
                                "1L seu subtotal foi de: " + subtotal);
                            Console.ReadLine();
                        }

                        if (opçãoLanches == 3)
                        {
                            Console.Clear();
                            subtotal = subtotal + 10.00;
                            Console.WriteLine("Você selecionou o PEPSI TWISTER " +
                                "LATINHA seu subtotal foi de: " + subtotal);
                            Console.ReadLine();
                        }

                        if (opçãoLanches == 4)
                        {
                            Console.Clear();
                            subtotal = subtotal + 19.99;
                            Console.WriteLine("Você selecionou o HEINEKEN" +
                                "1L seu subtotal foi de: " + subtotal);
                            Console.ReadLine();
                        }
                        if (opçãoLanches == 5)
                        {
                            Console.Clear();
                            subtotal = subtotal + 6.00;
                            Console.WriteLine("Você selecionou a ÁGUA " +
                                " seu subtotal foi de: " + subtotal);
                            Console.ReadLine();
                        }

                    } while (opçãoLanches != 0);

                    }

                if (opção == 3)
                {
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("COMBOS");
                        Console.WriteLine("-------------------------------------------------------------------------");
                        Console.WriteLine("1- COMBO SUPREMO BACON + COCA COLA + FRITAS - 15.00");
                        Console.WriteLine("2- COMBO FRITAS DE BACON E CATUPIRY + ITAIPAVA + X-SALADA - 28.00");
                        Console.WriteLine("3- COMBO INFANTIL - 10.00");
                        Console.WriteLine("4- COMBO QUARTEIRÃO + PEPSI TWISTER - 17.50");
                        Console.WriteLine("5- COMBO TRIPLO CHEDDAR + HEINEKEN - 22.00");
                        Console.WriteLine("0- SAIR");
                        opçãoLanches = Convert.ToInt32(Console.ReadLine());

                        if (opçãoLanches == 1)
                        {
                            Console.Clear();
                            subtotal = subtotal + 15.00;
                            Console.WriteLine("Você selecionou o COMBO SUPREMO BACON" +
                                "+ COCA COLA + FRITAS  seu subtotal foi de: " + subtotal);
                            Console.ReadLine();
                        }

                        if (opçãoLanches == 2)
                        {
                            Console.Clear();
                            subtotal = subtotal + 28.00;
                            Console.WriteLine("Você selecionou o COMBO FRITAS DE BACON E CATUPIRY " +
                                " + ITAIPAVA + X-SALADAseu subtotal foi de: " + subtotal);
                            Console.ReadLine();
                        }

                        if (opçãoLanches == 3)
                        {
                            Console.Clear();
                            subtotal = subtotal + 10.00;
                            Console.WriteLine("Você selecionou o COMBO INFANTIL" +
                                "seu subtotal foi de: " + subtotal);
                            Console.ReadLine();
                        }

                        if (opçãoLanches == 4)
                        {
                            Console.Clear();
                            subtotal = subtotal + 17.50;
                            Console.WriteLine("Você selecionou o COMBO QUARTEIRÃO" +
                                "+ PEPSI TWISTER seu subtotal foi de: " + subtotal);
                            Console.ReadLine();
                        }
                        if (opçãoLanches == 5)
                        {
                            Console.Clear();
                            subtotal = subtotal + 22.00;
                            Console.WriteLine("Você selecionou a ÁCOMBO TRIPLO CHEDDAR " +
                                " + HEINEKEN seu subtotal foi de: " + subtotal);
                            Console.ReadLine();
                        }

                    } while (opçãoLanches != 0);

                } while (opção != 4) ;

                Console.WriteLine("O subtotal foi de: " + subtotal);
            } while (opção != 4);
        }
    }
}