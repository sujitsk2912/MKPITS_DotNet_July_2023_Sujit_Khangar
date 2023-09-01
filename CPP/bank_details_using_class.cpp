#include<iostream>
using namespace std;
class bank
{
	public:
		string name;
		int accno,withdrawal;
		int deposite,balance;
		
	float depositeMoney()
	{
		float d = balance + deposite;
		return d;
	} 
	 float withdrawalMoney()
	{
	 	float w = balance - withdrawal;
	 	return w;
	}
};

int main()
{
	float result;
	bank b1;
	cout<<"Enter Customer Name: ";
	cin>>b1.name;
	cout<<"Enter Account Number: ";
	cin>>b1.accno;
	cout<<"Enter Balance: ";
	cin>>b1.balance;

cout<<"Enter Deposite Amount: ";
cin>>b1.deposite;
	result = b1.depositeMoney();
	cout<<"Money Deposited, Total Balance= "<<result<<endl;

cout<<"Enter Withdrawal Amount: ";
cin>>b1.withdrawal;
	result = b1.withdrawalMoney();
	cout<<"Money Withdrwaled, Total Balance= "<<result;
}
