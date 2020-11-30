easter_bread = int(input())

winner_points = 0
winner_name = ""
for i in range(1, easter_bread+1):
    name = input()
    command = input()

    total_points = 0
    while command != "Stop":
        points = int(command)
        total_points += points

        command = input()
    else:
        print(f"{name} has {total_points} points.")
    if total_points > winner_points:
        winner_points = total_points
        winner_name = name
        print(f"{name} is the new number 1!")
print(f"{winner_name} won competition with {winner_points} points!")