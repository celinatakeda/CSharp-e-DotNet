using CsvHelper.Configuration.Attributes;
public class Livro
{
    //[Index(0)] // quando não tem titulo
    //[Name("titulo")]
    public string Titulo { get; set; }
    //[Index(2)]
    //[Name("autor")]
    public string Autor { get; set; }
    //[Index(1)]
    //[Name("preço")]
    //[CultureInfo("pt-BR")]
    public decimal Preco { get; set; }
    //[Index(3)]
    //[Name("lançamento")]
    //[Format("dd/MM/yyyy")]
    public DateOnly Lancamento { get; set; }   
}