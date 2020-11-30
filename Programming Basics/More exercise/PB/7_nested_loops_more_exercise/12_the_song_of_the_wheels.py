m = int(input())

count = 0
magic_num = 0
magic = False
for a in range(1, 10):
    for b in range(1, 10):
        for c in range(1, 10):
            for d in range(1, 10):
                if a*b + c*d == m and a<b and c>d:
                    count += 1
                    print (f"{a}{b}{c}{d} ", end="")
                    if count == 4:
                        magic_num = f"{a}{b}{c}{d}"
                        magic = True
print("")
if magic:
    print(f"Password: {magic_num}")
else:
    print("No!")