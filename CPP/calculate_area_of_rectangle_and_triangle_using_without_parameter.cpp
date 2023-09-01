#include<iostream>
using namespace std;
class shape
{
	public:
		int x;
		int y;
	void getData(int a,int b)
	{
		x=a;
		y=b;
	}
};
class Rectangle:public shape
{
	public:
		int carea()
		{
			int ra;
			ra=x*y;
			return ra;
		}
};
class Triangle:public shape
{
	public:
		float carea()
		{
			float ta;
			ta=0.5f*x*y;
			return ta;
		}
};
int main()
{
	Rectangle r;
	Triangle t;
	int length,breath,base,height;
	int ra;
	float ta;
	cout<<"--------- AREA OF RECTANGLE ---------"<<endl;
	cout<<"\nEnter Length and Bredth for Rectangle"<<endl;
	cin>>length>>breath;
	r.getData(length,breath);
	ra=r.carea();
	cout<<"Area of Rectangle: "<<ra<<endl;
	cout<<"\n--------- AREA OF TRIANGLE ---------"<<endl;
	cout<<"\nEnter Base and Height for Triangle"<<endl;
	cin>>base>>height;
	t.getData(base,height);
	ta=t.carea();
	cout<<"Area of Triangle: "<<ta;
	return 0;
}
