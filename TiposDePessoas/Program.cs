using TiposDePessoas;

internal class Program
{
    private static void Main(string[] args)
    {
        PessoaFisica pessoaFisica = new PessoaFisica(" Leandro Schneider", "98164-5102", "3312-4570", "434.045.848-79", "leandro@gmail.com");
        PessoaJuridica pessoaJuridica= new PessoaJuridica(" Universe", "Saint Universe" ,"98164-5102", "3423-9873", "324.856.456-86" ,"00.133.133/0001-45", "saintuniverse@gmail.com");

        Console.WriteLine(pessoaFisica.ToString());
        Console.WriteLine(pessoaJuridica.ToString());
    }
}