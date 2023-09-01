#include<stdio.h>
#include<string.h>
struct employee
{
	int id,salary;
	char name[50];
	char designation[50];
	char department[50];
};
void print(struct employee b1);
int main()
{
	struct employee b1;
	printf("Employee Name:");
	scanf("%s",b1.name);
	printf("\nEmployee Id:");
	scanf("%d",&b1.id);
	printf("\nDesignation(m,c,p):");
	scanf("%s",b1.designation);
	printf("\nDepartment(cse,it,etc,mec.):");
	scanf("%s",b1.department);
	printf("\nSalary:");
	scanf("%d",&b1.salary);
	printf("\n\n******** Details Of Employee ********\n\n");
	print(b1);
}
	
	void print(struct employee b1)
	{
	printf("Name= %s\n",b1.name);
	printf("\nId= %d\n",b1.id);
	printf("\nDesignation= %s\n",b1.designation);
	printf("\nDeapartment= %s\n",b1.department);
	printf("\nSalary= %d\n",b1.salary);
	}
