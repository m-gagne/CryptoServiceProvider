# Crypto Service Provider

Azure Function helpers for encryption

## APIs

### TDESGenerate

Located in `/src/functions/TDESGenerate` this Azure Function uses the [.NET TripleDESCryptoServiceProvider](https://msdn.microsoft.com/en-us/library/system.security.cryptography.tripledescryptoserviceprovider(v=vs.110).aspx) class to generate both the `key` and  initialization vector `iv` required for symmetric algorithms. Sourced from: https://msdn.microsoft.com/en-us/library/5e9ft273(v=vs.110).aspx

** Returns JSON iv & key**

    "{\"iv\": \"C4RRyt7ce3g=\", \"key\": \"LrsbUVnTbpqWwfRt+wrYnJDh7FIhVwWA\"}"

#### Usage

    curl http://localhost:7071/api/TDESGenerate