#include<iostream>
using namespace std;
class person
{
	protected:
		string name;
};
class student:public person
{
	public:
		
	void setData(string s)
	{
		name=s;
	}
	void displayData()
	{
		cout<<"Name:"<<name;
	}
};
int main()
{
	student s1;
	s1.setData("sujit");
	s1.displayData();
}
