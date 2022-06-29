using Autodesk.Revit.ApplicationServices;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System;

namespace RevitAddin.UserInfo.Revit.Commands
{
    [Transaction(TransactionMode.Manual)]
    public class Command : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elementSet)
        {
            UIApplication uiapp = commandData.Application;

            string caption = $"Revit {uiapp.Application.VersionBuild}";

            string text = "";
            text += $"IsLoggedIn:\t{Application.IsLoggedIn}\n";
            text += $"Username:\t{uiapp.Application.Username}\n";
            text += $"LoginUserId:\t{uiapp.Application.LoginUserId}\n";

            System.Windows.MessageBox.Show(text, caption);

            return Result.Succeeded;
        }
    }
}
