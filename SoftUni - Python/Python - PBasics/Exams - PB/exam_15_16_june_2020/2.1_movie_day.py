from math import ceil

time_filming = int(input())
count_scenes = int(input())
time_scene = int(input())

terrain = time_filming * 0.15
scenes_time = count_scenes * time_scene
time_needed = terrain + scenes_time

diff = abs(time_filming - time_needed)
if time_needed <= time_filming:
    print(f"You managed to finish the movie on time! You have {ceil(diff)} minutes left!")
else:
    print(f"Time is up! To complete the movie you need {ceil(diff)} minutes.")