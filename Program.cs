using System;

namespace POO5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int op = 0;
            bool intentar = false;
            Coches ferrari = new Coches();
            ferrari.setInfoExtraCoches("Cuero", false);
            Coches mercedes = new Coches(0);
            mercedes.setInfoExtraCoches("Cuero o tela", true);
            Coches corvette = new Coches(0, 0);
            corvette.setInfoExtraCoches("Cuero", true);
            Console.WriteLine("Elija un coche para ver sus propiedades \nPresione (1) para ver las propiedades del Ferrari" +
                "\nPresione (2) para ver las propiedades del Mercedes \nPresione (3) para ver las propiedades del Corvette");


            while (!intentar)
            {
                try
                {
                    op = Convert.ToInt32(Console.ReadLine());
                    if (op == 1)
                    {
                        Console.WriteLine(ferrari.getCoche());
                        Console.WriteLine(ferrari.getInfoExtraCoche());
                    }
                    else if (op == 2)
                    {
                        Console.WriteLine(mercedes.getCoche());
                        Console.WriteLine(mercedes.getInfoExtraCoche());
                    }
                    else if (op == 3)
                    {
                        Console.WriteLine(corvette.getCoche());
                        Console.WriteLine(corvette.getInfoExtraCoche());
                    }

                    else throw new Exception();
                    intentar = true;

                }
                catch (Exception ex)
                {
                    Console.WriteLine("-----------------------------------------------------------");
                    Console.WriteLine("ERROR:");
                    Console.WriteLine("Haz cometido una excepción al elegir la opción");
                    Console.WriteLine("Tipo de excepción: " + ex.Message);
                    Console.WriteLine("Vuelva a intentarlo");
                    Console.WriteLine("-----------------------------------------------------------");
                    Console.WriteLine("\nElija un coche para ver sus propiedades \nPresione (1) para ver las propiedades del Ferrari" +
                "\nPresione (2) para ver las propiedades del Mercedes \nPresione (3) para ver las propiedades del Corvette");

                    intentar = false;
                }

            }
            Console.ReadKey();
        }
    }

    class Coches
    {
        private String modelo, color, tapiceria;
        private int potencia, peso, añoF;
        private bool climatizador;

        public Coches()
        {
            modelo = "Ferrari F40";
            color = "Rojo";
            peso = 1100;
            potencia = 478;
            añoF = 1989;
        }
        public Coches(int nulo = 0)
        {
            modelo = "Mercedes-Benz E-Class 300E Sedan";
            color = "Negro, blanco, plata, azul, entre otros.";
            peso = 1500;
            potencia = 177;
            añoF = 1992;
        }
        public Coches(int nulo = 0, int nulo2 = 0)
        {
            modelo = "40th Anniversary Special Edition Corvette Ruby Red";
            color = "Rojo Rubi";
            peso = 1450;
            potencia = 300;
            añoF = 1993;
        }

        public string getCoche()
        {
            return "Información del carro: \n" + "Modelo: " + modelo + "\nPotencia: " + potencia +
                " caballos de fuerzas" + "\nPeso: " + peso + " Kg" + "\nColor: " + color +
                "\nAño de fabricación: " + añoF;
        }
        public void setInfoExtraCoches(String tapiceria, bool climatizador)
        {
            this.tapiceria = tapiceria;
            this.climatizador = climatizador;
        }
        public String getInfoExtraCoche()
        {
            return "\nInformación Extra del coche: \n" + "Tapicería: " + tapiceria + "\nClimatizador: " + climatizador;
        }

    }
}