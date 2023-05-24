﻿using DataBase;
using Microsoft.Reporting.WinForms;

namespace CourseManagement
{
    internal class LocalSubReport
    {
        static public void Processing(object sender, SubreportProcessingEventArgs e)
        {
            e.DataSources.Clear();

            if (e.ReportPath == "SubReportListByClass")
            {
                e.DataSources.Add(new ReportDataSource("dtListAttendance", ChangeSomeValuesInTheDataTable.DtListAttendance(ListAttendance.GetListAttendanceByStudentId(int.Parse(e.Parameters["student_id"].Values[0])))));
            }
        }
    }
}
