#include<iostream>
using namespace std;
class shape
{
	public:
		int x;
		int y;
	void getData(int a, int b)
	{
		x=a;
		y=b;
	}
};
class Rectangle:public shape
{
	public:
		int arear(int l,int b)
		{
			int ra;
			ra=l*b;
			return ra;
		}
};
class Triangle:public shape
{
	public:
		int areat(int ba, int h)
		{
			float ta;
			ta=0.5f*ba*h;
			return ta;
		}
};
int main()
{
	Rectangle r;
	Triangle t;
	int length,bredth,base,height;
	int ra;
	float ta;
	cout<<"--------- AREA OF RECTANGLE ---------"<<endl;
	cout<<"\nEnter Length and Bredth for Rectangle"<<endl;
	cin>>length>>bredth;
	ra=r.arear(length,bredth);
	cout<<"Area of Rectangle: "<<ra<<endl;
	cout<<"\n--------- AREA OF TRIANGLE ---------"<<endl;
	cout<<"\nEnter Base and Height for Triangle"<<endl;
	cin>>base>>height;
	ta=t.areat(base,height);
	cout<<"Area of Triangle: "<<ta;
	return 0;										
}
