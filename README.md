CSharp-WinForm/PAIRING-MESSAGE-APPLICATION
=================================================
Application to pair messaging using Socket programming.

1. The source code includes 1 Server and 2 Client (LAN - WAN). Client-WAN to connect to a server outside the Internet for demo.

2. The server IP in the source code is IP Loopback, only used for testing with Client LAN.

3. Server configuration for Client WAN I rented when working on the project is no longer available.  
If you want to test the application on the Internet, find a way to Publicize the server's code, change the IP for it at: Server > Program Class > Main Funct.  
Change the connection IP for Client-WAN at: Client-Wan > GlobalConnect Class.

5. The function related to Email will be broken (because Email in the source code no longer exists).  
Change it at: Server > Program Class > GetNumberValiddationEmail Funct.

6. This project I do to store everything with the .text file, so there is no need to set up SQL Server.


Ứng dụng ghép đôi nhắn tin bằng lập trình Socket.
=================================================

1. Mã nguồn bao gồm 1 Server và 2 Client (LAN - WAN). Client-WAN để kết nối tới 1 máy chủ ngoài Internet để demo.

2. IP máy chủ trong mã nguồn là IP Loopback, chỉ dùng để test với Client LAN.

3. Cấu hình Server cho Client WAN mình thuê lúc làm dự án đã không còn.  
   Nếu muốn test thử ứng dụng trên Intrernet hãy tìm cách Public đoạn mã của Server, thay đổi IP cho nó tại: Server > Program Class > Main Funct.  
   Thay đổi IP kết nối cho Client-WAN tại: Client-Wan > GlobalConnect Class.

5. Phần chức năng liên quan tới Email sẽ bị lỗi (vì Email trong mã nguồn không còn tồn tại).  
   Hãy thay đổi nó tại: Server > Program Class > GetNumberValiddationEmail Funct.

6. Dự án này mình làm lưu trữ mọi thứ với file .text, nên không cần setup SQL Server.
