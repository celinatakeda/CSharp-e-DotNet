namespace Classes.dotMetodos
{
    public class Ref
    {
        static void Inverter(ref int x, ref int y) // recebido por referência
        {
            int temp = x;
            x = y;
            y = temp;
        }

        public static void Inverter()
        {
            int i = 1, j = 2;
            Inverter(ref i, ref j); // passando a variável por referência e não por valor
            System.Console.WriteLine($"{i} = {j}"); // Escreve "2 1"
        }
    }
}