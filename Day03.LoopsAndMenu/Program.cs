bool isRunning = true;

while (isRunning)
{
    Console.WriteLine("===== DAY 3 - LOOPS AND MENU =====");
    Console.WriteLine("1. Bai 1 - Nhap n so nguyen");
    Console.WriteLine("2. Bai 2 - In bang cuu chuong");
    Console.WriteLine("3. Bai 3 - Quan ly danh sach ten");
    Console.WriteLine("0. Thoat");
    Console.Write("Chon bai: ");

    string choice = Console.ReadLine();

    switch (choice)
    {

        case "1":
    Console.WriteLine("===== BAI 1 - TONG, TRUNG BINH, SO LON NHAT =====");

    Console.Write("Nhap so luong so nguyen n: ");
    string nInput = Console.ReadLine();
    bool isValidN = int.TryParse(nInput, out int n);

    if (!isValidN || n <= 0)
    {
        Console.WriteLine("n khong hop le. n phai la so nguyen lon hon 0.");
        break;
    }

    int sum = 0;
    int max = 0;

    for (int i = 1; i <= n; i++)
    {
        Console.Write($"Nhap so thu {i}: ");
        string numberInput = Console.ReadLine();
        bool isValidNumber = int.TryParse(numberInput, out int number);

        if (!isValidNumber)
        {
            Console.WriteLine("Gia tri khong hop le. Vui long nhap lai bai nay.");
            break;
        }

        sum += number;

        if (i == 1 || number > max)
        {
            max = number;
        }

        if (i == n)
        {   
            double average = (double)sum / n;//Ép kiểu (double)sum / n 
            //để kết quả trung bình có phần thập phân, không bị chia nguyên.

            Console.WriteLine($"Tong: {sum}");
            Console.WriteLine($"Trung binh: {average}");
            Console.WriteLine($"So lon nhat: {max}");
        }
    }

    break;

        case "2":
    Console.WriteLine("===== BAI 2 - BANG CUU CHUONG =====");

    Console.Write("Nhap so nguyen can in bang cuu chuong: ");
    string multiplicationInput = Console.ReadLine();
    bool isValidMultiplicationNumber = int.TryParse(multiplicationInput, out int multiplicationNumber);

    if (!isValidMultiplicationNumber)
    {
        Console.WriteLine("So nhap vao khong hop le.");
        break;
    }

    for (int i = 1; i <= 10; i++)
    {
        int result = multiplicationNumber * i;
        Console.WriteLine($"{multiplicationNumber} x {i} = {result}");
    }

    break;

        case "3":
            Console.WriteLine("Ban da chon Bai 3.");
            break;

        case "0":
            Console.WriteLine("Tam biet!");
            isRunning = false;
            break;

        default:
            Console.WriteLine("Lua chon khong hop le.");
            break;
    }

    Console.WriteLine();
}
