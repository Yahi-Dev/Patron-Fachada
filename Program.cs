namespace Fachada
{
    internal class Program
    {
        static void Main()
        {
            Fachada fachada = new Fachada();
            int opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("\n [1]Leon  \n [2]Gato  \n [3]Perro \n [4]Salir \n");
                Console.Write("Elige tu animal fav: ");
                opcion = int.Parse(Console.ReadLine());
               Factory factory = new Factory();
                factory.revolser(opcion);

            } while (opcion != 4);

        }
    }
}