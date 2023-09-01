#include<iostream>
using namespace std;
class Account
{
	public:
		int acctno;
		int bal;
	void deposite(int amt)
	{
		cout<<"Hello From Deposite Account"<<endl;
	}
};
class Saving:public Account
{
	public:
		void deposite(int amt)
		{
			int intrest=500;
			bal=bal+amt+intrest;
			cout<<"Amount Deposited, Total Balance with intrest= "<<bal<<".Rs"<<endl;
		}
};
class Current:public Account
{
	public:
		void deposite(int amt)
		{
			bal=bal+amt;
			cout<<"Amount Deposuted, Total Balance without intrest= "<<bal<<".Rs"<<endl;
		}
};
int main()
{
	Account *A;
	Saving s;
	A=&s;
	A->acctno=123;
	A->bal=2000;
	A->deposite(100);
	Current c;
	A=&c;
	A->acctno=456;
	A->bal=2000;
	A->deposite(100);
	return 0;
}
