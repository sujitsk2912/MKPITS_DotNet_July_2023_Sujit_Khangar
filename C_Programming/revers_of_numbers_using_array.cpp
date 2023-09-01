#include<stdio.h>
int main()
{
	int i,n, nums[100];
	printf("Enter Number: ");
	scanf("%d",&n);
	for(i=0;i<n;i++)
	{
		printf("Enter values: ");
		scanf("%d",&nums[i]);
	}
	for(i=n-1; i>=0; i--)
	{
		printf("\nArray in reverse oredr are = %d",nums[i]);
	}
}
