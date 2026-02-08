namespace esercizio7StringeFunzioni
{
    internal class Program
    {
        static int es7(string parola, char lettera)
        {
            char[] lettere = parola.ToCharArray();

            int l = 0;

            for (int i = 0; i < lettere.Length; i++)
            {
                if (lettere[i] == lettera)
                {
                    l++;
                }
            }
            return l;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Dimmi una parola");
            string parola = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Dimmi una lettera nella parola");
            char lettera = Convert.ToChar(Console.ReadLine());

            Console.WriteLine(es7(parola, lettera));
        }
    }
}
