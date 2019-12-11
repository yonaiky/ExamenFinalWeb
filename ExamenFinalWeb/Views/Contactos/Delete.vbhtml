@ModelType ExamenFinalWeb.ExamenFinalWeb.Contactos
@Code
    ViewData("Title") = "Delete"
End Code

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
<div>
    <h4>Contactos</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.nombre)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.nombre)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.apellido)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.apellido)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.cedula)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.cedula)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.fecha_creacion)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.fecha_creacion)
        </dd>

    </dl>
    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()

        @<div class="form-actions no-color">
            <input type="submit" value="Delete" class="btn btn-default" /> |
            @Html.ActionLink("Back to List", "Index")
        </div>
    End Using
</div>
