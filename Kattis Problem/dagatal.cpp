//https://open.kattis.com/problems/dagatal

#include<bits/stdc++.h>
using namespace std; 

int numberOfDays(int num)
{
    if(num==2) return 28;
    else if(num<=7)
    {
        if(num%2==0) return 30;
        else return 31;
    }
    else
    {
        if(num%2==0) return 31;
        else return 30;
    }
}
int main()
{
    int n;
    cin >> n;
    cout << numberOfDays(n);
}