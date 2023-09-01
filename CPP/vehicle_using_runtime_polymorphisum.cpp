
#include<iostream>
using namespace std;
class vehicle
{
	public:
	virtual void drive()
	{
	cout<<"Enginee of Car,Motorcycle, and truck "<<endl;	
	}
	void start()
	{
		cout<<"Enginee Started"<<endl;
	}
	void stop()
	{
		cout<<"Enginee Stopped"<<endl;
	}
};
class car:public vehicle
{
	public:
		void drive()
		{
		cout<<"Car is Driving"<<endl;	
		}
};
class motorcycle:public vehicle
{
	public:
		void drive()
		{
			cout<<"Motorcycle is Driving"<<endl;
		}
};
class truck:public vehicle
{
	public:
		void drive()
		{
			cout<<"truck is Driving"<<endl;
		}
};
int main()
{
	vehicle *v;
	car c;
	v=&c;
	v->start();
	v->drive();
	v->stop();
	motorcycle m;
	v=&m;
	v->start();
	v->drive();
	v->stop();
	truck t;
	v=&t;
	v->start();
	v->drive();
	v->stop();
	return 0;
}
