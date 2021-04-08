N = int(input())

one_two = 0
three_four = 0
for i in range(1, 10):
    for j in range(1, 10):
        for k in range(1, 10):
            for l in range(1, 10):
                one_two = i + j
                three_four = k + l
                if i+j == k+l and N % one_two == 0:
                    print(f"{i}{j}{k}{l}", end=" ")
