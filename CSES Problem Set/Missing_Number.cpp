//https://cses.fi/problemset/task/1083/

#include<bits/stdc++.h>
using namespace std; 
 
int main()
{
   long long n;
   long long sum=0;
   cin >> n;
   for(int i = 0; i<n-1; i++)
   {
    int x;
    cin >> x;
    sum+=x;
   }
   cout << (((n+1)*n)/2)-sum;
    
}