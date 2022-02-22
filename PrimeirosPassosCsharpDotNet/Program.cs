using static System.Console;
public class Program
{
    static int Dobro(int x)
    {
        return x * 2;

    }
    static void Demo1()
    {
        int a = 7;
        int b = a;
        a = Dobro(a);
        
        WriteLine("Hello, World!");
        WriteLine($"O valor do dobro de {b} e {a}");
    }
    static void Demo2()
    {
        Pessoa p1 = new Pessoa();

        p1.Nome = "Thiago";
        p1.Idade = 23;
        p1.Documento = "2345478";

        Pessoa p2 = p1.Clone();

        TrocarNome(p1, "Jacob");

        WriteLine($@"
        Nome de p1 e {p1.Nome}
        Nome de p2 e {p2.Nome}");
    }
    static void TrocarNome(Pessoa p1, string novoNome)
    {
        p1.Nome = novoNome;
    }

    static void TrocarNome(StructPessoa p1, string novoNome)
    {
        p1.Nome = novoNome;
    }


         public static void Main()
    {
        StructPessoa p1 = new StructPessoa
        {
            Documento = "324314",
            Idade = 67,
            Nome = "Miqueline"
        };

        var p2 = p1;

        TrocarNome(p1, "wed");

        WriteLine($@"
        O nome de p1 e {p1.Nome}
        O nome de p2 e {p2.Nome}");

    }
}
