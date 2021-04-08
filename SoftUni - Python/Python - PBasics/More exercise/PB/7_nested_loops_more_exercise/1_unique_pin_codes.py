first_number = int(input())
second_number = int(input())
third_number = int(input())


for one in range(2, first_number+1, 2):
    for two in range(2, second_number+1):
        for three in range(2, third_number+1,2 ):
            if two == 2 or two == 3 or two == 5 or two == 7:
                print(f"{one} {two} {three}")
