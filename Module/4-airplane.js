export let availableAirplanes = [
    {name: 'AeroJet', fuelCapacity: 800, availableStaff: ['pilots', 'flightAttendents', 'engineers', 'medicalAssistance', 'sensorOperators'], maxSpeed: 1200, minSpeed: 300}, {name: 'SkyJet', fuelCapacity: 500, availableStaff: ['pilots', 'flightAttendents'], maxSpeed: 800, minSpeed: 200}
  ];

export let flightRequirements = {
  requiredStaff: 4,
  requiredSpeedRange: 700
  };

export const meetsStaffRequirements = (availableStaff, requiredStaff) => {
  if (availableStaff.length >= requiredStaff) {
    return true;
  } else {
    return false;
  }
};


export const meetsSpeedRangeRequirements = (maxSpeed, minSpeed, requiredSpeedRange) => {
  let range = maxSpeed - minSpeed;
  if (range > requiredSpeedRange) {
    return true;
  } else {
    return false;
  }
};
//export { availableAirplanes, flightRequirements, meetsStaffRequirements};
