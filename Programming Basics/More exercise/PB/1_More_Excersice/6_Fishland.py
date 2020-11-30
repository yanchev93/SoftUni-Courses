skumriq_kg = float(input())
caca_kg = float(input())
palaumd_kg = float(input())
safrid_kg = float(input())
midi_kg = float(input())

price_palamud = skumriq_kg + skumriq_kg * 0.60
result_palamud = palaumd_kg * price_palamud
price_safrid = caca_kg + caca_kg * 0.80
result_safrid = price_safrid * safrid_kg
result_midi = midi_kg * 7.50

result = result_palamud + result_safrid + result_midi
print(f"{result:.2f}")