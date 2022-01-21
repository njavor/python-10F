lista = [1,12,4,41]

szotar = {} # vagy dict
szotar["bla"] = 2
szotar["asdf"] = 1

#print(szotar)

s = "ohohaoipuwehjopabijopajwdiopwjopaivjaiopwerjho3"

sz = {}
for c in s:
    if c in sz.keys():
        sz[c] +=1
    else:
        sz[c] = 1
print(sz)
