Console.WriteLine("===== DAY 1 - CONSOLE BASICS =====");
Console.WriteLine("1. Bai 1 - In thong tin ca nhan");
Console.WriteLine("2. Bai 2 - Tinh tong tien san pham");
Console.Write("Chon bai: ");

string choice = Console.ReadLine();

if (choice == "1")
{
    Console.WriteLine("===== THONG TIN CA NHAN =====");
    Console.WriteLine("Ho ten: Nguyen Van A");
    Console.WriteLine("Nam sinh: 2003");
    Console.WriteLine("Truong/Lop: Nam 3 dai hoc");
    Console.WriteLine("Muc tieu: Hoc tot C# va .NET");
    Console.WriteLine("Ngay hoc: Day 1 - Console Basics");
}
else if (choice == "2")
{
    Console.WriteLine("===== TINH TONG TIEN SAN PHAM =====");

    Console.Write("Nhap ten san pham: ");
    string productName = Console.ReadLine();

    Console.Write("Nhap so luong: ");
    string quantityInput = Console.ReadLine();
    bool isValidQuantity = int.TryParse(quantityInput, out int quantity);

    if (!isValidQuantity || quantity <= 0)
    {
        Console.WriteLine("So luong khong hop le. Vui long nhap so nguyen lon hon 0.");
        return;
    }

    Console.Write("Nhap don gia: ");
    string priceInput = Console.ReadLine();
    bool isValidPrice = decimal.TryParse(priceInput, out decimal price);

    if (!isValidPrice || price <= 0)
    {
        Console.WriteLine("Don gia khong hop le. Vui long nhap so lon hon 0.");
        return;
    }

    decimal total = quantity * price;

    Console.WriteLine("===== HOA DON =====");
    Console.WriteLine($"Ten san pham: {productName}");
    Console.WriteLine($"So luong: {quantity}");
    Console.WriteLine($"Don gia: {price}");
    Console.WriteLine($"Tong tien: {total}");
}
else
{
    Console.WriteLine("Lua chon khong hop le.");
}
