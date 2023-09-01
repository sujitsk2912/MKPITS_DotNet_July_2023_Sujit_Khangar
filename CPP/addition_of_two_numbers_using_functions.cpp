#include<iostream>
using namespace std;
int addition(int n1, int n2)
{
	int result = n1 + n2;
	return result;
}
int main()
{
	char ch='y';
	while(ch=='y')
	{
		int num1,num2,result=0;
		
		cout<<"Enter any two numbers:endl";
		cin>>num1>>num2;
		result=addition(num1,num2);
		cout<<"result="<<result;
		cout<<"\nDo you want to continue, press 'y'";
		cin>>ch;
	}
}
