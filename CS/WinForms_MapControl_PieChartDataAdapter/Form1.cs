using DevExpress.XtraMap;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace WinForms_MapControl_PieChartDataAdapter {
    public partial class Form1 : Form {
        const string xmlFilepath = "..\\..\\sochi2014.xml";

        VectorItemsLayer PieLayer { get { return (VectorItemsLayer)mapControl1.Layers["PieLayer"]; } }

        public Form1() {
            InitializeComponent();

            #region #DataProperty
            // Assign a PieChartDataAdapter object to Data.
            PieLayer.Data = CreateData();
            #endregion #DataProperty

            #region #ColorizerProperty
            // Assign a KeyColorColorizer object to Colorizer.
            PieLayer.Colorizer = CreateColorizer();
            #endregion #ColorizerProperty
        }

        #region #CreateData
        // Create pie chart data adapter and specify its parameters.                
        IMapDataAdapter CreateData() {
            PieChartDataAdapter adapter = new PieChartDataAdapter() {
                DataSource = LoadDataFromXml(xmlFilepath),
                PieItemDataMember = "Name",
                ItemMinSize = 20,
                ItemMaxSize = 60
            };
            
            // Specify mappings.
            adapter.Mappings.Latitude = "CapitalLat";
            adapter.Mappings.Longitude = "CapitalLon";
            adapter.Mappings.PieSegment = "MedalClass";
            adapter.Mappings.Value = "Quantity";

            // Specify measure rules
            adapter.MeasureRules = new MeasureRules();
            adapter.MeasureRules.RangeStops.Add(1);
            adapter.MeasureRules.RangeStops.Add(10);
            adapter.MeasureRules.RangeStops.Add(20);
            adapter.MeasureRules.RangeStops.Add(30);
            adapter.MeasureRules.RangeStops.Add(40);

            return adapter;
        }

        private DataTable LoadDataFromXml(string path) {
            DataSet ds = new DataSet();
            ds.ReadXml(path);
            DataTable table = ds.Tables[0];
            return table;
        }
        #endregion #CreateData

        #region #CreateColorizer
        MapColorizer CreateColorizer() {
            KeyColorColorizer colorizer = new KeyColorColorizer() {
                ItemKeyProvider = new ArgumentItemKeyProvider()
            };

            colorizer.Colors.Add(Color.FromArgb(255, 207, 98));
            colorizer.Colors.Add(Color.FromArgb(169, 181, 188));
            colorizer.Colors.Add(Color.FromArgb(233, 152, 118));

            colorizer.Keys.Add(new ColorizerKeyItem() { Key = 1, Name = "Gold" });
            colorizer.Keys.Add(new ColorizerKeyItem() { Key = 2, Name = "Silver" });
            colorizer.Keys.Add(new ColorizerKeyItem() { Key = 3, Name = "Bronze" });
            
            return colorizer;
        }
        #endregion #CreateColorizer
    }
}
