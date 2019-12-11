@ModelType ExamenFinalWeb.ExamenFinalWeb.Contactos
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

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
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.id_contacto }) |
    @Html.ActionLink("Back to List", "Index")
</p>
