bool isRunning = true;

while (isRunning)
{
    Console.WriteLine("===== DAY 5 - WEEK 1 REVIEW =====");
    Console.WriteLine("1. Bai test 1 - Tinh hoa don co giam gia theo loai khach hang");
    Console.WriteLine("2. Bai test 2 - Quan ly sinh vien bang List");
    Console.WriteLine("3. Bai test 3 - Refactor code va dat ten bien ro rang");
    Console.WriteLine("0. Thoat");
    Console.Write("Chon bai: ");

    string choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            RunInvoiceDiscountTest();
            break;

        case "2":
            RunStudentManagementTest();
            break;

        case "3":
            RunRefactorReviewTest();
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

static void RunInvoiceDiscountTest()
{
    Console.WriteLine("===== BAI TEST 1 - TINH HOA DON GIAM GIA =====");

    Console.Write("Nhap ten khach hang: ");
    string customerName = Console.ReadLine();

    if (string.IsNullOrWhiteSpace(customerName))
    {
        Console.WriteLine("Ten khach hang khong duoc de trong.");
        return;
    }

    Console.Write("Nhap tong tien hoa don: ");
    string totalAmountInput = Console.ReadLine();

    bool isValidTotalAmount = decimal.TryParse(totalAmountInput, out decimal totalAmount);

    if (!isValidTotalAmount || totalAmount <= 0)
    {
        Console.WriteLine("Tong tien hoa don phai la so lon hon 0.");
        return;
    }

    Console.WriteLine("Chon loai khach hang:");
    Console.WriteLine("1. Thuong - Giam 0%");
    Console.WriteLine("2. Bac - Giam 5%");
    Console.WriteLine("3. Vang - Giam 10%");
    Console.WriteLine("4. Kim cuong - Giam 15%");
    Console.Write("Nhap loai khach hang: ");

    string customerType = Console.ReadLine();

    decimal discountRate;
    string customerTypeName;

    switch (customerType)
    {
        case "1":
            customerTypeName = "Thuong";
            discountRate = 0m;
            break;

        case "2":
            customerTypeName = "Bac";
            discountRate = 0.05m;
            break;

        case "3":
            customerTypeName = "Vang";
            discountRate = 0.10m;
            break;

        case "4":
            customerTypeName = "Kim cuong";
            discountRate = 0.15m;
            break;

        default:
            Console.WriteLine("Loai khach hang khong hop le.");
            return;
    }

    decimal discountAmount = totalAmount * discountRate;
    decimal finalAmount = totalAmount - discountAmount;

    Console.WriteLine("===== KET QUA HOA DON =====");
    Console.WriteLine($"Khach hang: {customerName.Trim()}");
    Console.WriteLine($"Loai khach hang: {customerTypeName}");
    Console.WriteLine($"Tong tien ban dau: {totalAmount}");
    Console.WriteLine($"Ti le giam gia: {discountRate * 100}%");
    Console.WriteLine($"So tien duoc giam: {discountAmount}");
    Console.WriteLine($"So tien can thanh toan: {finalAmount}");
}

static void RunStudentManagementTest()
{
    Console.WriteLine("Ban da chon Bai test 2 - Quan ly sinh vien bang List.");
}

static void RunRefactorReviewTest()
{
    Console.WriteLine("Ban da chon Bai test 3 - Refactor code va dat ten bien ro rang.");
}
