using System;

//TODO:Complete os espaços em branco com uma possível solução para o problema.
class Desafio {
    static void Main() {
        var chico = 300 * Int32.Parse(Console.ReadLine());
        var bento = 1500 * Int32.Parse(Console.ReadLine());
        var bernardo = 600 * Int32.Parse(Console.ReadLine());
        var marina = 1000 * Int32.Parse(Console.ReadLine());
        var iara =  150 * Int32.Parse(Console.ReadLine());
        var marlene = 225;
        var total = chico + bento + bernardo + marina + iara + marlene;
        Console.WriteLine(total);
    }
}