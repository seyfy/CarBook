# 🚗 CarBook – Araç Kiralama Platformu

CarBook, kullanıcıların araçları inceleyebildiği, araç kiralama işlemleri için rezervasyon oluşturabildiği ve yöneticilerin sistemdeki verileri yönetebildiği bir web uygulamasıdır. Proje, ASP.NET Core teknolojileri kullanılarak katmanlı mimari ve modern yazılım geliştirme yaklaşımları doğrultusunda geliştirilmiştir.

## 📌 Proje Hakkında

CarBook projesinin temel amacı, araç kiralama süreçlerini dijital ortama taşımak ve yönetim işlemlerini merkezi bir panel üzerinden gerçekleştirmektir.

Proje geliştirme sürecinde RESTful API tasarımı, veritabanı işlemleri, kimlik doğrulama, yetkilendirme ve yeniden kullanılabilir yazılım bileşenleri üzerinde çalışılmıştır.

## 🛠️ Kullanılan Teknolojiler

- **C#**
- **ASP.NET Core Web API**
- **ASP.NET Core MVC**
- **Entity Framework Core**
- **Microsoft SQL Server**
- **MediatR**
- **CQRS Pattern**
- **Repository Pattern**
- **DTO (Data Transfer Object)**
- **JWT Authentication**
- **Role-Based Authorization**
- **HttpClientFactory**
- **Newtonsoft.Json**
- **Chart.js**
- **HTML, CSS ve JavaScript**

## 🏗️ Mimari ve Tasarım Yaklaşımları

Proje içerisinde kullanılan başlıca mimari ve tasarım yaklaşımları:

- **Layered Architecture:** Uygulama sorumluluklarının katmanlara ayrılması.
- **CQRS Pattern:** Veri okuma ve değiştirme işlemlerinin ayrı komut ve sorgular üzerinden yönetilmesi.
- **Mediator Pattern:** MediatR aracılığıyla uygulama içindeki isteklerin ilgili handler sınıflarına yönlendirilmesi.
- **Repository Pattern:** Veri erişim işlemlerinin soyutlanması.
- **DTO Pattern:** Katmanlar ve API arasında taşınan verilerin düzenlenmesi.
- **Dependency Injection:** Bağımlılıkların merkezi olarak yönetilmesi.

## ✨ Temel Özellikler

- Araç, marka, kategori ve lokasyon bilgilerinin yönetimi.
- Araç kiralama ve rezervasyon işlemleri.
- Yönetim paneli üzerinden veri listeleme, ekleme, güncelleme ve silme.
- JWT tabanlı kimlik doğrulama.
- Rol bazlı yetkilendirme ile Admin işlemlerinin korunması.
- Web API üzerinden veri alışverişi.
- Dashboard üzerinde grafiklerle verilerin görselleştirilmesi.
- SQL Server üzerinde ilişkisel veri yönetimi.

## 📂 Proje Yapısı

Projede Web API, WebUI, DTO ve uygulama katmanları gibi farklı sorumluluklara sahip bileşenler bulunmaktadır.

```text
CarBook/
├── CarBook.Frontends/
├── CarBook.Application/
├── CarBook.Presentation/
└── CarBook.Infrastructure/
```


## 🔐 Güvenlik

Projede JWT tabanlı kimlik doğrulama ve rol bazlı yetkilendirme yaklaşımı kullanılmaktadır. Yönetim işlemleri, tanımlanan kullanıcı rollerine göre sınırlandırılmaktadır.

## ⚙️ Kurulum

1. Projeyi bilgisayarınıza klonlayın:

   ```bash
   git clone REPOSITORY_URL
   ```

2. Solution dosyasını Visual Studio ile açın.

3. `appsettings.json` veya ilgili yapılandırma dosyasında SQL Server bağlantı ayarlarını düzenleyin.

4. Gerekli NuGet paketlerini yükleyin.

5. Veritabanı migration'larını uygulayın veya projede tanımlanan veritabanını hazırlayın.

6. Web API ve WebUI projelerini başlatın.

7. Web API uç noktalarına Swagger üzerinden erişerek API işlemlerini test edin.

## 🎯 Projenin Kazandırdıkları

Bu proje kapsamında ASP.NET Core ile web uygulaması geliştirme, RESTful API tasarımı, katmanlı mimari, CQRS ve MediatR kullanımı, ilişkisel veritabanı yönetimi, JWT ile güvenlik ve istemci-sunucu iletişimi konularında deneyim kazanılması hedeflenmiştir.

## 👨‍💻 Geliştirici

**Seyfullah Yalçın**

Computer Engineering Student | .NET Developer Candidate

- GitHub: GITHUB_PROFIL_LINKIN
- LinkedIn: LINKEDIN_PROFIL_LINKIN
