Bu proje, ASP.NET Core ile geliştirilmiş bir ürün listeleme uygulamasıdır. Uygulama iki ana bileşenden oluşur:

🔧 Backend (ASP.NET Core Web API)
Ürün verileri bir JSON dosyasından alınır ve RESTful API olarak sunulur.

Ürün fiyatları, popularityScore, weight ve güncel altın fiyatı (USD) kullanılarak dinamik olarak hesaplanır.

Gerçek zamanlı altın fiyatı bir dış API üzerinden alınmaktadır.

💻 Frontend (Razor Pages / MVC)
Ürünler şık bir arayüzde listelenir.

Ürünler arasında carousel desteği (oklar ve swipe).

Renk seçici ile ürün görselleri değiştirilebilir.

Popülerlik puanı 5 üzerinden 1 ondalık basamakla gösterilir.

📦 Özellikler
ASP.NET Core Web API

Dynamic pricing

Real-time gold price integration

Responsive tasarım

Carousel ve color picker desteği
