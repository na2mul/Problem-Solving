//https://toph.co/p/bpl-mubarak

#include<bits/stdc++.h>
using namespace std; 

void CountOverBall(string str)
{
    int count = 0;
    for(int i = 0; i<str.length(); i++)
    {
        if(str[i] == 'O' || str[i]>=48 && str[i]<=54) count++;
    }

    int over = count/6;
    int ball = count%6;
    if(ball==0)
    {
        cout << over << (over>1?" OVERS":" OVER");
        
    }
    else if(over>0)
    {
        cout << over << (over>1?" OVERS ":" OVER ") << ball << (ball>1?" BALLS":" BALL");
    }
    else
    {
        cout << ball << (ball>1?" BALLS":" BALL");
    }   
    cout << "\n";
}

int main()
{
    int t;
    cin >> t;
    while(t--)
    {
        string str;
        cin >> str;
        CountOverBall(str);
    }
}