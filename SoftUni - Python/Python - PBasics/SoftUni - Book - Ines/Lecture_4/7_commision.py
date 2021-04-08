town = input()
sales = float(input())

result = 0

if town == "Sofia":
    if sales >= 0 and sales <= 500:
        result = sales * 0.05
    elif sales > 500 and sales <= 1000:
        result = sales * 0.07
    elif sales > 1000 and sales <= 10000:
        result = sales * 0.08
    elif sales > 10000:
        result = sales * 0.12

elif town == "Plovdiv":
    if sales >= 0 and sales <= 500:
        result = sales * 0.055
    elif sales > 500 and sales <= 1000:
        result = sales * 0.08
    elif sales > 1000 and sales <= 10000:
        result = sales * 0.12
    elif sales > 10000:
        result = sales * 0.145

elif town == "Varna":
    if sales >= 0 and sales <= 500:
        result = sales * 0.045
    elif sales > 500 and sales <= 1000:
        result = sales * 0.075
    elif sales > 1000 and sales <= 10000:
        result = sales * 0.10
    elif sales > 10000:
        result = sales * 0.13

else:
   result = "error"

if type(result) == str or sales < 0:
    print("error")
else:
    print("{0:.2f}".format(result))