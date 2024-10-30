# Sayı Karesi Hesaplama Programı

Bu program, kullanıcıdan bir sayı değeri alır ve bu sayının karesini ekrana yazdırır. Kullanıcıdan geçerli bir sayı alınana kadar tekrar eden bir `while` döngüsü ile hataların kontrolünü yapar.

## Özellikler

- **Geçerli Sayı Kontrolü**: Kullanıcının yalnızca sayı girmesi gerekmektedir. Geçersiz formatta bir giriş yapılırsa program, kullanıcıyı uyarır ve tekrar giriş yapılmasını ister.
- **Taşma Kontrolü**: Girilen sayı, `Int16` veri tipinin sınırları dışında ise program kullanıcıya bir hata mesajı gösterir ve tekrar giriş yapılmasını ister.
- **Hata Yakalama**: `try-catch` blokları ile `FormatException` ve `OverflowException` hatalarını yakalar.

## Kullanılan Yapılar

- `while` döngüsü: Kullanıcıdan geçerli bir giriş alana kadar çalışır.
- `try-catch-finally` blokları: Hataları yakalamak için kullanılır.
  - `FormatException`: Kullanıcı geçersiz bir giriş (örneğin bir metin) girdiğinde yakalanır.
  - `OverflowException`: Kullanıcı `Int16` sınırları dışında bir sayı girdiğinde yakalanır.
  
## Program Çalışma Mantığı

1. Kullanıcıdan bir sayı girmesi istenir.
2. Kullanıcı geçerli bir sayı girerse, program bu sayının karesini hesaplar ve sonucu ekrana yazdırır.
3. Geçersiz bir sayı girildiğinde veya sınırların dışında bir sayı girildiğinde uygun hata mesajı ekrana yazdırılır.
4. Hatalı giriş yapılırsa program tekrar giriş yapılmasını ister, geçerli bir sayı girildiğinde işlem sonlandırılır ve "İşlem Tamamlandı" mesajı ekrana yazdırılır.
