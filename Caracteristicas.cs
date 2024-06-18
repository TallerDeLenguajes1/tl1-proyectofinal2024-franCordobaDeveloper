namespace CaracteristicasPersonaje
{
    public class Caracteristicas
    {
        private int velocidad; // 1 a 10
        private int destreza; // 1 a 5
        private int fuerza; // 1 a 10
        private int nivel; // 1 a 10
        private int armadura; // 1 a 10
        private readonly int salud; // 100

        // Constructor
        public Caracteristicas(int velocidad, int destreza, int fuerza, int nivel, int armadura)
        {
            this.velocidad = velocidad;
            this.destreza  = destreza;
            this.fuerza    = fuerza;
            this.nivel     = nivel;
            this.armadura  = armadura;
            this.salud     = 100;
        }
    }
}