#include<stdio.h>
void sayhello()
{
	printf("Hello\n");
}
int main()
{
	printf("calling Function\n");
	sayhello();
	printf("Back in main\n");
	sayhello();
	printf("\nBye");
	
}
