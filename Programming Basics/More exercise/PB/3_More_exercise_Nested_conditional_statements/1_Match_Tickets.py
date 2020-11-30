budget = float(input())
category = input()
people = int(input())

diff = 0
ticket = 0
normal = 249.99
vip = 499.99

if category == "Normal":
    if 1 <= people <= 4:
        budget -= budget * 0.75
        ticket = people * normal
    elif 5 <= people <= 9:
        budget -= budget * 0.60
        ticket = people * normal
    elif 10 <= people <= 24:
        budget -= budget * 0.50
        ticket = people * normal
    elif 25 <= people <= 49:
        budget -= budget * 0.40
        ticket = people * normal
    else:
        budget -= budget * 0.25
        ticket = people * normal
elif category == "VIP":
    if 1 <= people <= 4:
        budget -= budget * 0.75
        ticket = people * vip
    elif 5 <= people <= 9:
        budget -= budget * 0.60
        ticket = people * vip
    elif 10 <= people <= 24:
        budget -= budget * 0.50
        ticket = people * vip
    elif 25 <= people <= 49:
        budget -= budget * 0.40
        ticket = people * vip
    else:
        budget -= budget * 0.25
        ticket = people * vip

diff = abs(budget - ticket)

if budget >= ticket:
    print(f"Yes! You have {diff:.2f} leva left.")
else:
    print(f"Not enough money! You need {diff:.2f} leva.")