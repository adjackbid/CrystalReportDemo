﻿using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrystalReportDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                string sFrom = ttbFrom.Text.Trim();
                string sTo = ttbTo.Text.Trim();
                string sWeight = ttbWeight.Text.Trim();
                string sItemNo = ttbItemNo.Text.Trim();

                PrintLabel(sFrom, sTo, sWeight, sItemNo);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PrintLabel(string sFrom, string sTo, string sWeight, string sItemNo)
        {
            DSLabel ds = new DSLabel();

            //CREATE DataTable
            DataTable dt = ds.Tables[0];
            DataRow dr_row = null;
            dr_row = dt.NewRow();
            dr_row["FROM"] = sFrom;
            dr_row["TO"] = sTo;
            dr_row["WEIGHT"] = sWeight;
            dr_row["ITEMNO"] = sItemNo;
            dt.Rows.Add(dr_row);

            //Create CR Report Object
            ReportDocument doc = new CRLabel();
            doc.SetDataSource(ds);

            //Print
            doc.PrintToPrinter(1, false, 0, 0);
        }
    }
}
