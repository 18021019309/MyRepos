using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Test
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string str = "{\n\t'ET_CHARACS':{\n\t'item' : [ {\n\t'CHARACT' : '门体厚度mm',\n\t'VALUE': 90\n\t }, {\n\t'CHARACT' : '门体结构',\n\t'VALUE': '单门'\n\t}, {\n\t'CHARACT' : '规格宽cm',\n\t 'VALUE' : 950\n\t}, {\n\t'CHARACT' : '规格高cm',\n\t 'VALUE': 2050\n\t }, {\n\t'CHARACT' : '锁具',\n\t 'VALUE' : '弹珠锁'\n\t}, {\n\t 'CHARACT' : '门框',\n\t'VALUE' : 'A型框'\n\t }, {\n\t 'CHARACT' : '开向',\n\t 'VALUE' : '外左'\n\t}, {\n\t 'CHARACT' : '开锁方向',\n\t 'VALUE' : '顺时针'\n\t }, {\n\t 'CHARACT' : 'ORDER',\n\t 'VALUE': 600000084811\n\t}, {\n\t 'CHARACT' : 'ORDER_QTY',\n\t 'VALUE': 5.000\n\t} ]\n\t }\n\t}";
            Data result = JsonConvert.DeserializeObject<Data>(str);
            DoorInfo doorInfo = new DoorInfo
            {
                DoorThickness = result.ET_CHARACS.Item[0].VALUE,
                DoorStrut = result.ET_CHARACS.Item[1].VALUE,
                DoorWidth=Convert.ToInt16( result.ET_CHARACS.Item[2].VALUE),
                DoorHigh=Convert.ToInt32(result.ET_CHARACS.Item[3].VALUE)
            };
            Console.WriteLine("结果",result);

            Console.WriteLine("Hello World!");
        }
      

       public class Data
        {
            public DataList ET_CHARACS { get; set; }
        }

      public  class DataList
        {
            public List<Item> Item { get; set; }
        }

       public class Item
        {
            public string CHARACT { get; set; }
            public string VALUE { get; set; }
        }
        public class DoorInfo
        {
            public string DoorThickness { get; set; }
            public string DoorStrut { get; set; }
            public int DoorWidth { get; set; }
            public int DoorHigh { get; set; }
        }
    }
}
