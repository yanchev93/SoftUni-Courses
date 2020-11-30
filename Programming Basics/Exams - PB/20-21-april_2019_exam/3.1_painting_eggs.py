size_eggs = input()
color_eggs = input()
number = int(input())


if color_eggs == "Red":
    if size_eggs == "Large":
        price = 16 * number
    elif size_eggs == "Medium":
        price = 13 * number
    else:
        price = 9 * number
elif color_eggs == "Green":
    if size_eggs == "Large":
        price = 12 * number
    elif size_eggs == "Medium":
        price = 9 * number
    else:
        price = 8 * number
else:
    if size_eggs == "Large":
        price = 9 * number
    elif size_eggs == "Medium":
        price = 7 * number
    else:
        price = 5 * number

price *= 0.65
print(f"{price:.2f} leva.")