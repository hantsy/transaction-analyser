#nullable enable
using System;

namespace TransactionAnalyzer
{
    record Transaction(
        string Id,
        DateTime TransactedAt,
        decimal Amount,
        string MerchantName,
        TransactionType Type,
        string? RelatedTransactionId
    )
    { }
}
