<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Libros.aspx.cs" Inherits="wsBibliotecaTest.Libros" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="lblBienvenida" runat="server"></asp:Label>
        <br />
        <br />
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
        <br />
        <asp:RadioButtonList ID="RadioButtonList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged">
            <asp:ListItem Value="1">Añadir</asp:ListItem>
            <asp:ListItem Value="2">Actualizar</asp:ListItem>
            <asp:ListItem Value="3">Eliminar</asp:ListItem>
        </asp:RadioButtonList>
        <br />
        <asp:Label ID="lblResultado" runat="server"></asp:Label>
        <br />
        <asp:Panel ID="pAñadir" runat="server" GroupingText="Añadir" Visible="False">
            ISBN:<asp:TextBox ID="TextBox7" runat="server" Width="190px"></asp:TextBox>
            &nbsp;Nombre:<asp:TextBox ID="TextBox8" runat="server" Width="190px"></asp:TextBox>
            <br />
            Autor:<asp:TextBox ID="TextBox9" runat="server" Width="190px"></asp:TextBox>
            &nbsp;Editorial:<asp:TextBox ID="TextBox10" runat="server" Width="190px"></asp:TextBox>
            <br />
            Edicion:<asp:TextBox ID="TextBox11" runat="server" Width="100px"></asp:TextBox>
            &nbsp;Año:<asp:TextBox ID="TextBox12" runat="server" Width="100px"></asp:TextBox>
            <br />
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Añadir" />
        </asp:Panel>
        <br />
        <asp:Panel ID="pActualizar" runat="server" GroupingText="Actualizar" Visible="False">
            Seleccionar ISBN:<asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" Width="200px">
            </asp:DropDownList>
            <br />
            <br />
            ISBN:<asp:TextBox ID="TextBox1" runat="server" ReadOnly="True" Width="190px"></asp:TextBox>
            <br />
            Nombre:<asp:TextBox ID="TextBox2" runat="server" Width="190px"></asp:TextBox>
            &nbsp;Autor:<asp:TextBox ID="TextBox3" runat="server" Width="190px"></asp:TextBox>
            <br />
            Editorial:<asp:TextBox ID="TextBox4" runat="server" Width="190px"></asp:TextBox>
            &nbsp;Edicion:<asp:TextBox ID="TextBox5" runat="server" Width="100px"></asp:TextBox>
            <br />
            Año:<asp:TextBox ID="TextBox6" runat="server" Width="100px"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Actualizar" />
        </asp:Panel>
        <br />
        <asp:Panel ID="pEliminar" runat="server" GroupingText="Eliminar" Visible="False">
            Seleccionar ISBN a eliminar:<asp:DropDownList ID="DropDownList2" runat="server" Width="200px">
            </asp:DropDownList>
            &nbsp;<asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Eliminar" />
        </asp:Panel>
    
    </div>
    </form>
</body>
</html>
