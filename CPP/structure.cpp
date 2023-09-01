#include<iostream>
using namespace std;
struct book
{
	char name[50];
	char title[50];
	char author[50];
	int book_id;
	
};

int main()
{
	struct book b1;
	cout<<"Book Name:";
	cin>>b1.name;
	cout<<"\ntitle:";
	cin>>b1.title;
	cout<<"\nauthor:";
	cin>>b1.author;
	cout<<"\nbook_id:";
	cin>>b1.book_id;
	
	cout<<"\nName: "<<b1.name;
	cout<<"\nTitle: "<<b1.title;
	cout<<"\nauthor: "<<b1.author;
	cout<<"\nbook_id: "<<b1.book_id;
	return 0; 
}
