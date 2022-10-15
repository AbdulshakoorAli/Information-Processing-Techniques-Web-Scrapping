<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="k191373_Q4._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div>
        <h1 class="text-center bg-primary">Question No 4: Displaying on a Web App</h1>
        <p class="lead small bold text-center">Create a ASP.Net Page which will allow the user to perform all operations defined in Question 3 on a web page. All operations should not post the entire page to the server.</p>        
    </div>    
    <div >
        <div class="center">
            <asp:DropDownList ID="DropDownList1" runat="server" Height="29px" Width="571px" >
            <asp:ListItem>SELECT</asp:ListItem>
            <asp:ListItem>AUTOMOBILE ASSEMBLER</asp:ListItem>  
            <asp:ListItem>AUTOMOBILE PARTS & ACCESSORIES</asp:ListItem>  
            <asp:ListItem>CABLE & ELECTRICAL GOODS</asp:ListItem>  
            <asp:ListItem>CEMENT</asp:ListItem>  
            <asp:ListItem>CHEMICAL</asp:ListItem> 
            <asp:ListItem>CLOSE - END MUTUAL FUND</asp:ListItem>  
            <asp:ListItem>COMMERCIAL BANKS</asp:ListItem>  
            <asp:ListItem>ENGINEERING</asp:ListItem>  
            <asp:ListItem>EXCHANGE TRADED FUNDS</asp:ListItem>  
            <asp:ListItem>FERTILIZER</asp:ListItem>  
            <asp:ListItem>FOOD & PERSONAL CARE PRODUCTS</asp:ListItem>  
            <asp:ListItem>FUTURE CONTRACTS</asp:ListItem>  
            <asp:ListItem>GLASS & CERAMICS</asp:ListItem>  
            <asp:ListItem>INSURANCE</asp:ListItem>  
            <asp:ListItem>INV. BANKS  INV. COS.  SECURITIES COS</asp:ListItem>  
            <asp:ListItem>JUTE</asp:ListItem>  
            <asp:ListItem>LEASING COMPANIES</asp:ListItem>  
            <asp:ListItem>LEATHER & TANNERIES</asp:ListItem>  
            <asp:ListItem>MISCELLANEOUS</asp:ListItem>  
            <asp:ListItem>MODARABAS</asp:ListItem>  
            <asp:ListItem>OIL & GAS EXPLORATION COMPANIES</asp:ListItem>  
            <asp:ListItem>OIL & GAS MARKETING COMPANIES</asp:ListItem>  
            <asp:ListItem>PAPER & BOARD</asp:ListItem>  
            <asp:ListItem>PHARMACEUTICALS</asp:ListItem>  
            <asp:ListItem>POWER GENERATION & DISTRIBUTION</asp:ListItem>  
            <asp:ListItem>PROPERTY</asp:ListItem>  
            <asp:ListItem>REAL ESTATE INVESTMENT TRUST</asp:ListItem>  
            <asp:ListItem>REFINERY</asp:ListItem>  
            <asp:ListItem>SUGAR & ALLIED INDUSTRIES</asp:ListItem>  
            <asp:ListItem>SYNTHETIC & RAYON</asp:ListItem>  
            <asp:ListItem>TECHNOLOGY & COMMUNICATION</asp:ListItem>  
            <asp:ListItem>TEXTILE COMPOSITE</asp:ListItem>  
            <asp:ListItem>TEXTILE SPINNING</asp:ListItem>  
            <asp:ListItem>TEXTILE WEAVING</asp:ListItem>  
            <asp:ListItem>TOBACCO</asp:ListItem>  
            <asp:ListItem>TRANSPORT</asp:ListItem>  
            <asp:ListItem>VANASPATI & ALLIED INDUSTRIES</asp:ListItem>  
            <asp:ListItem>WOOLEN</asp:ListItem>

            <asp:ListItem></asp:ListItem>  

         </asp:DropDownList>
        </div>


        <div class="center"> <asp:Button ID="Button1" runat="server" Text="APPLY" onclick="Button1_Click" Width="573px" Height="28px"/> 
            <asp:GridView ID="GridView1" runat="server" Width="531px" CellPadding="4" ForeColor="#333333" GridLines="None">
                <AlternatingRowStyle BackColor="White" />
                <EditRowStyle BackColor="#2461BF" />
                <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#EFF3FB" />
                <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#F5F7FB" />
                <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                <SortedDescendingCellStyle BackColor="#E9EBEF" />
                <SortedDescendingHeaderStyle BackColor="#4870BE" />
            </asp:GridView>
        </div>       
        
        
        
    </div>
</asp:Content>
