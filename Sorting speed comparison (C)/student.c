#include <stdio.h>
#include <stdbool.h>
#include <stdlib.h>
#include "clock.h"
#include "LinkedList.h"

//Banasko Vladyslav 991528801 . Second version of programm , with correct compare function and correct second array of doubles

/* PROG20799 Project, Prof. Georg Feil
   Student Name: Your Name Here
   Student ID: Your ID Here     */


// readFile function:
// Reads a CSV text file of students with four fields:
// Last name,first name,ID,GPA
// 'fileName' is the name of the text file to read.
// Returns the number of lines read, or -1 on errors.
// You may add a parameter to this function if you wish.

static List* list ;

int readFile(const char fileName[]) {
	FILE *fptr;
	int lines = 0;

	if ((fptr = fopen(fileName, "r")) == NULL) {
		fprintf(stderr, "Error, failed to open %s: ", fileName);
		perror("");
		return -1;
	}

	char lastName[NAME_STR_LEN];
	char firstName[NAME_STR_LEN];
	long int ID;
	double GPA;

	list = initList();

	while (feof(fptr) == 0) {
		// Read all fields from one line in the file into temporary variables
		// Assumes fields are separated by commas
		fscanf(fptr, "%99[^,],", lastName);
		fscanf(fptr, "%99[^,],", firstName);
		fscanf(fptr, "%ld,", &ID);
		fscanf(fptr, "%lf ", &GPA);

		//** Your code to create a node and append it to the linked list goes here
		Node* nd = createNode(lastName,firstName,ID,GPA);
		appendNode(list,nd);

		lines++;
	}

	return lines;
}

void sort(double a[],int n) {

	bool swapped = true;  // Did we swap?
	while (swapped) {
		swapped = false;
		double temp;
		for (int i = 0; i < n -1; i++) {// Check if we need to swap
			if (a[i] < a[i+1]) {// Swap two array elements !!! change from > to <
				temp = a[i];
				a[i] = a[i+1];
				a[i+1] = temp;
				swapped = true;  // Show that a swap occurred
			}
		}
	}
}
void swap(double* a , double* b) {
	double* temp = a;
	a = b ;
	b = temp;

}

int cmpfunc(const void* a, const void* b) {
	double num1 = *(double*)a;
	double num2 = *(double*)b;
	if (num1 > num2) { // >
		return -1;
	} else if (num2 > num1) {
		return 1;
	} else {
		return 0;
	}
}

int main(int argc, char** argv) {
	int lines = readFile("StudentList.txt");

	printf("\n%d lines read from the file.\n", lines);

	//** Your code goes here **//

	int size = 50000;
	double arr[size];
	int i=0;
	Node* temp = list->head;  // Start at head
	// Loop as long as there are more nodes
	while (temp != NULL) { // get GPA in array of doubles
		arr[i] = temp->GPA;
		temp = temp->next; // Go on to the next node
		i++;
	}
	
//	for(int i = 0; i<50; i++) {
//		printf("%f\n",arr[i]);
//	}

	// check how much time will take to sort
	clock_t t1 = clock();
	sort(arr,size);
	clock_t t2 = clock();
	double time1 = (double)(t2-t1)/CLOCKS_PER_SEC;

//	printf("%f time sorting in sec\n",time1);

//
//	for(int i = 0; i<50; i++) {
//		printf("%f\n",arr[i]);
//	}

	double arr1[size];
	
	temp = list->head;  // Start at head
	// Loop as long as there are more nodes
	i = 0;
	while (temp != NULL) { // get GPA in array of doubles
		arr1[i] = temp->GPA;
		temp = temp->next; // Go on to the next node
		i++;
	}
//	for(int i = 0; i<50; i++) {
//		printf("%f\n",arr1[i]);
//	}
	

	clock_t t3 = clock();
	qsort(arr1,size,sizeof(double),cmpfunc);
	clock_t t4 = clock();
	double time2 = (double)(t4-t3)/CLOCKS_PER_SEC;
	
		for(int i = 0; i<50; i++) {
		printf("%f\n",arr1[i]);
	}

	printf("%f time sorting in sec\n",time2);




}
