budget = float(input())
fuel = float(input())
day = input()

fuel_price = fuel * 2.10
guide = 100 + fuel_price

if day == "Saturday":
    guide *= 0.90
else:
    guide *= 0.80

diff = abs(budget - guide)
if budget > guide:
    print(f"Safari time! Money left: {diff:.2f} lv.")
else:
    print(f"Not enough money! Money needed: {diff:.2f} lv.")