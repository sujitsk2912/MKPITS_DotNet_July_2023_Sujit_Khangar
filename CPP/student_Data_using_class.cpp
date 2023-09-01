#include<iostream>
using namespace std;

class student
{
	public:
		string name;
		int roll_no;
		string course;
		
	void getData()
	{
		cout<<"Enter Name:";
		cin>>name;
		cout<<"Roll No.: ";
		cin>>roll_no;
		cout<<"Course: ";
		cin>>course;
	}
	void displayData()
	{
		cout<<"Name: "<<name<<endl;
		cout<<"Roll No.: "<<roll_no<<endl;
		cout<<"Course: "<<course<<endl;
	}
};
int main()
{
	student stud1,stud2;
	cout<<"Student 1"<<endl;
	stud1.getData();
	stud1.displayData();
	cout<<"Student 2"<<endl;
	stud2.getData();
	stud2.displayData();
	return 0;
}

