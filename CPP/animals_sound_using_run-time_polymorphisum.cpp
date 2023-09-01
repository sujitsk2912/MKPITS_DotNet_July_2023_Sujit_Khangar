#include<iostream>
using namespace std;
class animal
{
	public:
		virtual void sound()
		{
			cout<<"Animals Sound";
		}
};
class Dog:public animal
{
	public:
		void sound()
		{
			cout<<"Dog's sound bow-bow"<<endl;
		}
};
class Cat:public animal
{
	public:
		void sound()
		{
			cout<<"Cat's sound meow"<<endl;
		}
};
class Cow:public animal
{
	public:
		void sound()
		{
			cout<<"Cow's sound mowwwww"<<endl;
		}
};
int main()
{
	animal *A;
	Cat c;
	A=&c;
	A->sound();
	Dog d;
	A=&d;
	A->sound();
	Cow C;
	A=&C;
	A->sound();
	return 0;
}
