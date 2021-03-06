﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace POCSmiles.SolicitarMilhas
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The SolicitarMilhas recording.
    /// </summary>
    [TestModule("86a915ea-bd22-40e0-8c75-c32abef77135", ModuleType.Recording, 1)]
    public partial class SolicitarMilhas : ITestModule
    {
        /// <summary>
        /// Holds an instance of the POCSmiles.SmilesRepository repository.
        /// </summary>
        public static POCSmiles.SmilesRepository repo = POCSmiles.SmilesRepository.Instance;

        static SolicitarMilhas instance = new SolicitarMilhas();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public SolicitarMilhas()
        {
            NumeroVoo = "";
            LocalizadorVoo = "";
            DataVoo = "";
            CabineViagem = "";
            ClasseReserva = "";
            NomePassageiro = "";
            SobrenomePassageiro = "";
            AeroportoOrigem = "";
            AeroportoDestino = "";
            BilheteEletronico = "";
            AnexarBilheteEletronico = "";
            AnexarCartaoEmbarque = "";
            CompanhiaAerea = "";
            URL = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static SolicitarMilhas Instance
        {
            get { return instance; }
        }

#region Variables

        string _NumeroVoo;

        /// <summary>
        /// Gets or sets the value of variable NumeroVoo.
        /// </summary>
        [TestVariable("22839aa7-63de-4b63-b4e0-749ffe7b83f0")]
        public string NumeroVoo
        {
            get { return _NumeroVoo; }
            set { _NumeroVoo = value; }
        }

        string _LocalizadorVoo;

        /// <summary>
        /// Gets or sets the value of variable LocalizadorVoo.
        /// </summary>
        [TestVariable("63806c28-a57c-403f-8cfc-6969e1d321b3")]
        public string LocalizadorVoo
        {
            get { return _LocalizadorVoo; }
            set { _LocalizadorVoo = value; }
        }

        string _DataVoo;

        /// <summary>
        /// Gets or sets the value of variable DataVoo.
        /// </summary>
        [TestVariable("edf14d15-da3a-49c1-a266-f24472e1c124")]
        public string DataVoo
        {
            get { return _DataVoo; }
            set { _DataVoo = value; }
        }

        string _CabineViagem;

        /// <summary>
        /// Gets or sets the value of variable CabineViagem.
        /// </summary>
        [TestVariable("7a125f71-7fcb-41b7-97db-29f123736231")]
        public string CabineViagem
        {
            get { return _CabineViagem; }
            set { _CabineViagem = value; }
        }

        string _ClasseReserva;

        /// <summary>
        /// Gets or sets the value of variable ClasseReserva.
        /// </summary>
        [TestVariable("2ac000e0-c5f4-4a67-8277-efbe6680fd09")]
        public string ClasseReserva
        {
            get { return _ClasseReserva; }
            set { _ClasseReserva = value; }
        }

        string _NomePassageiro;

        /// <summary>
        /// Gets or sets the value of variable NomePassageiro.
        /// </summary>
        [TestVariable("316ed9f9-2587-450a-a28b-60a89c43b682")]
        public string NomePassageiro
        {
            get { return _NomePassageiro; }
            set { _NomePassageiro = value; }
        }

        string _SobrenomePassageiro;

        /// <summary>
        /// Gets or sets the value of variable SobrenomePassageiro.
        /// </summary>
        [TestVariable("45b5f8f9-62be-4d7c-96ab-b3f1bf8e9daf")]
        public string SobrenomePassageiro
        {
            get { return _SobrenomePassageiro; }
            set { _SobrenomePassageiro = value; }
        }

        string _AeroportoOrigem;

        /// <summary>
        /// Gets or sets the value of variable AeroportoOrigem.
        /// </summary>
        [TestVariable("d51e8809-0e31-4fb3-8760-f56eb9ac7de7")]
        public string AeroportoOrigem
        {
            get { return _AeroportoOrigem; }
            set { _AeroportoOrigem = value; }
        }

        string _AeroportoDestino;

        /// <summary>
        /// Gets or sets the value of variable AeroportoDestino.
        /// </summary>
        [TestVariable("c6f56b2d-ca94-40ea-843c-82baf8dae56b")]
        public string AeroportoDestino
        {
            get { return _AeroportoDestino; }
            set { _AeroportoDestino = value; }
        }

        string _BilheteEletronico;

        /// <summary>
        /// Gets or sets the value of variable BilheteEletronico.
        /// </summary>
        [TestVariable("ea0f2948-1c08-4783-b88f-137d697b379c")]
        public string BilheteEletronico
        {
            get { return _BilheteEletronico; }
            set { _BilheteEletronico = value; }
        }

        string _AnexarBilheteEletronico;

        /// <summary>
        /// Gets or sets the value of variable AnexarBilheteEletronico.
        /// </summary>
        [TestVariable("30dbb512-6441-4770-9b50-13c9a393c858")]
        public string AnexarBilheteEletronico
        {
            get { return _AnexarBilheteEletronico; }
            set { _AnexarBilheteEletronico = value; }
        }

        string _AnexarCartaoEmbarque;

        /// <summary>
        /// Gets or sets the value of variable AnexarCartaoEmbarque.
        /// </summary>
        [TestVariable("9102357d-ff57-46f6-8de9-d098657b6b55")]
        public string AnexarCartaoEmbarque
        {
            get { return _AnexarCartaoEmbarque; }
            set { _AnexarCartaoEmbarque = value; }
        }

        string _CompanhiaAerea;

        /// <summary>
        /// Gets or sets the value of variable CompanhiaAerea.
        /// </summary>
        [TestVariable("bd78985c-90ec-4418-ac05-c8fa1834c734")]
        public string CompanhiaAerea
        {
            get { return _CompanhiaAerea; }
            set { _CompanhiaAerea = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable URL.
        /// </summary>
        [TestVariable("aa7b91c3-8944-44bc-a709-ada666e82f1a")]
        public string URL
        {
            get { return repo.URL; }
            set { repo.URL = value; }
        }

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "6.2")]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "6.2")]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            SelectItemListBox("//select[#'_smilescreditrequestportlet_WAR_smilesmemberportlet_airlines']", CompanhiaAerea);
            Delay.Milliseconds(0);
            
            SetCalendarDate("//img[@title='...']", DataVoo);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SmilesOMelhorProgramaDeMilhasS1' at Center.", repo.SmilesOMelhorProgramaDeMilhasS1.SelfInfo, new RecordItemIndex(2));
            repo.SmilesOMelhorProgramaDeMilhasS1.Self.Click(1);
            Delay.Milliseconds(0);
            
            CheckVisible();
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{TAB}{TAB}'.", new RecordItemIndex(4));
            //Keyboard.Press("{TAB}{TAB}");
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{TAB}'.", new RecordItemIndex(5));
            //Keyboard.Press("{TAB}");
            //Delay.Milliseconds(0);
            
            TypeKeys("//input[@name='_smilescreditrequestportlet_WAR_smilesmemberportlet_flightNumber' and @visible='True']", NumeroVoo);
            Delay.Milliseconds(0);
            
            TypeKeys("//input[@name~'_smilescreditrequestportlet_WAR_smilesmemberportlet_trackingNumber' and @visible='True']", LocalizadorVoo);
            Delay.Milliseconds(0);
            
            SelectItemListBox("//select[#'cabineTravel1']", CabineViagem);
            Delay.Milliseconds(0);
            
            SelectItemListBox("//select[#'cabineReserve1']", ClasseReserva);
            Delay.Milliseconds(0);
            
            TypeKeys("//input[@name='_smilescreditrequestportlet_WAR_smilesmemberportlet_passengerFirstName' and @visible='True']", NomePassageiro);
            Delay.Milliseconds(0);
            
            TypeKeys("//input[@name='_smilescreditrequestportlet_WAR_smilesmemberportlet_passengerLastName' and @visible='True']", SobrenomePassageiro);
            Delay.Milliseconds(0);
            
            SelectItemFloatBox("//input[@name='_smilescreditrequestportlet_WAR_smilesmemberportlet_originAirport' and @visible='True']", "//div[@class='searchFlightTab' and @Visible='True']", AeroportoOrigem);
            Delay.Milliseconds(0);
            
            SelectItemFloatBox("//input[@name='_smilescreditrequestportlet_WAR_smilesmemberportlet_destinyAirport' and @visible='True']", "//div[@class='searchFlightTab' and @Visible='True']", AeroportoDestino);
            Delay.Milliseconds(0);
            
            TypeKeys("//input[@name='_smilescreditrequestportlet_WAR_smilesmemberportlet_eticketNumber' and @visible='True']", BilheteEletronico);
            Delay.Milliseconds(0);
            
            anexarArquivo(AnexarCartaoEmbarque, "//input[@name='_smilescreditrequestportlet_WAR_smilesmemberportlet_fileEticket' and @type='file' and @visible='True']");
            Delay.Milliseconds(0);
            
            anexarArquivo(AnexarCartaoEmbarque, "//input[@name='_smilescreditrequestportlet_WAR_smilesmemberportlet_fileBoardingPass' and @type='file' and @visible='True']");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SmilesOMelhorProgramaDeMilhasS1' at Center.", repo.SmilesOMelhorProgramaDeMilhasS1.SelfInfo, new RecordItemIndex(17));
            repo.SmilesOMelhorProgramaDeMilhasS1.Self.Click(1);
            Delay.Milliseconds(490);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Next}'.", new RecordItemIndex(18));
            Keyboard.Press("{Next}", 5);
            Delay.Milliseconds(90);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SmilesOMelhorProgramaDeMilhasS1.SolicitarMilhas_SolicitarMilhasDeVoo' at Center.", repo.SmilesOMelhorProgramaDeMilhasS1.SolicitarMilhas_SolicitarMilhasDeVooInfo, new RecordItemIndex(19));
            repo.SmilesOMelhorProgramaDeMilhasS1.SolicitarMilhas_SolicitarMilhasDeVoo.Click(1);
            Delay.Milliseconds(490);
            
            clickIfExists();
            Delay.Milliseconds(0);
            
            Report.Screenshot(ReportLevel.Success, "User", "", null, false, new RecordItemIndex(21));
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
