one = int(input())
two = int(input())
last_one = int(input())
last_two = int(input())

number_one = one + last_one
number_two = two + last_two

is_prime = False
for i in range(one, number_one+1):
    for j in range(two, number_two+1):
        if one % i == 0 and two % j == 0:
            break
        else:
            print(f"{i}{j}")