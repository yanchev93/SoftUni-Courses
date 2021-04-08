days = int(input())
rooms = input()
rating = input()

price = 0

rf1p = 18
ap = 25
pa = 35

if days > 15:
    if rooms == "room for one person":
        price = (days - 1) * rf1p
    elif rooms == "apartment":
        price = (days - 1) * ap
    elif rooms == "president apartment":
        price = (days - 1) * pa
elif days >= 10:
    if rooms == "room for one person":
        price = (days - 1) * rf1p
    elif rooms == "apartment":
        price = (days - 1) * ap
    elif rooms == "president apartment":
        price = (days - 1) * pa
elif days < 10:
    if rooms == "room for one person":
        price = (days - 1) * rf1p
    elif rooms == "apartment":
        price = (days - 1) * ap
    elif rooms == "president apartment":
        price = (days - 1) * pa

if rating