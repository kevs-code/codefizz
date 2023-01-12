const menu = {
  _courses: {
    appetizers: [],
    mains: [],
    desserts: []
  },//get and set could be in _courses
  get appetizers(){
  },
  set appetizers(appetizer){
  },
  get mains(){
  },
  set mains(main){
  },
  get desserts(){
  },
  set desserts(dessert){
  },//},
  get courses(){
    //const meh = Object.entries(this._courses);
    return this._courses;
  },
  addDishToCourse (courseName, dishName, dishPrice) {
    const dish = {
    name: dishName,
    price: dishPrice
    };
    this._courses[courseName].push(dish);
  },
  getRandomDishFromCourse(courseName) {
    const dishes = this._courses[courseName];
    let index = Math.floor(Math.random() * dishes.length);
    return  dishes[index];
  },
  generateRandomMeal() {
    const appetizer = this.getRandomDishFromCourse('appetizers');
    const main = this.getRandomDishFromCourse('mains');
    const dessert = this.getRandomDishFromCourse('desserts');
    const totalPrice = (appetizer.price + main.price + dessert.price).toFixed(2);
    const totalMeal = appetizer.name + ', ' + main.name + ', ' + dessert.name + '. Total Price: $' + totalPrice + '.';
    
    return totalMeal;
  }
};
menu.addDishToCourse('appetizers', 'King Prawns', 1.50);
menu.addDishToCourse('appetizers', 'Hot Wings', 1.50);
menu.addDishToCourse('appetizers', 'Onion Rings', 1.50);

menu.addDishToCourse('mains', 'Steak', 4.50);
menu.addDishToCourse('mains', 'Beef', 4.50);
menu.addDishToCourse('mains', 'Cow', 4.50);

menu.addDishToCourse('desserts', 'Ice Cream', 1.50);
menu.addDishToCourse('desserts', 'Carrots', 0.50);
menu.addDishToCourse('desserts', 'Taramisu', 10.50);

console.log(menu.generateRandomMeal());

