
using ExemploConstrutores.Models;

namespace ExemploCosntrutores
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno p1 = new Aluno("Leonardo", "Buta", "Teste");
            p1.Apresentar();
            
            // Log log = Log.GetInstance();

            // log.PropriedadeLog = "Teste instancia";

            // Log log2 = Log.GetInstance();
            // System.Console.WriteLine(log2.PropriedadeLog);

            //Pessoa p1 = new Pessoa("Leonardo", "Buta");
            //p1.Apresentar();
            
        }
    }
}


