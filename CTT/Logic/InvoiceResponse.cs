using System.Text.Json.Serialization;

public class InvoiceResponse
{
    [JsonPropertyName("status")]
    public string Status { get; set; }

    [JsonPropertyName("pay_url")]
    public string PayUrl { get; set; }

    [JsonPropertyName("currency")]
    public string Currency { get; set; }

    [JsonPropertyName("invoice_id")]
    public string InvoiceId { get; set; }

    [JsonPropertyName("amount")]
    public float Amount { get; set; }

    [JsonPropertyName("amount_usd")]
    public float AmountUsd { get; set; }
}