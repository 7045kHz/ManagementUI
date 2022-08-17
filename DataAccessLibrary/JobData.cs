using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public class JobData : IJobData
    {
        private readonly ISqlDataAccess _db;

        public JobData(ISqlDataAccess db)
        {
            _db = db;
        }
        public Task<List<JobModel>> GetJobs()
        {
            string sql = "select * from [dbo].[JOB_INVENTORY]";
            return _db.LoadData<JobModel, dynamic>(sql, new { });
        }
        public Task InsertJob(JobModel job)
        {
            string sql = @"INSERT INTO  [dbo].[JOB_INVENTORY] (Name,Execution_Server,Enabled,Job_Definition,Job_Schedule)
                         VALUES (@Name,@Execution_Server,@Enabled,@Job_Definition,@Job_Schedule);";
            return _db.SaveData(sql, job);
        }
    }
}
