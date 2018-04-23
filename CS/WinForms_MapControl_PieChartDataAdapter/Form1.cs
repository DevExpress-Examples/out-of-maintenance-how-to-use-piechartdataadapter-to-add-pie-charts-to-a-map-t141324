using System.Data;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraMap;

namespace WinForms_MapControl_PieChartDataAdapter {
    public partial class Form1 : Form {
        const string bingKey = "YOUR BING MAPS KEY";
        const string xmlFilepath = "..\\..\\sochi2014.xml";

        public Form1() {
            InitializeComponent();
            InitializeMap();
        }

        void InitializeMap() {
            // Create a map and initialize it.
            MapControl map = new MapControl() {
                Dock = DockStyle.Fill,
                ToolTipController = new ToolTipController() { AllowHtmlText = true }
            };
            this.Controls.Add(map);
            
            // Create map layers.
            map.Layers.Add(new ImageTilesLayer() { DataProvider = new BingMapDataProvider() { BingKey = bingKey } });
            VectorItemsLayer pieLayer = new VectorItemsLayer() {
                Colorizer = CreateColorizer(),
                Data = CreateData(),
                ToolTipPattern = "<b>%A%</b>\nGold: %V0%\nSilver: %V1%\nBronze: %V2%\nTotal: %V%"
            };
            map.Layers.Add(pieLayer);

            // Create map legends.
            map.Legends.Add(new ColorListLegend() { Header = "Medal Type", Layer = pieLayer });
            map.Legends.Add(new SizeLegend() {
                Alignment = LegendAlignment.TopRight,
                Header = "Medal Count",
                Layer = pieLayer,
                Type = SizeLegendType.Nested
            });
        }

        // Create pie chart data adapter and specify its parameters.                
        IMapDataAdapter CreateData() {
            PieChartDataAdapter adapter = new PieChartDataAdapter() {
                DataSource = LoadDataFromXml(xmlFilepath),
                PieItemDataMember = "Name",
                ItemMinSize = 20,
                ItemMaxSize = 60
            };
            
            adapter.Mappings.Latitude = "CapitalLat";
            adapter.Mappings.Longitude = "CapitalLon";
            adapter.Mappings.PieSegment = "MedalClass";
            adapter.Mappings.Value = "Quantity";

            adapter.MeasureRules = new MeasureRules();
            adapter.MeasureRules.RangeStops.Add(1);
            adapter.MeasureRules.RangeStops.Add(10);
            adapter.MeasureRules.RangeStops.Add(20);
            adapter.MeasureRules.RangeStops.Add(30);
            adapter.MeasureRules.RangeStops.Add(40);

            return adapter;
        }
        
        // Create key color colorizer and specify its parameters.
        MapColorizer CreateColorizer() {
            KeyValueColorizer colorizer = new KeyValueColorizer() { ColorItemKeyProvider = new ChartItemArgumentToColorKeyProvider() };
            colorizer.AddItem(1, new ColorizerColorTextItem() { Color = Color.FromArgb(255, 207, 98), Text = "Gold" });
            colorizer.AddItem(2, new ColorizerColorTextItem() { Color = Color.FromArgb(169, 181, 188), Text = "Silver" });
            colorizer.AddItem(3, new ColorizerColorTextItem() { Color = Color.FromArgb(233, 152, 118), Text = "Bronze" });

            return colorizer;
        }


        private DataTable LoadDataFromXml(string path) {
            DataSet ds = new DataSet();
            ds.ReadXml(path);
            DataTable table = ds.Tables[0];
            return table;
        }
    }
}
