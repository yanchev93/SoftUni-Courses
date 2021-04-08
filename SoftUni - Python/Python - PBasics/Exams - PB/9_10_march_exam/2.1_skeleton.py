min_kontrola = int(input())
sec_kontrola = int(input())
lenght_meters = float(input())
sec_per_100_meters = int(input())

min_to_sec_kontrola = min_kontrola * 60 + sec_kontrola
difference = lenght_meters / 120
total_difference = difference * 2.5
total_time = (lenght_meters/100) * sec_per_100_meters - total_difference

if min_to_sec_kontrola >= total_time:
    print("Marin Bangiev won an Olympic quota!")
    print(f"His time is {total_time:.3f}.")
else:
    diff = abs(total_time - min_to_sec_kontrola)
    print(f"No, Marin failed! He was {diff:.3f} second slower.")