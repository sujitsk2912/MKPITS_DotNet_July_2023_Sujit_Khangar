#include<iostream>
using namespace std;
class Account
{
	public:
		int accno;
		int bal;
		int intrest;
	void getData(int a,int b,int c)
	{
		accno=a;
		bal=b;
		intrest=c;
	}
};
class saving:public Account
{
	public:
		int deposite(int amt)
		{
			bal=bal+intrest+amt;
			return bal;
		}
};
class current:public Account
{
	public:
		int deposite(int amt)
		{
			bal=bal+amt;
			return bal;
		}
};
int main()
{
	saving s1;
	current c1;
	int accountno,balance,inter,amount;
	int result;
	cout<<"------- SAVING ACCOUNT -------"<<endl;
	cout<<"Enter Account Details"<<endl;
//	cout<<"Enter Account No.: ";
	cin>>accountno>>balance>>inter>>amount;
	s1.getData(balance,inter,amount);
	result=s1.deposite(amount);
	cout<<"Saving Balance: "<<result;
	cout<<"\n------- CURRENT ACCOUNT -------"<<endl;
	cout<<"Enter Account Details"<<endl;
	cin>>accountno>>balance>>inter>>amount;
	result=c1.deposite(amount);
	cout<<"Current Balance: "<<result;
	return 0;
	
}
