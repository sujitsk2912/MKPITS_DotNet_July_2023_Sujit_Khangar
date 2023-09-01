#include<stdio.h>
int main()
{
	int n1,n2;
	int arr1[n1];
	int arr2[n2];
	int i,j,count=0;
	printf("Enter value of array1: ");
	scanf("%d",&n1);
	printf("Enter elements:\n");
	for(i=0;i<n1;i++)
	{
		scanf("%d",&arr1[i]);
	}
	printf("Enter value of array2: ");
	scanf("%d",&n2);
	printf("Enter elements:\n");
	for(i=0;i<n2;i++)
	{
		scanf("%d",&arr2[i]);
	}
	for(i=0;i<n1;i++)
	    {
			for(j=0;j<n1;j++)
				{
					if(arr1[i]==arr2[j])
					{
						count++;
						break;
					}
				}
		}
	if((count==n1)&&(count==n2))
		{
			printf("two matrices are equal");
		}
	else
		{
			printf("the matrices are not equal");
		}		
}

