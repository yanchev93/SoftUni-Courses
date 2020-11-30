n = int(input())

left_num = 0
right_num = 0

for number in range(0, n*2):
    current_num = int(input())
    if number < n:
        left_num += current_num
    elif number >= n:
        right_num += current_num

if left_num == right_num:
    print(f"Yes, sum = {left_num}")
else:
    diff = abs(left_num - right_num)
    print(f"No, diff = {diff}")