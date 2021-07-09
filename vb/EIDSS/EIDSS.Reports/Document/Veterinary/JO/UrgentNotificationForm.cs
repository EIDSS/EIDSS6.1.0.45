using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using EIDSS.Reports.BaseControls.Report;
using System.Collections.Generic;
using bv.model.BLToolkit;
using System.Data.SqlClient;

namespace EIDSS.Reports.Document.Veterinary.JO
{
    public partial class UrgentNotificationForm : BaseDocumentReport
    {
        public UrgentNotificationForm()
        {
            InitializeComponent();
        }

        public override void SetParameters(string lang, Dictionary<string, string> parameters, DbManagerProxy manager, DbManagerProxy archiveManager)
        {
            base.SetParameters(lang, parameters, manager, archiveManager);
            string caseId = GetStringParameter(parameters, "@ObjID");

            spRepVetNotificationFormJoTableAdapter.Connection = (SqlConnection)manager.Connection;
            spRepVetNotificationFormJoTableAdapter.Transaction = (SqlTransaction)manager.Transaction;

            urgentNotificationFormDataSet1.EnforceConstraints = false;
            spRepVetNotificationFormJoTableAdapter.Fill(urgentNotificationFormDataSet1.spRepVetNotificationFormJo, lang, long.Parse(caseId));


            spRepVetNotificationFormJoLabTestResultsTableAdapter.Connection = (SqlConnection)manager.Connection;
            spRepVetNotificationFormJoLabTestResultsTableAdapter.Transaction = (SqlTransaction)manager.Transaction;

            spRepVetNotificationFormJoLabTestResultsTableAdapter.Fill(urgentNotificationFormDataSet1.spRepVetNotificationFormJoLabTestResults, lang, long.Parse(caseId));

            //ReportRtlHelper.SetRTL(this);
        }

        private void xrLabel5_EvaluateBinding(object sender, BindingEventArgs e)
        {
            string datePattern = System.Globalization.CultureInfo.CurrentUICulture.DateTimeFormat.ShortDatePattern;
            e.Binding.FormatString = "{0:" + datePattern + "}";  
        }

    }
}
