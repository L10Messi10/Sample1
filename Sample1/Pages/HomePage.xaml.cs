namespace Sample1.Pages;

public partial class HomePage : ContentPage
{
	public HomePage()
	{
		InitializeComponent();
	}

    private async void btnaddproduct_Clicked(object sender, EventArgs e)
    {
		await Navigation.PushModalAsync(new AddProductPage());
    }
}