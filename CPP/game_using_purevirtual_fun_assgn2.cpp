#include<iostream>
using namespace std;
class games
{	
	public:
	virtual void game()=0;
	void start()
	{
	cout<<"Game started"<<endl;
	}	
	void play()
	{
		cout<<"Game Playing"<<endl;
	}
	void end()
	{
		cout<<"Game ended"<<endl;
	}
};
class tik_tak_toe:public games
{
	public:
		void game()
		{
			cout<<"------- Tik Tak Toe -------\n"<<endl;
		}
};
class chess:public games
{
	public:
		void game()
		{
			cout<<"\n------- Chess -------\n"<<endl;
		}
};
int main()
{
	games *G;
	tik_tak_toe ttt;
	G=&ttt;
	G->game();
	G->start();
	G->play();
	G->end();
	chess c;
	G=&c;
	G->game();
	G->start();
	G->play
	();
	G->end();
	return 0;
}
