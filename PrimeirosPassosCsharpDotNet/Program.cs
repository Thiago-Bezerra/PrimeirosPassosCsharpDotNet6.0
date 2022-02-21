using static System.Console;
public class Program
{
    static int Dobro(int x)
    {
        return x * 2;

    }

    static void TrocarNome(Pessoa p1, string novoNome)
    {
        p1.Nome = novoNome;
    }

         public static void Main()
    {
        int a = 7;
        int b = a;
        a = Dobro(a);
        
        WriteLine("Hello, World!");
        WriteLine($"O valor do dobro de {b} e {a}");

        Pessoa p1 = new Pessoa();

        p1.Nome = "Thiago";
        p1.Idade = 23;
        p1.Documento = "2345478";

        TrocarNome(p1, "Jacob");

        WriteLine($"O novo nome e {p1.Nome}");




    }
}
