// Создание объектов DateTime
DateTime now = DateTime.Now; // Текущие дата и время
DateTime today = DateTime.Today; // Текущая дата с временем 00:00:00
// DateTime specificDate = new DateTime(2024, 1, 1); // 1 января 2024 года
DateTime specificDate = new(2024, 1, 1); // 1 января 2024 года
Console.WriteLine($"Текущие дата и время: {now}");
Console.WriteLine($"Текущая дата: {today}");
Console.WriteLine($"Специфическая дата: {specificDate}");

// Манипуляции с датами
DateTime tomorrow = now.AddDays(1);
DateTime nextMonth = now.AddMonths(1);
DateTime nextYear = now.AddYears(1);
DateTime oneHourLater = now.AddHours(1);
Console.WriteLine($"Завтра: {tomorrow}");
Console.WriteLine($"Следующий месяц: {nextMonth}");
Console.WriteLine($"Следующий год: {nextYear}");
Console.WriteLine($"Через один час: {oneHourLater}");

// Использование TimeSpan
TimeSpan tenDays = TimeSpan.FromDays(10);
DateTime tenDaysFromNow = now.Add(tenDays);
Console.WriteLine($"Через десять дней будет: {tenDaysFromNow}");

// Форматирование даты и времени
string formattedDate = now.ToString("yyyy-MM-dd HH:mm:ss");
Console.WriteLine($"Отформатированная дата и время: {formattedDate}");

// Работа с часовыми поясами
TimeZoneInfo localZone = TimeZoneInfo.Local; // Локальный часовой пояс
DateTime utcNow = DateTime.UtcNow; // UTC время
DateTime localTime = TimeZoneInfo.ConvertTimeFromUtc(utcNow, localZone); // Преобразование UTC в локальное время
Console.WriteLine($"Локальное время: {localTime}");
Console.WriteLine($"UTC время: {utcNow}");

// Использование DateTimeOffset
DateTimeOffset nowOffset = DateTimeOffset.Now;
DateTimeOffset utcNowOffset = DateTimeOffset.UtcNow;
Console.WriteLine($"Текущее время с учетом смещения: {nowOffset}");
Console.WriteLine($"Текущее UTC время с учетом смещения: {utcNowOffset}");
