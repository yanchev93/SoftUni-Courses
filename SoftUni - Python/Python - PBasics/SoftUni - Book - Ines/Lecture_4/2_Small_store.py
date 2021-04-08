product = input().lower()
town = input().lower()
quantity = float(input())

result = 0

if town == "sofia":
    if product == "coffee":
        result = 0.50 * quantity
    elif product == "water":
        result = 0.80 * quantity
    elif product == "beer":
        result = 1.20 * quantity
    elif product == "sweets":
        result = 1.45 * quantity
    elif product == "peanuts":
        result = 1.60 * quantity

if town == "plovdiv":
    if product == "coffee":
        result = 0.40 * quantity
    elif product == "water":
        result = 0.70 * quantity
    elif product == "beer":
        result = 1.15 * quantity
    elif product == "sweets":
        result = 1.30 * quantity
    elif product == "peanuts":
        result = 1.50 * quantity

if town == "varna":
    if product == "coffee":
        result = 0.45 * quantity
    elif product == "water":
        result = 0.70 * quantity
    elif product == "beer":
        result = 1.10 * quantity
    elif product == "sweets":
        result = 1.35 * quantity
    elif product == "peanuts":
        result = 1.55 * quantity

print(result)