public /*static*/ class DataContext
{
    // некорректный способ сохранения и передачи состояния между юзерами (статику лучше избегать);
    // статический элемент единственный и существует до остановки приложения
    // public static string Str = "";

    // корректный способ
    public DataContext()
    {
        this.Str = String.Empty;
    }

    public string Str { get; set; }
}