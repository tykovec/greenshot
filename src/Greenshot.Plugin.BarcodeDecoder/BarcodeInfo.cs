using System;

namespace Greenshot.Plugin.BarcodeDecoder
{
    public class BarcodeInfo
    {
        public string Value { get; set; }

        public string Type { get; set; }

        public DateTime CapturedAt { get; }

        public BarcodeInfo(string value, string type)
        {
            Value = value;
            Type = type;
            CapturedAt = DateTime.Now;
        }
    }
}
