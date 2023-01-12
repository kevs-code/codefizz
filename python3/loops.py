dog_breeds = ['french_bulldog', 'dalmatian', 'shihtzu', 'poodle', 'collie']
for breed in dog_breeds:
    print(breed)


board_games = ['Settlers of Catan', 'Carcassone', 'Power Grid', 'Agricola', 'Scrabble']

sport_games = ['football', 'football - American', 'hockey', 'baseball', 'cricket']

for game in board_games:
  print(game)

for game in sport_games:
  print(game)

promise = "I will not chew gum in class"
for i in range(5):
  print(promise)

#
students_period_A = ["Alex", "Briana", "Cheri", "Daniele"]
students_period_B = ["Dora", "Minerva", "Alexa", "Obie"]

for i in students_period_A:
  students_period_B.append(i)
  print(i)
# infinite loop error
for i in students_period_A:
  students_period_A.append(i)
  print(i)

# search and break

dog_breeds_available_for_adoption = ['french_bulldog', 'dalmatian', 'shihtzu', 'poodle', 'collie']
dog_breed_I_want = 'dalmatian'
for dog in dog_breeds_available_for_adoption:
  print(dog)
  if dog == dog_breed_I_want:
    print("They have the dog I want!")
    break

# continue == skip lines

ages = [12, 38, 34, 26, 21, 19, 67, 41, 17]
for i in ages:
  if i < 21:
    continue
  print(i)

all_students = ["Alex", "Briana", "Cheri", "Daniele", "Dora", "Minerva", "Alexa", "Obie", "Arius", "Loki"]
students_in_poetry = []
while len(students_in_poetry) < 6:
  next_one = all_students.pop()
  students_in_poetry.append(next_one)
print(students_in_poetry)

sales_data = [[12, 17, 22], [2, 10, 3], [5, 12, 13]]
scoops_sold = 0
for i in sales_data:
  for j in i:
    scoops_sold += j
print(scoops_sold)

#96

words = ["@coolguy35", "#nofilter", "@kewldawg54", "reply", "timestamp", "@matchamom", "follow", "#updog"]
usernames = []

for word in words:
  if word[0] == '@':
    usernames.append(word)

# oneliner

heights = [161, 164, 156, 144, 158, 170, 163, 163, 157]


can_ride_coaster = [height for height in heights if height > 161]
print(can_ride_coaster)
# is same as one liner above
#can_ride_coaster = []
#for height in heights:
#  if height > 161:
#    can_ride_coaster.append(height)

# oneliner2
# usernames = ["@coolguy35", "@kewldawg54", "@matchamom"]
# messages = [user + " please follow me!" for user in usernames]
# print(messages)
# ["@coolguy35 please follow me!", "@kewldawg54 please follow me!", "@matchamom please follow me!"


celsius = [0, 10, 15, 32, -5, 27, 3]
fahrenheit = [temperature * 9/5 + 32 for temperature in celsius]
print(fahrenheit)

# review

single_digits = list(range(10))
squares = []
for i in single_digits:
  print(i)
  squares.append(i**2)
print(squares)
cubes = [i ** 3 for i in single_digits]
print(cubes)

#carly's clippers

hairstyles = ["bouffant", "pixie", "dreadlocks", "crew", "bowl", "bob", "mohawk", "flattop"]

prices = [30, 25, 40, 20, 20, 35, 50, 35]

last_week = [2, 3, 5, 8, 4, 4, 6, 2]

total_price = 0

for price in prices:
  total_price += price

average_price = total_price/len(prices)
print('Average Haircut Price: $%.2f' % average_price)

new_prices = [price - 5 for price in prices]
print(new_prices)

total_revenue = 0

for i in range(len(hairstyles)):
  total_revenue += prices[i] * last_week[i]

print('Total Revenue: $%.2f' % total_revenue)
average_daily_revenue = total_revenue / 7
print('Average Daily Revenue: $%.2f' % average_daily_revenue)

cuts_under_30 = [hairstyles[i] for i in range(len(new_prices)) if new_prices[i] < 30]
print(cuts_under_30)
