seats_count = 0
students =0
standard = 0
kids = 0
tickets_count = 0
movie_name = input()
while True:
    command = input(movie_name)
    if command == "Finish":
        print(f"Total tickets: {tickets_count}")
        print(f"{(students / tickets_count) * 100:.2f}% student tickets.")
        print(f"{(standard / tickets_count) * 100:.2f}% standard tickets.")
        print(f"{(kids / tickets_count) * 100:.2f}% kids tickets.")
        break
    seats = int(input())
    while seats != seats_count:
        tickets = input()
        if tickets == "End":
            break
        seats_count += 1
        tickets_count += 1
        if tickets == "student":
            students += 1
        elif tickets == "standard":
            standard += 1
        else:
            kids += 1
        hall = (seats_count / seats) * 100
    print(f"{movie_name} - {hall:.2f}% full.")
    movie_name = input()