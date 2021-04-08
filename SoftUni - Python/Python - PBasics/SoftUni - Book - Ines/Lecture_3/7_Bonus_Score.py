number = float(input())

bonus_score = 0.0

if number <= 100:
    bonus_score = 5
elif number > 100 and number < 1000:
    bonus_score = number * 0.2
else:
    bonus_score = number * 0.1

if number % 2 == 0:
    bonus_score = bonus_score + 1

if number % 10 == 5:
    bonus_score = bonus_score + 2

print(bonus_score)
print(number + bonus_score)