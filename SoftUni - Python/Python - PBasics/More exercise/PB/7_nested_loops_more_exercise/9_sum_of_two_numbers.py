start = int(input())
final = int(input())
magic_num = int(input())

count = 0
magic_stick = 0
for i in range(start, final+1):
    for j in range(start, final+1):
        count += 1
        magic_stick = i+j
        if magic_stick == magic_num:
            break
    if magic_stick == magic_num:
        break
if magic_stick == magic_num:
    print(f"Combination N:{count} ({i} + {j} = {magic_num})")
else:
    print(f"{count} combinations - neither equals {magic_num}")