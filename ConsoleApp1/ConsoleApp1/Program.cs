namespace ConsoleApp1
{
   public static class GeometryHelper
    {
        public static int Kvadrat(int a)
        {
            int S = a * a;
            Console.WriteLine(S);
            return S;
        }

        public static int Ucbucag(int a , int h) 
        {
            int S = h * a/2;
            Console.WriteLine(S);
            return S;        
        }

        public static decimal Daire (int r ,decimal p)
        {
            decimal S = p * (r * r);
            Console.WriteLine(S);
            return S;
        }

    }
    
    
    internal class Program
    {
        static void Main(string[] args)
        {
           GeometryHelper.Kvadrat(5);
            GeometryHelper.Ucbucag(2, 5);
            GeometryHelper.Daire(2, 3.14m);
            
        }
    }
}