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
print(type(Grade(100)))
print(type('hello'))

class HoldsFive:
  five = 5
  
five_holder = HoldsFive()

print(hasattr(five_holder, 'five'))
