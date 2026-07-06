# ConsoleBasics - Day 01

## Mục tiêu

- Hiểu Console App cơ bản.
- Biết in dữ liệu ra màn hình bằng `Console.WriteLine`.
- Biết nhập dữ liệu từ bàn phím bằng `Console.ReadLine`.
- Biết chương trình chạy từ trên xuống dưới.
- Biết khai báo biến và chọn kiểu dữ liệu cơ bản.
- Biết tính toán đơn giản với số lượng, đơn giá, tổng tiền và tuổi gần đúng.
- Biết kiểm tra dữ liệu nhập sai cơ bản bằng `TryParse`.
- Biết tạo menu đơn giản để chọn bài thực hành.

## Bài đã hoàn thành

### Bài 1: In thông tin cá nhân và lớp học

Chương trình in ra các thông tin:

- Họ tên
- Năm sinh
- Trường/lớp
- Mục tiêu học .NET
- Ngày học

### Bài 2: Nhập tên sản phẩm, số lượng, đơn giá và tính tổng tiền

Chương trình cho phép nhập:

- Tên sản phẩm
- Số lượng
- Đơn giá

Sau đó chương trình tính:

```text
Tổng tiền = Số lượng * Đơn giá
```

Chương trình có kiểm tra dữ liệu nhập:

- Số lượng phải là số nguyên lớn hơn 0.
- Đơn giá phải là số lớn hơn 0.
- Nếu nhập sai, chương trình báo lỗi và không bị crash.

### Bài 3: Nhập năm sinh và tính tuổi gần đúng

Chương trình cho phép nhập năm sinh, sau đó tính tuổi gần đúng theo công thức:

```text
Tuổi gần đúng = Năm hiện tại - Năm sinh
```

Chương trình có kiểm tra dữ liệu nhập:

- Năm sinh phải là số nguyên.
- Năm sinh phải lớn hơn 0.
- Năm sinh không được lớn hơn năm hiện tại.
- Nếu nhập sai, chương trình báo lỗi và không bị crash.

## Cách chạy chương trình

Mở Terminal tại thư mục gốc của repo và chạy:

```powershell
dotnet run --project Day01.ConsoleBasics
```

Sau khi chạy, chương trình hiển thị menu:

```text
===== DAY 1 - CONSOLE BASICS =====
1. Bai 1 - In thong tin ca nhan
2. Bai 2 - Tinh tong tien san pham
3. Bai 3 - Tinh tuoi gan dung
Chon bai:
```

Nhập `1` để chạy Bài 1.

Nhập `2` để chạy Bài 2.

Nhập `3` để chạy Bài 3.

Nếu nhập lựa chọn không hợp lệ, chương trình sẽ báo lỗi lựa chọn.

## Kiến thức đã hiểu

- `Console.WriteLine` dùng để in một dòng ra màn hình và xuống dòng.
- `Console.Write` dùng để in ra màn hình nhưng không xuống dòng.
- `Console.ReadLine` dùng để đọc dữ liệu người dùng nhập từ bàn phím.
- Nội dung trong dấu nháy kép là chuỗi ký tự.
- Dấu chấm phẩy `;` dùng để kết thúc một câu lệnh trong C#.
- Chương trình chạy từ trên xuống dưới theo thứ tự câu lệnh.
- `string` dùng để lưu chuỗi, ví dụ tên sản phẩm.
- `int` dùng để lưu số nguyên, ví dụ số lượng, năm sinh và tuổi.
- `decimal` phù hợp để lưu giá tiền và tổng tiền.
- `DateTime.Now.Year` dùng để lấy năm hiện tại từ máy tính.
- `int.TryParse` dùng để thử chuyển chuỗi sang số nguyên.
- `decimal.TryParse` dùng để thử chuyển chuỗi sang số thập phân hoặc tiền.
- `if`, `else if`, `else` dùng để xử lý điều kiện và lựa chọn menu.
- Toán tử `!` dùng để phủ định điều kiện.
- Toán tử `||` nghĩa là hoặc.
- `return` dùng để dừng chương trình sớm khi dữ liệu không hợp lệ.

## Test case

| Bài | Trường hợp | Dữ liệu nhập | Kết quả mong đợi |
|---|---|---|---|
| Bài 1 | Chạy Bài 1 | Chọn `1` | In đúng thông tin cá nhân và lớp học |
| Menu | Chọn sai menu | Chọn `9` | Báo lựa chọn không hợp lệ |
| Bài 2 | Dữ liệu hợp lệ | Chọn `2`, sản phẩm `But bi`, số lượng `2`, đơn giá `5000` | Tổng tiền `10000` |
| Bài 2 | Số lượng là chữ | Chọn `2`, số lượng `abc` | Báo số lượng không hợp lệ, chương trình không crash |
| Bài 2 | Số lượng âm | Chọn `2`, số lượng `-1` | Báo số lượng không hợp lệ |
| Bài 2 | Đơn giá là chữ | Chọn `2`, đơn giá `abc` | Báo đơn giá không hợp lệ, chương trình không crash |
| Bài 2 | Đơn giá bằng 0 | Chọn `2`, đơn giá `0` | Báo đơn giá không hợp lệ |
| Bài 3 | Năm sinh hợp lệ | Chọn `3`, năm sinh `2003` | In năm hiện tại, năm sinh và tuổi gần đúng |
| Bài 3 | Năm sinh là chữ | Chọn `3`, năm sinh `abc` | Báo năm sinh không hợp lệ, chương trình không crash |
| Bài 3 | Năm sinh tương lai | Chọn `3`, năm sinh `3000` | Báo năm sinh không hợp lệ |
| Bài 3 | Năm sinh bằng 0 | Chọn `3`, năm sinh `0` | Báo năm sinh không hợp lệ |

## Lỗi đã gặp

| Lỗi | Nguyên nhân | Cách xử lý |
|---|---|---|
| Chương trình crash khi nhập `abc` vào số lượng | Dùng `int.Parse` nên không xử lý được chuỗi không phải số | Đổi sang `int.TryParse` để kiểm tra nhập hợp lệ trước khi tính |
| Chương trình có thể crash khi nhập `abc` vào đơn giá | Dùng `decimal.Parse` nên không xử lý được chuỗi không phải số | Đổi sang `decimal.TryParse` để kiểm tra nhập hợp lệ trước khi tính |
| Năm sinh có thể không hợp lệ nếu nhập chữ hoặc năm tương lai | Dữ liệu từ `Console.ReadLine` ban đầu là chuỗi và người dùng có thể nhập sai | Dùng `int.TryParse`, kiểm tra năm sinh lớn hơn 0 và không lớn hơn năm hiện tại |

## Phần chưa hiểu

- Tiếp tục luyện thêm cách dùng `TryParse`.
- Tiếp tục luyện thêm cách đặt tên biến rõ nghĩa.
- Tiếp tục luyện cách viết test case đầy đủ hơn.
- Tiếp tục luyện giải thích điều kiện có `!` và `||`.

## Tự đánh giá

- Đã tạo và chạy được Console App.
- Đã làm được Bài 1, Bài 2 và Bài 3.
- Đã biết tạo menu đơn giản để chọn bài.
- Đã biết dùng `Console.WriteLine`, `Console.Write` và `Console.ReadLine`.
- Đã biết dùng `TryParse` để kiểm tra nhập sai cơ bản.
- Đã biết dùng `DateTime.Now.Year` để lấy năm hiện tại.
- Đã biết kiểm tra nhập sai cơ bản để chương trình không crash.
- Cần tiếp tục luyện giải thích flow chương trình trước khi nộp bài.
