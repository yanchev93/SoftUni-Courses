yearly_tax = int(input())

basketball_kicks = yearly_tax * 0.60
basketball_suit = basketball_kicks * 0.80
basketball_ball = basketball_suit / 1/4
basketball_accessories = basketball_ball / 1/5

total = yearly_tax + basketball_kicks + basketball_suit + basketball_ball + basketball_accessories


print(f"{total:.2f}")