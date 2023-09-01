#include<iostream>
using namespace std;
class employee
{
	public:
		string empname;
		int empno;
	static string cname;
	employee(string empname,int empno)
	{
		this->empname=empname;
		this->empno=empno;
	}
	void display()
	{
		cout<<"Employee Name: "<<empname<<endl;
		cout<<"Employee No.: "<<empno<<endl;
		cout<<"Company Name: "<<cname<<endl;
	}
};
string employee::cname="MKP IT SERVIECES";
int main()
{
	employee e1=employee("Sujit",123);
	employee e2=employee("Ashvin",345);
	e1.display();
	e2.display();
	return 0;
}
