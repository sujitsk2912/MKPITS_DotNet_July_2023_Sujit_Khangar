#include<iostream>
using namespace std;

class employe
{
	public:
		string name;
		int empno;
		
	employe(string ename,int eno)
	{
		name = ename;
		empno = eno;
	}
	
	void displayData()
	{
		cout<<"\n\nEmploye Name: "<<name<<endl;
		cout<<"Employe No.: "<<empno<<endl;
	}
};
int main()
{
	string ename;
	int eno;
	
	cout<<"Enter Employe Name: ";
	cin>>ename;
	cout<<"Enter Employe No.: ";
	cin>>eno;
	
	employe emp1(ename,eno);
	emp1.displayData();
	return 0;
}
