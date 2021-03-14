## Projede Kullanılanlar
### C#-ASP.NET Core Mvc 2.1
### N-tier Architecture(Entity-Data Access Layer-Business Logic Layer-Core-WebUI)
### Generic Repository Design Pattern

## Projeyi başka bilgisayarda çalıştırmak
### Asp.net Core 2.1 SDK ve MSSQL Server'ın yüklü olması gerekmektedir.
### Öncelikle GraduateDb.sql isimli dosyayı kendi MSSQL Management Studio'ya girip new query'den dosyayı sürekleyip bıraktıktan sonra execute diyerek veritabanımız yüklenmiş olur.Ardından projedeki GraduateStudent.Dal/Concrete/EntityFramework/GraduateStudentContext.cs buradaki dosyayı optionsBuilder.UseSqlServer içindeki yere kendi veritabanı bağlantı yolumuzu göstermemiz gerekmektedir bunları yaptıktan sonra proje çalışacaktır.


