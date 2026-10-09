namespace Factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Calculo del factorial del 0 al 10
            for (long contador = 0; contador < 10; contador++)
            {
                Console.WriteLine("{0}! = {1}", contador, Factorial(contador));
            }
            //fin del for
        }

        //declaracion recursiva del metodo Factorial
        public static long Factorial(long numero)
        {
            //caso base
            if (numero <= 1)
                return 1;
            //paso de recursividad
            else return numero * Factorial(numero - 1);
        }//fin del metodo Factorial

    }
}
