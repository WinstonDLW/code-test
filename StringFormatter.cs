using System.Text;

namespace PointsBet_Backend_Online_Code_Test
{

    /*
    Improve a block of code as you see fit in C#.
    You may make any improvements you see fit, for example:
      - Cleaning up code
      - Removing redundancy
      - Refactoring / simplifying
      - Fixing typos
      - Any other light-weight optimisation
    */

    //If we don't have to use StringBuilder
    //We can use the combination of string.Join and LinQ: string.Join(",", items.Select(x => "the format we want"))
    //Then loop can be saved for further simplifying
    public class StringFormatter
    {
        public static string ToCommaSeparatedList(string[] items, string quote)
        {
            if (items == null || items.Length == 0)
            {
                return string.Empty;
            }

            StringBuilder qry = new StringBuilder();

            foreach (var item in items)
            {
                if (qry.Length > 0)
                {
                    qry.Append(", ");
                }

                qry.AppendFormat("{0}{1}{0}", quote, item);
            }

            return qry.ToString();
        }
    }
}
