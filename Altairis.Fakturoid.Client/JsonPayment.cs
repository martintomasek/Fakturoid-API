using System;
using System.Collections.Generic;
using System.Text;

namespace Altairis.Fakturoid.Client;
public class JsonPayment {
    /// <summary>
    /// Unique identifier in Fakturoid
    /// </summary>
    public int? id { get; set; }

    /// <summary>
    /// Payment date
    /// Default: Today
    /// </summary>
    public DateTime? paid_on { get; set; }

    /// <summary>
    /// Currency ISO Code (same as invoice currency)
    /// </summary>
    public string currency { get; set; }

    /// <summary>
    /// Paid amount in document currency
    /// Default: Remaining amount to pay
    /// </summary>
    public decimal? amount { get; set; }

    /// <summary>
    /// Paid amount in account currency
    /// Default: Remaining amount to pay converted to account currency
    /// </summary>
    public decimal? native_amount { get; set; }

    /// <summary>
    /// Mark document as paid?
    /// Default: true if the total paid amount becomes greater or equal to remaining amount to pay
    /// </summary>
    public bool? mark_document_as_paid { get; set; }

    /// <summary>
    /// Issue a followup document with payment
    /// Only for proformas and mark_document_as_paid must be true
    /// Values: final_invoice_paid (Invoice paid), final_invoice (Invoice with edit),
    /// tax_document (Document to payment), none (None)
    /// </summary>
    public string? proforma_followup_document { get; set; }

    /// <summary>
    /// Send thank-you email?
    /// mark_document_as_paid must be true
    /// Default: Inherit from account settings
    /// </summary>
    public bool? send_thank_you_email { get; set; }

    /// <summary>
    /// Payment variable symbol
    /// Default: Invoice variable symbol
    /// </summary>
    public string? variable_symbol { get; set; }

    /// <summary>
    /// Bank account ID
    /// Default: Invoice bank account or default bank account
    /// </summary>
    public string? bank_account_id { get; set; }

    /// <summary>
    /// Tax document ID (if present)
    /// </summary>
    public int? tax_document_id { get; set; }

    /// <summary>
    /// The date and time of payment creation
    /// </summary>
    public DateTime? created_at { get; set; }

    /// <summary>
    /// The date and time of last payment update
    /// </summary>
    public DateTime? updated_at { get; set; }
}
