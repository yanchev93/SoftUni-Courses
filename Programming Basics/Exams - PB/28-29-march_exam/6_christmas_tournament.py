days = int(input())

win_total_money = 0
win_total = 0
lose_total = 0
for day in range(1, days+1):

    win = 0
    win_count = 0
    lose_count = 0
    money_wins = 0
    command = input()
    while command != "Finish":
        sport = command
        result = input()

        if result == "win":
            win_total += 1
            win_count += 1
            money_wins = 20
            win += money_wins
        else:
            lose_total += 1
            lose_count += 1
        command = input()
    if win_count > lose_count:
        win_total_money += win + (win * 0.10)
    else:
        win_total_money += win

if win_total > lose_total:
    win_total_money += (win_total_money * 0.20)
    print(f"You won the tournament! Total raised money: {win_total_money:.2f}")
else:
    print(f"You lost the tournament! Total raised money: {win_total_money:.2f}")