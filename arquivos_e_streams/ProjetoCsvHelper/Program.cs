using System.Globalization;
using CsvHelper.Configuration;
using CsvHelper;

//LerCSVComDynamic();
//LerCSVComClasse();
LerCsvComOutroDelimitador();

Console.WriteLine("Digite [enter] para finalizar");
Console.ReadLine();

static void LerCsvComOutroDelimitador()
{
      var path = Path.Combine(Environment.CurrentDirectory,"Entrada", "Livros-preco-com-virgula.csv");

    var fi = new FileInfo(path);

    if(!fi.Exists)
        throw new FileNotFoundException($"O arquivo {path} não existe!");

    using var sr = new StreamReader(fi.FullName);
    var csvConfig = new CsvConfiguration(CultureInfo.InvariantCulture)
    {
        Delimiter = ";"
    };

    using var csvReader = new CsvReader(sr, csvConfig);

    var registros = csvReader.GetRecords<Livro>().ToList();

    foreach (var registro in registros)
    {
        Console.WriteLine($"Título:{registro.Titulo}");
        Console.WriteLine($"Preço:{registro.Preco}");
        Console.WriteLine($"Autor:{registro.Autor}");
        Console.WriteLine($"Lançamento:{registro.Lancamento}");
        Console.WriteLine("---------------");
    }
}

static void LerCSVComClasse()
{
    var path = Path.Combine(Environment.CurrentDirectory,"Entrada", "novos-usuarios.csv");

    var fi = new FileInfo(path);

    if(!fi.Exists)
        throw new FileNotFoundException($"O arquivo {path} não existe!");
    
    using var sr = new StreamReader(fi.FullName);
    var csvConfig = new CsvConfiguration(CultureInfo.InvariantCulture);
    using var csvReader = new CsvReader(sr, csvConfig);

    var registros = csvReader.GetRecords<Usuario>();

    foreach (var registro in registros)
    {
        Console.WriteLine($"nome:{registro.Nome}");
        Console.WriteLine($"email:{registro.Email}");
        Console.WriteLine($"telefone:{registro.Telefone}");
        Console.WriteLine("---------------");
    }
}



static void LerCSVComDynamic()
{
    var path = Path.Combine(Environment.CurrentDirectory,"Entrada", "Produtos.csv");

    var fi = new FileInfo(path);

    if(!fi.Exists)
        throw new FileNotFoundException($"O arquivo {path} não existe!");

    using var sr = new StreamReader(fi.FullName);
    var csvConfig = new CsvConfiguration(CultureInfo.InvariantCulture);
    using var csvReader = new CsvReader(sr, csvConfig);

    var registros = csvReader.GetRecords<dynamic>();

    foreach (var registro in registros)
    {
        Console.WriteLine($"nome:{registro.Produto}");
        Console.WriteLine($"marca:{registro.Marca}");
        Console.WriteLine($"preco:{registro.Preco}");
        Console.WriteLine("---------------");
    }
}



