# Xiaomi-ai-skill-converter 

### System requirement
* [.NET standard 2.0](https://docs.microsoft.com/en-us/dotnet/standard/net-standard)
* [ASP.NET Core 2.0](https://docs.microsoft.com/en-us/aspnet/core/aspnetcore-2.0)

### XaiomiAI.SDK
* RequestContent

  Convert json from Xiaomi AI server to object.

* ResponseContent

  Convert object to response json to Xaimi AI server.

### Example
```csharp
[HttpPost]
public async Task<ResponseContent> Post([FromBody]string value)
{
    using (StreamReader reader = new StreamReader(Request.Body, Encoding.UTF8))
    {
        // read json content
        string requestJson = await reader.ReadToEndAsync();
        // convert to RequestContent 
        var requestContent = JsonConvert.DeserializeObject<RequestContent>(requestJson);
        // identify request type to generate response content
        switch (requestContent.Request.Type)
        {
            case RequestType.Intent:
                string displayText = "是的，幫你朗讀現在氣象";
                return new ResponseContent
                {
                    IsSessionEnd = false,
                    Response = new ResponseData
                    {
                        ToSpeak = new ToSpeakData
                        {
                            Type = ToSpeakType.TTS,
                            Text = displayText
                        },
                        ToDisplay = new PlainTextToDisplayData
                        {
                            Text = displayText
                        },
                        Directives = new List<IDirectiveData>
                        {
                            new AudioDirectiveData
                            {
                                AudioItem = new AudioItemData
                                {
                                    Stream = new StreamData
                                    {
                                        Url = "http://xxxxx.mp3"
                                    }
                                }
                            },
                            new TTSDirectiveData
                            {
                                TTSItem = new TTSItemData
                                {
                                    Text = displayText
                                }
                            }
                        }
                    }
                };
            case RequestType.End:
                string endTxt = "期待您再次使用";
                return new ResponseContent
                {
                    IsSessionEnd = true,
                    Response = new ResponseData
                    {
                        ToSpeak = new ToSpeakData
                        {
                            Type = ToSpeakType.TTS,
                            Text = endTxt
                        },
                        ToDisplay = new PlainTextToDisplayData
                        {
                            Text = endTxt
                        },
                    }
                };
            default:
                // None, Wakeup
                string wakeupTxt = "請問您需要什么服務呢?";
                return new ResponseContent
                {
                    IsSessionEnd = false,
                    Response = new ResponseData
                    {
                        ToSpeak = new ToSpeakData
                        {
                            Type = ToSpeakType.TTS,
                            Text = wakeupTxt
                        },
                        ToDisplay = new PlainTextToDisplayData
                        {
                            Text = wakeupTxt
                        }
                    }
                };
        }
    }
}
```