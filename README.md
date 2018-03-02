# Xiaomi-ai-skill-converter 

### Documents
[自定义技能开发文档](https://shuidi.mi.com/documents/Home?type=/doc/render_markdown/CustomSkills)

If you aren't a Xiaomi AI developer, please visit the [水滴平台](https://shuidi.mi.com/).

### System requirement
* [.NET standard 2.0](https://docs.microsoft.com/en-us/dotnet/standard/net-standard)
* [.NET Framework 4.5.2+](https://docs.microsoft.com/en-us/dotnet/framework/install/guide-for-developers)
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
                string displayText = "是的，帮你朗读现在气象";
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

### Enter develop mode of the Xiaomi AI Speaker
If the state of the custom skill is testing or during cerficiation process, you can test it on the Xiaomi AI Speaker.

Steps:
1. 对音箱说：`进入开发者模式`

   --------------测试中-------------------
2. 用你的技能 `调用名称` 进行测试，只有处于测试中或者审核中的技能都能够进行测试
3. 想要退出请说：`进入用户模式`