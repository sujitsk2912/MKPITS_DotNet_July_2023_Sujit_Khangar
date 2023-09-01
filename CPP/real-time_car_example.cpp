#include<iostream>
using namespace std;
class enginee
{
	protected:
		int power;
	public:
		void start()
		{
			cout<<"Enginee Started"<<endl;
		}
		void stop()
		{
			cout<<"Enginee Stoped"<<endl;
		}
};
class vehicle
{
	protected:
		string brand;
	public:
		void accelarate()
		{
			cout<<"Car Exelarate"<<endl;
		}
		void brake()
		{
			cout<<"Brake Applied"<<endl;
		}
		void displaybrand()
		{
			cout<<"Brand: Maruti"<<brand<<endl;
		}
};
class car:public enginee, public vehicle
{
	public:
		void drive()
		{
			start();
			accelarate();
			cout<<"Car is driving"<<endl;
		}
		void park()
		{
			stop();
			brake();
			cout<<"Car is Parking"<<endl;
		}
};
int main()
{
	car c1;
	c1.displaybrand();
	c1.drive();
	c1.park();
	return 0;	
}
