#include <iostream>
#include <vector>

using namespace std;


int main()
{
    int N; // h
    int M; // mennyi sor 

    cin >> N;
    cin >> M;


    vector<int> lista (N+1, 0);


    int x;
    for (size_t i = 0; i < M*2; i++)
    {
        cin >> x;
        lista[x]++;
    }






    int y = 0;
    int z;
    for (size_t i = 0; i < lista.size(); i++)
    {
        if(lista[i] == 1)
        {
            y++;
        }
    }
    
    cout << y << " " << z;
}