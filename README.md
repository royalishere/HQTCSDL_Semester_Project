<h1 align = "center">
    HQTCSDL_SEMESTER_PROJECT
</h1>

## Cài đặt chương trình: 
Tải về dưới dạng file nén (.zip) và chạy file HTDatGiao.sln hoặc clone reposity bằng lệnh git:
```
git clone https://github.com/YuriToshiro/HQTCSDL_Semester_Project
```

## Môi trường cần thiết:
**1. Nuget Packages:**
- Microsoft.Data.SqlClient (current ver 5.0.1)
- System.Data.SqlClient (current ver 4.8.5)
- Microsoft.EntityFrameworkCore.SqlServer (current ver 7.0.0)
- Microsoft.EntityFrameworkCore.Tools (current ver 7.0.0)

**2. IDE và các tools hỗ trợ lập trình Winforms (Microsoft Visual Studio)**

## Cài đặt Nuget Pakages trên Microsoft Visual Studio (MVS):
Sau khi mở solution file (.sln) trên MVS, chuột phải vào project đầu tiên và chọn `Manage Nuget Packages...`. 
Cửa sổ Package Manager hiện ra, tại tab Browse, tìm và cài đặt 4 Packages đã nêu trên.
<br>
Tại `View> Other Windows>` chọn **Package Manger Console** và dùng lệnh được cung cấp tại `UserClass.cs` để xây dựng **Entity Model**:
```
scaffold-dbContext "Server=<YOUR_SERVER_NAME>;Database=HTDatGiaoThucAn;User ID=HT_AD;Password=admin;Trust Server Certificate=true" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models -f
```
Đồng thời, thay đổi _server_name_ tại `UserClass.cs` theo **SERVER_NAME** của hệ quản trị hệ thống.
Build Debug và chạy chương trình. Sẽ tốn một ít thời gian để kết nối database trước khi form được mở.

## Thành viên nhóm
|     Họ và tên        |
|----------------------|
| Trương Cao Hoàng Gia |
|    Phạm Quốc Hùng    |
|   Nguyễn Nhật Khang  |
|   Nguyễn Đức Quang   |
