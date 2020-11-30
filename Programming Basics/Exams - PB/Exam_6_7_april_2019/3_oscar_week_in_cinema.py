name_movie = input()
hall = input()
tickets = int(input())


if hall == "normal":
    if name_movie == "A Star Is Born":
        price = 7.50 * tickets
    elif name_movie == "Bohemian Rhapsody":
        price = 7.35 * tickets
    elif name_movie == "Green Book":
        price = 8.15 * tickets
    elif name_movie == "The Favourite":
        price = 8.75 * tickets
elif hall == "luxury":
    if name_movie == "A Star Is Born":
        price = 10.50 * tickets
    elif name_movie == "Bohemian Rhapsody":
        price = 9.45 * tickets
    elif name_movie == "Green Book":
        price = 10.25 * tickets
    elif name_movie == "The Favourite":
        price = 11.55 * tickets
elif hall == "ultra luxury":
    if name_movie == "A Star Is Born":
        price = 13.50 * tickets
    elif name_movie == "Bohemian Rhapsody":
        price = 12.75 * tickets
    elif name_movie == "Green Book":
        price = 13.25 * tickets
    elif name_movie == "The Favourite":
        price = 13.95 * tickets
print(f"{name_movie} -> {price:.2f} lv.")
