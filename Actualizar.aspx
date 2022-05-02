<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Actualizar.aspx.cs" Inherits="Laboratorio_12.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p style="font-size: xx-large">
        Actualizar</p>
    <p style="font-size: medium">
        Carne:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    </p>
    <p style="font-size: medium">
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="font-size: large" Text="Buscar Alumno" />
    </p>
    <p style="font-size: medium">
        Nombre:&nbsp;&nbsp;
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    </p>
    <p style="font-size: medium">
        Apellido:&nbsp;&nbsp;
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
    </p>
    <p style="font-size: medium">
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" style="font-size: large" Text="Editar Alumno" />
    </p>
</asp:Content>
