CSharp-WinForm/PAIRING-MESSAGE-APPLICATION
=================================================
Ứng dụng ghép đôi nhắn tin bằng lập trình Socket.

1. Mã nguồn bao gồm 1 Server và 2 Client (LAN - WAN). Client-WAN để kết nối tới 1 máy chủ ngoài Internet để demo.

2. IP máy chủ trong mã nguồn là IP Loopback, chỉ dùng để test với Client LAN.

3. Cấu hình Server cho Client WAN mình thuê lúc làm dự án đã không còn.  
   Nếu muốn test thử ứng dụng trên Intrernet hãy tìm cách Public đoạn mã của Server, thay đổi IP cho nó tại: Server > Program Class > Main Funct.  Thay đổi IP kết nối cho Client-WAN tại: Client-Wan > GlobalConnect Class.

4. Phần chức năng liên quan tới Email sẽ bị lỗi (vì Email trong mã nguồn không còn tồn tại).  
   Hãy thay đổi nó tại: Server > Program Class > GetNumberValiddationEmail Funct.

5. Dự án này mình làm lưu trữ mọi thứ với file .text, nên không cần setup SQL Server.
