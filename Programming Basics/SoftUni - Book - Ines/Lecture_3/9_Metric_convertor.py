size = float(input())
source_metric = input().lower()
dest_metric = input().lower()


if source_metric == "mm":
    size = size / 1000
elif source_metric == "cm":
    size = size / 100
elif source_metric == "mi":
    size = size / 0.000621371192
elif source_metric == "in":
    size = size / 39.3700787
elif source_metric == "km":
    size = size / 0.001
elif source_metric == "ft":
    size = size / 3.2808399
elif source_metric == "yd":
    size = size / 1.0936133

if dest_metric == "mm":
    size = size * 1000
elif dest_metric == "cm":
    size = size * 100
elif dest_metric == "mi":
    size = size * 0.000621371192
elif dest_metric == "in":
    size = size * 39.3700787
elif dest_metric == "km":
    size = size * 0.001
elif dest_metric == "ft":
    size = size * 3.2808399
elif dest_metric == "yd":
    size = size * 1.0936133

print(f"{size} {dest_metric}")
