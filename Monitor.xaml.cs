namespace CardioGuardMobile;


public partial class Monitor : ContentPage
{

	public string UserID { get; set; }

	public Monitor()
	{
		InitializeComponent();

		UserID = Preferences.Get(nameof(UserID), string.Empty);
	}

	private void OnBtnClicked(object sender, EventArgs args)
	{
		var value = int.Parse(TestEntry.Text);

		BPM.Text = value.ToString() + " BPM";
	}

    private void IDBtn_Clicked(object sender, EventArgs e)
    {
		UserID = TestEntry.Text;

		Preferences.Set(nameof(UserID), UserID);
    }
}

