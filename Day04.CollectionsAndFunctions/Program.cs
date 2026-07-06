bool isRunning = true;

while (isRunning)
{
    Console.WriteLine("===== DAY 4 - COLLECTIONS AND FUNCTIONS =====");
    Console.WriteLine("1. Bai 1 - Quan ly danh sach sinh vien");
    Console.WriteLine("2. Bai 2 - Xu ly chuoi ho ten");
    Console.WriteLine("3. Bai 3 - Xu ly ngay thang");
    Console.WriteLine("4. Bai 4 - Tong hop voi function");
    Console.WriteLine("0. Thoat");
    Console.Write("Chon bai: ");

    string choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            RunStudentListExercise();
            break;

        case "2":
            RunStringExercise();
            break;

        case "3":
            RunDateTimeExercise();
            break;

        case "4":
            RunFunctionReviewExercise();
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

static void RunStudentListExercise()
{
    Console.WriteLine("Ban da chon Bai 1 - Quan ly danh sach sinh vien.");
}

static void RunStringExercise()
{
    Console.WriteLine("Ban da chon Bai 2 - Xu ly chuoi ho ten.");
}

static void RunDateTimeExercise()
{
    Console.WriteLine("Ban da chon Bai 3 - Xu ly ngay thang.");
}

static void RunFunctionReviewExercise()
{
    Console.WriteLine("Ban da chon Bai 4 - Tong hop voi function.");
}
