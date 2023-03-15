using Microsoft.VisualBasic;
using Newtonsoft.Json;
using System;
using System.Collections.ObjectModel;
using System.Text.Json;
public class Program
{
    public static void Main()
    {
        List<int> list = new List<int> { 1, 2, 3, 1, 4, 5, 2, 2, 1 };

        List<int> end = list.Take(3).ToList();
        end.Add(0);
        List<int> end2 = list.Skip(4).Take(2).ToList();
        end2.Add(0);
        end2.Add(0);
        end2.Add(0);

        list = Enumerable.Concat(end, end2).ToList();
        foreach(int item in list)
        {
            Console.Write(item + " ");
        }


        /*Console.WriteLine("\n"+ new string('=', 30));
        MoreEASY();*/
    }

    public static void MoreEASY()
    {
        List<int> list = new List<int> { 1, 2, 3, 1, 4, 5, 2, 2, 1 };
        List<int> save = new List<int>();

        for(int i = 0; i < list.Count; i++)        
            if (!save.Contains(list[i]))           
                save.Add(list[i]);            
            else          
                save.Add(0);            
        
        foreach (int item in save)        
            Console.Write(item + " ");
        
    }
}
