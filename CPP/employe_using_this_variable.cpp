#include<iostream>
using namespace std;
class employe
{
	public:
		string name;
		int empno; //instance veriable
	
	employe (string name, int empno)
	{
		this-> name = name;
		this-> empno = empno;
	}
	void display()
	{
		cout<<name<<endl;
		cout<<empno<<endl;
	}
};
int main()
{
	employe emp1("Sujit",123);
	emp1.display();
	return 0;
}
