from math import ceil
guests = int(input())
budget = int(input())

easter_bread_needed = guests / 3
eggs_needed = guests * 2

price_easter_bread = ceil(easter_bread_needed) * 4
price_eggs_needed = eggs_needed * 0.45
total = price_eggs_needed + price_easter_bread
diff = abs(budget - total)
if budget >= total:
    print(f"Lyubo bought {ceil(easter_bread_needed)} Easter bread and {eggs_needed} eggs.")
    print(f"He has {diff:.2f} lv. left.")
else:
    print("Lyubo doesn't have enough money.")
    print(f"He needs {diff:.2f} lv. more.")