budget = float(input())
tv_shows = int(input())

tv_shows_total = 0

for i in range (1, tv_shows+1):
    name = input()
    price = float(input())
    if name == "Thrones":
        tv_shows_total += price * 0.50
    elif name == "Lucifer":
        tv_shows_total += price * 0.60
    elif name == "Protector":
        tv_shows_total += price * 0.70
    elif name == "TotalDrama":
        tv_shows_total += price * 0.80
    elif name == "Area":
        tv_shows_total += price * 0.90
    else:
        tv_shows_total += price

diff = abs(budget - tv_shows_total)
if budget >= tv_shows_total:
    print(f"You bought all the series and left with {diff:.2f} lv.")
else:
    print(f"You need {diff:.2f} lv. more to buy the series!")