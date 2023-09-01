#include<stdio.h>
int main()
{
	int num;
	printf("Enter Any Number\n");
	scanf("%d",&num);
	switch (num%2)
	{
		case 0:
		printf("Number is Even");
		break;
		
		case 1:
		printf("Number is Odd");
		break;
		}
}
