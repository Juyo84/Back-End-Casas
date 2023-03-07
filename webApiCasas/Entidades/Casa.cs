namespace webApiCasas.Entidades
{
    public class Casa
    {

        public int Id { get; set; }

        public string Direccion { get; set; }

        public float Precio { get; set;}

        public int DueñoID { get; set; }

        public Dueño Dueño { get; set; }

    }
}
