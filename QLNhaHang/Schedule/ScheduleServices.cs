using System.Data.SqlClient;
using System.Data;

namespace QLNH.Schedule
{
    public class ScheduleServices
    {
        public void ShowListSchedule(DataGridView dgv)
        {
            ScheduleModel schedule = new ScheduleModel();
            schedule.ShowListSchedule(dgv);
        }

        public void ShowListScheduleByName(DataGridView dgv, string? name)
        {
            ScheduleModel schedule = new ScheduleModel();
            schedule.ShowListScheduleByName(dgv, name);
        }

        public void ShowSalary(DataGridView dgv, int month, int year)
        {
            ScheduleModel schedule = new ScheduleModel(month, year);
            schedule.ShowSalary(dgv);
        }

        public string CreateSchedule(string? manv, int ca, string? ngay)
        {
            ScheduleModel schedule = new ScheduleModel(manv, ca, ngay);
            return schedule.CreateSchedule();
        }

        public string UpdateSchedule(string? manv, int ca, string? ngay)
        {
            ScheduleModel schedule = new ScheduleModel(manv, ca, ngay);
            return schedule.UpdateSchedule();
        }

        public string DeleteSchedule(string? manv, string? ngay)
        {
            ScheduleModel schedule = new ScheduleModel(manv, ngay);
            return schedule.DeleteSchedule();
        }
    }
}
