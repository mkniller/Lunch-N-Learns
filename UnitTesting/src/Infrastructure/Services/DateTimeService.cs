using UnitTesting.Application.Common.Interfaces;

namespace UnitTesting.Infrastructure.Services;

public class DateTimeService : IDateTime
{
    public DateTime Now => DateTime.Now;
}
