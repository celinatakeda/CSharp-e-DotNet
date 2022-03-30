namespace Classes.Herança
{
    public class Ponto3D : Ponto  // só pode herdar de uma única classe
    {
        public int z;
        public Ponto3D(int x, int y, int z) : base(x, y)
        {
            this.z = z;
            CalcularDistancia();
        }

        public static void Calcular()
        {
            //faz alguma coisa...
        }

        public override void CalcularDistancia3()
        {
            //faz alguma coisa...
            base.CalcularDistancia3();
        }
    }
}