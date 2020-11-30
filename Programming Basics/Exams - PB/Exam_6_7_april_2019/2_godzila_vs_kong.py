budget = float(input())
people = int(input())
cloths = float(input())

decor = budget * 0.10
cloths_for_people = people * cloths

if people > 150:
    cloths_for_people -= cloths_for_people * 0.10

total_needed = cloths_for_people + decor
diff = abs(budget - total_needed)
if budget >= total_needed:
    print(f"Action!")
    print(f"Wingard starts filming with {diff:.2f} leva left.")
else:
    print(f"Not enough money!")
    print(f"Wingard needs {diff:.2f} leva more.")
