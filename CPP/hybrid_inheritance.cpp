#include<iostream>
using namespace std;
class classA
{
	protected:
		int n1;
	public:
		void getn1(int n)
		{
			n1=n;
		}
};
class classB:public classA
{
	protected:
		int n2;
	public:
		void getn2(int n)
		{
			n2=n;
		}
};
class classC
{
	protected:
		int n3;
	public:
		void getn3(int n)
		{
			n3=n;
		}
};
class classD:public classB, public classC
{
	public:
		int multiply()
		{
			int m= n1*n2*n3;
			return m;	
		}
};
int main()
{
	int result;
	classD d1;
	d1.getn1(2);
	d1.getn2(4);
	d1.getn3(6);
	result=d1.multiply();
	cout<<"Multiplication: "<<result;
	return 0;
}
