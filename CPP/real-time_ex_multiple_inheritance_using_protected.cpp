#include<iostream>
using namespace std;
class ability
{
	protected:
		string abilityname;
	public:
	void getability(string abn)
	{
		abilityname=abn;
	}
};
class equipment
{
	protected:
		string equipitem;
	public:
	void getequipment(string item)
	{
		equipitem=item;
	}
};
class charachter:public ability, public equipment
{
	private:
		string charname;
	public:
	void getchar(string cname)
	{
		charname=cname;
	}
	void display()
	{
		cout<<"charachter Name: "<<charname<<endl;
		cout<<"Ability Name: "<<abilityname<<endl;
		cout<<"Equipment Name: "<<equipitem<<endl;
	}
};
int main()
{
	charachter c1;
	c1.getchar("Sujit");
	c1.getability("Gamer");
	c1.getequipment("Controler");
	c1.display();
	return 0;
}
