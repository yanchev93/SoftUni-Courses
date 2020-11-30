n = int(input())

result = 1

for num in range(n, 0, -1):
    result *= num
print(result)