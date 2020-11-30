days = int(input())
hours = int(input())

total = 0
day_count = 0
for day in range(1, days+1):
    day_count += 1
    total_for_the_day = 0
    for hour in range(1, hours+1):
        if day % 2 == 0 and hour % 2 != 0:
            total_for_the_day += 2.50
            total += 2.50
        elif  day % 2 != 0 and hour % 2 == 0:
            total_for_the_day += 1.25
            total += 1.25
        else:
            total_for_the_day += 1
            total += 1
    print(f"Day: {day_count} - {total_for_the_day:.2f} leva")
print(f"Total: {total:.2f} leva")

