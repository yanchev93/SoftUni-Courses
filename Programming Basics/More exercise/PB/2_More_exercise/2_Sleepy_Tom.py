import math
days_off = int(input())

sleep = 30000
days_off_play = days_off * 127
play_time_days = (365 - days_off) * 63
time_to_play = days_off_play + play_time_days

hours = math.floor(abs(sleep - time_to_play) / 60)
minutes = abs(sleep - time_to_play) % 60

if time_to_play >= sleep:
    print("Tom will run away")
    print(f"{hours} hours and {minutes} minutes more for play")
else:
    print("Tom sleeps well")
    print(f"{hours} hours and {minutes} minutes less for play")
