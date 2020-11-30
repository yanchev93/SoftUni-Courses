high = int(input())

start = high - 30
total_jumps = 0
unsucc_jump = 0

while True:
    jump = int(input())
    total_jumps += 1

    if jump > start:
        start += 5
        unsucc_jump = 0
    else:
        unsucc_jump += 1

    if start > high:
        print(f"Tihomir succeeded, he jumped over {start-5}cm after {total_jumps} jumps.")
        break
    if unsucc_jump == 3:
        print(f"Tihomir failed at {start}cm after {total_jumps} jumps.")
        break
