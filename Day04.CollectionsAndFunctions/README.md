# Day 04 - Collections And Functions

## Mục tiêu

- Luyện sử dụng `List<string>` để lưu nhiều dữ liệu dạng chuỗi.
- Luyện tạo menu Console để chọn bài thực hành.
- Luyện tách logic thành function để code dễ đọc hơn.
- Luyện truyền dữ liệu vào function thông qua tham số.
- Luyện kiểm tra dữ liệu nhập rỗng bằng `string.IsNullOrWhiteSpace`.
- Luyện duyệt danh sách bằng `foreach`.
- Luyện xử lý chuỗi với `Trim`, `ToLower` và `Contains`.
- Luyện kiểm tra ký tự viết hoa bằng `char.IsUpper`.

## Bài đã hoàn thành

### Bài 1: Quản lý danh sách sinh viên bằng List<string>

Chương trình cho phép quản lý danh sách sinh viên bằng `List<string>`.

Chức năng đã làm:

- Thêm sinh viên vào danh sách.
- Xem danh sách sinh viên đã thêm.
- Kiểm tra tên sinh viên không được để trống.
- Báo danh sách rỗng nếu chưa có sinh viên nào.
- Cho phép quay lại menu chính.

Chương trình dùng `List<string>` để lưu nhiều tên sinh viên.

Menu con của Bài 1:

```text
===== BAI 1 - QUAN LY DANH SACH SINH VIEN =====
1. Them sinh vien
2. Xem danh sach sinh vien
0. Quay lai menu chinh
Chon chuc nang:
```

### Bài 2: Tìm kiếm sinh viên không phân biệt hoa/thường

Chương trình cho phép tìm kiếm sinh viên trong danh sách đã thêm ở Bài 1.

Chức năng đã làm:

- Kiểm tra danh sách sinh viên có rỗng không trước khi tìm kiếm.
- Cho phép nhập từ khóa tìm kiếm.
- Kiểm tra từ khóa tìm kiếm không được để trống.
- Tìm kiếm sinh viên theo một phần tên.
- Tìm kiếm không phân biệt chữ hoa và chữ thường.
- Hiển thị tất cả sinh viên phù hợp với từ khóa.
- Báo không tìm thấy nếu không có sinh viên phù hợp.

Ví dụ:

```text
Danh sách sinh viên: Nguyen Van An, Tran Thi Binh
Từ khóa tìm kiếm: an
Kết quả: Nguyen Van An, Tran Thi Binh
```

Lý do cả hai tên đều được tìm thấy là vì sau khi chuyển về chữ thường:

```text
nguyen van an
tran thi binh
```

cả hai đều có chứa chuỗi `an`.

### Bài 3: Tách các chức năng menu thành function riêng

Bài 3 tập trung vào refactor code: giữ nguyên chức năng đã có nhưng tách code thành nhiều function nhỏ, rõ nhiệm vụ hơn.

Các phần đã tách:

- `ShowMainMenu`: hiển thị menu chính Day 4.
- `HandleMainMenuChoice`: xử lý lựa chọn ở menu chính.
- `ShowStudentMenu`: hiển thị menu con quản lý sinh viên.
- `HandleStudentMenuChoice`: xử lý lựa chọn ở menu con quản lý sinh viên.
- `AddStudent`: thêm sinh viên vào danh sách.
- `ShowStudents`: hiển thị danh sách sinh viên.
- `SearchStudents`: tìm kiếm sinh viên trong danh sách.
- `RunFunctionRefactorExercise`: hiển thị thông tin Bài 3 đã được áp dụng trong code.

Lợi ích của việc tách function:

- Code ngắn hơn trong từng phần.
- Dễ đọc hơn vì mỗi function có một nhiệm vụ rõ ràng.
- Dễ sửa lỗi hơn vì biết logic nằm ở function nào.
- Có thể tái sử dụng function ở nhiều nơi nếu cần.

### Mini challenge: Kiểm tra mật khẩu

Chương trình cho phép nhập một mật khẩu mẫu và kiểm tra mật khẩu có hợp lệ không.

Điều kiện hợp lệ:

- Độ dài mật khẩu phải lớn hơn hoặc bằng `8` ký tự.
- Mật khẩu phải có ít nhất `1` ký tự viết hoa.
- Mật khẩu không được để trống.

Chức năng đã làm:

- Nhập mật khẩu từ bàn phím.
- Kiểm tra mật khẩu rỗng bằng `string.IsNullOrWhiteSpace`.
- Kiểm tra độ dài bằng `password.Length >= 8`.
- Duyệt từng ký tự trong mật khẩu bằng `foreach`.
- Kiểm tra ký tự viết hoa bằng `char.IsUpper`.
- Thông báo mật khẩu hợp lệ hoặc không hợp lệ.

## Cách chạy chương trình

Mở Terminal tại thư mục gốc repo và chạy:

```powershell
dotnet run --project Day04.CollectionsAndFunctions
```

Sau khi chạy, chương trình hiển thị menu chính:

```text
===== DAY 4 - COLLECTIONS AND FUNCTIONS =====
1. Bai 1 - Quan ly danh sach sinh vien
2. Bai 2 - Tim kiem sinh vien
3. Bai 3 - Tach chuc nang thanh function
4. Mini challenge - Kiem tra mat khau
0. Thoat
Chon bai:
```

Nhập `1` để chạy Bài 1.

Nhập `2` để chạy Bài 2.

Nhập `3` để xem thông tin Bài 3 đã được áp dụng bằng cách tách function.

Nhập `4` để chạy mini challenge kiểm tra mật khẩu.

Nhập `0` để thoát chương trình.

Nếu nhập lựa chọn không hợp lệ, chương trình sẽ báo lỗi lựa chọn.

## Kiến thức đã hiểu

- `List<string>` dùng để lưu danh sách nhiều chuỗi, ví dụ danh sách tên sinh viên.
- `students.Add(studentName)` dùng để thêm sinh viên vào danh sách.
- `students.Count` dùng để kiểm tra số lượng sinh viên trong danh sách.
- `foreach` dùng để duyệt từng sinh viên trong danh sách hoặc từng ký tự trong chuỗi.
- `string.IsNullOrWhiteSpace` dùng để kiểm tra chuỗi rỗng hoặc chỉ có khoảng trắng.
- `Trim` dùng để loại bỏ khoảng trắng thừa ở đầu và cuối chuỗi.
- `while` dùng để lặp menu chính hoặc menu con.
- `switch/case` dùng để xử lý lựa chọn menu.
- `default` dùng để xử lý lựa chọn không hợp lệ.
- `break` dùng để kết thúc một nhánh xử lý trong `switch` hoặc dừng vòng lặp khi đã tìm thấy điều kiện cần.
- Function giúp tách code thành từng phần nhỏ, dễ đọc và dễ sửa hơn.
- Tham số function giúp truyền dữ liệu từ bên ngoài vào function để xử lý.
- Function có kiểu trả về `bool` có thể dùng để quyết định menu có tiếp tục chạy hay không.
- `ToLower` dùng để chuyển chuỗi về chữ thường trước khi so sánh.
- `Contains` dùng để kiểm tra một chuỗi có chứa chuỗi khác hay không.
- Biến `bool` có thể dùng để đánh dấu đã tìm thấy kết quả hay chưa.
- Dữ liệu sinh viên nên được lưu ở phạm vi dùng chung để Bài 1 thêm sinh viên và Bài 2 tìm kiếm được cùng danh sách.
- `password.Length` dùng để kiểm tra độ dài mật khẩu.
- `char.IsUpper` dùng để kiểm tra một ký tự có phải chữ viết hoa hay không.

## Test case

| Bài | Trường hợp | Dữ liệu nhập | Kết quả mong đợi |
|---|---|---|---|
| Menu chính | Chọn Bài 1 | Chọn `1` | Chạy menu con quản lý danh sách sinh viên |
| Menu chính | Chọn sai menu | Chọn `9` | Báo lựa chọn không hợp lệ |
| Menu chính | Thoát chương trình | Chọn `0` | In lời chào tạm biệt và thoát chương trình |
| Bài 1 | Thêm sinh viên hợp lệ | Chọn `1`, chọn `1`, nhập `An` | Báo đã thêm sinh viên |
| Bài 1 | Xem danh sách | Sau khi thêm `An`, chọn `2` | Hiển thị `- An` |
| Bài 1 | Thêm nhiều sinh viên | Thêm `An`, `Binh`, `Cuong`, chọn `2` | Hiển thị đủ các sinh viên đã thêm |
| Bài 1 | Tên sinh viên rỗng | Chọn `1`, nhập rỗng | Báo tên sinh viên không được để trống |
| Bài 1 | Danh sách rỗng | Chọn `2` khi chưa thêm sinh viên | Báo danh sách sinh viên đang rỗng |
| Bài 1 | Chọn sai menu con | Chọn `9` trong menu con | Báo lựa chọn không hợp lệ |
| Bài 1 | Quay lại menu chính | Chọn `0` trong menu con | Quay lại menu chính Day 4 |
| Bài 2 | Danh sách rỗng | Chọn `2` khi chưa thêm sinh viên | Báo danh sách sinh viên đang rỗng |
| Bài 2 | Tìm đúng tên | Thêm `An`, chọn `2`, tìm `An` | Hiển thị `- An` |
| Bài 2 | Tìm không phân biệt hoa/thường | Thêm `Nguyen Van An`, tìm `an` hoặc `AN` | Vẫn tìm thấy sinh viên phù hợp |
| Bài 2 | Tìm theo một phần tên | Thêm `Nguyen Van An`, tìm `nguyen` | Hiển thị `- Nguyen Van An` |
| Bài 2 | Từ khóa rỗng | Chọn `2`, nhập rỗng | Báo từ khóa tìm kiếm không được để trống |
| Bài 2 | Không tìm thấy | Tìm `xyz` | Báo không tìm thấy sinh viên phù hợp |

| Bài 3 | Chọn Bài 3 | Chọn `3` | Hiển thị thông tin Bài 3 đã được áp dụng bằng cách tách function |
| Mini challenge | Mật khẩu rỗng | Chọn `4`, nhập rỗng | Báo mật khẩu không được để trống |
| Mini challenge | Mật khẩu quá ngắn | Nhập `Abc123` | Báo mật khẩu không hợp lệ |
| Mini challenge | Đủ dài nhưng không có chữ hoa | Nhập `abc12345` | Báo mật khẩu không hợp lệ |
| Mini challenge | Có chữ hoa nhưng quá ngắn | Nhập `Abc123` | Báo mật khẩu không hợp lệ |
| Mini challenge | Mật khẩu hợp lệ | Nhập `Abc12345` | Báo mật khẩu hợp lệ |

## Lỗi đã gặp

| Lỗi | Nguyên nhân | Cách xử lý |
|---|---|---|
| Ban đầu định làm danh sách điểm cho Bài 1 | Chưa đối chiếu kỹ roadmap Day 4 | Đọc lại tài liệu và sửa đúng thành quản lý danh sách sinh viên bằng `List<string>` |
| Người dùng có thể nhập tên rỗng | Dữ liệu từ `Console.ReadLine` có thể là chuỗi rỗng hoặc chỉ có khoảng trắng | Dùng `string.IsNullOrWhiteSpace` để kiểm tra |
| Danh sách có thể rỗng khi người dùng chọn xem | Chưa có sinh viên nào được thêm vào `List<string>` | Kiểm tra `students.Count == 0` trước khi dùng `foreach` |
| Dữ liệu sinh viên cần dùng lại ở bài khác | Nếu tạo danh sách bên trong một function riêng thì bài khác khó dùng chung | Tạo danh sách ở phạm vi menu chính và truyền vào function qua tham số |
| Tìm kiếm có thể bị sai nếu so sánh phân biệt hoa/thường | Người dùng có thể nhập `an`, `AN` hoặc `An` | Chuyển cả tên sinh viên và từ khóa về chữ thường bằng `ToLower` trước khi dùng `Contains` |
| Người dùng có thể nhập từ khóa rỗng | Dữ liệu từ `Console.ReadLine` có thể rỗng hoặc chỉ có khoảng trắng | Dùng `string.IsNullOrWhiteSpace` để kiểm tra trước khi tìm |

| Code bắt đầu dài khi thêm nhiều bài | Nhiều logic nằm chung trong menu và `switch/case` | Tách menu và chức năng thành các function riêng |
| Kiểm tra mật khẩu cần xét từng ký tự | Không thể chỉ dùng `Length` để biết có chữ hoa hay không | Dùng `foreach` để duyệt từng ký tự và `char.IsUpper` để kiểm tra |

## Phần chưa hiểu/cần luyện thêm

- Luyện thêm cách truyền `List<string>` vào function.
- Luyện thêm cách đặt tên function rõ nghĩa.
- Luyện thêm cách chia nhỏ chức năng thêm, xem, tìm kiếm thành các function riêng.
- Luyện thêm các thao tác với `List<T>` như tìm kiếm, xóa và thống kê.
- Luyện thêm xử lý chuỗi không phân biệt hoa/thường.
- Luyện thêm cách dùng function trả về dữ liệu như `bool`, `string` hoặc `int`.
- Luyện thêm các hàm xử lý ký tự như `char.IsUpper`, `char.IsLower` và `char.IsDigit`.

## Tự đánh giá

- Đã tạo được project Console App cho Day 4.
- Đã tạo được menu chính cho Day 4.
- Đã làm đúng Bài 1 theo roadmap: quản lý danh sách sinh viên bằng `List<string>`.
- Đã biết thêm sinh viên vào danh sách.
- Đã biết xem danh sách sinh viên bằng `foreach`.
- Đã biết kiểm tra tên sinh viên rỗng.
- Đã biết kiểm tra danh sách rỗng trước khi hiển thị.
- Đã làm đúng Bài 2 theo roadmap: tìm kiếm sinh viên không phân biệt hoa/thường.
- Đã biết dùng `ToLower` và `Contains` để tìm kiếm chuỗi cơ bản.
- Đã biết kiểm tra danh sách rỗng và từ khóa rỗng trước khi tìm kiếm.
- Đã làm đúng Bài 3 theo roadmap: tách các chức năng menu thành function riêng.
- Đã biết tách function hiển thị menu, xử lý menu, thêm sinh viên, xem sinh viên và tìm kiếm sinh viên.
- Đã hoàn thành mini challenge kiểm tra mật khẩu.
- Đã biết dùng `Length` và `char.IsUpper` để kiểm tra điều kiện mật khẩu.
