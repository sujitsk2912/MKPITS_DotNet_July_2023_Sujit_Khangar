#include<iostream>
using namespace std;
class employe
{
	public:
		string name;
		int empno;
		
	employe()
	{
		empno = 123;
		name = "Sujit";
	}
	
	void displayData()
	{
		cout<<"Employe Name: "<<name<<endl;
		cout<<"Employe No,: "<<empno<<endl;
	}
};
int main()
{
	employe emp1;
	emp1.displayData();
	return 0;
}
