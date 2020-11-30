product = input()
day = input()
quantity = float(input())
result = 0

if day == "Saturday" or day == "Sunday":
    if product == "banana":
        result = quantity * 2.70
    elif product == "apple":
        result = quantity * 1.25
    elif product == "orange":
        result = quantity * 0.90
    elif product == "grapefruit":
        result = quantity * 1.60
    elif product == "kiwi":
        result = quantity * 3.00
    elif product == "pineapple":
        result = quantity * 5.60
    elif product == "grapes":
        result = quantity * 4.20
else:
    if product == "banana":
        result = quantity * 2.50
    elif product == "apple":
        result = quantity * 1.20
    elif product == "orange":
        result = quantity * 0.85
    elif product == "grapefruit":
        result = quantity * 1.45
    elif product == "kiwi":
        result = quantity * 2.70
    elif product == "pineapple":
        result = quantity * 5.50
    elif product == "grapes":
        result = quantity * 3.85
print(result)