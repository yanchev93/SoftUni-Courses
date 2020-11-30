name_player_one = input()
name_player_two = input()

player_one_points = 0
player_two_points = 0

command = input()
while True:
    if command == "End of game":
        print(f"{name_player_one} has {player_one_points} points")
        print(f"{name_player_two} has {player_two_points} points")
        break
    player_one_card = int(command)
    player_two_card = int(input())

    if player_one_card > player_two_card:
        player_one_points += (player_one_card - player_two_card)
    elif player_one_card < player_two_card:
        player_two_points += (player_two_card - player_one_card)
    else:
        print("Number wars!")
        last_card_player_one = int(input())
        last_card_player_two = int(input())
        if last_card_player_one > last_card_player_two:
            print(f"{name_player_one} is winner with {player_one_points} points")
            break
        else:
            print(f"{name_player_two} is winner with {player_two_points} points")
            break

    command = input()