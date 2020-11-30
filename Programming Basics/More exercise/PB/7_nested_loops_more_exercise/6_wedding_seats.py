last_sector = input()
count_rows = int(input())
count_seats_in_odd_rows = int(input())

count_seats_in_even_row = count_seats_in_odd_rows + 2

count = 0
for i in range(65, ord(last_sector)+1):
    for j in range(1, count_rows+1):
        if j % 2 == 0:
            for k in range(97, 96+count_seats_in_even_row+1):
                count += 1
                print(f"{chr(i)}{j}{chr(k)}")
        else:
            for k in range(97, 96+count_seats_in_odd_rows+1):
                count += 1
                print(f"{chr(i)}{j}{chr(k)}")
    count_rows += 1
print(count)