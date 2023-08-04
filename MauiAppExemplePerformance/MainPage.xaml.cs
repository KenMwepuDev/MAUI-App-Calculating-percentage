namespace MauiAppExemplePerformance;

public partial class MainPage : ContentPage
{
    int count = 0;

    public MainPage()
    {
        InitializeComponent();
    }

    private void InputMontant_TextChanged(object sender, TextChangedEventArgs e)
    {
        try
        {
            InputPourcente.Text = (Math.Round((Convert.ToDouble(InputMontant.Text) / Convert.ToDouble(InputMainValue.Text)) * 100, 2)).ToString();
        }
        catch (Exception)
        {
            InputPourcente.Text = string.Empty;
        }
    }

    private void InputPourcente_TextChanged(object sender, TextChangedEventArgs e)
    {
        try
        {

            InputMontant.Text = (Math.Round(((Convert.ToDouble(InputPourcente.Text)) * (Convert.ToDouble(InputMainValue.Text))) / 100)).ToString();
        }
        catch (Exception)
        {
            InputMontant.Text = string.Empty;
        }
    }

    private void ResetValue_Clicked(object sender, EventArgs e) => InputMontant.Text = InputMainValue.Text = string.Empty;
}

