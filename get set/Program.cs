namespace get_set
{
    public class test
    {
        // có 4 cách get set
        // 1. ghi trực tiếp
        public bool isset { get; set; }
        public bool issethide { get; private set; }
        //2. trả về giá trị của biến private 
        private bool _is;
        public bool isSet
        {
            get
            {
                return _is;
            }
            set
            {
                isset = value;
            }
        }
        // 3.dùng lambda để get set 
        private bool s;
        public bool S { get => s; set => s = value; }
        // 4. nếu chỉ có get
        private bool e;
        public bool V => e;

    }
    internal class Program
    {
        
        static void Main(string[] args)
        {
            
        }
    }
}
