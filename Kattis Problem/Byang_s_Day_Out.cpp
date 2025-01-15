// https://toph.co/p/byangs-day-out

#include<bits/stdc++.h>
using namespace std; 

void visible(int a, int b, int c)
{
    if(a>b && a>c) cout << (b+c>=a?"Yes\n":"No\n");
    else if(b>a && b>c) cout << (a+c>=b?"Yes\n":"No\n");
    else  cout << (b+a>=c?"Yes\n":"No\n");
}

int main() {
	int T;
	cin >> T;
	for (int i = 0; i < T; ++i) {
		int a, b, c;
		cin >> a >> b >> c;
        visible(a,b,c);
	}
	
	return 0;
}
