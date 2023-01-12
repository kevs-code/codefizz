##zip
names = ['Jenny', 'Alexus', 'Sam', 'Grace']
dogs_names = ['Elphonse', 'Dr. Doggy DDS', 'Carter', 'Ralph']

names_and_dogs_names = zip(names, dogs_names)
list_of_names_and_dogs_names = list(names_and_dogs_names)
print(list_of_names_and_dogs_names)

orders = ['daisies', 'periwinkle']
print(orders)
orders.append('tulips')
orders.append('roses')
print(orders)

orders = ['daisy', 'buttercup', 'snapdragon', 'gardenia', 'lily']

# Create new orders here:
new_orders = orders + ['lilac', 'iris']

broken_prices = [5, 3, 4, 5, 4] + [4]

#print a range list
list1 = range(9)

list2 = range(8)
print(list(list1))

# my_range3 = range(1, 100, 10)
# print(list(my_range3))
# [1, 11, 21, 31, 41, 51, 61, 71, 81, 91]

list1 = range(5, 15, 3)

list2 = range(0, 40, 5)

first_names = ['Ainsley', 'Ben', 'Chani', 'Depak']
age = []
age.append(42)
all_ages = [32, 41, 29] + age
name_and_age = zip(first_names, all_ages)
ids = range(4)

# gradebook

last_semester_gradebook = [("politics", 80), ("latin", 96), ("dance", 97), ("architecture", 65)]
subjects = ['physics', 'calculus', 'poetry', 'history']
grades = [98, 97, 85, 88]
subjects.append('computer science')
grades.append(100)
subjects.append('visual arts')
grades.append(93)
gradebook = zip(subjects, grades)
print(list(gradebook))
full_gradebook = list(gradebook) + last_semester_gradebook

##access lists

list1 = range(2, 20, 3)
list1_len = len(list1)
print(list1_len)

employees = ['Michael', 'Dwight', 'Jim', 'Pam', 'Ryan', 'Andy', 'Robert']
index4 = employees[4]
print(len(employees))
print(employees[6])

shopping_list = ['eggs', 'butter', 'milk', 'cucumbers', 'juice', 'cereal']
print(len(shopping_list))
last_element = shopping_list[-1]
element5 = shopping_list[5]
print(element5, last_element)

suitcase = ['shirt', 'shirt', 'pants', 'pants', 'pajamas', 'books']
beginning = suitcase[0:4]
print(beginning)
middle = suitcase [2:4]

suitcase = ['shirt', 'shirt', 'pants', 'pants', 'pajamas', 'books']
start = suitcase[:3]
end = suitcase[4:]
end = suitcase[-3:] # same as above here

votes = ['Jake', 'Jake', 'Laurie', 'Laurie', 'Laurie', 'Jake', 'Jake', 'Jake', 'Laurie', 'Cassie', 'Cassie', 'Jake', 'Jake', 'Cassie', 'Laurie', 'Cassie', 'Jake', 'Jake', 'Cassie', 'Laurie']

jake_votes = votes.count('Jake')
print(jake_votes)

#demo .sort() acts on list directly not stored variable
### Exercise 1 & 2 ###
addresses = ['221 B Baker St.', '42 Wallaby Way', '12 Grimmauld Place', '742 Evergreen Terrace', '1600 Pennsylvania Ave', '10 Downing St.']

# Sort addresses here:

### Exercise 3 ###
names = ['Ron', 'Hermione', 'Harry', 'Albus', 'Sirius']
names.sort()

### Exercise 4 ###
cities = ['London', 'Paris', 'Rome', 'Los Angeles', 'New York']

sorted_cities = cities.sort()

sorted_addresses = addresses.sort()
print(sorted_addresses)
print(sorted_cities)
# nothing stores to variable but cities and addresses are both sorted now
# None
# None
#sorted was correct type of list as here
games = ['Portal', 'Minecraft', 'Pacman', 'Tetris', 'The Sims', 'Pokemon']
games_sorted = sorted(games)
print(games, games_sorted)


inventory = ['twin bed', 'twin bed', 'headboard', 'queen bed', 'king bed', 'dresser', 'dresser', 'table', 'table', 'nightstand', 'nightstand', 'king bed', 'king bed', 'twin bed', 'twin bed', 'sheets', 'sheets', 'pillow', 'pillow']

inventory_len = len(inventory)

first = inventory[0]
last = inventory[-1]

inventory_2_6 = inventory[2:6]

first_3 = inventory [:3]
twin_beds = inventory.count('twin bed')
inventory_sorted = inventory.sort()
print(inventory, inventory_sorted)
# ['dresser', 'dresser', 'headboard', 'king bed', 'king bed', 'king bed', 'nightstand', 'nightstand', 'pillow', 'pillow', 'queen bed', 'sheets', 'sheets', 'table', 'table', 'twin bed', 'twin bed', 'twin bed', 'twin bed'] None

#pizzas

toppings = ['pepperoni', 'pineapple', 'cheese', 'sausage', 'olives', 'anchovies', 'mushrooms']
prices = [2, 6, 1, 3, 2, 7, 2]
num_pizzas = len(toppings)
print('We sell %d different kinds of pizza!' % num_pizzas)
pizzas = list(zip(prices, toppings))
pizzas = sorted(pizzas)
print(pizzas)
cheapest_pizza = pizzas[0]
priciest_pizza = pizzas[-1]
three_cheapest = pizzas[:3]
print(three_cheapest)
num_two_dollar_slices = prices.count(2)
print(num_two_dollar_slices)

# tuples immutable data

>>> name = ('Mike')
>>> print(name)
Mike
>>> type(name)
<class 'str'>
>>> name = ('Mike',)
>>> type(name)
<class 'tuple'>
>>> len(name)
1
#unpack
>>> tup = ('Mike', 12, 'dog')
>>> name, age, pet = tup
>>> name
'Mike'
>>> age
12
>>> pet
'dog'
#can you sort a tuple?, maybe if you convert it into e.g., a list first

>>> tup = (9, 12, 7)
>>> tup.sort()
Traceback (most recent call last):
  File "<stdin>", line 1, in <module>
AttributeError: 'tuple' object has no attribute 'sort'
>>> tuplist = list(tup)
>>> tuplist.sort()
>>> tuplist
[7, 9, 12]

