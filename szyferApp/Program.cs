string text; //tekst do zaszyfrowania
int key; //klucz - ilosc znakow przesuniecia


string asciiCaesar(string t)
{
    t = t.ToUpper();
    string encryptedText = ""; //zaszyfrowany tekst
    for (int i = 0; i < t.Length; i++)
    {
        char letter = t[i];
        int letterCode = (int)letter;
        letterCode += key;
        letterCode = ((letterCode - 65) % 26) + 65;
        char encryptedLetter = (char)letterCode;
        encryptedText += encryptedLetter;
    }
    return encryptedText;
}

Console.WriteLine("Podaj tekst do zaszyfrowania");
text = Console.ReadLine() ?? "";
Console.WriteLine("Podaj klucz (wartość przesunięcia):");
key = int.Parse(Console.ReadLine() ?? "");



Console.WriteLine("Szyfrowanie ASCII: " + asciiCaesar(text));


