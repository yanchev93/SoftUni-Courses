country = input()
instrument = input()

if country == "Russia":
    if instrument == "ribbon":
        points = 9.100 + 9.400
        real_points = 20 - points
        percent = (real_points / 20) * 100
    elif instrument == "hoop":
        points = 9.300 + 9.800
        real_points = 20 - points
        percent = (real_points / 20) * 100
    elif instrument == "rope":
        points = 9.600 + 9.000
        real_points = 20 - points
        percent = (real_points / 20) * 100
elif country == "Bulgaria":
    if instrument == "ribbon":
        points = 9.600 + 9.400
        real_points = 20 - points
        percent = (real_points / 20) * 100
    elif instrument == "hoop":
        points = 9.550 + 9.750
        real_points = 20 - points
        percent = (real_points / 20) * 100
    elif instrument == "rope":
        points = 9.500 + 9.400
        real_points = 20 - points
        percent = (real_points / 20) * 100
elif country == "Italy":
    if instrument == "ribbon":
        points = 9.200 + 9.500
        real_points = 20 - points
        percent = (real_points / 20) * 100
    elif instrument == "hoop":
        points = 9.450 + 9.350
        real_points = 20 - points
        percent = (real_points / 20) * 100
    elif instrument == "rope":
        points = 9.700 + 9.150
        real_points = 20 - points
        percent = (real_points / 20) * 100
print(f"The team of {country} get {points:.3f} on {instrument}.")
print(f"{percent:.2f}%")