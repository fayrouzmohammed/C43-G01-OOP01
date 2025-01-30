
namespace oop1
{

    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1
            /*foreach (WeekDays day in Enum.GetValues(typeof(WeekDays)))
            {
                Console.WriteLine(day);
            }*/
            #endregion

            #region 2
            /*Console.WriteLine("Enter a season: ");
            string Input = Console.ReadLine();

         
            if (Enum.TryParse(Input, true, out Season season))
            {
                switch (season)
                {
                    case Season.Spring:
                        Console.WriteLine("Spring: March to May");
                        break;
                    case Season.Summer:
                        Console.WriteLine("Summer: June to August");
                        break;
                    case Season.Autumn:
                        Console.WriteLine("Autumn: September to November");
                        break;
                    case Season.Winter:
                        Console.WriteLine("Winter: December to February");
                        break;
                    default:
                        Console.WriteLine("Invalid season.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid season entered.");
            }*/

            #endregion

            #region 3
          /*  User user01=new User();
            user01.Id = 1; 
            user01.permissions = (permission)6; //write, delete
            Console.WriteLine(user01.permissions);

            // add premission Read
            user01.permissions = user01.permissions ^ permission.read;
            Console.WriteLine(user01.permissions);

            // remove premission delete
            user01.permissions = user01.permissions ^ permission.delete;
            Console.WriteLine(user01.permissions);

            // check if premission available

            if ((user01.permissions & permission.delete) == permission.delete) 
            {
                Console.WriteLine("delete ava");
            }
            else
            {
                Console.WriteLine("delete Unava");
            }

*/


            #endregion

            #region 4

            /*  Console.WriteLine("enter a color: ");
              String inputColor = Console.ReadLine(); 

              bool isParsed = false;

              isParsed = Enum.TryParse(inputColor, true, out colors color);

              if (isParsed)
              {
                  if (color == colors.Red | color == colors.Blue | color == colors.Green) 
                  {
                      Console.WriteLine("primary Color");
                  }
                  else { Console.WriteLine("not a praimary color "); }
              }         */

            #endregion

        }
    }
}