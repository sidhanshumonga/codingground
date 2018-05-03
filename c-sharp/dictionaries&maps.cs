// created by sidhanshu monga
// 02 may, 2018

//Problem statement :  using dictionaries and maps

using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
       string count = Console.ReadLine();
        int c = Convert.ToInt32(count);
         Dictionary<string, string> hash = new Dictionary<string, string>();
        for(int i=0;i<c;i++){
            string input = Console.ReadLine();
            string[] array = input.Split(' ');
            string name = array[0];
            string number = array[1];
            hash.Add(name,number);
        }
        
        while(true){
            string check = Console.ReadLine();
            if(hash.ContainsKey(check) == true){
                Console.WriteLine(check+"="+hash[check]);
            }
            else if(check == "exit"){
                break;
            }
            else{
                Console.WriteLine("Not found");
            }
        }
    }
}
