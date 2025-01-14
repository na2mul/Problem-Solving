// https://open.kattis.com/problems/aleidibio

#include<bits/stdc++.h>
using namespace std; 

int possibleMinute(int a, int b, int c)
{
    return c-(a+b);
}
int main()
{
    int a, b, c;
    cin >> a >> b >> c;
    cout << possibleMinute(a,b,c);
}