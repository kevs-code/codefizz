let availableAirplanes = [
    {name: 'AeroJet', fuelCapacity: 800, availableStaff: ['pilots', 'flightAttendents', 'engineers', 'medicalAssistance', 'sensorOperators']}, {name: 'SkyJet', fuelCapacity: 500, availableStaff: ['pilots', 'flightAttendents']}
  ];

let flightRequirements = {
  requiredStaff: 4
  };

const meetsStaffRequirements = (availableStaff, requiredStaff) => {
  if (availableStaff.length >= requiredStaff) {
    return true;
  } else {
    return false;
  }
};

export { availableAirplanes, flightRequirements, meetsStaffRequirements};
