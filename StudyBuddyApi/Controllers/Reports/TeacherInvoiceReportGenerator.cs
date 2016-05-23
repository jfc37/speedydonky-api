using System.Linq;
using Contracts.Reports.TeacherInvoices;
using Data.Repositories;
using Models;
using NHibernate.Linq;

namespace SpeedyDonkeyApi.Controllers.Reports
{
    /// <summary>
    /// Generates teacher invoice reports
    /// </summary>
    public class TeacherInvoiceReportGenerator : ITeacherInvoiceReportGenerator
    {
        private readonly IRepository<Event> _repository;

        public TeacherInvoiceReportGenerator(IRepository<Event> repository)
        {
            _repository = repository;
        }

        public TeacherInvoiceResponse Create(TeacherInvoiceRequest request)
        {
            var eventsInRange = _repository.Queryable()
                .FetchMany(x => x.Teachers)
                .ThenFetch(x => x.User)
                .Where(x => x.StartTime >= request.From)
                .Where(x => x.EndTime <= request.To)
                .ToList();

            var teacherPaySlips = eventsInRange.SelectMany(x => x.GetPaySlips());

            var teacherInvoiceLines = teacherPaySlips.GroupBy(x => x.Teacher)
                .Select(x => new TeacherInvoiceLine
                {
                    Name = x.Key.User.FullName,
                    AmountOwed = x.Sum(y => y.Pay)
                })
                .ToList();

            var report = new TeacherInvoiceResponse(teacherInvoiceLines);

            return report;
        }
    }
}