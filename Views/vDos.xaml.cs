namespace esanchezS3.Views;

public partial class vDos : ContentPage
{
	public vDos(string Dato1, string Dato2)
	{
		InitializeComponent();
		lblDato1.Text = "El dato uno es " + Dato1;
        lblDato2.Text = "El Dato dos es " + Dato2;
	}
}