bottles_detergent = int(input())

ml = bottles_detergent * 750
fill = 0
dishes_cleaned = 0
pots_cleaned = 0

command = input()
while command != "End":
    fill += 1
    command = int(command)
    if fill % 3 == 0:
        ml -= command * 15
        pots_cleaned += command
    else:
        ml -= command * 5
        dishes_cleaned += command
    if ml < 0:
        print(f"Not enough detergent, {abs(ml)} ml. more necessary!")
        break
    command = input()
if ml >= 0:
    print("Detergent was enough!")
    print(f"{dishes_cleaned} dishes and {pots_cleaned} pots were washed.")
    print(f"Leftover detergent {ml} ml.")