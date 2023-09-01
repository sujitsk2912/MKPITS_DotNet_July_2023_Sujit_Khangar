#include<iostream>
using namespace std;
class student
{
	public:
	string name;
	int age;
	void getstudData(string sname, int sage)
	{
		name=sname;
		age=sage;
	}
};
class partimestud:public student
{
	public:
		void displaystud()
		{
			cout<<"Student Name: "<<name<<endl;
			cout<<"Student Age: "<<age<<endl;
		}
};
class employe
{
	public:
		string ename;
		int salary;
	void getempData(string empname, int sal)
	{
		ename=empname;
		salary=sal;
	}
};
class partimeemploye:public employe
{
	public:
		string workinghr;
		void getpartData(string whr)
		{
		 workinghr=whr;
		}
		void displayemploy()
		{
			cout<<"Employe Name: "<<ename<<endl;
			cout<<"Working hours: "<<workinghr<<endl;
			cout<<"Salary: "<<salary;
		}
};
int main()
{
	partimestud s1;
	partimeemploye e1;
	s1.getstudData("Sujit",23);
	s1.displaystud();
	e1.getempData("sujit",50000);
	e1.getpartData("12");
	e1.displayemploy();
	return 0;	
}
