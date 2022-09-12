using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.IO;

namespace HW7Project.Models
{
    public class DBInitializer:DropCreateDatabaseAlways<HW7ProjectContext>
    {
        protected override void Seed(HW7ProjectContext context)
        {
            base.Seed(context);

            ////////////////////////////////////////////////////////////////////////
            ///
            List<Products> products = new List<Products>
            {
                new Products
                {
                   ProductID="A00001",
                   ProductName="PETROMAX FT12-T DUTCH OVEN 鑄鐵荷蘭鍋14吋(平底)",
                   PhotoFile=getFileBytes("\\SourcePhotos\\P001.jpg"),
                   ImageMimeType="image/jpeg",
                   UnitPrice=1980,
                   Description= "平底無鍋腳的設計，較適合居家使用，能夠擺放在家用瓦斯爐上\n"+
                                "採用儲熱性最好的鑄鐵材質，可以完整保留食材的風味及營養\n"+
                                "特別設計的鍋蓋，能提供最佳的熱對流，並且可作為煎鍋或是平盤使用\n"+
                                "\n"+
                                "預先養鍋，免開鍋，直接就可開始烹煮料理，使用完畢須養鍋\n"+
                                "通過歐盟食品級安全認證！",
                   UnitsInStock=5,
                   Discontinued=false,
                   CreatedDate=DateTime.Today
                },
                new Products
                {
                   ProductID="A00002",
                   ProductName="公司貨 韓國高碳鋼 28cm 炒鍋 平底鍋 大炒鍋 碳鋼炒鍋 韓國鍋 韓式炒鍋",
                   PhotoFile=getFileBytes("\\SourcePhotos\\P002.jpg"),
                   ImageMimeType="image/jpeg",
                   UnitPrice=1890,
                   Description= "本產品於台灣總代理\"妙管家\"公司貨，請安心購買，杜絕仿冒，原廠保障\n"+
                                "\n"+
                                "來自韓國代代相傳特鋼工藝\n"+
                                "材質堅硬。毛孔小鍋面平滑\n"+
                                "傳熱快，散熱慢，高碳鋼特性\n"+
                                "不具任何化學塗層\n"+
                                "微型孔隙，油容易吸附鍋子，產生自然不沾效果\n"+
                                "採用韓國工藝，德國汽車表面處理技術，抗腐蝕\n"+
                                "事先已開鍋，不用自行在開鍋",
                   UnitsInStock=6,
                   Discontinued=false,
                   CreatedDate=DateTime.Today
                },
                new Products
                {
                   ProductID="A00003",
                   ProductName="Naturehike 露營野炊雙耳琺瑯鍋24cm 夏藕白 CJ021",
                   PhotoFile=getFileBytes("\\SourcePhotos\\P003.jpg"),
                   ImageMimeType="image/jpeg",
                   UnitPrice=2330,
                   Description= "附矽膠防滑防燙三件組\n"+
                                "煎、燉、炒、烤，一鍋多用\n"+
                                "\n"+
                                "高純度鑄鐵製成，防鏽易導熱\n"+
                                "凝水點設計，使水氣均勻回落食物中\n"+
                                "厚重鑄鐵鍋蓋，減少水分流失\n"+
                                "琺瑯塗層，清潔容易，不易竄味\n"+
                                "美味循環，留住食物的原汁原味",
                   UnitsInStock=2,
                   Discontinued=false,
                   CreatedDate=DateTime.Today
                },
                   new Products
                {
                   ProductID="A00004",
                   ProductName="Naturehike 露營野炊雙耳琺瑯鍋24cm 寒杉綠 CJ021",
                   PhotoFile=getFileBytes("\\SourcePhotos\\P004.jpg"),
                   ImageMimeType="image/jpeg",
                   UnitPrice=2330,
                   Description= "附矽膠防滑防燙三件組\n"+
                                "煎、燉、炒、烤，一鍋多用\n"+
                                 "\n"+
                                "高純度鑄鐵製成，防鏽易導熱\n"+
                                "凝水點設計，使水氣均勻回落食物中\n"+
                                "厚重鑄鐵鍋蓋，減少水分流失\n"+
                                "琺瑯塗層，清潔容易，不易竄味\n"+
                                "美味循環，留住食物的原汁原味",
                   UnitsInStock=3,
                   Discontinued=false,
                   CreatedDate=DateTime.Today
                },
                    new Products
                {
                   ProductID="A00005",
                   ProductName="鎧斯Keith Ti6017純鈦折疊環保餐具套鍋組附收納袋",
                   PhotoFile=getFileBytes("\\SourcePhotos\\P005.jpg"),
                   ImageMimeType="image/jpeg",
                   UnitPrice=1590,
                   Description= "戶外登山露營野炊鈦金屬輕量便攜易清洗摺疊握把湯碗平底煎鍋子\n"+
                                "\n"+
                                "2050ml一鍋兩用.快速導熱\n"+
                                "輕量可折疊.環保無毒.抗酸鹼\n"+
                                "矽膠包覆握把.安全不燙手！\n"+
                                "獨立辨識碼,贈禮時尚有品質\n"+
                                "鈦金屬材質,無重金屬.鐵鏽異味",
                   UnitsInStock=4,
                   Discontinued=false,
                   CreatedDate=DateTime.Today
                },
                new Products
                {
                   ProductID="A00006",
                   ProductName="瑞典Trangia Camping set Tundra III-D 鋁夾鋼露營鍋具套組 極地3號.鋁合金套鍋 戶外野營 湯鍋平底煎鍋子 露營野炊 登山鍋具組",
                   PhotoFile=getFileBytes("\\SourcePhotos\\P006.jpg"),
                   ImageMimeType="image/jpeg",
                   UnitPrice=1560,
                   Description= "獨特夾鋼板DUOSSAL2.0\n"+
                                "航太等級鋁材 強韌耐用低耗損\n"+
                                "防黏易潔塗層 方便煮食及清潔\n"+
                                "防滑磨製底座 穩定性極佳\n"+
                                "多功能一體式套鍋 烹飪更多元",
                   UnitsInStock=8,
                   Discontinued=false,
                   CreatedDate=DateTime.Today
                },
                new Products
                {
                   ProductID="A00007",
                   ProductName="韓國麥飯石平底鍋【台灣現貨】32公分 附鍋鏟+鍋蓋 炒鍋 不沾鍋 煎鍋 鍋子 炒菜鍋",
                   PhotoFile=getFileBytes("\\SourcePhotos\\P007.jpg"),
                   ImageMimeType="image/jpeg",
                   UnitPrice=1480,
                   Description= "不挑爐具 容易清洗\n"+
                                 "不沾鍋 少油少煙\n"+
                                 "瓦斯爐\n"+
                                 "電磁爐\n"+
                                 "陶瓷爐\n"+
                                 "鹵素爐\n"+
                                 "黑金爐\n"+
                                 "導熱迅速 露營在外都可以使用",
                   UnitsInStock=5,
                   Discontinued=false,
                   CreatedDate=DateTime.Today
                },
                new Products
                {
                   ProductID="A00008",
                   ProductName="鎧斯Keith Ti6012純鈦折疊鍋組附收納袋.戶外登山露營野炊環保鈦金屬輕量便攜易清洗摺疊握把平底煎鍋子湯碗套鍋",
                   PhotoFile=getFileBytes("\\SourcePhotos\\P008.jpg"),
                   ImageMimeType="image/jpeg",
                   UnitPrice=2640,
                   Description= "1200ml一鍋兩用快速導熱\n"+
                                "輕量可折疊.環保無毒.抗酸鹼\n"+
                                "矽膠包覆握把.安全不燙手！\n"+
                                "獨立辨識碼,贈禮時尚有品質\n"+
                                "鈦金屬材質,無重金屬.鐵鏽異味",
                   UnitsInStock=7,
                   Discontinued=false,
                   CreatedDate=DateTime.Today
                },
                new Products
                {
                   ProductID="A00009",
                   ProductName="鎧斯 Keith Ti6013純鈦折疊鍋組附收納袋.戶外登山露營野炊環保鈦金屬輕量便攜易清洗摺疊握把平底煎鍋子湯碗套鍋",
                   PhotoFile=getFileBytes("\\SourcePhotos\\P009.jpg"),
                   ImageMimeType="image/jpeg",
                   UnitPrice=2450,
                   Description= "一鍋兩用是鍋蓋也是煎鍋\n"+
                                "1600ml一鍋兩用快速導熱\n"+
                                "輕量可折疊.環保無毒.抗酸鹼\n"+
                                "矽膠包覆握把.安全不燙手\n"+
                                "獨立辨識碼,贈禮時尚有品質\n"+
                                "鈦金屬材質,無重金屬.鐵鏽異味",
                   UnitsInStock=4,
                   Discontinued=false,
                   CreatedDate=DateTime.Today
                },
                new Products
                {
                   ProductID="A00010",
                   ProductName="鎧斯Keith Ti6015純鈦環保餐具折疊握把湯鍋.居家戶外露營野炊鈦金屬輕量便攜易清洗摺疊提把雙耳湯鍋子",
                   PhotoFile=getFileBytes("\\SourcePhotos\\P010.jpg"),
                   ImageMimeType="image/jpeg",
                   UnitPrice=1280,
                   Description= "SGS國際認證，醫療用「純鈦」製作不氧化\n"+
                                "輕量提把可折疊、環保無毒，抗酸鹼、耐腐蝕\n"+
                                "矽膠包覆握把，耐熱達270度高溫，安全不燙手\n"+
                                "99.9%鈦金屬材質，無重金屬、鐵鏽異味\n"+
                                "鍋蓋透氣孔設計，滾沸時洩壓減少內容物溢出",
                   UnitsInStock=5,
                   Discontinued=false,
                   CreatedDate=DateTime.Today
                },
                new Products
                {
                   ProductID="A00011",
                   ProductName="鎧斯Keith Ti6015純鈦環保餐具折疊握把湯鍋.居家戶外露營野炊鈦金屬輕量便攜易清洗摺疊提把雙耳湯鍋子",
                   PhotoFile=getFileBytes("\\SourcePhotos\\P011.jpg"),
                   ImageMimeType="image/jpeg",
                   UnitPrice=1940,
                   Description= "SGS國際認證，醫療用「純鈦」製作不氧化\n"+
                                "輕量提把可折疊、環保無毒，抗酸鹼、耐腐蝕\n"+
                                "矽膠包覆握把，耐熱達270度高溫，安全不燙手\n"+
                                "99.9%鈦金屬材質，無重金屬、鐵鏽異味\n"+
                                "鍋蓋透氣孔設計，滾沸時洩壓減少內容物溢出",
                   UnitsInStock=7,
                   Discontinued=false,
                   CreatedDate=DateTime.Today
                },
                new Products
                {
                   ProductID="A00012",
                   ProductName="鈦鍋子【TiANN 純鈦餐具】4.5L 純鈦大湯鍋 元寶鍋 料理火鍋 24cm (含鈦鍋蓋) 超輕盈整組不到500g，超大容量4500ml",
                   PhotoFile=getFileBytes("\\SourcePhotos\\P012.jpg"),
                   ImageMimeType="image/jpeg",
                   UnitPrice=3560,
                   Description= "安全、無毒、輕盈、抗菌\n"+
                                "蒸、煮、烤多功能\n"+
                                "居家、露營、外宿 一個抵多個\n"+
                                 "\n"+
                                "獨門抗菌技術 安全工法 鈦厲害\n"+
                                "安全無毒純鈦 即使不小心乾燒\n"+
                                "也不會釋放出有毒物\n"+
                                 "\n"+
                                "適用瓦斯爐、黑晶爐 、電陶爐，不適用於電磁爐\n"+
                                "因無塗層電鍍美化，加工過程可能會產生些許刮傷與沙孔，並非瑕疵品。",
                   UnitsInStock=6,
                   Discontinued=false,
                   CreatedDate=DateTime.Today
                },
                 new Products
                {
                   ProductID="A00013",
                   ProductName="Naturehike 鈦合金戶外野營便攜炊具組 鍋子1300ml",
                   PhotoFile=getFileBytes("\\SourcePhotos\\P013.jpg"),
                   ImageMimeType="image/jpeg",
                   UnitPrice=1680,
                   Description= "重量為一般餐具的50%，隨身攜帶沒負擔\n"+
                                "耐腐蝕抗氧化，受熱均勻超耐用\n"+
                                "耐高溫不溶出，可直火加熱\n"+
                                "新工藝噴金鋼砂，不留指紋顏色均勻\n"+
                                "把手加強穩固，不易打滑脫手",
                   UnitsInStock=1,
                   Discontinued=false,
                   CreatedDate=DateTime.Today
                }
            };
            products.ForEach(s => context.Products.Add(s));
            context.SaveChanges();

            byte[] getFileBytes(string path)
            {
                FileStream fileOnDisk = new FileStream(HttpRuntime.AppDomainAppPath + path, FileMode.Open);

                byte[] fileBytes;

                using (BinaryReader br = new BinaryReader(fileOnDisk))
                {
                    fileBytes = br.ReadBytes((int)fileOnDisk.Length);
                }
                return fileBytes;
            }
            List<Members> members = new List<Members>
            {
                new Members
                {
                   MemberName="莊孝為",
                   MemberBirthday=Convert.ToDateTime("1981/7/9"),
                   CreatedDate=DateTime.Today,
                   Account="shaio",
                   Password= "12345678"
                }
            };


            members.ForEach(s => context.Members.Add(s));
            context.SaveChanges();

            List<Shippers> shippers = new List<Shippers>
            {
                new Shippers
                {
                   ShipVia="到店取貨"
                },
                new Shippers
                {
                   ShipVia="宅配到府"
                },
                new Shippers
                {
                   ShipVia="郵寄"
                }
            };

            shippers.ForEach(s => context.Shippers.Add(s));
            context.SaveChanges();

            List<PayTypes> payType = new List<PayTypes>
            {
                new PayTypes
                {
                   PayTypeName="信用卡"
                },
                new PayTypes
                {
                   PayTypeName="Line Pay"
                },
                new PayTypes
                {
                   PayTypeName="貨到付款"
                },
                new PayTypes
                {
                   PayTypeName="到店取貨付款"
                }
            };

            payType.ForEach(s => context.PayTypes.Add(s));
            context.SaveChanges();

            List<Employees> employees = new List<Employees>
            {
                new Employees
                {
                   EmployeesName="王立弘",
                   CreatedDate=DateTime.Today,
                   Account="admin",
                   Password="P@ssw0rd"
                }
            };
            employees.ForEach(s => context.Employees.Add(s));
            context.SaveChanges();
        }
    }
}