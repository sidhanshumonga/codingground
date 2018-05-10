// created by sidhanshu monga
// 10 may, 2018

//Problem statement : find frequency of given element in particular string

#include <stdio.h>

int main()
{
   char str[1000], ch;
   int i, frequency = 0;

   printf("Enter a string: ");
   gets(str);

   printf("Enter a character to find the frequency: ");
   scanf("%c",&ch);

   for(i = 0; str[i] != '\0'; ++i)
   {
       if(ch == str[i])
           ++frequency;
   }

   printf("Frequency of %c = %d", ch, frequency);

   return 0;
}