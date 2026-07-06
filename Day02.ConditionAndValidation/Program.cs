Console.WriteLine("Bai 1 - Tinh diem trung binh va xep loai sinh vien");

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
