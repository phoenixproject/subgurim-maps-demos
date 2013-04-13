﻿using System;
using Subgurim.Controles;

namespace Demos.Geo
{
    public partial class Traffic : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GMap1.setCenter(new GLatLng(40.7, -74), 12);
            GMap1.enableGTrafficOverlay = true;
            GMap1.enableTransitOverlay = true;
        }
    }
}