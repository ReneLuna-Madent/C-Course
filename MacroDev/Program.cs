using System;

namespace nett.core3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables de Entorno y Conversion Primitivas

            // Numeros Enteros
            sbyte Ciclo = 120; // Numeros Enteros -+ 128
            short Hora = 30000;     // Numeros Enteros -+ 32767
            int Step = 10;    // -147483648 a 2147483647  

            // Variables de Precision (Decimal#)
            decimal Medida = 0.354565544M; ///decimal 28-29 digitos 128 bits // Se agrega M para no confunifr con double
            float Tolerancia = 8.012F;     ///float 7 digitos 32 bits // se agrega F para no confundir con otro tipo de variable 
            double Defect = 1.8;           //double 15-16 digitos 64 bits
            long Error = 1184681515146544; // Xn18

            // Otras variables 
            string Client = "Daimler"; //String es una clase no un dato primitivo
            bool evaluate = false;
            char locker = 'V'; // Almacena un caracter solmente se usacon '' ya que ""  solo para string
            string DateTime;

            ///Estructuras///
            Decimal EsMedida = 28.5M;
            Boolean EsValuate = true;
            Double esDefect = 2.1;

            int Model = Convert.ToInt16("30");

            //Writeline ejecuta la linea parecido a console.log
            Console.WriteLine(Client + "{0}{1}{2}", EsValuate, EsMedida, esDefect); // {..} acomoda variables en impresion acorde a un arreglo

            // Color de Consola 
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear(); //Limpia las ordenes de buffer 


            Console.WriteLine("////////////////////////////////////////////////|");
            Console.WriteLine("                Inicio de Macro:                |" +
                "              \n #Proceso {0} {1}                            |" +
                "\n Defecto Spec {1} {2} {3}                    | " +
                "\n Tolerancia +- Ex: {4} Permitida {5}  |", Model, Client, Defect, Step, Medida, Tolerancia);

            Console.WriteLine("////////////////////////////////////////////////|");
            Console.WriteLine("Press OP Key To Generate Macro {0}            |", evaluate);


            // Manejo de Variables 
            Console.Write("------------------Manejo de Variables-----------------\n");

            //Numeros
            int Error1 = 18;
            int Error2 = 20;
            int sum = Error1 + Error2;
            int ErroresA, ErroresB, ErroresC; // Se pueden declarar variables en continuo
            double Medida1 = 3.8;
            double Medida2 = 1.375;
            double Evaluate = Medida1 + Error2;
            Console.WriteLine("Numeros_________________________________________");
            Console.WriteLine("La Medida de " + Medida1 + "Con Error: \n " + Error2 + "Valor de Precaucion =  " + Evaluate);

            //texto 
            string MaterialA = "Bujia";
            string Faltante = "Material Faltante: " + MaterialA;
            string Norma = Faltante.ToUpper();
            Console.WriteLine("Texto___________________________________________");
            Console.WriteLine(Norma);
            //Console.Read();


            //Conversione s


            Console.Write("-----------Conversion Explicita(casting)----------------");

            double Torque = 14.5;
            int redondeoTorque;

            redondeoTorque = (int)Torque;
            Console.WriteLine(redondeoTorque);
            //Conversion Implicita
            int num = 123456;
            long numg = num;
            float Flotante = 133.89F;
            double miFlotante = Flotante;
            Console.WriteLine(numg);
            Console.WriteLine(miFlotante);
            //Conversion de Tipo 
            double newDouble = miFlotante;
            string Modelo21 = miFlotante.ToString();
            Console.WriteLine(Modelo21);
            bool elsolbrilla = true;
            string elsolbrilla2 = elsolbrilla.ToString();
            Console.Write("-----------Parsing----------------");
            //Transformar String a numericos Parsing 
            string denominacion = "96";
            string denominacion2 = "69";
            string resultado = denominacion + denominacion2;
            Console.WriteLine(resultado); //concatena igual que py
            int resultadoNumber = Int32.Parse(denominacion);
            int resultadoNumber2 = Int32.Parse(denominacion2);
            int totalnumber = resultadoNumber + resultadoNumber2;
            Console.WriteLine(totalnumber);
            Console.Read(); //evita cerrar la consola
        }

        public void Conversion(string[] args)
        {
            

        }

        

    }          
        
}