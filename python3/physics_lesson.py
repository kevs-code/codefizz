train_mass = 22680
train_acceleration = 10
train_distance = 100
c = 3*10**8
bomb_mass = 1

def f_to_c(f_temp):
  c_temp = (f_temp - 32) * 5/9
  return c_temp

def c_to_f(c_temp):
  f_temp = c_temp * 9/5 + 32
  return f_temp

def get_force(mass, acceleration):
  return mass * acceleration

def get_energy(mass,c):
  return mass*(c**2)

def get_work(mass, acceleration, distance):
  force = get_force(mass, acceleration)
  return force*distance

f100_in_celsius = f_to_c(100)
print(f100_in_celsius)
c0_in_fahrenheit = c_to_f(0)
print(c0_in_fahrenheit)
train_force = get_force(train_mass, train_acceleration)
print(train_force)
print("The GE train supplies %s Newtons of force." % train_force)
bomb_energy = get_energy(bomb_mass, c)
print("A 1kg bomb supplies %s Joules." % bomb_energy)
train_work = get_work(train_mass, train_acceleration, train_distance)
print("The GE train does %s Joules of work over %s meters." % (train_work, train_distance))

#bonus
#Use exponents (**) to return the square root of num
def square_root(num):
  return num**0.5

