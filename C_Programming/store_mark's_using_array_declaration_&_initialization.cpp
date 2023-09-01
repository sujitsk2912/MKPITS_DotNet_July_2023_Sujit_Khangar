#include<stdio.h>
int main()
{
	int i,sum=0;
	int marks[3]={36,87,98};
	for(i=0;i<3;i++)
	{
		printf("\nMarks=%d",marks[i]);
		sum=sum+marks[i];
	}
	printf("\nTotal Marks= %d",sum);
}
