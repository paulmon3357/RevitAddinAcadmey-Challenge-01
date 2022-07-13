#region Namespaces
using Autodesk.Revit.ApplicationServices;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;

#endregion

namespace RevitAddinAcadmey_Challenge_01
{
    internal class App : IExternalApplication
    {
        public Result OnStartup(UIControlledApplication a)
        {
            TaskDialog.Show("REVIT Add-in Academy", "Welcome to REVIT Add-in Acadmey!\n2022-07-12");
            return Result.Succeeded;
        }

        public Result OnShutdown(UIControlledApplication a)
        {
            TaskDialog.Show("REVIT Add-in Academy", "Exiting REVIT Add-in Acadmey!\n2022-07-12");
            return Result.Succeeded;
        }
    }
}
