n = int(input())

is_n_even = n % 2 == 0
range = 0
stars = 1

if is_n_even:
    range = n // 2
    stars = 2
else:
    range = n // 2 + 1

for row in range(0, range):
