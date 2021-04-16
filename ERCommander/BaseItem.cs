namespace ERCommander
{
    /// <summary>
    /// Элемент отображэения файлового мендежера
    /// </summary>
    public class BaseItem : IBaseItem
    {
        public string MainPath { get; set; }
        public string Name { get; set; }
        public long? Size { get; set; } = null;
    }
}