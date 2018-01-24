' If there are multiple Macro in each workbooks, without manually click each one, we can use this 

Sub RunOnAllSheets()
Dim wrkSht As Worksheet

    For Each wrkSht In ThisWorkbook.Worksheets
        Select Case wrkSht.Name
            Case " "
                'Do nothing.
            Case Else
                'For all other sheets execute the RetrieveNumbers procedure
                'and pass the wrkSht variable to it.
                RetrieveNumbers wrkSht
        End Select
    Next wrkSht

MsgBox "Done"

End Sub