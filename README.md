# XPinYin
实现汉字到拼音,拼音到汉字的转码

 * XPinYin包含一个公开类Pinyin，该类实现了取汉字文本首字母、文本对应拼音、以及
 * 获取和拼音对应的汉字列表等方法。由于汉字字库大，且多音字较多，因此本组中实现的
 * 拼音转换不一定和词语中的字的正确读音完全吻合。但绝大部分是正确的。
 *
 * 设计思路：
 * 将汉字按拼音分组后建立一个字符串数组（见XPyCode.codes），然后使用程序
 * 将XPyCode.codes中每一个汉字通过其编码值使用散列函数：
 *
 *     f(x) = x % PyCode.codes.Length
 *     g(f(x)) = pos(x)
 *
 * 其中, pos(x)为字符x所属字符串所在的XPyCode.codes的数组下标, 然后散列到同XPyCode.codes长度相同长度的一个散列表中XPyHash.hashes。
 * 当检索一个汉字的拼音时，首先从XPyHash.hashes中获取和对应的XPyCode.codes中数组下标，然后从对应字符串查找，
 * 当到要查找的字符时，字符串的前6个字符即包含了该字的拼音。
 *
 * 此种方法的好处一是节约了存储空间，二是兼顾了查询效率。
 
 日志:
 
 /*
 * =================================================================
 * v1.2.x的变化
 * =================================================================
 * 1.增加重构单字符拼音的获取,未找到拼音时返回特定字符串
 * 2.加入标点符号,控制符,10进制数字,空格,小写字母,大写字母,特殊符号,分隔符的兼容
 *
 * 杜宇 2017年9月28日
 * =================================================================
 * v0.2.x的变化
 * =================================================================
 * 1、增加对不同编码格式文本的支持,同时增加编码转换方法Pinyin.ConvertEncoding
 * 2、重构单字符拼音的获取，未找到拼音时返回字符本身.
 *
 * 汪思言 2012年7月23日晚
 */
 
运行结果:

UTF8句子拼音：
汉字：事常与人违，事总在人为123456789
拼音：shi chang yu ren wei ，shi zong zai ren wei 123456789

汉字：骏马是跑出来的，强兵是打出来的?|\!@$%^&*()_+=-,./';:{}[]<>
拼音：jun ma shi pao chu lai de ，qiang bing shi da chu lai de ?|\!@$%^&*()_+=-,./';:{}[]<>

汉字：驾驭命运的舵是奋斗。不抱有一丝幻想，不放弃一点机会,不停止一日努力.
拼音：jia yu ming yun de duo shi fen dou 。bu bao you yi si huan xiang ，bu fang qi yi dian ji hui ,bu ting zhi yi ri nu li .

汉字：如果惧怕前面跌宕的山岩，生命就永远只能是死水一潭
拼音：ru guo ju pa qian mian die dang de shan yan ，sheng ming jiu yong yuan zhi neng shi si shui yi tan

汉字：懦弱的人只会裹足不前，莽撞的人只能引为烧身，只有真正勇敢的人才能所向披靡ghrjh
拼音：nuo ruo de ren zhi hui guo zu bu qian ，mang zhuang de ren zhi neng yin wei shao shen ，zhi you zhen zheng yong gan de ren cai neng suo xiang pi mi ghrjh

GBK拼音简码：
药品：
简码：测

药品：聚维酮碘溶液
简码：JWTDRY

药品：开塞露
简码：KSL

药品：炉甘石洗剂
简码：LGSXJ

药品：苯扎氯铵贴
简码：BZLAT

药品：鱼石脂软膏
简码：YSZRG

药品：莫匹罗星软膏
简码：MPLXRG

药品：红霉素软膏
简码：HMSRG

药品：氢化可的松软膏5461
简码：QHKDSRG5461

药品：sadgsad测试1
简码：SADGSADCS1

药品：输血记录
简码：SXJL
 
该项目在汪思言大神的NPinYin项目基础上进行修改:

项目链接: 
这些都是2010年以前的方案，至少还有大侠在为汉字转拼音不断努力着，目前发现最完美的就是NPINYIN，在googlecode可以看到它的开源项目，http://code.google.com/p/npinyin/
不能识别的字很少，而且还在不断维护更新，日趋完美，推荐大家使用。
下载地址
dll：http://files.cnblogs.com/files/guohu/NPinyin-0.2.4588.20158-bin.zip
源码：http://files.cnblogs.com/files/guohu/NPinyin-0.2.x-source_code.zip
