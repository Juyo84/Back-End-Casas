﻿namespace webApiCasas.Entidades
{
    public class Dueño
    {

        public int Id { get; set; }

        public string Nombre { get; set;}

        public string Apellido { get; set;}

        public int Edad { get; set;}

        public List<Casa> casas { get; set;}

    }
}
