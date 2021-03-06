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

namespace POCSmiles.Mobile.RxBrowser.Login
{
    public partial class LoginHeader
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }

        public void AtualizarMilhasBD(string CPFSmilesID, string URL)
        {
        	try {
        		Smiles_UserCode.AtualizarMilhasBDMobile(CPFSmilesID, URL, repo);
        	}catch (Exception e) {
        		Report.Error("Database query execution  exception- Error updating user in data base: " + e.Message);	
        	}
        }

        public void Logout()
        {
            // TODO: Replace the following line with your code implementation.
            throw new NotImplementedException();
        }

        public void WaitForDocumentLoad()
        {
        	try {
        		if (!repo.RxBrowser.Self.Element.GetAttributeValueText("OSVersion").ToUpper().Contains("IOS")) {
        			Report.Log(ReportLevel.Info, "Invoke Action", "Invoking WaitForDocumentLoaded() on item 'RxBrowser.Dom'.", repo.RxBrowser.Dom.SelfInfo, new RecordItemIndex(3));
		            repo.RxBrowser.Dom.Self.WaitForDocumentLoaded();
		            Delay.Milliseconds(0);
        		}
        	} catch (Exception e) {
        		Report.Failure("Error launched trying to wwait dom statte. Error: " + e.Message);
        		throw new Exception("FAtal error");
        	}
        }

    }
}
