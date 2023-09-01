#include<stdio.h>
#include<string.h>
struct workers
{
	char name[50];
	int wage;
	int wdays;
};
int main()
{
	struct workers w1,w2;
	int i,totalw1=0,totalw2=0;
	
		printf("------------------------ Details Of First Worker -----------------------\n\n");
		printf("Name of Worker: ");
		scanf("%s",w1.name);
		printf("Wage: ");
		scanf("%d",&w1.wage);
		printf("Working days: ");
		scanf("%d",&w1.wdays);
		printf("\n\n------------------------ Details Of Second Worker ---------------------\n\n");
		printf("Name of Worker: ");
		scanf("%s",w2.name);
		printf("Wage: ");
		scanf("%d",&w2.wage);
		printf("Working days: ");
		scanf("%d",&w2.wdays);
	printf("------------------------------------------------------------------------------\n");
	totalw1 = w1.wage * w1.wdays;
	printf("\nName of first worker is: %s \n\nTotal payment is: %d\n\n",w1.name,totalw1);
	printf("------------------------------------------------------------------------------\n");
	totalw2 = w2.wage * w2.wdays;
	printf("\nName of second worker is: %s \n\nTotal payment is: %d",w2.name,totalw2);
}
