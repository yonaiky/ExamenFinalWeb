@ModelType IEnumerable(Of ExamenFinalWeb.ExamenFinalWeb.Motivodevisita)
@Code
ViewData("Title") = "Index"
End Code

<h2>Index</h2>

<p>
    @Html.ActionLink("Create New", "Create")
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayName("Fecha de Visita")
        </th>
        <th>
            @Html.DisplayName("Hora de entrada")
        </th>
        <th>
            @Html.DisplayName("Hora de Salida")
        </th>
        <th>
            @Html.DisplayName("Nombre Completo")
        </th>
        <th>
            @Html.DisplayName("Contacto que lo atendio")
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.fecha_visita)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.hora_entrada)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.hora_salida)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.nombrecompleto)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Contactoquerecibio)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.id_visita}) |
            @Html.ActionLink("Details", "Details", New With {.id = item.id_visita}) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.id_visita})
        </td>
    </tr>
Next

</table>
