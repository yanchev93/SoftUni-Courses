days = int(input())
hours = int(input())

days_count = 0
total = 0
for i in range(1, days+1):
    days_count += 1
    odd_day_price = 0
    even_day_price = 0
    hours_count = 0
    for j in range(1, hours+1):
        hours_count += 1
        if days_count % 2 != 0:
            if hours_count % 2 != 0:
                odd_day_price += 1
            else:
                odd_day_price += 1.25
        else:
            if hours_count % 2 != 0:
                even_day_price += 2.50
            else:
                even_day_price += 1
    if days_count % 2 != 0:
        print(f"Day: {days_count} - {odd_day_price:.2f} leva")
    else:
        print(f"Day: {days_count} - {even_day_price:.2f} leva")
    total += odd_day_price + even_day_price
print(f"Total: {total:.2f} leva")