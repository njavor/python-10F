print("""Kedves Felhasználó! Üdv! Adj meg 2 db számot, megmondom 
melyik a nagyobb.""")

a = input("a=")
b = input("b=")

if a==b:
    print("Egyenlőek")
elif a<b:
    print(b + " a nagyobb")
else:
    print(a + " a nagyobb")