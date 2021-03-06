﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// Your custom recording code should go in this file.
// The designer will only add methods to this file, so your custom code won't be overwritten.
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace POCSmiles.Mobile.RxBrowser.Pagamento
{
    public partial class PagamentoComTecladoVirtual
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }

        public void SelectItemListBox(string selectTagElement, string itemName)
        {
        	try 
        	{
        		if(itemName.Equals("")){
        			return;
        		}
        		Report.Log(ReportLevel.Info,"Selecting item '" + itemName + "'");
        		Utils.SelectItemListBoxAsHuman(repo.SmilesOMelhorProgramaDeMilhasS1.AbsoluteBasePath.ToResolvedString() + selectTagElement, itemName,"1");
        		Report.Log(ReportLevel.Info,"Item '" + itemName + "' selected");
        	} catch (Exception) 
        	{
        		Report.Error("BuscarVoos - Error launched trying to select item '" + itemName + "' on element '" + selectTagElement + "'");
        		throw new System.Exception("BuscarVoos.SelectItemListBoxAsHuman");
        	}
        }

        public void TypeKeys(string element, string text)
        {
        	try 
        	{
        		if (text.Equals("")) {
        			return;
        		}
        		Report.Log(ReportLevel.Info,"Inserting text '" + text + "'");
        		InputTag input = repo.SmilesOMelhorProgramaDeMilhasS1.AbsoluteBasePath.ToResolvedString() + element;
        		input.PressKeys(text,Duration.FromMilliseconds(10));
        		Report.Log(ReportLevel.Info,"Text inserted '" + text + "'");
        	} catch (Exception) 
        	{
        		Report.Screenshot();
        		Keyboard.Press("{NEXT}");
        		Report.Error("ComprarPassagem - Error launched trying to inserting text '" + text + "' on element '" + element + "'");
        		throw new System.Exception("ComprarPassagem.TypeKeys");
        	}
        }
        
        public void selectList(string text, string element){
        	try {
        		Report.Info("Selecting item " + text);
        		Utils.SelectItemListBoxContains(repo.RxBrowser.Dom.AbsoluteBasePath.ToResolvedString() + element,text);
        		Report.Info(text + " selected");
        	} catch (Exception e) {
        		Report.Error("PagamentoComTecladoVirtual - Error launched trying to select item " + text + ". Error: " + e.Message);
        		throw new System.Exception("Fatal error");
        	}
        }
        public void selectListAsHuman(string text, string element){
        	try {
        		Report.Info("Selecting item " + text);
        		Utils.SelectItemListBoxContainsAsHuman(repo.RxBrowser.Dom.AbsoluteBasePath.ToResolvedString(),element,text);
        		Report.Info(text + " selected");
        	} catch (Exception e) {
        		Report.Error("PagamentoComTecladoVirtual - Error launched trying to select item " + text + ". Error: " + e.Message);
        		throw new System.Exception("Fatal error");
        	}
        }
    }
}
