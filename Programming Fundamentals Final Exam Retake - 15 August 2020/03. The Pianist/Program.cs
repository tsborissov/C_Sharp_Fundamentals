using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._The_Pianist
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPieces = int.Parse(Console.ReadLine());

            Dictionary<string, Piece> piecesCollection = new Dictionary<string, Piece>();

            for (int i = 0; i < numberOfPieces; i++)
            {
                string[] pieceInput = Console.ReadLine().Split('|').ToArray();

                string pieceName = pieceInput[0];
                string composer = pieceInput[1];
                string key = pieceInput[2];

                if (!piecesCollection.ContainsKey(pieceName))
                {
                    piecesCollection.Add(pieceName, new Piece());
                    
                    piecesCollection[pieceName].Name = pieceName;
                    piecesCollection[pieceName].Composer = composer;
                    piecesCollection[pieceName].Key = key;
                }
            }

            while (true)
            {
                string commandInput = Console.ReadLine();
                if (commandInput == "Stop")
                {
                    break;
                }

                string[] command = commandInput.Split('|').ToArray();

                switch (command[0])
                {
                    case "Add":

                        string pieceToAdd = command[1];
                        string composerToAdd = command[2];
                        string keyToAdd = command[3];

                        if (!piecesCollection.ContainsKey(pieceToAdd))
                        {
                            piecesCollection.Add(pieceToAdd, new Piece());

                            piecesCollection[pieceToAdd].Name = pieceToAdd;
                            piecesCollection[pieceToAdd].Composer = composerToAdd;
                            piecesCollection[pieceToAdd].Key = keyToAdd;

                            Console.WriteLine($"{pieceToAdd} by {composerToAdd} in {keyToAdd} added to the collection!");
                        }
                        else
                        {
                            Console.WriteLine($"{pieceToAdd} is already in the collection!");
                        }

                        break;

                    case "Remove":

                        string pieceToRemove = command[1];

                        if (piecesCollection.ContainsKey(pieceToRemove))
                        {
                            piecesCollection.Remove(pieceToRemove);
                            Console.WriteLine($"Successfully removed {pieceToRemove}!");
                        }
                        else
                        {
                            Console.WriteLine($"Invalid operation! {pieceToRemove} does not exist in the collection.");
                        }

                        break;

                    case "ChangeKey":

                        string pieceToChange = command[1];
                        string newKey = command[2];

                        if (piecesCollection.ContainsKey(pieceToChange))
                        {
                            piecesCollection[pieceToChange].Key = newKey;

                            Console.WriteLine($"Changed the key of {pieceToChange} to {newKey}!");
                        }
                        else
                        {
                            Console.WriteLine($"Invalid operation! {pieceToChange} does not exist in the collection.");
                        }

                        break;
                }
            }

            foreach (var piece in piecesCollection.OrderBy(x => x.Key).ThenBy(x => x.Value.Composer))
            {
                Console.WriteLine($"{piece.Key} -> Composer: {piece.Value.Composer}, Key: {piece.Value.Key}");
            }
        }
    }

    class Piece
    {
        public string Name { get; set; }
        public string Composer { get; set; }
        public string Key { get; set; }
    }
}
