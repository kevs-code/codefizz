const getSleepHours = day => {
  day = day.toLowerCase();
  let sleep = 0;
  switch (day) {
    case 'monday':
      sleep = 8;
      break;
    case 'tuesday':
      sleep = 8;
      break;
    case 'wednesday':
      sleep = 8;
      break;
    case 'thursday':
      sleep = 8;
      break;
    case 'friday':
      sleep = 8;
      break;
    case 'saturday':
      sleep = 1;
      break;
    case 'sunday':
      sleep = 8;
      break;
    default:
      sleep = 24;
  }
  return sleep;
}

const getActualSleepHours = () => {
  var weekdays = ['monday', 'tuesday', 'wednesday', 'thursday', 'friday', 'saturday', 'sunday'];
  let sum = 0;
  for (i = 0; i < weekdays.length; i++) {
    // console.log(weekdays[i]);
    sum = sum + getSleepHours(weekdays[i]);
    // console.log(sum);
  } 
  // console.log(sum);
  return sum;
}

const getIdealSleepHours = () => {
  const idealSleepHours = 8;
  return idealSleepHours * 7;
}

const calculateSleepDebt = () => {
  let actualSleepHours = getActualSleepHours();
  let idealSleepHours = getIdealSleepHours();
  let margin = actualSleepHours - idealSleepHours;
  if (actualSleepHours === idealSleepHours ) {
    console.log(`User go the perfect amount of Sleep with ${margin} hours deficit!`) } else if (actualSleepHours >= idealSleepHours) {
    console.log(`User got more sleep than needed, an extra ${margin} hours sleep!`)} else {
      console.log(`User got less sleep than needed! having ${margin} hours sleep this week`)
    }

}
calculateSleepDebt()
/*
12.
For extra practice, try these:

getActualSleepHours() could be implemented without calling getSleepHours(). Use literal numbers and the + operator to rewrite getActualSleepHours(). It should still return the total actual hours slept in the week.

Some people need to sleep longer than others. Rewrite getIdealSleepHours() so that you can pass it an argument, like getIdealSleepHours(8) where 8 is the ideal hours per night. Update the call to getIdealSleepHours() in calculateSleepDebt() too.

To see the solutions, open the hint.
*/
