using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TesteSeusConhecimentos.Domain;
using TesteSeusConhecimentos.Infra;

namespace TesteSeusConhecimentos.Web.Infocast
{
    public partial class Enterprises : System.Web.UI.Page
    {
        private readonly IEnterpriseRepository _enterpriseRepository;

        public Enterprises()
        {
            _enterpriseRepository = new EnterpriseRepository();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                UpdateGridEnterprises();
            }
        }

        protected void grdEnterprises_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            var idEnterprise = Convert.ToInt32(e.CommandArgument);

            switch (e.CommandName)
            {
                case ("Remove"):
                    _enterpriseRepository.Delete(idEnterprise);
                    UpdateGridEnterprises();
                    break;
                case ("Edit"):
                    Response.Redirect("~/Infocast/InfoEnterprise.aspx?id=" + idEnterprise, true);
                    break;
            }
        }
        protected void btnNovo_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Infocast/InfoEnterprise.aspx");
        }
        private void UpdateGridEnterprises()
        {
            var Enterprises = _enterpriseRepository.GetAll();
            grdEnterprises.DataSource = Enterprises.ToList();
            grdEnterprises.DataBind();
        }


    }
}