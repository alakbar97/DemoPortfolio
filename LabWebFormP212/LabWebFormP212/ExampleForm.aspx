<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ExampleForm.aspx.cs" Inherits="LabWebFormP212.ExampleForm" %>
<%@Import NameSpace="LabWebFormP212.Models" %>
<%@Import NameSpace="System.Web" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <%
                using (MyDbContext db=new MyDbContext())
                {
                    foreach (var item in db.Projects.ToList())
                    {
                        var sentence = HttpUtility.HtmlDecode(item.Description);
                        Response.Write($"<h3>{sentence}</h3>");
                        Response.Write($"<img src=Images/{item.MainImage} > <br/>");
                        foreach (var img in db.Pictures.Where(x=>x.ProjectID==item.ID).ToList())
                        {
                            Response.Write($"<img width=100px height=100px src=Images/{img.Name} >");
                        }
                    }
                }
                %>
        </div>
    </form>
</body>
</html>
