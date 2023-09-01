#include<iostream>
using namespace std;
 class employe
 {
 	public:
	 	string name;
	 	string designation;
	 	int salary,empno;
 	
 	void getDetails()
 	{
 		cout<<"Enter Employe Name: ";
 		cin>>name;
 		cout<<"Enter Employe No.: ";
 		cin>>empno;
 		cout<<"Designation(m,c,p): ";
 		cin>>designation;
 		cout<<"Salary: ";
 		cin>>salary;
 	}
 		
 	void displayDetails()
 	{
 		cout<<"Name: "<<name<<endl;
 		cout<<"Employe No.: "<<empno<<endl;
 		cout<<"Designation: "<<designation<<endl;
 		cout<<"Salary: "<<salary<<endl;
	 }
};
	
	int main()
	{
		employe emp1,emp2,emp3;
		cout<<"Employe 1 Details\n"<<endl;
		emp1.getDetails();
		emp1.displayDetails();
		cout<<"\nEmploye 2 Details\n"<<endl;
		emp2.getDetails();
		emp2.displayDetails();
		cout<<"\nEmploye 3 Details\n"<<endl;
		emp3.getDetails();
		emp3.displayDetails();
		return 0;
	}

