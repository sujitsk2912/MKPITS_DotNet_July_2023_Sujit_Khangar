#include<stdio.h>
int main()
{
	int temp;
	int n1=10;
	int n2=20;
	int *p1=&n1;
	int *p2=&n2;
	
	printf("Before swaping *p1=%d,*p2=%d",*p1,*p2);
	temp=*p1;
	*p1=*p2;
	*p2=temp;
	printf("\nAftre swapping *p1=%d,*p2=%d",*p1,*p2);
}
