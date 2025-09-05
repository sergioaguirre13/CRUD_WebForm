using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using CRUD.EntityLayer;
using CRUD.BusinessLayer;
using System.Globalization;

namespace CRUD.WEbForm
{
    public partial class Contact : Page
    {

        private static int idEmpleado = 0;
        DepartamentoBL departamentoBL = new DepartamentoBL();
        EmpleadoBL empleadoBL = new EmpleadoBL();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (Request.QueryString["idEmpleado"] != null)
                {
                    idEmpleado = Convert.ToInt32((Request.QueryString["idEmpleado"].ToString()));

                    if (idEmpleado != 0)
                    {
                        lblTitulo.Text = "Editar empleado";
                        btnSubmit.Text = "Actualizar";

                        Empleado empleado = empleadoBL.Obtener(idEmpleado);
                        txtNombreCompleto.Text = empleado.NombreCompleto;
                    }

                }
                else
                {
                    Response.Redirect("~/default.aspx");
                }
            }
        }

        private void CargarDepartamentos(string idDepartamento = "")
        {
            List<Departamento> lista = departamentoBL.lista();

            ddlDepartamento.DataTextField = "Nombre";
            ddlDepartamento.DataValueField = "IdDepartamento";

            ddlDepartamento.DataSource = lista;
            ddlDepartamento.DataBind();
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {

        }
    }
}