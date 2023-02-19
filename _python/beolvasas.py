lista = []
with open("03_000.txt", "r", encoding="utf8") as f:
    for sor in f:
        lista.append(int(sor))

"""
for elem in lista:
    print(elem)
print(lista)
"""

print("\n1. feladat")
print(f"Lista elemeinek száma: {len(lista)}")


print("\n2. feladat")
i = 0
while i<len(lista) and not lista[i]<0:
    i+=1
print("Nincs negatív szám" if i==len(lista) else "Van negatív szám")

print("\n3. feladat")
par = 0
for elem in lista:
    if elem %2 == 0:
        par += 1
print(f"{par} páros szám van a sorozatban")


print("\n4. feladat")
max = lista[0]
for elem in lista:
    if elem > max:
        max = elem
print(f"{max} a legnagyobb szám")


print("\n5. feladat")
for elem in lista:
    if elem %10 == 0:
        print(elem)


print("\n6. feladat")
i = 0
while i<len(lista) and not lista[i] %29 == 0:
    i+=1
print(f"{i-1} az első 29-cel osztható szám indexe")


print("\n7. feladat")
paros = True
i = 0
while i<len(lista) and paros:
    if lista[i] %2 == 1:
        paros = False
    i+=1
print("Minden szám páros" if paros else "Nem minden szám páros")


print("\n8. feladat")
print(f"{sum(lista)} a sorozat átlaga")


print("\n9. feladat")
van = False
i = 0
while not van and i<len(lista)-1:
    if lista[i] %2 == 0 and lista[i+1] == 0:
        van = True
    i+=1
print(f"{lista[i]} egy olyan páratlan szám, amit 0 követ" if van else "Nincs olyan páratlan szám, amit 0 követ")


print("\n10. feladat")
res = " -ERROR- Nincs 17-tel osztható szám -ERROR-"

i = len(lista)-1
while 0>i and not res %17 == 0:
    i+=1
if i == 0: res = lista[i]
print(res)