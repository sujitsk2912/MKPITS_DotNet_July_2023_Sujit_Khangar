#include<stdio.h>
int sum ( int num)
{
	int sum=sum+num;
	return sum;
}
int main()
{
	float num,avg;
	printf("Enter Any Five Numbers\n");
	scanf("\n%f",&num);
	avg=sum/5;
	printf("avg=%f",num);
}
