using System.Text.RegularExpressions;
using System;
using System.IO;

public class limpiaTexto{
    
    public static void Main(string[] args) {
        limpiaTexto.LimpiaJSON();
    }

    static public void LimpiaJSON(){
      string line = "",texto="";
      FileStream File = new FileStream("myfile1.txt", FileMode.Open, FileAccess.Read, FileShare.Read);
      using (StreamReader sr = new StreamReader("myfile1.txt")) {
            while ((line = sr.ReadLine()) != null) {
               texto+=line+"\n";
            }
         }

      string pattern = @"""alternatives"": \[\n [ ]*{\n [ ]*""confidence"": [\d]\.[\d]*, \n [ ]*""transcript"": ""((\w)*(\s))*(\w)*""\n[ ]*}\n(\s)* \], \n(\s)*""final"": true";
      string textoMedioLimpio="";
      foreach (Match match in Regex.Matches(texto, pattern)){
        if(match!=null){
         textoMedioLimpio=match.Value;
        }
      }
    
      string transcript= "";
      string patternTwo=@"""transcript"": ""((\w)*(\s))*(\w)*""";
      foreach (Match match in Regex.Matches(textoMedioLimpio, patternTwo)){
        if(match!=null){
         transcript=match.Value;
        }
      }

      string textoParaProcesar= "";
      string patternThree=@" ""((\w)*(\s))*(\w)*""";
      foreach (Match match in Regex.Matches(transcript, patternThree)){
        if(match!=null){
         textoParaProcesar=match.Value;
        }
      }
      Console.WriteLine(textoParaProcesar);

      // Write the string array to a new file named "WriteLines.txt".
      using (StreamWriter outputFile = new StreamWriter("textoPI.txt"))
      {
          outputFile.WriteLine(textoParaProcesar);
      }
    }
  }
