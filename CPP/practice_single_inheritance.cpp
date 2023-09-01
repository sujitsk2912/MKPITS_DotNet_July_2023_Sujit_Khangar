#include<iostream>
using namespace std;
class person
{
	public:
		string name;
		int age;
	void getData(string pname, int page)
	{
		name=pname;
		age=page;
	}
};
class sujit:public person
{
	public:
		void display()
		{
			cout<<"Person Name: "<<name<<endl;
			cout<<"Person Age: "<<age;
		}
};
int main()
{
sujit s;
s.getData("Sujit",23);
s.display();
return 0;	
}
