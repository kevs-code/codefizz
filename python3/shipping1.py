premium_ground_shipping = 125.00

def ground_shipping(weight):
  price = 20
  if weight > 10:
    price += 4.75 * weight
  elif weight > 6:
    price += 4 * weight
  elif weight > 2:
    price += 3 * weight
  else:
    price += 1.5 * weight
  return "{:.2f}".format(price)

print (ground_shipping(8.4))

def drone_shipping(weight):
  price = 0
  if weight > 10:
    price += 14.25 * weight
  elif weight > 6:
    price += 12 * weight
  elif weight > 2:
    price += 9 * weight
  else:
    price += 4.5 * weight
  return "{:.2f}".format(price)

print (drone_shipping(1.5))

def cheapest_shipping(weight):
  shipping = [float(drone_shipping(weight)), float(ground_shipping(weight)), premium_ground_shipping]
  print(shipping)
  return "{:.2f}".format(min(shipping))


print(cheapest_shipping(4.8))
print(cheapest_shipping(41.5))
