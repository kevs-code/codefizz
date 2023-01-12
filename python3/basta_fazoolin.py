class Menu:
  def __init__(self, name, items, start_time, end_time):
    self.name = name
    self.items = items
    self.start_time = start_time
    self.end_time = end_time
  def __repr__(self):
    return '{} menu available from {}.00hrs to {}.00hrs'.format(self.name, self.start_time, self.end_time)
  def calculate_bill(self, purchased_items):
    total = 0
    for i in purchased_items:
      for k in self.items:
        if i == k:
          total += self.items[k]
    return '$%.2f' % total

# Create a Menu object and save it into the variable brunch. Call it with the arguments "brunch" and the items dictionary in the code block above.

#For the start_time and end_time, either you can use a 24-hour clock (11 & 16, respectively) or the time object from the datetime module.

brunchObj = {
  'pancakes': 7.50, 'waffles': 9.00, 'burger': 11.00, 'home fries': 4.50, 'coffee': 1.50, 'espresso': 3.00, 'tea': 1.00, 'mimosa': 10.50, 'orange juice': 3.50
}

brunch = Menu("brunch", brunchObj, 11, 16)

early_birdObj = {
  'salumeria plate': 8.00, 'salad and breadsticks (serves 2, no refills)': 14.00, 'pizza with quattro formaggi': 9.00, 'duck ragu': 17.50, 'mushroom ravioli (vegan)': 13.50, 'coffee': 1.50, 'espresso': 3.00,
}

early_bird = Menu("early bird", early_birdObj, 15, 18)

dinnerObj = {
  'crostini with eggplant caponata': 13.00, 'ceaser salad': 16.00, 'pizza with quattro formaggi': 11.00, 'duck ragu': 19.50, 'mushroom ravioli (vegan)': 13.50, 'coffee': 2.00, 'espresso': 3.00,
}

dinner = Menu("dinner", dinnerObj, 17, 23)

kidsObj = {
  'chicken nuggets': 6.50, 'fusilli with wild mushrooms': 12.00, 'apple juice': 3.00
}

kids = Menu("kids", kidsObj, 11, 21)
print(brunch)
print(brunch.calculate_bill(['pancakes', 'home fries', 'coffee']))
print(early_bird.calculate_bill(['salumeria plate', 'mushroom ravioli (vegan)']))

# Franchise

class Franchise:
  def __init__(self, address, menus):
    self.address = address
    self.menus = menus
  
  def __repr__(self):
    return 'Restaurant is {}'.format(self.address)

  def available_menus(self, time):
    menu = []
    for i in self.menus:
      if time >= i.start_time and time <= i.end_time:
        menu.append(i.name)
    return menu

flagship_store = Franchise('1232 West End Road', [brunch, early_bird, dinner, kids])

new_installment = Franchise('12 East Mulberry Street', [brunch, early_bird, dinner, kids])


print(flagship_store.available_menus(12))
print(new_installment.available_menus(17))

# Business

class Business:
  def __init__(self, name, franchises):
    self.name = name
    self.franchise = franchises

arepas_menuObj = {
  'arepa pabellon': 7.00, 'pernil arepa': 8.50, 'guayanes arepa': 8.00, 'jamon arepa': 7.50
}
arepas_menu = Menu("arepas menu", arepas_menuObj, 10, 20)

arepas_place = Franchise('189 Fitzgerald Avenue', [arepas_menu])

business = Business("Basta Fazoolin' with my Heart", [flagship_store, new_installment])

business2 = Business("Take a' Arepa", [arepas_place])

print(business.name)
print(business2.name)
