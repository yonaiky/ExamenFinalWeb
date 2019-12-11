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
    Public Class ContactosController
        Inherits System.Web.Mvc.Controller

        Private db As New ProyectowebEntities

        ' GET: Contactos
        Function Index() As ActionResult
            Return View(db.Contactos.ToList())
        End Function

        ' GET: Contactos/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim contactos As Contactos = db.Contactos.Find(id)
            If IsNothing(contactos) Then
                Return HttpNotFound()
            End If
            Return View(contactos)
        End Function

        ' GET: Contactos/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: Contactos/Create
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="id_contacto,nombre,apellido,cedula,fecha_creacion")> ByVal contactos As Contactos) As ActionResult
            If ModelState.IsValid Then
                db.Contactos.Add(contactos)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(contactos)
        End Function

        ' GET: Contactos/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim contactos As Contactos = db.Contactos.Find(id)
            If IsNothing(contactos) Then
                Return HttpNotFound()
            End If
            Return View(contactos)
        End Function

        ' POST: Contactos/Edit/5
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="id_contacto,nombre,apellido,cedula,fecha_creacion")> ByVal contactos As Contactos) As ActionResult
            If ModelState.IsValid Then
                db.Entry(contactos).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(contactos)
        End Function

        ' GET: Contactos/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim contactos As Contactos = db.Contactos.Find(id)
            If IsNothing(contactos) Then
                Return HttpNotFound()
            End If
            Return View(contactos)
        End Function

        ' POST: Contactos/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim contactos As Contactos = db.Contactos.Find(id)
            db.Contactos.Remove(contactos)
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
