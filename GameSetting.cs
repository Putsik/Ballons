using System;
using System.Drawing;

namespace Ballons
{
    ///////////////////////////////////////////////////////////////////////////
    //    Moduł ustawienia aplikacji i zmiennych globalnych.
    ///////////////////////////////////////////////////////////////////////////


    // Dane globalne aplikacji.
    public class Global
    {
        public const int AmountColorBalls = 3; // Liczba grafelemenów kolorów
        public const int NumGraphItems = 100;  // Liczba grafelemenów
        public const int NumPlayers = 6;       // Liczba zapamiętających graczej z nagrodami
    }


    // Do przechowywania i zapis ustawień do pliku binarnego. 
    // Należy ustawić atrybut [Serializable] 
    [Serializable]
    class GameSetting
    {
        public GameSetting()
        {
            // Inicjalizacja rekord graczy.
            for (int i = 0; i < DRH.Length; i++)
            {
                DRH[i] = new DataRecordsman();
            }

            // kolory grafelementów są domyślnie.
            GraphItems = new Color[] { Color.DeepPink, Color.DeepSkyBlue, Color.Gold };
        }

        // Przechowywanie tablicy graczej. 
        public DataRecordsman[] DRH = new DataRecordsman[Global.NumPlayers];

        // Tablica zachowania kolorów grafelementów.
        public Color[] GraphItems = null;

        // Tryb działania aplikacji.
        public bool FullScreen = false;

        // Rozmiar i położenie okna aplikacji.
        public Rectangle Bounds;

        // Wpisz grafèlementa (balon, prostokąt, romb).
        public GraphItem.TypeGraphItem CurrentGraphItem;
    }

    // Klasa danych z najlepszych graczy, przygotowane  
    // do serializacji (Zapisz plik).
    [Serializable]
    public class DataRecordsman
    {
        public int Score = 0; // punkty
        public string Name = null; // imię gracza
        public bool CurrentPlayer = false; // bieżący gracz
    }

}
