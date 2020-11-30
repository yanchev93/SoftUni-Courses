voucher = int(input())

purchases = input()
tickets = 0
others = 0

while purchases != "End":
    if len(purchases) > 8:
        tickets += 1
        price = ord(purchases[0]) + ord(purchases[1])
        if voucher < price:
            tickets -= 1
            break
    elif len(purchases) <= 8:
        others += 1
        price = ord(purchases[0])
        if voucher < price:
            others -= 1
            break

    voucher -= price
    purchases = input()

if purchases == "End" or voucher >= 0:
    print(f"{tickets}")
    print(f"{others}")