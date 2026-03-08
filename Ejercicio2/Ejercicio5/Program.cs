// See https://aka.ms/new-console-template for more information
ServidorMinercraft e1= new ServidorMinercraft();

//agregamos un nuevo jugador;
e1.agregarNuevoJuga("james",0);
e1.mostrar();

//total de diamantes
System.Console.WriteLine("total de los diamantes: "+e1.totalDiamantes()+"\n");
//verificamos al jugador con mas diamantes
e1.mostrarJugMayorDiaman();

//vemos cuantos stascks tiene cada jugador
e1.verificarStacks();


