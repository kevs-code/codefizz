##awful solution

#Write your function here
def delete_starting_evens(lst): 
  i = 0
  miggins = len(lst)
  while i < miggins:
    if lst[i] % 2 == 0:
    	print(lst.pop(0))
    	i += 1
    else:
        break
  print(lst)

#Uncomment the lines below when your function is done
print(delete_starting_evens([4, 8, 10, 11, 12, 15]))
print(delete_starting_evens([4, 8, 10]))

