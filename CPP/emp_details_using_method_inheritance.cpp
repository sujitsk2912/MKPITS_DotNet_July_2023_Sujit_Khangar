#include<iostream>
using namespace std;

class employe
	{
	public:
		string name;
		string designation;
		int empno;
		int salary;
void getDetails()
	{
	cout<<"Enter Employe Name: ";
	cin>>name;
	cout<<"Enter Employe No.: ";
	cin>>empno;
	cout<<"Enter Designation(m,c,p): ";
	cin>>designation;
	cout<<"Enter Salary: ";
	cin>>salary;
	}
	};
	
class Data:public employe
	{
	public:
void displayData()
	{
	cout<<endl<<"Name: "<<name<<endl;
	cout<<"Employe No.: "<<empno<<endl;
	cout<<"Designation: "<<designation<<endl;
	cout<<"Salary: "<<salary<<endl;
	}
};
int main()
{
 Data d1;
 	d1.getDetails();
 	d1.displayData();
	 return 0;
}
