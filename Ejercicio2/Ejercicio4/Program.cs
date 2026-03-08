// See https://aka.ms/new-console-template for more information
//d) Crea una instancia del bus y utiliza los métodos de los incisos anteriores.

Bus b2= new Bus(31,40,2.5);

System.Console.WriteLine(b2+"\n");

//subiendo personas al bus;
b2.subirXCantidadPasa(3);

//cobrando los pasajes del autobus: 
System.Console.WriteLine("total del pasaje de todas las personas: "+b2.cobrarPasajeTotal()+"\n");

//asientos disponibles en total: 
System.Console.WriteLine("total de asientos disponibles del bus: "+b2.asientosDisponibles()+"\n");

