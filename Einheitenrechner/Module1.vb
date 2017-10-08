Module Module1

    Sub Main()

        mko.Newton.Init.Do()

        Dim AU_in_km = mko.Newton.Length.Kilometer(mko.Newton.Length.AU(1)).Vector(0)

    End Sub

End Module
