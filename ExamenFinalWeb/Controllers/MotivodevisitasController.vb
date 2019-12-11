Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc
Imports ExamenFinalWeb.ExamenFinalWeb

Namespace Controllers
    Public Class MotivodevisitasController
        Inherits System.Web.Mvc.Controller

        Private db As New ProyectowebEntities

        ' GET: Motivodevisitas
        Function Index() As ActionResult
            Return View(db.Motivodevisita.ToList())
        End Function

        ' GET: Motivodevisitas/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim motivodevisita As Motivodevisita = db.Motivodevisita.Find(id)
            If IsNothing(motivodevisita) Then
                Return HttpNotFound()
            End If
            Return View(motivodevisita)
        End Function

        ' GET: Motivodevisitas/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: Motivodevisitas/Create
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="id_visita,fecha_visita,hora_entrada,hora_salida,nombrecompleto,Contactoquerecibio")> ByVal motivodevisita As Motivodevisita) As ActionResult
            If ModelState.IsValid Then
                db.Motivodevisita.Add(motivodevisita)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(motivodevisita)
        End Function

        ' GET: Motivodevisitas/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim motivodevisita As Motivodevisita = db.Motivodevisita.Find(id)
            If IsNothing(motivodevisita) Then
                Return HttpNotFound()
            End If
            Return View(motivodevisita)
        End Function

        ' POST: Motivodevisitas/Edit/5
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="id_visita,fecha_visita,hora_entrada,hora_salida,nombrecompleto,Contactoquerecibio")> ByVal motivodevisita As Motivodevisita) As ActionResult
            If ModelState.IsValid Then
                db.Entry(motivodevisita).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(motivodevisita)
        End Function

        ' GET: Motivodevisitas/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim motivodevisita As Motivodevisita = db.Motivodevisita.Find(id)
            If IsNothing(motivodevisita) Then
                Return HttpNotFound()
            End If
            Return View(motivodevisita)
        End Function

        ' POST: Motivodevisitas/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim motivodevisita As Motivodevisita = db.Motivodevisita.Find(id)
            db.Motivodevisita.Remove(motivodevisita)
            db.SaveChanges()
            Return RedirectToAction("Index")
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing) Then
                db.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub
    End Class
End Namespace
