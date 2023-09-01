#include<iostream>
using namespace std;
class car
{
	public:
		string make;
		string model;
		int year;
		
	void startEngine()
	{
		cout<<"Enginee started"<<endl;
		
	}
	void Break()
	{
		cout<<"Break applied";
	}
};

int main()
{
	car c1;
	c1.make="maruti";
	c1.model="SUV";
	c1.year=2022;
	cout<<"make: "<<c1.make<<endl;
	cout<<"model: "<<c1.model<<endl;
	cout<<"year: "<<c1.year<<endl;
	c1.startEngine();
	c1.Break();
	return 0;
}
