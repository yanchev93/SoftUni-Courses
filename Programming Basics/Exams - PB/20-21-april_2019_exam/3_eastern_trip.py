destination = input()
dates = input()
nights = int(input())

price = 0

if destination == "France":
    if dates == "21-23":
        price += 30
    elif dates == "24-27":
        price += 35
    else:
        price += 40
elif destination == "Italy":
    if dates == "21-23":
        price += 28
    elif dates == "24-27":
        price += 32
    else:
        price += 39
else:
    if dates == "21-23":
        price += 32
    elif dates == "24-27":
        price += 37
    else:
        price += 43

total = price * nights
print(f"Easter trip to {destination} : {total:.2f} leva.")