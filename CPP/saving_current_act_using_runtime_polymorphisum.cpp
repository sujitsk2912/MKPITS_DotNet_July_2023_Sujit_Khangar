#include<iostream>
using namespace std;
class account
{
	public:
		int accno;
		int bal;
	virtual void deposite(int amt)
	{
		cout<<"Hello from Account Deposite "<<endl;
	}
};
class saving:public account
{
	public:
		void deposite(int amt)
		{
			int intrest=500;
			bal=bal+amt+intrest;
			cout<<"Amount Deposited,Total balance with intrest: "<<bal<<endl;
		}
};
class current:public account
{
	public:
		void deposite(int amt)
		{
			bal=bal+amt;
			cout<<"Amount Deposited,Total Balance without intrest: "<<bal<<endl;
		}
};
int main()
{
	account a;
	a.deposite();
	account *A;
	saving s;
	current c;
	A=&s;
	A->accno=553;
	A->bal=2000;
	A->deposite(500);
	A=&c;
	A->accno=132;
	A->bal=4000;
	A->deposite(500);
	return 0;
}
