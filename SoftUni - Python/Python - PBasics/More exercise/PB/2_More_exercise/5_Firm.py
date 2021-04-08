import math
hours_needed = int(input())
days = int(input())
workers_extra_hours = int(input())

working_days = days * 0.90
days_working = working_days * 8
workers_extra_hours = workers_extra_hours  * days * 2

all_hours = math.floor(days_working + workers_extra_hours)
result = abs(all_hours - hours_needed)

if all_hours >= hours_needed:
    print(f"Yes!{result} hours left.")
else:
    print(f"Not enough time!{result} hours needed.")