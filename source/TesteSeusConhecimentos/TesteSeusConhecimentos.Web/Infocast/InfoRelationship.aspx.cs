using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TesteSeusConhecimentos.Domain;
using TesteSeusConhecimentos.Entities;
using TesteSeusConhecimentos.Infra;

namespace TesteSeusConhecimentos.Web.Infocast
{
    public partial class InfoRelationship : System.Web.UI.Page
    {
        private readonly IRelationshipRepository _relationshipRepository;
        private readonly IEnterpriseRepository _enterpriseRepository;
        private readonly IUserRepository _userRepository;

        private int IdRelationship
        {
            set { ViewState["idRelationship"] = value; }
            get
            {
                return ViewState["idRelationship"] != null ? Convert.ToInt32(ViewState["idRelationship"]) : 0;
            }
        }

        public InfoRelationship()
        {
            this._relationshipRepository = new RelationshipRepository();
            this._enterpriseRepository = new EnterpriseRepository();
            this._userRepository = new UserRepository();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;
            SetViewStateRelationship();
            FillDropDownLists();
            UpdateForm();
        }

        private void SetViewStateRelationship()
        {
            IdRelationship = Request.QueryString["id"] != null ? Convert.ToInt32(Request.QueryString["id"]) : 0;
        }

        private void FillDropDownLists()
        {
            var enterprises = _enterpriseRepository.GetAll();
            ddlEnterprise.DataTextField = "CorporateActivity";
            ddlEnterprise.DataValueField = "Id";
            ddlEnterprise.DataSource = enterprises;
            ddlEnterprise.DataBind();

            var users = _userRepository.GetAll();
            ddlUser.DataTextField = "Name";
            ddlUser.DataValueField = "Id";
            ddlUser.DataSource = users;
            ddlUser.DataBind();
        }
        private void UpdateForm()
        {
            var relationship = this._relationshipRepository.GetById(IdRelationship);

            if (relationship == null) return;
            formStatus.InnerText = "Editar Relacionamento";
            ddlEnterprise.SelectedValue = relationship.IdEnterprise.ToString();
            ddlUser.SelectedValue = relationship.IdUser.ToString();
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            var Relationship = new Relationship(IdRelationship, int.Parse(ddlEnterprise.SelectedValue), int.Parse(ddlUser.SelectedValue));
            _relationshipRepository.Save(Relationship);

            Response.Redirect("~/Infocast/Relationships.aspx");
        }
    }
}