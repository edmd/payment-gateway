﻿
namespace PaymentGateway.Data.Persistence.Entities
{
    public class Transaction : BaseEntity
    {
        public Transaction() { }
        public Transaction(Guid transactionId, Guid acquirerTransactionId, int merchantId, string cardHolderName,
            string cardNumber, string? validFrom, string validTo, string cvv2, decimal amount,
            string currencyCode, int status)
        {
            TransactionId = transactionId;
            AcquirerTransactionId = acquirerTransactionId;
            MerchantId = merchantId;
            CardHolderName = cardHolderName;
            CardNumber = cardNumber;
            ValidFrom = validFrom;
            ValidTo = validTo;
            Cvv2 = cvv2;
            Amount = amount;
            CurrencyCode = currencyCode;
            Status = status;
        }

        public Guid TransactionId { get; set; }
        public Guid AcquirerTransactionId { get; set; }
        public int MerchantId { get; set; }
        public string CardHolderName { get; set; }
        public string CardNumber { get; set; }
        public string? ValidFrom { get; set; }
        public string ValidTo { get; set; }
        public string Cvv2 { get; set; }
        public decimal Amount { get; set; }
        public string CurrencyCode { get; set; }
        public int Status { get; set; }
    }
}