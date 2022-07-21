using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using System.Text;
using Newtonsoft.Json;
using System.Web.UI.DataVisualization.Charting;

public partial class chart1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            GetChartData();
            //GetChartType();
        }

    }
    private void GetChartData()
    {
        string json = (new WebClient()).DownloadString("http://late.aashayweather.com/api/weather/Data.php?StationName=cwprs");
        var obj = JsonConvert.DeserializeObject<DataTable>(json);

        
        
        //string Timestamp = obj.Rows[0][0].ToString();
        //string AmbTemperature = obj.Rows[0][1].ToString();
        //string Humidity = obj.Rows[0][2].ToString();
        //string WindSpeed = obj.Rows[0][3].ToString();
        //string Winddirection = obj.Rows[0][4].ToString();
        //string SolarRadiation = obj.Rows[0][5].ToString();
        //string RainfalTodayTotal = obj.Rows[0][6].ToString();

        Series series = Chart2.Series["series"];
        series.Points.AddXY("AmbTemperature", obj.Rows[0][1].ToString());

        //Series series2 = Chart2.Series["series"];
        series.Points.AddXY("Humidity", obj.Rows[0][2].ToString());
       // Series series3 = Chart2.Series["series"];
        series.Points.AddXY("WindSpeed", obj.Rows[0][3].ToString());
       // Series series4 = Chart2.Series["series"];
        series.Points.AddXY("Winddirection", obj.Rows[0][4].ToString());
        //Series series5 = Chart2.Series["series"];
        series.Points.AddXY("SolarRadiation", obj.Rows[0][5].ToString());
        //Series series6 = Chart2.Series["series"];
        series.Points.AddXY("RainfalTodayTotal", obj.Rows[0][6].ToString());

        {

        }
    }
}