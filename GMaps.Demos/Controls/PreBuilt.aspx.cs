﻿using System;
using Subgurim.Controles;

namespace Demos.Controls
{
    public partial class PreBuilt : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GControl control = new GControl(GControl.preBuilt.LargeMapControl);
            GControl control2 = new GControl(GControl.preBuilt.MenuMapTypeControl, new GControlPosition(GControlPosition.position.Top_Right));

            GMap1.Add(control);
            GMap1.Add(control2);
            GMap1.Add(new GControl(GControl.preBuilt.StreetViewControl, new GControlPosition(GControlPosition.position.Bottom_Right))); 
        }
    }
}