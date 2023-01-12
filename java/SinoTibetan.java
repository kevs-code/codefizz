class SinoTibetan extends Language {
  SinoTibetan(String languageName, int speakers) {
    //set super with parent constructor and some default
    super(languageName, speakers, "Asia", "subject-object-verb");
    if (this.name.indexOf("Chinese") != -1 ) {
      this.wordOrder ="subject-verb-object";
    }
  }
}
