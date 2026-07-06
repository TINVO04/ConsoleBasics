# Day 03 - Loops And Menu

## Mục tiêu

- Luyện tạo menu Console chạy lặp bằng `while`.
- Luyện xử lý lựa chọn menu bằng `switch/case`.
- Luyện dùng vòng lặp `for` khi biết trước số lần lặp.
- Luyện kiểm tra dữ liệu nhập bằng `int.TryParse`.
- Biết tính tổng, trung bình cộng và tìm số lớn nhất trong nhiều số nguyên.
- Biết dùng `break` để dừng xử lý khi dữ liệu không hợp lệ.
- Biết để chương trình quay lại menu sau khi chạy xong một bài.

## Bài đã hoàn thành

### Bài 1: Nhập n số nguyên, tính tổng, trung bình và số lớn nhất

Chương trình cho phép nhập:

- Số lượng số nguyên `n`.
- Lần lượt `n` số nguyên.

Sau đó chương trình tính:

```text
Tổng = Tổng tất cả số đã nhập
Trung bình = Tổng / n
Số lớn nhất = Giá trị lớn nhất trong các số đã nhập
```

Chương trình có kiểm tra dữ liệu nhập:

- `n` phải là số nguyên.
- `n` phải lớn hơn `0`.
- Các số nhập vào phải là số nguyên.
- Nếu nhập sai, chương trình báo lỗi và không bị crash.
- Sau khi chạy xong hoặc nhập sai, chương trình quay lại menu chính.

## Cách chạy chương trình

Mở Terminal tại thư mục gốc repo và chạy:

```powershell
dotnet run --project Day03.LoopsAndMenu
```

Sau khi chạy, chương trình hiển thị menu:

```text
===== DAY 3 - LOOPS AND MENU =====
1. Bai 1 - Nhap n so nguyen
2. Bai 2 - In bang cuu chuong
3. Bai 3 - Quan ly danh sach ten
0. Thoat
Chon bai:
```

Nhập `1` để chạy Bài 1.

Nhập `2` để chạy Bài 2.

Nhập `3` để chạy Bài 3.

Nhập `0` để thoát chương trình.

Nếu nhập lựa chọn không hợp lệ, chương trình sẽ báo lỗi lựa chọn và quay lại menu.

## Kiến thức đã hiểu

- `while` dùng để lặp menu chính cho đến khi người dùng chọn thoát.
- `bool` dùng để lưu trạng thái đúng/sai, ví dụ biến kiểm soát chương trình còn chạy hay không.
- `switch/case` phù hợp khi cần xử lý nhiều lựa chọn cố định từ menu.
- `default` trong `switch` dùng để xử lý lựa chọn không hợp lệ.
- `break` dùng để kết thúc một nhánh `case` hoặc dừng xử lý khi dữ liệu không hợp lệ.
- `Console.WriteLine` dùng để in một dòng ra màn hình và xuống dòng.
- `Console.Write` dùng để in ra màn hình nhưng không xuống dòng.
- `Console.ReadLine` dùng để đọc dữ liệu người dùng nhập từ bàn phím.
- Dữ liệu nhập từ `Console.ReadLine` ban đầu là `string`.
- `int.TryParse` dùng để thử chuyển chuỗi sang số nguyên và tránh chương trình bị crash.
- `if` dùng để kiểm tra điều kiện hợp lệ hoặc không hợp lệ.
- `for` phù hợp khi biết trước số lần lặp, ví dụ lặp từ `1` đến `n`.
- Biến tổng dùng để cộng dồn giá trị qua từng lần lặp.
- Biến số lớn nhất dùng để lưu giá trị lớn nhất hiện tại trong quá trình nhập dữ liệu.
- Ép kiểu `(double)` khi tính trung bình để tránh kết quả bị chia nguyên.

## Test case

| Bài | Trường hợp | Dữ liệu nhập | Kết quả mong đợi |
|---|---|---|---|
| Menu | Chọn Bài 1 | Chọn `1` | Chạy chức năng nhập `n` số nguyên |
| Menu | Chọn sai menu | Chọn `9` | Báo lựa chọn không hợp lệ và quay lại menu |
| Menu | Thoát chương trình | Chọn `0` | In lời chào tạm biệt và thoát chương trình |
| Bài 1 | Dữ liệu hợp lệ | Chọn `1`, `n = 3`, nhập `2`, `5`, `8` | Tổng `15`, trung bình `5`, số lớn nhất `8` |
| Bài 1 | Có số âm | Chọn `1`, `n = 3`, nhập `-2`, `5`, `1` | Tổng `4`, trung bình khoảng `1.3333`, số lớn nhất `5` |
| Bài 1 | `n` là chữ | Chọn `1`, `n = abc` | Báo `n` không hợp lệ, chương trình không crash |
| Bài 1 | `n` bằng 0 | Chọn `1`, `n = 0` | Báo `n` không hợp lệ |
| Bài 1 | `n` âm | Chọn `1`, `n = -1` | Báo `n` không hợp lệ |
| Bài 1 | Một số nhập sai | Chọn `1`, `n = 3`, số thứ hai nhập `abc` | Báo giá trị không hợp lệ, chương trình không crash |

## Lỗi đã gặp

| Lỗi | Nguyên nhân | Cách xử lý |
|---|---|---|
| Người dùng có thể nhập chữ thay vì số lượng `n` | Dữ liệu từ `Console.ReadLine` ban đầu là chuỗi | Dùng `int.TryParse` để kiểm tra trước khi lặp |
| Người dùng có thể nhập `n <= 0` | Số lượng phần tử không hợp lệ để nhập danh sách số | Thêm điều kiện kiểm tra `n <= 0` |
| Người dùng có thể nhập chữ trong lúc nhập từng số | Dữ liệu nhập từ bàn phím có thể không phải số nguyên | Dùng `int.TryParse` cho từng số nhập vào |
| Trung bình có thể bị sai nếu chia nguyên | `int / int` có thể cho kết quả chia nguyên | Ép kiểu sang `double` trước khi chia |
| Menu có thể kết thúc ngay sau khi chọn một bài | Chưa dùng vòng lặp để giữ chương trình chạy liên tục | Dùng `while` và biến `bool` để lặp menu |

## Phần chưa hiểu/cần luyện thêm

- Luyện thêm cách dùng `for`, `while`, `break` và `continue` trong nhiều tình huống khác nhau.
- Luyện thêm cách viết menu con cho từng nhóm chức năng.
- Luyện thêm cách đặt tên biến rõ nghĩa khi xử lý vòng lặp.
- Luyện thêm cách tách logic thành hàm để chương trình dễ đọc hơn ở các bài sau.
- Luyện thêm cách xử lý khi nhập sai nhưng vẫn cho người dùng nhập lại thay vì quay về menu.

## Tự đánh giá

- Đã tạo được Console App cho Day 3.
- Đã tạo được menu chính chạy lặp bằng `while`.
- Đã biết dùng `switch/case` để xử lý lựa chọn menu.
- Đã làm được Bài 1: nhập `n` số nguyên, tính tổng, trung bình và số lớn nhất.
- Đã biết dùng `for` để lặp theo số lần nhập từ người dùng.
- Đã biết dùng `int.TryParse` để kiểm tra nhập sai cơ bản.
- Đã biết kiểm tra `n` phải lớn hơn `0`.
- Cần tiếp tục luyện Bài 2 và Bài 3 để hiểu rõ hơn về vòng lặp và menu Console.
