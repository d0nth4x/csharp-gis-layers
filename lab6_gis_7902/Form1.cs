using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DotSpatial.Controls;
using DotSpatial.Symbology;
using System.Diagnostics;

namespace lab6_gis_7902
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void bFile_Click(object sender, EventArgs e)
        {
            uxMap.AddLayer();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bZoomIn_Click(object sender, EventArgs e)
        {
            uxMap.ZoomIn();
        }

        private void bZoomOut_Click(object sender, EventArgs e)
        {
            uxMap.ZoomOut();
        }

        private void bCenter_Click(object sender, EventArgs e)
        {
            uxMap.ZoomToMaxExtent();
        }

        private void uxLegend_MouseClick(object sender, MouseEventArgs e)
        {
            DataTable data = null;

            if(uxMap.Layers.Count > 0)
            {
                try
                {
                    MapPolygonLayer layers = default(MapPolygonLayer);
                    layers = (MapPolygonLayer)uxMap.Layers[0];

                    if (layers != null)
                    {
                        data = layers.DataSet.DataTable;
                        uxGridView.DataSource = data;
                    }
                }
                catch(Exception ex)
                {

                    Debug.WriteLine("blad: {0} ", ex);
                }
            }
        }
    }
}
