namespace ERCommander
{
    public interface IBaseItem
    {
        /// <summary>
        /// Полный путь к элементу
        /// </summary>
        string MainPath { get; set; }
        /// <summary>
        /// Имя элемента
        /// </summary>
        string Name { get; set; }
        /// <summary>
        /// Размер
        /// </summary>
        long? Size { get; set; }
    }
}