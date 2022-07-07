foreach (string numer in args)
{
    bool isStrobogramatyczny = true;
    for (int j = 0; j <= numer.Length / 2; j++)
    {
        isStrobogramatyczny = numer[j] switch
        {
            '0' or '8' or '1' => numer[j] == numer[numer.Length - 1 - j],
            '6' => numer[numer.Length - 1 - j] == '9',
            '9' => numer[numer.Length - 1 - j] == '6',
            '2' => numer[numer.Length - 1 - j] == '5',
            '5' => numer[numer.Length - 1 - j] == '2',
            _ => false,
        };
        if (!isStrobogramatyczny)
            break;
    }
    if (isStrobogramatyczny)
    {
        bool isPierwsza = true;
        int liczba = Convert.ToInt32(numer);
        for (int i = 2; i < Math.Sqrt(liczba); i++)
        {
            if (liczba % i == 0)
            {
                isPierwsza = false;
                break;
            }
        }
        Console.WriteLine("Liczba " + numer + (isStrobogramatyczny ? " " : " nie ") + "jest strobogramatyczna" + (isPierwsza ? " i pierwsza! " : "!"));
    }
    else
        Console.WriteLine("Liczba " + numer + (isStrobogramatyczny ? " " : " nie ") + "jest strobogramatyczna!");
}