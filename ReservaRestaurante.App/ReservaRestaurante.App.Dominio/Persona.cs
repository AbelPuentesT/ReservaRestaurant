namespace ReservaRestaurante.App.Dominio
{
    public class Persona
    {
        /* public Persona(string Name, string LastName, int Age)
        {
            this.Name = Name;
            this.LastName = LastName;
            this.Age = Age;
        } */

        public int Id { get; set; }
        public int Cedula { get; set; }

        public string? Name { get; set; }

        public string? LastName { get; set; }

        public int Age { get; set; }
    }
}
