namespace flower_bed
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] flowerbed1 = { 1, 0, 0, 0,1 };
            int n1 = 1;
            Console.WriteLine(Canplaceflower(flowerbed1,n1));
            int[] flowerbed2 = { 1, 0, 0, 0, 1 };
            int n2 = 2;
            Console.WriteLine(Canplaceflower(flowerbed2,n2));
        }


        public static bool Canplaceflower(int[] flowerbed , int n) 
        {
            int count = 0;  
            for (int i = 0; i < flowerbed.Length; i++) 
            {
                if (flowerbed[i] == 0 && (i == 0 || flowerbed[i -1 ] == 0) && (i == flowerbed.Length-1 || flowerbed[i + 1] == 0))
                {
                    flowerbed[i] = 1; count++;
                    if (count >= n) return true;
                }
            }
            return false;
        }
    }
}
