#include<iostream>
using namespace std;
int main()
{
	int n1,n2,sum=0;
	char op;
	cout<<"Enter any 2 Numbers\n";
	cin>>n1>>n2;
	cout<<"Enter Operator(+,-,*,/)\n";
	cin>>op;
	switch(op)
	{
		case '+':
		sum=n1+n2;
		break;
		
		case '-':
		sum=n1-n2;
		break;
		
		case '*':
		sum=n1*n2;
		break;
		
		case '/':
		sum=n1/n2;
		break;
		default:
			break;
	}
	cout<<"sum = "<<sum;
	return 0;
}
