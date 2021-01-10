#include <stdio.h>
#include <stdlib.h>
#include "fileInput.h"

/* run this program using the console pauser or add your own getch, system("pause") or input loop */
//Banasko Vladyslav 991528801
// calculate all occurrences of each letter and save it into array
void calculateLetters(int arr[],char string[],int length) {

	for(int i=0; i<length; i++) {
		if(string[i]=='A'||string[i]=='a') {
			arr[0]++;
		}
		if(string[i]=='B'||string[i]=='b') {
			arr[1]++;
		}
		if(string[i]=='C'||string[i]=='c') {
			arr[2]++;
		}
		if(string[i]=='D'||string[i]=='d') {
			arr[3]++;
		}
		if(string[i]=='E'||string[i]=='e') {
			arr[4]++;
		}
		if(string[i]=='F'||string[i]=='f') {
			arr[5]++;
		}
		if(string[i]=='G'||string[i]=='g') {
			arr[6]++;
		}
		if(string[i]=='H'||string[i]=='h') {
			arr[7]++;
		}
		if(string[i]=='I'||string[i]=='i') {
			arr[8]++;
		}
		if(string[i]=='J'||string[i]=='j') {
			arr[9]++;
		}
		if(string[i]=='K'||string[i]=='k') {
			arr[10]++;
		}
		if(string[i]=='L'||string[i]=='l') {
			arr[11]++;
		}
		if(string[i]=='M'||string[i]=='m') {
			arr[12]++;
		}
		if(string[i]=='N'||string[i]=='n') {
			arr[13]++;
		}
		if(string[i]=='O'||string[i]=='o') {
			arr[14]++;
		}
		if(string[i]=='P'||string[i]=='p') {
			arr[15]++;
		}
		if(string[i]=='Q'||string[i]=='q') {
			arr[16]++;
		}
		if(string[i]=='R'||string[i]=='r') {
			arr[17]++;
		}
		if(string[i]=='S'||string[i]=='s') {
			arr[18]++;
		}
		if(string[i]=='T'||string[i]=='t') {
			arr[19]++;
		}
		if(string[i]=='U'||string[i]=='u') {
			arr[20]++;
		}
		if(string[i]=='V'||string[i]=='v') {
			arr[21]++;
		}
		if(string[i]=='W'||string[i]=='w') {
			arr[22]++;
		}
		if(string[i]=='X'||string[i]=='x') {
			arr[23]++;
		}
		if(string[i]=='Y'||string[i]=='Y') {
			arr[24]++;
		}
		if(string[i]=='Z'||string[i]=='z') {
			arr[25]++;
		}
	}
}

// find number of most common occurrences
int mostCommon(int arr[],char str[],int size) {

	int common=arr[0];
	for(int i=0; i<size; i++) {
		if (arr[i]>common) {
			common=arr[i];
		}
	}

	printf("most common %d\n",common);

	return common;
}
//find position of most common letter , resolving tie situation
char positionMost(int common,int arr[],char alphabet[], int size) {

	char pos =alphabet[0];
	char letter = alphabet[25];
	for(int i=0; i<size; i++) {
		if(arr[i]==common) {
			if(alphabet[i]<letter) {
				letter = alphabet[i];
				pos = alphabet[i];
			}
		}
	}
	return pos;
}
//find number of least common occurrences
int leastCommon(int arr[],char str[],int size) {

	int common=arr[0];


	for(int i=0; i<size; i++) {
		if (arr[i]<common&&arr[i]>0) {
			common=arr[i];
		}
	}
	return common;
}
//find position of least common letter
char positionLeast(int leastCommon,int arr[],char alphabet[], int size) {

	int pos = arr[0];
	for(int i=0; i<size; i++) {
		if(arr[i]==leastCommon) {
			pos = alphabet[i];
		}
	}
	return pos;
}
// count if each letter occurred in string at least one time
int uniqueLetters(int arr[], int size) {
	int letter = 0;

	for(int i=0; i<size; i++) {
		if(arr[i]!=0) {
			letter++;
		}
	}
	return letter;
}

//display each letter as many times as number of occurrences of this letter in text
void displayHistogram(const int letters[], char alphabet[],int lettersSize,int alphabetSize) {

	for(int i=0; i<alphabetSize; i++) {
		for(int j=0; j<letters[i]; j++) {
			printf("%c",alphabet[i]);
		}
		printf(" %d\n",letters[i]);
	}
}


int main(int argc, char *argv[]) {

	//  alphabet array
	char alphabet[] = {'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z'};
	int alphabetSize = 25;
	// array of int that holds record of each occurrence of each letter according to order in alphabet
	int letters[25];
	//assigning all records to 0
	for(int i=0; i<26; i++) {
		letters[i]=0;
	}
	//length of letters array
	int lettersSize = 26;

	//read file
	char str[MAX_FILE];
	int len = readFile("wonder.txt", str);

	if (len == -1) {
		printf("An error occurred\n");
	} else {

		// calculate number of occurrences of each letter
		calculateLetters(letters,str,len);

		// most common
		int common = mostCommon(letters,alphabet,lettersSize);

		char posMost = positionMost(common,letters,alphabet,lettersSize);

		printf("pos and letter of most common %c\n",posMost);

		//least common

		int leastCom= leastCommon(letters,alphabet,lettersSize);

		printf("least common %d\n",leastCom);

		char posLeast=  positionLeast(leastCom,letters,alphabet,lettersSize);

		printf("pos and letter of least common %c\n",posLeast);

		// unique letters

		int unique = uniqueLetters(letters,lettersSize);
		printf("unique letter : %d\n",unique);

		// display histogram

		displayHistogram(letters,alphabet,lettersSize,alphabetSize);




	}
}
