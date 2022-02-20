﻿using System;

namespace Edmilson.Series
{
    class Program
    {
        static void Main(string[] args)
        {
            string userChoice = GetUserChoice();

            while (userChoice.ToUpper() != "X")
            {
                switch (userChoice)
                {
                    case "1":
                        ListSeries();
                        break;
                    case "2":
                        InsertSeries();
                        break;
                    case "3":
                        UpdateSeries();
                        break;
                    case "4":
                        DeleteSeries();
                        break;
                    case "5":
                        ViewSeries();
                        break;
                    case "C":
                        Console.Clear();
                        break;

                    default:
                        throw new ArgumentOutOfRangeException();
                }

                userChoice = GetUserChoice();
            }
            
            Console.WriteLine("Obrigado por utilizar nossos serviços.");
            Console.ReadLine();
        }


        public static string GetUserChoice()
        {
            Console.WriteLine();
            Console.WriteLine("Lama Séries a seu dispor!!!");
            Console.WriteLine("1- Listar séries");
            Console.WriteLine("2- Inserir nova série");
            Console.WriteLine("3- Atualizar série");
            Console.WriteLine("4- Excluir série");
            Console.WriteLine("5- Visualizar");
            Console.WriteLine("C- Limpar tela");
            Console.WriteLine("X- Sair");
            Console.WriteLine();

            string userChoice = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return userChoice;
        }
    }
}