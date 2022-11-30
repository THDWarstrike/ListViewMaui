namespace ListViewMaui;

public partial class MainPage : ContentPage
{
	List<string> animallist = new List<string>()
	{
		"Dog", "Rat", "Walrus","Llama","Hippopotamus", "Bear", "Tiger", "Lemur","Lion", "Megaladon"
	};

	public MainPage()
	{
		InitializeComponent();
		LvofAnimals.ItemsSource = animallist;
	}


}

