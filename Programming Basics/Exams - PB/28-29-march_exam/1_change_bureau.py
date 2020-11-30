count_bitcoin = int(input())
count_china_money = float(input())
commission = float(input())/100

bitcoin = count_bitcoin * 1168
china_money = count_china_money * 0.15
china_dollars_to_lv = china_money * 1.76
total = (bitcoin + china_dollars_to_lv) / 1.95
commission_price = total * commission
left_after_commission = total - commission_price
print(f"{left_after_commission:.2f}")