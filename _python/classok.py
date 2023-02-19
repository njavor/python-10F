from time import process_time_ns


class Osztály:    
    osztalyok_szama=0 # C#-ban a statikus változó
    def __init__(self, *args, **kwargs):# "__init__" a konstruktor, "**kwargs" egy szótár, azt használjuk az "*args" helyett általában
        self.letszam=10
        self.nevsor=[]
        self.evfolyam=kwargs["evfolyam"]
        self.szekcio =kwargs["szekcio"]       #ha "private"-et akarunk akkor csak jelezni tudjuk a név előtt "_"-vel; pl.: self._szekcio
        Osztály.osztalyok_szama+=1
        print(f"ezek jöttek még be: {args}, ilyen sokan vannak {len(args)}, ez az első: {args[0]}")
        print(f"ez itt a bejövő szótár: {kwargs}")

    def csatakialtas(self, mit):
        for i in range(self.letszam):
            print(f"{mit} -- Mondta az {i+1}. tanuló.")

    def __str__(self) -> str:
        return f"{self.evfolyam}. évfolyam, {self.szekcio} szekció, ({self.letszam} fő)"

    def __add_() -> int:
        return 20

def main():
    print("Hello world!")
    '''
    o = Osztály()
    o.letszam = 10
    print(o.letszam)
    print(Osztály.osztalyok_szama)
    o1 = Osztály("hali")
    o2 = Osztály("Hali",2)
    '''
    o3 = Osztály("halika", szekcio='A', evfolyam='10')    

    #o3.csatakialtas("Csak az eff!")
    Osztály.csatakialtas(o3,"Csak az eff!")

    #print(o3)

main()