name_movie = input()
count_days = int(input())
count_tickets = int(input())
tickets_price = float(input())
percent_for_cinema = int(input())

price_tickets_per_day = tickets_price * count_tickets
full_period_income = count_days * price_tickets_per_day
cinema_percent = full_period_income * percent_for_cinema / 100
income_from_movie = full_period_income - cinema_percent
print(f"The profit from the movie {name_movie} is {income_from_movie:.2f} lv.")