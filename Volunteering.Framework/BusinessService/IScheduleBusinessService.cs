using ResultCommunication;
using System;
using System.Threading.Tasks;
using Volunteering.Framework.BusinessService.Models;

namespace Volunteering.Framework.BusinessService
{
    public interface IScheduleBusinessService
    {

        Task<IExecutionResult> CreateSchedule(ScheduleWriteModel schedule);

        Task<IExecutionResult> DeleteSchedule(Guid scheduleId);

        Task<IExecutionResult> GetSchedule(Guid scheduleId);

        Task<IExecutionResult> GetSchedules(Dataservices.Filters.ScheduleFilters filters);

        Task<IExecutionResult> UpdateSchedule(ScheduleWriteModel schedule);

    }
}