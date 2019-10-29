using System;
using System.Text;
using XPinYinStandard;

namespace XPinYinTestCore
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] maxims = {
                "事常与人违，事总在人为123456789",
                @"骏马是跑出来的，强兵是打出来的?|\!@$%^&*()_+=-,./';:{}[]<>",
                "驾驭命运的舵是奋斗。不抱有一丝幻想，不放弃一点机会,不停止一日努力.",
                "如果惧怕前面跌宕的山岩，生命就永远只能是死水一潭",
                "懦弱的人只会裹足不前，莽撞的人只能引为烧身，只有真正勇敢的人才能所向披靡ghrjh"
            };
            string[] medicines = {
                "聚维酮碘溶液",
                "开塞露",
                "炉甘石洗剂",
                "苯扎氯铵贴",
                "鱼石脂软膏",
                "莫匹罗星软膏",
                "红霉素软膏",
                "氢化可的松软膏5461",
                "sadgsad测试1",
                "输血记录"
            };
            Console.WriteLine("UTF8句子拼音：");
            foreach (var s in maxims)
            {
                Console.WriteLine("汉字：{0}\n拼音：{1}\n", s, PinYin.GetPinYin(s, '%'));
            }
            var GBK = Encoding.GetEncoding("GBK");
            Console.WriteLine("GBK拼音简码：");
            Console.WriteLine("药品：{0}\n简码：{1}\n", "", PinYin.GetInitials("錒", '%', GBK));
            foreach (var m in medicines)
            {
                Console.WriteLine("药品：{0}\n简码：{1}\n", PinYin.ConvertEncoding(m, Encoding.UTF8, GBK), PinYin.GetInitials(PinYin.ConvertEncoding(m, Encoding.UTF8, GBK), '测', GBK));
            }
            Console.ReadKey();
        }
    }
}
