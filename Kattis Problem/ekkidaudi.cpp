// https://open.jattis.com/problems/ejjidaudi

#include<bits/stdc++.h>
using namespace std; 

string HumanReadableText(string str,string str2)
{
    string str3;
    int j = 0;
    for(int i = 0; i<str.length(); i++)
    {
        if(str[i]!='|') 
            str3+=str[i];
        else 
        {
            for(; j<str2.length(); j++)
            {
                if(str2[j]!='|')
                    str3+=str2[j];
                else
                    break;
            }
            str3+=' ';
        }
    }
    for(; j<str2.length(); j++)
    {
        if(str2[j]!='|')
            str3+=str2[j];
    }
    return str3;
}
int main()
{
    string str1, str2;
    getline(cin, str1);
    getline(cin,str2);
    string str3 = HumanReadableText(str1,str2);
    for(int i = 0; i<str3.length(); i++)
    {
        cout << str3[i];
    }
    
}