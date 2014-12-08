Imports System.IO

Public Class Form1


    '   Gets data from text boxes and stores into rectangle properties
    Public Sub GetRectData(ByVal objRectangle As Rectangle)
        '   Assigns values
        Try
            objRectangle.Width() = txtWidth.Text()
            objRectangle.Length() = txtLength.Text()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    '   Gets data from text boxes and stores into carpet properies
    Public Sub GetCarpetData(ByVal objCarpet As Carpet)
        '   Assigns values
        Try
            objCarpet.Color() = txtColor.Text()
            objCarpet.Style() = txtStyle.Text()
            objCarpet.Cost() = txtCost.Text()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    '   Calculates the total cost
    Public Sub TotalCost(ByVal objCarpet As Carpet, ByVal objRectangle As Rectangle)
        Dim totalCost As Double
        totalCost = objCarpet.Cost() * objRectangle.Area()
        txtTotCost.Text() = FormatCurrency(totalCost, , , TriState.True, TriState.True)
    End Sub
    '   Event to calculate and store data in properties, then display
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim rect As New Rectangle
        Dim carp As New Carpet

        '   Rectangle start up
        GetRectData(rect)
        txtArea.Text() = rect.Area()

        '   Carpet start up
        GetCarpetData(carp)

        '   Displays total cost
        TotalCost(carp, rect)
    End Sub

    '   Clears data
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtColor.Clear()
        txtStyle.Clear()
        txtCost.Clear()
        txtLength.Clear()
        txtWidth.Clear()
        txtArea.Clear()
        txtTotCost.Clear()
    End Sub

    '   Closes form
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Hide()
    End Sub
End Class

Public Class Rectangle
    '   Member variables
    Dim sinWidth As Single
    Dim sinLength As Single
    Dim sinArea As Single

    '   Constructor
    Public Sub New()
        Debug.WriteLine("Rectangle object being created.")
        sinWidth = 0
        sinLength = 0
        sinArea = 0
    End Sub

    '   Width property procedure
    Public Property Width() As Single
        Get
            Return sinWidth
        End Get
        Set(value As Single)
            sinWidth = value
        End Set
    End Property

    '   Height property procedure
    Public Property Length() As Single
        Get
            Return sinLength
        End Get
        Set(value As Single)
            sinLength = value
        End Set
    End Property

    '   Calculates the area
    Public Sub CalcArea()
        sinArea = sinLength * sinWidth
    End Sub

    '   Area property procedure
    Public ReadOnly Property Area() As Single
        Get
            CalcArea()
            Return sinArea
        End Get
    End Property
End Class

Public Class Carpet
    '   Member variables
    Dim strColor As String
    Dim strStyle As String
    Dim dblCost As Decimal

    '   Constructor
    Public Sub New()
        Debug.WriteLine("Carpet object is being created.")
        strColor = ("unknown")
        strStyle = ("unknown")
        dblCost = 0.0
    End Sub

    '   Color property procedure
    Public Property Color() As String
        Get
            Return strColor
        End Get
        Set(value As String)
            strColor = value
        End Set
    End Property

    '   Style property procedure
    Public Property Style() As String
        Get
            Return strStyle
        End Get
        Set(value As String)
            strStyle = value
        End Set
    End Property

    '   Cost property procedure
    Public Property Cost() As Decimal
        Get
            Return dblCost
        End Get
        Set(value As Decimal)
            dblCost = value
        End Set
    End Property
End Class
