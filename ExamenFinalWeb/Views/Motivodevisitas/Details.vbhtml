@ModelType ExamenFinalWeb.ExamenFinalWeb.Motivodevisita
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<div>
    <h4>Motivodevisita</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.fecha_visita)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.fecha_visita)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.hora_entrada)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.hora_entrada)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.hora_salida)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.hora_salida)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.nombrecompleto)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.nombrecompleto)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Contactoquerecibio)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Contactoquerecibio)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.id_visita }) |
    @Html.ActionLink("Back to List", "Index")
</p>
