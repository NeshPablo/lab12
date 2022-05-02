<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Laboratorio_12._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Ingreso de Alumnos</h1>
        <p>Universidad:&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem>Mesoamericana</asp:ListItem>
                <asp:ListItem>Landivar</asp:ListItem>
            </asp:DropDownList>
        </p>
        <p>Alumnos:</p>
        <p>Carne:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </p>
        <p>Nombre:&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </p>
        <p>Apellido:&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        </p>
        <p>Notas:</p>
        <p>Curso:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txt_Curso" runat="server"></asp:TextBox>
        </p>
        <p>Punteo:&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txt_punteo" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" Text="Agregar Nota" OnClick="Button1_Click" />
        </p>
        <p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" Text="Agregar Alumno a la Universidad" OnClick="Button2_Click"  />
        </p>
        <p>
            <asp:Button ID="Button3" runat="server" Text="Agregar Universidad con sus Alumnos" OnClick="Button3_Click"  />
        </p>
    </div>

    <div class="row">
    </div>

</asp:Content>
