#include <iostream>

//1.	Declare variables of type int, float, double and char.Assign some example values to them. Display the values
//Declare pointers for int, float, double and char. Set the pointers to the created variables. Display the values using pointers
//Change the values using pointers.Display the values using pointers.Then display the same values using the variables
//Then display the values of raw pointers

using namespace std;

int main()
{
    int v1 = 10;
    float v2 = 20.2f;
    double v3 = 34.9;
    char v4 = 'x';

    cout << v1 << " " << v2 << " " << v3 << " " << v4 << endl;

    int* p1 = &v1;
    float* p2 = &v2;
    double* p3 = &v3;
    char* p4 = &v4;

    cout << *p1 << " " << *p2 << " " << *p3 << " " << *p4 << endl;

    *p1 = 20;
    *p2 = 44.5f;
    *p3 = 20.213;
    *p4 = 'a';

    cout << *p1 << " " << *p2 << " " << *p3 << " " << *p4 << endl;
    cout << v1 << " " << v2 << " " << v3 << " " << v4 << endl;

    cout << p1 << " " << p2 << " " << p3 << " " << p4 << endl;
}