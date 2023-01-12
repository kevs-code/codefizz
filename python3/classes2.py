#inheritance and polymorphism

# inheritance

class User:
  is_admin = False
  def __init__(self, username)
    self.username = username

class Admin(User):
  is_admin = True

#
class Bin:
  pass

class RecyclingBin(Bin):
  pass


issubclass(ZeroDivisionError, Exception)
# Returns True
# Above, we checked whether ZeroDivisionError, the exception raised when attempting division by zero, is a subclass of Exception. It is, so issubclass returns True.


class KitchenException(Exception):
  """
  Exception that gets thrown when a kitchen appliance isn't working
  """

class MicrowaveException(KitchenException):
  """
  Exception for when the microwave stops working
  """

class RefrigeratorException(KitchenException):
  """
  Exception for when the refrigerator stops working
  """
# as all subclasses of KitchenException can ...


def get_food_from_fridge():
  if refrigerator.cooling == False:
    raise RefrigeratorException
  else:
    return food

def heat_food(food):
  if microwave.working == False:
    raise MicrowaveException
  else:
    microwave.cook(food)
    return food

try:
  food = get_food_from_fridge()
  food = heat_food(food)
except KitchenException:
  food = order_takeout()

#exception

# Define your exception up here:
class OutOfStock(Exception):
  """
  Out of Stock
  """
  print('meh')

# Update the class below to raise OutOfStock
class CandleShop:
  name = "Here's a Hot Tip: Buy Drip Candles"
  def __init__(self, stock):
    self.stock = stock
    
  def buy(self, color):
    if self.stock[color] == 0:
      raise OutOfStock
    else:
      self.stock[color] = self.stock[color] - 1

candle_shop = CandleShop({'blue': 6, 'red': 2, 'green': 0})
candle_shop.buy('blue')

try:
# This should raise OutOfStock:
  candle_shop.buy('green')
except Exception:
  #pass
  #OutOfStock() still prints meh with pass here as OutOfStock called above. 
  print('weeeee') 

#meh
#weeeee

#override method

class User:
  def __init__(self, username, permissions):
    self.username = username
    self.permissions = permissions

  def has_permission_for(self, key):
    if self.permissions.get(key):
      return True
    else:
      return False
Above we defined a class User which takes a permissions parameter in its constructor. Let’s assume permissions is a dict. User has a method .has_permission_for() implemented, where it checks to see if a given key is in its permissions dictionary. We could then define our Admin user like this:

class Admin(User):
  def has_permission_for(self, key):
    return True

#override ... permission check with class Admin

class Message:
  def __init__(self, sender, recipient, text):
    self.sender = sender
    self.recipient = recipient
    self.text = text

class User:
  def __init__(self, username):
    self.username = username
    
  def edit_message(self, message, new_text):
    if message.sender == self.username:
      message.text = new_text

class Admin(User):
  def edit_message(self, message, new_text):
    message.text = new_text

#super

class Sink:
  def __init__(self, basin, nozzle):
    self.basin = basin
    self.nozzle = nozzle

class KitchenSink(Sink):
  def __init__(self, basin, nozzle, trash_compactor=None):
    super().__init__(basin, nozzle)
    if trash_compactor:
      self.trash_compactor = trash_compactor
#Above we defined two classes. First, we defined a Sink class with a constructor that assigns a rinse basin and a sink nozzle to a Sink instance. Afterwards, we defined a KitchenSink class that inherits from Sink. KitchenSink‘s constructor takes an additional parameter, a trash_compactor. KitchenSink then calls the constructor for Sink with the basin and nozzle it received using the super() function, with this line of code:

#super().__init__(basin, nozzle)

# super add 40 raisins

class PotatoSalad:
  def __init__(self, potatoes, celery, onions):
    self.potatoes = potatoes
    self.celery = celery
    self.onions = onions

class SpecialPotatoSalad(PotatoSalad):
  def __init__(self, potatoes, celery, onions):
    super().__init__(potatoes, celery, onions)
    self.raisins = 40

#interfaces

class Chess:
  def __init__(self):
    self.board = setup_board()
    self.pieces = add_chess_pieces()

  def play(self):
    print("Playing chess!")

class Checkers:
  def __init__(self):
    self.board = setup_board()
    self.pieces = add_checkers_pieces()

  def play(self):
    print("Playing checkers!")
#In the code above we define two classes, Chess and Checkers. In Chess we define a constructor that sets up the board and pieces, and a .play() method. Checkers also defines a .play() method. If we have a play_game() function that takes an instance of Chess or Checkers, it could call the .play() method without having to check which class the object is an instance of.

def play_game(chess_or_checkers):
  chess_or_checkers.play()

chess_game = Chess()
checkers_game = Checkers()
chess_game_2 = Chess()

for game in [chess_game, checkers_game, chess_game_2]:
  play_game(game)
"""
Prints out the following:
Playing chess!
Playing checkers!
Playing chess!

#When two classes have the same method names and attributes, we say they implement the same interface. An interface in Python usually refers to the names of the methods and the arguments they take. Other programming languages have more rigid definitions of what an interface is, but it usually hinges on the fact that different objects from different classes can perform the same operation (even if it is implemented differently for each class).

#interface 

class InsurancePolicy:
  def __init__(self, price_of_item):
    self.price_of_insured_item = price_of_item

class VehicleInsurance(InsurancePolicy):
  def get_rate(self):
    return .001 * self.price_of_insured_item

class HomeInsurance(InsurancePolicy):
  def get_rate(self):
    return .00005 * self.price_of_insured_item  

#polymorpherism

# For example, let’s think of the + operator. It’s easy to think of it as a single function that “adds” whatever is on the left with whatever is on the right, but it does many different things in different contexts:

# For an int and an int, + returns an int
2 + 4 == 6

# For a float and a float, + returns a float
3.1 + 2.1 == 5.2

# For a string and a string, + returns a string
"Is this " + "addition?" == "Is this addition?"

# For a list and a list, + returns a list
[1, 2] + [3, 4] == [1, 2, 3, 4]
#Look at all the different things that + does! The hope is that all of these things are, for the arguments given to them, the intuitive result of adding them together. Polymorphism is the term used to describe the same syntax (like the + operator here, but it could be a method name) doing different actions depending on the type of data.

#Polymorphism is an abstract concept that covers a lot of ground, but defining class hierarchies that all implement the same interface is a way of introducing polymorphism to our code.

a_list = [1, 18, 32, 12]
a_dict = {'value': True}
a_string = "Polymorphism is cool!"

print(len(a_list))
print(len(a_dict))
print(len(a_string))

#polymorpherism example 2 len() it has the same syntax and is performing different operation on each datatype
#4
#1
#21

# dunder methods (associated with polymorpherism)

# One way that we can introduce polymorphism to our class definitions is by using Python’s special dunder methods. We’ve explored a few already, the constructor __init__ and the string representation method __repr__, but that’s only scratching the tip of the iceberg.

# Python gives us the power to define dunder methods that define a custom-made class to look and behave like a Python builtin. What does that mean? Say we had a class that has an addition method:

class Color:
  def __init__(self, red, blue, green):
    self.red = red
    self.blue = blue
    self.green = green

  def __repr__(self):
    return "Color with RGB = ({red}, {blue}, {green})".format(red=self.red, blue=self.blue, green=self.green)

  def add(self, other):
    """
    Adds two RGB colors together
    Maximum value is 255
    """
    new_red = min(self.red + other.red, 255)
    new_blue = min(self.blue + other.blue, 255)
    new_green = min(self.green + other.green, 255)

    return Color(new_red, new_blue, new_green)

red = Color(255, 0, 0)
blue = Color(0, 255, 0)

magenta = red.add(blue)
print(magenta)
# Prints "Color with RGB = (255, 255, 0)"
# In this code we defined a Color class that implements an addition function. Unfortunately, red.add(blue) is a little verbose for something that we have an intuitive symbol for (i.e., the + symbol). Well, Python offers the dunder method __add__ for this very reason! If we rename the add() method above to something that looks like this:

class Color: 
  def __add__(self, other):
    """
    Adds two RGB colors together
    Maximum value is 255
    """
    new_red = min(self.red + other.red, 255)
    new_blue = min(self.blue + other.blue, 255)
    new_green = min(self.green + other.green, 255)

    return Color(new_red, new_blue, new_green)
Then, if we create the colors:

red = Color(255, 0, 0)
blue = Color(0, 255, 0)
green = Color(0, 0, 255)
We can add them together using the + operator!

# Color with RGB: (255, 255, 0)
magenta = red + blue

# Color with RGB: (0, 255, 255)
cyan = blue + green

# Color with RGB: (255, 0, 255)
yellow = red + green

# Color with RGB: (255, 255, 255)
white = red + blue + green
# Since we defined an __add__ method for our Color class, we were able to add these objects together using the + operator.


#dunder

class Atom:
  def __init__(self, label):
    self.label = label
  def __add__(self, other):
    return Molecule([self, other])
    
class Molecule:
  def __init__(self, atoms):
    if type(atoms) is list:
	    self.atoms = atoms
      
sodium = Atom("Na")
chlorine = Atom("Cl")
salt = Molecule([sodium, chlorine])
# salt = sodium + chlorine
#__dunder_ 2_

#Dunder Methods II
#Python offers a whole suite of magic methods a class can implement that will allow us to use the same syntax as Python’s built-in data types. You can write functionality that allows custom defined types to behave like lists:

class UserGroup:
  def __init__(self, users, permissions):
    self.user_list = users
    self.permissions = permissions

  def __iter__(self):
    return iter(self.user_list)

  def __len__(self):
    return len(self.user_list)

  def __contains__(self, user):
    return user in self.user_list
#In our UserGroup class above we defined three methods:

#__init__, our constructor, which sets a list of users to the instance variable self.user_list and sets the group’s permissions when we create a new UserGroup.
#__iter__, the iterator, we use the iter() function to turn the list self.user_list into an iterator so we can use for user in user_group syntax. For more information on iterators, review Python’s documentation of Iterator Types.
#__len__, the length method, so when we call len(user_group) it will return the length of the underlying self.user_list list.
#__contains__, the check for containment, allows us to use user in user_group syntax to check if a User exists in the user_list we have.
#These methods allow UserGroup to act like a list using syntax Python programmers will already be familiar with. If all you need is something to act like a list you could absolutely have used a list, but if you want to bundle some other information (like a group’s permissions, for instance) having syntax that allows for list-like operations can be very powerful.

#We would be able to use the following code to do this, for example:

class User:
  def __init__(self, username):
    self.username = username

diana = User('diana')
frank = User('frank')
jenn = User('jenn')

can_edit = UserGroup([diana, frank], {'can_edit_page': True})
can_delete = UserGroup([diana, jenn], {'can_delete_posts': True})

print(len(can_edit))
# Prints 2

for user in can_edit:
  print(user.username)
# Prints "diana" and "frank"

if frank in can_delete:
  print("Since when do we allow Frank to delete things? Does no one remember when he accidentally deleted the site?")
#Above we created a set of users and then added them to UserGroups with specific permissions. Then we used Python built-in functions and syntax to calculate the length of a UserGroup, to iterate through a UserGroup and to check for a User‘s membership in a UserGroup.


#dunder 

class LawFirm:
  def __init__(self, practice, lawyers):
    self.practice = practice
    self.lawyers = lawyers
  def __len__(self):
    return len(self.lawyers)
  def __contains__(self, lawyer):
    return lawyer in self.lawyers

d_and_p = LawFirm("Injury", ["Donelli", "Paderewski"])


# review change list behaviour to append and sort

class SortedList(list):
  def append(self, value):
    super().append(value)
    return self.sort()
