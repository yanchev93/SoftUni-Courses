film_name = input()

count = 0
favorite = 0
favorite_name = ""

while film_name != "STOP":
    count += 1
    points_movie = 0

    for char in film_name:
        value = ord(char)
        if "a" <= char <= "z":
            points = value - (2 * len(film_name))
            points_movie += points
        elif "A" <= char <= "Z":
            points = value - len(film_name)
            points_movie += points
        else:
            points = value
            points_movie += points
        if points_movie > favorite:
            favorite = points_movie
            favorite_name = film_name

    if count >= 7:
        print(f"The limit is reached.")
        break

    film_name = input()
print(f"The best movie for you is {favorite_name} with {favorite} ASCII sum.")