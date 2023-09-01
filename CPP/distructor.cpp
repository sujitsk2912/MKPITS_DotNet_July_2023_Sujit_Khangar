#include<iostream>
using namespace std;
class employe
{
	public:
//		string name;
//		int empno;
	employe()
	{
	cout<<"Constructor called"<<endl;	
	}
	~employe()
	{
		cout<<"distructor called"<<endl;
	}
};
int main()
{
	employe emp1;
	employe emp2;
	return 0;
}
