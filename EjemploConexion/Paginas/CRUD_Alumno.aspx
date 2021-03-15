<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CRUD_Alumno.aspx.cs" Inherits="EjemploConexion.Paginas.CRUD_Alumno" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 145px;
        }
        .auto-style2 {
            width: 145px;
            height: 40px;
        }
        .auto-style3 {
            height: 40px;
        }
        .auto-style4 {
            height: 40px;
            width: 680px;
        }
        .auto-style5 {
            width: 680px;
        }
        .auto-style6 {
            width: 145px;
            height: 24px;
        }
        .auto-style7 {
            height: 24px;
            width: 680px;
        }
        .auto-style8 {
            height: 24px;
        }
        .auto-style9 {
            width: 141px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="CRUD Alumno"></asp:Label>
            <br />
            <br />
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Refrescar Pagina" />
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Crear Alumno"></asp:Label>
            <br />
            <br />
            <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Crear" Width="160px" />
            <br />
            <table style="width:100%;">
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label5" runat="server" Text="Nombre"></asp:Label>
                    </td>
                    <td class="auto-style4">
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style3"></td>
                </tr>
                <tr>
                    <td class="auto-style6">
                        <asp:Label ID="Label6" runat="server" Text="Carnet"></asp:Label>
                    </td>
                    <td class="auto-style7">
                        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style8"></td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="Label7" runat="server" Text="Carrera"></asp:Label>
                    </td>
                    <td class="auto-style5">
                        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
            </table>
            <br />
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="Editar Alumnos"></asp:Label>
            <br />
            <br />
            <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="carnet" DataValueField="carnet">
            </asp:DropDownList>
            <br />
            <table style="width:100%;">
                <tr>
                    <td class="auto-style9">
                        <asp:Label ID="Label8" runat="server" Text="Nombre"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style9">
                        <asp:Label ID="Label9" runat="server" Text="Carrera"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style9">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
            <br />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Editar Alumno" />
            <br />
            <br />
            <asp:Label ID="Label4" runat="server" Text="Visualizar Alumnos"></asp:Label>
            <br />
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="carnet" DataSourceID="SqlDataSource1">
                <Columns>
                    <asp:BoundField DataField="carnet" HeaderText="carnet" ReadOnly="True" SortExpression="carnet" />
                    <asp:BoundField DataField="nombre" HeaderText="nombre" SortExpression="nombre" />
                    <asp:BoundField DataField="carrera" HeaderText="carrera" SortExpression="carrera" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ipc2ConnectionString %>" ProviderName="<%$ ConnectionStrings:ipc2ConnectionString.ProviderName %>" SelectCommand="SELECT * FROM ALUMNO;"></asp:SqlDataSource>
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
