﻿namespace ShareInvest;

public enum Conclusion
{
    계좌번호 = 9201,
    주문번호 = 9203,
    관리자사번 = 9205,
    종목코드_업종코드 = 9001,
    주문업무분류 = 912,
    주문상태 = 913,
    종목명 = 302,
    주문수량 = 900,
    주문가격 = 901,
    미체결수량 = 902,
    체결누계금액 = 903,
    원주문번호 = 904,
    주문구분 = 905,
    매매구분 = 906,
    매도수구분 = 907,
    주문_체결시간 = 908,
    체결번호 = 909,
    체결가 = 910,
    체결량 = 911,
    현재가 = 10,
    매도호가 = 27,
    매수호가 = 28,
    단위체결가 = 914,
    단위체결량 = 915,
    당일매매수수료 = 938,
    당일매매세금 = 939,
    거부사유 = 919,
    화면번호 = 920,
    터미널번호 = 921,
    신용구분 = 922,
    대출일 = 923
}
public enum OrderState
{
    접수,
    체결,
    취소
}