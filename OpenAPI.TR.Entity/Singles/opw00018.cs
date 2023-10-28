using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>계좌평가결과</summary>
public class SingleOpw00018
{
    /// <summary>총매입금액</summary>
    [DataMember, JsonProperty("총매입금액")]
    public string? 총매입금액
    {
        get; set;
    }
    /// <summary>총평가금액</summary>
    [DataMember, JsonProperty("총평가금액")]
    public string? 총평가금액
    {
        get; set;
    }
    /// <summary>총평가손익금액</summary>
    [DataMember, JsonProperty("총평가손익금액")]
    public string? 총평가손익금액
    {
        get; set;
    }
    /// <summary>총수익률(%)</summary>
    [DataMember, JsonProperty("총수익률(%)")]
    public string? 총수익률
    {
        get; set;
    }
    /// <summary>추정예탁자산</summary>
    [DataMember, JsonProperty("추정예탁자산")]
    public string? 추정예탁자산
    {
        get; set;
    }
    /// <summary>총대출금</summary>
    [DataMember, JsonProperty("총대출금")]
    public string? 총대출금
    {
        get; set;
    }
    /// <summary>총융자금액</summary>
    [DataMember, JsonProperty("총융자금액")]
    public string? 총융자금액
    {
        get; set;
    }
    /// <summary>총대주금액</summary>
    [DataMember, JsonProperty("총대주금액")]
    public string? 총대주금액
    {
        get; set;
    }
    /// <summary>조회건수</summary>
    [DataMember, JsonProperty("조회건수")]
    public string? 조회건수
    {
        get; set;
    }
}