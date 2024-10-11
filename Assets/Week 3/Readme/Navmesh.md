# Sử Dụng NavMesh Obstacle Trong Unity

## Hỏi AI: Cách Sử Dụng NavMesh Obstacle
- Tạo NavMesh:
Đảm bảo bạn đã tạo một NavMesh cho cảnh của mình. Bạn có thể sử dụng cửa sổ Navigation để tạo và baking NavMesh.
- Thêm NavMesh Obstacle:
Chọn đối tượng bạn muốn biến thành vật cản.
Trong cửa sổ Inspector, thêm thành phần NavMesh Obstacle.
- Cấu hình:
Shape: Chọn hình dạng cho vật cản (Capsule hoặc Box).
Carve: Khi bật, vật cản sẽ tạo lỗ trên NavMesh khi dừng lại.
Move Threshold: Khoảng cách tối thiểu mà vật cản phải di chuyển để cập nhật lỗ trên NavMesh.
Time To Stationary: Thời gian chờ để coi vật cản là tĩnh và bắt đầu tạo lỗ.
Carve Only Stationary: Chỉ tạo lỗ khi vật cản đứng yên.
- Điều chỉnh trong quá trình chạy:
Kích hoạt/vô hiệu hóa: Bạn có thể bật/tắt thành phần NavMesh Obstacle trong quá trình chạy để kiểm soát khi nào đối tượng trở thành vật cản.
Thay đổi kích thước: Điều chỉnh kích thước của vật cản để ảnh hưởng đến vùng cản trở trên NavMesh.
### NavMesh Obstacle là gì?

**NavMesh Obstacle** là một thành phần trong Unity được sử dụng để tạo ra các vật cản trong môi trường, ngăn cản các nhân vật hoặc đối tượng điều hướng (navigation) qua những khu vực nhất định. Đối tượng được gắn **NavMesh Obstacle** sẽ trở thành vật cản và có thể tĩnh hoặc động, tùy thuộc vào cách bạn cấu hình nó.
