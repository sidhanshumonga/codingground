using System.IO;
using System;
using System.Collections;


class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        string pattern = Console.ReadLine();
        bool flag = false;
        int star = pattern.Length;
        for(int i=0;i<star;i++){
            // if(i<pattern.Length){
                
                if(pattern[i] == '*'){
                    if(i == pattern.Length-1){
                        if(input.Length > i+2){flag = true;}
                        else flag = false;
                        
                    }
                    if(i != pattern.Length-1){
                    
                    for(int j=i;j<input.Length;j++){
                        if(input[j]==pattern[i+1]){
                            if(j-i > 2){flag = true;}
                            else {flag = false;}
                            input = input.Substring(0,i) + input.Substring(j);
                        }
                    }
                    }
                }
                if(pattern[i] == '?'){
                    if(i == pattern.Length-1){
                         if(input.Length < i+2){flag = true;}
                        else flag = false;
                    }
                     if(i != pattern.Length-1){
                    
                    for(int j=i;j<input.Length;j++){
                        if(input[j]==pattern[i+1]){
                            if(j-i < 3){flag = true;}
                            else{flag = false;}
                            input = input.Substring(0,i) + input.Substring(j);
                            }
                        }
                    }
                }
                if(pattern[i] == '-'){
                    Console.WriteLine(0);
                    return;
                }
                
            // }
        }
        if(flag==true)Console.WriteLine(1);
        else Console.WriteLine(0);
        
    }
}