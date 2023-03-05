Sub ControlStatements()
    
    ' If statement
    Dim x As Integer
    x = 10
    If x > 5 Then
        MsgBox "x is greater than 5"
    End If
    
    ' If-Then-Else statement
    Dim y As Integer
    y = 3
    If y > 5 Then
        MsgBox "y is greater than 5"
    Else
        MsgBox "y is less than or equal to 5"
    End If
    
    ' Select Case statement
    Dim z As Integer
    z = 8
    Select Case z
        Case Is > 10
            MsgBox "z is greater than 10"
        Case Is > 5
            MsgBox "z is greater than 5 but less than or equal to 10"
        Case Else
            MsgBox "z is less than or equal to 5"
    End Select
    
    ' For-Next loop
    Dim i As Integer
    For i = 1 To 4
        MsgBox i
    Next i
    
    ' Do-While loop
    Dim j As Integer
    j = 1
    Do While j <= 5
        MsgBox j
        j = j + 1
    Loop
    
    ' Do-Until loop
    Dim k As Integer
    k = 1
    Do Until k > 5
        MsgBox k
        k = k + 1
    Loop
    
    ' Do-Loop While loop
    Dim l As Integer
    l = 1
    Do
        MsgBox l
        l = l + 1
    Loop While l <= 5
    
    ' Do-Loop Until loop
    Dim m As Integer
    m = 1
    Do
        MsgBox m
        m = m + 1
    Loop Until m > 5
    
    ' Exit For statement
    Dim n As Integer
    For n = 1 To 10
        If n = 5 Then
            Exit For
        End If
        MsgBox n
    Next n
    
    ' Exit Do statement
    Dim o As Integer
    o = 1
    Do While o <= 5
        MsgBox o
        o = o + 1
        If o = 3 Then
            Exit Do
        End If
    Loop
    
    ' GoTo statement
    Dim p As Integer
    p = 1
    Do While p <= 5
        If p = 3 Then
            GoTo MyLabel
        End If
        MsgBox p
        p = p + 1
    Loop
MyLabel:
    MsgBox "Jumped to MyLabel"
End Sub
