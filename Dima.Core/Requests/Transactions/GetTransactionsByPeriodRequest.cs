namespace Dima.Core.Requests.Transactions;

public class GetTransactionsByPeriodRequest : RequestBase
{
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }
}