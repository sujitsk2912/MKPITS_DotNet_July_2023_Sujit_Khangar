#include<iostream>
using namespace std;

class Person
{
	public:
		string name;
		string city;
};
class Student:public Person
{
	public:
		int roll_no;
		int marks;
};
int main()
{
	Student s1;
	s1.name="Sujit";
	s1.city="Nagpur";
	s1.roll_no=57;
	s1.marks=99;
	cout<<s1.name<<endl<<s1.city<<endl<<s1.roll_no<<endl<<s1.marks;
	return 0;
}
