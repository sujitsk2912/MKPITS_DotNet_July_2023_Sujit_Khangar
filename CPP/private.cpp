#include<iostream>
using namespace std;
class student
{
	private:
		int rollno;
	public:
void displayData()
{
	cout<<"Roll No.: "<<rollno;
}
void getData(int r)
{
	rollno=r;
}
};
int main()
{
	student s1;
	int rn;
	cout<<"Enter Roll No.: ";
	cin>>rn;
	s1.getData(rn);
	s1.displayData();
}
