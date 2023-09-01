#include<stdio.h>
int addition()
{
	int n1,n2;
	printf("Enter Any Numbers\n");
	scanf("%d%d",&n1,&n2);
	int result=n1+n2;
	return result;
}
int main()
{
	char ch='y';
	do
	{
		int result;
		result=addition();
		printf("result=%d",result);
		printf("\nDo you want to continue, press 'y': \n");
		fflush(stdin);
		scanf("%c",&ch);
	}
	while(ch=='y');
}
