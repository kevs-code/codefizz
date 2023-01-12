// Import statement:
import java.util.ArrayList;
class PrimeDirective {
  
  // Add your methods here:
  public boolean isPrime(int number) {
    if (number < 2) {
      return false;
    } else if (number == 2) {
      return true;
    } else {
      for (int i = 2; i < number; i++){
        if (number % i == 0) {
          return false;
        }
      }
    }
    return true;
  }

  public ArrayList<Integer> onlyPrimes(int[] numbers) {
    // Declaring and initializing in one line:
    ArrayList<Integer> primes = new ArrayList<Integer>();
    for (int number : numbers) {
      if (this.isPrime(number)) {
       //System.out.println(number);//works
       primes.add(number);
      }
    }
    return primes;
  }
  
  public static void main(String[] args) {

    PrimeDirective pd = new PrimeDirective();
    int[] numbers = {6, 29, 28, 33, 11, 100, 101, 43, 89};
    System.out.println(pd.isPrime(7));
    System.out.println(pd.isPrime(28));
    System.out.println(pd.isPrime(2));
    System.out.println(pd.isPrime(0));
    System.out.println(pd.onlyPrimes(numbers));
  }  


}
