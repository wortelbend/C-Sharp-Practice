using System;

// 定義一個委派，用於指向不同的轉換方法
public delegate double ConvertDelegate(double units);

public class UnitConverter
{
    // 將英尺轉換成英吋
    public static double FeetToInches(double feet)
    {
        return feet * 12;
    }

    // 將英碼轉換成英吋 
    public static double YardsToInches(double yards)
    {
        return yards * 36;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("請輸入要轉換的數值:");
        if (!double.TryParse(Console.ReadLine(), out double inputValue))
        {
            Console.WriteLine("無效的輸入。");
            return;
        }

        Console.WriteLine("請選擇要執行的轉換:");
        Console.WriteLine("1. 英尺轉換成英吋 (Feet to Inches)");
        Console.WriteLine("2. 英碼轉換成英吋 (Yards to Inches)");
        string choice = Console.ReadLine();

        ConvertDelegate converter = null; // 宣告一個委派變數

        switch (choice)
        {
            case "1":
                converter = UnitConverter.FeetToInches; // 將委派指向 FeetToInches 方法
                break;
            case "2":
                converter = UnitConverter.YardsToInches; // 將委派指向 YardsToInches 方法
                break;
            default:
                Console.WriteLine("無效的選擇。");
                return;
        }

        // 檢查委派是否已被賦值，然後動態呼叫轉換方法
        if (converter != null)
        {
            double result = converter(inputValue);
            Console.WriteLine($"轉換結果為: {result} 英吋");
        }

        Console.ReadLine(); // 暫停，以便查看結果
    }
}