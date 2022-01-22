
using ExemploConstrutores.Models;

namespace ExemploCosntrutores
{
    class Program
    {
        public delegate void Operacao(int x, int y);
        static void Main(string[] args)
        {
            //Operacao op = Calculadora.Somar; // sem o uso do new
            Operacao op = new Operacao(Calculadora.Somar);
            // Multi Cast Delegate - chamar vários métodos
            // usando += 
            // está chamando mais um método sem perder a referência do outro método
            op += Calculadora.Subtrair; 

            //Maneiras válidas de chamar o seu delegate
            op.Invoke(10,10);

            //op(10,10);

            // const double pi = 3.14;
            // System.Console.WriteLine(pi);

            // Data data = new Data();
            //data.SetMes(20);

            //data.Mes = 20;
            //System.Console.WriteLine(data.Mes);

            //data.ApresentarMes();

            // Aluno p1 = new Aluno("Leonardo", "Buta", "Teste");
            // p1.Apresentar();
            
            // Log log = Log.GetInstance();

            // log.PropriedadeLog = "Teste instancia";

            // Log log2 = Log.GetInstance();
            // System.Console.WriteLine(log2.PropriedadeLog);

            //Pessoa p1 = new Pessoa("Leonardo", "Buta");
            //p1.Apresentar();
            
        }
    }
}


