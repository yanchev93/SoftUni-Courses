import math
n = int(input())

is_prime = True

if n < 2 and n < 1 and n< 0:
    print("Not Prime")
else:
    end_i = int(math.sqrt(n))
    for numbers in range(2, end_i+1):
        if n / numbers == n // numbers:
            is_prime = False
    print(is_prime)

    if is_prime:
        print("Prime")
    else:
        print("Not Prime")