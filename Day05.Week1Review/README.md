# Day 05 - Week 1 Review

## Mục tiêu

- Ôn tập lại kiến thức C# nền tảng trong tuần 1.
- Luyện lại biến, kiểu dữ liệu, nhập/xuất dữ liệu và validate input.
- Luyện sử dụng `if/else`, `switch/case`, `while`, `foreach`.
- Luyện sử dụng `List<string>` để quản lý danh sách dữ liệu.
- Luyện xử lý chuỗi với `Trim`, `ToLower` và `Contains`.
- Luyện refactor code bằng cách tách function và đặt tên rõ nghĩa.
- Luyện debug lỗi build/run cơ bản.

## Bài đã hoàn thành

### Bài test 1: App tính hóa đơn có giảm giá theo loại khách hàng

Chương trình cho phép nhập thông tin hóa đơn và tính số tiền cần thanh toán sau khi áp dụng giảm giá theo loại khách hàng.

Chức năng đã làm:

- Nhập tên khách hàng.
- Kiểm tra tên khách hàng không được để trống.
- Nhập tổng tiền hóa đơn.
- Kiểm tra tổng tiền là số hợp lệ và lớn hơn `0`.
- Chọn loại khách hàng:
  - Thường: giảm `0%`.
  - Bạc: giảm `5%`.
  - Vàng: giảm `10%`.
  - Kim cương: giảm `15%`.
- Tính số tiền được giảm.
- Tính số tiền cần thanh toán sau giảm giá.
- Hiển thị kết quả hóa đơn.

Ví dụ:

```text
Tong tien ban dau: 100000
Loai khach hang: Vang
Ti le giam gia: 10%
So tien duoc giam: 10000
So tien can thanh toan: 90000
```

### Bài test 2: App quản lý sinh viên bằng List

Chương trình cho phép quản lý danh sách sinh viên bằng `List<string>`.

Chức năng đã làm:

- Thêm sinh viên.
- Xem danh sách sinh viên.
- Tìm sinh viên theo một phần tên.
- Tìm kiếm không phân biệt hoa/thường.
- Xóa sinh viên theo tên chính xác.
- Kiểm tra danh sách rỗng trước khi xem, tìm hoặc xóa.
- Kiểm tra tên sinh viên không được để trống.
- Cho phép quay lại menu chính.

Menu con của Bài test 2:

```text
===== BAI TEST 2 - QUAN LY SINH VIEN =====
1. Them sinh vien
2. Xem danh sach sinh vien
3. Tim sinh vien
4. Xoa sinh vien
0. Quay lai menu chinh
Chon chuc nang:
```

### Bài test 3: Refactor code và đặt tên biến rõ ràng

Bài test 3 tập trung vào việc refactor code đã làm ở Bài test 1 và Bài test 2.

Các phần đã refactor:

- Tách menu chính thành function `ShowMainMenu`.
- Tách menu sinh viên thành function `ShowStudentMenu`.
- Tách chức năng thêm sinh viên thành function `AddStudent`.
- Tách chức năng xem danh sách thành function `ShowStudents`.
- Tách chức năng tìm sinh viên thành function `SearchStudents`.
- Tách chức năng xóa sinh viên thành function `RemoveStudent`.
- Cập nhật `RunRefactorReviewTest` để mô tả các phần đã refactor.

Lợi ích của refactor:

- Code dễ đọc hơn.
- Mỗi function có một nhiệm vụ rõ ràng.
- Menu chính và menu con gọn hơn.
- Dễ sửa lỗi vì biết logic nằm ở function nào.
- Dễ mở rộng thêm chức năng sau này.

## Cách chạy chương trình

Mở Terminal tại thư mục gốc repo và chạy:

```powershell
dotnet run --project Day05.Week1Review
```

Sau khi chạy, chương trình hiển thị menu chính:

```text
===== DAY 5 - WEEK 1 REVIEW =====
1. Bai test 1 - Tinh hoa don co giam gia theo loai khach hang
2. Bai test 2 - Quan ly sinh vien bang List
3. Bai test 3 - Refactor code va dat ten bien ro rang
0. Thoat
Chon bai:
```

Nhập `1` để chạy Bài test 1.

Nhập `2` để chạy Bài test 2.

Nhập `3` để xem thông tin refactor của Bài test 3.

Nhập `0` để thoát chương trình.

Nếu nhập lựa chọn không hợp lệ, chương trình sẽ báo lỗi lựa chọn.

## Kiến thức đã ôn lại

- `Console.WriteLine` dùng để in dữ liệu ra màn hình.
- `Console.Write` dùng để in dữ liệu nhưng không xuống dòng.
- `Console.ReadLine` dùng để nhận dữ liệu người dùng nhập từ bàn phím.
- `string.IsNullOrWhiteSpace` dùng để kiểm tra chuỗi rỗng hoặc chỉ có khoảng trắng.
- `decimal.TryParse` dùng để chuyển chuỗi sang số tiền an toàn, tránh chương trình bị crash.
- `decimal` phù hợp để xử lý tiền tệ.
- `if/else` dùng để xử lý điều kiện.
- `switch/case` dùng để xử lý nhiều lựa chọn menu.
- `while` dùng để lặp menu chính hoặc menu con.
- `List<string>` dùng để lưu danh sách sinh viên.
- `Add` dùng để thêm phần tử vào danh sách.
- `Remove` dùng để xóa phần tử khỏi danh sách.
- `Count` dùng để kiểm tra số lượng phần tử trong danh sách.
- `foreach` dùng để duyệt từng sinh viên trong danh sách.
- `Trim` dùng để loại bỏ khoảng trắng thừa ở đầu và cuối chuỗi.
- `ToLower` dùng để chuyển chuỗi về chữ thường trước khi so sánh.
- `Contains` dùng để kiểm tra chuỗi có chứa chuỗi khác hay không.
- Function giúp chia nhỏ code thành từng phần dễ hiểu.
- Tên function nên mô tả rõ hành động, ví dụ `AddStudent`, `SearchStudents`, `RemoveStudent`.

## Test case

| Bài | Trường hợp | Dữ liệu nhập | Kết quả mong đợi |
|---|---|---|---|
| Menu chính | Chọn Bài test 1 | Chọn `1` | Chạy chức năng tính hóa đơn |
| Menu chính | Chọn Bài test 2 | Chọn `2` | Chạy menu quản lý sinh viên |
| Menu chính | Chọn Bài test 3 | Chọn `3` | Hiển thị thông tin refactor |
| Menu chính | Chọn sai menu | Chọn `9` | Báo lựa chọn không hợp lệ |
| Menu chính | Thoát chương trình | Chọn `0` | In lời chào tạm biệt và thoát chương trình |
| Bài test 1 | Tên khách hàng rỗng | Không nhập tên | Báo tên khách hàng không được để trống |
| Bài test 1 | Tổng tiền sai định dạng | Nhập `abc` | Báo tổng tiền phải là số lớn hơn `0` |
| Bài test 1 | Tổng tiền âm | Nhập `-100` | Báo tổng tiền phải là số lớn hơn `0` |
| Bài test 1 | Loại khách hàng sai | Chọn `9` | Báo loại khách hàng không hợp lệ |
| Bài test 1 | Khách thường | Tổng tiền `100000`, loại `1` | Không giảm giá |
| Bài test 1 | Khách bạc | Tổng tiền `100000`, loại `2` | Giảm `5%` |
| Bài test 1 | Khách vàng | Tổng tiền `100000`, loại `3` | Giảm `10%` |
| Bài test 1 | Khách kim cương | Tổng tiền `100000`, loại `4` | Giảm `15%` |
| Bài test 2 | Xem khi danh sách rỗng | Chọn xem danh sách khi chưa thêm sinh viên | Báo danh sách rỗng |
| Bài test 2 | Thêm sinh viên hợp lệ | Nhập `An` | Báo đã thêm sinh viên |
| Bài test 2 | Thêm tên rỗng | Không nhập tên | Báo tên sinh viên không được để trống |
| Bài test 2 | Xem danh sách | Sau khi thêm `An`, chọn xem | Hiển thị `- An` |
| Bài test 2 | Tìm đúng tên | Tìm `An` | Hiển thị `- An` |
| Bài test 2 | Tìm không phân biệt hoa/thường | Thêm `Nguyen Van An`, tìm `an` | Tìm thấy sinh viên phù hợp |
| Bài test 2 | Tìm không có kết quả | Tìm `xyz` | Báo không tìm thấy sinh viên phù hợp |
| Bài test 2 | Xóa sinh viên có tồn tại | Xóa `An` | Báo đã xóa sinh viên |
| Bài test 2 | Xóa sinh viên không tồn tại | Xóa `Binh` khi chưa có | Báo không tìm thấy sinh viên cần xóa |
| Bài test 2 | Quay lại menu chính | Chọn `0` trong menu sinh viên | Quay lại menu chính |

## Lỗi đã gặp

| Lỗi | Nguyên nhân | Cách xử lý |
|---|---|---|
| Người dùng có thể nhập sai số tiền | Dữ liệu từ `Console.ReadLine` là chuỗi | Dùng `decimal.TryParse` để kiểm tra trước khi tính toán |
| Tổng tiền có thể nhỏ hơn hoặc bằng `0` | Người dùng nhập số không hợp lệ về nghiệp vụ | Kiểm tra `totalAmount <= 0` và báo lỗi |
| Tên khách hàng hoặc sinh viên có thể bị rỗng | Người dùng nhấn Enter hoặc nhập toàn khoảng trắng | Dùng `string.IsNullOrWhiteSpace` |
| Danh sách sinh viên có thể rỗng | Người dùng chưa thêm sinh viên nhưng chọn xem/tìm/xóa | Kiểm tra `students.Count == 0` trước khi xử lý |
| Tìm kiếm có thể sai nếu phân biệt hoa/thường | Người dùng có thể nhập `an`, `AN` hoặc `An` | Chuyển tên sinh viên và từ khóa về chữ thường bằng `ToLower` |
| Code dài sau khi thêm nhiều chức năng | Nhiều logic nằm chung trong `switch/case` | Tách thành các function nhỏ như `AddStudent`, `SearchStudents`, `RemoveStudent` |
| Build bị fail vì file `.exe` bị khóa | Chương trình vẫn đang chạy ở terminal khác | Dừng chương trình bằng `Ctrl + C` rồi build lại |

## Phần chưa hiểu/cần luyện thêm

- Luyện thêm cách tách function nhỏ hơn trong Bài test 1.
- Luyện thêm cách function trả về dữ liệu như `decimal`, `bool` hoặc `string`.
- Luyện thêm cách xóa sinh viên không phân biệt hoa/thường.
- Luyện thêm cách thống kê số lượng sinh viên.
- Luyện thêm debug bằng breakpoint trong Visual Studio Code.
- Luyện thêm cách giảm warning nullable từ `Console.ReadLine`.

## Tự đánh giá

- Đã tạo được project Console App cho Day 5.
- Đã tạo được menu chính cho bài review tuần 1.
- Đã làm được Bài test 1: tính hóa đơn có giảm giá theo loại khách hàng.
- Đã biết dùng `decimal.TryParse` để validate số tiền.
- Đã làm được Bài test 2: quản lý sinh viên bằng `List<string>`.
- Đã biết thêm, xem, tìm và xóa sinh viên.
- Đã biết kiểm tra danh sách rỗng trước khi xử lý.
- Đã biết tìm kiếm chuỗi không phân biệt hoa/thường.
- Đã làm được Bài test 3: refactor code và đặt tên function rõ nghĩa.
- Đã biết chia code thành các function nhỏ để dễ đọc và dễ sửa hơn.
- Cần luyện thêm cách viết function có giá trị trả về và xử lý nullable tốt hơn.
