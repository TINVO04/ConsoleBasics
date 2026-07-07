# ConsoleBasics

Repo thực hành C# Console App theo lộ trình .NET cơ bản.

## Mục tiêu

- Luyện C# nền tảng qua Console App.
- Thực hành nhập/xuất dữ liệu với `Console.WriteLine`, `Console.Write` và `Console.ReadLine`.
- Thực hành biến, kiểu dữ liệu, điều kiện, vòng lặp, danh sách và function theo từng ngày học.
- Luyện Git workflow: branch, commit, push và Pull Request.
- Luyện viết README, test case và ghi chú lỗi cơ bản.
- Làm quen với CI bằng GitHub Actions.

## Cấu trúc repo

| Thư mục/File | Nội dung | Trạng thái |
|---|---|---|
| `Day01.ConsoleBasics` | Console App Day 1: nhập/xuất, biến, kiểu dữ liệu, tính toán đơn giản | Hoàn thành |
| `Day02.ConditionAndValidation` | Console App Day 2: điều kiện, validate, `if/else`, `switch/case` | Hoàn thành, đã merge vào `main` |
| `Day03.LoopsAndMenu` | Console App Day 3: vòng lặp, menu lặp, danh sách tên, mini challenge chặn nhập sai menu | Hoàn thành, đã merge vào `main` |
| `Day04.CollectionsAndFunctions` | Console App Day 4: `List<string>`, tìm kiếm chuỗi, tách function, mini challenge kiểm tra mật khẩu | Hoàn thành, đã merge vào `main` |
| `Day05.Week1Review` | Console App Day 5: ôn tập tuần 1, tính hóa đơn, quản lý sinh viên, refactor function | Hoàn thành, chuẩn bị tạo Pull Request |
| `.github/workflows/dotnet-ci.yml` | GitHub Actions workflow để build project .NET | Đã thêm |

## Day 1 - Console Basics

Nội dung đã làm:

- Bài 1: In thông tin cá nhân và lớp học.
- Bài 2: Nhập sản phẩm, số lượng, đơn giá và tính tổng tiền.
- Bài 3: Nhập năm sinh và tính tuổi gần đúng.
- Có menu chọn bài thực hành.
- Có kiểm tra dữ liệu nhập sai cơ bản bằng `TryParse`.
- Có README riêng cho Day 1.

Xem chi tiết tại:

```text
Day01.ConsoleBasics/README.md
```

## Day 2 - Condition And Validation

Nội dung đã làm:

- Bài 1: Tính điểm trung bình và xếp loại sinh viên.
- Bài 2: Tính tiền hóa đơn có giảm giá theo tổng tiền.
- Bài 3: Menu chọn loại khách hàng: thường, bạc, vàng, kim cương; áp dụng phần trăm giảm giá.
- Có menu chọn bài thực hành.
- Có kiểm tra dữ liệu nhập sai bằng `TryParse`.
- Có xử lý điều kiện bằng `if`, `else if`, `else`.
- Có xử lý lựa chọn bằng `switch/case`.
- Có README riêng cho Day 2.

Xem chi tiết tại:

```text
Day02.ConditionAndValidation/README.md
```

## Day 3 - Loops And Menu

Nội dung đã làm:

- Bài 1: Nhập `n` số nguyên, tính tổng, trung bình cộng và số lớn nhất.
- Bài 2: In bảng cửu chương bằng vòng lặp.
- Bài 3: Quản lý danh sách tên bằng menu con.
- Có menu chính chạy lặp bằng `while`.
- Có menu con cho Bài 3.
- Có kiểm tra dữ liệu nhập sai bằng `int.TryParse` và `string.IsNullOrWhiteSpace`.
- Có xử lý lựa chọn bằng `switch/case`.
- Có mini challenge chặn nhập sai menu để chương trình không dừng đột ngột.
- Có README riêng cho Day 3.

Xem chi tiết tại:

```text
Day03.LoopsAndMenu/README.md
```

## Day 4 - Collections And Functions

Nội dung đã làm:

- Bài 1: Quản lý danh sách sinh viên bằng `List<string>`.
- Bài 2: Tìm kiếm sinh viên không phân biệt hoa/thường.
- Bài 3: Tách các chức năng menu thành function riêng.
- Mini challenge: Kiểm tra mật khẩu có độ dài >= 8 và có ký tự viết hoa.
- Có menu chính cho Day 4.
- Có menu con quản lý danh sách sinh viên.
- Có sử dụng `List<string>` để lưu danh sách sinh viên.
- Có xử lý chuỗi bằng `Trim`, `ToLower` và `Contains`.
- Có kiểm tra mật khẩu bằng `Length` và `char.IsUpper`.
- Có README riêng cho Day 4.

Xem chi tiết tại:

```text
Day04.CollectionsAndFunctions/README.md
```

## Day 5 - Week 1 Review

Nội dung đã làm:

- Bài test 1: App tính hóa đơn có giảm giá theo loại khách hàng.
- Bài test 2: App quản lý sinh viên bằng `List<string>` gồm thêm, xem, tìm, xóa.
- Bài test 3: Refactor code, tách function và đặt tên biến rõ ràng.
- Có menu chính cho Day 5.
- Có menu con quản lý sinh viên.
- Có validate dữ liệu nhập bằng `string.IsNullOrWhiteSpace` và `decimal.TryParse`.
- Có xử lý chuỗi bằng `Trim`, `ToLower` và `Contains`.
- Có sử dụng `Add`, `Remove`, `Count` và `foreach` với `List<string>`.
- Có README riêng cho Day 5.

Xem chi tiết tại:

```text
Day05.Week1Review/README.md
```

## Cách chạy Day 1

Mở Terminal tại thư mục gốc repo và chạy:

```powershell
dotnet run --project Day01.ConsoleBasics
```

Sau khi chạy, chọn bài trong menu:

```text
1. Bai 1 - In thong tin ca nhan
2. Bai 2 - Tinh tong tien san pham
3. Bai 3 - Tinh tuoi gan dung
```

## Cách chạy Day 2

Mở Terminal tại thư mục gốc repo và chạy:

```powershell
dotnet run --project Day02.ConditionAndValidation
```

Sau khi chạy, chọn bài trong menu:

```text
1. Bai 1 - Tinh diem trung binh va xep loai sinh vien
2. Bai 2 - Tinh hoa don co giam gia
3. Bai 3 - Tinh giam gia theo loai khach hang
```

## Cách chạy Day 3

Mở Terminal tại thư mục gốc repo và chạy:

```powershell
dotnet run --project Day03.LoopsAndMenu
```

Sau khi chạy, chọn bài trong menu:

```text
===== DAY 3 - LOOPS AND MENU =====
1. Bai 1 - Nhap n so nguyen
2. Bai 2 - In bang cuu chuong
3. Bai 3 - Quan ly danh sach ten
0. Thoat
```

## Cách chạy Day 4

Mở Terminal tại thư mục gốc repo và chạy:

```powershell
dotnet run --project Day04.CollectionsAndFunctions
```

Sau khi chạy, chọn bài trong menu:

```text
===== DAY 4 - COLLECTIONS AND FUNCTIONS =====
1. Bai 1 - Quan ly danh sach sinh vien
2. Bai 2 - Tim kiem sinh vien
3. Bai 3 - Tach chuc nang thanh function
4. Mini challenge - Kiem tra mat khau
0. Thoat
```

## Cách chạy Day 5

Mở Terminal tại thư mục gốc repo và chạy:

```powershell
dotnet run --project Day05.Week1Review
```

Sau khi chạy, chọn bài trong menu:

```text
===== DAY 5 - WEEK 1 REVIEW =====
1. Bai test 1 - Tinh hoa don co giam gia theo loai khach hang
2. Bai test 2 - Quan ly sinh vien bang List
3. Bai test 3 - Refactor code va dat ten bien ro rang
0. Thoat
```

## Git workflow

Mỗi ngày học nên làm trên branch riêng theo mẫu:

```text
feature/week1-dayXX-tenhocvien
```

Ví dụ:

```text
feature/week1-day01-tinvo
feature/week1-day02-tinvo
feature/week1-day03-tinvo
feature/week1-day04-tinvo
feature/week1-day05-tinvo
```

Quy trình cơ bản:

1. Tạo branch riêng cho ngày học.
2. Làm bài và commit nhỏ, rõ nghĩa.
3. Push branch lên GitHub.
4. Tạo Pull Request vào `main`.
5. Chạy CI và kiểm tra kết quả.
6. Merge sau khi hoàn thành/review.

## CI

Repo có GitHub Actions workflow để build project .NET khi push hoặc tạo Pull Request.

Workflow nằm tại:

```text
.github/workflows/dotnet-ci.yml
```

CI hiện kiểm tra:

- Restore dependencies.
- Build project .NET ở cấu hình Release.

## Trạng thái hiện tại

| Ngày | Nội dung | Trạng thái |
|---|---|---|
| Day 1 | Console basics, biến, kiểu dữ liệu, nhập/xuất, tính toán đơn giản | Hoàn thành, đã merge vào `main` |
| Day 2 | Input, ép kiểu, `if/else`, `switch/case`, validate cơ bản | Hoàn thành, đã merge vào `main` |
| Day 3 | Vòng lặp, menu lặp, `for`, `while`, `foreach`, `List<string>`, chặn nhập sai menu | Hoàn thành, đã merge vào `main` |
| Day 4 | `List<string>`, xử lý chuỗi, tìm kiếm không phân biệt hoa/thường, function, kiểm tra mật khẩu | Hoàn thành, đã merge vào `main` |
| Day 5 | Ôn tập tuần 1, hóa đơn giảm giá, quản lý sinh viên bằng `List<string>`, refactor function | Hoàn thành, chuẩn bị tạo Pull Request |
