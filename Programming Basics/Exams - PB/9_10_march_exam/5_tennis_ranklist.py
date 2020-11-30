from math import floor
tournament = int(input())
opening_points = int(input())

points_count = 0
win_count = 0

for games in range(1, tournament+1):
    stage_in_tournament = input()
    if stage_in_tournament == "W":
        win_count += 1
        points_count += 2000
    elif stage_in_tournament == "F":
        points_count += 1200
    else:
        points_count += 720
total_points = points_count + opening_points
print(f"Final points: {total_points}")
average = points_count / tournament
print(f"Average points: {floor(average)}")
percent_won = (win_count / tournament) * 100
print(f"{percent_won:.2f}%")