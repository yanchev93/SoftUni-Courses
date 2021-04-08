season = input()
group = input()
students = int(input())
nights = int(input())

price = 0
sport = ""

if season == "Winter":
    if group == "boys" or group == "girls":
        price = students * 9.60 * nights
        if group == "girls":
            sport = "Gymnastics"
        elif group == "boys":
            sport = "Judo"
    else:
        price = students * 10 * nights
        sport = "Ski"
if season == "Spring":
    if group == "boys" or group == "girls":
        price = students * 7.20 * nights
        if group == "girls":
            sport = "Athletics"
        elif group == "boys":
            sport = "Tennis"
    else:
        price = students * 9.50 * nights
        sport = "Cycling"
if season == "Summer":
    if group == "boys" or group == "girls":
        price = students * 15 * nights
        if group == "girls":
            sport = "Volleyball"
        elif group == "boys":
            sport = "Football"
    else:
        price = students * 20 * nights
        sport = "Swimming"
if 10 <= students < 20:
    price -= price * 0.05
elif 20 <= students < 50:
    price -= price * 0.15
elif 50 <= students:
    price -= price * 0.50
print(f"{sport} {price:.2f} lv.")