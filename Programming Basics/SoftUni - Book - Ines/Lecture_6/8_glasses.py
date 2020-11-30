n = int(input())

stars = 2 * n
space = 5 * n - 4 * n
slash = 2 * n - 2

print("*"*stars + " "*space + "*"*stars)

is_n_even = n%2 == 0

for rows in range(1, (n-2)+1):
    if rows == n//2 and not is_n_even:
        print("*" + "/" * slash + "*" + "|" * space + "*" + "/" * slash + "*" )
    elif is_n_even and rows == (n//2) - 1:
        print("*" + "/" * slash + "*" + "|" * space + "*" + "/" * slash + "*" )
    else:
        print("*" + "/" * slash + "*" + " " * space + "*" + "/" * slash + "*")

print("*"*stars + " "*space + "*"*stars)
