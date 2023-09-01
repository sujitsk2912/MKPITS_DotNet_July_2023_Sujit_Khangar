#include<stdio.h>
int main()
{
	int num=5;
	int *ptr=&num;
	printf("Address: %x\n",ptr);
	printf("value of address: %d\n",*ptr);
}
