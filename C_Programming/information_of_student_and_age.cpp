#include<stdio.h>
#include<conio.h>
struct student
{
	char name[50];
	int roll;
	struct date
	{
		int D,M,Y;
	}bd,ad;
};
int main()
{
	int age;
	
	struct student stu;

	printf("Enter Student Name: ");
	scanf("%s",stu.name);
	printf("Roll No.: ");
	scanf("%d",&stu.roll);
	printf("Birth-Day: ");
	scanf("%d-%d-%d",&stu.bd.D,&stu.bd.M,&stu.bd.Y);
	printf("Admission year: ");
	scanf("%d-%d-%d",&stu.ad.D,&stu.ad.M,&stu.ad.Y);
	
	age = stu.ad.Y - stu.bd.Y;
	printf("Age of the student is: %d",age);
	
	
}
