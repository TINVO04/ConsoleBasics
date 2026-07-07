
List<string> students = new List<string>();

bool isRunning = true;

while (isRunning)
{
    Console.WriteLine("===== DAY 4 - COLLECTIONS AND FUNCTIONS =====");
    Console.WriteLine("1. Bai 1 - Quan ly danh sach sinh vien");
    Console.WriteLine("2. Bai 2 - Tim kiem sinh vien");
    Console.WriteLine("3. Bai 3 - Tach chuc nang thanh function");
    Console.WriteLine("4. Mini challenge - Kiem tra mat khau");
    Console.WriteLine("0. Thoat");
    Console.Write("Chon bai: ");

    string choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            RunStudentListExercise(students);
            break;

        case "2":
            RunStudentSearchExercise();
            break;

        case "3":
            RunFunctionRefactorExercise();
            break;

        case "4":
            RunPasswordChallenge();
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

static void RunStudentListExercise(List<string> students)
{
    bool isStudentMenuRunning = true;

    while (isStudentMenuRunning)
    {
        Console.WriteLine("===== BAI 1 - QUAN LY DANH SACH SINH VIEN =====");
        Console.WriteLine("1. Them sinh vien");
        Console.WriteLine("2. Xem danh sach sinh vien");
        Console.WriteLine("0. Quay lai menu chinh");
        Console.Write("Chon chuc nang: ");

        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                Console.Write("Nhap ten sinh vien: ");
                string studentName = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(studentName))
                {
                    Console.WriteLine("Ten sinh vien khong duoc de trong.");
                    break;
                }

                students.Add(studentName.Trim());
                Console.WriteLine("Da them sinh vien.");
                break;

            case "2":
                if (students.Count == 0)
                {
                    Console.WriteLine("Danh sach sinh vien dang rong.");
                    break;
                }

                Console.WriteLine("Danh sach sinh vien:");

                foreach (string student in students)
                {
                    Console.WriteLine($"- {student}");
                }

                break;

            case "0":
                isStudentMenuRunning = false;
                break;

            default:
                Console.WriteLine("Lua chon khong hop le.");
                break;
        }

        Console.WriteLine();
    }
}

static void RunStudentSearchExercise()
{
    Console.WriteLine("Ban da chon Bai 2 - Tim kiem sinh vien.");
}

static void RunFunctionRefactorExercise()
{
    Console.WriteLine("Ban da chon Bai 3 - Tach chuc nang thanh function.");
}

static void RunPasswordChallenge()
{
    Console.WriteLine("Ban da chon Bai 4 - Kiem tra mat khau.");
}
