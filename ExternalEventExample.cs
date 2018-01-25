﻿using Autodesk.Revit.DB;
using Autodesk.Revit.DB.Structure;
using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevitHP
{
    public class ExternalEventExample : IExternalEventHandler
    {
        public void Execute(UIApplication app)
        {
            CreateTables();
        }
        public void CreateTables()
        {
            var uiDoc = BtnFamilyBrowser.GetDoc();
            if (uiDoc == null) return;
            var document = uiDoc.Document;

            if (document == null) return;

            //String fileName = @"E:\电动两通阀.0002.rfa";
            String fileName = RevitBiz.openfamilypath;
            // try to load family
            Family family = null;
            using (Transaction tx = new Transaction(document))
            {
                tx.Start("load family");
                document.LoadFamily(fileName, out family);

                tx.Commit();
            }


            //using (SubTransaction tx2 = new SubTransaction(document))
            //{
                foreach (ElementId id in family.GetFamilySymbolIds())
                {
                    var symbol = document.GetElement(id) as FamilySymbol;
                    if (symbol != null)
                    {
                        try
                        {
                            uiDoc.PromptForFamilyInstancePlacement(symbol);
                        }
                        catch (Exception ex)
                        {
                            string sss = ex.ToString();
                        }
                    }
                }
            //}

        }
        public string GetName()
        {
            return "External Event Example";
        }

    }
}
