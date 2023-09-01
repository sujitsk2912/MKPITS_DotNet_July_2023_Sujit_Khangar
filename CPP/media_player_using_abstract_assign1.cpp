#include<iostream>
using namespace std;
class mediaplayer
{
	public:
		virtual void play()=0;
		void play()
		{
			cout<<"\nMedia Play"<<endl;
		}
		void pause()
		{
			cout<<"Media Pause"<<endl;
		}
		void stop()
		{
			cout<<"Media stop"<<endl;
		}
};
class audioplayer:public mediaplayer
{
	public:
		void media()
		{
			cout<<"------- Audio Player -------"<<endl;
		}
};
class videoplayer:public mediaplayer
{
	public:
		void media()
		{
			cout<<"\n------- Video Player -------"<<endl;
		}
};
int main()
{
	audioplayer a;
	a.media();
 	a.play();
	a.pause();
	a.stop();
	videoplayer v;
	v.media();
	v.play();
	v.pause();
	v.stop();
	return 0;	
}
