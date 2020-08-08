using System;
using System.Text.RegularExpressions;

namespace Song_Encryption
{
    class Program
    {
        static void Main(string[] args)
        {

            string pattern = @"^(?<artist>[A-Z][a-z'\s]+):(?<song>[A-Z\s]+)$";

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }

                if (Regex.IsMatch(input, pattern))
                {
                    char[] artist = Regex.Match(input, pattern).Groups["artist"].ToString().ToCharArray();
                    char[] song = Regex.Match(input, pattern).Groups["song"].ToString().ToCharArray();
                    int key = artist.Length;

                    //A-Z -> 65-90
                    //a-z -> 97-122

                    bool isLetter = false;

                    for (int i = 0; i < artist.Length; i++)
                    {
                        isLetter = (artist[i] >= 65 && artist[i] <= 90) || (artist[i] >= 97 && artist[i] <= 122);

                        if (isLetter)
                        {
                            artist[i] += (char)key;

                            if (artist[i] > 90 && artist[i] < 97)
                            {
                                artist[i] -= (char)26;
                            }

                            if (artist[i] > 122)
                            {
                                artist[i] -= (char)26;
                            }
                        }
                    }

                    for (int i = 0; i < song.Length; i++)
                    {
                        isLetter = (song[i] >= 65 && song[i] <= 90);

                        if (isLetter)
                        {
                            song[i] += (char)key;

                            if (song[i] > 90)
                            {
                                song[i] -= (char)26;
                            }
                        }
                    }

                    string encryptedArtist = string.Join("", artist);
                    string encryptedSong = string.Join("", song);

                    string encryptedData = string.Concat(encryptedArtist, "@", encryptedSong);

                    Console.WriteLine($"Successful encryption: {encryptedData}");
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }

            }

        }
    }
}
