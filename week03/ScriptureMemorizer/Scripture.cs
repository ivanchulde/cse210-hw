public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        string[] words = text.Split(' ');
        foreach (string word in words)
        {
            _words.Add(new Word(word));
        }
    }
    public void HideRandomWords(int numberToHide)
    {
        var random = new Random();

        // Obtener todas las palabras visibles
        var visibleWords = _words.Where(w => !w.IsHidden()).ToList();

        // Si hay menos palabras visibles de las que se quieren ocultar, solo ocultar las que quedan
        numberToHide = Math.Min(numberToHide, visibleWords.Count);

        int countHidden = 0;
        while (countHidden < numberToHide)
        {
            int index = random.Next(visibleWords.Count);
            if (!visibleWords[index].IsHidden())
            {
                visibleWords[index].Hide();
                countHidden++;
            }
        }
    }
    public string GetDisplayText()
    {
        List<string> displayWords = new List<string>();
        foreach (Word word in _words)
        {
            displayWords.Add(word.GetDisplayText());
        }
        return string.Join(" ", displayWords);
    }
    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
                return false;
        }
        return true;
    }
}