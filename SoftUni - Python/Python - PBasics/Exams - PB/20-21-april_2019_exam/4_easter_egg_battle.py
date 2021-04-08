one_player_eggs = int(input())
two_player_eggs = int(input())

command = input()

while command != "End of battle":


    if command == "one":
        two_player_eggs -= 1
    else:
        one_player_eggs -= 1

    if one_player_eggs == 0:
        print(f"Player one is out of eggs. Player two has {two_player_eggs} eggs left.")
        break
    if two_player_eggs == 0:
        print(f"Player two is out of eggs. Player one has {one_player_eggs} eggs left.")
        break
    command = input()
else:
    print(f"Player one has {one_player_eggs} eggs left.")
    print(f"Player two has {two_player_eggs} eggs left.")