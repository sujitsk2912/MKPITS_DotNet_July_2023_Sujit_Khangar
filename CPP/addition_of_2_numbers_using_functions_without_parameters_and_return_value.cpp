#include<iostream>
using namespace std;
int addition()
{
	int n1,n2;
	cout<<"Enter any two numbers:\n";
	cin>>n1>>n2;
	int result= n1 + n2;
	return result;
}
int main()
{
	char ch='y';
	while(ch=='y')
	{
	int result;
	result = addition();
	cout<<"result=\n"<<result;
	cout<<"Do you want to continue, press 'y': ";
	cin>>ch;
	}

}
//int n1,n2;
//printf("Enter two numbers");
//scanf("%d%d",&n1,&n2);
//
//int n2,n1;
//cout<<"Enter two numbers";
//cin>>n2>>n1;


