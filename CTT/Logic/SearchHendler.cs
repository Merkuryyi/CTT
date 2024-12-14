namespace CTT.Frame;
using System;
using System.Collections.Generic;

class SearchHandler
{
    private static FlagFrames flagFrames = new FlagFrames();
    private readonly Dictionary<string, Action> _searchActions = new Dictionary<string, Action>
    {
        { "ticket", Tickets },
        { "travelticket", TravelTickets },
        { "news", News },
        { "catalog", Catalog }
    };
    public void Search(string search)
    {
        string searchLower = search.ToLower();
        foreach (var keyword in _searchActions.Keys)
        {
            if (searchLower.Contains(keyword, StringComparison.OrdinalIgnoreCase))
            {
                _searchActions[keyword](); 
                return;
            }
        }
        Console.WriteLine("Ключевое слово не найдено.");
    }
    private static void Tickets()
    {
        flagFrames.ChangeFlagsFrame();
        MainForm.topPanel = true;
        MainForm.frame6 = true;
    }
    private static void TravelTickets()
    {
        flagFrames.ChangeFlagsFrame();
        MainForm.topPanel = true;
        MainForm.frame7 = true;
    }
    private static void News()
    {
        flagFrames.ChangeFlagsFrame();
        MainForm.topPanel = true;
        MainForm.frame8 = true;
    }
    private static void Catalog()
    {
        flagFrames.ChangeFlagsFrame();
        MainForm.topPanel = true;
        MainForm.frame9 = true;
    }
}


