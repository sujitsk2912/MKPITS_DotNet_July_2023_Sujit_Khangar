#include<stdio.h>
int calculate ( int r, float *a, float *c)
{
	*a= 3.14f*r*r;
	*c= 2*3.14f*r;
}
int main()
{
	int radius;
	float area, circum;
	printf("Enter radius: ");
	scanf("\n%d",&radius);
	calculate(radius,&area,&circum);
	printf("\nArea of circle: %f",area);
	printf("\nCircumference of circle: %f",circum);
}
