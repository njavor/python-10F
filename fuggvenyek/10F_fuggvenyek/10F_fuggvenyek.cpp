#include <iostream>
#include <string>

using namespace std;




int elso_fuggvenyem(int, int); //függvény deklaráció
void csere(int*, int*);
void jobb_csere(int, int);


/** /
POINTEREK





/**/


int main()
{
    int a,b;
    int eredmeny;

    a = 5;
    b = 7;

    cout << a << ";" << b << endl;

    //csere(&a, &b);
    jobb_csere(a, b);

    cout << "POINTEREK\n";

    cout << "a erteke = " << a << endl;
    cout << "a helye = " << &a << endl;

    int* p = &a; // azt jelenti, hogy a 'p'-ben eltároljuk az 'a' helyét

    cout << "p erteke = " << p << endl;
    cout << "p cimen talalhato dolog = " << *p << endl;
    cout << "p helye = " << p << endl;

    // *p az, ami a memóriacímbõl elõállítja az ott lévõ dolgot
    // &a az, ami az a változóból elõszedi, hogy az milyen memóriacímen is van



}

int elso_fuggvenyem(int a, int b){
    return 2 * a + b;
}

void csere(int* x, int* y) {
    int temp = *x;
    *x = *y;
    *x = temp;
}

void jobb_csere(int& x, int& y) {
    int temp = x;
    x = y;
    x = temp;
}