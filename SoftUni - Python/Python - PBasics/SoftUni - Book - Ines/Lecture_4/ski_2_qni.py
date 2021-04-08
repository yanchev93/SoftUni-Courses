days_vacation = int(input())
room = input()
rating = input()

room_for_one_person = 18.00
apartment = 25.00
president_apartment = 35.00


price = 0
result = 0

if room == "room for one person":
    price = (days_vacation-1) * room_for_one_person
elif room == "apartment":
    price = (days_vacation-1) * apartment
    if days_vacation < 10:
        price = price - (price * 0.30)
    elif 10 <= days_vacation <= 15:
        price = price - (price * 0.35)
    elif days_vacation > 15:
        price = price - (price * 0.50)
elif room == "president apartment":
    price = (days_vacation - 1) * president_apartment
    if days_vacation < 10:
        price -= (price * 0.10)
    elif 10 <= days_vacation <= 15:
        price = price - (price * 0.15)
    elif days_vacation > 15:
        price = price - (price * 0.20)

if rating == "positive":
    result = price + (price * 0.25)
elif rating == "negative":
    result = price - (price * 0.10)
print("{0:.2f}".format(result))