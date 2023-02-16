using System.Linq;
using System;
using System.Text;

public class Word
{
    private Dictionary<List<string>, string> _singleScripts;
    private Dictionary<string[], Dictionary<string[], string[]>> _multiScripts;
    private List<string> _oneLine;
    public Word()
    {
        Reference reference = new Reference();
        _singleScripts = reference.GetSingleScripts();
        _multiScripts = reference.GetMultiScripts();
        
    }

    public string Show()
    {
        Random randomVerses = new Random();
        int singleOrMulti = randomVerses.Next(1,3);
        int randomScripture = randomVerses.Next(0, _singleScripts.Count()); 
        if (singleOrMulti == 2)
        {
            int randomMultiScript = randomVerses.Next(0, _multiScripts.Count);
            var randomScript = _multiScripts.ElementAt(randomMultiScript);

            _oneLine = new List<string>();
            string bookOfProphet = randomScript.Key[0];
            string chapterOfBook = randomScript.Key[1];
            string verse = "";
            string miniVerse = "";
            int beginVerse = 0;
            int endVerse = 0;
            string titre = $"{bookOfProphet} {chapterOfBook}:\n";
            foreach (KeyValuePair<string[], string[]> versesAndText in randomScript.Value)
            {
                beginVerse = int.Parse(versesAndText.Key[0]);
                endVerse = int.Parse(versesAndText.Key[1]);
                foreach (string verselet in versesAndText.Value)
                {
                    miniVerse = string.Join(" ",beginVerse, verselet);
                    _oneLine.Add(miniVerse);
                    beginVerse++;
                }
                verse = string.Join("", _oneLine);
                _oneLine.Clear(); // add this line to clear the list
            }
            string wholeScripture = titre + verse;
            //Console.WriteLine(wholeScripture);
            return wholeScripture;
        }
        else
        {
            _oneLine = new List<string>();   
            foreach (KeyValuePair<List<string>, string> script in _singleScripts)
            {
                string keyString = string.Join(" ", script.Key);
                string valueString = script.Value;
                
                _oneLine.Add($"{keyString} {valueString}");
            }
            //Console.WriteLine(_oneLine[randomScripture]);
            return _oneLine[randomScripture];
        }
    }
    
    public string Hide(string textToHide)
    {
        string[] words = textToHide.Split(' ');

        // Keep track of replaced word indices
        HashSet<int> replacedWordIndices = new HashSet<int>();

        Random rnd = new Random();

        
        for (int i = 2; i < words.Length && replacedWordIndices.Count < 3; i++)
        {
            // Choose a random word index that hasn't been replaced yet
            int wordIndex = -1;
            do
            {
                wordIndex = rnd.Next(2, words.Length);
            } while (replacedWordIndices.Contains(wordIndex));
            replacedWordIndices.Add(wordIndex);

            string wordToReplace = words[wordIndex];
            string replacedWord = new string('-', wordToReplace.Length);

            words[wordIndex] = replacedWord;
        }

        string result = string.Join(" ", words);
        //Console.WriteLine(result);
        return result;
    }
}