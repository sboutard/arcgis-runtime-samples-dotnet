// Copyright 2016 Esri.
//
// Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except in compliance with the License.
// You may obtain a copy of the License at: http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on an 
// "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the License for the specific 
// language governing permissions and limitations under the License.

using Esri.ArcGISRuntime.Geometry;
using Esri.ArcGISRuntime.Mapping;
using System;

namespace ArcGISRuntime.UWP.Samples.FeatureLayerUrl
{
    [ArcGISRuntime.Samples.Shared.Attributes.Sample(
        "Feature layer (feature service)",
        "Layers",
        "This sample demonstrates how to show a feature layer on a map using the URL to the service.",
        "")]
    public partial class FeatureLayerUrl
    {
        public FeatureLayerUrl()
        {
            InitializeComponent();

            // Setup the control references and execute initialization 
            Initialize();
        }

        private void Initialize()
        {
            // Create new Map with basemap
            Map myMap = new Map(Basemap.CreateTerrainWithLabels());

            // Create and set initial map location
            MapPoint initialLocation = new MapPoint(
                -13176752, 4090404, SpatialReferences.WebMercator);
            myMap.InitialViewpoint = new Viewpoint(initialLocation, 300000);

            // Create uri to the used feature service
            Uri serviceUri = new Uri(
                "https://sampleserver6.arcgisonline.com/arcgis/rest/services/Energy/Geology/FeatureServer/9");

            // Create new FeatureLayer from service uri and
            FeatureLayer geologyLayer = new FeatureLayer(serviceUri);

            // Add created layer to the map
            myMap.OperationalLayers.Add(geologyLayer);

            // Assign the map to the MapView
            MyMapView.Map = myMap;
        }
    }
}
