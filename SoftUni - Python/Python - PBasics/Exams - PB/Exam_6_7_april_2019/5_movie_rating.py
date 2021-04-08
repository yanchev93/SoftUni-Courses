movies = int(input())
count = 0

highest_rating = 0
name_highest = ""
lowest_rating = 10
name_lowest = ""
count_ratings = 0

while count != movies:
    name_movie = input()
    rating = float(input())
    count += 1
    count_ratings += rating
    if rating > highest_rating:
        name_highest = name_movie
        highest_rating = rating
    if rating < lowest_rating:
        name_lowest = name_movie
        lowest_rating = rating

average_rating = count_ratings / movies
print(f"{name_highest} is with highest rating: {highest_rating}")
print(f"{name_lowest} is with lowest rating: {lowest_rating}")
print(f"Average rating: {average_rating:.1f}")