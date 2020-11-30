period = int(input())

doctors = 7
treated_patients = 0
untreated_patients = 0

for period_in_time in range(1, period+1):
    current_patients = int(input())
    if period_in_time % 3 == 0 and untreated_patients > treated_patients:
        doctors += 1
    if doctors >= current_patients:
        treated_patients += current_patients
    elif doctors < current_patients:
        treated_patients += doctors
        untreated_patients += current_patients - doctors

print(f"Treated patients: {treated_patients}.")
print(f"Untreated patients: {untreated_patients}.")