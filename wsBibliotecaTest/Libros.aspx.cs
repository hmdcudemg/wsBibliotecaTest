using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace wsBibliotecaTest
{
    public partial class Libros : System.Web.UI.Page
    {

        wsBiblioteca.webServiceDB wsBiblioteca = new wsBibliotecaTest.wsBiblioteca.webServiceDB();

        protected void Page_Load(object sender, EventArgs e)
        {
            lblBienvenida.Text = wsBiblioteca.bienvenida();
            cargarLibros();
        }

        private void cargarLibros()
        {
            DataSet dt = new DataSet();
            dt = wsBiblioteca.selectAll();
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (RadioButtonList1.SelectedIndex)
            {
                case 0:
                    lblResultado.Text = "";
                    pAñadir.Visible = true;
                    pActualizar.Visible = false;
                    pEliminar.Visible = false;
                    break;
                case 1:
                    lblResultado.Text = "";
                    pAñadir.Visible = false;
                    pActualizar.Visible = true;
                    pEliminar.Visible = false;

                    DropDownList1.DataSource = wsBiblioteca.selectISBN();
                    DropDownList1.DataValueField = "isbn";
                    DropDownList1.DataTextField = "isbn";
                    DropDownList1.DataBind();
                    break;
                case 2:
                    lblResultado.Text = "";
                    pAñadir.Visible = false;
                    pActualizar.Visible = false;
                    pEliminar.Visible = true;

                    DropDownList2.DataSource = wsBiblioteca.selectISBN();
                    DropDownList2.DataValueField = "isbn";
                    DropDownList2.DataTextField = "isbn";
                    DropDownList2.DataBind();
                    break;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Object[] updateLibros = new Object[6];
            updateLibros[0] = TextBox1.Text;
            updateLibros[1] = TextBox2.Text;
            updateLibros[2] = TextBox3.Text;
            updateLibros[3] = TextBox4.Text;
            updateLibros[4] = TextBox5.Text;
            updateLibros[5] = TextBox6.Text;

            lblResultado.Text = wsBiblioteca.update(updateLibros);
            Response.Redirect(Request.RawUrl);
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet dt = new DataSet();
            dt = wsBiblioteca.selectLibroByISBN(DropDownList1.SelectedValue);

            TextBox1.Text = dt.Tables[0].Rows[0]["isbn"].ToString();
            TextBox2.Text = dt.Tables[0].Rows[0]["nombreLibro"].ToString();
            TextBox3.Text = dt.Tables[0].Rows[0]["autorLibro"].ToString();
            TextBox4.Text = dt.Tables[0].Rows[0]["editorialLibro"].ToString();
            TextBox5.Text = dt.Tables[0].Rows[0]["edicionLibro"].ToString();
            TextBox6.Text = dt.Tables[0].Rows[0]["añoLibro"].ToString();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            lblResultado.Text = wsBiblioteca.delete(DropDownList2.SelectedValue);
            Response.Redirect(Request.RawUrl);
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Object[] insertLibros = new Object[6];
            insertLibros[0] = TextBox7.Text;
            insertLibros[1] = TextBox8.Text;
            insertLibros[2] = TextBox9.Text;
            insertLibros[3] = TextBox10.Text;
            insertLibros[4] = TextBox11.Text;
            insertLibros[5] = TextBox12.Text;

            if (!wsBiblioteca.insert(insertLibros))
            {
                lblResultado.Text = "Libro NO Añadido de forma correcta";
            }
            else
            {
                lblResultado.Text = "Libro Añadido de forma correcta";
            }
        }
    }
}