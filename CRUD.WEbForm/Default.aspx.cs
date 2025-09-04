﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using CRUD.EntityLayer;
using CRUD.BusinessLayer;

namespace CRUD.WEbForm
{
    public partial class _Default : Page
    {
        EmpleadoBL empleadoBL = new EmpleadoBL();

        protected void Page_Load(object sender, EventArgs e)
        {
            MostrarEmpleados();
        }

        private void MostrarEmpleados()
        {
            List<Empleado> lista = empleadoBL.lista();

            GVEmpleado.DataSource = lista;
            GVEmpleado.DataBind();
        }

        protected void Nuevo_Click(Object sender,EventArgs e)
        {
            Response.Redirect("~/Contact.aspx?idEmpleado=0");
        }

        protected void Editar_Click(Object sender, EventArgs e)
        {
            LinkButton btn = (LinkButton)sender;
            string idEmpleado = btn.CommandArgument;


            Response.Redirect($"~/Contact.aspx?idEmpleado={idEmpleado}");
        }
    }
}