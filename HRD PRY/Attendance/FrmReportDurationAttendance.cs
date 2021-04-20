using HRD_PRY.Util;
using Syncfusion.Data;
using Syncfusion.WinForms.DataGrid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRD_PRY.Attendance
{
    public partial class FrmReportDurationAttendance : Form
    {
        public FrmReportDurationAttendance()
        {
            InitializeComponent();
        }
        private DataTable getKaryawan(List<DateTime> week1, List<DateTime> week2, List<DateTime> week3, List<DateTime> week4, List<DateTime> week5, List<DateTime> week6)
        {
            DataTable dt = new DataTable();


            string query = @"SELECT Employee_id,Employee_Number,Employee_Name FROM EMPLOYEES where ISNULL(termination_date,'') = ''";
            using (SqlCommand cmd = new SqlCommand(query, ConnUtil.connection))
            {
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(dt);
                }
            }

            foreach (DateTime dateWeek1 in week1)
            {
                dt.Columns.Add(dateWeek1.ToShortDateString(), typeof(string));
            }
            dt.Columns.Add("Duration1", typeof(int));
            foreach (DateTime dateWeek2 in week2)
            {
                dt.Columns.Add(dateWeek2.ToShortDateString(), typeof(string));
            }
            dt.Columns.Add("Duration2", typeof(int));
            foreach (DateTime dateWeek3 in week3)
            {
                dt.Columns.Add(dateWeek3.ToShortDateString(), typeof(string));
            }
            dt.Columns.Add("Duration3", typeof(int));
            foreach (DateTime dateWeek4 in week4)
            {
                dt.Columns.Add(dateWeek4.ToShortDateString(), typeof(string));
            }
            dt.Columns.Add("Duration4", typeof(int));
            foreach (DateTime dateWeek5 in week5)
            {
                dt.Columns.Add(dateWeek5.ToShortDateString(), typeof(string));
            }
            dt.Columns.Add("Duration5", typeof(int));
            if (week6.Count > 0)
            {
                foreach (DateTime dateWeek6 in week6)
                {
                    dt.Columns.Add(dateWeek6.ToShortDateString(), typeof(string));
                }
                dt.Columns.Add("Duration6", typeof(int));
            }
            dt.Columns.Add("DurationALL", typeof(int));
           

            return dt;
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            this.GridAttendance.DataSource = null;
            this.GridAttendance.Columns.Clear();
            DateTime firstdateTo = new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, 1);
            string startdate1 = firstdateTo.ToString("yyyy/MM/dd");
            string enddate1 = firstdateTo.AddMonths(1).AddDays(-1).ToString("yyyy/MM/dd");
            var week1 = new List<DateTime>();
            var week2 = new List<DateTime>();
            var week3 = new List<DateTime>();
            var week4 = new List<DateTime>();
            var week5 = new List<DateTime>();
            var week6 = new List<DateTime>();
            DateTime startdate = DateTime.ParseExact(startdate1, "yyyy/MM/dd", System.Globalization.CultureInfo.InvariantCulture);
            DateTime enddate = DateTime.ParseExact(enddate1, "yyyy/MM/dd", System.Globalization.CultureInfo.InvariantCulture);
            DateTime date = startdate;
            int i = 1;
            while (date <= enddate)
            {

                if (!(date.DayOfWeek == DayOfWeek.Sunday))
                {
                    if (i == 1)
                    {
                        week1.Add(date);
                    }
                    if (i == 2)
                    {
                        week2.Add(date);
                    }
                    if (i == 3)
                    {
                        week3.Add(date);
                    }
                    if (i == 4)
                    {
                        week4.Add(date);
                    }
                    if (i == 5)
                    {
                        week5.Add(date);
                    }
                    if (i == 6)
                    {
                        week6.Add(date);
                    }
                }
                else
                {
                    if (i == 1)
                    {
                        week1.Add(date);

                    }
                    if (i == 2)
                    {
                        week2.Add(date);
                    }
                    if (i == 3)
                    {
                        week3.Add(date);
                    }
                    if (i == 4)
                    {
                        week4.Add(date);
                    }
                    if (i == 5)
                    {
                        week5.Add(date);
                    }
                    if (i == 6)
                    {
                        week6.Add(date);
                    }
                    i = i + 1;
                }
                date = date.AddDays(1);
            }
            this.GridAttendance.Columns.Add(new GridTextColumn() { MappingName = "Employee_id", HeaderText = "Employee Id", Visible = false, Width = 100 });
            this.GridAttendance.Columns.Add(new GridTextColumn() { MappingName = "Employee_Number", HeaderText = "Employee Number", Width = 170 });
            this.GridAttendance.Columns.Add(new GridTextColumn() { MappingName = "Employee_Name", HeaderText = "Employee Name", Width = 220 });

            foreach (DateTime dateWeek1 in week1)
            {
                this.GridAttendance.Columns.Add(new GridTextColumn() { MappingName = dateWeek1.ToShortDateString(), HeaderText = dateWeek1.ToString("dd-MMM-yy") });

            }
            this.GridAttendance.Columns.Add(new GridTextColumn() { MappingName = "Duration1", HeaderText = "Akumulasi" });
            foreach (DateTime dateWeek2 in week2)
            {
                this.GridAttendance.Columns.Add(new GridTextColumn() { MappingName = dateWeek2.ToShortDateString(), HeaderText = dateWeek2.ToString("dd-MMM-yy") });
            }
            this.GridAttendance.Columns.Add(new GridTextColumn() { MappingName = "Duration2", HeaderText = "Akumulasi" });
            foreach (DateTime dateWeek3 in week3)
            {
                this.GridAttendance.Columns.Add(new GridTextColumn() { MappingName = dateWeek3.ToShortDateString(), HeaderText = dateWeek3.ToString("dd-MMM-yy") });
            }
            this.GridAttendance.Columns.Add(new GridTextColumn() { MappingName = "Duration3", HeaderText = "Akumulasi" });
            foreach (DateTime dateWeek4 in week4)
            {
                this.GridAttendance.Columns.Add(new GridTextColumn() { MappingName = dateWeek4.ToShortDateString(), HeaderText = dateWeek4.ToString("dd-MMM-yy") });
            }
            this.GridAttendance.Columns.Add(new GridTextColumn() { MappingName = "Duration4", HeaderText = "Akumulasi " });
            foreach (DateTime dateWeek5 in week5)
            {

                this.GridAttendance.Columns.Add(new GridTextColumn() { MappingName = dateWeek5.ToShortDateString(), HeaderText = dateWeek5.ToString("dd-MMM-yy") });
            }
            this.GridAttendance.Columns.Add(new GridTextColumn() { MappingName = "Duration5", HeaderText = "Akumulasi" });
            foreach (DateTime dateWeek6 in week6)
            {

                this.GridAttendance.Columns.Add(new GridTextColumn() { MappingName = dateWeek6.ToShortDateString(), HeaderText = dateWeek6.ToString("dd-MMM-yy") });
            }
            if (week6.Count > 0)
            {
                this.GridAttendance.Columns.Add(new GridTextColumn() { MappingName = "Duration6", HeaderText = "Akumulasi" });
            }
            this.GridAttendance.Columns.Add(new GridTextColumn() { MappingName = "DurationALL", HeaderText = "Akumulasi Bulanan" });
            GridAttendance.DataSource = getKaryawan(week1, week2, week3, week4, week5, week6);

            foreach (RecordEntry record in GridAttendance.View.Records)
            {
                int akumulasiWeek1 = 0;
                int akumulasiWeek2 = 0;
                int akumulasiWeek3 = 0;
                int akumulasiWeek4 = 0;
                int akumulasiWeek5 = 0;
                int akumulasiWeek6 = 0;
                var dataRowView = record.Data as DataRowView;

                if (dataRowView != null)
                {
                    foreach (DateTime dateWeek1 in week1)
                    {

                        int durasi = 0;
                        durasi = getDurationByDate
                                                                        (dateWeek1.ToShortDateString(), (int)dataRowView.Row["Employee_id"]);
                        dataRowView.Row[dateWeek1.ToShortDateString()] = durasi;
                        akumulasiWeek1 = akumulasiWeek1 + durasi;

                    }
                    dataRowView.Row["Duration1"] = akumulasiWeek1;
                    foreach (DateTime dateWeek2 in week2)
                    {
                        int durasi = 0;
                        durasi = getDurationByDate
                                                                        (dateWeek2.ToShortDateString(), (int)dataRowView.Row["Employee_id"]);
                        dataRowView.Row[dateWeek2.ToShortDateString()] = durasi;
                        akumulasiWeek2 = akumulasiWeek2 + durasi;
                    }
                    dataRowView.Row["Duration2"] = akumulasiWeek2;
                    foreach (DateTime dateWeek3 in week3)
                    {

                        int durasi = 0;
                        durasi = getDurationByDate
                                                                    (dateWeek3.ToShortDateString(), (int)dataRowView.Row["Employee_id"]);
                        dataRowView.Row[dateWeek3.ToShortDateString()] = durasi;
                        akumulasiWeek3 = akumulasiWeek3 + durasi;
                    }
                    dataRowView.Row["Duration3"] = akumulasiWeek3;
                    foreach (DateTime dateWeek4 in week4)
                    {
                        int durasi = 0;
                        durasi = getDurationByDate
                                                                                           (dateWeek4.ToShortDateString(), (int)dataRowView.Row["Employee_id"]);
                        dataRowView.Row[dateWeek4.ToShortDateString()] = durasi;
                        akumulasiWeek4 = akumulasiWeek4 + durasi;
                    }
                    dataRowView.Row["Duration4"] = akumulasiWeek4;
                    foreach (DateTime dateWeek5 in week5)
                    {

                        int durasi = 0;
                        durasi = getDurationByDate
                                                                                             (dateWeek5.ToShortDateString(), (int)dataRowView.Row["Employee_id"]);
                        dataRowView.Row[dateWeek5.ToShortDateString()] = durasi;
                        akumulasiWeek5 = akumulasiWeek5 + durasi;
                    }
                    dataRowView.Row["Duration5"] = akumulasiWeek5;
                    if (week6.Count > 0)
                    {
                        foreach (DateTime dateWeek6 in week6)
                        {

                            int durasi = 0;
                            durasi = getDurationByDate
                                                                                                 (dateWeek6.ToShortDateString(), (int)dataRowView.Row["Employee_id"]);
                            dataRowView.Row[dateWeek6.ToShortDateString()] = durasi;
                            akumulasiWeek6 = akumulasiWeek6 + durasi;
                        }
                        dataRowView.Row["Duration6"] = akumulasiWeek6;
                    }
                    int totalAkumulasi = 0;
                    totalAkumulasi = akumulasiWeek1 + akumulasiWeek2 + akumulasiWeek3 + akumulasiWeek4 + akumulasiWeek5 + akumulasiWeek6;
                    dataRowView.Row["DurationALL"] = totalAkumulasi;


                }

            }

        }

        private int getDurationByDate(string dateString, int employee_id)
        {
            DataTable dt = new DataTable();

            int duration = 0;

            //string query = @"SELECT ISNULL(att.attendance_id,0) attendance_id,Employee_Number,Employee_Name, unit.unit_name, att.Date_attendance,att.Clock_in,att.Clock_out,ISNULL(CONVERT(varchar(5), DATEADD(minute, DATEDIFF(MINUTE,  Clock_in,clock_out), 0), 114),'') Duration FROM Employees emp left join Attendance att
            //				on emp.Employee_id = att.Employee_id LEFT JOIN MST_UNIT unit on unit.unit_id = emp.unit_id
            //				where ISNULL(att.Date_attendance,@dateAtt) = @dateAtt";
            string query = @"SELECT ISNULL(DATEDIFF(hour,  Clock_in,clock_out), 0) as Duration 
                               FROM Employees emp left join Attendance att
							on emp.Employee_id = att.Employee_id 
							where ISNULL(att.Date_attendance,@dateAtt) = @dateAtt
							and emp.Employee_id =@emp_id";
            using (SqlCommand cmd = new SqlCommand(query, ConnUtil.connection))
            {
                cmd.Parameters.AddWithValue("@dateAtt", dateString);
                cmd.Parameters.AddWithValue("@emp_id", employee_id);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        duration = (int)reader["Duration"];
                    }


                }
                reader.Close();
            }
            return duration;
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            ClsUtil.DownloadXLs(GridAttendance);
        }
    }


}
