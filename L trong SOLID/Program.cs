namespace L_trong_SOLID
{
    abstract class SquareShape
    {
        public abstract void DrawSquare();
    }

    class CircleShape
    {
        public virtual void DrawCircle()
        {
            // Triển khai vẽ hình tròn
        }
    }
    // thêm phương thức vào lớp con để lớp con có thể thêm mà ko biến đổi cấu trúc
    class Square : SquareShape
    {
        public override void DrawSquare()
        {
            // Triển khai vẽ hình vuông
        }

        public void DienTich()
        {
            // Triển khai tính diện tích hình vuông
        }
    }

    class Circle : CircleShape
    {
        public override void DrawCircle()
        {
            base.DrawCircle();
            // Triển khai vẽ hình tròn
            xuat();
        }
        public void xuat() 
        {
            // triển khai phương thức xuất 
        }
    }

    class CircleSpecial : Circle
    {
        public void Nhap()
        {
            // Triển khai phương thức nhập
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            SquareShape square = new Square();
            square.DrawSquare(); // Gọi phương thức vẽ hình vuông

            CircleShape circle = new Circle();
            circle.DrawCircle(); // Gọi phương thức vẽ hình tròn
            
            CircleSpecial circle1 = new CircleSpecial();
            circle1.Nhap();
            // ...
        }
    }
}