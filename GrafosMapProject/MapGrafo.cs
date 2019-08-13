
#region Using Directives
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GrafosMap.DataSource;
using GrafosMapModels;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using GrafosMap.Business;
#endregion

namespace GrafosMap.Client
{
    public partial class MapGrafo : Form
    {
        #region Fields
        private DataMarkers dataMarkers;
        private DijkstraMin dijkstraMin;
        private DijkstraMax dijkstraMax;
        private GMapOverlay markers;
        private GMapOverlay routes;
        private double[,] auxMatrix;
        private int source = -1;
        private int end = -1;
        private int countMark = 0;
        private int[] path;
        #endregion

        #region Constructors
        public MapGrafo()
        {
            InitializeComponent();
            dataMarkers = new DataMarkers();
            gmap.MapProvider = BingMapProvider.Instance;
            GMaps.Instance.Mode = AccessMode.ServerAndCache;
            gmap.Position = new PointLatLng(9.921031, -84.036371);
            gmap.ShowCenter = false;
            gmap.OnMarkerClick += Gmap_OnMarkerClick;
        }
        #endregion

        #region Overrides
        protected override void Dispose(bool disposing)
        {
            gmap.OnMarkerClick -= Gmap_OnMarkerClick;

            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.UploadRoutes();
            this.UploadMarkers();
            gmap.Zoom++;
            gmap.Zoom--;
        }
        #endregion

        #region Protected
        protected void UploadMarkers()
        {
            markers = new GMapOverlay("markers");
            foreach (KeyValuePair<int, Place> dot in dataMarkers.places)
            {
                GMapMarker marker = new GMarkerGoogle(new PointLatLng(dot.Value.latitude, dot.Value.longitud), GMarkerGoogleType.green_dot);
                marker.ToolTipText = dot.Value.name;
                marker.ToolTip.Fill = Brushes.Black;
                marker.ToolTip.Foreground = Brushes.White;
                marker.ToolTip.Stroke = Pens.Black;
                marker.ToolTip.TextPadding = new Size(20, 20);
                markers.Markers.Add(marker);
            }
            gmap.Overlays.Add(markers);
        }

        protected void UploadRoutes()
        {
            DataMarkers dataroute = new DataMarkers();
            routes = new GMapOverlay("routes");
            
            for (int i = 0; i < (int)Math.Sqrt(dataMarkers.arcs.Length); i++)
            {
                for (int j = 0; j < (int)Math.Sqrt(dataMarkers.arcs.Length); j++)
                {
                    if (dataroute.arcs[i, j] == 1)
                    {
                        List<PointLatLng> points = new List<PointLatLng>();
                        points.Add(new PointLatLng(dataMarkers.places[i].latitude, dataMarkers.places[i].longitud)); //Source
                        points.Add(new PointLatLng(dataMarkers.places[j].latitude, dataMarkers.places[j].longitud)); //End
                        GMapRoute route = new GMapRoute(points, "Path");
                        route.Stroke = new Pen(Color.Blue, 3);
                        routes.Routes.Add(route);
                        dataMarkers.arcs[i, j] = route.Distance;
                        ShowDistances();
                    }
                }
            }
            this.auxMatrix = dataMarkers.arcs;
            gmap.Overlays.Add(routes);
        }

        protected void ChangeColorMark(GMapMarker item, int key)
        {
            GMapOverlay auxMarkers;
            this.markers.Markers.Remove(item);
            item = new GMarkerGoogle(new PointLatLng(dataMarkers.places[key].latitude, dataMarkers.places[key].longitud), GMarkerGoogleType.blue_dot);
            item.ToolTipText = dataMarkers.places[key].name;
            item.ToolTip.Fill = Brushes.Black;
            item.ToolTip.Foreground = Brushes.White;
            item.ToolTip.Stroke = Pens.Black;
            item.ToolTip.TextPadding = new Size(20, 20);
            this.markers.Markers.Add(item);
            auxMarkers = this.markers;
            gmap.Overlays.Remove(this.markers);
            gmap.Overlays.Add(auxMarkers);
        }

        protected void ChangeColorRoute(int start, int final)
        {
            List<PointLatLng> points = new List<PointLatLng>();
            points.Add(new PointLatLng(dataMarkers.places[start].latitude, dataMarkers.places[start].longitud)); //Source
            points.Add(new PointLatLng(dataMarkers.places[final].latitude, dataMarkers.places[final].longitud)); //End
            GMapRoute route = new GMapRoute(points, "Min Way");
            route.Stroke = new Pen(Color.Red, 3);
            routes.Routes.Add(route);
            gmap.Overlays.Remove(this.routes);
            gmap.Overlays.Add(routes);
        }

        protected void Reset()
        {
            this.source = -1;
            this.end = -1;
            this.countMark = 0;
            gmap.Overlays.Remove(this.markers);
            gmap.Overlays.Remove(this.routes);
            this.UploadMarkers();
            this.UploadRoutes();
            gmap.Zoom--;
            gmap.Zoom++;
        }

        protected void ShowDistances()
        {
            string textInf = $"Distancia por tramo: \r\n"+
                $" \r\n";
            
            for(int i = 0;i< (int)Math.Sqrt(dataMarkers.arcs.Length);i++)
            {
                for(int j = 0; j < (int)Math.Sqrt(dataMarkers.arcs.Length); j++)
                {
                    if(dataMarkers.arcs[i, j] > 0)
                    {
                        textInf = textInf + $"{dataMarkers.places[i].name} a {dataMarkers.places[j].name}\r\n" +
                        $"Distancia: {dataMarkers.arcs[i, j].ToString("0.000")} Km\r\n"+
                        $" \r\n";
                    }
                    
                } 
            }
            txtDistance.Text = textInf;
        }
        #endregion

        #region Events
        private void Gmap_OnMarkerClick(GMapMarker item, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.countMark++;
                int key = dataMarkers.places.Where(p => p.Value.name == item.ToolTipText).FirstOrDefault().Key;

                if (this.countMark == 1)
                {
                    source = key;
                    ChangeColorMark(item, key);
                }

                if (this.countMark == 2)
                {
                    this.end = key;
                    ChangeColorMark(item, key);
                }
            }

            if(e.Button == MouseButtons.Right)
            {
                if (this.countMark == 0)
                {
                    int key = dataMarkers.places.Where(p => p.Value.name == item.ToolTipText).FirstOrDefault().Key;
                    source = key;
                    ChangeColorMark(item, key);
                    this.countMark = 2;
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.Reset();
        }

        private void btnZoomP_Click(object sender, EventArgs e)
        {
            gmap.Zoom++;
        }

        private void btnZoomM_Click(object sender, EventArgs e)
        {
            gmap.Zoom--;
        }

        private void btnMinWay_Click(object sender, EventArgs e)
        {
            if (this.countMark == 2)
            {
                this.dijkstraMin = new DijkstraMin(auxMatrix, this.source);
                dijkstraMin.RunDijkstraMin();
                this.path = dijkstraMin.Path;
                int key = path[this.end];
                lblrDistancia.Text = dijkstraMin.Distance[this.end].ToString();

                if (key == -1)
                {
                    MessageBox.Show("No se encuentra una ruta para su destino.", "Informacion");
                    this.Reset();
                }
                else
                {
                    ChangeColorRoute(this.end, path[this.end]);
                }

                while (key != this.source && key != -1)
                { 
                    GMapMarker item = new GMarkerGoogle(new PointLatLng(dataMarkers.places[key].latitude, dataMarkers.places[key].longitud), GMarkerGoogleType.green_dot);
                    ChangeColorRoute(key, path[key]);
                    ChangeColorMark(item,key);
                    key = path[key];
                }  
            }
            else
            {
                MessageBox.Show("Debe seleccionar un inicio y un destino con el click izquierdo.", "Informacion");
            }
            
        }

        private void btnMaxWay_Click(object sender, EventArgs e)
        {
            if (this.countMark == 2)
            {
                this.dijkstraMax = new DijkstraMax(auxMatrix, this.source);
                this.path = dijkstraMax.RunDijkstraMax();
                int key = path[this.end];

                if (key == -1)
                {
                    MessageBox.Show("No se encuentra una ruta para su destino.", "Informacion");
                    this.Reset();
                }
                else
                {
                    ChangeColorRoute(this.end, path[this.end]);
                }

                while (key != this.source && key != -1)
                {
                    GMapMarker item = new GMarkerGoogle(new PointLatLng(dataMarkers.places[key].latitude, dataMarkers.places[key].longitud), GMarkerGoogleType.green_dot);
                    ChangeColorMark(item, key);
                    ChangeColorRoute(key, path[key]);
                    key = path[key];
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un inicio y un destino con el click izquierdo.", "Informacion");
            }
        }

        private void btnAdyacents_Click(object sender, EventArgs e)
        {
            if (this.countMark == 2)
            {
                DijkstraMin dijkstraMinAdj = new DijkstraMin(auxMatrix, 0);
                dijkstraMinAdj.RunDijkstraMin();

                for (int i = 0; i < (int)Math.Sqrt(dataMarkers.arcs.Length); i++)
                {
                    if (dataMarkers.arcs[this.source, i] != 0)
                    {
                        GMapMarker item = new GMarkerGoogle(new PointLatLng(dataMarkers.places[source].latitude, dataMarkers.places[source].longitud), GMarkerGoogleType.green_dot);
                        ChangeColorRoute(source, i);
                        ChangeColorMark(item, i); 
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un marcador con el click derecho.", "Informacion");
            }
        }
        #endregion
    }
}
