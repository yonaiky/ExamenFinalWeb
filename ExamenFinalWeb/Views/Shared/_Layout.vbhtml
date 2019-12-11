<!DOCTYPE html>
<html>
<head>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>@ViewBag.Title - Mi aplicación ASP.NET</title>
    @Styles.Render("~/Content/css")
    @Scripts.Render("~/bundles/modernizr")
    
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/materialize/1.0.0/css/materialize.min.css">


</head>
<body>

    <!
    <script src="https://cdnjs.cloudflare.com/ajax/libs/materialize/1.0.0/js/materialize.min.js"></script>

    <nav>
        <div class="green accent-4">
            <div class="container">
                <a href="https://localhost:44331" class="navbar-brand" id="name">Gestionador de visitas</a>
                <ul id="nav-mobile" class="right hide-on-med-and-down">
                    <li>@Html.ActionLink("Inicio", "Index", "Home")</li>
                    <li>@Html.ActionLink("Contactos", "Index", "Contactos")</li>
                    <li>@Html.ActionLink("Motivodevisitas", "Index", "Motivodevisitas")</li>
                </ul>
            </div>
        </div>
    </nav>
    <div class="container body-content">
        @RenderBody()
        <hr />
    </div>

    @Scripts.Render("~/bundles/jquery")
    @Scripts.Render("~/bundles/bootstrap")
    @RenderSection("scripts", required:=False)
</body>

<footer class="green accent-4">
    <div class="container">
        <div class="row">
            <div class="col l6 s12">
                <h5 class="white-text">Examen Final de programacion web</h5>
                <p class="grey-text text-lighten-4">Yonaiky Matos #2018-6056</p>
            </div>
            <div class="col l4 offset-l2 s12">

            </div>
        </div>
    </div>
    <div class="footer-copyright">
        <div class="container">
            © 2020 Copyright - Yonaiky Matos 
        </div>
    </div>
</footer>
</html>
