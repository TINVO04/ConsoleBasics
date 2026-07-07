List<string> students = new List<string>();

bool isRunning = true;

while (isRunning)
{
    ShowMainMenu();

    string choice = Console.ReadLine();

    isRunning = HandleMainMenuChoice(choice, students);

    Console.WriteLine();
}

static void ShowMainMenu()
{
    Console.WriteLine("===== DAY 4 - COLLECTIONS AND FUNCTIONS =====");
    Console.WriteLine("1. Bai 1 - Quan ly danh sach sinh vien");
    Console.WriteLine("2. Bai 2 - Tim kiem sinh vien");
    Console.WriteLine("3. Bai 3 - Tach chuc nang thanh function");
    Console.WriteLine("4. Mini challenge - Kiem tra mat khau");
    Console.WriteLine("0. Thoat");
    Console.Write("Chon bai: ");
}

static bool HandleMainMenuChoice(string choice, List<string> students)
{
    switch (choice)
    {
        case "1":
            RunStudentListExercise(students);
            return true;

        case "2":
            RunStudentSearchExercise(students);
            return true;

        case "3":
            RunFunctionRefactorExercise();
            return true;

        case "4":
            RunPasswordChallenge();
            return true;

        case "0":
            Console.WriteLine("Tam biet!");
            return false;

        default:
            Console.WriteLine("Lua chon khong hop le.");
            return true;
    }
}

static void RunStudentListExercise(List<string> students)
{
    bool isStudentMenuRunning = true;

    while (isStudentMenuRunning)
    {
        ShowStudentMenu();

        string choice = Console.ReadLine();

        isStudentMenuRunning = HandleStudentMenuChoice(choice, students);

        Console.WriteLine();
    }
}

static void ShowStudentMenu()
{
    Console.WriteLine("===== BAI 1 - QUAN LY DANH SACH SINH VIEN =====");
    Console.WriteLine("1. Them sinh vien");
    Console.WriteLine("2. Xem danh sach sinh vien");
    Console.WriteLine("0. Quay lai menu chinh");
    Console.Write("Chon chuc nang: ");
}

static bool HandleStudentMenuChoice(string choice, List<string> students)
{
    switch (choice)
    {
        case "1":
            AddStudent(students);
            return true;

        case "2":
            ShowStudents(students);
            return true;

        case "0":
            return false;

        default:
            Console.WriteLine("Lua chon khong hop le.");
            return true;
    }
}

static void AddStudent(List<string> students)
{
    Console.Write("Nhap ten sinh vien: ");
    string studentName = Console.ReadLine();

    if (string.IsNullOrWhiteSpace(studentName))
    {
        Console.WriteLine("Ten sinh vien khong duoc de trong.");
        return;
    }

    students.Add(studentName.Trim());
    Console.WriteLine("Da them sinh vien.");
}

static void ShowStudents(List<string> students)
{
    if (students.Count == 0)
    {
        Console.WriteLine("Danh sach sinh vien dang rong.");
        return;
    }

    Console.WriteLine("Danh sach sinh vien:");

    foreach (string student in students)
    {
        Console.WriteLine($"- {student}");
    }
}

static void RunStudentSearchExercise(List<string> students)
{
    Console.WriteLine("===== BAI 2 - TIM KIEM SINH VIEN =====");

    SearchStudents(students);
}

static void SearchStudents(List<string> students)
{
    if (students.Count == 0)
    {
        Console.WriteLine("Danh sach sinh vien dang rong.");
        return;
    }

    Console.Write("Nhap tu khoa tim kiem: ");
    string keyword = Console.ReadLine();

    if (string.IsNullOrWhiteSpace(keyword))
    {
        Console.WriteLine("Tu khoa tim kiem khong duoc de trong.");
        return;
    }

    string normalizedKeyword = keyword.Trim().ToLower();

    bool isFound = false;

    Console.WriteLine("Ket qua tim kiem:");

    foreach (string student in students)
    {
        string normalizedStudent = student.ToLower();

        if (normalizedStudent.Contains(normalizedKeyword))
        {
            Console.WriteLine($"- {student}");
            isFound = true;
        }
    }

    if (!isFound)
    {
        Console.WriteLine("Khong tim thay sinh vien phu hop.");
    }
}

static void RunFunctionRefactorExercise()
{
    Console.WriteLine("Bai 3 da duoc ap dung trong code bang cach tach menu va chuc nang thanh cac function rieng.");
    Console.WriteLine("Vi du: ShowMainMenu, HandleMainMenuChoice, AddStudent, ShowStudents, SearchStudents.");
}

static void RunPasswordChallenge()
{
    Console.WriteLine("===== MINI CHALLENGE - KIEM TRA MAT KHAU =====");
    Console.Write("Nhap mat khau: ");

    string password = Console.ReadLine();

    if (string.IsNullOrWhiteSpace(password))
    {
        Console.WriteLine("Mat khau khong duoc de trong.");
        return;
    }

    bool hasEnoughLength = password.Length >= 8;
    bool hasUppercaseLetter = false;

    foreach (char character in password)
    {
        if (char.IsUpper(character))
        {
            hasUppercaseLetter = true;
            break;
        }
    }

    if (hasEnoughLength && hasUppercaseLetter)
    {
        Console.WriteLine("Mat khau hop le.");
    }
    else
    {
        Console.WriteLine("Mat khau khong hop le.");
        Console.WriteLine("Mat khau can co do dai >= 8 va it nhat 1 ky tu viet hoa.");
    }
}

