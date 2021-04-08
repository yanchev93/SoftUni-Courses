days_vacation = int(input())
room = input()
rating = input()

room_for_one_person = 18.00
apartment = 25.00
president_apartment = 35.00

price = 0
discount_nights = 0
discount = 0

if room == "room for one person":
    price = (days_vacation-1) * room_for_one_person
    if days_vacation < 10:
        if rating == "positive":
            discount = price + (price * 0.25)
        elif rating == "negative":
            discount = price - (price * 0.10)
    elif 10 <= days_vacation <= 15:
        if rating == "positive":
            discount = price + (price * 0.25)
        elif rating == "negative":
            discount = price - (price * 0.10)
    elif days_vacation > 15:
        if rating == "positive":
            discount = price + (price * 0.25)
        elif rating == "negative":
            discount = price - (price * 0.10)
elif room == "apartment":
    price = (days_vacation-1) * apartment
    if days_vacation < 10:
        discount_nights = price - (price * 0.30)
        if rating == "positive":
            discount = discount_nights + (discount_nights * 0.25)
        elif rating == "negative":
            discount = discount_nights - (price * 0.10)
    elif 10 <= days_vacation <= 15:
        discount_nights = price - (price * 0.35)
        if rating == "positive":
            discount = discount_nights + (discount_nights * 0.25)
        elif rating == "negative":
            discount = discount_nights - (price * 0.10)
    elif days_vacation > 15:
        discount_nights = price - (price * 0.50)
        if rating == "positive":
            discount = discount_nights + (discount_nights * 0.25)
        elif rating == "negative":
            discount = discount_nights - (price * 0.10)
elif room == "president apartment":
    price = (days_vacation - 1) * president_apartment
    if days_vacation < 10:
        discount_nights = price - (price * 0.10)
        if rating == "positive":
            discount = discount_nights + (discount_nights * 0.25)
        elif rating == "negative":
            discount = discount_nights - (price * 0.10)
    elif 10 <= days_vacation <= 15:
        discount_nights = price - (price * 0.15)
        if rating == "positive":
            discount = discount_nights + (discount_nights * 0.25)
        elif rating == "negative":
            discount = discount_nights - (price * 0.10)
    elif days_vacation > 15:
        discount_nights = price - (price * 0.20)
        if rating == "positive":
            discount = discount_nights + (discount_nights * 0.25)
        elif rating == "negative":
            discount = discount_nights - (price * 0.10)

print("{0:.2f}".format(discount))

