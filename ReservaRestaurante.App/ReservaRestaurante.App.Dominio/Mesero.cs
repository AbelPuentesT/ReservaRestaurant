namespace ReservaRestaurante.App.Dominio
{
    public class Mesero:Persona
    {
        public Mesero(string name, string lastName,int age,int cedula)
        {
            Name = name;
            LastName = lastName;
            Age = age;
            Cedula = cedula;
        }
    }
}