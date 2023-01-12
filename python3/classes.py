# types warmup
print(type(5))
my_dict = {}
print(type(my_dict))
my_list = []
print(type(my_list))

class Facade:
  pass

facade_1 = Facade()
facade_1_type = type(facade_1)
print(facade_1_type)

class Grade:
  minimum_passing = 65

class Rules:
  def washing_brushes(self):
    return 'Point bristles towards the basin while washing your brushes.'

# useful?
class Circle:
  pi = 3.14
  def area(self, radius):
    return self.pi * radius ** 2

circle = Circle()
pizza_area = circle.area(12/2)
teaching_table_area = circle.area(36/2)
round_room_area = circle.area(11460/2)

print(pizza_area)
print(teaching_table_area)
print(round_room_area)

# constructor

class Circle:
  pi = 3.14
  
  # Add constructor here:
  def __init__(self, diameter):
    print('New circle with diameter: {}'.format(diameter))

circle = Circle(36)
# prints: New circle with diameter: 36

# instance variables e.g., created on instance only

class Store:
  pass

alternative_rocks = Store()
isabelles_ices = Store()

alternative_rocks.store_name = "Alternative Rocks"
isabelles_ices.store_name = "Isabelle's Ices"

print(alternative_rocks.store_name)
print(isabelles_ices.store_name)

#hasattr
can_we_count_it = [{'s': False}, "sassafrass", 18, ["a", "c", "s", "d", "s"]]

for element in can_we_count_it:
  if hasattr(element, "count"):
    print(str(type(element)) + " has the count attribute!")
  else:
    print(str(type(element)) + " does not have the count attribute :(")

#getattr
hasattr(attributeless, "fake_attribute")
# returns False

getattr(attributeless, "other_fake_attribute", 800)
# returns 800, the default value or attribute value if real

# self

class SearchEngineEntry:
  def __init__(self, url):
    self.url = url

codecademy = SearchEngineEntry("www.codecademy.com")
wikipedia = SearchEngineEntry("www.wikipedia.org")

print(codecademy.url)
# prints "www.codecademy.com"

print(wikipedia.url)
# prints "www.wikipedia.org"

class SearchEngineEntry:
  secure_prefix = "https://"
  def __init__(self, url):
    self.url = url

  def secure(self):
    return "{prefix}{site}".format(prefix=self.secure_prefix, site=self.url)

codecademy = SearchEngineEntry("www.codecademy.com")

print(codecademy.secure())
# prints "https://www.codecademy.com"

print(wikipedia.secure())
# prints "https://www.wikipedia.org"

# more self

class Circle:
  pi = 3.14
  def __init__(self, diameter):
    print("Creating circle with diameter {d}".format(d=diameter))
    # Add assignment for self.radius here:
    self.radius = diameter / 2
  def circumference(self):
    return 2 * self.pi * self.radius
    
medium_pizza = Circle(12)
teaching_table = Circle(36)
round_room = Circle(11460)

print(medium_pizza.circumference())
print(teaching_table.circumference())
print(round_room.circumference())

#Everything is an Object

print(dir(5))

def this_function_is_an_object():
  return 3

print(dir(this_function_is_an_object))

# __repr__ tells what to print instead of classname.obj and where it is stored

class Circle:
  pi = 3.14
  
  def __init__(self, diameter):
    self.radius = diameter / 2
  
  def __repr__(self):
    return 'Circle with radius {}'.format(self.radius)

  def area(self):
    return self.pi * self.radius ** 2
  
  def circumference(self):
    return self.pi * 2 * self.radius
  
  
medium_pizza = Circle(12)
teaching_table = Circle(36)
round_room = Circle(11460)

print(medium_pizza)
print(teaching_table)
print(round_room)

# review

class Student:
  def __init__(self, name, year):
    self.name = name
    self.year = year
    self.grades = []
  def add_grade(self, grade):
    if type(grade) == Grade:
      self.grades.append(grade)

class Grade:
  minimum_passing = 65
  def __init__(self, score):
    self.score = score


roger = Student('Roger van der Weyden', 10)
sandro = Student('Sandro Botticelli', 12)
pieter = Student('Pieter Bruegel the Elder', 8)

pieter.add_grade(Grade(100))

# meh

class User:
  def __init__(self, name):
    self.name = name
    
  def __repr__(self):
    return "Hiya {}!".format(self.name)
  
devorah = User("Devorah")
print(devorah)
