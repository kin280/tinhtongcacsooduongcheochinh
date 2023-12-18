class Program
{
    static void Main()
    {
       

      

        Console.WriteLine("nhap hang cua ma tran");
        int rows = int.Parse(Console.ReadLine());

        Console.WriteLine("nhap cot cua ma tran");
        int cols = int.Parse(Console.ReadLine());

        double[,] matran1 = new double[rows, cols];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.WriteLine($"nhap gia tri phan tu o hang {i + 1},cot {j + 1}:");
                matran1[i, j] = double.Parse(Console.ReadLine());

            }

        }
        Console.WriteLine("mang dc tao tu nhap lieu: ");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0 ; j < cols; j++)
            {

                Console.Write(matran1[i, j] + " ");


            }
            Console.WriteLine();
        }

        double tinhtong = 0;
        for (int i = 0; i < matran1.GetLength(0); i++)
        {
            for (int j = 0; j < matran1.GetLength(1); j++)
            {
                tinhtong += matran1[i, j];
            }
        }

        Console.WriteLine("tong cac phan tu cua ma tran la: " + tinhtong);


    }

}