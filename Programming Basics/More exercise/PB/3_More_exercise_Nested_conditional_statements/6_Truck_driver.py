season = input()
km_month = float(input())

salary = 0

if km_month <= 5000:
    if season == "Spring" or season == "Autumn":
        salary = km_month * 0.75 * 4
        salary -= salary * 0.10
    elif season == "Summer":
        salary = km_month * 0.90 * 4
        salary -= salary * 0.10
    elif season == "Winter":
        salary = km_month * 1.05 * 4
        salary -= salary * 0.10
elif 5000 < km_month <= 10000:
    if season == "Spring" or season == "Autumn":
        salary = km_month * 0.95 * 4
        salary -= salary * 0.10
    elif season == "Summer":
        salary = km_month * 1.10 * 4
        salary -= salary * 0.10
    elif season == "Winter":
        salary = km_month * 1.25 * 4
        salary -= salary * 0.10
elif 10000 < km_month <= 20000:
    salary = km_month * 1.45 * 4
    salary -= salary * 0.10

print(f"{salary:.2f}")