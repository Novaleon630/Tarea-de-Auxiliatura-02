using System.Runtime.InteropServices;

class Bus
{
    private int nroPasajero;
    private int nroAsientos;
    private double CostoPasaje;

    public Bus(int nP, int nA, double cosPas)
    {
        this.nroAsientos = nA;

        if (nP <= nA)
        {
            this.nroPasajero = nP;
        }
        else
        {
            this.nroPasajero = 0;
        }
        if (cosPas >= 1)
        {
            this.CostoPasaje = cosPas;
        }
        else
        {
            this.CostoPasaje = 1;
        }
    }
    public override string ToString()
    {
        return $"| Numero de pasajeros: {this.nroPasajero}| Numero de asientos: {this.nroAsientos}| Pasaje: {this.CostoPasaje}|";
    }
    //c) Muestra cuántos asientos quedan disponibles.
    public int asientosDisponibles()
    {
        return this.nroAsientos - this.nroPasajero;
    }
    //a) Al bus desean subir X cantidad de pasajeros, actualiza los datos del bus
    public void subirXCantidadPasa(int subiendo)
    {

        //primero vemos los asientos disponibles
        int disponible = asientosDisponibles();

        if (disponible >= subiendo)
        {
            this.nroPasajero += subiendo;
            System.Console.WriteLine("se subieron: " + subiendo + " Personas... total de pasajeros actuales: " + this.nroPasajero + "\n");
        }
        else
        {
            System.Console.WriteLine("se exede la cantidad de pasajeros... solo pueden subirse: " + asientosDisponibles() + " pasajeros\n");

        }
    }
    //b) Crea un método para cobrar pasaje a los pasajeros. (Costo del pasaje: bs. 1.50)
    public string cobrarPasajeTotal()
    {
        return (this.nroPasajero * this.CostoPasaje) + " bs";
    }
}