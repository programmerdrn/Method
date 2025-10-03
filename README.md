🛠️ Method - C# Method Examples & Patterns
کتابخانه جامع مثال‌ها و الگوهای متد در زبان C# - آموزش کامل مفاهیم تابع‌نویسی و معماری نرم‌افزار

https://img.shields.io/badge/C%2523-239120?style=for-the-badge&logo=c-sharp&logoColor=white
https://img.shields.io/badge/.NET-512BD4?style=for-the-badge&logo=dotnet&logoColor=white
https://img.shields.io/badge/Methods-Functions%2520%2526%2520Patterns-orange?style=for-the-badge
https://img.shields.io/badge/GitHub-Open%2520Source-181717?style=for-the-badge&logo=github

https://img.shields.io/github/stars/programmerdrn/Method
https://img.shields.io/github/forks/programmerdrn/Method
https://img.shields.io/github/issues/programmerdrn/Method

✨ ویژگی‌ها
✅ انواع متدها: void, return, static, instance, extension

✅ پارامترهای مختلف: value, reference, out, ref, params

✅ متدهای پیشرفته: async, recursive, generic, lambda

✅ الگوهای طراحی: Factory, Singleton, Strategy

✅ کدهای کامنت‌گذاری شده: آموزش گام به گام

🏗️ ساختار پروژه
text
Method/
├── Program.cs                     # فایل اصلی برنامه
├── BasicMethods/                  # متدهای پایه
│   ├── VoidMethods.cs            # متدهای بدون بازگشت
│   ├── ReturnMethods.cs          # متدهای با بازگشت
│   └── ParameterTypes.cs         # انواع پارامتر
├── AdvancedMethods/               # متدهای پیشرفته
│   ├── AsyncMethods.cs           # متدهای ناهمگام
│   ├── ExtensionMethods.cs       # متدهای توسعه‌دهنده
│   ├── GenericMethods.cs         # متدهای جنریک
│   └── RecursiveMethods.cs       # متدهای بازگشتی
├── DesignPatterns/               # الگوهای طراحی
│   ├── FactoryPattern.cs         # الگوی کارخانه
│   ├── SingletonPattern.cs       # الگوی singleton
│   └── StrategyPattern.cs        # الگوی استراتژی
└── README.md
🚀 نحوه اجرا
پیش‌نیازها
.NET 6.0 یا بالاتر

اجرای پروژه
bash
# کلون کردن ریپوزیتوری
git clone https://github.com/programmerdrn/Method.git
cd Method

# اجرای پروژه
dotnet run
💡 مثال‌های متدهای مختلف
۱. متدهای پایه (Basic Methods)
متد void
csharp
public void GreetUser(string name)
{
    Console.WriteLine($"سلام {name}!");
    Console.WriteLine("خوش آمدید!");
}

// استفاده
GreetUser("محمد");  // خروجی: سلام محمد! خوش آمدید!
متد با مقدار بازگشتی
csharp
public int AddNumbers(int a, int b)
{
    return a + b;
}

// استفاده
int result = AddNumbers(5, 3);  // result = 8
متد static
csharp
public static class MathHelper
{
    public static double CalculateCircleArea(double radius)
    {
        return Math.PI * radius * radius;
    }
}

// استفاده
double area = MathHelper.CalculateCircleArea(5);  // area ≈ 78.54
۲. انواع پارامترها
پارامتر عادی (Value)
csharp
public void UpdateScore(int score)
{
    score = 100;  // فقط کپی مقدار تغییر می‌کند
}
پارامتر ref
csharp
public void UpdateScoreRef(ref int score)
{
    score = 100;  // مقدار اصلی تغییر می‌کند
}

// استفاده
int myScore = 50;
UpdateScoreRef(ref myScore);  // myScore = 100
پارامتر out
csharp
public bool TryParseNumber(string input, out int result)
{
    return int.TryParse(input, out result);
}

// استفاده
if (TryParseNumber("123", out int number))
{
    Console.WriteLine($"عدد معتبر: {number}");  // 123
}
پارامتر params
csharp
public int Sum(params int[] numbers)
{
    return numbers.Sum();
}

// استفاده
int total = Sum(1, 2, 3, 4, 5);  // total = 15
۳. متدهای پیشرفته
متد بازگشتی (Recursive)
csharp
public int Factorial(int n)
{
    if (n <= 1) return 1;
    return n * Factorial(n - 1);
}

// استفاده
int fact = Factorial(5);  // fact = 120
متد جنریک (Generic)
csharp
public T GetMax<T>(T a, T b) where T : IComparable<T>
{
    return a.CompareTo(b) > 0 ? a : b;
}

// استفاده
int maxInt = GetMax(10, 20);        // 20
string maxStr = GetMax("A", "B");   // "B"
متد توسعه‌دهنده (Extension)
csharp
public static class StringExtensions
{
    public static string ToTitleCase(this string text)
    {
        if (string.IsNullOrEmpty(text))
            return text;
            
        return char.ToUpper(text[0]) + text.Substring(1).ToLower();
    }
}

// استفاده
string name = "mohammad";
string title = name.ToTitleCase();  // "Mohammad"
متد ناهمگام (Async)
csharp
public async Task<string> DownloadDataAsync(string url)
{
    using var client = new HttpClient();
    return await client.GetStringAsync(url);
}

// استفاده
string data = await DownloadDataAsync("https://api.example.com/data");
۴. الگوهای طراحی با متدها
الگوی Strategy
csharp
public interface IPaymentStrategy
{
    void Pay(decimal amount);
}

public class CreditCardPayment : IPaymentStrategy
{
    public void Pay(decimal amount)
    {
        Console.WriteLine($"پرداخت {amount} تومان با کارت اعتباری");
    }
}

public class CashPayment : IPaymentStrategy
{
    public void Pay(decimal amount)
    {
        Console.WriteLine($"پرداخت {amount} تومان نقدی");
    }
}

public class PaymentProcessor
{
    private IPaymentStrategy _strategy;
    
    public void SetStrategy(IPaymentStrategy strategy)
    {
        _strategy = strategy;
    }
    
    public void ProcessPayment(decimal amount)
    {
        _strategy.Pay(amount);
    }
}
🎯 مفاهیم آموزشی
اصول متدنویسی تمیز:
نام‌گذاری معنادار

مسئولیت واحد (Single Responsibility)

اندازه مناسب (کوتاه و متمرکز)

مستندات کامل

امنیت و کارایی:
validation ورودی‌ها

مدیریت خطا (try/catch)

بهینه‌سازی performance

🧪 تست متدها
csharp
// واحد تست برای متدها
[Test]
public void AddNumbers_ShouldReturnCorrectSum()
{
    // Arrange
    var calculator = new Calculator();
    
    // Act
    int result = calculator.AddNumbers(2, 3);
    
    // Assert
    Assert.AreEqual(5, result);
}
🎓 سطوح یادگیری
✅ مبتدی: متدهای ساده و پارامترها

✅ متوسط: متدهای static، extension، recursive

✅ پیشرفته: جنریک، async، الگوهای طراحی

🤝 مشارکت در توسعه
ریپو را Fork کنید

Branch جدید ایجاد کنید (git checkout -b feature/method-enhancement)

تغییرات را Commit کنید (git commit -m 'Add new method patterns')

Branch را Push کنید (git push origin feature/method-enhancement)

Pull Request ایجاد کنید

📄 لایسنس
این پروژه تحت لایسنس MIT منتشر شده است.

👨‍💻 توسعه‌دهنده
programmerdrn - GitHub Profile

⭐ اگر این پروژه آموزشی برایتان مفید بود، حتما به آن Star بدهید!

💬 پشتیبانی
📧 ایجاد Issue در گیتهاب برای گزارش باگ یا پیشنهاد

🔄 پیشنهاد الگوهای متد جدید

