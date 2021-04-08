count_windows = int(input())
windows_type = input()
delivery = input()

price = 0
if windows_type == "90X130":
    price = count_windows * 110
    if count_windows > 60:
        price -= price * 0.08
    elif count_windows > 30:
        price -= price * 0.05
elif windows_type == "100X150":
    price = count_windows * 140
    if count_windows > 80:
        price -= price * 0.10
    elif count_windows > 40:
        price -= price * 0.06
elif windows_type == "130X180":
    price = count_windows * 190
    if count_windows > 50:
        price -= price * 0.12
    elif count_windows > 20:
        price -= price * 0.07
else:
    price = count_windows * 250
    if count_windows > 50:
        price -= price * 0.14
    elif count_windows > 25:
        price -= price * 0.09

if delivery == "With delivery":
    price += 60

if count_windows > 99:
    price -= price * 0.04

if count_windows < 10:
    print("Invalid order")
else:
    print(f"{price:.2f} BGN")