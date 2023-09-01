#include<iostream>
using namespace std;
class student
{
	public:
		string name;
		int Class,roll_no,marks;
		
		void getData()
		{
			cout<<"------------ Enter Student Details -------------\n\n";
			cout<<"Enter Student Name: ";
			cin>>name;
			cout<<"Enter Class: ";
			cin>>Class;
			cout<<"Enter Roll No.: ";
			cin>>roll_no;
			cout<<"Enter Obtained Marks /100 ";
			cin>>marks;
		}
		
		
		void displayData()
		{
			cout<<"\n";
			cout<<"------------ Student Details -------------\n\n";
			cout<<"Name: "<<name<<endl;
			cout<<"Class: "<<Class<<endl;
			cout<<"Roll No.: "<<roll_no<<endl;
			cout<<"Obtained Marks: "<<marks<<endl;
//			cout<<"Total Percentage: "<<totalPercent<<endl;
		}
		
		void displayGrade()
		{
			if(90<=marks)
			{
				cout<<"Grade: A";
			}
			else if(85<=marks)
			{
				cout<<"Grade: B";
			}
			else if(65<=marks)
			{
				cout<<"Grade: C";
			}
			else
			{
				cout<<"Grade: D";
			}
		}
};
int main()
{
	student s1;
	s1.getData();
	s1.displayData();
	s1.displayGrade();	
return 0;
	
}
