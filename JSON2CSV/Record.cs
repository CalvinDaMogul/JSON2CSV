using System;

public class Record
{
    public float askSize { get; set; }
    public float askPrice { get; set; }
    public float bidPrice { get; set; }
    public float bidSize { get; set; }
    public float lastTradePrice { get; set; }
    public string symbolID { get; set; }
    public float lastTradeSize { get; set; }
    public string lastTradeSide { get; set; }
    public string priceNotZero { get; set; }
    public string exchangeID { get; set; }
    public string symbolType { get; set; }
    public string assetIDBase { get; set; }
    public string assetIDQuote { get; set; }
    public string assetCombinedID { get; set; }
    public string assetBaseName { get; set; }
    public int assetBaseType { get; set; }
    public string assetBaseAligned { get; set; }
    public string assetQuoteName { get; set; }
    public int assetQuoteType { get; set; }
    public string assetQuoteAligned { get; set; }

    public Record()
	{
	}

}

