namespace ReservaRestaurante.App.Dominio
{
    public class Cliente:Persona
    {
        public Cliente(string name, string lastName, int age,int cedula)
        {
            Name = name;
            LastName = lastName;
            Age = age;
            Cedula = cedula;
        }
    }
}