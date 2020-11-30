movies_count = 0
winner_points = 0

command = input()

while command != "STOP":
    name = input(command)
    movies_count += 1

    if movies_count == 7:
        print(f"The limit is reached.")
        print(f"The best movie for you is {name} with {winner_points} ASCII sum.")
        break

    movie_points = 0
    point = 0

    for char in name:
        ascii_value = ord(char)
        if 'a' <= char <= 'z':
            points = ascii_value - (2 * len(command))
            movie_points += points
        elif 'A' <= char <= 'Z':
            points = ascii_value - len(command)
            movie_points += points
        else:
            points = ascii_value
            movie_points += ascii_value

    if movie_points > 0:
        winner_movie = command
        winner_points = movie_points

    command = input()

if command == "STOP":
    print(f"The best movie for you is {name} with {winner_points} ASCII sum.")