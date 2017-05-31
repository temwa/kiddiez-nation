using System.Data.Entity;
using System.Collections.Generic;

namespace Nation1.Models
{
   public class ProductDatabaseInitializer : DropCreateDatabaseIfModelChanges<ProductContext>
   //public class ProductDatabaseInitializer : DropCreateDatabaseAlways<ProductContext>
    {
        protected override void Seed(ProductContext context)
        {
            GetCategories().ForEach(c => context.Categories.Add(c));
            GetProducts().ForEach(p => context.Products.Add(p));
        }

        private static List<Category> GetCategories()
        {
            var categories = new List<Category>
            {
                new Category
                {
                    CategoryID = 1,
                    CategoryName = "Bottles-Pacifiers-More",
                    Description = "Bottles, Pacifiers And More"
                },
                new Category
                {
                    CategoryID = 2,
                    CategoryName = "Formula",
                    Description = "Formula"
                },
                new Category
                {
                    CategoryID = 3,
                    CategoryName = "Toys",
                    Description = "Toys"
                },
                new Category
                {
                    CategoryID = 4,
                    CategoryName = "Parental-Books",
                    Description = "Parental Books"
                },
                new Category
                {
                    CategoryID = 5,
                    CategoryName = "Baby-Children-Books",
                    Description = "Baby/Children Books"
                },
                new Category
                {
                    CategoryID = 6,
                    CategoryName = "Clothes",
                    Description = "Clothes"
                },
                new Category
                {
                    CategoryID = 7,
                    CategoryName = "Nappies",
                    Description = "Nappies"
                },
            };
            return categories;
        }

        private static List<Product> GetProducts()
        {
            var products = new List<Product>
            {
                new Product
                {
                    ProductID = 1,
                    ProductName = "330ml Classic Baby Bottle",
                    ProductLinkName = "330ml-Classic-Baby-Bottle",
                    Description = "3months+ Variable Flow Nipple",
                    ImagePath = "bottle1.png",
                    UnitPrice = 135.00,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 2,
                    ProductName = "125ml Classic Baby Bottle",
                    ProductLinkName = "125ml-Classic-Baby-Bottle",
                    Description = "0months+ Newborn Flow Nipple",
                    ImagePath = "bottle2.png",
                    UnitPrice = 165.00,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 3,
                    ProductName = "260ml Classic Baby Bottle",
                    ProductLinkName = "260ml-Classic-Baby-Bottle",
                    Description = "1month+ Slow Flow Nipple",
                    ImagePath = "bottle3.png",
                    UnitPrice = 245.00,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 4,
                    ProductName = "200ml Toddler Cup",
                    ProductLinkName = "200ml-Toddler-Cup",
                    Description = "6months+ Soft Spout",
                    ImagePath = "bottle4.png",
                    UnitPrice = 179.00,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 5,
                    ProductName = "260ml Toddler Cup",
                    ProductLinkName = "260ml-Toddler-Cup",
                    Description = "12months+ Toddler Spout",
                    ImagePath = "bottle5.png",
                    UnitPrice = 199.00,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 6,
                    ProductName = "Classic Pacifiers (2 Pack)",
                    ProductLinkName = "Classic-Pacifiers-2-Pack)",
                    Description = "0 - 6 months",
                    ImagePath = "pac1.png",
                    UnitPrice = 125.00,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 7,
                    ProductName = "Classic Pacifiers (2 Pack)",
                    ProductLinkName = "Classic-Pacifiers-2-Pack",
                    Description = "6 - 18 months",
                    ImagePath = "pac2.png",
                    UnitPrice = 135.00,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 8,
                    ProductName = "Night Time Pacifiers (2 Pack)",
                    ProductLinkName = "Night-Time-Pacifiers-2-Pack",
                    Description = "3 - 6 months",
                    ImagePath = "pac3.png",
                    UnitPrice = 135.00,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 9,
                    ProductName = "Fashion Pacifiers (2 Pack)",
                    ProductLinkName = "Fashion-Pacifiers-2-Pack",
                    Description = "3 - 6 months",
                    ImagePath = "pac4.png",
                    UnitPrice = 135.00,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 10,
                    ProductName = "Fashion Pacifiers (2 Pack)",
                    ProductLinkName = "Fashion-Pacifiers-2-Pack",
                    Description = "6 - 18 months",
                    ImagePath = "pac5.png",
                    UnitPrice = 135.00,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 11,
                    ProductName = "Non H.A. Infant Formula (1.8kg)",
                    ProductLinkName = "Non-H-A-Infant-Formula",
                    Description = "0 - 6 months, Formula Gentle Start 1",
                    ImagePath = "form7.jpg",
                    UnitPrice = 209.90,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 12,
                    ProductName = "Lactogen Infant Milk (1.8kg)",
                    ProductLinkName = "Lactogen-Infant-Milk",
                    Description = "6 - 12 months, Formula Gentle Plus 2",
                    ImagePath = "form8.jpg",
                    UnitPrice = 192.99,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 13,
                    ProductName = "Lactogen Infant Milk (900g)",
                    ProductLinkName = "Lactogen-Infant-Milk-900g",
                    Description = "0 - 6 months, Formula Gentle Start 1",
                    ImagePath = "form1.jpg",
                    UnitPrice = 114.99,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 14,
                    ProductName = "Lactogen Infant Milk (900g)",
                    ProductLinkName = "Lactogen-Infant-Milk-900g",
                    Description = "6 - 12 months, Formula Gentle Plus 2",
                    ImagePath = "form2.jpg",
                    UnitPrice = 114.99,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 15,
                    ProductName = "Non H.A. Infant Formula (800g)",
                    ProductLinkName = "Non-HA-Infant-Formula-800g",
                    Description = "0 - 6 months, Starter",
                    ImagePath = "form3.jpg",
                    UnitPrice = 209.90,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 16,
                    ProductName = "Non H.A. Infant Formula (800g)",
                    ProductLinkName = "Non-H-A-Infant-Formula-800g",
                    Description = "6 - 12 months, Follow Up",
                    ImagePath = "form4.jpg",
                    UnitPrice = 209.90,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 17,
                    ProductName = "Non H.A. Infant Formula (400g)",
                    ProductLinkName = "Non-H-A-Infant-Formula-400g",
                    Description = "0 - 6 months, Starter",
                    ImagePath = "form5.jpg",
                    UnitPrice = 113.90,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 18,
                    ProductName = "Non H.A. Infant Formula (400g)",
                    ProductLinkName = "Non-H-A-Infant-Formula-400g",
                    Description = "6 - 12 months, Follow Up",
                    ImagePath = "form6.jpg",
                    UnitPrice = 113.90,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 19,
                    ProductName = "Snuggle & Teethe (Elephant)",
                    ProductLinkName = "Snuggle-Teethe-Elephant",
                    Description = "Bright Starts",
                    ImagePath = "toy1.jpg",
                    UnitPrice = 69.00,
                    CategoryID = 3
                },
                new Product
                {
                    ProductID = 20,
                    ProductName = "Roaming Safari Activity Gym",
                    ProductLinkName = "Roaming-Safari-Activity-Gym",
                    Description = "Bright Starts",
                    ImagePath = "toy2.jpg",
                    UnitPrice = 479.00,
                    CategoryID = 3
                },
                new Product
                {
                    ProductID = 21,
                    ProductName = "Clack & Slide Activity Ball",
                    ProductLinkName = "Clack-Slide-Activity-Ball",
                    Description = "Bright Starts",
                    ImagePath = "toy3.jpeg",
                    UnitPrice = 155.00,
                    CategoryID = 3
                },
                new Product
                {
                    ProductID = 22,
                    ProductName = "Click & Giggle Remote",
                    ProductLinkName = "Click-Giggle-Remote",
                    Description = "Bright Starts",
                    ImagePath = "toy4.jpg",
                    UnitPrice = 149.00,
                    CategoryID = 3
                },
                new Product
                {
                    ProductID = 23,
                    ProductName = "Take Along Toy Bar",
                    ProductLinkName = "Take-Along-Toy-Bar",
                    Description = "Bright Starts",
                    ImagePath = "toy5.jpg",
                    UnitPrice = 149.00,
                    CategoryID = 3
                },
                new Product
                {
                    ProductID = 24,
                    ProductName = "Pack 'n Go Mini Mobile Tiny Princess",
                    ProductLinkName = "Pack-n-Go-Mini-Mobile-Tiny-Princess",
                    Description = "Tiny Love",
                    ImagePath = "toy6.jpg",
                    UnitPrice = 255.00,
                    CategoryID = 3
                },
                new Product
                {
                    ProductID = 25,
                    ProductName = "Spin & Giggle Puppy",
                    ProductLinkName = "Spin-Giggle-Puppy",
                    Description = "Bright Starts, Having a Ball",
                    ImagePath = "toy7.jpg",
                    UnitPrice = 355.00,
                    CategoryID = 3
                },
                new Product
                {
                    ProductID = 26,
                    ProductName = "Grab 'n Stack Blocks",
                    ProductLinkName = "Grab-n-Stack-Blocks",
                    Description = "Bright Starts",
                    ImagePath = "toy8.jpg",
                    UnitPrice = 155.00,
                    CategoryID = 3
                },
                new Product
                {
                    ProductID = 27,
                    ProductName = "Engaging Autism (Greenspan, S.i & Wieder, S)",
                    ProductLinkName = "Engaging-Autism-Greenspan-Wieder",
                    Description = "Using the Floortime Approach to Help Children Relate, Communicate, and Think",
                    ImagePath = "pbook1.jpg",
                    UnitPrice = 239.00,
                    CategoryID = 4
                },
                new Product
                {
                    ProductID = 28,
                    ProductName = "Step Mother Survival Guide (S. a. Lamar)",
                    ProductLinkName = "Step-Mother-Survival-Guide",
                    Description = "10 Misconceptions About Surviving as a 'Wicked Stepmother'",
                    ImagePath = "pbook2.jpg",
                    UnitPrice = 219.00,
                    CategoryID = 4
                },
                new Product
                {
                    ProductID = 29,
                    ProductName = "Mini-Wife Syndrome (Katie Lee Douglas)",
                    ProductLinkName = "Mini-Wife-Syndrome",
                    Description = "A Divorced Dad's Guide",
                    ImagePath = "pbook3.jpg",
                    UnitPrice = 99.00,
                    CategoryID = 4
                },
                new Product
                {
                    ProductID = 30,
                    ProductName = "Toddler Sense (Ann Richardson)",
                    ProductLinkName = "Toddler-Sense",
                    Description = "Understanding your toddler's sensory world - the key to a happy well-balanced child",
                    ImagePath = "pbook4.jpg",
                    UnitPrice = 129.00,
                    CategoryID = 4
                },
                new Product
                {
                    ProductID = 31,
                    ProductName = "Baby Sense (Megan Faure, Ann Richardson, et al.)",
                    ProductLinkName = "Baby Sense",
                    Description = "This 2nd Edition is sure to hold the same appeal for parents in that it offers practical solutions for the common issues of infancy. The new content will enhance the ways parents respond to their baby's sensory needs in a sense-able manner. Baby Sense is your key to: A calm, contented, colic-free baby; Establishing good sleep habits and enjoying peaceful nights; Your baby's optimal development and positive early experiences.",
                    ImagePath = "pbook5.jpg",
                    UnitPrice = 105.00,
                    CategoryID = 4
                },
                new Product
                {
                    ProductID = 32,
                    ProductName = "The Me, Me, Me Epidemic (Amy McCready)",
                    ProductLinkName = "The-Me-Me-Me-Epidemic",
                    Description = "A Step-by-Step Guide to Raising Capable, Grateful Kids in an Over-Entitled World",
                    ImagePath = "pbook6.jpg",
                    UnitPrice = 389.00,
                    CategoryID = 4
                },
                new Product
                {
                    ProductID = 33,
                    ProductName = "Stress-Proof Your Teen (Heath Dingwell)",
                    ProductLinkName = "Stress-Proof-Your-Teen",
                    Description = "Helping Your Teen Manage Stress and Build Healthy Habits",
                    ImagePath = "pbook7.jpg",
                    UnitPrice = 239.00,
                    CategoryID = 4
                },
                new Product
                {
                    ProductID = 34,
                    ProductName = "I Can Be...",
                    ProductLinkName = "I-Can-Be",
                    Description = "Story Collection",
                    ImagePath = "bbook1.jpg",
                    UnitPrice = 99.00,
                    CategoryID = 5
                },
                new Product
                {
                    ProductID = 35,
                    ProductName = "Saving the Day! (Melissa Lagonegro)",
                    ProductLinkName = "Saving-the-Day",
                    Description = "Barbie in Princess Power",
                    ImagePath = "bbook2.jpg",
                    UnitPrice = 71.00,
                    CategoryID = 5
                },
                new Product
                {
                    ProductID = 36,
                    ProductName = "Lego Ninjago (Inc. Scholastic)",
                    ProductLinkName = "Lego-Ninjago",
                    Description = "This official sticker book includes more than 75 stickers of the heroes, villains, vehicles, and weapons--along with information about each and fill-in sections for readers to add their own notes.",
                    ImagePath = "bbook3.jpg",
                    UnitPrice = 88.00,
                    CategoryID = 5
                },
                new Product
                {
                    ProductID = 37,
                    ProductName = "Kai (Greg Farshtey)",
                    ProductLinkName = "Kai-Greg-Farshtey",
                    Description = "Will Kai be the greatest warrior ever known? Maybe, if he ever listens to Sensei Wu long enough to complete his training. He's stubborn, he's reckless, and he might just save the world.",
                    ImagePath = "bbook4.jpg",
                    UnitPrice = 76.00,
                    CategoryID = 5
                },
                new Product
                {
                    ProductID = 38,
                    ProductName = "First 100 Words (Roger Priddy)",
                    ProductLinkName = "First-100-Words",
                    Description = "A soft-to-touch, padded board book of words. Packed with over 100 first words to learn and bright, vibrant pictures that babies will love to look at!",
                    ImagePath = "bbook5.jpg",
                    UnitPrice = 62.00,
                    CategoryID = 5
                },
                new Product
                {
                    ProductID = 39,
                    ProductName = "Toddler Town: Zoo (Roger Priddy)",
                    ProductLinkName = "Toddler-Town-Zoo",
                    Description = "What things can you see at the zoo? This new series of illustrated board books provides an ideal introduction to the zoo for toddlers who are just beginning to discover the world around them.",
                    ImagePath = "bbook6.jpg",
                    UnitPrice = 58.00,
                    CategoryID = 5
                },
                new Product
                {
                    ProductID = 40,
                    ProductName = "Toddler Town: Seaside (Roger Priddy)",
                    ProductLinkName = "Toddler-Town-Seaside",
                    Description = "What things can you see by the sea? This new series of illustrated board books provides an ideal introduction to the seaside for toddlers who are just beginning to discover the world around them.",
                    ImagePath = "bbook7.jpg",
                    UnitPrice = 99.00,
                    CategoryID = 5
                },
                new Product
                {
                    ProductID = 40,
                    ProductName = "Lift The Flap: First 100 Farm Words (Roger Priddy)",
                    ProductLinkName = "Lift-The-Flap-First-100-Farm-Words",
                    Description = "From animals to buildings, crops to machines, there are more than 100 first farm words to learn in this interactive board book with more than 50 lift-the-flaps.",
                    ImagePath = "bbook8.jpg",
                    UnitPrice = 149.00,
                    CategoryID = 5
                },
                new Product
                {
                    ProductID = 41,
                    ProductName = "Dribble Ons Bright Baby Bib",
                    ProductLinkName = "Dribble-Ons-Bright-Baby-Bib",
                    Description = "Dribble ons draw away the moisture with the soft terry cotton lining, whilst being cute and comfortable to wear. Together with Sock Ons they make the perfect gift set and a real fashion statement.",
                    ImagePath = "cloth1.jpg",
                    UnitPrice = 149.00,
                    CategoryID = 6
                },
                new Product
                {
                    ProductID = 42,
                    ProductName = "Short Sleeve Baby Grow - I love Santa",
                    ProductLinkName = "Short-Sleeve-Baby-Grow",
                    Description = "Treat baby to something special this Christmas. All our Baby Grows or Onesies are 100% Cotton and exclusively manufactured in Cape Town, South Africa.",
                    ImagePath = "cloth2.jpg",
                    UnitPrice = 84.00,
                    CategoryID = 6
                },
                new Product
                {
                    ProductID = 43,
                    ProductName = "Disney - Hello Kitty Baby Fun Rattle Sock",
                    ProductLinkName = "Disney-Hello-Kitty-Baby-Fun-Rattle-Sock",
                    Description = "3 - 12 months, Our fun Hello Kitty socks are topped with a plush rattle head and non-slip dots.",
                    ImagePath = "cloth3.jpg",
                    UnitPrice = 49.00,
                    CategoryID = 6
                },
                new Product
                {
                    ProductID = 44,
                    ProductName = "The Funky Shop - Party Tonight",
                    ProductLinkName = "The-Funky-Shop-Party-Tonight",
                    Description = "12 - 18 months",
                    ImagePath = "cloth4.jpg",
                    UnitPrice = 94.00,
                    CategoryID = 6
                },
                new Product
                {
                    ProductID = 45,
                    ProductName = "Plod Ons - Knee Protector",
                    ProductLinkName = "Plod-Ons-Knee-Protector",
                    Description = "Plod Ons Cow Print Plod Ons are designed to protect baby's knees as they crawl around on hard floors or scratchy surfaces.",
                    ImagePath = "cloth5.jpg",
                    UnitPrice = 189.00,
                    CategoryID = 6
                },
                new Product
                {
                    ProductID = 46,
                    ProductName = "I'm Awesome, I Take After My Granny Tshirt",
                    ProductLinkName = "I'm-Awesome-I-Take-After-My-Granny-Tshirt",
                    Description = "Noeltees ZA",
                    ImagePath = "cloth6.jpg",
                    UnitPrice = 180.00,
                    CategoryID = 6
                },
                new Product
                {
                    ProductID = 47,
                    ProductName = "Rhubarb and Custard - I Love Boobies Unisex T-shirt",
                    ProductLinkName= "Rhubarb-and-Custard-I-Love-Boobies-Unisex-T-shirt",
                    Description = "The Rhubarb & Custard I Love Boobies baby t-shirt really has the cute factor. It's catchy slogan make it one of Rhubarb & Custard's most popular sellers.",
                    ImagePath = "cloth7.jpg",
                    UnitPrice = 35.00,
                    CategoryID = 6
                },
                new Product
                {
                    ProductID = 48,
                    ProductName = "Pampers - Active Baby 76 Nappies - Size 3 Jumbo Pack",
                    ProductLinkName = "Pampers-Active-Baby-76-Nappies",
                    Description = "For lovable happy morning moments all your baby needs is lots of love and a diaper that keeps them dry all night long.",
                    ImagePath = "nap1.jpg",
                    UnitPrice = 209.00,
                    CategoryID = 7
                },
                new Product
                {
                    ProductID = 49,
                    ProductName = "BabyJoy Pants Diapers - 40 - Size: 6 (15-25kg)",
                    ProductLinkName = "BabyJoy-Pants-Diapers-40",
                    Description = "As your baby grows and you watch them develop, you will be filled with a sense of joy and pride. BabyJoy supports a parents deep affection for their children.",
                    ImagePath = "nap2.jpg",
                    UnitPrice = 190.00,
                    CategoryID = 7
                },
                new Product
                {
                    ProductID = 50,
                    ProductName = "Pampers - Active Baby Pants 44 Nappies - Size 6 Jumbo Pack",
                    ProductLinkName = "Pampers-Active-Baby-Pants-44-Nappies",
                    Description = "Easy To Change Pants With Up To 12 Hours Of Dryness - Size 6XL (16+ kg)",
                    ImagePath = "nap3.jpg",
                    UnitPrice = 169.00,
                    CategoryID = 7
                },
                new Product
                {
                    ProductID = 51,
                    ProductName = "Huggies Preemies - Size P (Premature) x 30 Nappies - 3kg",
                    ProductLinkName = "Huggies-Preemies-Size-P",
                    Description = "Huggies Preemies is our smallest nappy, to make sure your baby receives the most gentle protection right from the start, even if they arrive a little earlier than expected.",
                    ImagePath = "nap4.jpg",
                    UnitPrice = 105.00,
                    CategoryID = 7
                },
                new Product
                {
                    ProductID = 52,
                    ProductName = "Huggies - Gold Boy - Size 3x72 Nappies (6 - 10kg)",
                    ProductLinkName = "Huggies-Gold-Boy-Size-3",
                    Description = "Huggies Gold, our driest nappy ever, has a soft DryTouch liner that quickly draws in wetness away from your baby's skin and distributes the fluid evenly inside the core of the nappy -all in a matter of seconds.",
                    ImagePath = "nap5.jpg",
                    UnitPrice = 179.00,
                    CategoryID = 7
                },
                new Product
                {
                    ProductID = 53,
                    ProductName = "Huggies - Dry Comfort - Size 3 x 20 Nappies (6-10kg)",
                    ProductLinkName = "Huggies-Dry-Comfort-Size-3",
                    Description = "Huggies Dry Comfort keeps baby dry for up to 12 hours.",
                    ImagePath = "nap6.jpg",
                    UnitPrice = 52.00,
                    CategoryID = 7
                },
                new Product
                {
                    ProductID = 54,
                    ProductName = "Huggies - Dry Comfort - Size 4x17 (8 - 14kg)",
                    ProductLinkName = "Huggies-Dry-Comfort-Size-4",
                    Description = "Huggies Gold, our driest nappy ever, has a soft DryTouch liner that quickly draws in wetness away from your baby's skin and distributes the fluid evenly inside the core of the nappy -all in a matter of seconds.",
                    ImagePath = "nap7.jpg",
                    UnitPrice = 52.00,
                    CategoryID = 7
                },
                new Product
                {
                    ProductID = 55,
                    ProductName = "Huggies - Nappy Pants Boy - 34 - Size 4",
                    ProductLinkName = "Huggies-Nappy-Pants-Boy-34-Size-4",
                    Description = "Huggies Nappy Pants has an all-round breathable stretchy waistband giving your baby freedom to move, and up to 12 hours of tailored absorption for boys.",
                    ImagePath = "nap8.jpg",
                    UnitPrice = 109.00,
                    CategoryID = 7
                }
            };
            return products;
        }
    }
}