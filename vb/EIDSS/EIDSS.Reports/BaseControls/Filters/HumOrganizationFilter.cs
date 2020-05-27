﻿using System;
using System.ComponentModel;
using System.Data;
using bv.common.db.Core;
using bv.winclient.Core;

namespace EIDSS.Reports.BaseControls.Filters
{
    public sealed partial class HumOrganizationFilter : BaseLookupFilter
    {
        private readonly ComponentResourceManager m_Resources = new ComponentResourceManager(typeof (HumOrganizationFilter));

        public HumOrganizationFilter()
        {
            InitializeComponent();
        }

        protected override string KeyColumnName
        {
            get { return "idfInstitution"; }
        }

        protected override string ValueColumnName
        {
            get { return "name"; }
        }

        protected override string LookupCaption
        {
            get { return lblLookupName.Text; }
        }

        protected override DataView CreateDataSource()
        {
            if (WinUtils.IsComponentInDesignMode(this))
            {
                return new DataView();
            }

            DataView dataSource = LookupCache.Get(LookupTables.RepHumOrganization);
            if (dataSource == null)
            {
                throw new ApplicationException("Hum Organization Lookup is not filled");
            }
            dataSource.RowFilter = "intRowStatus <> 1";
            return dataSource;
        }

        protected override void ApplyResources()
        {
            base.ApplyResources();

            lblLookupName.Text = m_Resources.GetString("lblLookupName.Text");
        }
    }
}