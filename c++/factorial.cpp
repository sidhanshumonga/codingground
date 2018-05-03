// created by sidhanshu monga
// 03 may, 2018

//Problem statement :  return the factorial of a number

#include <iostream>
#include<stdio.h>

using namespace std;
long int factorial(int n);
int main() {
      int n;
    cin>>n;
    cout<<factorial(n);
      return 0;
}
long int factorial(int n){
    if(n>=1){
 return n*factorial(n-1);
       
    }
    else{
        return 1;
    }
}
