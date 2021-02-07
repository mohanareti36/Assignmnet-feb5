using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;

namespace DropDownWeb
{
    public partial class CountryDDl : System.Web.UI.Page
    {
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings[1].ToString());

        public void Country()
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand("select country,countryid from country", cn);

            SqlDataReader dr = cmd.ExecuteReader();
            ConDDl.DataSource = dr;
            ConDDl.Items.Clear();
            ConDDl.Items.Add("--Please select country--");
            ConDDl.DataTextField = "country";
            ConDDl.DataValueField = "countryid";
            ConDDl.DataBind();
            cn.Close();
        }
        public void State()
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand("select states,stateid from countrystates where countryid='" + ConDDl.SelectedValue + "'", cn);

            SqlDataReader dr = cmd.ExecuteReader();
            StateDDl.DataSource = dr;
            StateDDl.Items.Clear();
            StateDDl.Items.Add("--Please select the state--");
            StateDDl.DataTextField = "states";
            StateDDl.DataValueField = "stateid";
            StateDDl.DataBind();
            cn.Close();
        }

        public void City()
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand("select city,cityid from city where stateid='" + StateDDl.SelectedValue + "'", cn);
            SqlDataReader dr = cmd.ExecuteReader();
            CityDDl.DataSource = dr;
            CityDDl.Items.Clear();
            CityDDl.Items.Add("--please select city--");
            CityDDl.DataTextField = "city";
            CityDDl.DataValueField = "cityid";
            CityDDl.DataBind();
            cn.Close();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Country();
            }
        }

        protected void ConDDl_SelectedIndexChanged(object sender, EventArgs e)
        {
            State();
        }

        protected void StateDDl_SelectedIndexChanged(object sender, EventArgs e)
        {
            City();
        }
    }
}