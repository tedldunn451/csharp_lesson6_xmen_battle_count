using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace csharp_lesson6_xmen_battle_count
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string[] names = new string[] { "Professor X", "Iceman", "Angel", "Beast", "Pheonix", "Cyclops", "Wolverine", "Nightcrawler", "Storm", "Colossus" };
            int[] numbers = new int[] { 7, 9, 12, 15, 17, 13, 2, 6, 8, 13 };

            string most = "";
            string least = "";
            int battles = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > battles)
                {
                    battles = numbers[i];
                    most = names[i];
                }
            }

            mostLabel.Text = String.Format("Most battles belongs to: {0} (Value: {1})", most, battles.ToString());

            for (int j = 0; j < numbers.Length; j++)
            {
                if (numbers[j] < battles)
                {
                    battles = numbers[j];
                    least = names[j];
                }
            }

            leastLabel.Text = String.Format("Least battles belongs to: {0} (Value: {1})", least, battles.ToString());
        }
    }
}