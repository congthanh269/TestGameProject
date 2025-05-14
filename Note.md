Nhược điểm:
Chưa có object pooling khiến việc hủy và tạo item liên tục tốn hiệu năng
Sử dụng Resource.load để khởi tạo object có chi phí hiệu năng cao

Ưu điểm:
Dùng các prefab từ resource để tạo các gameobject giúp giảm thiểu việc quản lý qua inspector
Các hàm chức năng được chia tách rõ ràng theo từng script

Đề xuất:
Có thể kết hợp factory pattern để việc tạo item dễ mở rộng (vd tạo item random, tạo item không trùng, khởi tạo các item theo nhiều logic khác nhau)
Tích hợp object pooling

