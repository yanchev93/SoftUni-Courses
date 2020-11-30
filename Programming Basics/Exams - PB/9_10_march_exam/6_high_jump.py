wanted_jump = int(input())

start_jump = wanted_jump - 30
actual_jumps = 0
last_jump = 0

line = int(input())
while wanted_jump > start_jump:
    unsuccessful_jumps = 0
    for height in range(1, 4):
        actual_jumps += 1
        height_jump = line
        if height_jump > start_jump:
            start_jump += 5
            break
        else:
            unsuccessful_jumps += 1
            if unsuccessful_jumps == 3:
                break
            line = int(input())
            continue
    if unsuccessful_jumps == 3:
        print(f"Tihomir failed at {start_jump}cm after {actual_jumps} jumps.")
        break
    line = int(input())
else:
    actual_jumps += 1
    print(f"Tihomir succeeded, he jumped over {start_jump}cm after {actual_jumps} jumps.")