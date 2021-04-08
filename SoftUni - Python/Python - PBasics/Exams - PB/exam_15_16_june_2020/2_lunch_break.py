from math import ceil
name_tv_show = input()
time_episode = int(input())
time_break = int(input())

time_lunch = time_break * 1/8
time_relax = time_break * 1/4
time_left = time_break - (time_lunch + time_relax)

diff = abs(time_left - time_episode)
if time_left >= time_episode:
    print(f"You have enough time to watch {name_tv_show} and left with {ceil(diff)} minutes free time.")
else:
    print(f"You don't have enough time to watch {name_tv_show}, you need {ceil(diff)} more minutes.")
