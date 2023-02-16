using System;
using System.Collections.Generic;
using System.IO;
//stores scriptures and used to get scriptures
public class Reference
{
    // read from file, store in dictionary
    //has getter to take out dictionary.
    private static readonly string Path = "scriptures.txt";
    private Dictionary<List<string>, string> _singleScriptsDico;
    private Dictionary<string[], Dictionary<string[], string[]>> _multiScriptsDico;
    //private List<List<string>> _listOfReferenceLists;
    private Dictionary<string[], string[]> verseMultiple = new Dictionary<string[], string[]>();
    public Reference()
    {
        _singleScriptsDico = new Dictionary<List<string>, string>();
        _multiScriptsDico = new Dictionary<string[], Dictionary<string[], string[]>>();
        //_listOfReferenceLists = new List<List<string>>();

        string[] lines = File.ReadAllLines(Path);

        foreach (string line in lines)
        {
            string[] words = line.Split(' ');
            if (words.Length <= 1)
            {
                continue;
            }

            List<string> referencedScripture = new List<string> { words[0], words[1] };//[Book, Chapter Number:Verses]
            //_listOfReferenceLists.Add(referencedScripture);

            List<string> wholeText = new List<string>(words.Skip(2));

            string[] chapterVerses = words[1].Split(":");//[Chapter Number, Verse Numbers]
            string[] startEndVerse = chapterVerses[1].Contains("-")
                            ? chapterVerses[1].Split("-")//[Start Verse, End Verse]
                            : new string[0];
            
            string wholeTextString = string.Join(" ", wholeText);
            string[] splitedVerses = wholeTextString.Contains("^")
                            ? wholeTextString.Split("^")// list of multiple verses of one chapter
                            : new string[0];

            if (chapterVerses[1].Contains("-"))//if there are multiple verses
            {
                string[] refMultiple = {words[0], chapterVerses[0]};
                verseMultiple.Add(startEndVerse, splitedVerses);
                _multiScriptsDico.Add(refMultiple, verseMultiple);
            }
            else
            {
                _singleScriptsDico.Add(referencedScripture, wholeTextString);
            }
            
        }
    }

    public Dictionary<List<string>, string> GetSingleScripts()
    {
        return _singleScriptsDico;
    }
    public Dictionary<string[], Dictionary<string[], string[]>> GetMultiScripts()
    {
        return _multiScriptsDico;
    }
}