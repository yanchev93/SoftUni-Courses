fruit = input()
sets = input()
count_sets = int(input())

price = 0
if sets == "small":
    if fruit == "Watermelon":
        total = 2 * 56
        price = count_sets * total
    elif fruit == "Mango":
        total = 2 * 36.66
        price = count_sets * total
    elif fruit == "Pineapple":
        total = 2 * 42.10
        price = count_sets * total
    else:
        total = 2 * 20
        price = count_sets * total
else:
    if fruit == "Watermelon":
        total = 5 * 28.70
        price = count_sets * total
    elif fruit == "Mango":
        total = 5 * 19.60
        price = count_sets * total
    elif fruit == "Pineapple":
        total = 5 * 24.80
        price = count_sets * total
    else:
        total = 5 * 15.20
        price = count_sets * total

if 400 <= price <= 1000:
    price *= 0.85
elif 1000 < price:
    price *= 0.50
print(f"{price:.2f} lv.")