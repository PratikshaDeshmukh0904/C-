using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Net;
using System.IO;
using System.Text;

public partial class _Default : System.Web.UI.Page
{
 
    private void connection()
    {
      
    }
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnsave_Click(object sender, EventArgs e)
    {
        string Name = Request.Form["txtname"];
        string Address = Request.Form["txtraddress"];
        string Email = Request.Form["txtemail"];


        HttpWebRequest request = WebRequest.Create("http://hydromet.cwprsaws.co.in/delete.php?Name=" + Name + "& Address= " + Address + "& Email=" + Email + "") as HttpWebRequest;
        HttpWebResponse response = request.GetResponse() as HttpWebResponse;
        Stream stream = response.GetResponseStream();
        WebHeaderCollection header = response.Headers;
        string responseText = null;
        var encoding = ASCIIEncoding.ASCII;
        using (var reader = new System.IO.StreamReader(response.GetResponseStream(), encoding))
        {
            responseText = reader.ReadToEnd();
        }
        if (responseText == "delete Success")
        {
            Response.Write("<script>alert('delete successful')</script>");
        }
        else
        {
            Response.Write("<script>alert('delete not successful')</script>");
        }



    }



    //  SqlConnection con = new SqlConnection(constr);
    //  con.Open();
    //     SqlCommand cmd = new SqlCommand("insert into shri(Name,Address,Email) values ('" + txtname.Text + "','" + txtaddress.Text + "','" + txtemail.Text + "'", con);
    //  cmd.ExecuteNonQuery();
    //  con.Close();

}
