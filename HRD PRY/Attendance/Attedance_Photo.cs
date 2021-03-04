using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRD_PRY.Attendance
{
    class Attedance_Photo
    {

        public int Attendance_Photo_id { get; set; }
        public int Attendance_id { get; set; }
        public byte[] image_string { get; set; }

        public DateTime? upload_date { get; set; }
    }
}
