#include<iostream>
using namespace std;
class shape
{
	public:
		virtual void draw()
		{
			cout<<"Draw method of Shape class"<<endl;
		}
};
class rectangle:public shape
{
	public:
		void draw()
		{
			cout<<"Draw method of Rectangle class"<<endl;
		}
};
int main()
{
	shape *s;	
	shape s1;
	s=&s1;
	s->draw();
	rectangle r1;
	s=&r1;
	s->draw();
	return 0;
}
