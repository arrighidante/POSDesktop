<%@ Page Title="" Language="C#" MasterPageFile="~/Mater.master" AutoEventWireup="true" CodeFile="Proveedores.aspx.cs" Inherits="Proveedores" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style9
        {
            width: 835px;
        }
        .style43
        {
            width: 408px;
        }
        .style52
        {
            width: 94px;
        }
        .style37
        {
            width: 137px;
        }
        .style40
        {
            width: 69px;
        }
        .style34
        {
            width: 86px;
        }
        .style13
        {
            width: 419px;
        }
        .style53
        {
            width: 94px;
            height: 32px;
        }
        .style38
        {
            width: 137px;
            height: 32px;
        }
        .style41
        {
            width: 69px;
            height: 32px;
        }
        .style35
        {
            width: 86px;
            height: 32px;
        }
        .style26
        {
            width: 419px;
            height: 32px;
        }
        .style27
        {
            width: 94px;
            height: 33px;
        }
        .style29
        {
            width: 137px;
            height: 33px;
        }
        .style17
        {
            width: 94px;
            height: 31px;
        }
        .style19
        {
            width: 137px;
            height: 31px;
        }
        .style54
        {
            width: 94px;
            height: 34px;
        }
        .style39
        {
            width: 137px;
            height: 34px;
        }
        .style42
        {
            width: 69px;
            height: 34px;
        }
        .style36
        {
            width: 86px;
            height: 34px;
        }
        .style30
        {
            width: 419px;
            height: 34px;
        }
        .style55
        {
            width: 469px;
        }
        .style56
        {
            width: 469px;
            height: 32px;
        }
        .style57
        {
            width: 469px;
            height: 33px;
        }
        .style58
        {
            width: 469px;
            height: 31px;
        }
        .style59
        {
            width: 469px;
            height: 34px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="style7">
        <tr>
            <td>
                &nbsp;</td>
            <td class="style9">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td align="center" class="style9">
                <asp:Label ID="lblProveedores" runat="server" Font-Bold="True" Font-Size="X-Large" 
                    Text="Proveedores"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td class="style9">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td class="style9">
                <asp:GridView ID="gvProveedores" runat="server" AutoGenerateColumns="False" 
                    DataKeyNames="Dni"
                    DataSourceID="odsProveedores" Width="845px" 
                    onselectedindexchanged="gvProveedores_SelectedIndexChanged" 
                    CellPadding="4" GridLines="Horizontal" BackColor="White" 
                    BorderColor="#336666" BorderStyle="Double" BorderWidth="3px">
                    <RowStyle BackColor="White" ForeColor="#333333" />
                    <Columns>
                        <asp:CommandField SelectText="Editar" ShowSelectButton="True" >
                            <ControlStyle ForeColor="Blue" />
                        </asp:CommandField>
                        <asp:BoundField DataField="Dni" HeaderText="Dni" SortExpression="Dni" />
                        <asp:BoundField DataField="Nombre" HeaderText="Nombre" 
                            SortExpression="Nombre" />
                        <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" />
                        <asp:BoundField DataField="Telefono" HeaderText="Telefono" 
                            SortExpression="Telefono" />
                        <asp:BoundField DataField="Direccion" HeaderText="Direccion" 
                            SortExpression="Direccion" />
                            
                        <asp:TemplateField>
                        <ItemTemplate>
                        <asp:LinkButton ID="delete" Runat="server" OnClientClick="return confirm('�Desea eliminar el registro?');" CommandName="Delete">Eliminar
                        </asp:LinkButton>
                        </ItemTemplate>
                        </asp:TemplateField> 
                        
                    </Columns>
                    <FooterStyle BackColor="White" ForeColor="#333333" />
                    <PagerStyle BackColor="#336666" ForeColor="White" HorizontalAlign="Center" />
                    <SelectedRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#336666" Font-Bold="True" ForeColor="White" />
                </asp:GridView>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td class="style9" align="right">
                <asp:LinkButton ID="lbtnA�adirNuevo" runat="server" TabIndex="9" 
                    onclick="lbtnA�adirNuevo_Click1">A�adir nuevo</asp:LinkButton>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td class="style9">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td class="style9" rowspan="7">
                <table class="style7">
                    <tr>
                        <td class="style43">
                            &nbsp;</td>
                        <td class="style45">
                            &nbsp;</td>
                        <td class="style52">
                            &nbsp;</td>
                        <td class="style55">
                            &nbsp;</td>
                        <td class="style37">
                            &nbsp;</td>
                        <td class="style40">
                            &nbsp;</td>
                        <td class="style34">
                            &nbsp;</td>
                        <td class="style13">
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td class="style43" rowspan="6">
                            &nbsp;</td>
                        <td class="style45" rowspan="6">
                            <asp:Image ID="imgProveedor" runat="server" Height="185px" 
                                ImageUrl="~/Imagenes/Persona.JPG" Visible="False" Width="164px" />
                        </td>
                        <td class="style52">
                        </td>
                        <td class="style55">
                            <asp:Label ID="lblNombre" runat="server" Text="Nombre" Visible="False"></asp:Label>
                        </td>
                        <td class="style37">
                            <asp:TextBox ID="txtNombre" runat="server" Visible="False" Width="199px" 
                                TabIndex="10" ReadOnly="True"></asp:TextBox>
                        </td>
                        <td class="style40" rowspan="2">
                            &nbsp;</td>
                        <td class="style34" rowspan="2">
                            <asp:Button ID="btnGuardar" runat="server" Height="33px" 
                                onclick="btnGuardar_Click" Text="Guardar" Visible="False" Width="82px" 
                                TabIndex="15" />
                        </td>
                        <td class="style13" rowspan="2">
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td class="style53">
                        </td>
                        <td class="style56">
                            <asp:Label ID="lblNumeroDoc" runat="server" Text="N�mero de documento" 
                                Visible="False"></asp:Label>
                        </td>
                        <td class="style38">
                            <asp:TextBox ID="txtNroDoc" runat="server" Visible="False" 
                                Width="197px" TabIndex="11"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="style53">
                        </td>
                        <td class="style56">
                            <asp:Label ID="lblEmail" runat="server" Text="Email" Visible="False"></asp:Label>
                        </td>
                        <td class="style38">
                            <asp:TextBox ID="txtEmail" runat="server" Visible="False" Width="193px" 
                                TabIndex="12"></asp:TextBox>
                        </td>
                        <td class="style41">
                            &nbsp;</td>
                        <td class="style35">
                            <asp:Button ID="btnA�adir" runat="server" Height="33px" 
                                onclick="btnA�adir_Click" Text="A�adir" Visible="False" Width="82px" 
                                TabIndex="16" />
                        </td>
                        <td class="style26">
                        </td>
                    </tr>
                    <tr>
                        <td class="style27">
                        </td>
                        <td class="style57">
                            <asp:Label ID="lblTelefono" runat="server" Text="Telefono" Visible="False"></asp:Label>
                        </td>
                        <td class="style29">
                            <asp:TextBox ID="txtTelefono" runat="server" Visible="False" Width="195px" 
                                ontextchanged="txtTelefono_TextChanged" TabIndex="13"></asp:TextBox>
                        </td>
                        <td class="style40" rowspan="2">
                            &nbsp;</td>
                        <td class="style34" rowspan="2">
                            <asp:Button ID="btnCancelar" runat="server" Height="33px" 
                                onclick="btnCancelar_Click" Text="Cancelar" Visible="False" Width="82px" 
                                TabIndex="17" />
                        </td>
                        <td class="style13" rowspan="2">
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td class="style17">
                        </td>
                        <td class="style58">
                            <asp:Label ID="lblDireccion" runat="server" Text="Direcci�n" Visible="False"></asp:Label>
                        </td>
                        <td class="style19">
                            <asp:TextBox ID="txtDireccion" runat="server" Visible="False" Width="196px" 
                                TabIndex="14"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="style54">
                        </td>
                        <td class="style59">
                            &nbsp;</td>
                        <td class="style39">
                            &nbsp;</td>
                        <td class="style42">
                            &nbsp;</td>
                        <td class="style36">
                        </td>
                        <td class="style30">
                        </td>
                    </tr>
                    <tr>
                        <td class="style43">
                            &nbsp;</td>
                        <td class="style45" colspan="4">
                            <asp:Label ID="lblAdvertencia" runat="server" Font-Bold="True" ForeColor="Red"></asp:Label>
                        </td>
                        <td class="style40">
                            &nbsp;</td>
                        <td class="style34">
                            &nbsp;</td>
                        <td class="style13">
                            &nbsp;</td>
                    </tr>
                </table>
                </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td class="style9">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td class="style9">
                <asp:ObjectDataSource ID="odsProveedores" runat="server" DeleteMethod="Quitar" 
                    SelectMethod="GetAll" TypeName="Data.Database.ProveedorAdapter">
                    <DeleteParameters>
                        <asp:Parameter Name="nombreProv" Type="String" />
                    </DeleteParameters>
                </asp:ObjectDataSource>
            </td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>

