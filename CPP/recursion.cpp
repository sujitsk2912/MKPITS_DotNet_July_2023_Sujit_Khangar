#include<iostream>
using namespace std;
int factorial(int);
int main()
{
	int num,fact;
	cout<<"Enter Number: "<<endl;
	cin>>num;
	fact=factorial(num);
	cout<<"Factorial: "<<fact;
	return 0;
}
int factorial(int n)
{
	if(n==0)
	{
		return(1);
	}
	else
	{
		return(n*factorial(n-1));
	}
};
