namespace CTT.Frame;
using System;
using System.Collections.Generic;

class SearchHandler
{
    private static FlagFrames flagFrames;
    private readonly Dictionary<string, Action> _searchActions = new Dictionary<string, Action>
    {
        { "билет", MethodA },
        { "проездной", MethodB },
        { "новости", MethodC },
        { "каталог", MethodD }
    };

    public void Search(string search)
    {
        foreach (var keyword in _searchActions.Keys)
        {
            if (search.Contains(keyword))
            {
                _searchActions[keyword](); 
                return;
            }
        }
        Console.WriteLine("Ключевое слово не найдено.");
    }

    private static void MethodA()
    {
        Console.WriteLine("Вызван метод A (билет).");
    }

    private  static void MethodB()
    {
        Console.WriteLine("Вызван метод B (проездной).");
    }

    private static void MethodC()
    {
        flagFrames.ChangeFlagsFrame();
        MainForm.topPanel = true;
        MainForm.frame8 = true;
        Console.WriteLine("Вызван метод C (новости).");
    }

    private static void MethodD()
    {
        Console.WriteLine("Вызван метод D (каталог).");
    }
}