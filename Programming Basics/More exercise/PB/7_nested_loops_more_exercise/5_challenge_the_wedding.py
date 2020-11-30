mens = int(input())
womens = int(input())
tables = int(input())

for i in range(1, mens+1):
    for j in range(1, womens+1):
        tables -= 1
        print(f"({i} <-> {j})", end=" ")
        if tables == 0:
            break
    if tables == 0:
        break
