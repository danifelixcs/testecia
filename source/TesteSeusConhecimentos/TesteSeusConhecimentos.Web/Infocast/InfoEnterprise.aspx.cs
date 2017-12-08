using System;
using TesteSeusConhecimentos.Domain;
using TesteSeusConhecimentos.Entities;
using TesteSeusConhecimentos.Infra;

namespace TesteSeusConhecimentos.Web.Infocast
{
    public partial class InfoEnterprise : System.Web.UI.Page
    {
        private readonly IEnterpriseRepository _enterpriseRepository;

        private int IdEnterprise
        {
            set { ViewState["idEnterprise"] = value; }
            get
            {
                return ViewState["idEnterprise"] != null ? Convert.ToInt32(ViewState["idEnterprise"]) : 0;
            }
        }

        public InfoEnterprise()
        {
            this._enterpriseRepository = new EnterpriseRepository();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;
            SetViewStateEnterprise();
            UpdateForm();
        }

        private void SetViewStateEnterprise()
        {
            IdEnterprise = Request.QueryString["id"] != null ? Convert.ToInt32(Request.QueryString["id"]) : 0;
        }

        private void UpdateForm()
        {
            var enterprise = this._enterpriseRepository.GetById(IdEnterprise);

            if (enterprise == null) return;
            formStatus.InnerText = "Editar Empresa";
            txtAddress.Text = enterprise.StreetAddress;
            txtCity.Text = enterprise.City;
            txtZipCode.Text = enterprise.ZipCode;
            txtCorporateActivity.Text = enterprise.CorporateActivity;
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            var enterprise = new Enterprise(IdEnterprise, txtAddress.Text, txtCity.Text, txtZipCode.Text, txtCorporateActivity.Text);
            _enterpriseRepository.Save(enterprise);

            Response.Redirect("~/Infocast/Enterprises.aspx");
        }
    }
}