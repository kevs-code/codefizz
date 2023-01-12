sensors =  {"living room": 21, "kitchen": 23, "bedroom": 20, "pantry": 22}
num_cameras = {"backyard": 6, "garage": 2, "driveway": 1}

print(sensors)

#like objects basically

person = {"name": "Shuri", "age": 18, "siblings": ["T'Chaka", "Ramonda"]}

# sindarin Tolkien Gateway
translations = {"mountain": "orod", "bread": "bass", "friend": "mellon", "horse": "roch"}

#children = {["Johannes", "Rosmarie", "Eleonore"]: "von Trapp", ["Sonny", "Fredo", "Michael"]: "Corleone"}

#keys can't be varied dataTypes so should be
children = {"von Trapp": ["Johannes", "Rosmarie", "Eleonore"], "Corleone": ["Sonny", "Fredo", "Michael"]}

my_empty_dictionary ={}
#so ...
animals_in_zoo = {}

animals_in_zoo["zebras"] = 8
animals_in_zoo["monkeys"] = 12
animals_in_zoo["dinosaurs"] = 0

print(animals_in_zoo)
# {'zebras': 8, 'monkeys': 12, 'dinosaurs': 0}

user_ids = {"teraCoder": 9018293, "proProgrammer": 119238}
user_ids.update({"theLooper": 138475, "stringQueen": 85739})
print(user_ids)
# {'teraCoder': 9018293, 'proProgrammer': 119238, 'theLooper': 138475, 'stringQueen': 85739}

oscar_winners = {"Best Picture": "La La Land", "Best Actor": "Casey Affleck", "Best Actress": "Emma Stone", "Animated Feature": "Zootopia"}
oscar_winners["Supporting Actress"] = "Viola Davis"
#can change existing this way ...
oscar_winners["Best Picture"] = "Moonlight"


# list comprehension to create dictionary
# names = ['Jenny', 'Alexus', 'Sam', 'Grace']
# heights = [61, 70, 67, 64]
# students = {key:value for key, value in zip(names, heights)}

drinks = ["espresso", "chai", "decaf", "drip"]
caffeine = [64, 40, 0, 120]
zipped_drinks = zip(drinks, caffeine)
drinks_to_caffeine = {key:value for key, value in zipped_drinks}
print(drinks_to_caffeine)

# review

songs = ["Like a Rolling Stone", "Satisfaction", "Imagine", "What's Going On", "Respect", "Good Vibrations"]
playcounts = [78, 29, 44, 21, 89, 5]

plays = {key:value for key, value in zip(songs, playcounts)}

plays['Purple Haze'] = 1
plays['Respect'] += 5 
print(plays)

library = {"The Best Songs": plays, "Sunday Feelings": {}}
print(library)


# part2

zodiac_elements = {"water": ["Cancer", "Scorpio", "Pisces"], "fire": ["Aries", "Leo", "Sagittarius"], "earth": ["Taurus", "Virgo", "Capricorn"], "air":["Gemini", "Libra", "Aquarius"]}
print(zodiac_elements["earth"])
print(zodiac_elements["fire"])

zodiac_elements = {"water": ["Cancer", "Scorpio", "Pisces"], "fire": ["Aries", "Leo", "Sagittarius"], "earth": ["Taurus", "Virgo", "Capricorn"], "air":["Gemini", "Libra", "Aquarius"]}

zodiac_elements["energy"] = "Not a Zodiac element"
print(zodiac_elements["energy"])

building_heights = {"Burj Khalifa": 828, "Shanghai Tower": 632, "Abraj Al Bait": 601, "Ping An": 599, "Lotte World Tower": 554.5, "One World Trade": 541.3}

key_to_check = "Landmark 81"

if key_to_check in building_heights:
  print(building_heights["Landmark 81"])


key_to_check = "Landmark 81"
try:
  print(building_heights[key_to_check])
except KeyError:
  print("That key doesn't exist!")



caffeine_level = {"espresso": 64, "chai": 40, "decaf": 0, "drip": 120}

caffeine_level["matcha"] = 30

try:
  print(caffeine_level["matcha"])
except KeyError:
  print("Unknown Caffeine Level")

#safe get with a default value if doesn't exist
user_ids = {"teraCoder": 100019, "pythonGuy": 182921, "samTheJavaMaam": 123112, "lyleLoop": 102931, "keysmithKeith": 129384}

tc_id = user_ids.get('teraCoder', 100000)
print(tc_id)
stack_id = user_ids.get('superStackSmash', 100000)
print(stack_id)
print(user_ids)
100019
100000
{'teraCoder': 100019, 'pythonGuy': 182921, 'samTheJavaMaam': 123112, 'lyleLoop': 102931, 'keysmithKeith': 129384}

# use case for get or pop e.g.,  return default value or value from list if present and in case of pop remove key value pair from list

available_items = {"health potion": 10, "cake of the cure": 5, "green elixir": 20, "strength sandwich": 25, "stamina grains": 15, "power stew": 30}
health_points = 20

health_points += available_items.pop("stamina grains", 0)
health_points += available_items.pop("power stew", 0)
health_points += available_items.pop("mystic bread", 0)

print(available_items)
print(health_points)

# get keys

user_ids = {"teraCoder": 100019, "pythonGuy": 182921, "samTheJavaMaam": 123112, "lyleLoop": 102931, "keysmithKeith": 129384}
num_exercises = {"functions": 10, "syntax": 13, "control flow": 15, "loops": 22, "lists": 19, "classes": 18, "dictionaries": 18}
users = user_ids.keys()
lessons = num_exercises.keys()
print(users)
print(lessons)

#get values

num_exercises = {"functions": 10, "syntax": 13, "control flow": 15, "loops": 22, "lists": 19, "classes": 18, "dictionaries": 18}

total_exercises = 0

for i in num_exercises.values():
  total_exercises += i

print(total_exercises)

#get both items

pct_women_in_occupation = {"CEO": 28, "Engineering Manager": 9, "Pharmacist": 58, "Physician": 40, "Lawyer": 37, "Aerospace Engineer": 9}

for key, value in pct_women_in_occupation.items():
  print('Women make up {} percent of {}s.'.format(value, key))

#Women make up 28 percent of CEOs.
#Women make up 9 percent of Engineering Managers.
#Women make up 58 percent of Pharmacists.
#Women make up 40 percent of Physicians.
#Women make up 37 percent of Lawyers.
#Women make up 9 percent of Aerospace Engineers.


tarot = { 1:	"The Magician", 2:	"The High Priestess", 3:	"The Empress", 4:	"The Emperor", 5:	"The Hierophant", 6:	"The Lovers", 7:	"The Chariot", 8:	"Strength", 9:	"The Hermit", 10:	"Wheel of Fortune", 11:	"Justice", 12:	"The Hanged Man", 13:	"Death", 14:	"Temperance", 15:	"The Devil", 16:	"The Tower", 17:	"The Star", 18:	"The Moon", 19:	"The Sun", 20:	"Judgement", 21:	"The World", 22: "The Fool"}

spread = {}

spread["past"] = tarot.pop(13, "meh")
spread["present"] = tarot.pop(22, "meh")
spread["future"] = tarot.pop(10, "meh")

for k, v in spread.items():
  print ('Your {} is the {} card.'.format(k, v))

# Your past is the Death card.
# Your present is the The Fool card.
# Your future is the Wheel of Fortune card.
