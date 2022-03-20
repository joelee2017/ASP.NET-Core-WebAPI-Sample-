# ASP.NET-Core-WebAPI-Sample
ASP.NET Core - Web API - Sample 

ASP.NET Core 6.0

教學課程：使用 ASP.NET Core 建立 Web API：https://docs.microsoft.com/zh-tw/aspnet/core/tutorials/first-web-api?view=aspnetcore-6.0&tabs=visual-studio

體驗全新 ASP.NET Core 6.0 專案範本與 C# 10 語言特性：https://blog.miniasp.com/post/2021/10/25/ASP-NET-Core-6-Project-Template-and-CSharp-10-New-Features

.NET 6 亮點快速巡覽：https://blog.darkthread.net/blog/dotnet-6-release/

------

ASP.NET Core 6.0 - Web API 測試

安裝 HTTP 複寫
dotnet tool install -g Microsoft.dotnet-httprepl

開啟新的終端機視窗
POST 呼叫
httprepl https://localhost:7199/api/todoitems 
post -h Content-Type=application/json -c "{"name":"walk dog","isComplete":true}"

測試位置標頭 URI
connect https://localhost:7199/api/todoitems/1

檢查 GET 方法
connect https://localhost:7199/api/todoitems

PUT 呼叫
connect https://localhost:7199/api/todoitems/1
put -h Content-Type=application/json -c "{"id":1,"name":"feed fish","isComplete":true}"

Delete 呼叫
connect https://localhost:7199/api/todoitems/1
delete

------

使用 JavaScript 呼叫 Web API

https://docs.microsoft.com/zh-tw/aspnet/core/tutorials/web-api-javascript?view=aspnetcore-6.0
