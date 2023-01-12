class Mayan extends Language {
  Mayan(String languageName, int speakers) {
    //set super with parent constructor and some defaults
    super(languageName, speakers, "Central America", "verb-object-subject");
  }
  @Override
  public void getInfo() {
  System.out.println(name + " is spoken by " + numSpeakers + " people mainly in " + regionsSpoken + ". The language follows the word order: " + wordOrder + "\nFun fact: " + name + " is an ergative language.");
  }
  

}
