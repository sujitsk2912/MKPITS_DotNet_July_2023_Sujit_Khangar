#include<iostream>
using namespace std;
class shape
{
	public:
		virtual void draw()=0;
};
class Rectangle:public shape
{
	public:
		void draw()
		{
			cout<<"Draw from Rectangle"<<endl;
		}
};
int main()
{
	Rectangle r;
	r.draw();
	return 0;
}
