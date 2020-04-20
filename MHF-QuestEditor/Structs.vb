Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace QuestInfo
    Public Class Structs
        Public Class QuestInfo
            Public FileName As String
            Public CRC32 As String
            Public Location As String
            Public StatTable As String
            Public Variant1A As String
            Public Variant2A As String
            Public Variant1B As String
            Public Variant2B As String
            Public ObjectiveMainType As String
            Public ObjectiveMain As String
            Public ObjectiveMainQuant As Int32
            Public ObjectiveAType As String
            Public ObjectiveA As String
            Public ObjectiveAQuant As Int32
            Public ObjectiveBType As String
            Public ObjectiveB As String
            Public ObjectiveBQuant As Int32
            Public QuestFee As Int32
            Public RewardMain As Int32
            Public RewardA As Int32
            Public RewardB As Int32
            Public QuestTypeName As String
            Public ObjMainString As String
            Public ObjAString As String
            Public ObjBString As String
            Public ClearReqString As String
            Public FailReqString As String
            Public HirerString As String
            Public DescriptString As String
            Public DeliveryString As String
            Public RewardsString As String
        End Class

        Public Class MonsterSpawn
            Public Monster As String
            Public Unk1 As Int32
            Public Unk2 As Int32
            Public Unk3 As Int32
            Public Unk4 As Int32
            Public Unk5 As Int32
            Public Unk6 As Int32
            Public Unk7 As Int32
            Public Unk8 As Int32
            Public XPos As Double
            Public YPos As Double
            Public ZPos As Double
            Public Unk9 As Int32
            Public Unk10 As Int32
            Public Unk11 As Int32
            Public Unk12 As Int32
        End Class
    End Class
End Namespace
