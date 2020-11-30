from math import  ceil
name = input()
seasons_count = int(input())
episodes_count = int(input())
time_regular_episode = float(input())

commercials = time_regular_episode * 0.20
time_regular_episode += commercials
special_episodes = seasons_count * 10
total_minutes = time_regular_episode * episodes_count * seasons_count + special_episodes

print(f"Total time needed to watch the {name} series is {ceil(total_minutes)} minutes.")

