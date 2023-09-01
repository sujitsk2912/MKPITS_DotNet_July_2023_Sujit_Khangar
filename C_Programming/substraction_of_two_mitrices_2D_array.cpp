#include<stdio.h>
int main()
{
	int i,j,k,n1,n2,n3;
	int arr1[n1];
	int arr2[n2];
	int sub[n3];
	printf("Enter value of array1:");
	scanf("%d",&n1);
	printf("Enter Elements:\n");
	for(i=0;i<n1;i++)
	{
		scanf("%d",&arr1[i]);
	}
	printf("Enter value of array2:");
	scanf("%d",&n2);
	printf("Enter Elements:\n");
	for(i=0;i<n2;i++)
	{
		scanf("%d",&arr2[i]);
	}
	for(i=0;i<n1;i++)
	{
		for(j=0;j<n2;j++)
		{
		   sub[k]=arr1[i]-arr2[j];
		}
	}
	printf("Substraction of two matrices are:\n");
	for(i=0;i<n1;i++)
	{
		for(j=0;j<n2;j++)
		{
			printf("%d",sub[k]);
		}
		printf("\n");
	}
	
}
