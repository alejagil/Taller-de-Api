using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TallerApi.Xamarin.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TallerApi.Xamarin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PublicacionPage : ContentPage
    {
        public PublicacionPage()
        {
            InitializeComponent();
            CargarPublicaciones();
        }

        private async Task CargarPublicaciones()
        {
            HttpClient cliente = new HttpClient();

            //Se especifica el sitio al cual se le realizaran los request
            cliente.BaseAddress = new Uri("http://172.28.119.193"); 

            var request = await cliente.GetAsync("/Publicacion/Api/Publicacion");
            if (request.IsSuccessStatusCode)
            {
                var responseJson = await request.Content.ReadAsStringAsync();
                var respuesta = JsonConvert.DeserializeObject<List<Publicacion>>(responseJson);
                listPublicacion.ItemsSource = respuesta;
            }

          
        }

        private void Publicacion_Seleccionado(object sender, SelectedItemChangedEventArgs e)
        {
            var publicacion = e.SelectedItem as Publicacion;
            DisplayAlert(publicacion.Usuario, "Cantidad de me gusta: " + publicacion.MeGusta, "continuar");
        }        
    }
}