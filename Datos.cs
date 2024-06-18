namespace DatosPersonajes
{
    public class Datos
    {
        private String tipo;

        private String nombre;
        
        private String apodo;

        private DateTime fechaNacimiento;

        private int edad; // 0 a 300
   

        public Datos(String tipo, String nombre, String apodo, DateTime fechaNacimiento, int edad)
        {
            this.tipo            = tipo;
            this.nombre          = nombre;
            this.apodo           = apodo;
            this.fechaNacimiento = fechaNacimiento;
            this.edad            = edad;

        }   
    }
}