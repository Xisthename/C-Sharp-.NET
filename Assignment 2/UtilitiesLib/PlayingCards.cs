using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UtilitiesLib
{
    /// <summary>
    /// Daniel Petersén
    /// 2018-11-08
    /// 
    /// The diffrent playing states a player can be in
    /// </summary>
    public enum PlayingStates { Playing, BlackJack, Thick, Stand, Won, Lost }

    public class PlayingCards
    {
        /// <summary>
        /// Delecering necessary variables
        /// </summary>
        public static readonly int Count = 52;
        public static readonly int BlackJack = 21;
        public static readonly int MinStopValueForDealer = 17;
        public static readonly int Width = 100;
        public static readonly int Height = 150;
        private static readonly int[] CardValues = { 1, 11, 13, 12, 8, 9, 2, 3, 4, 5, 6, 7, 10 };

        /// <summary>
        /// Returns a card back image
        /// </summary>
        /// <returns></returns>
        public static Image GetCardBack()
        {
            return Properties.Resources.cardback_red;
        }

        /// <summary>
        /// Returns a list of values that are synced with the value of the card's images
        /// </summary>
        /// <returns></returns>
        public static List<int> GetCardsValue()
        {
            List<int> values = new List<int>();
            int tempIndex = 0;

            for (int i = 0; i < Count; i++)
            {
                try
                {
                    values.Add(CardValues[tempIndex]);

                    if ((i + 1) % 4 == 0)
                    {
                        tempIndex++;
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
            }
            return values;
        }

        /// <summary>
        /// Returns the playing cards images as a list
        /// </summary>
        /// <returns></returns>
        public static List<Image>GetCardsImage()
        {
            List<Image> images = new List<Image>();
            Assembly asm = Assembly.GetExecutingAssembly();
            Assembly resourceAssembly = Assembly.Load(new AssemblyName(asm.GetName().Name));
            string[] manifests = resourceAssembly.GetManifestResourceNames();
            using (ResourceReader reader = new ResourceReader(resourceAssembly.GetManifestResourceStream(manifests[0])))
            {
                IDictionaryEnumerator dict = reader.GetEnumerator();
                while (dict.MoveNext())
                {
                    string name = dict.Key as string;

                    if (!name.Contains("cardback")) // We dont want to add the card back images to the list
                    {
                        Image image = dict.Value as Image;
                        images.Add(image);
                    }
                }
            }
            return images;
        }
    }
}
