<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminPanel.aspx.cs" Inherits="LabWebFormP212.AdminPanel" ValidateRequest="false" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    <link href="Content/bootstrap.min.css" rel="stylesheet" />

</head>
<body>
    <form id="form1" runat="server" enctype="multipart/form-data" method="post">
        <div class="container">
            <div class="row">
                <div class="form-group col-12 m-auto">
                    <label for="sitename">Site name</label>
                    <input type="text" name="SiteName" id="sitename" class="form-control" runat="server"/>
                </div>
                <div class="form-group col-12 m-auto">
                    <label for="img">Main image</label>
                    <input type="file" name="MainImage" id="MainImage" class="form-control" runat="server" />
                </div>
                <div class="form-group col-12 m-auto">
                    <label for="img2">Secondary images</label>
                    <input type="file" name="Image2" id="Image2" class="form-control" runat="server" multiple="multiple"  runat="server"/>
                </div>
                <div class="form-group col-12 m-auto">
                    <label for="textarea">Main image</label>
                    <textarea id="Description" name="Description"  runat="server"></textarea>
                </div>
            </div>
            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="ProjectClicked" />
        </div>
    </form>
    <script src="Scripts/jquery-3.4.1.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/ckeditor/4.12.1/ckeditor.js"></script>
    <script>
        CKEDITOR.replace('Description');
    </script>
</body>
</html>
