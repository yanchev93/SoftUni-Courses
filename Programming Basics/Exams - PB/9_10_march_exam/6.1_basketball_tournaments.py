command = input()

win = 0
lost = 0
games_count = 0

while command != "End of tournaments":
    name = command
    matches = int(input())

    games_count += matches
    desi_team = 0
    opposite_team = 0
    game = 0

    for i in range(1, matches+1):
        desi_team = int(input())
        opposite_team = int(input())
        game += 1
        if desi_team > opposite_team:
            win += 1
            print(f"Game {game} of tournament {name}: win with {desi_team - opposite_team} points.")
        else:
            lost += 1
            print(f"Game {game} of tournament {name}: lost with {opposite_team - desi_team} points.")
    command = input()
else:
    win = win / games_count * 100
    print(f"{win:.2f}% matches win")
    lost = lost / games_count * 100
    print(f"{lost:.2f}% matches lost")