<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128576845/14.1.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T141324)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/WinForms_MapControl_PieChartDataAdapter/Form1.cs) (VB: [Form1.vb](./VB/WinForms_MapControl_PieChartDataAdapter/Form1.vb))
* [Program.cs](./CS/WinForms_MapControl_PieChartDataAdapter/Program.cs) (VB: [Program.vb](./VB/WinForms_MapControl_PieChartDataAdapter/Program.vb))
<!-- default file list end -->
# How to use PieChartDataAdapter to add pie charts to a map


<p>The <a href="https://documentation.devexpress.com/#WindowsForms/clsDevExpressXtraMapPieChartDataAdaptertopic">PieChartDataAdapter</a> class is intended to automatically generate pie charts from a data source. The following code demonstrates how to use <strong>PieChartDataAdapter</strong> to add pie chart items to a map.</p>


<h3>Description</h3>

For this,&nbsp;create the <a href="https://documentation.devexpress.com/#WindowsForms/clsDevExpressXtraMapPieChartDataAdaptertopic">PieChartDataAdapter</a> object, set its <a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapDataSourceAdapterBase_DataSourcetopic">PieChartDataAdapter.DataSource</a> property and assign this data adapter to the&nbsp;<a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapVectorItemsLayer_Datatopic">Data</a> property of a <a href="https://documentation.devexpress.com/#WindowsForms/clsDevExpressXtraMapVectorItemsLayertopic">VectorItemsLayer</a>.<br /><br />Then specify the following properties of the <strong>PieChartDataAdapter</strong> object.<br />&nbsp;-&nbsp;The <a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapPieChartDataAdapter_PieItemDataMembertopic">PieChartDataAdapter.PieItemDataMember</a> property;<br />&nbsp;- The <a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapMapItemMappingInfo_Latitudetopic">MapItemMappingInfo.Latitude</a>&nbsp;and <a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapMapItemMappingInfo_Longitudetopic">MapItemMappingInfo.Longitude</a>&nbsp;mappings of the&nbsp;<a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapPieChartDataAdapter_Mappingstopic">PieChartDataAdapter.Mappings</a> property;<br />&nbsp;-&nbsp;The <a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapMapChartItemMappingInfo_Valuetopic">MapChartItemMappingInfo.Value</a> mapping of the&nbsp;<a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapPieChartDataAdapter_Mappingstopic">PieChartDataAdapter.Mappings</a> property;<br />&nbsp;- The <a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapMapPieMappingInfo_PieSegmenttopic">MapPieMappingInfo.PieSegment</a> mapping of the&nbsp;<a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapPieChartDataAdapter_Mappingstopic">PieChartDataAdapter.Mappings</a> property.

<br/>


