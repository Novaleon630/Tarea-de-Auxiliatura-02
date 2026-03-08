using System.Diagnostics;

class ServidorMinercraft
{
    private int nroJugadores;
    private string[] nomJug = new string[20];
    private int[] diamaJug = new int[20];

    //estoy usando un constructor por defecto: 
    public ServidorMinercraft()
    {
        this.nroJugadores = 10;
        //nombre de cada jugador
        this.nomJug[0] = "juana";
        this.nomJug[1] = "Raul";
        this.nomJug[2] = "jeff";
        this.nomJug[3] = "anikilo";
        this.nomJug[4] = "johan";
        this.nomJug[5] = "max";
        this.nomJug[6] = "roma";
        this.nomJug[7] = "juan";
        this.nomJug[8] = "hunte";
        this.nomJug[9] = "jax";
        //nro de diamantes de cada jugador: 
        this.diamaJug[0] = 100;
        this.diamaJug[1] = 34;
        this.diamaJug[2] = 46;
        this.diamaJug[3] = 73;
        this.diamaJug[4] = 50;
        this.diamaJug[5] = 64;
        this.diamaJug[6] = 52;
        this.diamaJug[7] = 81;
        this.diamaJug[8] = 34;
        this.diamaJug[9] = 130;
    }
    public void mostrar()
    {
        System.Console.WriteLine("DATOS DE LOS JUGADORES");
        for (int i = 0; i < this.nroJugadores; i++)
        {
            System.Console.WriteLine($"{i + 1}. Nombre Jugador: {this.nomJug[i]}| Diamantes del jugador: {this.diamaJug[i]}| ");
        }
    }
    //a) crea un metodo para agregar un nuevo jugador al servidor
    public void agregarNuevoJuga(string nom, int dia)
    {
        this.nomJug[this.nroJugadores] = nom;
        this.diamaJug[this.nroJugadores] = dia;

        this.nroJugadores++;

    }

    //b)verificar cuantos stasck de diamante tiene cada jugador:
    public void verificarStacks()
    {
        //sabemos que un stack contiene 64 diamantes
        //entonces debemos revisar solo los jugadores que tienen 
        //mas diamantes o diamantes >=64
        for (int i = 0; i < this.nroJugadores; i++)
        {
            int stack = 0;

            if (this.diamaJug[i] >= 64)
            {
                int resto = this.diamaJug[i] - 64;
                this.diamaJug[i] -= resto;

                if (resto >= 64)
                {
                    resto = resto - 64;
                    stack++;
                }
                stack++;
                System.Console.WriteLine($"jugador: {this.nomJug[i]}, tiene {stack} |Stack| y {resto} diamantes...");
            }
        }

    }
    public void mostrarJugMayorDiaman()
    {
        int may = 0;
        int posicion = 0;
        for (int i = 0; i < diamaJug.Length; i++)
        {
            if (this.diamaJug[i] > may)
            {
                may = this.diamaJug[i];
                posicion = i;
            }
        }
        if (this.nroJugadores > 0)
        {
            System.Console.WriteLine("El jugador con más diamantes es: " + nomJug[posicion] + " con: " + may);
        }

    }
    //d) Mostrar el total de diamantes entre todos los jugadores
    public int totalDiamantes()
    {
        int total = 0;
        for (int i = 0; i < this.nroJugadores; i++)
        {
            total = diamaJug[i] + total;
        }
        return total;
        //System.Console.WriteLine("el total de diamantes de los jugadores: "+total);
    }

}