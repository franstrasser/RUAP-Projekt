<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Ruap.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>RUAP Projekt</title>
    <style>
        body {
            font-family: Arial;
            font-size: 12px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Heart Failure Prediction</h1>
        </div>
            <table>
                <tr>
                    <td>
                        Age:
                    </td>
                    <td>
                        <asp:TextBox ID="txtAge" runat="server"></asp:TextBox>
                    </td>
                </tr>

                <tr>
                    <td>
                        Anaemia:
                    </td>
                    <td>
                        <asp:RadioButtonList ID="rblAnaemia" runat="server">
							<asp:ListItem>Yes</asp:ListItem>
							<asp:ListItem>No</asp:ListItem>
						</asp:RadioButtonList> 
                    </td>
                </tr>

                <tr>
                    <td>
                        Creatinine phosphokinase:
                    </td>
                    <td>
                        <asp:TextBox ID="txtCreatinine" runat="server"></asp:TextBox>
                    </td>
                </tr>

                <tr>
                    <td>
                        Diabetes:
                    </td>
                    <td>
                        <asp:RadioButtonList ID="rblDiabetes" runat="server">
							<asp:ListItem>Yes</asp:ListItem>
							<asp:ListItem>No</asp:ListItem>
						</asp:RadioButtonList> 
                    </td>
                </tr>

                <tr>
                    <td>
                        Ejection fraction:
                    </td>
                    <td>
                        <asp:TextBox ID="txtEjection" runat="server"></asp:TextBox>
                    </td>
                </tr>

                <tr>
                    <td>
                        High Blood Pressure:
                    </td>
                    <td>
                        <asp:RadioButtonList ID="rblBloodPressure" runat="server">
							<asp:ListItem>Yes</asp:ListItem>
							<asp:ListItem>No</asp:ListItem>
						</asp:RadioButtonList> 
                    </td>
                </tr>

                <tr>
                    <td>
                        Platelets:
                    </td>
                    <td>
                        <asp:TextBox ID="txtPlatelets" runat="server"></asp:TextBox>
                    </td>
                </tr>

                <tr>
                    <td>
                        Serum creatinine:
                    </td>
                    <td>
                        <asp:TextBox ID="txtSerumCreatinine" runat="server"></asp:TextBox>
                    </td>
                </tr>

                <tr>
                    <td>
                        Serum sodium:
                    </td>
                    <td>
                        <asp:TextBox ID="txtSerumSodium" runat="server"></asp:TextBox>
                    </td>
                </tr>

                <tr>
                    <td>
                        Gender:
                    </td>
                    <td>
                        <asp:RadioButtonList ID="rblGender" runat="server">
							<asp:ListItem>Male</asp:ListItem>
							<asp:ListItem>Female</asp:ListItem>
						</asp:RadioButtonList> 
                    </td>
                </tr>

                <tr>
                    <td>
                        Smoking:
                    </td>
                    <td>
                        <asp:RadioButtonList ID="rblSmoking" runat="server">
							<asp:ListItem>Yes</asp:ListItem>
							<asp:ListItem>No</asp:ListItem>
						</asp:RadioButtonList> 
                    </td>
                </tr>

                <tr>
                    <td>
                        
                    </td>
                    <td>
                        <asp:LinkButton ID="lbPredict" runat="server" OnClick="lbPredict_Click">Predict</asp:LinkButton>
                    </td>
                </tr>
            </table>
        <asp:Label ID="lblResults" runat="server" Font-Size="Larger"></asp:Label>
    </form>
</body>
</html>
