# Day 02 - Condition And Validation

## Mục tiêu

- Luyện nhập dữ liệu từ bàn phím bằng `Console.ReadLine`.
- Luyện chuyển kiểu an toàn bằng `TryParse`.
- Luyện kiểm tra dữ liệu đầu vào hợp lệ.
- Luyện xử lý điều kiện bằng `if`, `else if`, `else`.
- Biết áp dụng điều kiện vào bài toán nghiệp vụ đơn giản.
- Biết tính toán giảm giá dựa trên điều kiện tổng tiền.

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

### Bài 2: Tính tiền hóa đơn có giảm giá theo tổng tiền

Chương trình cho phép nhập:

- Tên sản phẩm
- Số lượng
- Đơn giá

Công thức:

```text
Tổng tiền = Số lượng * Đơn giá
Tiền giảm = Tổng tiền * Phần trăm giảm
Tiền phải trả = Tổng tiền - Tiền giảm
```

Quy tắc giảm giá:

| Tổng tiền | Giảm giá |
|---|---|
| `>= 1,000,000` | `10%` |
| `>= 500,000` | `5%` |
| `< 500,000` | `0%` |

Chương trình có kiểm tra dữ liệu nhập:

- Tên sản phẩm không được rỗng.
- Số lượng phải là số nguyên lớn hơn 0.
- Đơn giá phải là số lớn hơn 0.
- Nếu nhập sai, chương trình báo lỗi và không bị crash.

## Cách chạy chương trình

Mở Terminal tại thư mục gốc repo và chạy:

```powershell
dotnet run --project Day02.ConditionAndValidation
```

Sau khi chạy, chương trình hiển thị menu:

```text
1. Bai 1 - Tinh diem trung binh va xep loai sinh vien
2. Bai 2 - Tinh hoa don co giam gia
```

Nhập `1` để chạy Bài 1.

Nhập `2` để chạy Bài 2.

## Kiến thức đã hiểu

- `double` phù hợp để lưu điểm vì điểm có thể là số lẻ.
- `double.TryParse` giúp kiểm tra dữ liệu nhập có chuyển được sang số hay không.
- `int.TryParse` giúp kiểm tra số lượng có phải số nguyên hay không.
- `decimal.TryParse` giúp kiểm tra đơn giá có phải số hợp lệ hay không.
- `decimal` phù hợp để tính tiền.
- `string.IsNullOrWhiteSpace` giúp kiểm tra chuỗi rỗng hoặc chỉ có khoảng trắng.
- `if`, `else if`, `else` dùng để phân loại kết quả theo điều kiện.
- Khi xếp loại hoặc tính giảm giá, nên kiểm tra từ mức cao xuống thấp để tránh phân loại sai.
- Hậu tố `m` trong `0.10m` cho biết đây là số kiểu `decimal`.
- `return` dùng để dừng chương trình sớm khi dữ liệu không hợp lệ.

## Test case

| Bài | Trường hợp | Dữ liệu nhập | Kết quả mong đợi |
|---|---|---|---|
| Bài 1 | Giỏi | Chọn `1`, Toán `9`, Văn `8`, Anh `8.5` | Điểm trung bình `8.5`, xếp loại `Gioi` |
| Bài 1 | Khá | Chọn `1`, Toán `7`, Văn `6.5`, Anh `7` | Xếp loại `Kha` |
| Bài 1 | Trung bình | Chọn `1`, Toán `5`, Văn `5.5`, Anh `6` | Xếp loại `Trung binh` |
| Bài 1 | Yếu | Chọn `1`, Toán `3`, Văn `4`, Anh `4.5` | Xếp loại `Yeu` |
| Bài 1 | Nhập chữ | Chọn `1`, Toán `abc` | Báo điểm Toán không hợp lệ, chương trình không crash |
| Bài 1 | Điểm ngoài khoảng | Chọn `1`, Toán `11` | Báo điểm Toán không hợp lệ |
| Bài 1 | Điểm âm | Chọn `1`, Toán `-1` | Báo điểm Toán không hợp lệ |
| Menu | Chọn sai menu | Chọn `9` | Báo lựa chọn không hợp lệ |
| Bài 2 | Không giảm giá | Chọn `2`, sản phẩm `But bi`, số lượng `2`, đơn giá `100000` | Tổng tiền `200000`, giảm `0%` |
| Bài 2 | Giảm 5% | Chọn `2`, sản phẩm `Sach`, số lượng `5`, đơn giá `100000` | Tổng tiền `500000`, giảm `5%` |
| Bài 2 | Giảm 10% | Chọn `2`, sản phẩm `Laptop`, số lượng `1`, đơn giá `1200000` | Tổng tiền `1200000`, giảm `10%` |
| Bài 2 | Tên sản phẩm rỗng | Chọn `2`, tên sản phẩm rỗng | Báo tên sản phẩm không được để trống |
| Bài 2 | Số lượng là chữ | Chọn `2`, số lượng `abc` | Báo số lượng không hợp lệ, chương trình không crash |
| Bài 2 | Số lượng âm | Chọn `2`, số lượng `-1` | Báo số lượng không hợp lệ |
| Bài 2 | Đơn giá là chữ | Chọn `2`, đơn giá `abc` | Báo đơn giá không hợp lệ, chương trình không crash |
| Bài 2 | Đơn giá bằng 0 | Chọn `2`, đơn giá `0` | Báo đơn giá không hợp lệ |

## Lỗi đã gặp

| Lỗi | Nguyên nhân | Cách xử lý |
|---|---|---|
| Người dùng có thể nhập chữ thay vì điểm số | Dữ liệu từ `Console.ReadLine` ban đầu là chuỗi | Dùng `double.TryParse` để kiểm tra trước khi tính |
| Người dùng có thể nhập điểm ngoài khoảng 0-10 | Chưa kiểm tra giới hạn điểm | Thêm điều kiện kiểm tra điểm nhỏ hơn 0 hoặc lớn hơn 10 |
| Người dùng có thể bỏ trống tên sản phẩm | Chưa kiểm tra chuỗi rỗng | Dùng `string.IsNullOrWhiteSpace` để validate tên sản phẩm |
| Người dùng có thể nhập sai số lượng hoặc đơn giá | Dữ liệu nhập từ bàn phím là chuỗi | Dùng `int.TryParse` và `decimal.TryParse` trước khi tính hóa đơn |
| Hóa đơn lớn có thể bị áp sai mức giảm giá nếu kiểm tra điều kiện sai thứ tự | Kiểm tra mức thấp trước mức cao | Kiểm tra tổng tiền từ mức cao xuống thấp |

## Phần chưa hiểu/cần luyện thêm

- Luyện thêm cách viết điều kiện rõ ràng.
- Luyện thêm cách đặt tên biến cho dễ hiểu.
- Luyện thêm cách gom logic lặp lại để code ngắn hơn ở các bài sau.
- Luyện thêm `switch/case` ở Bài 3.

## Tự đánh giá

- Đã làm được Bài 1 và Bài 2 của Day 2.
- Đã biết dùng `double.TryParse` để validate điểm.
- Đã biết dùng `int.TryParse` và `decimal.TryParse` để validate hóa đơn.
- Đã biết xếp loại bằng `if`, `else if`, `else`.
- Đã biết áp dụng giảm giá theo tổng tiền.
- Cần tiếp tục luyện `switch/case` ở bài tiếp theo.
