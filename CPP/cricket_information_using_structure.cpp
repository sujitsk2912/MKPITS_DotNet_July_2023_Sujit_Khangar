#include<iostream>
using namespace std;
int main()
{
	int n1,n2,sum=0;
	char op;
	cout<<"Enter any 2 numbers\n";
	cin>>n1>>n2;
	cout<<"enter op(+,-,*,/)\n";
	cin>>op;
	if(op=='+')
	{
		sum=n1+n2;
	}
	else if(op=='-')
	{
		sum=n1-n2;
	}
	else if(op=='*')
	{
		sum=n1*n2;
	}
	else if(op=='/')
	{
		sum=n1/n2;
	}
	cout<<"sum= "<<sum;
	return 0;
}
