namespace Bridge.Html5
{
    [External]
    public enum HtmlEventTarget
    {
        [Template("{0}")]
        Raw = 0,

        [Template("document.getElementById(\"{0}\")")]
        GetElementById = 1,

        [Template("document.querySelector(\"{0}\")")]
        QuerySelector = 2
    }

    [External]
    public abstract class EventAttribute : Bridge.AdapterAttribute
    {
        public const string Format = "Bridge.on(\"{0}\", {1}, this.{2});";
        public const string FormatScope = "Bridge.on(\"{0}\", {1}, this.{2}, this);";
    }

    [External]
    public class HtmlEventAttribute : EventAttribute
    {
        public const bool IsCommonEvent = true;

        public HtmlEventAttribute(string eventName, string selector, HtmlEventTarget target = HtmlEventTarget.QuerySelector)
        {
        }

        public HtmlEventAttribute(EventType eventName, string selector, HtmlEventTarget target = HtmlEventTarget.QuerySelector)
        {
        }
    }

    [External]
    public class ClickAttribute : EventAttribute
    {
        public const string Event = "click";

        public ClickAttribute(string selector, HtmlEventTarget target = HtmlEventTarget.QuerySelector)
        {
        }
    }
}