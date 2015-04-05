Partial Class ExpandedOrders

End Class

Partial Class Customer

    Private Sub Oncredit_limitChanging(value As Decimal)
        If value < 0 Then
            Throw New ConstraintException("Credit limit must be positive (or zero)")
        End If
    End Sub
End Class

