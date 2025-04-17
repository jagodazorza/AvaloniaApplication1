using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Metadata;
using System.Collections.Generic;
using System.Text;

namespace AvaloniaApplication1.Views;

public partial class MainView : UserControl
{
    public MainView()
    {
        InitializeComponent();
    }

    public void DNA(string s)
    {
        if (s is null) return;
        
        List<string> list = new List<string>();
       

        for (int i = 0; i <= s.Length - 4; i++)
        {
            list.Add(s.Substring(i, 4));
        }


        List<int> licznik = new List<int>(new int[list.Count]);


        for (int i = 0; i < list.Count; i++)
        {
            licznik[i]++;
            for (int j = 0; j < list.Count; j++)
            {
                if (list[i] == list[j] && i!=j)
                {
                    licznik[i]++;
                }
            }
        }

      


        StringBuilder wynikBuilder = new StringBuilder();

        for (int i = 0; i < list.Count; i++)
        {
            wynikBuilder.Append(i+1 + ". " + list[i] + ": " + licznik[i] + "\n");
        }
        string wynik = wynikBuilder.ToString();

        DNA_Output.Text = wynik;
    }

    public void ButtonClicked(object? sender, RoutedEventArgs e)
    {
        string sekwencja = TekstBox.Text;
        DNA(sekwencja);
    }
}
