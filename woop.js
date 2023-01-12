const _ = {
  clamp (num, min, max) {
    const lowerClamp = Math.max(num, min);
    // console.log(lowerClamp);
    const Clamp = Math.min(lowerClamp, max);
    // console.log(Clamp);
    return Clamp;
  }
}
console.log(_.clamp(10, -5, 5));
