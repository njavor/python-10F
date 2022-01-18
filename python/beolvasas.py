lista = []
with open("03_000.txt", "r", encoding="utf8") as f:
    for sor in f:
        lista.append(int(sor))

"""
for elem in lista:
    print(elem)
print(lista)
"""

print("1. feladat")
print(f"Lista elemeinek száma: {len(lista)}")

print("2. feladat")
i = 0
while(i<len(lista) and not lista[i]<0):
    i+=1
"""
if i == len(lista):
    print("Nincs negatív szám")
else:
    print("Van negatív szám")
"""
print("Nincs negatív szám" if i==len(lista) else "Van negatív szám")

print("3. feladat")
par = 0
for elem in lista:
    if elem %2 == 0:
        par += 1
print(f"{par} páros szám van a listában")

print("4. feladat")
max = lista[0]
for elem in lista:
    if elem > max:
        max = elem
print(f"{max} a legnagyobb szám")
    
print("5. feladat")
for elem in lista:
    if elem %10 == 0:
        print(elem)

print("6. feladat")

print("7. feladat")

print("8. feladat")