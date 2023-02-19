// 10F_cpp.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

/** /
    block komment
/**/

#include <iostream>
#include <string>


using namespace std;

int main() // entry point
{
    cout << "Hello World!\n" << "és ez is " << "meg ez is " << endl << "ez is sorvége\n" << "lám\n";  // Console Out -> cout
    // NE HASZNÁLJ ÉKEZETES BETÛKET
    
    int a = 5;
    int b = 7;
    cout << "a+b egyenlo: " << a + b << "\n";

    cout << "Adj meg egy szamot\n";
    int c;
    cin >> c;
    cout << "Te most azt mondtad, hogy " << c << endl;

    string d = "blabla\n";
    cout << d;

    bool e = 5 < 7;

    if (e)
    {
        cout << "5 kisebb, mint 7\n";
    }
    else
    {
        cout << "olyan is van, hogy else";
    }

    for (size_t i = 0; i < 5; i++)
    {
        cout << "Lepek!\n";
    }

    cout << "izé\n";

    unsigned int t = 1;

    cout << t - 1 << endl;
    cout << t - 2 << endl;
    cout << t - 3 << endl;
    cout << t - 4 << endl;

    int s = 0;
    while (s < 5)
    {
        cout << s++ << endl;
    }



    int kapcsolo;
    cout << endl << "Adj meg egy szamot a kapcsolonak:\n";
    cin >> kapcsolo;

    switch (kapcsolo)
    {
    case 1:
        cout << "ez egy 1-es lett" << endl;
        break;
    case 2:
        cout << "ez viszont egy 2-es lett" << endl;
        break;
    default:
        cout << "ez valami egeszen mas lett" << endl;
        break;
    }


    switch (kapcsolo)
    {
    case 1:
    case 2:
    case 3:
    case 4:
    case 5:
        cout << "ez 5 vagy kisebb lett" << endl;
        break;
    case 6:
        cout << "ez 6 lett" << endl;
        break;
    default:
        cout << "ez valami 6-nal nagyobb lett" << endl;
        break;
    }


}