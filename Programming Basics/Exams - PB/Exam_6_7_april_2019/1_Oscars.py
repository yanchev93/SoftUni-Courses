rent_room = int(input())

statues = rent_room * 0.70
catering = statues * 0.85
sound = catering / 2

total = rent_room + statues + catering + sound
print(f"{total:.2f}")
