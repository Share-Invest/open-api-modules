using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>거래원별ELW순매매상위</summary>
public class MultiOPT30002
{
    /// <summary>종목코드</summary>
    [DataMember, JsonProperty("종목코드")]
    public string? 종목코드
    {
        get; set;
    }
    /// <summary>종목명</summary>
    [DataMember, JsonProperty("종목명")]
    public string? 종목명
    {
        get; set;
    }
    /// <summary>주가등락</summary>
    [DataMember, JsonProperty("주가등락")]
    public string? 주가등락
    {
        get; set;
    }
    /// <summary>등락율</summary>
    [DataMember, JsonProperty("등락율")]
    public string? 등락율
    {
        get; set;
    }
    /// <summary>거래량</summary>
    [DataMember, JsonProperty("거래량")]
    public string? 거래량
    {
        get; set;
    }
    /// <summary>순매수</summary>
    [DataMember, JsonProperty("순매수")]
    public string? 순매수
    {
        get; set;
    }
    /// <summary>매수거래량</summary>
    [DataMember, JsonProperty("매수거래량")]
    public string? 매수거래량
    {
        get; set;
    }
    /// <summary>매도거래량</summary>
    [DataMember, JsonProperty("매도거래량")]
    public string? 매도거래량
    {
        get; set;
    }
}