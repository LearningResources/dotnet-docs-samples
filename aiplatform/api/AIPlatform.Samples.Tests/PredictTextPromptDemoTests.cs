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

using System;
using System.Threading.Tasks;
using Xunit;
using static Google.Rpc.Context.AttributeContext.Types;

public class PredictTextPromptDemoTest
{
    private readonly PredictTextPromptDemoSample _sample;

    public PredictTextPromptDemoTest()
    {
        _sample = new PredictTextPromptDemoSample();
    }

    [Fact]
    public void TestPredictTextPromptDemo()
    {
        var response = _sample.PredictTextPrompt("ilocalize-310004");
        Assert.NotNull(response);
    }

    [Fact]
    public async Task TestPredictTextPromptAsyncDemo()
    {
        try
        {
            var response = await _sample.PredictTextPromptAsync("ilocalize-310004");
            Assert.NotNull(response);
        } catch (Exception ex)
        {
            Assert.NotNull(ex.Message);
        }
    }
}
