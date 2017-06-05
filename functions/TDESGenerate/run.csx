using System.Net;
using System.Security.Cryptography;

public static async Task<HttpResponseMessage> Run(HttpRequestMessage req, TraceWriter log)
{
  string iv, key;

  using (var rng = RandomNumberGenerator.Create())
  {
      // IV (12 chars)
      byte[] tokenData = new byte[8];
      rng.GetBytes(tokenData);
      iv = Convert.ToBase64String(tokenData);

      // KEY (32 chars)
      tokenData = new byte[24];
      rng.GetBytes(tokenData);
      key = Convert.ToBase64String(tokenData);
  }

  return req.CreateResponse(HttpStatusCode.OK, $"{{\"iv\": \"{iv}\", \"key\": \"{key}\"}}");
}