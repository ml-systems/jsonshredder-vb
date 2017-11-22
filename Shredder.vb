Option Infer On

Imports System
Imports System.IO
Imports System.Text
Imports Newtonsoft.Json.Linq
Imports System.Linq
Imports System.Diagnostics

Public Module Module1
    Public daty As List(Of Object)
End Module

Module Shredder
    Sub Main(args As String())
        shred4()


    End Sub

    Sub shred1()
        Console.WriteLine("Hello World!")
        Dim innerobj As New Object
        Dim txtfile As String = File.ReadAllText("C:\Users\nflvm\Desktop\python\tmp2.json")
        ' Object obj = JsonHelper.Deserialize(txtfile)
        Dim obj As Object = JsonHelper.Deserialize(txtfile)
        ' Console.WriteLine("{0}  yo", obj.GetType().ToString())
        ' Console.WriteLine("Type of number1 and number2 are equal: {0}",
        ' Object.ReferenceEquals(obj.GetType(), dictionary.GetType()))
        'prin(obj)
        Dim pair As KeyValuePair(Of String, Object)
        Dim daty = New List(Of Object)
        Dim included = New Dictionary(Of String, Integer)()
        Dim excluded = New Dictionary(Of String, Integer)()
        Dim melded = New Dictionary(Of String, Integer)()
        Dim level = 1
        Dim rider = New List(Of Object)
        Console.WriteLine("HI")
        included.Add("drives", 2)
        excluded.Add("nextupdate", 1)
        melded.Add("start", 4)
        melded.Add("end", 4)
        excluded.Add("plays", 4)
        excluded.Add("crntdrv", 3)
        For Each pair In obj
            Dim riderc As New List(Of Object)(rider)
            iterprint(daty, pair.Key, pair.Value, included, excluded, melded, level, riderc)
        Next
        For Each ls In daty
            For Each it In ls
                Console.Write("{0},", it)

            Next
            Console.WriteLine("")
        Next
        Console.ReadKey(True)
    End Sub

    Sub shred2()
        Console.WriteLine("Hello World!")
        Dim innerobj As New Object
        Dim txtfile As String = File.ReadAllText("C:\Users\nflvm\Desktop\python\tmp2.json")
        ' Object obj = JsonHelper.Deserialize(txtfile)
        Dim obj As Object = JsonHelper.Deserialize(txtfile)
        ' Console.WriteLine("{0}  yo", obj.GetType().ToString())
        ' Console.WriteLine("Type of number1 and number2 are equal: {0}",
        ' Object.ReferenceEquals(obj.GetType(), dictionary.GetType()))
        'prin(obj)
        Dim pair As KeyValuePair(Of String, Object)
        Dim daty = New List(Of Object)
        Dim included = New Dictionary(Of String, Integer)()
        Dim excluded = New Dictionary(Of String, Integer)()
        Dim melded = New Dictionary(Of String, Integer)()
        Dim level = 1
        Dim rider = New List(Of Object)
        Console.WriteLine("HI")
        excluded.Add("nextupdate", 1)
        included.Add("drives", 2)
        included.Add("plays", 4)
        excluded.Add("players", 6)
        excluded.Add("crntdrv", 3)
        For Each pair In obj
            Dim riderc As New List(Of Object)(rider)
            iterprint(daty, pair.Key, pair.Value, included, excluded, melded, level, riderc)
        Next
        For Each ls In daty
            For Each it In ls
                Console.Write("{0},", it)

            Next
            Console.WriteLine("")
        Next
        Console.ReadKey(True)
    End Sub

    Sub shred3()
        Console.WriteLine("Hello World!")
        Dim innerobj As New Object
        Dim txtfile As String = File.ReadAllText("C:\Users\nflvm\Desktop\python\tmp2.json")
        ' Object obj = JsonHelper.Deserialize(txtfile)
        Dim obj As Object = JsonHelper.Deserialize(txtfile)
        ' Console.WriteLine("{0}  yo", obj.GetType().ToString())
        ' Console.WriteLine("Type of number1 and number2 are equal: {0}",
        ' Object.ReferenceEquals(obj.GetType(), dictionary.GetType()))
        'prin(obj)
        Dim pair As KeyValuePair(Of String, Object)
        Dim daty = New List(Of Object)
        Dim included = New Dictionary(Of String, Integer)()
        Dim excluded = New Dictionary(Of String, Integer)()
        Dim melded = New Dictionary(Of String, Integer)()
        Dim level = 1
        Dim rider = New List(Of Object)
        Console.WriteLine("HI")
        included.Add("drives", 2)
        excluded.Add("nextupdate", 1)
        excluded.Add("crntdrv", 3)
        included.Add("plays", 4)
        included.Add("players", 6)
        For Each pair In obj
            Dim riderc As New List(Of Object)(rider)
            iterprint(daty, pair.Key, pair.Value, included, excluded, melded, level, riderc)
        Next
        For Each ls In daty
            For Each it In ls
                Console.Write("{0},", it)

            Next
            Console.WriteLine("")
        Next
        Console.ReadKey(True)
    End Sub

    Sub shred4()
        Console.WriteLine("Hello World!")
        Dim innerobj As New Object
        Dim txtfile As String = File.ReadAllText("C:\Users\nflvm\Desktop\python\tmp2.json")
        ' Object obj = JsonHelper.Deserialize(txtfile)
        Dim obj As Object = JsonHelper.Deserialize(txtfile)
        ' Console.WriteLine("{0}  yo", obj.GetType().ToString())
        ' Console.WriteLine("Type of number1 and number2 are equal: {0}",
        ' Object.ReferenceEquals(obj.GetType(), dictionary.GetType()))
        'prin(obj)
        Dim pair As KeyValuePair(Of String, Object)
        Dim daty = New List(Of Object)
        Dim included = New Dictionary(Of String, Integer)()
        Dim excluded = New Dictionary(Of String, Integer)()
        Dim melded = New Dictionary(Of String, Integer)()
        Dim level = 1
        Dim rider = New List(Of Object)
        Console.WriteLine("HI")
        excluded.Add("nextupdate", 1)
        included.Add("stats", 3)
        included.Add("home", 2)
        included.Add("away", 2)
        excluded.Add("team", 4)
        For Each pair In obj
            Dim riderc As New List(Of Object)(rider)
            iterprint(daty, pair.Key, pair.Value, included, excluded, melded, level, riderc)
        Next
        For Each ls In daty
            For Each it In ls
                Console.Write("{0},", it)

            Next
            Console.WriteLine("")
        Next
        Console.ReadKey(True)
    End Sub


    Sub iterprint(daty As List(Of Object), objkey As String, objval As Object, included As Dictionary(Of String, Integer), excluded As Dictionary(Of String, Integer), melded As Dictionary(Of String, Integer), level As Integer, ByVal rider As List(Of Object))

        Dim dictionary As New Dictionary(Of String, Object)
        Dim list As New List(Of Object)

        If included Is Nothing Then
            included = New Dictionary(Of String, Integer)()
        End If

        If excluded Is Nothing Then
            excluded = New Dictionary(Of String, Integer)()
        End If

        If melded Is Nothing Then
            melded = New Dictionary(Of String, Integer)()
        End If

        If level = Nothing Then
            level = 1
        End If

        If rider Is Nothing Then
            rider = New List(Of Object)()
        End If
        '    print('printing')
        'If strThen Then(objkey)==includekey And level==includelevel
        '    print(str(level)+','+str(isinstance(objval,list)))
        '    print ('prea'+str(objkey))
        '    print ('a,'+str(melded.get(str(objkey),"")))
        '    print ('c,'+str(level))
        Dim value As String = ""
        Dim numvalue As Integer = 0
        'Debug.Print("1")
        'Debug.Print(objkey.GetType())
        'Debug.Print(included.GetType())

        'Console.WriteLine("the objkey {0} is in included on level {1}:{2}, included.TryGetValue(objkey, numvalue)={3}", objkey, level, included.TryGetValue(objkey, numvalue) = level, numvalue)
        included.TryGetValue(objkey, numvalue)
        If numvalue = level Or Not included.ContainsValue(level) Then
            'Console.Write("a")
            excluded.TryGetValue(objkey, numvalue)
            If numvalue <> level Then
                'Console.Write("b")
                'Console.Write(objval.GetType())
                'Console.Write(objval)
                If Not objval Is Nothing Then

                    If Object.ReferenceEquals(objval.GetType(), dictionary.GetType()) Then
                        'Console.Write("c")
                        If rider.Count = 0 Then
                            'If isinstanceThen Then( objkey, int ):
                            'print(objkey)
                            rider.Add(objkey)
                            'Console.Write("d")
                            'Console.Write(objkey)
                        Else
                            'Console.Write("e")
                            melded.TryGetValue(objkey, numvalue)
                            If numvalue = level Then
                                'Console.Write("f")
                                If rider(rider.Count - 1).ToString().Substring(rider(rider.Count - 1).ToString().Length - 1, 1) = "-" Then
                                    'Console.Write("g")
                                    rider(rider.Count - 1) = rider(rider.Count - 1) & objkey & "-"
                                Else
                                    'Console.Write("h")
                                    rider.Add(objkey & "-")
                                End If

                            Else
                                'Console.Write("i")
                                If rider(rider.Count - 1).ToString().Substring(rider(rider.Count - 1).ToString().Length - 1, 1) = "-" Then
                                    'Console.Write("j")
                                    rider(rider.Count - 1) = rider(rider.Count - 1) & objkey
                                Else
                                    'Console.Write("k")
                                    rider.Add(objkey)
                                End If
                            End If
                        End If

                        'Console.Write("l")
                        level += 1
                        '------start here
                        Dim pair As KeyValuePair(Of String, Object)
                        For Each pair In objval
                            'Console.Write("m")
                            Dim riderc As New List(Of Object)(rider)
                            iterprint(daty, pair.Key, pair.Value, included, excluded, melded, level, riderc)
                        Next

                    ElseIf Object.ReferenceEquals(objval.GetType(), list.GetType()) Then
                        'Console.Write("n")
                        If rider.Count = 0 Then
                            'Console.Write("o")
                            'If isinstanceThen Then( objkey, int ):
                            'print(objkey)
                            rider.Add(objkey)
                        Else
                            'Console.Write("p")
                            melded.TryGetValue(objkey, numvalue)
                            If numvalue = level Then
                                'Console.Write("q")
                                If rider(rider.Count - 1).ToString().Substring(rider(rider.Count - 1).ToString().Length - 1, 1) = "-" Then
                                    'Console.Write("r")
                                    rider(rider.Count - 1) = rider(rider.Count - 1) & objkey & "-"
                                Else
                                    'Console.Write("s")
                                    rider.Add(objkey & "-")
                                End If

                            Else
                                'Console.Write("t")
                                If rider(rider.Count - 1).ToString().Substring(rider(rider.Count - 1).ToString().Length - 1, 1) = "-" Then
                                    'Console.Write("u")
                                    rider(rider.Count - 1) = rider(rider.Count - 1) & objkey
                                Else
                                    'Console.Write("v")
                                    rider.Add(objkey)
                                End If
                            End If
                            'Console.Write("w")
                            level += 1

                            For Each itm In objval
                                'Console.Write("x")
                                If Object.ReferenceEquals(itm.GetType(), dictionary.GetType()) Then
                                    'Console.Write("y")

                                    For Each pair In itm
                                        'Console.Write("z")
                                        Dim riderc As New List(Of Object)(rider)
                                        iterprint(daty, pair.key, pair.value, included, excluded, melded, level, riderc)
                                    Next

                                ElseIf Object.ReferenceEquals(itm.GetType(), dictionary.GetType()) Then
                                    'Console.Write("1A")
                                    Dim ikey = ""
                                    For Each ivalue In itm
                                        'Console.Write("1B")
                                        Dim riderc As New List(Of Object)(rider)
                                        iterprint(daty, ikey, ivalue, included, excluded, melded, level, riderc)
                                    Next
                                Else
                                    If rider(rider.Count - 1).ToString().Substring(rider(rider.Count - 1).ToString().Length - 1, 1) = "-" Then
                                        'Console.Write("1C")
                                        rider(rider.Count - 1) = rider(rider.Count - 1) & objkey
                                        rider.Add(objval)
                                        daty.Add(rider)
                                        'Console.WriteLine("")
                                        'For Each i In rider
                                        'Console.Write("{0},", i)

                                        'Next
                                        'Console.WriteLine("")
                                        'Console.ReadKey(True)
                                        rider = New List(Of Object)
                                    Else
                                        'Console.Write("1D")
                                        rider.Add(objkey)
                                        rider.Add(objval)
                                        daty.Add(rider)
                                        'Console.WriteLine("")
                                        'For Each i In rider
                                        'Console.Write("{0},", i)

                                        'Next
                                        'Console.WriteLine("")
                                        'Console.ReadKey(True)
                                        rider = New List(Of Object)
                                    End If
                                End If
                            Next
                        End If
                    Else
                        'Console.Write("1E")
                        If rider.Count = 0 Then
                            'Console.Write("1F")
                            rider.Add(objkey)
                            rider.Add(objval)
                            'rider.append("\"%s\"" % objval If type(objval)==str Else str(objval))
                            'print(rider)
                            daty.Add(rider)
                            'Console.WriteLine("")
                            'For Each i In rider
                            'Console.Write("{0},", i)

                            'Next
                            'Console.WriteLine("")
                            'Console.ReadKey(True)
                            'print(daty)
                            rider = New List(Of Object)
                        Else
                            'Console.Write("1G")
                            If rider(rider.Count - 1).ToString() = "" Then
                                rider(rider.Count - 1) = "Nothing"
                            End If
                            If rider(rider.Count - 1).ToString().Substring(rider(rider.Count - 1).ToString().Length - 1, 1) = "-" Then
                                'Console.Write("1H")
                                rider(rider.Count - 1) = rider(rider.Count - 1) & objkey
                                rider.Add(objval)
                                'rider.append("\"%s\"" % objval If type(objval)==str Else str(objval)) 
                                'print(rider)
                                daty.Add(rider)
                                'Console.WriteLine("")
                                'For Each i In rider
                                'Console.Write("{0},", i)

                                'Next
                                'Console.WriteLine("")
                                'Console.ReadKey(True)
                                'print(daty)
                                rider = New List(Of Object)
                            Else
                                'Console.Write("1I")
                                rider.Add(objkey)
                                rider.Add(objval)
                                'rider.append("\"%s\"" % objval If type(objval)==str Else str(objval))
                                'print(rider)
                                daty.Add(rider)
                                'Console.WriteLine("")
                                'For Each i In rider
                                'Console.Write("{0},", i)

                                'Next
                                'Console.WriteLine("")
                                'Console.ReadKey(True)
                                'print(daty)
                                rider = New List(Of Object)
                            End If
                        End If
                    End If
                Else
                    'Console.Write("1J")
                    If rider.Count = 0 Then
                        'Console.Write("1K")
                        rider.Add(objkey)
                        rider.Add("NULL")
                        'rider.append("\"%s\"" % objval If type(objval)==str Else str(objval))
                        'print(rider)
                        daty.Add(rider)
                        'Console.WriteLine("")
                        'For Each i In rider
                        'Console.Write("{0},", i)

                        'Next
                        'Console.WriteLine("")
                        'Console.ReadKey(True)
                        'print(daty)
                        rider = New List(Of Object)
                    Else
                        'Console.Write("1L")
                        If rider(rider.Count - 1).ToString().Substring(rider(rider.Count - 1).ToString().Length - 1, 1) = "-" Then
                            'Console.Write("1M")
                            rider(rider.Count - 1) = rider(rider.Count - 1) & objkey
                            rider.Add("NULL")
                            'rider.append("\"%s\"" % objval If type(objval)==str Else str(objval)) 
                            'print(rider)
                            daty.Add(rider)
                            'Console.WriteLine("")
                            'For Each i In rider
                            'Console.Write("{0},", i)

                            'Next
                            'Console.WriteLine("")
                            'Console.ReadKey(True)
                            'print(daty)
                            rider = New List(Of Object)
                        Else
                            'Console.Write("1N")
                            rider.Add(objkey)
                            rider.Add("NULL")
                            'rider.append("\"%s\"" % objval If type(objval)==str Else str(objval))
                            'print(rider)
                            daty.Add(rider)
                            'Console.WriteLine("")
                            'For Each i In rider
                            'Console.Write("{0},", i)

                            'Next
                            'Console.WriteLine("")
                            'Console.ReadKey(True)
                            'print(daty)
                            rider = New List(Of Object)
                        End If
                    End If
                End If
            End If
        Else
            'Console.WriteLine("{0} not included on level {1} and other includes on that level", objkey, level)
        End If
    End Sub

    Sub prin(obj)
        Dim pair As KeyValuePair(Of String, Object)
        Dim dictionary As New Dictionary(Of String, Object)
        Dim list As New List(Of Object)
        Dim str As String()
        If Object.ReferenceEquals(obj.GetType(), list.GetType()) Then
            For Each val In obj
                If Object.ReferenceEquals(val.GetType(), dictionary.GetType()) Or Object.ReferenceEquals(val.GetType(), list.GetType()) Then
                    prin(val)
                Else
                    'Console.WriteLine("{0}", val)
                End If
            Next
        Else
            For Each pair In obj
                If pair.Value Is Nothing Then
                    'Console.WriteLine("{0}, {1}", pair.Key, "NULL")
                Else

                    'Console.WriteLine("key: {0}, {1}", pair.Key.GetType, pair.Key)
                    'Console.WriteLine("oj {0}", pair.Value.GetType)
                    'Console.WriteLine("ok {0}", pair.Key)
                    'Console.WriteLine("ol {0}", pair.Value)
                    If Object.ReferenceEquals(pair.Value.GetType(), dictionary.GetType()) Then
                        prin(pair.Value)
                    Else
                        'Console.WriteLine("{0}, {1}", pair.Key, pair.Value)
                        'Console.WriteLine("type {0}, type {1}", pair.Key.GetType(), pair.Value.GetType())
                    End If
                End If

            Next
        End If
    End Sub
End Module

Public NotInheritable Class JsonHelper
    Private Sub New()
    End Sub
    Public Shared Function Deserialize(json As String) As Object
        Return ToObject(JToken.Parse(json))
    End Function

    Private Shared Function ToObject(token As JToken) As Object
        Select Case token.Type
            Case JTokenType.[Object]
                Return token.Children(Of JProperty)().ToDictionary(Function(prop) prop.Name, Function(prop) ToObject(prop.Value))

            Case JTokenType.Array
                Return token.[Select](AddressOf ToObject).ToList()
            Case Else

                Return DirectCast(token, JValue).Value
        End Select
    End Function
End Class