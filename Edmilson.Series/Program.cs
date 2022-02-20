using System;

namespace Edmilson.Series
{
    class Program
    {
        static SerieRepository repository = new SerieRepository();
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
                        InsertSerie();
                        break;
                    case "3":
                        UpdateSerie();
                        break;
                    case "4":
                        DeleteSerie();
                        break;
                    case "5":
                        // ViewSerie();
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

        private static void DeleteSerie() {
            Console.Write("Digite o id da série: ");
            int serieIndex = int.Parse(Console.ReadLine());

            repository.Delete(serieIndex);
        }

        private static void UpdateSerie() {
            Console.Write("Digite o id da série.");
            int serieIndex = int.Parse(Console.ReadLine());

            foreach (int i in Enum.GetValues(typeof(Gender))) {
                Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Gender), i));
            }

            Console.Write("Digite o Gênero entre as opções acima: ");
            int genderInput = int.Parse(Console.ReadLine());

            Console.Write("Digite o Titulo da Série: ");
            string titleInput = Console.ReadLine();

            Console.Write("Digite o Ano de Início da Série");
            int yearInput = int.Parse(Console.ReadLine());

            Console.Write("Digite a Descrição da Série");
            string descriptionInput = Console.ReadLine();

            Serie updateSerie = new Serie(id: serieIndex,
            gender: (Gender)genderInput,
            title: titleInput,
            year: yearInput,
            description: descriptionInput
            );

            repository.Update(serieIndex, updateSerie);
        }

        private static void ListSeries() {
            Console.WriteLine("List series");

            var list = repository.List();

            if (list.Count == 0) {
                Console.WriteLine("Nenhuma série cadastrada.");
                return;
            }

            foreach (var serie in list) {
                Console.WriteLine("#ID {0}:   {1}", serie.returnId(), serie.returnTitle());
            }
        }

        private static void InsertSerie() {
            Console.WriteLine("Inserir nova série");

            foreach (int i in Enum.GetValues(typeof(Gender))) {
                Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Gender), i));
            }

            Console.WriteLine("Digite o gênero entre as opções acima: ");
            int genderInput = int.Parse(Console.ReadLine());

            Console.Write("Digite o Titulo da Série: ");
            string titleInput = Console.ReadLine();

            Console.Write("Digite o Ano de Início da Série: ");
            int yearInput = int.Parse(Console.ReadLine());
            
            Console.Write("Digite a descrição da Série: ");
            string descriptionInput = Console.ReadLine();

            Serie newSerie = new Serie(
                id: repository.NextId(),
                gender: (Gender)genderInput,
                title: titleInput,
                year: yearInput,
                description: descriptionInput
            );

            repository.Insert(newSerie);
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