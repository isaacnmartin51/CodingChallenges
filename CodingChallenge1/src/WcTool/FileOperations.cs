namespace CC.WcTool;

internal static class FileOperations
{
       internal static int GetWordCount(string filePath)
       {
          int wordCount = 0;

          using(StreamReader sr = new StreamReader(filePath))

          while(!sr.EndOfStream)
          {
               var line = sr.ReadLine();
               var words = line.Split(" ");
               wordCount += words.Where(w => !string.IsNullOrWhiteSpace(w)).Count();
          }
          return wordCount;
       }

       internal static int GetLineCount(string filePath)
       {
            return File.ReadAllLines(filePath).Count();
       }

       internal static int GetByteCount(string filePath)
       {
            return File.ReadAllBytes(filePath).Count();
       }
}