a = int(input())
b = int(input())
c = int(input())

for i in range(2, a+1, 2):
    for j in range(1, b+1):
        for k in range(2, c+1, 2):
            if j == 2 or j == 3 or j == 5 or j == 7:
                print(f"{i} {j} {k}")