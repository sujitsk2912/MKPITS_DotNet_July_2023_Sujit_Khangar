#include<stdio.h>
int area()
{
	int num1,num2;
	printf("Enter Any Value\n");
	scanf("\n%d%d",&num1,&num2);
	int result=num1*num2;
	return result;
}
int main()
{
	int result;
	result=area();
	printf("area of squre= %d",result);
}
