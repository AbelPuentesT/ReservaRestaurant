namespace ReservaRestaurante.App.Dominio
{
    public class Mesa
    {
        public Mesa(int numero, string ubicacion, string categoria)
        {
            this.numero = numero;
            this.ubicacion = ubicacion;
            this.categoria = categoria;
        }

        public int Id { get; set; }

        public int numero { get; set; }

        public string ubicacion { get; set; }

        public string categoria { get; set; }
    }
}
