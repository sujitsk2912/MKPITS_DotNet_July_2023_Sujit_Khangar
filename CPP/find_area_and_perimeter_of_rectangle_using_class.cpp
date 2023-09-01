#include<iostream>
using namespace std;
class Rectangle
{
	public:
		int length,width;
	float calculateArea()
	{
		float a= length*width;
		return a;
	}
	float calculatePeri()
	{
		float peri= 2*(length*width);
		return peri;
	}
};

int main()
{
	float result;
	Rectangle r1;
	cout<<"Enter Lenght: ";
	cin>>r1.length;
	cout<<"Enter Width: ";
	cin>>r1.width;
	result=r1.calculateArea();
	cout<<"Area= "<<result<<endl;
	result=r1.calculatePeri();
	cout<<"Perimeter= "<<result;
}
