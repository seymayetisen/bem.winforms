using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DictionaryOrnek
{
    public class Ekle<T> where T : Control, new()
    {
        public string Key = "";
        
        public Ekle(string key)
        {
            Key = key;
           
        }
        public T ControlEkle(Dictionary<string, List<Control>> EkliOgeler)
        {
           
            if (!EkliOgeler.ContainsKey(Key))
            {
                EkliOgeler.Add(Key, new List<Control>());
            }


            int top = (EkliOgeler[Key].Count > 0) ? EkliOgeler[Key][EkliOgeler[Key].Count - 1].Top : -10;
            var eklenecek = new T
            {
                Size = new Size(120, 20),
                Text = (EkliOgeler[Key].Count + 1).ToString(),
                Location = new Point(20, top + 30)
            };

            EkliOgeler[Key].Add(eklenecek);

            return eklenecek;
        }
    }
}
