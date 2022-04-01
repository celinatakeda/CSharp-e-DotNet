using static System.Console;

WriteLine("Digite o nome do arquivo:");
var nome = ReadLine();

nome = LimparNome(nome);

var path = Path.Combine(Environment.CurrentDirectory,$"{nome}.txt");

CriarArquivo(path);

WriteLine("Digite enter para finalizar...");
ReadLine();

static string LimparNome(string nome)
{
    foreach (var @char in Path.GetInvalidFileNameChars())
    {
        nome = nome.Replace(@char, '-');
    }
    return nome;
}

// criar arquivo e escrevendo no arquivo teste.txt
static void CriarArquivo(string path)
{
    try
    {
        using var sw = File.CreateText(path); //using descarrega o conteúdo no final 
        sw.WriteLine("Está a linha 1 do arquivo");
        sw.WriteLine("Está a linha 2 do arquivo");
        sw.WriteLine("Está a linha 3 do arquivo");
        //sw.Flush(); //descarrega o conteúdo para o arquivo teste.txt
    }
    catch
    {
        WriteLine("O nome do arquivo está inválido!");
    }

}

// criando arquivo teste.txt
//File.Create(path);