namespace CTT.Logic;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
public class PaymentService
{
    private readonly string _apiKey;
    private readonly HttpClient _httpClient;

    public PaymentService()
    {
        _apiKey = "eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJ1dWlkIjoiTXpJM01qUT0iLCJ0eXBlIjoicHJvamVjdCIsInYiOiIxMzI4YzFkNmZjMTJlNzBkYTk2NTZjZjMzZTQyN2FhODFkYjk3M2NmNmZhODUzNDIzZWE3N2MyMjYzZWYxYWNiIiwiZXhwIjo4ODEzMzc1NTA3Nn0.sxgoxgYiOihPZuv3Q5-xSEJ2FfbyLH-r0hcQA6dBrfU";
        _httpClient = new HttpClient();
        _httpClient.DefaultRequestHeaders.Add("Authorization", $"Token {_apiKey}");
        _httpClient.DefaultRequestHeaders.Add("Accept", "application/json");
    }

    public async Task<string> CreateInvoiceAsync(float amount)
    {
        string createInvoiceUrl = "https://api.cryptocloud.plus/v1/invoice/create";
        string shopId = "fBfr0S6FI207092b";
        var invoiceData = new
        {
            shop_id = shopId,
            amount = amount,
            currency = "USD"
        };

        string jsonData = JsonConvert.SerializeObject(invoiceData);
        HttpContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");

        HttpResponseMessage response = await _httpClient.PostAsync(createInvoiceUrl, content);

        if (response.IsSuccessStatusCode)
        {
            string responseBody = await response.Content.ReadAsStringAsync();

            // Десериализация ответа
            var responseObject = JsonConvert.DeserializeObject<dynamic>(responseBody);
            string payUrl = responseObject?.pay_url; // Извлекаем pay_url

            if (!string.IsNullOrEmpty(payUrl))
            {
                return payUrl; // Возвращаем URL для оплаты
            }
            else
            {
                throw new Exception("Pay URL is missing in the response.");
            }
        }
        else
        {
            string errorResponse = await response.Content.ReadAsStringAsync();
            throw new Exception($"Error creating invoice: {response.StatusCode}. Details: {errorResponse}");
        }
    }
}
