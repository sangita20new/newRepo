Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Function Index() As ActionResult
        Return View()
    End Function

    Function About() As ActionResult
        ViewData("Message") = "Your application started."

        Return View()
    End Function

    Function Contact() As ActionResult
        ViewData("Message") = " Show your contact page."

        Return View()
    End Function
End Class
