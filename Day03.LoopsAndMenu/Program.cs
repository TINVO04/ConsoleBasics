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
            Console.WriteLine("Ban da chon Bai 1.");
            break;

        case "2":
            Console.WriteLine("Ban da chon Bai 2.");
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
