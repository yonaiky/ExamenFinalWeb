@ModelType ExamenFinalWeb.ExamenFinalWeb.Motivodevisita
@Code
    ViewData("Title") = "Delete"
End Code

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
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
    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()

        @<div class="form-actions no-color">
            <input type="submit" value="Delete" class="btn btn-default" /> |
            @Html.ActionLink("Back to List", "Index")
        </div>
    End Using
</div>
