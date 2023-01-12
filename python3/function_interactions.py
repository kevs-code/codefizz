#A parameter is a variable in the definition of a function.
#An argument is the value being passed into a function call.
#A function definition begins with def and contains the entire following indented block.
#And function calls are the places a function is invoked, with parentheses, after its definition


# use string as parameter
from record_library import place_record, rotate_record, drop_needle

def play_record(album):
  place_record(album)
  rotate_record(album)
  drop_needle(album)

next_album = "Blondie / Parallel Lines"

play_record(next_album)

#None is nothing!

none_var = None
if none_var:
  print("Hello!")
else:
  print("Goodbye")

# Prints "Goodbye"

# example 50/50 of being review or none!

# module
def get_next_review():
  if random.random() > .5:
    return None
  else:
    return "5/5 Stars, Incredible service and prompt response. Try the coffee!"

def submit_review(review):
  if review is None:
    raise Exception("Submission of an empty review!")

# code

from review_lib import get_next_review, submit_review

# define review here!

review = get_next_review()
if review != None:
  submit_review(review)
print(review)

#default return == None

# store the result of this print() statement in the variable prints_return
print("What does this print function return?")

# print out the value of prints_return
prints_return = print('hi!') 
print(prints_return)
# call sort_this_list.sort() and save that in list_sort_return
sort_this_list = [14, 631, 4, 51358, 50000000]

list_sort_return = sort_this_list.sort()
# print out the value of list_sort_return

print(list_sort_return)

#What does this print function return?
#hi!
#None
#None

Default Arguments
#Function arguments are required in Python. So a standard function definition that defines two parameters requires two arguments passed into the function.

# Function definition with two required parameters
def create_user(username, is_admin):
  create_email(username)
  set_permissions(is_admin)

# Function call with all two required arguments
user1 = create_user('johnny_thunder', True)

# Raises a "TypeError: Missing 1 required positional argument"
user2 = create_user('djohansen')
#Above we defined our function, create_user, with two parameters. We first called it with two arguments, but then tried calling it with only one argument and got an error. What if we had sensible defaults for this argument?

#Not all function arguments in Python need to be required. If we give a default argument to a Python function that argument won’t be required when we call the function.

# Function defined with one required and one optional parameter
def create_user(username, is_admin=False):
  create_email(username)
  set_permissions(is_admin)

# Calling with two arguments uses the default value for is_admin
user2 = create_user('djohansen')
#Above we defined create_user with a default argument for is_admin, so we can call that function with only the one argument 'djohansen'. It assumes the default value for is_admin: False. We can make both of our parameters have a default value (therefore making them all optional).

# We can make all three parameters optional
def create_user(username=None, is_admin=False):
  if username is None:
    username = "Guest"
  else:
    create_email(username)
  set_permissions(is_admin)

# So we can call with just one value
user3 = create_user('ssylvain')
# Or no value at all, which would create a Guest user
user4 = create_user()
#Above we define the function with all optional parameters, if we call it with one argument that gets interpreted as username. We can call it without any arguments at all, which would only use the default values.

# set next to default False

import os

def make_folders(folders_list, nest=False):
  if nest:
    """
    Nest all the folders, like
    ./Music/fun/parliament
    """
    path_to_new_folder = "."
    for folder in folders_list:
      path_to_new_folder += "/{}".format(folder)
      try:
        print(path_to_new_folder)
        os.makedirs("./" + path_to_new_folder)
      except FileExistsError:
        continue
  else:
    """
    Makes all different folders, like
    ./Music/ ./fun/ and ./parliament/
    """
    for folder in folders_list:
      try:
        os.makedirs(folder)

      except FileExistsError:
        continue

make_folders(['Music', 'fun', 'parliament'])

# required parameters before default parameters to work!

#Using Keyword and Positional Arguments
#Not all of your arguments need to have default values. But Python will only accept functions defined with their parameters in a specific order. The required parameters need to occur before any parameters with a default argument.

# Raises a TypeError
def create_user(is_admin=False, username, password):
  create_email(username, password)
  set_permissions(is_admin)
#In the above code, we attempt to define a default argument for is_admin without defining default arguments for the later parameters: username and password.

#If we want to give is_admin a default argument, we need to list it last in our function definition:

# Works perfectly
def create_user(username, password, is_admin=False):
  create_email(username, password)
  set_permissions(is_admin)
#Instructions
#1.
#In script.py the function get_id tries to define a parameter with a default argument before a required parameter.

#Update the function signature of get_id so that website comes second and html_id comes first.

import reqs as requests
from bs4 import BeautifulSoup

def get_id(html_id, website="http://coolsite.com"):
  request = requests.get(website)
  parsed_html = BeautifulSoup(website.content, features="html.parser")
  return parsed_html.find(id_=html_id)


#define some parameters when all default

import shapes

def draw_shape(shape_name="box", character="x", line_breaks=True):
  shape = shapes.draw_shape(shape_name, character)
  if not line_breaks:
    print(shape[1:-1])
  else:
    print(shape)

# call draw_shape() with keyword arguments here:
draw_shape(character = 'm', line_breaks = False)

#module code

BOX_SHAPE = """
xxx
x x
xxx
"""

TRIANGLE_SHAPE = """
  x 
 x x
xxxxx
"""

QUESTION_SHAPE = """
  x
 x x
x   x
   x
  x
  x

  x
"""

def draw_shape(name, char):
  if name == 'box':
    return BOX_SHAPE.replace('x', char)
  elif name == 'triangle':
    return TRIANGLE_SHAPE.replace('x', char)
  else:
    return QUESTION_SHAPE.replace('x', char)


#don't give functions mutable defaults

def populate_list(list_to_populate=[], length=1):
  for num in range(length):
    list_to_populate.append(num)
  return list_to_populate
#It’s reasonable to believe that list_to_populate will be given an empty list every time it’s called. This isn’t the case! list_to_populate will be given a new list once, in its definition, and all subsequent function calls will modify the same list. This will happen:

returned_list = populate_list(length=4)
print(returned_list)
# Prints [0, 1, 2, 3] -- this is expected

returned_list = populate_list(length=6)
print(returned_list)
# Prints [0, 1, 2, 3, 0, 1, 2, 3, 4, 5] -- this is a surprise!

#A mutable object refers to various data structures in Python that are intended to be mutated, or changed. A list has append and remove operations that change the nature of a list. Sets and dictionaries are two other mutable objects in Python.

#It might be helpful to note some of the objects in Python that are not mutable (and therefore OK to use as default arguments). int, float, and other numbers can’t be mutated (arithmetic operations will return a new number). tuples are a kind of immutable list. Strings are also immutable — operations that update a string will all return a completely new string.

# example

def update_order(new_item, current_order=[]):
  current_order.append(new_item)
  return current_order

# First order, burger and a soda
order1 = update_order({'item': 'burger', 'cost': '3.50'})
order1 = update_order({'item': 'soda', 'cost': '1.50'}, order1)

# Second order, just a soda
order2 = update_order({'item': 'soda', 'cost': '1.50'})

# What's in that second order again?
print(order2)

# [{'item': 'burger', 'cost': '3.50'}, {'item': 'soda', 'cost': '1.50'}, {'item': 'soda', 'cost': '1.50'}]


# using None as sentinel

def update_order(new_item, current_order=None):
  if current_order is None:
    current_order = []
  current_order.append(new_item)
  return current_order

# First order, burger and a soda
order1 = update_order({'item': 'burger', 'cost': '3.50'})
order1 = update_order({'item': 'soda', 'cost': '1.50'}, order1)

# Second order, just a soda
order2 = update_order({'item': 'soda', 'cost': '1.50'})

# What's in that second order again?
print(order2)
# [{'item': 'soda', 'cost': '1.50'}]

# unpack multiple returns

def scream_and_whisper(text):
    scream = text.upper()
    whisper = text.lower()
    return scream, whisper

the_scream, the_whisper = scream_and_whisper('burrdabooo')
print(the_scream, the_whisper)

# BURRDABOOO burrdabooo


# postional argument unpacking

We don’t always know how many arguments a function is going to receive, and sometimes we want to handle any possibility that comes at us. Python gives us two methods of unpacking arguments provided to functions. The first method is called positional argument unpacking, because it unpacks arguments given by position. Here’s what that looks like:

def shout_strings(*args):
  for argument in args:
    print(argument.upper())

shout_strings("hi", "what do we have here", "cool, thanks!")
# Prints out:
# "HI"
# "WHAT DO WE HAVE HERE"
# "COOL, THANKS!"
In shout_strings() we use a single asterisk (*) to indicate we’ll accept any number of positional arguments passed to the function. Our parameter args is a tuple of all of the arguments passed. In this case args has three values inside, but it can have many more (or fewer).

Note that args is just a parameter name, and we aren’t limited to that name (although it is rather standard practice). We can also have other positional parameters before our *args parameter. We can’t, as we’ll see, :

def truncate_sentences(length, *sentences):
  for sentence in sentences:
    print(sentence[:length])

truncate_sentences(8, "What's going on here", "Looks like we've been cut off")
# Prints out:
# "What's g"
# "Looks li"
Above we defined a function truncate_sentences that takes a length parameter and also any number of sentences. The function prints out the first length many characters of each sentence in sentences.


# postional argument unpacking


from os.path import join

path_segment_1 = "/Home/User"
path_segment_2 = "Codecademy/videos"
path_segment_3 = "cat_videos/surprised_cat.mp4"

# join all three of the paths here!
print(join(path_segment_1, path_segment_2, path_segment_3))

def myjoin(*strings):
  start = ''
  count = 0
  for string in strings:
    if count == 0:
      start += string
      count += 1
    else:
      start += '/' + string
  return start

print(myjoin(path_segment_1, path_segment_2, path_segment_3))o

# Keyword Argument Unpacking

#Python doesn’t stop at allowing us to accept unlimited positional parameters, it gives us the power to define functions with unlimited keyword parameters too. The syntax is very similar, but uses two asterisks (**) instead of one. Instead of args, we call this kwargs — as a shorthand for keyword arguments.

def arbitrary_keyword_args(**kwargs):
  print(type(kwargs))
  print(kwargs)
  # See if there's an "anything_goes" keyword arg
  # and print it
  print(kwargs.get('anything_goes'))

arbitrary_keyword_args(this_arg="wowzers", anything_goes=101)
# Prints "<class 'dict'>
# Prints "{'this_arg': 'wowzers', 'anything_goes': 101}"
# Prints "101"
#As you can see, **kwargs gives us a dictionary with all the keyword arguments that were passed to arbitrary_keyword_args. We can access these arguments using standard dictionary methods.

#Since we’re not sure whether a keyword argument will exist, it’s probably best to use the dictionary’s .get() method to safely retrieve the keyword argument. Do you remember what .get() returns if the key is not in the dictionary? It’s None!

# unpack keyword args **kwargs

# Checkpoint 1
print("My name is {name} and I'm feeling {feeling}.".format(
	name="meh", feeling="despair"
))

# Checkpoint 2
from products import create_product

# Update create_products() to take arbitrary keyword arguments
def create_products(**products_dict):
  print(products_dict)
  for name, price in products_dict.items():
    create_product(name, price)

# Checkpoint 3
# Update the call to `create_products()` to pass in this dictionary as a series of keyword

#create_products({
#  'Baseball': '3',
#  'Shirt': '14',
#  'Guitar': '70',
#})


create_products(Baseball=3, Shirt=14, Guitar=70)


#My name is meh and I'm feeling despair.
#{'Baseball': 3, 'Shirt': 14, 'Guitar': 70}
#Baseball created, being sold for $3
#Shirt created, being sold for $14
#Guitar created, being sold for $70

#module code

def create_product(name, price):
  print("{} created, being sold for ${}".format(name, price))

#both

#LEARN PYTHON: FUNCTION ARGUMENTS
#Using Both Keyword and Positional Unpacking
#This keyword argument unpacking syntax can be used even if the function takes other parameters. However, the parameters must be listed in this order:

#All named positional parameters
#An unpacked positional parameter (*args)
#All named keyword parameters
#An unpacked keyword parameter (**kwargs)
#Here’s a function with all possible types of parameter:

def main(filename, *args, user_list=None, **kwargs):
  if user_list is None:
    user_list = []

  if '-a' in args:
    user_list = all_users()

  if kwargs.get('active'):
    user_list = [user for user_list if user.active]

  with open(filename) as user_file:
    user_file.write(user_list)
#Looking at the signature of main() we define four different kinds of parameters. The first, filename is a normal required positional parameter. The second, *args, is all positional arguments given to a function after that organized as a tuple in the parameter args. The third, user_list, is a keyword parameter with a default value. Lastly, **kwargs is all other keyword arguments assembled as a dictionary in the parameter kwargs.

#A possible call to the function could look like this:

main("files/users/userslist.txt", 
     "-d", 
     "-a", 
     save_all_records=True, 
     user_list=current_users)
#In the body of main() these arguments would look like this:

filename == "files/users/userslist.txt"
args == ('-d', '-a)
user_list == current_users
kwargs == {'save_all_records': True}

# We can use all four of these kinds of parameters to create functions that handle a lot of possible arguments being passed to them.

#text.txt

#King Richard often thought upon what he had seen of Robin Hood and his fellows. He was very fond of archery; he had heard of many generous actions that were told about them, and he admired their gallant spirit and manners. Thought he, If I could but make these men my faithful subjects, what a pride they would be to my court! The king at last fixed upon a plan by which he might see Robin Hood once more.

# use both args and kwarg

def remove(filename, *args, **kwargs):
  with open(filename) as file_obj:
    text = file_obj.read()

  # Add code here to update text.
  for arg in args:
    print(arg)
    text = text.replace(arg, '')
  
  for k,v in kwargs.items():
    text = text.replace(k, v)

  return text

print(remove("text.txt", "generous", "gallant", fond="amused by", Robin="Mr. Robin"))

# Passing Containers as Arguments
# Not only can we accept arbitrarily many parameters to a function in our definition, but Python also supports a syntax that makes deconstructing any data that you have on hand to feed into a function that accepts these kinds of unpacked arguments. The syntax is very similar, but is used when a function is called, not when it’s defined.

def takes_many_args(*args):
  print(','.join(args))

long_list_of_args = [145, "Mexico City", 10.9, "85C"]

# We can use the asterisk "*" to deconstruct the container.
# This makes it so that instead of a list, a series of four different
# positional arguments are passed to the function
takes_many_args(*long_list_of_args)
# Prints "145,Mexico City,10.9,85C"
#We can use the * when calling the function that takes a series of positional parameters to unwrap a list or a tuple. This makes it easy to provide a sequence of arguments to a function even if that function doesn’t take a list as an argument. Similarly we can use ** to destructure a dictionary.

def pour_from_sink(temperature="Warm", flow="Medium")
  set_temperature(temperature)
  set_flow(flow)
  open_sink()

# Our function takes two keyword arguments
# If we make a dictionary with their parameter names...
sink_open_kwargs = {
  'temperature': 'Hot',
  'flow': "Slight",
}

# We can destructure them an pass to the function
pour_from_sink(**sink_open_kwargs)
# Equivalent to the following:
# pour_from_sink(temperature="Hot", flow="Slight")
#So we can also use dictionaries and pass them into functions as keyword arguments with that syntax. Notice that our pour_from_sink() function doesn’t even accept arbitrary **kwargs. We can use this destructuring syntax even when the function has a specific number of keyword or positional arguments it accepts. We just need to be careful that the object we’re destructuring matches the length (and names, if a dictionary) of the signature of the function we’re passing it into.

#Instructions
#1.
#We’ve got a latecomer to the new create_products syntax who wants to still pass in a dictionary. Unpack new_product_dict while passing it to create_products() as an argument.

# add kwargs

from products import create_product

def create_products(**products_dict):
  for name, price in products_dict.items():
    create_product(name, price)

new_product_dict = {
  'Apple': 1,
  'Ice Cream': 3,
  'Chocolate': 5,
}

# Call create_product() by passing new_product_dict
# as kwargs!


create_products(**new_product_dict)

# Apple created, being sold for $1
# Ice Cream created, being sold for $3
# Chocolate created, being sold for $5

#Review
#We covered a lot of ground in this lesson! We learned all about how functions can accept different arguments and different styles by which we can pass those arguments in. We covered:

#The default return of a function: None
#How to create default arguments to a function
#How to make sure our default arguments work the way we expect when dealing with lists.
#How to pass keyword arguments to a function
#How to unpack multiple returns from a function
#How to unpack multiple positional arguments to a function
#How to unpack multiple keyword arguments to a function
#How to pass a list as a series of arguments to a function
#How to pass a dictionary as a series of keyword arguments to a function
#This is a lot, and you should be impressed with yourself! You now should be able to read many different styles of function writing in Python and come up with ways to call those functions with style and clarity.
#
#Hopefully this has helped you as a writer of Python functions and enabled you to overcome any problems with input and output of a Python function you might run into. Congrats!

#returning functions
def get_math_function(operation): # + or -
    def add(n1, n2):
	return n1 + n2
    def sub(n1, n2):
	return n1 - n2
    if operation == '+':
	return add
    elif operation == '-':
	return sub

def print_his_name():
    print("Mike")

print_his_name()
#Mike

#decoratored function

def title_decorator(print_name_function):
    def wrapper():
	print("King:")
	print_name_function()
    return wrapper



def print_his_name():
    print("Mike")

print_his_name()
#Mike
decorated_function = title_decorator(print_his_name)

decorated_function()

#King:
#Mike

#Decorators skip step
decorated_function = title_decorator(print_his_name)

decorated_function()

#by using this syntax

@title_decorator
def print_his_name():
    print("Mike")

#so

#print_his_name()

#King:
#Mike

#what about any name

#*args, **kwargs
def title_decorator(print_name_function):
    def wrapper(*args, **kwargs):
        print("King:")
        print_name_function(*args, **kwargs)
    return wrapper


@title_decorator
def print_his_name(name):
    print(name)

