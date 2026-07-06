# Day 02 - Condition And Validation

## Mục tiêu

- Luyện nhập dữ liệu từ bàn phím bằng `Console.ReadLine`.
- Luyện chuyển kiểu an toàn bằng `TryParse`.
- Luyện kiểm tra dữ liệu đầu vào hợp lệ.
- Luyện xử lý điều kiện bằng `if`, `else if`, `else`.
- Biết áp dụng điều kiện vào bài toán nghiệp vụ đơn giản.

## Bài đã hoàn thành

### Bài 1: Tính điểm trung bình và xếp loại sinh viên

Chương trình cho phép nhập điểm 3 môn:

- Toán
- Văn
- Anh

Điểm hợp lệ phải nằm trong khoảng:

```text
0 <= điểm <= 10
```

Công thức tính điểm trung bình:

```text
Điểm trung bình = (Điểm Toán + Điểm Văn + Điểm Anh) / 3
```

Quy tắc xếp loại:

| Điểm trung bình | Xếp loại |
|---|---|
| `>= 8.0` | Giỏi |
| `>= 6.5` | Khá |
| `>= 5.0` | Trung bình |
| `< 5.0` | Yếu |

## Cách chạy chương trình

Mở Terminal tại thư mục gốc repo và chạy:

```powershell
dotnet run --project Day02.ConditionAndValidation
```

## Kiến thức đã hiểu

- `double` phù hợp để lưu điểm vì điểm có thể là số lẻ.
- `double.TryParse` giúp kiểm tra dữ liệu nhập có chuyển được sang số hay không.
- `if`, `else if`, `else` dùng để phân loại kết quả theo điều kiện.
- Khi xếp loại, nên kiểm tra từ mức cao xuống thấp để tránh phân loại sai.
- `return` dùng để dừng chương trình sớm khi dữ liệu không hợp lệ.

## Test case

| Bài | Trường hợp | Dữ liệu nhập | Kết quả mong đợi |
|---|---|---|---|
| Bài 1 | Giỏi | Toán `9`, Văn `8`, Anh `8.5` | Điểm trung bình `8.5`, xếp loại `Gioi` |
| Bài 1 | Khá | Toán `7`, Văn `6.5`, Anh `7` | Xếp loại `Kha` |
| Bài 1 | Trung bình | Toán `5`, Văn `5.5`, Anh `6` | Xếp loại `Trung binh` |
| Bài 1 | Yếu | Toán `3`, Văn `4`, Anh `4.5` | Xếp loại `Yeu` |
| Bài 1 | Nhập chữ | Toán `abc` | Báo điểm Toán không hợp lệ, chương trình không crash |
| Bài 1 | Điểm ngoài khoảng | Toán `11` | Báo điểm Toán không hợp lệ |
| Bài 1 | Điểm âm | Toán `-1` | Báo điểm Toán không hợp lệ |

## Lỗi đã gặp

| Lỗi | Nguyên nhân | Cách xử lý |
|---|---|---|
| Người dùng có thể nhập chữ thay vì điểm số | Dữ liệu từ `Console.ReadLine` ban đầu là chuỗi | Dùng `double.TryParse` để kiểm tra trước khi tính |
| Người dùng có thể nhập điểm ngoài khoảng 0-10 | Chưa kiểm tra giới hạn điểm | Thêm điều kiện kiểm tra điểm nhỏ hơn 0 hoặc lớn hơn 10 |

## Phần chưa hiểu/cần luyện thêm

- Luyện thêm cách viết điều kiện rõ ràng.
- Luyện thêm cách đặt tên biến cho dễ hiểu.
- Luyện thêm cách gom logic lặp lại để code ngắn hơn ở các bài sau.

## Tự đánh giá

- Đã làm được Bài 1 của Day 2.
- Đã biết dùng `double.TryParse` để validate điểm.
- Đã biết xếp loại bằng `if`, `else if`, `else`.
- Cần tiếp tục luyện `switch/case` ở các bài tiếp theo.
