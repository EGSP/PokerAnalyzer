namespace PokerAnalyzer.Code;

public abstract class Combination
{
    /// <summary>
    /// Роял флеш
    /// </summary>
    public class RoyalFlush {}
    /// <summary>
    /// Стрит флеш
    /// </summary>
    public class StraightFlush{}
    /// <summary>
    /// Каре
    /// </summary>
    public class FourKind{}
    /// <summary>
    /// Фулл хаус
    /// </summary>
    public class FullHouse{}
    /// <summary>
    /// Флеш
    /// </summary>
    public class Flush{}
    /// <summary>
    /// Стрит
    /// </summary>
    public class Straight{}
    /// <summary>
    /// Тройка или сет
    /// </summary>
    public class ThreeKind{}
    /// <summary>
    /// Две пары
    /// </summary>
    public class TwoPair{}
    /// <summary>
    /// Пара
    /// </summary>
    public class Pair{}
    /// <summary>
    /// Высшая карта
    /// </summary>
    public class High{}
}