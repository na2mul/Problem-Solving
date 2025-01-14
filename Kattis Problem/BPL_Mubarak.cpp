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
    if(count%6==0)
    {
        if(count/6>1)
            cout << count/6 << " OVERS";
        else
            cout << 1 << " OVER";
    }
    else
    {
        if(count/6>1 && count%6>1 )
            cout << count/6 << " OVERS " << count%6 << " BALLS";
        else if(count/6==1)
        {
            if(count%6>1)
                cout << 1 << " OVER " << count%6 << " BALLS";
            else
                cout << 1 << " OVER " << 1 << " BALL";
            

        }
        else
        {
            if(count>1)
                cout << count << " BALLS";
            else
                cout << 1 << " BALL";
        }
            
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