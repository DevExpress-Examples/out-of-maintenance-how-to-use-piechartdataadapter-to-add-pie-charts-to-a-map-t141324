namespace WinForms_MapControl_PieChartDataAdapter {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraMap.ImageLayer imageTilesLayer1 = new DevExpress.XtraMap.ImageLayer();
            DevExpress.XtraMap.BingMapDataProvider bingMapDataProvider1 = new DevExpress.XtraMap.BingMapDataProvider();
            DevExpress.XtraMap.VectorItemsLayer vectorItemsLayer1 = new DevExpress.XtraMap.VectorItemsLayer();
            DevExpress.XtraMap.KeyColorColorizer keyColorColorizer1 = new DevExpress.XtraMap.KeyColorColorizer();
            DevExpress.XtraMap.ArgumentItemKeyProvider argumentItemKeyProvider1 = new DevExpress.XtraMap.ArgumentItemKeyProvider();
            DevExpress.XtraMap.ColorizerKeyItem colorizerKeyItem1 = new DevExpress.XtraMap.ColorizerKeyItem();
            DevExpress.XtraMap.ColorizerKeyItem colorizerKeyItem2 = new DevExpress.XtraMap.ColorizerKeyItem();
            DevExpress.XtraMap.ColorizerKeyItem colorizerKeyItem3 = new DevExpress.XtraMap.ColorizerKeyItem();
            DevExpress.XtraMap.SizeLegend sizeLegend1 = new DevExpress.XtraMap.SizeLegend();
            DevExpress.XtraMap.ColorListLegend colorListLegend1 = new DevExpress.XtraMap.ColorListLegend();
            this.mapControl1 = new DevExpress.XtraMap.MapControl();
            this.toolTipController1 = new DevExpress.Utils.ToolTipController(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.mapControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // mapControl1
            // 
            this.mapControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            imageTilesLayer1.DataProvider = bingMapDataProvider1;
            keyColorColorizer1.Colors.Add(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(98))))));
            keyColorColorizer1.Colors.Add(System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(181)))), ((int)(((byte)(188))))));
            keyColorColorizer1.Colors.Add(System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(152)))), ((int)(((byte)(118))))));
            keyColorColorizer1.ItemKeyProvider = argumentItemKeyProvider1;
            colorizerKeyItem1.Key = 1;
            colorizerKeyItem1.Name = "Gold";
            colorizerKeyItem2.Key = 2;
            colorizerKeyItem2.Name = "Silver";
            colorizerKeyItem3.Key = 3;
            colorizerKeyItem3.Name = "Bronze";
            keyColorColorizer1.Keys.Add(colorizerKeyItem1);
            keyColorColorizer1.Keys.Add(colorizerKeyItem2);
            keyColorColorizer1.Keys.Add(colorizerKeyItem3);
            vectorItemsLayer1.Colorizer = keyColorColorizer1;
            vectorItemsLayer1.Name = "PieLayer";
            vectorItemsLayer1.ToolTipPattern = "<b>%A%</b>\r\nGold: %V0%\r\nSilver: %V1%\r\nBronze: %V2%\r\nTotal: %V%\"";
            this.mapControl1.Layers.Add(imageTilesLayer1);
            this.mapControl1.Layers.Add(vectorItemsLayer1);
            sizeLegend1.Header = "Medal Count";
            sizeLegend1.Layer = vectorItemsLayer1;
            colorListLegend1.Header = "Medal Class";
            colorListLegend1.Layer = vectorItemsLayer1;
            this.mapControl1.Legends.Add(sizeLegend1);
            this.mapControl1.Legends.Add(colorListLegend1);
            this.mapControl1.Location = new System.Drawing.Point(0, 0);
            this.mapControl1.Name = "mapControl1";
            this.mapControl1.Size = new System.Drawing.Size(717, 441);
            this.mapControl1.TabIndex = 0;
            this.mapControl1.ToolTipController = this.toolTipController1;
            // 
            // toolTipController1
            // 
            this.toolTipController1.AllowHtmlText = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 441);
            this.Controls.Add(this.mapControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.mapControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraMap.MapControl mapControl1;
        private DevExpress.Utils.ToolTipController toolTipController1;

    }
}

