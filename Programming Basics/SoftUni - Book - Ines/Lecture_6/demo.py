n = int(input())
max_number = -9223372036854775807
min_number = 9223372036854775807

for number in range(0, n):
    input_number = int(input())
    if input_number > max_number:
        max_number = input_number
    if input_number < min_number:
        min_number = input_number

print(f"Max number: {max_number}")
print(f"Min number: {min_number}")
