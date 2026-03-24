namespace CriticalCommonLib.Extensions;

public static class IntegerExtensions
{
    public static string ConvertToOrdinal(this int number)
    {
        //if (number >= 11 && number <= 13)
        //{
        //    return number + "th";
        //}

        //switch (number % 10)
        //{
        //    case 1:
        //        return number + "st";
        //    case 2:
        //        return number + "nd";
        //    case 3:
        //        return number + "rd";
        //    default:
        //        return number + "th";
        //}
        return number + "번째";
    }
    public static string ConvertToOrdinal(this uint number)
    {
        //if (number >= 11 && number <= 13)
        //{
        //    return number + "th";
        //}

        //switch (number % 10)
        //{
        //    case 1:
        //        return number + "st";
        //    case 2:
        //        return number + "nd";
        //    case 3:
        //        return number + "rd";
        //    default:
        //        return number + "th";
        //}
        return number + "번째";
    }
}