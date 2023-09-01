#include<iostream>
using namespace std;
class person
{
	public:
		string name;
		int mobile;
};
class employe:public person
{
	public:
		int empno;
		int salary;
};
class parttime:public employe
{
	public:
		int hours;
};
int main()
{
	employe e1;
	e1.name="Sujit";
	e1.mobile= 9579120646;
	e1.empno=57;
	e1.salary=65000;
	cout<<"---------- Employe Details ---------- "<<endl;
	cout<<e1.name<<endl<<e1.mobile<<endl<<e1.empno<<endl<<e1.salary<<endl;
	
	parttime p1;
	p1.name="Sujit";
	p1.mobile= 9579120646;
	p1.empno=57;
	p1.salary=67000;
	p1.hours=8;
	cout<<"\n\n---------- Partime Details ---------- "<<endl;
	cout<<p1.name<<endl<<p1.mobile<<endl<<p1.empno<<endl<<p1.salary<<endl<<p1.hours;
	return 0;
}
