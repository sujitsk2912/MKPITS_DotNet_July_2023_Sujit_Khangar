#include<iostream>
using namespace std;
class calculation
{
	public:
		int add(int n1, int n2)
		{
			return n1+n2;
		}
		float add(float n1, float n2)
		{
			return n1+n2;
		}
};
int main()
{
	calculation c1;
	cout<<"Addition of 2 integers: "<<c1.add(2,4)<<endl;
	cout<<"Addition of 2 floats: "<<c1.add(2.2f,3.6f);
	return 0;
}
