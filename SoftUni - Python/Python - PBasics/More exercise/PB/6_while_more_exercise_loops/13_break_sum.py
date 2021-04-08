n = int(input())
l = int(input())

start_letter = 97
last_letter = start_letter+l

for num in range(1,n):
    for num_2 in range(1, n):
        for num_3 in range(start_letter, last_letter):
            for num_4 in range(start_letter, last_letter):
                for num_5 in range(1, n):

