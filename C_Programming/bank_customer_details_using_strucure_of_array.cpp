#include<stdio.h>
#include<string.h>
struct customer
{
	char name[50];
	int anum,bal;
}c[2];
void cheak(struct customer c[], int n)	
{
		int i;
	
	for(i=0;i<n;i++)
	{
	if(c[i].bal<100)
		{
			printf("Name: %s",c[i].name);
			printf("\nAccount No.: %d",c[i].anum);
			printf("\nBalance: %d",c[i].bal);	
		}
	}
}
int main()
{
		int i;
//		struct customer c[2];
		for(i=0;i<2;i++)
		{
		printf("Enter Name of customer: ");
		scanf("%s",c[i].name);
		printf("Enter Account No.: ");
		scanf("%d",&c[i].anum);
		printf("Balance: ");
		scanf("%f",&c[i].bal);
		}
		cheak(c,2);
//		printf("Enter Name of customer: ");
//		scanf("%s",c2.name);
//		printf("Enter Account No.: ");
//		scanf("%d",&c2.anum);
//		printf("Balance: ");
//		scanf("%f",&c2.bal);
		
//			printf("\nIssuficiant Balance In Account");
			return 0;
			

}
