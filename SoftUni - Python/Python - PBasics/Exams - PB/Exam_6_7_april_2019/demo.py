movie_name = input()

seats_count = 0
students = 0
standard = 0
kids = 0

while movie_name != "Finish":
    seats = int(input())
    tickets = input()

    while tickets != "End" or seats == seats_count:
        if tickets == "student":
            students += 1
        elif tickets == "standard":
            standard += 1
        elif tickets == "kid":
            kids += 1
        if tickets == "End" or tickets == "Finish":
            break

        seats_count += 1
        tickets = input()

    percents = (seats_count / seats) * 100
    print(f"{movie_name} - {percents:.2f}% full.")
    if tickets == "End":
        seats_count = 0
    if tickets == "Finish":
        break
    movie_name = input()
total_tickets = students + kids + standard
print(f"Total tickets: {total_tickets}")
students = (students / total_tickets) * 100
standard = (standard / total_tickets) * 100
kids = (kids / total_tickets) * 100
print(f"{students:.2f}% student tickets.")
print(f"{standard:.2f}% standard tickets.")
print(f"{kids:.2f}% kids tickets.")
