public class DNA {

  public static void main(String[] args) {
    //return true if strand of DNA
    //  -. .-.   .-. .-.   .
    //    \   \ /   \   \ / 
    //   / \   \   / \   \  
    //  ~   `-~ `-`   `-~ `-


    String dna1 = "ATGCGATACGCTTGA";
    String dna2 = "ATGCGATACGTGA";
    String dna3 = "ATTAATATGTACTGA";
    String dna = dna1;
    System.out.println(dna.length());
    int atgIndex = dna.indexOf("ATG");
    int tgaIndex = dna.indexOf("TGA");
    String middle = dna.substring(atgIndex + 3, tgaIndex);
    System.out.println(atgIndex);
    System.out.println(tgaIndex);
    if (atgIndex != -1 && tgaIndex != -1 && middle.length() % 3 == 0) {
        System.out.println(dna + " Contains protein");
    } else {
        System.out.println(dna + " No protein");
    }

  }

}
/*
This works ...
You are all done!

Let’s test your code with each DNA strand. These should be the results:

dna1: Contains a protein.
dna2: Does not contain a protein.
dna3: Contains a protein.

*/
