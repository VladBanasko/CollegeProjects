#include <stdio.h>
#include <stdlib.h>
#include "vector_math.h" 

/* run this program using the console pauser or add your own getch, system("pause") or input loop */
//Banasko Vladyslav 991528801


void vec3dSet(Vec3d* vec, double x, double y, double z){
	vec->x = x;
	vec->y = y;
	vec->z = z;
}

void vec3dPrint(const Vec3d* vec){
	printf("(%g, %g, %g)\n",vec->x,vec->y,vec->z);
}

void vec3dAdd(const Vec3d* src1, const Vec3d* src2, Vec3d* dst){
	
	dst->x = src1->x + src2->x;
	dst->y = src1->y + src2->y;
	dst->z = src1->z + src2->z;
}

void vec3dScalarMul(const Vec3d* src, double a, Vec3d* dst){
	dst->x = src->x * a;
	dst->y = src->y * a;
	dst->z = src->z * a;
	
}

void lineSet(Line* line, const Point* start, const Point* end){
	line->start = *start;
	line->end = *end;
}

void linePrint(const Line* line){
	printf("(%g, %g, %g) - (%g, %g, %g)\n",line->start.vector.x,line->start.vector.y,line->start.vector.z,line->end.vector.x,line->end.vector.y,line->end.vector.z);
}




int main(int argc, char *argv[]) {


// creating 4 vectors
Vec3d vector1;
Vec3d vector2;
Vec3d vector3;
Vec3d vector4;

// setting vector1 and vector2
vec3dSet(&vector1,-2,1,11);
vec3dSet(&vector2,3.5,-7,0.3);

// printing vector1 and vector2
vec3dPrint(&vector1);
vec3dPrint(&vector2);

// setting vector3 by adding vector1 and vector2
vec3dAdd(&vector1,&vector2,&vector3);

//printing vector3
vec3dPrint(&vector3);

// multiplying vector3 by 0.5 and save results in vector4
vec3dScalarMul(&vector3,0.5,&vector4);

//print vector4
vec3dPrint(&vector4);


Line line1;
Point point1;
Point point2;

// assign point1 to vector1 and point2 to vector4
point1.vector = vector1;
point2.vector = vector4;

// set line with start in point1 and end in point2
lineSet(&line1,&point1,&point2);
//print line
linePrint(&line1);

// create 2 vectors using malloc
Vec3d* vector5 = malloc(sizeof(Vec3d));
Vec3d* vector6 = malloc(sizeof(Vec3d));

//set vector5 using vector1 coordinates
vec3dSet(vector5,vector1.x,vector1.y,vector1.z);

//set vector6 by muliplying vector5 by -1.7
vec3dScalarMul(vector5,-1.7,vector6);

// print vector5 and vector6
vec3dPrint(vector5);
vec3dPrint(vector6);

// free space where vector5 and 6 are located
free(vector5);
free(vector6);





}
