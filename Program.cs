using System;

namespace PracticasInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {

            Caballo miBabieca = new Caballo("babieca");

            Humano miJuan = new Humano("Juan");

            Gorila miCopito = new Gorila("Copito");

            Mamiferos animal = new Mamiferos("Bucefalo");

            Caballo Bucefalo = new Caballo("Bucefalo");

            animal = Bucefalo;

            Mamiferos[] almacenAnimales = new Mamiferos[3];

            almacenAnimales[0] = miBabieca;
            almacenAnimales[1] = miJuan;
            almacenAnimales[2] = miCopito;

            almacenAnimales[1].GetNombre();

            for (int i = 0; i < 3; i++)
            {

                almacenAnimales[i].Pensar();

            }

            Mamiferos miMamifero = new Mamiferos("");

            miMamifero.Respirar();


            miJuan.GetNombre();

            miBabieca.GetNombre();

            miCopito.GetNombre();

            Ballena miWally = new Ballena("Wally");

            miWally.Nadar();

            Console.WriteLine("Numero de patas de babieca: " + miBabieca.NumeroPatas());

        }
    }

    //Decalracion de INTERFACES.
interface IMamiferosTerrestres
    {

        int NumeroPatas();

    }

interface IAnimalesYDeportes
    {
        string TipoDeporte();

        Boolean EsOlimpico();
    }

interface ISaltoConPatas
    {

        int NumeroPatas();

    }

    class Mamiferos : Object
    {
        public Mamiferos(String nombre)
        {

            nombreSerVivo = nombre;

        }

        public void Respirar()
        {

            Console.WriteLine("Soy capaz de respirar");

        }

        public virtual void Pensar()
        {

            Console.WriteLine("Pensamiento básico instintivo");

        }

        public void CuidarCrias()
        {

            Console.WriteLine("Cuido de mis crias hasta que se valgan por si mismas");

        }

        public void GetNombre()
        {

            Console.WriteLine("El nombre del ser vivo es: " + nombreSerVivo);

        }

        private String nombreSerVivo;
    }

    class Ballena: Mamiferos
    {

        public Ballena(String nombreBallena) : base(nombreBallena)
        {



        }

        public void Nadar()
        {
            Console.WriteLine("Soy capaz de nadar");
        }

    }

    class Caballo : Mamiferos, IMamiferosTerrestres, IAnimalesYDeportes, ISaltoConPatas
    {

        public Caballo(String nombreCaballo) : base(nombreCaballo)
        {



        }

        public void Galopar()
        {
            Console.WriteLine("Soy capaz de galopar");
        }

        public int NumeroPatas()
        {

            return 4;

        }

        public string TipoDeporte()
        {

            return "Hípica";

        }

        public Boolean EsOlimpico()
        {
            return true;
        }

        
    }

    class Humano : Mamiferos
    {
        public Humano(String nombreHumano) : base(nombreHumano)
        {



        }
        public override void Pensar()
        {

            Console.WriteLine("Soy capaz de pensar ¿?");

        }
    }

    class Gorila : Mamiferos, IMamiferosTerrestres
    {
        public Gorila(String nombreGorila) : base(nombreGorila)
        {



        }

        public override void Pensar()
        {

            Console.WriteLine("Pensamiento instintivo avanzado");

        }
        public void Trepar()
        {

            Console.WriteLine("Soy capaz de trepar");

        }

        public int NumeroPatas()
        {

            return 4;

        }

    }

}