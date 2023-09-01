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
	Saving s;
	s.acctno=123;
	s.bal=2000;
	s.deposite(100);
	Current c;
	c.acctno=456;
	c.bal=2000;
	c.deposite(100);
	return 0;
}
