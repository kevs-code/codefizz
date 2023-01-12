public class Language {
  protected String name;
  protected int numSpeakers;
  protected String regionsSpoken;
  protected String wordOrder;

  Language(String languageName, int speakers, String regSpoken, String wordOrd) {
    this.name = languageName;
    this.numSpeakers = speakers;
    this.regionsSpoken = regSpoken;
    this.wordOrder = wordOrd;
  }

  public void getInfo() {
  System.out.println(name + " is spoken by " + numSpeakers + " people mainly in " + regionsSpoken + ". The language follows the word order: " + wordOrder + ".");
  }

  public static void main(String[] args) {
      Language spanish = new Language("Spanish", 555000000, "Spain, Latin America, and Equatorial Guinea", "subject-verb-object");
      spanish.getInfo();
      Mayan kiche = new Mayan("K'iche'", 2330000);
      kiche.getInfo();
      SinoTibetan chinese = new SinoTibetan("Chinese", 1400000000);
      chinese.getInfo();
      SinoTibetan burmese = new SinoTibetan("Burmese", 54000000);
      burmese.getInfo();
  }
}
