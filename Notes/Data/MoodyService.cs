namespace Notes.Data
{
    public class MoodyService // TODO: maybe not saving/storing notes here
    {
        public Moody? Md { get; set; }
        public Dictionary<string, Moody> Notes { get; set; }
        public void AddOrUpdate<TKey, TValue>(Dictionary<TKey, TValue> dictionary, TKey key, TValue value)
        {
            if (dictionary.ContainsKey(key))
            {
                dictionary[key] = value;
            }
            else
            {
                dictionary.Add(key, value);
            }
        }

    }
}
