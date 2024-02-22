
internal class Program
{
    private static void Main(string[] args)
    {
        string nomeCandidato1;
        int numeroCandidato1;
        string nomeCandidato2;
        int numeroCandidato2;
        string nomeCandidato3;
        int numeroCandidato3;
        int numerodevotos1 = 0;
        int numerodevotos2 = 0;
        int numerodevotos3 = 0;
        string votos;
        int votosEMBranco = 0;
        int votosNulos = 0;

        Console.WriteLine("Informe o nome do primeiro candidato: ");
        nomeCandidato1 = Console.ReadLine()!;

        Console.WriteLine($"Informe o número do candidato {nomeCandidato1}: ");
        numeroCandidato1 = int.Parse(Console.ReadLine()!);

        Console.Clear();

        Console.WriteLine("Informe o nome do segundo candidato: ");
        nomeCandidato2 = Console.ReadLine()!;

        Console.WriteLine($"Informe o número do candidato {nomeCandidato2}: ");
        numeroCandidato2 = int.Parse(Console.ReadLine()!);

        Console.Clear();

        Console.WriteLine("Informe o nome do terceiro candidato: ");
        nomeCandidato3 = Console.ReadLine()!;

        Console.WriteLine($"Informe o número do candidato {nomeCandidato3}: ");
        numeroCandidato3 = int.Parse(Console.ReadLine()!);

        Console.Clear();

        Console.WriteLine("----------ZERÉSIMO----------\n");

        Console.WriteLine($"Candidato: {nomeCandidato1}");
        Console.WriteLine($"Número: {numeroCandidato1}");
        Console.WriteLine($"Votos: {numerodevotos1}\n");

        Console.WriteLine($"Candidato: {nomeCandidato2}");
        Console.WriteLine($"Número: {numeroCandidato2}");
        Console.WriteLine($"Votos: {numerodevotos2}\n");

        Console.WriteLine($"Candidato: {nomeCandidato3}");
        Console.WriteLine($"Número: {numeroCandidato3}");
        Console.WriteLine($"Votos: {numerodevotos3}\n");

        Console.WriteLine("----------------------------");

        Thread.Sleep(3500);
        Console.Clear();

        do
        {
            Console.WriteLine($"Tecla '1' para votar em: {nomeCandidato1}");
            Console.WriteLine($"Tecla '2' para votar em: {nomeCandidato2}");
            Console.WriteLine($"Tecla '3' para votar em: {nomeCandidato3}");
            Console.WriteLine($"Tecla '0' para ENCERRAR a votação.");
            Console.WriteLine($"Tecla 'ENTER' para votar em branco.");

            Console.WriteLine("Voto: ");
            votos = Console.ReadLine()!;

            switch (votos)
            {
                case "1":
                    numerodevotos1++;
                    break;

                case "2":
                    numerodevotos2++;
                    break;

                case "3":
                    numerodevotos3++;
                    break;
                case "0":
                    break;


                default:
                    if (votos != "")
                        votosNulos++;
                    else
                        votosEMBranco++;
                    break;

            }

            Console.Clear();

        } while (votos != "0");



        if (numerodevotos1 == 0 && numerodevotos2 == 0 && numerodevotos3 == 0)
        {
            Console.WriteLine("---NENHUM CANDIDATO OBTEVE VOTOS---");
        }
        else if (numerodevotos1 > numerodevotos2 && numerodevotos1 > numerodevotos3)
        {
            Console.WriteLine($"O candidato {nomeCandidato1} foi o ganhador.");
        }
        else if (numerodevotos2 > numerodevotos1 && numerodevotos2 > numerodevotos3)
        {
            Console.WriteLine($"O candidato {nomeCandidato2} foi o ganhador.");
        }
        else if (numerodevotos3 > numerodevotos1 && numerodevotos3 > numerodevotos2)
        {
            Console.WriteLine($"O candidato {nomeCandidato3} foi o ganhador.");
        }

        Console.WriteLine($"Candidato: {nomeCandidato1}");
        Console.WriteLine($"Número: {numeroCandidato1}");
        Console.WriteLine($"Votos: {numerodevotos1}\n");

        Console.WriteLine($"Candidato: {nomeCandidato2}");
        Console.WriteLine($"Número: {numeroCandidato2}");
        Console.WriteLine($"Votos: {numerodevotos2}\n");

        Console.WriteLine($"Candidato: {nomeCandidato3}");
        Console.WriteLine($"Número: {numeroCandidato3}");
        Console.WriteLine($"Votos: {numerodevotos3}\n");

        Console.WriteLine($"Votos em branco: {votosEMBranco}");
        Console.WriteLine($"Votos nulos: {votosNulos}");


    }
}