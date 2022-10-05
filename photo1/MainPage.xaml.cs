namespace photo1;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
        InitializeComponent();
		img1.Source = "dotnet_bot.png";
	}

	private async void OnCounterClicked(object sender, EventArgs e)
	{
		try
		{
            var newImg = await MediaPicker.CapturePhotoAsync(new MediaPickerOptions { Title = "Take the shot" });
            //var newImg = await MediaPicker.CapturePhotoAsync(null);
            img1.Source = newImg?.FullPath;
        }
		catch 
		{
			img1.Source = "dotnet_bot.png";
		}
	}
}

