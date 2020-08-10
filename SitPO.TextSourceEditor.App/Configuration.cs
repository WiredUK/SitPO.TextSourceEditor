using System.Collections.Generic;

namespace SitPO.TextSourceEditor.App
{
    public class ConfigurationViewModel
    {
        public bool AutoSave { get; set; }
        public List<TextSource> TextSources { get; set; }
    }


    public abstract class TextSource
    {
        public string Name { get; set; }
    }

    public class SimpleTextSource : TextSource
    {
        public string Value { get; set; }
    }

    public class NumericTextSource : TextSource
    {
        public int Value { get; set; }
    }
}