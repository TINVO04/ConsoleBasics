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
| `Day02.ConditionAndValidation` | Console App Day 2: điều kiện, validate, `if/else`, `switch/case` | Hoàn thành, chuẩn bị tạo Pull Request |
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

## Git workflow

Mỗi ngày học nên làm trên branch riêng theo mẫu:

```text
feature/week1-dayXX-tenhocvien
```

Ví dụ:

```text
feature/week1-day01-tinvo
feature/week1-day02-tinvo
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
| Day 2 | Input, ép kiểu, `if/else`, `switch/case`, validate cơ bản | Hoàn thành, chuẩn bị tạo Pull Request |
