using Microsoft.EntityFrameworkCore;
using ReservaRestaurante.App.Dominio;
using ReservaRestaurante.App.Persistencia;
using ReservaRestaurante.App.Persistencia.Context;
Contexto context = new Contexto();
bool cont =true;
while(cont)
{
    Console.WriteLine("Reserva Restaurante");
    Console.WriteLine("1. Ingresar Cliente ");
    Console.WriteLine("2. Ingresar Mesero");
    Console.WriteLine("3. Ingresar mesa");
    Console.WriteLine("4. Reserva");
    Console.WriteLine("5. Consultar Clientes");
    Console.WriteLine("6. Consultar Meseros");
    Console.WriteLine("7. Consultar Mesas");
    Console.WriteLine("8. Consultar Reservas");
    Console.WriteLine("9. Salir");
    int opcion=Convert.ToInt32(Console.ReadLine());
    switch (opcion)
    {
        case 1:
            Console.WriteLine("Ingrese cedula de cliente");
            int cedula = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese nombre de cliente");
            string? nombre = Console.ReadLine();
            Console.WriteLine("Ingrese Apellido de cliente");
            string? apellido = Console.ReadLine();
            Console.WriteLine("Ingrese edad de cliente");
            int edad = Convert.ToInt32(Console.ReadLine());
            Cliente cliente1 = new Cliente(nombre,apellido,edad,cedula);//Cliente
            context.Add(cliente1);
            try{
            context.SaveChanges();
            }catch(Exception e){
            Console.WriteLine("Mensaje de error: "+e.Message);
            }
        break;

        case 2:
            Console.WriteLine("Ingrese cedula de mesero");
            cedula = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese nombre de mesero");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese Apellido de mesero");
            apellido = Console.ReadLine();
            Console.WriteLine("Ingrese edad de mesero");
            edad = Convert.ToInt32(Console.ReadLine());
            Mesero mesero1 = new Mesero(nombre,apellido,edad,cedula);//Cliente
            context.Add(mesero1);
            try{
            context.SaveChanges();
            }catch(Exception e){
            Console.WriteLine("Mensaje de error: "+e.Message);
            }
        break;

        case 3:
            Console.WriteLine("Ingrese numero de mesa");
            int mesa = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese ubicacion ");
            string? ubicacion = Console.ReadLine();
            Console.WriteLine("Ingrese categoria ");
            string? categoria = Console.ReadLine();
            Mesa mesa1=new Mesa(mesa,ubicacion,categoria);
            context.Add(mesa1);
            try{
            context.SaveChanges();
            }catch(Exception e){
            Console.WriteLine("Mensaje de error: "+e.Message);
            }
        break;

        case 4:
        Console.WriteLine("Ingrese cedula de cliente");
        cedula = Convert.ToInt32(Console.ReadLine());
        Cliente clienteC = context.Clientes.Where(c=>c.Cedula==cedula).Single();
        try{
            Console.WriteLine(clienteC.Name + " " + clienteC.LastName);
            }catch(Exception e){
            Console.WriteLine("Mensaje de error: "+e.Message);
            }
        Console.WriteLine("Ingrese cedula de mesero");
        cedula = Convert.ToInt32(Console.ReadLine());
        Mesero meseroC = context.Meseros.Where(c=>c.Cedula==cedula).Single();
        try{
            Console.WriteLine(meseroC.Name + " " + meseroC.LastName);
            }catch(Exception e){
            Console.WriteLine("Mensaje de error: "+e.Message);
            }
        Console.WriteLine("Ingrese numero de mesa");
        int numero = Convert.ToInt32(Console.ReadLine());
        Mesa mesaC = context.Mesas.Where(c=>c.numero==numero).Single();
        try{
            Console.WriteLine(mesaC.numero + " " + mesaC.ubicacion);
            }catch(Exception e){
            Console.WriteLine("Mensaje de error: "+e.Message);
            }
            Console.WriteLine("Ingrese Año de la reserva");
            int año = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese mes de la reserva");
            int mes = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese dia de la reserva");
            int dia = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese Hora de la reserva");
            int hora = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese minuto de la reserva");
            int minuto = Convert.ToInt32(Console.ReadLine());
            DateTime fechaC =new DateTime (año,mes,dia,hora,minuto,0);
            context.SaveChanges();
            Reserva myReserva = new Reserva (){
                cliente=clienteC,
                mesero=meseroC,
                mesa=mesaC,
                fecha=fechaC
            };
            context.Add(myReserva);
            context.SaveChanges();
        break;

        case 5:
        var consultaClientes = context.Clientes;
        foreach (var c in consultaClientes) Console.WriteLine("Nombre: "+c.Name+", Apellido: "+c.LastName);
        break;

        case 6:
        var cosultaMesero = context.Meseros;
        foreach (var c in cosultaMesero) Console.WriteLine("Nombre: "+c.Name+", Apellido: "+c.LastName);
        break;

        case 7:
        var consultaMesas = context.Mesas;
        foreach (var c in consultaMesas) Console.WriteLine("Mesa numero: "+c.numero+", Ubicacion: "+c.ubicacion);
        break;
        case 8:
        var consultaReservas = context.Reservas.Include("cliente").Include("mesero").Include("mesa");
        foreach (var c in consultaReservas)
        {
        Console.WriteLine("Reserva a nombre de: "+c.cliente.Name+" "+c.cliente.LastName+" ,con mesero: "+c.mesero.Name+" "+c.mesero.LastName+" en mesa numero: "+c.mesa.numero+" categoria "+c.mesa.categoria+" con fecha: "+c.fecha);
        }
        break;

        case 9:
            Console.WriteLine("Programa terminado");
            cont = false;
        break;
        default:
            Console.WriteLine("Opcion no valida");
            break;
    }
}







