#include<stdio.h>
#include<string.h>
struct player
{
	char name[50];
	int runs;
};
int main()
{
	struct player p[11];
	int i,total=0;
//	printf("Total players played: ");
//	scanf("%d",&num);
	for(i=0;i<11;i++)
	{
	printf("Name of player: ");
	scanf("%s",p[i].name);
	printf("Score: ");
	scanf("%d",&p[i].runs);
	}	
	for(i=0;i<11;i++)
	total= total+ p[i].runs;
	printf("Total score of Team = %d",total);
}
