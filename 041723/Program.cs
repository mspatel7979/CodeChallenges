using System;
using System.Collections.Generic;
public class CodeChallenge041723{

    private static List<int> FindIndexOfCapitalLetters (string s) {
        List<int> list = new List<int>();
        foreach (char ch in s) {
            if(char.IsUpper(ch)) {
                list.Add(s.IndexOf(ch));
            }
        }
        return list;
    }
    public static void Main(String[] args){
        Console.WriteLine("Input String : ");
        string s = Console.ReadLine();
        Console.WriteLine("Output is : ");
        Console.WriteLine("[" + string.Join(", ", FindIndexOfCapitalLetters(s)) + "]");
    }
}
