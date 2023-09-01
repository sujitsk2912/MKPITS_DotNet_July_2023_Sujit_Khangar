#include<iostream>
using namespace std;
class person
{
	public:
		string name;
		int mobile;
		
    void getpersonData(string pname, int mn)
    {
    	name=pname;
    	mobile=mn;
	}
};
class employe:public person
{
	public:
		int empno;
		int salary;
	
	void getemployeData(int en,int sal)
	{
		empno=en;
		salary=sal;
	}
void displayData()
{
	cout<<"Name: "<<name<<endl;
	cout<<"Mobile No.: "<<mobile<<endl;
	cout<<"Employe No.: "<<empno<<endl;
	cout<<"Salary: "<<salary<<endl;
}
};
int main()
{
	string pn;
	int m,e,s;
	cout<<"Employe Details"<<endl;
	cin>>pn>>m>>e>>s;
	
	employe emp;
	emp.getpersonData(pn,m);
	emp.getemployeData(e,s);
	emp.displayData();
	return 0;
}
