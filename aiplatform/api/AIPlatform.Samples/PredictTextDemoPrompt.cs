/*
 * Copyright 2023 Google LLC
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     https://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

// [START aiplatform_sdk_ideation]

using Google.Apis.Auth.OAuth2;
using Google.Cloud.AIPlatform.V1;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Value = Google.Protobuf.WellKnownTypes.Value;

public class PredictTextPromptDemoSample
{
    /// <summary>
    /// 同步方法
    /// </summary>
    /// <param name="projectId"></param>
    /// <param name="locationId"></param>
    /// <param name="publisher"></param>
    /// <param name="model"></param>
    /// <returns></returns>
    public string PredictTextPrompt(
        string projectId = "your-project-id",
        string locationId = "us-central1",
        string publisher = "google",
        string model = "text-bison@001"
    )
    {
        string json = "{\"type\":\"service_account\",\"project_id\":\"ilocalize-310004\",\"private_key_id\":\"52b74e7a184e9525fdfe26bade45f77b5ac5956e\",\"private_key\":\"-----BEGIN PRIVATE KEY-----\\nMIIEvQIBADANBgkqhkiG9w0BAQEFAASCBKcwggSjAgEAAoIBAQCDmDvNWf+vKCn1\\nhMEPIBzCoGfmS+kZE3BvP5nsP7M6wtfeDGe+JbEiwfJQAUsNV9p59EKlp7vOSgwX\\n/wtbsjYwG2o6WSczxc3nTddw9TIVhDoPE/SaKrsCKhLQgccSjZv0Nw+Z1SMbf4Ds\\nmq6VtnR3E9PCk5fSI5UXUTQlKZIyTKKdP7yRYq0OVFhnSPPHbwk2v920ZQzSCg12\\n4qc+HxIWCzTxlyFzlrjmdSu2sNlYn11ZROgOrPZlWGB/3BZ/8vIzTEm8p1RmZSbf\\nn31kp0uTIaGeQXw3dhvV/IApy6UjZvJOPrLK8xFXPqtbv3b3+jN+YCTrY98VK4h2\\nLTflvo9JAgMBAAECggEAAxueA53t0BQSS/LqUNTs3PYHHNJ7jeIucFAtGVNmpHCs\\nLWQ3XITSc8bRwKzhJK6ScY7QtqMZHZh/LooRWXrCX8fmo2a438Fa49eMAFDS0Zza\\nzAGdhU5qS3/VISvEI6E+IZ9zHL/YBAryj2lL+NZIlp8xy9QAHKBGwdiC/eLcadfq\\naVPSuHBTU5Ycon6rLUGqYJjFN9QpUGftQoR2ykRwtFlRQW4Tfa2+xAk0Uewsg+az\\nGE/swGlzM1yJ3Yj6X+TOPOW3Eib06ZTeB4QGJRJa5i4E47SsB+glMAugiR8p/p9b\\ncggFdT54oxU8w77U2z6Gr64+sdvHG03+D6Bi2SbOkQKBgQC3w3f74KVbDmwOy3mB\\nS+UZyAIwH1xzB5IqHVyglfI+R1eX+thOtNU25UXybnPq5cLJmm9sA++mByWpIzV1\\n6tmTdAxGSydBw7dA56aOR9voKe/xk5KTkljSSC9VMxA3qFpsBMKx3R8X5TYQqz/6\\n6AaqihWhfvGY4OLqbVoPGKOmGQKBgQC3UuUN8xAgY2PZyFy5EjpLkgdbym91/fMa\\nIECVkB632U+bRNq4LzGSzRGWHicDSkFveSvFE/KdeyMxhd/ZUGitRSkR46k0YIP+\\nQo6+Sm/qNCLImba/JRa2AIjr2e1L2ApQntIoEgb2wXOpdfrVTVcDFhzCqDUcVpnV\\n7QTyskV4sQKBgAoB4hncbQTdbzMLD63j5TEXPE9ElfNJuUMD4FR6dfvARNvo9Dit\\nDmNz7vA55aQoKQhzmZfHSxi+kOV6HmIyjPDDxBtb4mJpdyRYuTBMZ4RoLEH6qGPS\\n93VUKwe3xS1SxMHXLIclJJlXiS81NEHEuwA0juMBl8Sckp7zn5Ds5ZSZAoGBALY3\\nUe80muHmiJguvGNER+dXhbLqGzHnslxUlH1U3AOXn7XQkaojVp348TMKU3LEuxfH\\nFAd21V9MxuVxkNdbQkB/jtv2MvgZuvjeRS3FpUngenZzux5xCgrrqyzq1x/c5BvQ\\nUUl86akZDhLxbtnXXtZ1gy7ErM23En99cL6fDchxAoGAFnZHj/R1WQp778Z7dcUL\\n0FVppzxKDh8exQJ5RXUi2vnm+XfIpTzJqtiNWuRTPaAHnQwK/R4LM4WL1VmC3XRS\\nNLC9dQcr5PXAQfuji6ZdzkwDK1YpguMPKV3ZVebS8xAuH8UM2snzQVEcgS9gY7Zv\\n9A2v7oRwdL1tThR0p7MrtfE=\\n-----END PRIVATE KEY-----\\n\",\"client_email\":\"ilocal-gpt@ilocalize-310004.iam.gserviceaccount.com\",\"client_id\":\"109343625018470480666\",\"auth_uri\":\"https://accounts.google.com/o/oauth2/auth\",\"token_uri\":\"https://oauth2.googleapis.com/token\",\"auth_provider_x509_cert_url\":\"https://www.googleapis.com/oauth2/v1/certs\",\"client_x509_cert_url\":\"https://www.googleapis.com/robot/v1/metadata/x509/ilocal-gpt%40ilocalize-310004.iam.gserviceaccount.com\",\"universe_domain\":\"googleapis.com\"}";
        var credential = GoogleCredential.FromJson(json);

        // Initialize client that will be used to send requests.
        // This client only needs to be created
        // once, and can be reused for multiple requests.
        var client = new PredictionServiceClientBuilder
        {
            JsonCredentials = json,
            //Credential = credential,  //会报错：未授权
            Endpoint = $"{locationId}-aiplatform.googleapis.com"
        }.Build();

        // Configure the parent resource
        var endpoint = EndpointName.FromProjectLocationPublisherModel(projectId, locationId, publisher, model);

        // Initialize request argument(s)
        var prompt = "Give me ten interview questions for the role of program manager.";
        prompt = "Please translate the following text into English. It is required to output only the translation results.\n翻译服务费用优化";

        var instanceValue = Value.ForStruct(new()
        {
            Fields =
            {
                //["prompt"] = Value.ForString(prompt)
                ["content"] = Value.ForString(prompt)
            }
        });

        var instances = new List<Value>
        {
            instanceValue
        };

        var parameters = Value.ForStruct(new()
        {
            Fields =
            {
                { "temperature", new Value { NumberValue = 0.2 } },
                { "maxOutputTokens", new Value { NumberValue = 256 } },
                { "topP", new Value { NumberValue = 0.95 } },
                { "topK", new Value { NumberValue = 40 } }
            }
        });

        // Make the request
        var response = client.Predict(endpoint, instances, parameters);

        // Parse and return the content.
        var content = response.Predictions.First().StructValue.Fields["content"].StringValue;
        Console.WriteLine($"Content: {content}");
        return content;
    }

    /// <summary>
    /// 异步方法
    /// </summary>
    /// <param name="projectId"></param>
    /// <param name="locationId"></param>
    /// <param name="publisher"></param>
    /// <param name="model"></param>
    /// <returns></returns>
    public async Task<string> PredictTextPromptAsync(
        string projectId = "your-project-id",
        string locationId = "us-central1",
        string publisher = "google",
        string model = "text-bison@001"
    )
    {
        //ilocalize
        projectId = "ilocalize-310004";
        string json = "{\"type\":\"service_account\",\"project_id\":\"ilocalize-310004\",\"private_key_id\":\"52b74e7a184e9525fdfe26bade45f77b5ac5956e\",\"private_key\":\"-----BEGIN PRIVATE KEY-----\\nMIIEvQIBADANBgkqhkiG9w0BAQEFAASCBKcwggSjAgEAAoIBAQCDmDvNWf+vKCn1\\nhMEPIBzCoGfmS+kZE3BvP5nsP7M6wtfeDGe+JbEiwfJQAUsNV9p59EKlp7vOSgwX\\n/wtbsjYwG2o6WSczxc3nTddw9TIVhDoPE/SaKrsCKhLQgccSjZv0Nw+Z1SMbf4Ds\\nmq6VtnR3E9PCk5fSI5UXUTQlKZIyTKKdP7yRYq0OVFhnSPPHbwk2v920ZQzSCg12\\n4qc+HxIWCzTxlyFzlrjmdSu2sNlYn11ZROgOrPZlWGB/3BZ/8vIzTEm8p1RmZSbf\\nn31kp0uTIaGeQXw3dhvV/IApy6UjZvJOPrLK8xFXPqtbv3b3+jN+YCTrY98VK4h2\\nLTflvo9JAgMBAAECggEAAxueA53t0BQSS/LqUNTs3PYHHNJ7jeIucFAtGVNmpHCs\\nLWQ3XITSc8bRwKzhJK6ScY7QtqMZHZh/LooRWXrCX8fmo2a438Fa49eMAFDS0Zza\\nzAGdhU5qS3/VISvEI6E+IZ9zHL/YBAryj2lL+NZIlp8xy9QAHKBGwdiC/eLcadfq\\naVPSuHBTU5Ycon6rLUGqYJjFN9QpUGftQoR2ykRwtFlRQW4Tfa2+xAk0Uewsg+az\\nGE/swGlzM1yJ3Yj6X+TOPOW3Eib06ZTeB4QGJRJa5i4E47SsB+glMAugiR8p/p9b\\ncggFdT54oxU8w77U2z6Gr64+sdvHG03+D6Bi2SbOkQKBgQC3w3f74KVbDmwOy3mB\\nS+UZyAIwH1xzB5IqHVyglfI+R1eX+thOtNU25UXybnPq5cLJmm9sA++mByWpIzV1\\n6tmTdAxGSydBw7dA56aOR9voKe/xk5KTkljSSC9VMxA3qFpsBMKx3R8X5TYQqz/6\\n6AaqihWhfvGY4OLqbVoPGKOmGQKBgQC3UuUN8xAgY2PZyFy5EjpLkgdbym91/fMa\\nIECVkB632U+bRNq4LzGSzRGWHicDSkFveSvFE/KdeyMxhd/ZUGitRSkR46k0YIP+\\nQo6+Sm/qNCLImba/JRa2AIjr2e1L2ApQntIoEgb2wXOpdfrVTVcDFhzCqDUcVpnV\\n7QTyskV4sQKBgAoB4hncbQTdbzMLD63j5TEXPE9ElfNJuUMD4FR6dfvARNvo9Dit\\nDmNz7vA55aQoKQhzmZfHSxi+kOV6HmIyjPDDxBtb4mJpdyRYuTBMZ4RoLEH6qGPS\\n93VUKwe3xS1SxMHXLIclJJlXiS81NEHEuwA0juMBl8Sckp7zn5Ds5ZSZAoGBALY3\\nUe80muHmiJguvGNER+dXhbLqGzHnslxUlH1U3AOXn7XQkaojVp348TMKU3LEuxfH\\nFAd21V9MxuVxkNdbQkB/jtv2MvgZuvjeRS3FpUngenZzux5xCgrrqyzq1x/c5BvQ\\nUUl86akZDhLxbtnXXtZ1gy7ErM23En99cL6fDchxAoGAFnZHj/R1WQp778Z7dcUL\\n0FVppzxKDh8exQJ5RXUi2vnm+XfIpTzJqtiNWuRTPaAHnQwK/R4LM4WL1VmC3XRS\\nNLC9dQcr5PXAQfuji6ZdzkwDK1YpguMPKV3ZVebS8xAuH8UM2snzQVEcgS9gY7Zv\\n9A2v7oRwdL1tThR0p7MrtfE=\\n-----END PRIVATE KEY-----\\n\",\"client_email\":\"ilocal-gpt@ilocalize-310004.iam.gserviceaccount.com\",\"client_id\":\"109343625018470480666\",\"auth_uri\":\"https://accounts.google.com/o/oauth2/auth\",\"token_uri\":\"https://oauth2.googleapis.com/token\",\"auth_provider_x509_cert_url\":\"https://www.googleapis.com/oauth2/v1/certs\",\"client_x509_cert_url\":\"https://www.googleapis.com/robot/v1/metadata/x509/ilocal-gpt%40ilocalize-310004.iam.gserviceaccount.com\",\"universe_domain\":\"googleapis.com\"}";

        //aihelp gpt-650
        projectId = "tribal-bonito-158312";
        json = "{\"type\":\"service_account\",\"project_id\":\"tribal-bonito-158312\",\"private_key_id\":\"076b32a3b62c321a9f7425eb51e8d54c31703b3e\",\"private_key\":\"-----BEGIN PRIVATE KEY-----\\nMIIEvgIBADANBgkqhkiG9w0BAQEFAASCBKgwggSkAgEAAoIBAQDS5BGRrkEl1qIB\\nJmvbEueSTWjJ1anqP8mqmYbV6KGJfXERF4x2UeqkgU1TEB9rF2zQwhaxHLTceRSK\\nOmwXgK65UvvnXb6HkSrfBoFrA6lWkcAbMleieBeKfJHG4/AnLqQ3wp/gazEAB3nf\\nWD6qA7GbeldkXlphdW9GassLXD5gcA0NALnn4iBVC92heMUHH8Cz4oq3mK20FDgG\\ntEvKTj3vC5NgC9GwcWDdBCP/7kT5Nq7OLb1jhFahMVcjQFnL5wukeBtX8CJWxvEb\\nv0PMHo8Hx+5hgbyDI6laRI/WAtGxw/qA7vqY6AHtQcm9k3TdvfC8WUnROOF9NvLx\\nDbDZAWo1AgMBAAECggEAE95KzXJ2Ts320KxBqGUSjhUJlKJdnLp1EcPfESjBN0aA\\nhX9gy1uSWKdElVkagf4LUWudCa35Asshephgdfe4qQW+wnXG19d/C339vrWcmZGn\\ntf2Qhgz8YsleToz2Tiq1wU8ZEuKRE5NLZxWq6bI+ubV/+u5suMErQkjDZ7GWwC0C\\ngEd8Y/WyU8KOc0fCTGXarynLokIx/kexarkowkI2hKI7NCJsE5EC+ZMCCvEtejLV\\nWvgYyrnuaVGjqaiKilHY3rlamzMpgKNDr/hBIyiQh5uYHxaafM84IwOS/EvvzUb0\\nDLg5OEsMEHbGsyTBzQ4PuksE5CBtFhwZ9I4sd02Q7QKBgQDyxgmZldxXBUTLrw1C\\nNF2Xvo73zfQ9rewVAHt9MhQJoErE4a5Eawnn5l/cAVWg64mPzCy1P3F7vUHC35is\\nsZgeYkL5VmZ0kPWzhyCMaJXnFNH6cN9Gq7ueYezG+e46cgymM6mY2mLrb763G1y1\\nqK4IojmU35FcNNcu+DJBNjLDVwKBgQDeYV0DEjyWUnaxu/xMw6HfHSNAX5vUqQE3\\ncqKHYxoYKUu2AIeyM0uklbRQtB8VqE18oxtCbhEtUflLvCYZa8dhN8cJoYyUZHls\\nqGZWZGOkuMG/6xqbZxWTxWXsVC9mGAF2rG3BI/5upRZPrsyiW4fdeRwiKZ1oreuk\\nRJbJuhRzUwKBgQC3Wgn2DNCUiE4k5thEn/fvmuOvE8TasHgUhIC/VQr9Gipd93P+\\nCDk7Aypypi9dkYYbLEC3wmqa4ZzA6M4N3zLb/6pFVZObhb+LDwruAC72jyrm0khO\\nv3S7cYm53Rim22viOjJkVstOtN58vBWQvQxzSNHkNdU6pk2+E4Ug6yX7kQKBgCr3\\n1xf70xcckfCfqQ1QE5vfrmsGzj5V9XU4Qi00udsHR6jAC3gkLy56+p9JXmQ549b8\\nUQ0R5WHDYA8BKL9qstiXBW9X9qjJjSiwlS2GMjamuFET5U03qtSlpJ74WTw50TaT\\n9JUIFmZcoaX92W5ZjzP87bGwJskOKeTQl+4cdU0fAoGBANhbYGh8ueJeWzDaiW6+\\n2xnDxBBDC49WiFTjaT2wEyk1ZGQ67Q4zN6TadVQPx1S2gotpMLgc5R9sSCqZf6wZ\\nV2wZR6q3gGIHIC9onCw7YuN8xnCR50xB82M1I9WFJcgzkN2WXSPy9ma4+S2myKsR\\nMHSisp68HOFg70/EgXVCBeLf\\n-----END PRIVATE KEY-----\\n\",\"client_email\":\"gpt-650@tribal-bonito-158312.iam.gserviceaccount.com\",\"client_id\":\"101408283956470015555\",\"auth_uri\":\"https://accounts.google.com/o/oauth2/auth\",\"token_uri\":\"https://oauth2.googleapis.com/token\",\"auth_provider_x509_cert_url\":\"https://www.googleapis.com/oauth2/v1/certs\",\"client_x509_cert_url\":\"https://www.googleapis.com/robot/v1/metadata/x509/gpt-650%40tribal-bonito-158312.iam.gserviceaccount.com\",\"universe_domain\":\"googleapis.com\"}";

        //aihelp vision-api
        //projectId = "tribal-bonito-158312";
        //json = "{\"type\":\"service_account\",\"project_id\":\"tribal-bonito-158312\",\"private_key_id\":\"93e6b35e79e7737329ef70c9700cf97ae8352c15\",\"private_key\":\"-----BEGIN PRIVATE KEY-----\\nMIIEvgIBADANBgkqhkiG9w0BAQEFAASCBKgwggSkAgEAAoIBAQC6K3QR7gnr8zds\\n4GtjjEDzT1OeuzB+th2W6YTSn98N2N4gnzn9kBlSSNFmX+wgO1ujWIVe039vsmbN\\nZ5LheNA1v505LDYzwF8YcKJ8BDrMbvTorQi/ULT28DNKLPwwBMAA6nA8HBztpTIm\\nJeyJvEK8EThtZYvdZxFXGwwuhJ5GZTtffrRz2WAzJ+RRlJB3SIbXtu+e0DjdLoIr\\n1Smq+O4+dfvuSJw7GYHThGG1/TydowKgIgkFRTJw73Uz/GpyMlnecQRaAbtj+b59\\nr9OA0WWobTDeM9f2bh/PEfkH9HMnmVSl5HOiO8JUP2KdbBbOx5eBORIh5jK7YVSX\\nc7+kXmX3AgMBAAECggEAIlaReh0lx1d9CZ/7LslX0Yj4K3brYvPEUWmRDihew/cU\\nQYAc+h/yC7NSrEdVDjzkkiRptSvdfYSyYYCRHvVhsgg9v6Xf+XuqDp/32FgPYFW2\\n5pPD4UXJmyKC01Oo0FKP95tGSFAHJe4qac7k6iLHTFkAx2zLd3LjR+W9QXdEmkcQ\\n0DaoXeq7jR4wbIUzLc7cJVTCNHTzzYZDQpP+R4eyOZT82+moTEdYb3H9K1Ymt3cZ\\nOVwraA2TMs2NZdbETw5lhoh/2HZtRNa2cauaRjf1lM6DNRJJojnHhH6wyrqTYwyg\\nAd8/TBSSu8gsRWacouSKt7R1THjja5FJOZ5AyGhsQQKBgQDxxu7+WXyVv8AWXl1F\\ncQT8FIlDQr7z4aaWCLYrHGNnRlOmWj0a/9DDhPi9abCq+63wfFWuDjIJSvBD6ila\\n/YuEiI81iujPOlXwX8u6q37B9acz5JX34o6JQyL19toiAhO4tLyEkhSBng6aLRJH\\n2Nq2/NizQJdCt5++JXnkmPdVYwKBgQDFHxhspTmE/XMJ3m1Yg8OV2wxOeQ6NnPLP\\n/rXu5TPm1hi1yszl6cx0ogUwzq94GZ344stoQp4FDZV3snC/s/WEwStfTrXbfWun\\n/Pq3YDQQB2YYAc1XbRZx0W9+NUnLsMnSh0gZhKKeZVBLdIZ+SGjyN3mtpIYAsXxc\\ncM0TqRxrXQKBgQCnaSrlPYtRmXNlSbPluGtOLN4aj6Xu8ulJbADPexmtUfnr7wHu\\npwGj0Hf3l643xotbQIyHN9cXricNr58xHOy1OWWIGoY3r1oAViSYPdVIclNzUC0z\\ndlFh4/XaQDIsaCnFtIfwd8HxOkM8KEdHLnXLTOqzu97A2KqonAR58B0apwKBgQCJ\\nkfwPxvfvspqYpp0Vi0/yw99A3QelGYX0V0VNprSkQ4MXTKPXSWYhd/m7aGPZo7c2\\nPcHLz8JMsIBB+0zo3YVZ0x6b82jD+DIsGUg4tnFfRmqgEpHmlAF4CbyQDkykVYtk\\n3HkbJhAAD6EMKBS9CXgEo2bOIuZKkZPDSA43zGxDGQKBgBAFMC6TKQCksKVEJZKE\\nYUND6jTaZoY/zIHFYXbrkn7PqHnPHx6t4woamY9SNuW6ebP3UBRD32B4AAcK4vJO\\n2TX3HhOEKd5+15fCBKl1z6bqGrbQfG9PSNFeSAdn4nXzIUytCxaJLyYNycw+S7Hn\\nP4oc9PCy7oDUjMeru2QfWtnb\\n-----END PRIVATE KEY-----\\n\",\"client_email\":\"vision-api@tribal-bonito-158312.iam.gserviceaccount.com\",\"client_id\":\"103477185046554926819\",\"auth_uri\":\"https://accounts.google.com/o/oauth2/auth\",\"token_uri\":\"https://oauth2.googleapis.com/token\",\"auth_provider_x509_cert_url\":\"https://www.googleapis.com/oauth2/v1/certs\",\"client_x509_cert_url\":\"https://www.googleapis.com/robot/v1/metadata/x509/vision-api%40tribal-bonito-158312.iam.gserviceaccount.com\",\"universe_domain\":\"googleapis.com\"}";

        var credential = GoogleCredential.FromJson(json);

        // Initialize client that will be used to send requests.
        // This client only needs to be created
        // once, and can be reused for multiple requests.
        var client = new PredictionServiceClientBuilder
        {
            JsonCredentials = json,
            //Credential = credential,  //会报错：未授权
            Endpoint = $"{locationId}-aiplatform.googleapis.com"
        }.Build();

        // Configure the parent resource
        var endpoint = EndpointName.FromProjectLocationPublisherModel(projectId, locationId, publisher, model);

        // Initialize request argument(s)
        var prompt = "Give me ten interview questions for the role of program manager.";
        prompt = "Please translate the following text into English. It is required to output only the translation results.\n翻译服务费用优化";

        var instanceValue = Value.ForStruct(new()
        {
            Fields =
            {
                //["prompt"] = Value.ForString(prompt)
                ["content"] = Value.ForString(prompt)
            }
        });

        var instances = new List<Value>
        {
            instanceValue
        };

        var parameters = Value.ForStruct(new()
        {
            Fields =
            {
                { "temperature", new Value { NumberValue = 0.2 } },
                { "maxOutputTokens", new Value { NumberValue = 256 } },
                { "topP", new Value { NumberValue = 0.95 } },
                { "topK", new Value { NumberValue = 40 } }
            }
        });

        // Make the request
        var response = await client.PredictAsync(endpoint, instances, parameters);

        // Parse and return the content.
        var content = response.Predictions.First().StructValue.Fields["content"].StringValue;
        //var test = response.Predictions.First().StructValue.Fields["test"].StringValue;  //不存在的field 会报错
        var safetyAttributes = response.Predictions.First().StructValue.Fields["safetyAttributes"].StructValue;

        Console.WriteLine($"Content: {content}");
        Console.WriteLine(value: $"response: {response}");
        Console.WriteLine(value: $"response: {JsonConvert.SerializeObject(response)}");
        var a = response.ToString();
        var b = JsonConvert.SerializeObject(response);
        return content;
    }
}

// [END aiplatform_sdk_ideation]
