#include<iostream>
using namespace std;
class ability
{
	protected:
		string abilityname;
	public:
	void Ability(string abn)
	{
		abilityname=abn;
	}
	void displayability()
	{
		cout<<"Ability Name:"<<abilityname<<endl;
	}
};
class equipment
{
	protected:
		string equipmentname;
	public:
	void equipmentitem(string eitem)
	{
		equipmentname=eitem;
	}
void displayequipment()
	{
		cout<<"Equipment Name:"<<equipmentname<<endl;
	}
};
class character:public ability, public equipment
{
	public:
		string charname;
		
	void charn(string cname, string abn, string eitem)
	{
		charname=cname;
		abilityname(abn);
		equipmentname(eitem);
    }
};
void displaychar()
{
	cout<<"Character Name: "<<charname;
	ability::display();
	equipment::display();
	
}
};
int main()
{
	character c1;
	c1.charn("sujit","gamer","controller");
	c1.displaychar();
	return 0;
}
