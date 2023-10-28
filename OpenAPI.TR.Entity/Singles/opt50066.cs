using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>옵션틱차트</summary>
public class SingleOpt50066
{
    /// <summary>종목코드</summary>
    [DataMember, JsonProperty("종목코드")]
    public string? 종목코드
    {
        get; set;
    }
    /// <summary>마지막틱갯수</summary>
    [DataMember, JsonProperty("마지막틱갯수")]
    public string? 마지막틱갯수
    {
        get; set;
    }
}