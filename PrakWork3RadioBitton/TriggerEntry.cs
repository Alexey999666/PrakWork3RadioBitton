using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrakWork3RadioBitton
{
   public class EntryValidation : TriggerAction<Entry>
   {
        protected override void Invoke(Entry sender)
        {
            int num;
            if(Int32.TryParse(sender.Text, out num) == false)
            {
                sender.TextColor = Colors.DarkRed;
            }
            else
            {
                sender.TextColor = Colors.MediumVioletRed;
            }
        }
   }
}
