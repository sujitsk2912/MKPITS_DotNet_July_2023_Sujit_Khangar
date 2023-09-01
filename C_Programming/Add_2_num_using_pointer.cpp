#include<stdio.h>
int main()
{
	int num1,num2,sum=0;
	int *p1=&num1, *p2=&num2;
	printf("Enter any 2 Numbers\n");
	scanf("%d%d",&*p1,&*p2);
	sum=*p1+*p2;
	printf("Addition of two numbers are: %d",sum);
}
