#include<iostream>
using namespace std;
class employe
{
	public:
		string name;
		int empno;
		
	employe(string ename, int eno)
	{
		name = ename;
		empno = eno;
	}
	
	void displayData()
	{
		cout<<"Employe Name: "<<name<<endl;
		cout<<"Employe No.: "<<empno<<endl;
	}
};
int main()
{
	string ename;
	int eno;
	employe emp1("sujit",543);
	emp1.displayData();
	return 0;
}

