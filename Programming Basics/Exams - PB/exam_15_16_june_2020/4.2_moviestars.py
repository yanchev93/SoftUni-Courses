budget_actors = float(input())

budget_left =0

command = input()
while command != "ACTION":
    command = len(command)
    if command <= 15:
        income = float(input())
        budget_actors -= income
        budget_left += income
    else:
        budget_actors -= budget_actors * 0.20
        budget_left = budget_actors
    if budget_actors < 0:
        diff = abs(budget_actors)
        print(f"We need {diff:.2f} leva for our actors.")
        break

    command = input()
if command == "ACTION":
    print(f"We are left with {budget_actors:.2f} leva.")
