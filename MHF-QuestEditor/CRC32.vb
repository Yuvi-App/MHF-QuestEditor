Imports System.Security.Cryptography
Imports System
Imports System.Collections.Generic

Namespace DamienG.Security.Cryptography
    Public NotInheritable Class Crc32
        Inherits HashAlgorithm

        Public Const DefaultPolynomial As UInt32 = &HEDB88320UI
        Public Const DefaultSeed As UInt32 = &HFFFFFFFFUI
        Shared defaultTable As UInt32()
        ReadOnly seed As UInt32
        ReadOnly table As UInt32()
        Private hash As UInt32

        Public Sub New()
            Me.New(DefaultPolynomial, DefaultSeed)
        End Sub

        Public Sub New(ByVal polynomial As UInt32, ByVal seed As UInt32)
            If Not BitConverter.IsLittleEndian Then Throw New PlatformNotSupportedException("Not supported on Big Endian processors")
            table = InitializeTable(polynomial)
            Me.seed = CSharpImpl.__Assign(hash, seed)
        End Sub

        Public Overrides Sub Initialize()
            hash = seed
        End Sub

        Protected Overrides Sub HashCore(ByVal array As Byte(), ByVal ibStart As Integer, ByVal cbSize As Integer)
            hash = CalculateHash(table, hash, array, ibStart, cbSize)
        End Sub

        Protected Overrides Function HashFinal() As Byte()
            Dim hashBuffer = UInt32ToBigEndianBytes(Not hash)
            HashValue = hashBuffer
            Return hashBuffer
        End Function

        Public Overrides ReadOnly Property HashSize As Integer
            Get
                Return 32
            End Get
        End Property

        Public Shared Function Compute(ByVal buffer As Byte()) As UInt32
            Return Compute(DefaultSeed, buffer)
        End Function

        Public Shared Function Compute(ByVal seed As UInt32, ByVal buffer As Byte()) As UInt32
            Return Compute(DefaultPolynomial, seed, buffer)
        End Function

        Public Shared Function Compute(ByVal polynomial As UInt32, ByVal seed As UInt32, ByVal buffer As Byte()) As UInt32
            Return Not CalculateHash(InitializeTable(polynomial), seed, buffer, 0, buffer.Length)
        End Function

        Private Shared Function InitializeTable(ByVal polynomial As UInt32) As UInt32()
            If polynomial = DefaultPolynomial AndAlso defaultTable IsNot Nothing Then Return defaultTable
            Dim createTable = New UInt32(255) {}

            For i = 0 To 256 - 1
                Dim entry = CType(i, UInt32)

                For j = 0 To 8 - 1
                    If (entry And 1) = 1 Then
                        entry = (entry >> 1) Xor polynomial
                    Else
                        entry = entry >> 1
                    End If
                Next

                createTable(i) = entry
            Next

            If polynomial = DefaultPolynomial Then defaultTable = createTable
            Return createTable
        End Function

        Private Shared Function CalculateHash(ByVal table As UInt32(), ByVal seed As UInt32, ByVal buffer As IList(Of Byte), ByVal start As Integer, ByVal size As Integer) As UInt32
            Dim hash = seed

            For i = start To start + size - 1
                hash = (hash >> 8) Xor table(buffer(i) Xor hash And &HFF)
            Next

            Return hash
        End Function

        Private Shared Function UInt32ToBigEndianBytes(ByVal uint32 As UInt32) As Byte()
            Dim result = BitConverter.GetBytes(uint32)
            If BitConverter.IsLittleEndian Then Array.Reverse(result)
            Return result
        End Function

        Private Class CSharpImpl
            <Obsolete("Please refactor calling code to use normal Visual Basic assignment")>
            Shared Function __Assign(Of T)(ByRef target As T, value As T) As T
                target = value
                Return value
            End Function
        End Class
    End Class
End Namespace
