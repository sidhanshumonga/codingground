using System.IO;
using System.Collections.Generic; 
using System;

class Program
{
    static void Main()
    {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            dict.Add("i",1);
            dict.Add("love",1);
            dict.Add("indian",1);
            dict.Add("food",1);
            dict.Add("spicy",1);
            string input = Console.ReadLine();
           //  Console.WriteLine(input.Length);
            bool flag = false;
            string check = "";
            for(int i=0;i<input.Length;i++){
              check = check + input[i]; 
              Console.WriteLine(check);
                if(dict.ContainsKey(check) == true){
                    flag = true;
                    check = "";
                }
                else{
                    flag = false;
                }
            }
                Console.WriteLine(flag);
    }
}