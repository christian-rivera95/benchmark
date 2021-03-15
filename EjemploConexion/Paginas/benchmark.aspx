<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="benchmark.aspx.cs" Inherits="EjemploConexion.Paginas.benchmark" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 248px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Herramienta de Benchmark" Font-Bold="True" Font-Size="Larger" style="display:flex;justify-content:center;"></asp:Label>
            <br />
            <hr />
            <br />
            <table style="width:100%;">
                <thead>
                    <tr>
                        <th>Tabla</th>
                        <th class="auto-style1">Resgistros</th>
                        <th>Rellenar</th>
                        <th>Vaciar</th>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <td>Christian</td>
                        <td class="auto-style1">
                            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                        </td>
                        <td aria-checked="true">
                            <asp:CheckBox ID="CheckBox1" runat="server" checked="true"/>
                        </td>
                        <td>
                            <asp:CheckBox ID="CheckBox6" runat="server" />
                        </td>
                    </tr>
                    <tr>
                        <td>Maria</td>
                        <td class="auto-style1">
                            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                        </td>
                        <td aria-checked="true">
                            <asp:CheckBox ID="CheckBox2" runat="server" checked="true"/>
                        </td>
                        <td>
                            <asp:CheckBox ID="CheckBox7" runat="server" />
                        </td>
                    </tr>
                    <tr>
                        <td>Pedro</td>
                        <td class="auto-style1">
                            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                        </td>
                        <td aria-checked="true">
                            <asp:CheckBox ID="CheckBox3" runat="server" checked="true"/>
                        </td>
                        <td>
                            <asp:CheckBox ID="CheckBox8" runat="server" />
                        </td>
                    </tr>
                    <tr>
                        <td>Jorge</td>
                        <td class="auto-style1">
                            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                        </td>
                        <td aria-checked="true">
                            <asp:CheckBox ID="CheckBox4" runat="server" checked="true"/>
                        </td>
                        <td>
                            <asp:CheckBox ID="CheckBox9" runat="server" />
                        </td>
                    </tr>
                    <tr>
                        <td>Roberto</td>
                        <td class="auto-style1">
                            <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                        </td>
                        <td aria-checked="true">
                            <asp:CheckBox ID="CheckBox5" runat="server" checked="true"/>
                        </td>
                        <td>
                            <asp:CheckBox ID="CheckBox10" runat="server" />
                        </td>
                    </tr>
                </tbody>
            </table>
            <br />
            <hr />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Rellenar" style="margin-right:25px;" OnClick="Button1_Click"/>
            <asp:Button ID="Button2" runat="server" Text="Limpiar" OnClick="Button2_Click" />
            <br />
        </div>
    </form>
</body>
</html>
