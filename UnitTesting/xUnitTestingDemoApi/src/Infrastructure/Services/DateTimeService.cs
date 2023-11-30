using xUnitTestingDemoApi.Application.Common.Interfaces;

namespace xUnitTestingDemoApi.Infrastructure.Services;

public class DateTimeService : IDateTime
{
    public DateTime Now => DateTime.Now;
}
