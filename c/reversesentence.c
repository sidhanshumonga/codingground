// created by sidhanshu monga
// 10 may, 2018

//Problem statement :  reverse the given sentence

#include <stdio.h>
void reverseSentence();

int main()
{
    printf("Enter a sentence: ");
    reverseSentence();

    return 0;
}

void reverseSentence()
{
    char c;
    scanf("%c", &c);

    if( c != '\n')
    {
        reverseSentence();
        printf("%c",c);
    }
}