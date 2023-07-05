namespace Ejercicio3;

public partial class MainPage : ContentPage
{

    public MainPage()

    {

        InitializeComponent();

    }

    ///<Summary>
    ///<Createddate>05-07-2023</createddate>
    ///<company>SandBox</company>
    ///<lastmodificationdate>05-07-2023</lastmodificationdate>
    ///<lastmodificationdescription>Ninguna</lastmodificationdescription>
    ///<lastmodifierautor>Nery</lastmodifierautor>
    ///</Summary>

    private void OnCounterClicked(object sender, EventArgs e)

    {

        // Creamos las variables C1, C2, C3, C4, C5 y la variable Promedio que almacenara el resultado la la suma y division entre 5 de las varibles C //

        decimal C1 = decimal.Parse(C1Entry.Text);

        decimal C2 = decimal.Parse(C2Entry.Text);

        decimal C3 = decimal.Parse(C3Entry.Text);

        decimal C4 = decimal.Parse(C4Entry.Text);

        decimal C5 = decimal.Parse(C5Entry.Text);

        decimal Promedio = (C1 + C2 + C3 + C4 + C5) / 5;

        Resultado.Text = Promedio.ToString();

    }
}

