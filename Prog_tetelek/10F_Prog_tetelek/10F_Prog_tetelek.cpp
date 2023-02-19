#include <iostream>
#include <vector>
#include <map>
using namespace std;

int main()
{
    vector<int> lista{ 1,6,3,9,4,5,8,6,7,9,1,2,7,3,5,9,6,7,8,1,2,5,1,2,5,1,2,4 };

    //minden ciklus elõtt elsõ számú kérdés: while vagy for?


#pragma region WHILE-al oldandó


#pragma region HELYE
    // Találjuk meg a legelsõ 7-es helyét(ha nincs 7-es, lista utolsó utáni indexét adja vissza)

    cout << "a lista merete: " << lista.size() << endl;
    int i = 0;
    while (i < lista.size() && lista[i] != 7) // ez nem megfordítható
    {
        i++;
    }
    cout << i << endl;

#pragma endregion


#pragma region ELDÖNTÉS tétele
    // Van-e 7-es a listában

    int i = 0;
    while (i < lista.size() && lista[i] != 7) // ez nem megfordítható
    {
        i++;
    }
    cout << (i != lista.size()) << endl;

#pragma endregion


#pragma region KERESÉS tétel

#pragma region HA VAN
    // Hol van 7-es, ha tuti,hoy van 7-es?

    i = 0;
    while (lista[i] != 7)
    {
        i++;
    }
    cout << i << endl;
#pragma endregion

#pragma region HA NEM BIZTOS, HOGY VAN
    //Hol van az elsõ 7-es, ha nem biztos, hogy van 7-es, és ha nincs, akkor legyen -1?

    i = 0;
    while (i < lista.size() && lista[i] != 7)
    {
        i++;
    }
    cout << (i == lista.size() ? -1 : i) << endl;


    //Hol van az elsõ 7-es, ha nem biztos, hogy van 7-es, és ha nincs, akkor legyen -1?

    //ugyanaz, mint a helye, csak másik irányba megy a ciklus
    i = lista.size() - 1;
    while (0 <= i && lista[i] != 7) // nem megfordítható
    {
        i--;
    }
    cout << i << endl;

#pragma endregion

#pragma endregion


#pragma endregion

//---------------------------------------------------------

#pragma region FOR-al oldandó


#pragma region MAXIMUMKERESÉS

#pragma region ÉRTÉK
    //sosem 0-tól indul!

    int max_ertek = lista[0];
    for (size_t i = 1; i < lista.size(); i++)
    {
        if (max_ertek < lista[i])
        {
            max_ertek = lista[i];
        }
    }
    cout << max_ertek << endl;

#pragma endregion

#pragma region INDEX
    // ez sem 0-tól indul

    int max_ertek = lista[0];
    int max_hely = 0;
    for (size_t i = 1; i < lista.size(); i++)
    {
        max_ertek = lista[i];
        max_hely = i;
    }
    cout << max_hely << endl;

#pragma endregion

#pragma endregion


#pragma region ÖSSZEGZÉS
    //szorzás, összeadás, stb.

    int sum = 0;
    for (int& elem : lista)
    {
        sum += elem;
    }
    cout << sum << endl;

#pragma endregion


#pragma region MEGSZÁMLÁLÁS
    //Hány 7-es van?

    int db = 0;
    for (int& elem : lista)
    {
        if (elem == 7) {
            db++;
        }
    }
    cout << db << endl;

#pragma endregion


#pragma region SOROZATSZÁMÍTÁS
    
#pragma region KIVÁLOGATÁS (WHERE/FILTER)
    //Válogassuk ki a páros számokat!

    vector<int> parosak;
    for (auto& elem : lista)
    {
        if (elem % 2 == 0) {
            parosak.push_back(elem);
        }
    }
    for (auto& elem : parosak) { cout << elem << " "; }
    cout << endl;

#pragma endregion

#pragma region MÁSOLÁS (MAP/SELECT)
    //Az a lista, amely a számok négyzeteit tartalmazza!

    vector<int> negyzetek(lista.size());    
    for (size_t i = 0; i < lista.size(); i++)
    {
        negyzetek[i] = lista[i] * lista[i];
    }
    for (auto& elem : negyzetek) { cout << elem << " "; }
    cout << endl;

#pragma endregion

#pragma region GROUP BY

    string szoveg = "asldfkjhasldfkjhasldfkjhasldfkjd";

    cout << endl;
    map<char, int> statisztika;
    for (char& k : szoveg)
    {
        statisztika[k]++;
    }

#pragma endregion


#pragma endregion


#pragma endregion


    


    

}