// created by sidhanshu monga
// 03 may, 2018

//Problem statement :  return the maximum number of repeating 1s in binary number

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string binary = Convert.ToString(n, 2);
        int count = 0;
        int max = 0;
        // Console.WriteLine(binary.Length);
        for(int i=0;i<binary.Length-1;i++){
           // max = count;
            if(binary[i] == '1' && binary[i+1] == '1'){
                count++;
            }
            if(binary[i] == '0'){
                count = 0;
            }
            if(count >= max){
                max = count + 1;
                // count = 0;
            }
        }
        Console.WriteLine(max);
    }
}
