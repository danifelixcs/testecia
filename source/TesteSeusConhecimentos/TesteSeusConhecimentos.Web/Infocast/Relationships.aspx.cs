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
    public partial class Relationships : System.Web.UI.Page
    {
        private readonly IRelationshipRepository _relationshipRepository;

        public Relationships()
        {
            _relationshipRepository = new RelationshipRepository();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                UpdateGridRelationships();
            }
        }

        private void UpdateGridRelationships()
        {
            var relationships = _relationshipRepository.GetAll();
            grdRelationships.DataSource = relationships;
            grdRelationships.DataBind();
        }

        protected void grdRelationships_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            var idRelationship = Convert.ToInt32(e.CommandArgument);

            switch (e.CommandName)
            {
                case ("Remove"):
                    _relationshipRepository.Delete(idRelationship);
                    UpdateGridRelationships();
                    break;
                case ("Edit"):
                    Response.Redirect("~/Infocast/InfoRelationship.aspx?id=" + idRelationship, true);
                    break;
            }
        }

        protected void btnNovo_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Infocast/InfoRelationship.aspx");
        }
    }
}