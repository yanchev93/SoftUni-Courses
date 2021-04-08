budget = float(input())
destination = input()
season = input()
days = int(input())

money_needed = 0

if season == "Winter":
    if destination == "Dubai":
        money_needed = days * 45000
        money_needed -= (money_needed * 0.30)
    elif destination == "Sofia":
        money_needed = days * 17000
        money_needed += (money_needed * 0.25)
    elif destination == "London":
        money_needed = days * 24000
elif season == "Summer":
    if destination == "Dubai":
        money_needed = days * 40000
        money_needed -= (money_needed * 0.30)
    elif destination == "Sofia":
        money_needed = days * 12500
        money_needed += (money_needed * 0.25)
    elif destination == "London":
        money_needed = days * 20250

diff = abs(budget - money_needed)
if budget >= money_needed:
    print(f"The budget for the movie is enough! We have {diff:.2f} leva left!")
else:
    print(f"The director needs {diff:.2f} leva more!")