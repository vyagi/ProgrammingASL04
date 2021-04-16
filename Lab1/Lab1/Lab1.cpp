#include <iostream>

using namespace std;

void task1() 
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
void task2() {
    int myArray[5] = { 5, 1, 78, 29, 4 };

    int* pointer = myArray;

    for (int i = 0; i < 5; i++)
    {
        cout << *(pointer++) << endl;
    }
}
void task6() 
{
    int* x = new int;
    //cout << *x << endl; // we shouldn't do it, it's uninitialized memory
    *x = 6;
    cout << *x << endl;
    delete x;
    x = NULL;
    //cout << *x << endl;  // we shouldn't do it, we have deleted the object
}

int main()
{
    int size = 10;
    int* myArray = new int[size];

}