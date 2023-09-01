#include<iostream>
using namespace std;
class customer
{
	public:
		string name;
		int accno,balance;
		
	customer()
	{
		name = "Sujit";
		accno = 553;
		balance = 5000;
	}
	
	void displayData()
	{
		cout<<"Customer Name: "<<name<<endl;
		cout<<"Account No.: "<<accno<<endl;
		cout<<"Balance: "<<balance<<endl;
	}
};
int main()
{
	customer c1;
	cout<<"---------- Customer 1 ----------\n";
	c1.displayData();
return 0;	
}
