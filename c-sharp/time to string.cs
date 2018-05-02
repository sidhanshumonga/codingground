using System.IO;
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string hour = Console.ReadLine();
        string min = Console.ReadLine();
        int h = Convert.ToInt32(hour);
        int m = Convert.ToInt32(min);
        Dictionary<int, string> hash = new Dictionary<int, string>();

        hash.Add(1,"one");
        hash.Add(2,"two");
        hash.Add(3,"three");
        hash.Add(4,"four");
        hash.Add(5,"five");
        hash.Add(6,"six");
        hash.Add(7,"seven");
        hash.Add(8,"eight");
        hash.Add(9,"nine");
        hash.Add(10,"ten");
        hash.Add(11,"eleven");
        hash.Add(12,"tweleve");
        hash.Add(13,"thirteen");
        hash.Add(20,"twenty");
        hash.Add(15,"quarter");
        hash.Add(30,"half");
        
        //if minutes are 0
        if(m == 0){
            Console.WriteLine(hash[h] + "'o clock");
        }
        
        //if minutes are not 0
        else{
            
            //if minutes are less than 30
            if(m < 30){
                
                //if minutes are between 14-19
                if(m < 20 &&  m > 13 && m != 15){
                   int ms = Convert.ToInt32(min.Substring(1));
                    Console.WriteLine(hash[ms] + "teen minutes past " + hash[h]);
                }
                //if minutes are between 20-29
                else if(m > 20){
                      int ms = Convert.ToInt32(min.Substring(1));
                    Console.WriteLine(hash[20] + " " +  hash[ms] + " minutes past " + hash[h]);
                }
                //if minutes are 15
                else if(m == 15){
                    Console.WriteLine(hash[m] + " past " + hash[h]);
                }
                //if minutes are between 1-13
                else{
                    Console.WriteLine(hash[m] + " minutes past " + hash[h]);
                }
            }
            
            
            //if minutes are more than 30
            else if(m > 30){
                
                //so that getting how much minutes left in next hour
                int mm = 60 - m;
                string mms = mm.ToString();
                
                 //if minutes left are between 14-19
                if(mm < 20 &&  mm > 13 && mm != 15){
                   int ms = Convert.ToInt32(mms.Substring(1));
                    Console.WriteLine(hash[ms] + "teen minutes to " + hash[h + 1]);
                }
                //if minutes left are between 20-29
                else if(mm > 20){
                      int ms = Convert.ToInt32(mms.Substring(1));
                    Console.WriteLine(hash[20] + " " +  hash[ms] + " minutes to " + hash[h + 1]);
                }
                //if minutes left are 15
                else if(mm == 15){
                    Console.WriteLine(hash[mm] + " to " + hash[h + 1]);
                }
                //if minutes left are between 1-13
                else{
                    Console.WriteLine(hash[mm] + " minutes to " + hash[h + 1]);
                }
            }
            
            //if minutes are exactly 30
            else{
                Console.WriteLine(hash[m] + " past " + hash[h]);
            }
        }
    }
}