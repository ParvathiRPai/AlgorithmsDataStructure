// Strings.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include "Strings.h"
#include"iostream";
#include"vector";
#include"fstream";

using namespace std;

 void Rotate(int arr[], int k, int n)
{
	
	for (int i = 0; i < k; i++)
	{
		int prev = arr[n - 1];
		for (int j = 0; j < n ; j++)
		{
			int temp = arr[j];
			arr[j] = prev;
			prev = temp;
		}
	}
}
 void Arrange(int arr[], int n)
 {
	 
	 for (int i = 0; i < n; i++)
	 {
		 if (arr[i] != -1 && arr[i] != i)
		 {
			 int x = arr[i];
			 while (arr[x] != -1 && arr[x] != x)
			 {
				 int y = arr[x];
				 arr[x] = x;
				 x = y;
			 }
			 arr[x] = x;
			 if (arr[i] != i)
			 {
				 arr[i] = -1;
			 }
		}
	 }
 }
void Print(int arr[])
{
	for (int i = 0; i < 9; i++)
	{
		cout << arr[i];
	}
}

void Reverse1(int arr[], int n)
{
	int result[10];
	for (int i = n; i > 0; i--)
	{
		result[i] = arr[i];
		cout << result[i];
	}
	
}

int main()
{
	int arr[] = { -1, -1, 6, 1, 9,
		3, 2, -1, 4, -1 };
	
	int k = 3;
	Reverse1(arr, 10);
	Print(arr);
	cin.get(); 

    return 0;
}

