namespace PIN_Checking;

public partial class MainPage : ContentPage
{
	private const string Right_PIN = "1545";
	private bool PIN_is_Correct = false;

	public MainPage()
	{
		InitializeComponent();
	}

	public void Digit_Clicked(object sender, EventArgs e)
	{
		if (PIN_is_Correct) return;
		DisplayLabel.Text += (sender as Button).Text;
	}

	public void Reset_CLicked(object sender, EventArgs e)
	{
        if (PIN_is_Correct) return;
        DisplayLabel.Text = "";
	}

	public void Check_Clicked(object sender, EventArgs e)
	{
        if (PIN_is_Correct) return;
		if (Convert.ToString(DisplayLabel.Text) == Right_PIN)
		{
            DisplayLabel.Text = "Верно!";
			PIN_is_Correct = true;
        }
		else DisplayLabel.Text = "";
    }
}

