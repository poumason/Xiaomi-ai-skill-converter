using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Text;
using Newtonsoft.Json;
using XiaomiAI.SDK.Models;

namespace Xiaomi_ai_example.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public async Task<ResponseContent> Post([FromBody]string value)
        {
            try
            {
                using (StreamReader reader = new StreamReader(Request.Body, Encoding.UTF8))
                {
                    string requestJson = await reader.ReadToEndAsync();

                    var requestContent = JsonConvert.DeserializeObject<RequestContent>(requestJson);

                    switch (requestContent.Request.Type)
                    {
                        case RequestType.Intent:
                            string displayText = "是的，幫你朗讀現在氣象";

                            string sessionAttributes = @"{ ""name"": ""pou"", ""email"": ""poumason@live.com""}";

                            return new ResponseContent
                            {
                                IsSessionEnd = false,
                                SessionAttributes = sessionAttributes,
                                Response = new ResponseData
                                {
                                    // ToSpeak 與 ToDisplay 一定要給，來支援有屏幕跟沒有屏幕的設備
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
            catch (Exception ex)
            {
                return new ResponseContent
                {
                    IsSessionEnd = false,
                    Response = new ResponseData
                    {
                        ToDisplay = new PlainTextToDisplayData
                        {
                            Text = ex.Message
                        },
                        ToSpeak = new ToSpeakData
                        {
                            Type = ToSpeakType.TTS,
                            Text = ex.Message
                        }
                    }
                };
            }
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
