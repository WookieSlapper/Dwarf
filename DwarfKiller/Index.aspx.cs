using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DwarfKiller
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void OnCageChangeClick(object sender, EventArgs e)
        {
            var rnd = new Random();

            Cage1.Attributes["src"] = "http://placecage.com/c/" +
            (rnd.Next(1, 10) * 100).ToString() +
            "/" +
            (rnd.Next(1, 10) * 100).ToString();
        }
    }
}