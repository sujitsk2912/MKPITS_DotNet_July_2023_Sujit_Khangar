#include<stdio.h>
#include<string.h>
struct student
{
	int fees;
	float day,hr;
	char name[50];
};
int main()
{
		float day,hr;
		struct student stu;
	  	printf("Enter Name: ");
	  	scanf("%s",stu.name);
	  	printf("\nEnter Fees for 6 months: ");
	  	scanf("%d",&stu.fees);
	  	printf("\n------------------ Student Fees Details ---------------------");
		day = stu.fees / 180;
	  	hr = day / 24;
	  	printf("\n\nName of the Student : %s\n\nFees Per Day: %f.Rs\n\nFees Per Hour: %f.Rs",stu.name,day,hr);
}
