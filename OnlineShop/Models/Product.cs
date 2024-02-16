using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public long ProductPrice { get; set; }
        public string ProductDesc { get; set; }
        public string ProductImage { get; set; }
        public int ProductCategoryID { get; set; }

        public List<Product> GetProducts()
        {
            var ProductList = new List<Product>
            {
                new Product{ProductID=1,ProductName="VivoBook 15",ProductPrice=6900,ProductImage="laptop1.jpg",
                    ProductDesc="The ASUS VivoBook Pro 15 is a powerful laptop that combines performance with style"  +
                    " Here are some key features of the VivoBook Pro 15 Processor: It is equipped with an AMD Ryzen" +
                    " 5000 Series processor Display:The laptop boasts a 15.6 - inch NanoEdge display that showcases true colors." +
                    "Graphics: For graphics-intensive tasks, it features an NVIDIA GeForce RTX 3050 GPU."+
                    "Memory: With 16GB RAM, you can multitask seamlessly.Storage: It comes with a 512GB SSD for fast data access."+
                    " Operating System: The VivoBook Pro 15 runs on Windows 11." + "Design: The sleek design and " +
                    "lightweight build make it a great choice for both work and play",ProductCategoryID=1},

                 new Product{ProductID=2,ProductName="  Aspire 5 ",ProductPrice=5600,ProductImage="laptop2.jpg",
                     ProductDesc="Certainly! The Acer Aspire series offers a range of laptops designed to cater to various needs. " +
                     "Let me introduce you to a few notable models:Acer Aspire 5 (Intel):Powered by 13th Gen Intel® Core™ Processors " +
                     "and NVIDIA® GeForce RTX® graphics, this laptop is ideal for multitasking both at home and on the go1.It features a slim design," +
                     " making it easy to carry around. Whether you’re working, studying, or enjoying multimedia content, " +
                     "the Aspire 5 has you covered.",ProductCategoryID=1},

                  new Product{ProductID=3,ProductName="Yoga 520 - A1",ProductPrice=1050,ProductImage="laptop3.jpg",
                      ProductDesc="The Lenovo Yoga 520 is a versatile 2-in-1 laptop that combines style, entertainment features" +
                      ", and performance. Here are some key details about the Yoga 520 (14):Display: The Yoga 520 features a 14 -" +
                      " inch display with a resolution of 1920 x 1080 pixels.The panel type is IPS, ensuring vibrant colors and " +
                      "wide viewing angles1. Processor: It is equipped with powerful processors that allow smooth multitasking and " +
                      "performance.RAM: The laptop comes with 8 GB of DDR4 SDRAM, which contributes to efficient performance." +
                      "Entertainment Features:Gorgeous Video: Enjoy high-quality visuals for movies, videos, and more." +
                      "Enhanced Audio: Immersive sound for an enhanced entertainment experience.Optimized Video Chat:" +
                      " Clear and crisp video calls with optimized features",ProductCategoryID=1},

                   new Product{ProductID=4,ProductName="K456UR",ProductPrice=1900,ProductImage="laptop3.jpg",
                       ProductDesc="The ASUS K456UR is a laptop model that falls within the Asus Aspire series." +
                       " Here are some details about this laptop:ASUS K456UR-WX004D:Processor: Equipped with an " +
                       "Intel® Core™ i5 - 6200U processor running at 2.3 GHz.Memory: Comes with 4 GB DDR4-SDRAM." +
                       "Storage: Features a 1 TB HDD.Graphics: Powered by an NVIDIA® GeForce® 930MX GPU.Operating " +
                       "System: Ships with FreeDOS.Form Factor: Clamshell design with a 14 - inch HD display1.",ProductCategoryID=1},

                     new Product{ProductID=5,ProductName="iPad Pro 10.5 inch WiFi ",ProductPrice=1200,ProductImage="tablet1.jpg",
                         ProductDesc="The iPad Pro 10.5-inch is a powerful tablet that offers a range of features and capabilities." +
                         " Here are some key specifications:Display: The iPad Pro 10.5 - inch features a Retina display with a" +
                         " resolution of 2224 x 1668 pixels and a pixel density of 264 pixels per inch.It also features ProMotion" +
                         " technology for smoother scrolling and more responsive touch input1. Processor: It is powered by an A10X Fusion " +
                         "chip with 64 - bit architecture and an embedded M10 coprocessor. Memory: The tablet comes with 64GB, 256GB, or" +
                         " 512GB of internal storage. Camera: The iPad Pro 10.5-inch features a 12-megapixel camera with an f/1.8 aperture" +
                         " and optical image stabilization.It also has a 7-megapixel front-facing camera with an f/2.2 aperture and " +
                         "Retina Flash.Connectivity: The tablet supports Wi-Fi (802.11a/b/g/n/ac) and Bluetooth 4.2 technology." +
                         "Battery Life: The iPad Pro 10.5-inch has a built-in 30.4-watt-hour rechargeable lithium-polymer battery " +
                         "that provides up to 10 hours of surfing the web on Wi-Fi, watching video, or listening to music1.",ProductCategoryID=3},

                     new Product{ProductID=6,ProductName="Yoga Tab 3 8.0 YT3-850M",ProductPrice=1220,ProductImage="tablet2.jpg",
                         ProductDesc="The Lenovo Yoga Tab 3 8.0 is a tablet that was released in October 2015. Here are some of its " +
                         "key specifications:Display: The tablet features an 8.0-inch IPS LCD display with a resolution of 800 x 1280 " +
                         "pixels and a pixel density of 189 pixels per inch Processor: It is powered by a Qualcomm MSM8909 Snapdragon" +
                         " 210 chipset with a Quad-core 1.1 GHz Cortex-A7 CPU and an Adreno 304 GPU.Memory: The tablet comes with 16GB " +
                         "of internal storage and 1GB RAM.Camera: The Yoga Tab 3 8.0 features a single 8 MP primary camera with autofocus " +
                         "and a video recording capability. It does not have a front-facing camera1.Connectivity: The tablet supports Wi-Fi " +
                         "802.11 b / g / n and Bluetooth 4.0.Battery Life: The Yoga Tab 3 8.0 has a built -in 6200 mAh Li-Ion battery that " +
                         "provides up to 20 hours of talk time and up to 2280 hours of standby time1.  ",ProductCategoryID=3},

                      new Product{ProductID=7,ProductName="Zenfone Zoom",ProductPrice=1400,ProductImage="mobile1.jpg",
                          ProductDesc="The Asus Zenfone Zoom ZX550 is a smartphone that was released in December 2015." +
                          " Here are some key specifications:Display: The Zenfone Zoom features a 5.5 - inch IPS LCD display" +
                          " with a resolution of 1080 x 1920 pixels and a pixel density of approximately 403 pixels per inch." +
                          "It also comes with Corning Gorilla Glass 3 protection1. Processor: Powered by an Intel Atom Z3580 " +
                          "chipset with a quad-core 2.3 GHz CPU and a PowerVR G6430 GPU. Memory: Available in different configurations:" +
                          "16GB internal storage with 2GB RAM  , 32GB internal storage with 2GB RAM , 64GB internal storage with 2GB RAM " +
                          "128GB internal storage with 4GB RAM Main Camera: Equipped with a 13 MP periscope telephoto zoom lens (f/2.7-4.8)" +
                          " that supports 3x optical zoom. It also features Laser AF, OIS, and a dual-LED dual-tone flash for better low-light " +
                          "photography. Video recording is available at 1080p@30fps.Selfie Camera: The front camera is a 5 MP shooter with an " +
                          "aperture of f / 2.0. Connectivity: Supports Wi-Fi 802.11 a / b / g / n / ac, Bluetooth 4.0, and GPS/ GLONASS." +
                          "Battery: Powered by a 3000 mAh non-removable Li - Po battery.Dimensions: Measures 158.9 x 78.8 x 12 mm and " +
                          "weighs 185 g.Colors: Available in Meteorite black and Glacier white." ,ProductCategoryID=2},


                       new Product{ProductID=8,ProductName="iPhone 8",ProductPrice=1100,ProductImage="mobile2.jpg",
                           ProductDesc="The Apple iPhone 8 is a remarkable smartphone released in September 2017." +
                           " Let’s delve into its key specifications: Design and Build:The iPhone 8 boasts a sleek " +
                           "design with a glass front and back(made by Corning) and an aluminum frame.It is IP67 dust" +
                           " and water - resistant, meaning it can withstand being submerged in up to 1 meter of water for " +
                           "30 minutes.  Apple Pay is supported for secure transactions.Display:The 4.7 - inch Retina IPS " +
                           "LCD screen offers a resolution of 750 x 1334 pixels with a pixel density of approximately 326 ppi." +
                           "  It features 3D Touch technology for enhanced interaction. Performance:Powered by the Apple A11 Bionic" +
                           " chipset(10 nm) with a hexa - core CPU(2x Monsoon + 4x Mistral) and a three - core graphics GPU." +
                           "Available in three storage variants: 64GB, 128GB, and 256GB.Camera:Main Camera: A 12 MP wide - angle " +
                           "lens(f / 1.8) with PDAF and OIS.It supports 4K video recording at various frame rates.Selfie Camera: " +
                           "A 7 MP front camera(f / 2.2) with features like Face detection and HDR.Connectivity:Wi - Fi 802.11 " +
                           "a / b / g / n / ac, Bluetooth 5.0, and GPS / GLONASS are included.No 3.5mm headphone jack.Battery:" +
                           "The non - removable 1821 mAh Li - Ion battery provides decent endurance.It supports 15W wired" +
                           " charging(50 % in 30 minutes) and wireless charging(Qi).Colors: Available in Silver, Space Gray, " +
                           "Gold, and Red. ",ProductCategoryID=2},

                        new Product{ProductID=9,ProductName="Galaxy S24 ",ProductPrice=1300,ProductImage="mobile3.jpg",
                            ProductDesc="The Samsung Galaxy S24 Ultra is an impressive addition to the Galaxy lineup, " +
                            "offering a blend of power, durability, and innovative features. Let’s dive into its " +
                            "specifications:Display: The S24 Ultra boasts a 6.8 - inch QHD + Dynamic LTPO AMOLED display," +
                            " providing vibrant colors and sharp visuals. The flat display is perfect for various tasks, " +
                            "and it even comes with an embedded S Pen for added productivity1.Design and Durability:" +
                            "Wrapped in Titanium, the S24 Ultra is both sleek and strong.The IP68 water and dust resistance " +
                            "rating ensures worry - free adventures, even in puddles1.Camera:200 MP Wide - angle & 2x Optical " +
                            "Quality Zoom: Capture stunning details with the industry - standard camera quality.The most megapixels" +
                            " available on a smartphone allow you to rival reality in your photos.12 MP Ultra Wide:" +
                            " Expand your perspective.50 MP 5x Optical Zoom & 10x Optical Quality Zoom: Zoom into the details." +
                            "10 MP 3x Optical Zoom: More versatility.12 MP Selfie Camera: Perfect for capturing your best moments1." +
                            "Galaxy AI Features:Circle to Search: Use the S Pen or your finger to circle items while scrolling or" +
                            " watching videos, and get instant Google Search results.Live Translate: Break down language barriers" +
                            " over the phone or via text.Chat Assist: Get real-time tone suggestions for professional or" +
                            " conversational writing.Note Assist: Summarize your notes with AI formatting1.Performance:" +
                            "Powered by the Snapdragon 8 Gen 3 chipset.ProVisual engine enhances color tone and detail " +
                            "in every photo.",ProductCategoryID=2},
            };

            return ProductList;

        }
    }
}
