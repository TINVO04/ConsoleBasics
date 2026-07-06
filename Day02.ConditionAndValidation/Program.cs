Console.WriteLine("===== DAY 2 - CONDITION AND VALIDATION =====");
Console.WriteLine("1. Bai 1 - Tinh diem trung binh va xep loai sinh vien");
Console.WriteLine("2. Bai 2 - Tinh hoa don co giam gia");
Console.WriteLine("3. Bai 3 - Tinh giam gia theo loai khach hang");
Console.Write("Chon bai: ");

string choice = Console.ReadLine();

if (choice == "1")
{
    Console.WriteLine("===== BAI 1 - TINH DIEM TRUNG BINH =====");

    Console.Write("Nhap diem Toan: ");
    string mathInput = Console.ReadLine();
    bool isValidMath = double.TryParse(mathInput, out double mathScore);

    if (!isValidMath || mathScore < 0 || mathScore > 10)
    {
        Console.WriteLine("Diem Toan khong hop le. Diem phai nam trong khoang 0 den 10.");
        return;
    }

    Console.Write("Nhap diem Van: ");
    string literatureInput = Console.ReadLine();
    bool isValidLiterature = double.TryParse(literatureInput, out double literatureScore);

    if (!isValidLiterature || literatureScore < 0 || literatureScore > 10)
    {
        Console.WriteLine("Diem Van khong hop le. Diem phai nam trong khoang 0 den 10.");
        return;
    }

    Console.Write("Nhap diem Anh: ");
    string englishInput = Console.ReadLine();
    bool isValidEnglish = double.TryParse(englishInput, out double englishScore);

    if (!isValidEnglish || englishScore < 0 || englishScore > 10)
    {
        Console.WriteLine("Diem Anh khong hop le. Diem phai nam trong khoang 0 den 10.");
        return;
    }

    double averageScore = (mathScore + literatureScore + englishScore) / 3;

    string rank;

    if (averageScore >= 8)
    {
        rank = "Gioi";
    }
    else if (averageScore >= 6.5)
    {
        rank = "Kha";
    }
    else if (averageScore >= 5)
    {
        rank = "Trung binh";
    }
    else
    {
        rank = "Yeu";
    }

    Console.WriteLine("===== KET QUA =====");
    Console.WriteLine($"Diem Toan: {mathScore}");
    Console.WriteLine($"Diem Van: {literatureScore}");
    Console.WriteLine($"Diem Anh: {englishScore}");
    Console.WriteLine($"Diem trung binh: {averageScore}");
    Console.WriteLine($"Xep loai: {rank}");
}
else if (choice == "2")
{

// Tổng tiền = Số lượng * Đơn giá
// Tiền giảm = Tổng tiền * Phần trăm giảm
// Tiền phải trả = Tổng tiền - Tiền giảm

// Tổng tiền >= 1,000,000  -> giảm 10%
// Tổng tiền >= 500,000    -> giảm 5%
// Tổng tiền < 500,000     -> không giảm

// kiểm tra từ cao xuống thấp:
// >= 1,000,000 trước
// >= 500,000 sau

    Console.WriteLine("===== BAI 2 - TINH HOA DON CO GIAM GIA =====");

    Console.Write("Nhap ten san pham: ");
    string productName = Console.ReadLine();

    if (string.IsNullOrWhiteSpace(productName))
    {
        Console.WriteLine("Ten san pham khong duoc de trong.");
        return;
    }

    Console.Write("Nhap so luong: ");
    string quantityInput = Console.ReadLine();
    bool isValidQuantity = int.TryParse(quantityInput, out int quantity);

    if (!isValidQuantity || quantity <= 0)
    {
        Console.WriteLine("So luong khong hop le. So luong phai la so nguyen lon hon 0.");
        return;
    }

    Console.Write("Nhap don gia: ");
    string priceInput = Console.ReadLine();
    bool isValidPrice = decimal.TryParse(priceInput, out decimal price);

    if (!isValidPrice || price <= 0)
    {
        Console.WriteLine("Don gia khong hop le. Don gia phai lon hon 0.");
        return;
    }

    decimal totalAmount = quantity * price;
    decimal discountPercent;

    if (totalAmount >= 1000000)
    {
        discountPercent = 0.10m;
    }
    else if (totalAmount >= 500000)
    {
        discountPercent = 0.05m;// m là kiểu số deximal Vì discountPercent, totalAmount, discountAmount 
        //là tiền/tỷ lệ tính với decimal, nên viết 0.10m thay vì 0.10.
    }
    else
    {
        discountPercent = 0m;
    }

    decimal discountAmount = totalAmount * discountPercent;
    decimal finalAmount = totalAmount - discountAmount;

    Console.WriteLine("===== HOA DON =====");
    Console.WriteLine($"Ten san pham: {productName}");
    Console.WriteLine($"So luong: {quantity}");
    Console.WriteLine($"Don gia: {price}");
    Console.WriteLine($"Tong tien: {totalAmount}");
    Console.WriteLine($"Phan tram giam gia: {discountPercent * 100}%");
    Console.WriteLine($"Tien giam: {discountAmount}");
    Console.WriteLine($"Tien phai tra: {finalAmount}");
}
else if (choice == "3")
{
    Console.WriteLine("===== BAI 3 - GIAM GIA THEO LOAI KHACH HANG =====");

    Console.Write("Nhap ten khach hang: ");
    string customerName = Console.ReadLine();

    if (string.IsNullOrWhiteSpace(customerName))
    {
        Console.WriteLine("Ten khach hang khong duoc de trong.");
        return;
    }

    Console.Write("Nhap tong tien hoa don: ");
    string billInput = Console.ReadLine();
    bool isValidBill = decimal.TryParse(billInput, out decimal billAmount);

    if (!isValidBill || billAmount <= 0)
    {
        Console.WriteLine("Tong tien hoa don khong hop le. Tong tien phai lon hon 0.");
        return;
    }

    Console.WriteLine("Chon loai khach hang:");
    Console.WriteLine("1. Thuong");
    Console.WriteLine("2. Bac");
    Console.WriteLine("3. Vang");
    Console.WriteLine("4. Kim cuong");
    Console.Write("Lua chon: ");

    string customerTypeChoice = Console.ReadLine();

    string customerTypeName;
    decimal discountPercent;

    switch (customerTypeChoice)
    {
        case "1":
            customerTypeName = "Thuong";
            discountPercent = 0m;
            break;

        case "2":
            customerTypeName = "Bac";
            discountPercent = 0.05m;
            break;

        case "3":
            customerTypeName = "Vang";
            discountPercent = 0.10m;
            break;

        case "4":
            customerTypeName = "Kim cuong";
            discountPercent = 0.15m;
            break;

        default:
            Console.WriteLine("Loai khach hang khong hop le.");
            return;
    }

    decimal discountAmount = billAmount * discountPercent;
    decimal finalAmount = billAmount - discountAmount;

    Console.WriteLine("===== KET QUA HOA DON =====");
    Console.WriteLine($"Ten khach hang: {customerName}");
    Console.WriteLine($"Loai khach hang: {customerTypeName}");
    Console.WriteLine($"Tong tien ban dau: {billAmount}");
    Console.WriteLine($"Phan tram giam gia: {discountPercent * 100}%");
    Console.WriteLine($"Tien giam: {discountAmount}");
    Console.WriteLine($"Tien phai tra: {finalAmount}");
}
else
{
    Console.WriteLine("Lua chon khong hop le.");
}
