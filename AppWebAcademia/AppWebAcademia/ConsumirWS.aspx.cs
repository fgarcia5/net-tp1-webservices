using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Services;
using System.Xml;
using System.Data;


namespace AppWebAcademia
{
    public partial class ConsumirWS : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnGetUser_Click(object sender, EventArgs e)
        {
            lblMensaje.Visible = false;
            panelResponse.Visible = false;
            WSAcademia.WebServiceAcademia servicio = new WSAcademia.WebServiceAcademia();
            WSAcademia.Usuario user = new WSAcademia.Usuario();
            user = servicio.GetUser(int.Parse(txtID.Text));

            if(user.ID == 0)
            {
                lblMensaje.Visible = true;
                lblMensaje.Text = "El id ingresado no corresponde a algún usuario registrado";
            }
            else
            {
                panelResponse.Visible = true;
                cellApellido.Text = user.Apellido;
                cellEmail.Text = user.Email;
                cellID.Text = user.ID.ToString();
                cellNombre.Text = user.Nombre;
                cellNombreUsuario.Text = user.NombreUsuario;
                if(user.Habilitado)
                {
                    cellHabilitado.Text = "Sí";
                }
                else
                {
                    cellHabilitado.Text = "No";
                }
            }

            
            

        }


        protected void btnGetWeather_Click(object sender, EventArgs e)
        {
            lblMessage.Visible = false;
            panelWeather.Visible = false;
            WSWeather.Weather city = new WSWeather.Weather();
            WSWeather.WeatherReturn weather = city.GetCityWeatherByZIP(txtCD.Text);

            if(weather.ResponseText == "City Found")
            {
                panelWeather.Visible = true;
                lblMessage.Visible = false;
                //Llamada a WS para traer la imagen del idclima del objeto weather.
                WSWeather.WeatherDescription[] weatherDescription = city.GetWeatherInformation();
                
                for(int i = 0; i < weatherDescription.Length; i++)
                {
                    if(weatherDescription[i].WeatherID == weather.WeatherID)
                    {
                        ImgTiempo.ImageUrl = weatherDescription[i].PictureURL;
                        break;
                    }
                }

                txtCity.Text = weather.City;
                txtTiempo.Text = weather.Description;
                txtTemperature.Text = weather.Temperature;
                txtHumedad.Text = weather.RelativeHumidity;
            }
            else
            {
                lblMessage.Visible = true;
                panelWeather.Visible = false;
                lblMessage.Text = "La Ciudad especificada no se encuentra disponible";
            }
            
        }

        protected void btnGetGeoIP_Click(object sender, EventArgs e)
        {
            lblGeoIP.Text = "Consultando...";

            string ip = txtIP.Text;

            if (ip != "")
            {
                WSGeoIP.GeoIPService service = new WSGeoIP.GeoIPService();

                WSGeoIP.GeoIP geoIP = service.GetGeoIP(ip);

                lblGeoIP.Text = geoIP.CountryName;
            }
            else
            {
                lblGeoIP.Text = "Ingrese una dirección ip";
            }

            
        }

       

        

    }
}