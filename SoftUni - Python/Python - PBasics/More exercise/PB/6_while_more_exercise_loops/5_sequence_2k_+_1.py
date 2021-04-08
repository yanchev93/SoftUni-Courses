n = int(input())

result = 1

for num in range(0, n):
    print(result)
    result = result * 2 + 1
    if result > n:
        break
