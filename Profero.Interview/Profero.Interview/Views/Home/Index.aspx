<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Profero.Interview.Views.Home.InterviewViewModel>" %>
<%@ Import Namespace="Profero.Interview.Business.Shipping" %>
<%@ Import Namespace="Profero.Interview" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Home Page
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <fieldset>
    <h2>Your shopping basket:</h2>
    <p>
        
    </p>

    <table>
    <thead><tr><th>ProductId</th><th>SupplierId</th><th>Amount</th><th>Shipping</th><th>Shipping Amount</th></tr></thead>
    <%foreach (var li in Model.Basket.LineItems)
      {%>
    <tbody><tr>
    <td><%=li.ProductId %></td>
    <td><%=li.SupplierId %></td>
    <td><%=li.Amount %></td>
    <td><%=li.ShippingDescription %></td>
    <td><%=li.ShippingAmount %></td>
    <td><% using (Html.BeginForm("RemoveItem", "Home", new { li.Id }, FormMethod.Post))
{%>
    <input type="submit" value="Remove" />
    <%
}%></td></tr></tbody>
    <%
      }%>
    </table>
    </fieldset>

    <fieldset>
    <h2>Add new item:</h2>
    <%using(Html.BeginForm("AddItem", "Home", FormMethod.Post))
      {%>
      <label>ProductId:</label><%=Html.TextBox("ProductId") %><br />
      <label>Amount:</label><%=Html.TextBox("Amount") %><br />
      <label>Shipping:</label><%=Html.DropDownList("ShippingOption", Model.ShippingOptions.Select(x => new SelectListItem(){Text = x.Key, Value = x.Key} )) %><br />
      <label>SupplierId:</label><%=Html.TextBox("SupplierId") %><br />
      <label>DeliveryRegion:</label><%=Html.DropDownList("DeliveryRegion", typeof(RegionShippingCost.Regions)) %><br />
      <input type="submit" value="Submit" />
    <%
      }%>
      </fieldset>

</asp:Content>
