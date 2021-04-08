n = int(input())
space = " "
star = "*"
s_p_s = n-1

for row in range(1, 2*n):
    if row <= n:
        space = n - row
        star = row
        print(" " * space + "* " * star)
    else:
        space = row - n
        star = row - space
        print(" " * space + "* " * s_p_s)
        s_p_s -= 1