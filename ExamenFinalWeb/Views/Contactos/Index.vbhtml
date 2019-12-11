@ModelType IEnumerable(Of ExamenFinalWeb.ExamenFinalWeb.Contactos)
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
            @Html.DisplayName("Nombre")
        </th>
        <th>
            @Html.DisplayName("apellido")
        </th>
        <th>
            @Html.DisplayName("Cedula de identidad")
        </th>
        <th>
            @Html.DisplayName("Fecha de Creacion")
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.nombre)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.apellido)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.cedula)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.fecha_creacion)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.id_contacto}) |
            @Html.ActionLink("Details", "Details", New With {.id = item.id_contacto}) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.id_contacto})
        </td>
    </tr>
Next

</table>
