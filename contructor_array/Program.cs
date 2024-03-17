namespace contructor_array
{
    class contructor_array
    {
        private int[] array;
        public int[] Array { get { return array; } set { array = value; } }
        public contructor_array(int[] array)
        {
            this.Array = array;
        }
        public void Print(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($" phan tu thu {i+1} la : {array[i]}");
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            int[] values = new int[] { 1, 2, 3 };
            contructor_array _Array = new contructor_array(values);
            _Array.Print(values);
            Console.ReadLine();
        }
    }
}
