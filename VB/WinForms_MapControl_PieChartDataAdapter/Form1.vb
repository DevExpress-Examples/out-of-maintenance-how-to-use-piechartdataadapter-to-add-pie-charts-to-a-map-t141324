Imports DevExpress.XtraMap
Imports System.Data
Imports System.Drawing
Imports System.Windows.Forms

Namespace WinForms_MapControl_PieChartDataAdapter
    Partial Public Class Form1
        Inherits Form

        Private Const xmlFilepath As String = "..\..\sochi2014.xml"

        Private ReadOnly Property PieLayer() As VectorItemsLayer
            Get
                Return CType(mapControl1.Layers("PieLayer"), VectorItemsLayer)
            End Get
        End Property

        Public Sub New()
            InitializeComponent()

'            #Region "#DataProperty"
            ' Assign a PieChartDataAdapter object to Data.
            PieLayer.Data = CreateData()
'            #End Region ' #DataProperty

'            #Region "#ColorizerProperty"
            ' Assign a KeyColorColorizer object to Colorizer.
            PieLayer.Colorizer = CreateColorizer()
'            #End Region ' #ColorizerProperty
        End Sub

        #Region "#CreateData"
        ' Create pie chart data adapter and specify its parameters.                
        Private Function CreateData() As IMapDataAdapter
            Dim adapter As New PieChartDataAdapter() With {.DataSource = LoadDataFromXml(xmlFilepath), .PieItemDataMember = "Name", .ItemMinSize = 20, .ItemMaxSize = 60}

            ' Specify mappings.
            adapter.Mappings.Latitude = "CapitalLat"
            adapter.Mappings.Longitude = "CapitalLon"
            adapter.Mappings.PieSegment = "MedalClass"
            adapter.Mappings.Value = "Quantity"

            ' Specify measure rules
            adapter.MeasureRules = New MeasureRules()
            adapter.MeasureRules.RangeStops.Add(1)
            adapter.MeasureRules.RangeStops.Add(10)
            adapter.MeasureRules.RangeStops.Add(20)
            adapter.MeasureRules.RangeStops.Add(30)
            adapter.MeasureRules.RangeStops.Add(40)

            Return adapter
        End Function

        Private Function LoadDataFromXml(ByVal path As String) As DataTable
            Dim ds As New DataSet()
            ds.ReadXml(path)
            Dim table As DataTable = ds.Tables(0)
            Return table
        End Function
        #End Region ' #CreateData

        #Region "#CreateColorizer"
        Private Function CreateColorizer() As MapColorizer
            Dim colorizer As New KeyColorColorizer() With {.ItemKeyProvider = New ArgumentItemKeyProvider()}

            colorizer.Colors.Add(Color.FromArgb(255, 207, 98))
            colorizer.Colors.Add(Color.FromArgb(169, 181, 188))
            colorizer.Colors.Add(Color.FromArgb(233, 152, 118))

            colorizer.Keys.Add(New ColorizerKeyItem() With {.Key = 1, .Name = "Gold"})
            colorizer.Keys.Add(New ColorizerKeyItem() With {.Key = 2, .Name = "Silver"})
            colorizer.Keys.Add(New ColorizerKeyItem() With {.Key = 3, .Name = "Bronze"})

            Return colorizer
        End Function
        #End Region ' #CreateColorizer
    End Class
End Namespace
