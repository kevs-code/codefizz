let raceNumber = Math.floor(Math.random() * 1000);
let registeredEarly = false;
let runnersAge = 18;
if (runnersAge > 18 && registeredEarly) {
  raceNumber += 1000;
}
if (runnersAge > 18 && registeredEarly) {
    console.log(`No. ${raceNumber} your race will stare at 9:30am. Good luck!`);
} else if (runnersAge > 18 && !registeredEarly) {
  console.log(`No. ${raceNumber} your race will stare at 11:00am. Good luck!`);
} else if (runnersAge < 18) {
  console.log(`No. ${raceNumber} your race will stare at 12:40am. Good luck Kids!`);
} else {
  console.log(`Please consult the registration desk`);
}
