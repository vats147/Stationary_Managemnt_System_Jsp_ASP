<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Statnoray._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div>
        <div style="font-size:x-large"  align="center">Statnoary Info Manage</div>

        <div>

            <table class="nav-justified">
                <tr>
                    <td style="height: 22px">&nbsp;</td>
                    <td style="width: 373px; height: 22px;">Product_ID</td>
                    <td style="height: 22px">
                        <asp:TextBox ID="TextBox4" runat="server" OnTextChanged="TextBox4_TextChanged"></asp:TextBox>
                        <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="GET" CausesValidation="False" />
                    </td>
                </tr>
                <tr>
                    <td style="height: 22px"></td>
                    <td style="width: 373px; height: 22px;">Product Name</td>
                    <td style="height: 22px">
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Product Name is Required" ForeColor="Red"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Name is not valid" ForeColor="Red" ValidationExpression="^[A-Za-z0-9]+(?:[ _-][A-Za-z0-9]+)*$"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td style="height: 20px"></td>
                    <td style="width: 373px; height: 20px">Product Price</td>
                    <td style="height: 20px">
                        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="Product Price is required" ForeColor="Red"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="Price is not valid" ForeColor="Red" ValidationExpression="^\d+(,\d{1,2})?$"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td style="height: 20px"></td>
                    <td style="width: 373px; height: 20px">Product Description</td>
                    <td style="height: 20px">
                        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox3" ErrorMessage="Product Description is required" ForeColor="Red"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="TextBox3" ErrorMessage="Descroption is not valid" ForeColor="Red" ValidationExpression="^[a-zA-Z0-9_.-]*$"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td style="height: 22px"></td>
                    <td style="width: 373px; height: 22px;">Product Category</td>
                    <td style="height: 22px">
                        <asp:DropDownList ID="DropDownList1" runat="server">
                            <asp:ListItem>Pen</asp:ListItem>
                            <asp:ListItem>Book</asp:ListItem>
                            <asp:ListItem>Other</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td style="height: 20px"></td>
                    <td style="width: 373px; height: 20px"></td>
                    <td style="height: 20px">
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" />
                        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Update" />
                        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" OnClientClick="return confirm('Are you sure to delte?')" Text="Delete" />
                        <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Button" />
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td style="width: 373px">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td style="width: 373px">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td style="width: 373px">&nbsp;</td>
                    <td>
                        <asp:GridView ID="GridView1" runat="server" Width="448px">
                        </asp:GridView>
                    </td>
                </tr>
            </table>

        </div>
    </div>

</asp:Content>
