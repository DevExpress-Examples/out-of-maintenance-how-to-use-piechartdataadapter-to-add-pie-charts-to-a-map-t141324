Imports System.Data
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.Utils
Imports DevExpress.XtraMap

Namespace WinForms_MapControl_PieChartDataAdapter
    Partial Public Class Form1
        Inherits Form

        Private Const bingKey As String = "YOUR BING MAPS KEY"
        Private Const xmlFilepath As String = "..\..\sochi2014.xml"

        Public Sub New()
            InitializeComponent()
            InitializeMap()
        End Sub

        Private Sub InitializeMap()
            ' Create a map and initialize it.
            Dim map As New MapControl() With { _
                .Dock = DockStyle.Fill, .ToolTipController = New ToolTipController() With {.AllowHtmlText = True} _
            }
            Me.Controls.Add(map)

            ' Create map layers.
            map.Layers.Add(New ImageTilesLayer() With { _
                .DataProvider = New BingMapDataProvider() With {.BingKey = bingKey} _
            })
            Dim pieLayer As New VectorItemsLayer() With {.Colorizer = CreateColorizer(), .Data = CreateData(), .ToolTipPattern = "<b>%A%</b>" & ControlChars.Lf & "Gold: %V0%" & ControlChars.Lf & "Silver: %V1%" & ControlChars.Lf & "Bronze: %V2%" & ControlChars.Lf & "Total: %V%"}
            map.Layers.Add(pieLayer)

            ' Create map legends.
            map.Legends.Add(New ColorListLegend() With {.Header = "Medal Type", .Layer = pieLayer})
            map.Legends.Add(New SizeLegend() With {.Alignment = LegendAlignment.TopRight, .Header = "Medal Count", .Layer = pieLayer, .Type = SizeLegendType.Nested})
        End Sub

        ' Create pie chart data adapter and specify its parameters.                
        Private Function CreateData() As IMapDataAdapter
            Dim adapter As New PieChartDataAdapter() With {.DataSource = LoadDataFromXml(xmlFilepath), .PieItemDataMember = "Name", .ItemMinSize = 20, .ItemMaxSize = 60}

            adapter.Mappings.Latitude = "CapitalLat"
            adapter.Mappings.Longitude = "CapitalLon"
            adapter.Mappings.PieSegment = "MedalClass"
            adapter.Mappings.Value = "Quantity"

            adapter.MeasureRules = New MeasureRules()
            adapter.MeasureRules.RangeStops.Add(1)
            adapter.MeasureRules.RangeStops.Add(10)
            adapter.MeasureRules.RangeStops.Add(20)
            adapter.MeasureRules.RangeStops.Add(30)
            adapter.MeasureRules.RangeStops.Add(40)

            Return adapter
        End Function

        ' Create key color colorizer and specify its parameters.
        Private Function CreateColorizer() As MapColorizer
            Dim colorizer As New KeyValueColorizer() With {.ColorItemKeyProvider = New ChartItemArgumentToColorKeyProvider()}
            colorizer.AddItem(1, New ColorizerColorTextItem() With {.Color = Color.FromArgb(255, 207, 98), .Text = "Gold"})
            colorizer.AddItem(2, New ColorizerColorTextItem() With {.Color = Color.FromArgb(169, 181, 188), .Text = "Silver"})
            colorizer.AddItem(3, New ColorizerColorTextItem() With {.Color = Color.FromArgb(233, 152, 118), .Text = "Bronze"})

            Return colorizer
        End Function


        Private Function LoadDataFromXml(ByVal path As String) As DataTable
            Dim ds As New DataSet()
            ds.ReadXml(path)
            Dim table As DataTable = ds.Tables(0)
            Return table
        End Function
    End Class
End Namespace
