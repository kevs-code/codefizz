// Write your function here:

const finalGrade = (grade1, grade2, grade3) => {
   let average = (grade1 + grade2 + grade3) / 3; 
   if (grade1 < 0 || grade1 > 100) {
    return "You have entered an invalid grade.";
    }
    if (grade2 < 0 || grade2 > 100) {
    return "You have entered an invalid grade.";
    }
    if (grade3 < 0 || grade3 > 100) {
    return "You have entered an invalid grade.";
    }
  return average < 60  ? 'F' :
         average < 70 ? 'D' :
         average < 80 ? 'C' :
         average < 90 ? 'B' : 'A';
}






// Uncomment the line below when you're ready to try out your function
console.log(finalGrade(99, 92, 95)) // Should print 'A'

// We encourage you to add more function calls of your own to test your code!

// Write your function here:
const reportingForDuty = (rank, lastName) => {
  return `${rank} ${lastName} reporting for duty!`;
}


// Uncomment the line below when you're ready to try out your function
console.log(reportingForDuty('Private', 'Fido')) // Should return 'Private Fido reporting for duty!'

// We encourage you to add more function calls of your own to test your code!
