namespace esanchezS3.Views;

public partial class vUno : ContentPage
{
	//variables globales
	string usuarioglobal = "a";
	string contrasglobal;
	public vUno()
	{
		InitializeComponent();
	}
	
	public vUno(string usuarioacceso, string contrasenaacceso)
	{
        InitializeComponent();
		usuarioglobal = usuarioacceso;
		contrasglobal = contrasenaacceso;
    }

    private void btnAbrir_Clicked(object sender, EventArgs e)
    {
		try
		{
			//datos de acceso
            string usuario = txtUsuario.Text;
			string contrasena = txtContrasena.Text;

			if (usuario == usuarioglobal && contrasena == contrasglobal)
			{
				Navigation.PushAsync(new vDos(usuario, contrasena));
			}
			else
			{
				DisplayAlert("ERROR","Usuario o Contraseña Incorrectos","OK");
			}
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);
		}
    }

    private void btnRegistro_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new vTres());
    }
}