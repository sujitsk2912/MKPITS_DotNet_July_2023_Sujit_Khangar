#include<iostream>
using namespace std;
class Account
{
	public:
		int acctno;
		int bal;
	static float roi;
	
	Account(int acctno, int bal)
	{
		this->acctno=acctno;
		this->bal=bal;
	}
	void display()
	{
		cout<<"Account No.: "<<acctno<<endl;
		cout<<"Balance: "<<bal<<endl;
		cout<<"Rate of intrest: "<<roi<<endl;
	}
};
float Account::roi=9.5f;
int main()
{
	Account A1=Account(123,2000);
	Account A2=Account(456,3000);
	A1.display();
	A2.display();
	return 0;
}

