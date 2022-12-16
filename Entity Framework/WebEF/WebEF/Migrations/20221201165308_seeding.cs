using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebEF.Migrations
{
    public partial class seeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "City", "Country", "Street" },
                values: new object[,]
                {
                    { new Guid("d220318d-1f66-f544-61c3-8e1f56aa2722"), "Lake Richmondview", "Finland", "Weimann Village" },
                    { new Guid("bb37af07-f39f-5f48-2142-99dd9ec8eff2"), "Santamouth", "Macao", "Brannon Lane" },
                    { new Guid("5c96d583-27f9-2d2e-51af-faf6ca6a2592"), "Macejkovicville", "Mongolia", "Welch Land" },
                    { new Guid("7360d064-4c5f-54ec-429c-30acd1a04351"), "McDermotthaven", "Ethiopia", "Cruickshank Trail" },
                    { new Guid("9b5a475f-98ca-def1-6442-ea085d85d850"), "Ullrichville", "Saint Kitts and Nevis", "Bechtelar Ways" },
                    { new Guid("180c058a-defa-a61b-be1b-b46d0c3fe05a"), "Lake Albinaview", "Aruba", "Judy Spring" },
                    { new Guid("9207cac4-9163-4bf1-5927-537f9f63ba71"), "New Valentina", "Rwanda", "Leo Rapids" },
                    { new Guid("3878f47e-d214-eb44-60f8-cd5b2e6d75c3"), "New Felicityton", "Bangladesh", "Matteo Overpass" },
                    { new Guid("fe6050e3-dc94-85f2-e286-b92ef22de44b"), "Port Gerard", "Switzerland", "Zulauf Prairie" },
                    { new Guid("abb10a6c-6c8e-9f09-f551-8e9220eecaf1"), "Nettietown", "Lebanon", "Bayer Square" },
                    { new Guid("fc9b05aa-90de-64d9-856f-101818ba2d6d"), "New Kailey", "Georgia", "Jarred Brooks" },
                    { new Guid("253ccd3f-c789-3ed0-2cef-64d01c29fc0a"), "Pietroton", "Wallis and Futuna", "Hahn Bypass" },
                    { new Guid("e657df55-53f6-86f6-3a25-944b881c8934"), "Lake Carmela", "Eritrea", "Helen Trafficway" },
                    { new Guid("fb25472b-e281-e001-61d9-81ff818b3322"), "Kirstenberg", "New Caledonia", "Klein Rapid" },
                    { new Guid("d077b7aa-8542-90b5-b7fc-393567cec158"), "North Mason", "Ghana", "Toney Point" },
                    { new Guid("39aa1956-0302-a964-e51d-fef27518bcad"), "Billtown", "Uganda", "Kolby Courts" },
                    { new Guid("808c3f78-fa78-725b-ad57-dd7b8315a05f"), "Framiville", "Turkey", "King Island" },
                    { new Guid("b56a1ecf-3da4-1226-99d9-48fb5a132ecc"), "Brekkestad", "Seychelles", "Coty Loaf" },
                    { new Guid("a14a1030-567f-1f04-cfab-bb41c401b12c"), "South Ora", "Gabon", "Gia Viaduct" },
                    { new Guid("6b2b7e7f-cf5e-6e4c-3343-fef96d613d40"), "Adellmouth", "Lithuania", "Barry Keys" },
                    { new Guid("43c1cbbc-1d2c-a88a-5188-66ccd72d3d7f"), "West Orrinside", "Norway", "Annette Field" },
                    { new Guid("b6454d1b-2238-6d80-5b38-f950fe0c0307"), "North Aglaeberg", "Norway", "Brakus Ridge" },
                    { new Guid("aa3ae8e6-3ed7-cb79-55fc-8eadc16c8e39"), "North Stacyport", "Belize", "Bruen Squares" },
                    { new Guid("8243c599-1c1a-76e3-a229-633f2270620d"), "Lueilwitzview", "Switzerland", "Taurean Valleys" },
                    { new Guid("c085a2c9-fd94-db4e-3005-bed4b7b99d88"), "Cassinborough", "Belarus", "Leonel Mountain" },
                    { new Guid("f4c76b7f-63eb-e504-8f5f-53000fc7782d"), "Lake Gavinborough", "Hungary", "Wisozk Fall" },
                    { new Guid("151c4f70-738c-cb3b-1c61-05f15a3452f0"), "Lehnermouth", "Lithuania", "Cali Track" },
                    { new Guid("6a5ab17b-51d3-0633-4935-677c1837bc5c"), "West Baileeside", "Palestinian Territory", "Gerhold Ville" },
                    { new Guid("6d283440-8f0b-c3bc-fc32-d4d9ab827726"), "Port Kari", "Guyana", "Schneider Landing" },
                    { new Guid("b0a87fcc-a540-ecc7-079c-3352a5e1e7f2"), "Willside", "Montserrat", "Jacobi Gateway" },
                    { new Guid("2aa64f66-272b-2c67-3bed-4e1b5725c85d"), "Lake Aleneville", "Libyan Arab Jamahiriya", "Lucius Springs" },
                    { new Guid("b81e76f5-87f5-1e12-eeaa-ca3c62d06698"), "Port Charlenemouth", "Albania", "Ledner Throughway" },
                    { new Guid("43b6a79d-7692-bddd-e4ab-6b1fc1b970dd"), "East Erwinton", "Cape Verde", "Douglas Mills" },
                    { new Guid("6743208a-18e3-f813-0e36-aeaf4f480d9c"), "Port Hanna", "Romania", "Mosciski Road" },
                    { new Guid("40f6ceaf-2005-f654-b0dd-4f40df1fbb11"), "Port Buckchester", "Saint Vincent and the Grenadines", "Weimann Street" },
                    { new Guid("5e8fa248-3f1d-a14e-c52a-23f3eebb7277"), "Ebertshire", "Ethiopia", "Napoleon Center" },
                    { new Guid("e2987b0a-7d6e-50d8-51b3-89b846be1046"), "Rueckertown", "Greece", "Hills Villages" },
                    { new Guid("69fef9c5-5554-3ae6-3b18-9758c324276d"), "Erwinhaven", "El Salvador", "Ortiz Islands" },
                    { new Guid("407e9314-7abc-e99b-a15e-82f8f1f50cc6"), "Adrielview", "Panama", "Paucek Forges" },
                    { new Guid("566d0be6-67a2-592a-d8bd-60a31dcffc71"), "South Kaliberg", "Mozambique", "Roman Hill" },
                    { new Guid("df93e2ac-63fc-6963-1ef5-5555dfc1ade2"), "Jazmynborough", "Niue", "Vivianne Roads" },
                    { new Guid("860da56c-aeb0-d4f8-0712-433f2a2253d6"), "New Nova", "Mali", "Fletcher Vista" },
                    { new Guid("85c102d7-34cf-7793-f3ae-00124fc33b08"), "West Aidenchester", "Austria", "Crona Shoal" },
                    { new Guid("16d37f02-e42d-a5d8-75f4-81ab0295fbfb"), "Wunschtown", "Kenya", "Daugherty Valley" },
                    { new Guid("92032847-da22-ed68-36e8-0df8f28db002"), "East Veronaborough", "Iceland", "Jacobs Courts" },
                    { new Guid("f38e06d6-992b-1e8d-8136-d5918e086482"), "Pollichstad", "Iran", "Kay Rest" },
                    { new Guid("fee36535-8081-9bdc-2d27-aeb56be6090a"), "Devenberg", "Zambia", "Nellie Island" },
                    { new Guid("3585c031-add6-f6fe-475a-617007527de5"), "Lake Daniela", "Uruguay", "Kuhic Mountain" },
                    { new Guid("1692a923-8f41-231d-22fe-c351b0262cb6"), "Langchester", "France", "Beaulah Lights" },
                    { new Guid("cb62316f-7802-1b4f-9f56-cce4b4c56a42"), "Darrionland", "Saudi Arabia", "Drew Plains" },
                    { new Guid("e1c1d586-f889-97b9-2867-65b593554d8a"), "West Aurelieberg", "Germany", "Dandre Corner" },
                    { new Guid("56d430cb-e068-f9d3-97d6-af2b275141e5"), "Alyciaton", "Morocco", "Damion Mall" },
                    { new Guid("5dc3f409-d89e-f611-629d-47d3d34373b8"), "East Samantha", "Christmas Island", "Dooley Divide" },
                    { new Guid("1c359940-9f15-d584-cbfd-6fa98aa52275"), "Sadyeside", "Cameroon", "Bernhard Course" },
                    { new Guid("6c14193f-9078-71cd-7549-3639e12355d5"), "West Kaiafort", "Russian Federation", "Hershel Mount" },
                    { new Guid("e99bdb95-b9a3-ed8f-e1d4-661d84a022eb"), "Andreaneville", "Switzerland", "Crist Street" },
                    { new Guid("14ccc38f-0c7c-8ff9-86b9-9abc2fbf56e0"), "Javierburgh", "Nigeria", "Dare Mission" },
                    { new Guid("47adabd1-376c-2467-12c3-1c5e649a5bff"), "Swaniawskiville", "Nigeria", "Nina Islands" },
                    { new Guid("db8d403f-9e6c-f24c-8759-419636d7fa75"), "Santiagomouth", "Guernsey", "Corkery Springs" },
                    { new Guid("a59e5a01-3627-0d6c-421b-201f3ddac69b"), "East Harry", "Seychelles", "Mariah Center" },
                    { new Guid("91976174-a075-2c9d-5421-f0d3a6c50f86"), "Lake Shayleeburgh", "Seychelles", "Metz Flat" },
                    { new Guid("9381cfc1-729f-1157-6727-9f4a2e2f11e6"), "New Erin", "Sri Lanka", "Dare Mountain" },
                    { new Guid("a2b2b1a1-5928-f8ae-cbf5-9ae879644e31"), "East Andersonmouth", "Gibraltar", "Koch Well" },
                    { new Guid("eb6389b4-e2df-0eb4-604b-5aab771a9ddb"), "Mosciskiside", "United Arab Emirates", "Kohler Haven" },
                    { new Guid("724e0121-50dd-132d-2192-0c0ff1f707dc"), "Kellyburgh", "Kazakhstan", "Braulio Squares" },
                    { new Guid("78cc8e48-0f69-29b9-dcdc-1f8c5971b598"), "Gerardoland", "Montserrat", "Mann Route" },
                    { new Guid("80573226-7fc4-7c45-1695-2b1875980efa"), "Corwinton", "Latvia", "Jayde Keys" },
                    { new Guid("8bb30461-36c9-385d-d48b-9c5b294c969a"), "Jeffreyburgh", "Antarctica (the territory South of 60 deg S)", "Ruecker Mills" },
                    { new Guid("7979cd93-994c-4fc3-e1cf-4650308071db"), "Carmelomouth", "Armenia", "Emery Island" },
                    { new Guid("f6ef6383-10c6-f7e6-2f47-b695cb3557b2"), "Lake Maureen", "United Kingdom", "Roob Drive" },
                    { new Guid("93d3279a-686f-73a1-f9bd-abf7b5372d3a"), "Koreyview", "Saint Barthelemy", "Gislason Turnpike" },
                    { new Guid("f22f1d28-ea09-3122-fc9a-8bc9a3be4904"), "East Maryam", "Republic of Korea", "Ladarius Forge" },
                    { new Guid("4edc314e-b723-ffc5-ad97-7bf72dca81a8"), "Port Mabelle", "Kenya", "Addison Estate" },
                    { new Guid("0c90664c-b077-6534-6d89-5f85248b91b0"), "North Yessenia", "Suriname", "Dach Falls" },
                    { new Guid("117b1a14-7df1-9367-d42a-1a90e892ab4e"), "Reganstad", "Cyprus", "Conner Port" },
                    { new Guid("de841c5c-dd61-2125-849f-0c7bf1fb9f43"), "Emmaberg", "Ghana", "Domingo Wall" },
                    { new Guid("6aa79251-8689-cc4c-72b5-6c3ad7ac83b6"), "Port Florenciomouth", "Democratic People's Republic of Korea", "Hartmann Fork" },
                    { new Guid("b7d768b0-3a48-d7c0-11fa-9107ce25c2e9"), "Merlinmouth", "Haiti", "Little Cape" },
                    { new Guid("a21d5135-63ae-f1cb-beb7-b2eae5b90a01"), "New Myriam", "Tokelau", "Quitzon Station" },
                    { new Guid("203c00dc-6443-7f98-800b-889acc29550b"), "Amyahaven", "Comoros", "Brekke Land" },
                    { new Guid("e6c627d7-2af5-ad44-565c-15ad4b377c92"), "North Jesus", "Norfolk Island", "Heller Road" },
                    { new Guid("f372bbe0-3bf0-c700-ed61-9fbff71c8089"), "North Sylvesterbury", "Botswana", "Arnaldo Dam" },
                    { new Guid("8e4600ca-a906-8270-68c3-acd0d5be34d3"), "Padbergmouth", "Nepal", "Beahan Fork" },
                    { new Guid("c069a70f-aa3e-3287-0ab6-44e85da60896"), "Rickyshire", "Brunei Darussalam", "Theodora River" },
                    { new Guid("7ddf4877-f528-c711-44db-e74fb78c8f86"), "East Carli", "Comoros", "Hagenes Estate" },
                    { new Guid("a55febc4-8586-52bf-abcb-f7af0996828d"), "South Lera", "Paraguay", "Kathryne Villages" },
                    { new Guid("a4b74f0e-a6fc-b2ed-5174-74ea1bb63ba7"), "Ernserville", "Japan", "Kane Meadow" },
                    { new Guid("a314b3c0-35ec-480d-c8a2-360aab4a183e"), "Mayertburgh", "Samoa", "Adrien Branch" },
                    { new Guid("385d0737-d5b9-12e9-c61e-e2645f2f079c"), "East Juana", "Lao People's Democratic Republic", "Schinner Squares" },
                    { new Guid("4a9b169d-5a0e-cd4b-a527-09446bfa1fe3"), "Brayanburgh", "United Arab Emirates", "Beer Estates" },
                    { new Guid("76029197-52cb-dcab-844c-e6fb9e15be87"), "West Thea", "Algeria", "Sammy Creek" },
                    { new Guid("fddbb79f-95fc-6dae-eb4a-f1d87198d61d"), "Ardithburgh", "Northern Mariana Islands", "Aubrey Fort" },
                    { new Guid("569a3b8f-bbf1-2384-4e34-503169870eae"), "New Zelma", "Gibraltar", "Virgie Canyon" },
                    { new Guid("ac680941-2c32-d80e-446b-c4e3c8df0119"), "East Romaview", "Tonga", "Laverne Views" },
                    { new Guid("72125c3b-f073-e1bb-9f76-035eff073867"), "Uptonville", "Syrian Arab Republic", "Price Oval" },
                    { new Guid("40ff49d6-51db-0a74-cd06-dd31da551897"), "South Dorthy", "Estonia", "Frederique Isle" },
                    { new Guid("4934ae52-7807-e943-5121-dbc0ca599c96"), "North Bertland", "Uzbekistan", "Abernathy Junctions" },
                    { new Guid("83971da9-8a89-9f61-eb46-d61ff46d9e05"), "Elroyside", "Lebanon", "Willard Canyon" },
                    { new Guid("bc6f8d53-25aa-0a79-2213-7a6443b12292"), "Edmondshire", "Ecuador", "Gutmann Street" },
                    { new Guid("8be9f827-0421-c677-5455-0ec6d4cf3e24"), "West Jefferyburgh", "Cook Islands", "Glover Bridge" }
                });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "AddressId", "Age", "Name" },
                values: new object[,]
                {
                    { new Guid("d15d2f8d-6774-619c-706d-9da8fab9b59a"), new Guid("d220318d-1f66-f544-61c3-8e1f56aa2722"), 65, "Ramon Mante" },
                    { new Guid("cda99cb9-254d-91ce-9d9c-e0e1a2d0806f"), new Guid("9b5a475f-98ca-def1-6442-ea085d85d850"), 35, "Laverne Conn" },
                    { new Guid("c7ab409b-3ea1-ebef-a82f-63d564c56730"), new Guid("9b5a475f-98ca-def1-6442-ea085d85d850"), 37, "Donnie Konopelski" },
                    { new Guid("712fd99a-7161-94fb-8819-d16084d9b741"), new Guid("180c058a-defa-a61b-be1b-b46d0c3fe05a"), 65, "Josefina Pollich" },
                    { new Guid("b3226088-bc9a-0db9-e9ff-0611d2d1e885"), new Guid("180c058a-defa-a61b-be1b-b46d0c3fe05a"), 41, "Bennie Skiles" },
                    { new Guid("94f5f4a0-2763-9289-09b2-b3326b7dbb86"), new Guid("180c058a-defa-a61b-be1b-b46d0c3fe05a"), 46, "Bonnie Hoppe" },
                    { new Guid("98f1fd09-e491-513c-7122-01a2fd694459"), new Guid("180c058a-defa-a61b-be1b-b46d0c3fe05a"), 43, "Freda Rempel" },
                    { new Guid("9dfdb4e6-4e13-6703-7a43-fc1bc16eadf3"), new Guid("180c058a-defa-a61b-be1b-b46d0c3fe05a"), 21, "Pauline Jones" },
                    { new Guid("c1ea820d-06fc-fda6-26f4-535ff6445907"), new Guid("180c058a-defa-a61b-be1b-b46d0c3fe05a"), 64, "Kristin Langosh" },
                    { new Guid("101734ff-e355-5e16-fc22-93560e045021"), new Guid("9b5a475f-98ca-def1-6442-ea085d85d850"), 63, "Leonard Kemmer" },
                    { new Guid("2a34007c-e3c0-a1e0-d769-da06679f5f88"), new Guid("180c058a-defa-a61b-be1b-b46d0c3fe05a"), 41, "Wilson Mueller" },
                    { new Guid("342ee9ed-3646-b426-38b4-df86b41eaf57"), new Guid("9207cac4-9163-4bf1-5927-537f9f63ba71"), 30, "Nichole Lubowitz" },
                    { new Guid("9b693e5d-69ef-190b-0041-535dbebd9f0c"), new Guid("9207cac4-9163-4bf1-5927-537f9f63ba71"), 40, "Simon Grady" },
                    { new Guid("1b317623-71a8-f5d2-7dba-6ea52eea24ce"), new Guid("9207cac4-9163-4bf1-5927-537f9f63ba71"), 44, "Gladys Crist" },
                    { new Guid("e43d82b4-ab7f-1ad7-f50b-d39e4dd0e429"), new Guid("3878f47e-d214-eb44-60f8-cd5b2e6d75c3"), 57, "James Huels" },
                    { new Guid("3c0ea13a-9dfc-447c-59b0-dc6a72efeb6f"), new Guid("fe6050e3-dc94-85f2-e286-b92ef22de44b"), 59, "Clarence Sawayn" },
                    { new Guid("78ea669f-b6ca-8de5-010d-3f1e7f679d78"), new Guid("fe6050e3-dc94-85f2-e286-b92ef22de44b"), 23, "Virginia O'Conner" },
                    { new Guid("c21c927d-c994-116f-0975-ce6ef6e4200f"), new Guid("abb10a6c-6c8e-9f09-f551-8e9220eecaf1"), 21, "Ashley Hayes" },
                    { new Guid("e59cfd0d-c83b-0767-9896-b37275074866"), new Guid("abb10a6c-6c8e-9f09-f551-8e9220eecaf1"), 24, "Joyce Beahan" },
                    { new Guid("03e6aca1-3a22-b536-2b98-1c255dfe1e78"), new Guid("9207cac4-9163-4bf1-5927-537f9f63ba71"), 38, "Herbert Corkery" },
                    { new Guid("2ee3f52e-0467-bde0-26ad-d0a0ad7054f7"), new Guid("fc9b05aa-90de-64d9-856f-101818ba2d6d"), 27, "Beth Ratke" },
                    { new Guid("471deb5b-97b1-2967-949f-15ea6e8e678e"), new Guid("7360d064-4c5f-54ec-429c-30acd1a04351"), 58, "Ellis Runolfsdottir" },
                    { new Guid("c2b46550-3c43-ea85-83f6-5f87cadedd4f"), new Guid("5c96d583-27f9-2d2e-51af-faf6ca6a2592"), 59, "Tonya Pfannerstill" },
                    { new Guid("9553be24-4172-771a-3d81-8c0ddac81e58"), new Guid("f4c76b7f-63eb-e504-8f5f-53000fc7782d"), 55, "Leigh Hickle" },
                    { new Guid("9a83971b-9ad9-0525-56c2-4ea8a0d8a3b5"), new Guid("3585c031-add6-f6fe-475a-617007527de5"), 33, "Loretta Adams" },
                    { new Guid("73720723-85de-b7ee-4237-22dcdbf2faae"), new Guid("3585c031-add6-f6fe-475a-617007527de5"), 68, "Dominic Rohan" },
                    { new Guid("153d939d-9fc0-33eb-8acf-c199759390dc"), new Guid("3585c031-add6-f6fe-475a-617007527de5"), 66, "Bonnie Green" },
                    { new Guid("98ebbb69-f5d9-5ade-14cf-eb538c42b14e"), new Guid("3585c031-add6-f6fe-475a-617007527de5"), 39, "Kim Altenwerth" },
                    { new Guid("01e75e69-9fc2-5a3b-866a-3bdea47de707"), new Guid("c085a2c9-fd94-db4e-3005-bed4b7b99d88"), 22, "May Wolf" },
                    { new Guid("2ce1df9b-e540-b0f5-8df0-d431c424098e"), new Guid("c085a2c9-fd94-db4e-3005-bed4b7b99d88"), 20, "Ernesto Muller" },
                    { new Guid("0f4bc2ed-6bd4-7b8d-0969-a4131a5d62c6"), new Guid("c085a2c9-fd94-db4e-3005-bed4b7b99d88"), 39, "Randolph Boehm" },
                    { new Guid("1593d445-eab7-47d4-491e-e877b18a30b1"), new Guid("7360d064-4c5f-54ec-429c-30acd1a04351"), 39, "Jaime Runte" },
                    { new Guid("9f10afc4-799a-99d5-f799-e7ed11400435"), new Guid("c085a2c9-fd94-db4e-3005-bed4b7b99d88"), 22, "Kerry Schimmel" },
                    { new Guid("e703f4b3-a667-c43c-0f03-739c76618796"), new Guid("aa3ae8e6-3ed7-cb79-55fc-8eadc16c8e39"), 23, "Vicky Kihn" },
                    { new Guid("2558013e-d068-5521-a94c-59032679740d"), new Guid("aa3ae8e6-3ed7-cb79-55fc-8eadc16c8e39"), 66, "Terence Keebler" },
                    { new Guid("5cccfc8f-b67a-553a-bc77-5b008b3d28fa"), new Guid("aa3ae8e6-3ed7-cb79-55fc-8eadc16c8e39"), 63, "Robyn Cartwright" },
                    { new Guid("5daa1735-5fc6-3db2-828f-75edcc432e78"), new Guid("aa3ae8e6-3ed7-cb79-55fc-8eadc16c8e39"), 28, "Carrie Goyette" },
                    { new Guid("7881eef1-4fda-65c2-a760-daeccee0d29f"), new Guid("bb37af07-f39f-5f48-2142-99dd9ec8eff2"), 21, "Rodney Blanda" },
                    { new Guid("39f0254f-4d52-4d4c-2a34-faa809d2126c"), new Guid("bb37af07-f39f-5f48-2142-99dd9ec8eff2"), 31, "Cassandra Cummerata" },
                    { new Guid("914878d0-2dc7-fddd-e716-7d3cfe7a6584"), new Guid("bb37af07-f39f-5f48-2142-99dd9ec8eff2"), 37, "Karen Botsford" },
                    { new Guid("b153b2ef-a97d-201a-8f3b-353a4c5e668d"), new Guid("5c96d583-27f9-2d2e-51af-faf6ca6a2592"), 42, "Preston Veum" },
                    { new Guid("258edced-c4c2-976b-ad61-a29e6855f7cd"), new Guid("c085a2c9-fd94-db4e-3005-bed4b7b99d88"), 32, "Lena Weissnat" },
                    { new Guid("8c65a0a7-9c74-a1e1-8502-ae2a7e5eb5fb"), new Guid("f4c76b7f-63eb-e504-8f5f-53000fc7782d"), 46, "Terrell King" },
                    { new Guid("0ec870e9-4275-9bb4-0963-2a74004494f3"), new Guid("fc9b05aa-90de-64d9-856f-101818ba2d6d"), 60, "Debbie Marquardt" },
                    { new Guid("35c255ea-76b9-5cb8-cf45-79698da9e361"), new Guid("fc9b05aa-90de-64d9-856f-101818ba2d6d"), 29, "Lorene Hodkiewicz" },
                    { new Guid("d7fa2873-0e14-d046-31ba-51ffde3a1f7d"), new Guid("808c3f78-fa78-725b-ad57-dd7b8315a05f"), 28, "Ruben Gorczany" },
                    { new Guid("d6b6632f-6cca-59f5-d3af-2e687808e101"), new Guid("808c3f78-fa78-725b-ad57-dd7b8315a05f"), 46, "Ollie Hackett" },
                    { new Guid("8942a7e5-15a8-305a-dd77-c61bd44f1537"), new Guid("808c3f78-fa78-725b-ad57-dd7b8315a05f"), 34, "Jean Shanahan" },
                    { new Guid("13c380a7-5504-d2f8-a0bc-44e4e6d7de6a"), new Guid("b56a1ecf-3da4-1226-99d9-48fb5a132ecc"), 22, "Amelia Collier" },
                    { new Guid("2d1f6744-4f14-a9d3-6da3-0cfd05ed4118"), new Guid("b56a1ecf-3da4-1226-99d9-48fb5a132ecc"), 56, "Cecil Koepp" },
                    { new Guid("b1f45667-03b5-1141-5f1b-1f8296424b44"), new Guid("b56a1ecf-3da4-1226-99d9-48fb5a132ecc"), 20, "Matt Sauer" },
                    { new Guid("995f58e8-4fc4-c8c9-b892-7ddc07fd90dd"), new Guid("a14a1030-567f-1f04-cfab-bb41c401b12c"), 42, "Chad Grimes" },
                    { new Guid("8ecba3e0-7897-ff3d-84a9-0e74054e3bd1"), new Guid("a14a1030-567f-1f04-cfab-bb41c401b12c"), 51, "Gene Kilback" },
                    { new Guid("26b7a2dd-4903-ed3d-9f48-53638662fa19"), new Guid("808c3f78-fa78-725b-ad57-dd7b8315a05f"), 51, "Brandy Boyle" },
                    { new Guid("cfeb6d91-ba80-b81c-7fc6-fd52351726ab"), new Guid("a14a1030-567f-1f04-cfab-bb41c401b12c"), 30, "Gail O'Kon" },
                    { new Guid("0deeeb68-0a65-43bd-d465-d197990ccc44"), new Guid("6b2b7e7f-cf5e-6e4c-3343-fef96d613d40"), 43, "Jodi Ankunding" },
                    { new Guid("e1499051-79d5-9488-fa57-3c7ad804edf2"), new Guid("6b2b7e7f-cf5e-6e4c-3343-fef96d613d40"), 20, "Jonathon Cummings" },
                    { new Guid("578e302a-03a4-fa48-3bc5-d14abb332fbc"), new Guid("43c1cbbc-1d2c-a88a-5188-66ccd72d3d7f"), 32, "Billie McClure" },
                    { new Guid("53193611-8a16-6a4b-b454-f110ec17e3ce"), new Guid("43c1cbbc-1d2c-a88a-5188-66ccd72d3d7f"), 30, "Janet Gleason" },
                    { new Guid("475b913c-5b5c-8b04-4bd2-dfcc67e23635"), new Guid("43c1cbbc-1d2c-a88a-5188-66ccd72d3d7f"), 24, "Jackie Wilkinson" },
                    { new Guid("3e515d81-9f05-f214-a62b-3e1a09bc0e28"), new Guid("8243c599-1c1a-76e3-a229-633f2270620d"), 27, "Antonio Wisozk" },
                    { new Guid("cdc773eb-b471-25b0-98d0-0b53f6fcc396"), new Guid("8243c599-1c1a-76e3-a229-633f2270620d"), 69, "Kerry Kessler" },
                    { new Guid("1782a408-0f84-cd36-6361-43a6d3206a66"), new Guid("8243c599-1c1a-76e3-a229-633f2270620d"), 62, "Gregory Davis" },
                    { new Guid("d6c89ba6-cb65-3dda-c591-df47ecabd9aa"), new Guid("6b2b7e7f-cf5e-6e4c-3343-fef96d613d40"), 41, "Stacy Howell" },
                    { new Guid("822b667f-554b-825a-4d92-83e892e5233c"), new Guid("fc9b05aa-90de-64d9-856f-101818ba2d6d"), 66, "Jared Funk" },
                    { new Guid("f7605d24-76bb-7e75-de6e-86e66168b47b"), new Guid("808c3f78-fa78-725b-ad57-dd7b8315a05f"), 49, "Kari Zemlak" },
                    { new Guid("0e87e07c-f09f-dc6d-ef99-065c440d5e56"), new Guid("808c3f78-fa78-725b-ad57-dd7b8315a05f"), 21, "Christina Anderson" },
                    { new Guid("40880f0d-a1e4-51e6-0f75-f1897fd4edb8"), new Guid("fc9b05aa-90de-64d9-856f-101818ba2d6d"), 39, "Shelley Flatley" },
                    { new Guid("a0747cd0-2964-e25a-2b0c-088a31971127"), new Guid("253ccd3f-c789-3ed0-2cef-64d01c29fc0a"), 25, "Lora Brown" },
                    { new Guid("54301b0d-7916-1fa2-2950-ee03a697a7fb"), new Guid("253ccd3f-c789-3ed0-2cef-64d01c29fc0a"), 57, "Kathryn Legros" },
                    { new Guid("e0bb6aa6-572a-ecad-3946-bfc55cedf874"), new Guid("253ccd3f-c789-3ed0-2cef-64d01c29fc0a"), 65, "Fred Christiansen" },
                    { new Guid("87343c94-ac24-b356-83ef-5208e52fe04e"), new Guid("253ccd3f-c789-3ed0-2cef-64d01c29fc0a"), 42, "Hugh Bruen" },
                    { new Guid("d504fae7-fc50-e57b-1131-3438086cf4f6"), new Guid("e657df55-53f6-86f6-3a25-944b881c8934"), 64, "Delia Schaden" },
                    { new Guid("84e201fc-3101-51f5-acee-1e2b5f4ca3a9"), new Guid("e657df55-53f6-86f6-3a25-944b881c8934"), 26, "Johnnie Rodriguez" },
                    { new Guid("3fdd5941-89ae-bfde-97d6-b8050e61636b"), new Guid("e657df55-53f6-86f6-3a25-944b881c8934"), 21, "Muriel Kuhic" },
                    { new Guid("239fead2-116c-a8c3-0fbc-bed5fd7a3085"), new Guid("808c3f78-fa78-725b-ad57-dd7b8315a05f"), 54, "Lionel Olson" },
                    { new Guid("295d048b-e5a7-8275-937b-8c846f698b24"), new Guid("e657df55-53f6-86f6-3a25-944b881c8934"), 41, "Timothy Dach" },
                    { new Guid("f8064226-daf7-0448-e4a6-069c130d7bda"), new Guid("fb25472b-e281-e001-61d9-81ff818b3322"), 34, "Ronnie VonRueden" },
                    { new Guid("4e45e7ec-97e4-5714-2d34-4f0d9ad8e654"), new Guid("fb25472b-e281-e001-61d9-81ff818b3322"), 36, "Mandy Wilkinson" },
                    { new Guid("0a0b91da-4ead-6498-7890-dea87509e885"), new Guid("d077b7aa-8542-90b5-b7fc-393567cec158"), 60, "Richard Maggio" },
                    { new Guid("11c965eb-2a58-643f-678c-8b63238bac20"), new Guid("d077b7aa-8542-90b5-b7fc-393567cec158"), 40, "Lillie Wunsch" },
                    { new Guid("b77f3476-7e4d-2b63-3f03-fdefd68de137"), new Guid("d077b7aa-8542-90b5-b7fc-393567cec158"), 21, "Eduardo Fay" },
                    { new Guid("965b0076-fce5-0afa-a816-660bbb62ff81"), new Guid("39aa1956-0302-a964-e51d-fef27518bcad"), 39, "Viola Rutherford" },
                    { new Guid("bcc7d45a-47a3-540d-7993-af83a8220043"), new Guid("39aa1956-0302-a964-e51d-fef27518bcad"), 52, "Alan Bailey" },
                    { new Guid("10ff5be3-ebd1-0a90-dc76-03a8e75794f0"), new Guid("39aa1956-0302-a964-e51d-fef27518bcad"), 52, "Natasha Collier" },
                    { new Guid("39c0a829-6e82-f5e5-7ddd-d9998db44518"), new Guid("fb25472b-e281-e001-61d9-81ff818b3322"), 62, "Brenda Huel" },
                    { new Guid("067c6d10-8ddc-4fd2-5061-fcb2ebb9c565"), new Guid("8be9f827-0421-c677-5455-0ec6d4cf3e24"), 32, "Luther Schoen" },
                    { new Guid("fb239e1f-0520-7175-c622-e166b9bb73f8"), new Guid("fee36535-8081-9bdc-2d27-aeb56be6090a"), 36, "Inez Mitchell" },
                    { new Guid("7f07a411-3d4d-da40-c2e2-98397f58996a"), new Guid("fee36535-8081-9bdc-2d27-aeb56be6090a"), 35, "Lorena Stracke" },
                    { new Guid("8c212b3d-63c1-77e8-7ac6-76cc4aa6b2b7"), new Guid("2aa64f66-272b-2c67-3bed-4e1b5725c85d"), 41, "Donnie Yundt" },
                    { new Guid("05257d60-ef9e-9abf-8045-6a678974c6cf"), new Guid("2aa64f66-272b-2c67-3bed-4e1b5725c85d"), 57, "Jan Hauck" },
                    { new Guid("7ac7a55b-e077-f2ca-256a-992b806018d3"), new Guid("2aa64f66-272b-2c67-3bed-4e1b5725c85d"), 61, "Kelly Quitzon" },
                    { new Guid("89b459b3-6912-27d3-8ad6-328330875e14"), new Guid("2aa64f66-272b-2c67-3bed-4e1b5725c85d"), 65, "Shane Paucek" },
                    { new Guid("3f44859c-d028-d76e-d8e4-9b72c3de33a4"), new Guid("b81e76f5-87f5-1e12-eeaa-ca3c62d06698"), 22, "Doreen Rau" },
                    { new Guid("4113eebf-3374-c531-5627-1523930b6b8b"), new Guid("b81e76f5-87f5-1e12-eeaa-ca3c62d06698"), 54, "Marty Rippin" },
                    { new Guid("f16c94f9-4b07-2a1e-bf61-cf7496034a31"), new Guid("b81e76f5-87f5-1e12-eeaa-ca3c62d06698"), 53, "Domingo Bartell" },
                    { new Guid("7b7237b6-da5c-5f28-07f5-54950176bdaa"), new Guid("b81e76f5-87f5-1e12-eeaa-ca3c62d06698"), 44, "Tami Blick" },
                    { new Guid("da5527e0-e3d3-1648-c477-fba61204ac2f"), new Guid("2aa64f66-272b-2c67-3bed-4e1b5725c85d"), 20, "Jeremiah Witting" },
                    { new Guid("99664518-a47a-a1a5-3889-ecc2b246cc28"), new Guid("43b6a79d-7692-bddd-e4ab-6b1fc1b970dd"), 43, "Garry Green" },
                    { new Guid("c8b6392b-9d16-bd13-3ff3-be5a388d0da6"), new Guid("43b6a79d-7692-bddd-e4ab-6b1fc1b970dd"), 65, "Constance Crona" },
                    { new Guid("65d98d6e-6b55-fb6e-244f-f283674ca4d9"), new Guid("43b6a79d-7692-bddd-e4ab-6b1fc1b970dd"), 55, "April Stark" },
                    { new Guid("fa9270b5-7883-c7b2-b471-9e40d99e430e"), new Guid("43b6a79d-7692-bddd-e4ab-6b1fc1b970dd"), 30, "Ronnie Kessler" },
                    { new Guid("981b3c2a-f654-424d-a875-6f19dec0e8a4"), new Guid("6743208a-18e3-f813-0e36-aeaf4f480d9c"), 58, "Sherman Dietrich" },
                    { new Guid("0bb4b4ec-327f-ca9e-6e91-fa65c0c209bc"), new Guid("6743208a-18e3-f813-0e36-aeaf4f480d9c"), 22, "Clifton Roob" },
                    { new Guid("c71fd2e4-d8bb-1da5-2c8b-2e58d8f3bf69"), new Guid("40f6ceaf-2005-f654-b0dd-4f40df1fbb11"), 53, "Evan Feest" },
                    { new Guid("4fe28145-63a4-f594-1c8c-9ecde5f64141"), new Guid("40f6ceaf-2005-f654-b0dd-4f40df1fbb11"), 34, "Israel Koepp" },
                    { new Guid("fd5f3019-71e3-b5fc-fdd2-81726410a929"), new Guid("40f6ceaf-2005-f654-b0dd-4f40df1fbb11"), 60, "Guillermo Harris" },
                    { new Guid("7404a7b6-db70-aa9f-e5ea-aee62ce056fd"), new Guid("43b6a79d-7692-bddd-e4ab-6b1fc1b970dd"), 27, "Sonya Greenholt" },
                    { new Guid("75dc147d-8cb1-219c-8fa0-5e15a8fa850f"), new Guid("40f6ceaf-2005-f654-b0dd-4f40df1fbb11"), 53, "Ross Cole" },
                    { new Guid("321a86c3-bed0-0191-ffa5-29320f26c019"), new Guid("b0a87fcc-a540-ecc7-079c-3352a5e1e7f2"), 62, "Glen Haag" },
                    { new Guid("aa380649-ba36-52c3-8d6b-a378f947a8f0"), new Guid("b0a87fcc-a540-ecc7-079c-3352a5e1e7f2"), 27, "Jeannette Pagac" },
                    { new Guid("5d87ddb7-c738-e08c-a6fd-41e008d6681a"), new Guid("8be9f827-0421-c677-5455-0ec6d4cf3e24"), 45, "Cora Watsica" },
                    { new Guid("0cdd36fc-9837-1339-68d7-67949bad08ae"), new Guid("8be9f827-0421-c677-5455-0ec6d4cf3e24"), 22, "Olive West" },
                    { new Guid("cd5afc59-99dc-80b5-c431-6c64bf1b1676"), new Guid("a4b74f0e-a6fc-b2ed-5174-74ea1bb63ba7"), 25, "Jodi Witting" },
                    { new Guid("d35933d2-931d-f39b-8924-db34b7030549"), new Guid("a4b74f0e-a6fc-b2ed-5174-74ea1bb63ba7"), 55, "Derek Lebsack" },
                    { new Guid("3355a1d3-ef40-3eec-d634-46ac790bf864"), new Guid("a4b74f0e-a6fc-b2ed-5174-74ea1bb63ba7"), 30, "Madeline Padberg" },
                    { new Guid("994f640c-6cdf-2cdf-c7fc-7f12b185b42e"), new Guid("a4b74f0e-a6fc-b2ed-5174-74ea1bb63ba7"), 66, "Valerie Mosciski" },
                    { new Guid("601b6fe7-34d3-7a4a-eee8-8daa20bc4223"), new Guid("a4b74f0e-a6fc-b2ed-5174-74ea1bb63ba7"), 37, "Gayle Christiansen" },
                    { new Guid("18260010-f0d4-7088-a1e9-d3f055a3b659"), new Guid("151c4f70-738c-cb3b-1c61-05f15a3452f0"), 23, "Lora Romaguera" },
                    { new Guid("22344500-14e1-698b-2387-84b352497452"), new Guid("b0a87fcc-a540-ecc7-079c-3352a5e1e7f2"), 60, "Arthur Quigley" },
                    { new Guid("92285dfa-f21c-3951-340d-cc403eb9133f"), new Guid("151c4f70-738c-cb3b-1c61-05f15a3452f0"), 51, "Jared Torp" },
                    { new Guid("f74f3318-0ae7-7a7c-8ce0-500c608e9a41"), new Guid("151c4f70-738c-cb3b-1c61-05f15a3452f0"), 44, "Josh Lang" },
                    { new Guid("5489e5af-dc3d-4819-afe7-008395f1001e"), new Guid("6a5ab17b-51d3-0633-4935-677c1837bc5c"), 46, "Joanna Blanda" },
                    { new Guid("4a5c50af-6676-32c6-f440-e0de2f7893bb"), new Guid("6a5ab17b-51d3-0633-4935-677c1837bc5c"), 24, "Taylor Brakus" },
                    { new Guid("72cd3096-64a5-c30c-894a-66cd07c446e8"), new Guid("6a5ab17b-51d3-0633-4935-677c1837bc5c"), 30, "Arnold Herzog" },
                    { new Guid("ff6df3c6-1aa2-6cf7-4816-791ce813c02f"), new Guid("6a5ab17b-51d3-0633-4935-677c1837bc5c"), 45, "Patricia Kerluke" },
                    { new Guid("4ca3b01c-2ebf-2798-ce6c-c0dc422b5f68"), new Guid("6a5ab17b-51d3-0633-4935-677c1837bc5c"), 69, "Kendra Schmitt" },
                    { new Guid("93f3f7b8-43f1-f0c8-042f-a8fba6fa53cb"), new Guid("6d283440-8f0b-c3bc-fc32-d4d9ab827726"), 56, "Celia Gislason" },
                    { new Guid("3c8d652c-84bf-cfb3-d0f9-bf7df7337d29"), new Guid("b0a87fcc-a540-ecc7-079c-3352a5e1e7f2"), 23, "Charlotte Braun" },
                    { new Guid("6903b5da-4a3a-3c58-220f-635c5c8f5493"), new Guid("151c4f70-738c-cb3b-1c61-05f15a3452f0"), 31, "Matthew Stamm" },
                    { new Guid("0e3d8826-0775-8d40-4cc4-95fc42439892"), new Guid("fee36535-8081-9bdc-2d27-aeb56be6090a"), 31, "Terry Thiel" },
                    { new Guid("789ba0b8-c88b-eed3-25c0-353616f77c27"), new Guid("40f6ceaf-2005-f654-b0dd-4f40df1fbb11"), 43, "Ira Cummings" },
                    { new Guid("33478c7c-e0f3-85c6-2a5e-603de17a4222"), new Guid("40f6ceaf-2005-f654-b0dd-4f40df1fbb11"), 49, "Alicia Effertz" },
                    { new Guid("fe6afccd-ed67-c07c-fce6-75eb831efffa"), new Guid("df93e2ac-63fc-6963-1ef5-5555dfc1ade2"), 24, "Delores Graham" },
                    { new Guid("a1e1d455-c951-42cf-acc0-835fae149b78"), new Guid("df93e2ac-63fc-6963-1ef5-5555dfc1ade2"), 49, "Derrick Kulas" },
                    { new Guid("cbd47658-945b-ac6e-7594-cb76d8e2e00d"), new Guid("860da56c-aeb0-d4f8-0712-433f2a2253d6"), 42, "Dean Crist" },
                    { new Guid("8c57d5d3-8650-fb1e-fd76-6d7c70db1963"), new Guid("860da56c-aeb0-d4f8-0712-433f2a2253d6"), 45, "Robin Funk" },
                    { new Guid("31731833-36d9-7c2c-2e37-da059892bf29"), new Guid("860da56c-aeb0-d4f8-0712-433f2a2253d6"), 33, "Daisy Larkin" },
                    { new Guid("0838b21d-d973-f654-6a9f-aec89ac59c10"), new Guid("860da56c-aeb0-d4f8-0712-433f2a2253d6"), 69, "Marilyn Weissnat" },
                    { new Guid("5afd57b8-ea76-b91c-09f2-fa61be6e5f8d"), new Guid("85c102d7-34cf-7793-f3ae-00124fc33b08"), 64, "Jonathon Koss" },
                    { new Guid("6b1e1cf1-41cb-b9b0-5f72-3ea121b9bfcc"), new Guid("85c102d7-34cf-7793-f3ae-00124fc33b08"), 53, "Randolph Rodriguez" },
                    { new Guid("0fdfb4af-36c1-f984-4f99-6019530686c9"), new Guid("df93e2ac-63fc-6963-1ef5-5555dfc1ade2"), 64, "Walter Hodkiewicz" },
                    { new Guid("e78a6167-ead9-1549-c2af-2a6de062ac28"), new Guid("85c102d7-34cf-7793-f3ae-00124fc33b08"), 59, "Gertrude Douglas" },
                    { new Guid("577cef87-4929-41ea-60fe-b74d2ab5a0e5"), new Guid("16d37f02-e42d-a5d8-75f4-81ab0295fbfb"), 28, "Derrick Metz" },
                    { new Guid("b5f703bf-55ca-bf21-c622-bfc3f942009d"), new Guid("16d37f02-e42d-a5d8-75f4-81ab0295fbfb"), 22, "Rosemary Sauer" },
                    { new Guid("8aa1f68f-9152-c7b6-a21a-722fd834753e"), new Guid("92032847-da22-ed68-36e8-0df8f28db002"), 43, "Bruce Gutkowski" },
                    { new Guid("c24586b8-adf0-be2b-4816-cf6abb7bf70c"), new Guid("92032847-da22-ed68-36e8-0df8f28db002"), 22, "Lydia Welch" },
                    { new Guid("b597af37-bc4c-44d7-072a-75e81cc8d91c"), new Guid("f38e06d6-992b-1e8d-8136-d5918e086482"), 24, "Wilfred Klocko" },
                    { new Guid("41312180-c2ee-b91f-007f-095ff7c6eed5"), new Guid("f38e06d6-992b-1e8d-8136-d5918e086482"), 42, "Eloise Bailey" },
                    { new Guid("e3ce283c-24c3-30c1-7e60-8defc6a26ac1"), new Guid("f38e06d6-992b-1e8d-8136-d5918e086482"), 50, "Wesley Sawayn" },
                    { new Guid("8eda1f81-015f-af2d-7e4a-6eecf6fda0e8"), new Guid("f38e06d6-992b-1e8d-8136-d5918e086482"), 41, "Nick Boyle" },
                    { new Guid("57c60047-488b-5972-f409-0bb975d716e7"), new Guid("85c102d7-34cf-7793-f3ae-00124fc33b08"), 63, "Marianne Mayert" },
                    { new Guid("2a847ccb-f748-4580-5a07-ee3c55e13f3a"), new Guid("40f6ceaf-2005-f654-b0dd-4f40df1fbb11"), 65, "Maggie Rice" },
                    { new Guid("d3965e2c-679c-74fa-fd86-f4f2d8a12b27"), new Guid("566d0be6-67a2-592a-d8bd-60a31dcffc71"), 23, "Shirley Morar" },
                    { new Guid("d8dd53f5-fb1b-a009-222d-6597fe8dcf57"), new Guid("407e9314-7abc-e99b-a15e-82f8f1f50cc6"), 34, "Vicky Hammes" },
                    { new Guid("80bf46cc-2043-89ab-da06-7c33529ac72f"), new Guid("5e8fa248-3f1d-a14e-c52a-23f3eebb7277"), 48, "Marlene Hegmann" },
                    { new Guid("33dc5c06-58de-f196-65eb-0829bf19accd"), new Guid("5e8fa248-3f1d-a14e-c52a-23f3eebb7277"), 28, "Lucia Braun" },
                    { new Guid("e0bb938c-c81c-6de0-f8a2-b475d3cdfa81"), new Guid("5e8fa248-3f1d-a14e-c52a-23f3eebb7277"), 65, "Ismael Jacobi" },
                    { new Guid("b1e062b8-e5ce-2c2a-5ae1-5ca16499216b"), new Guid("5e8fa248-3f1d-a14e-c52a-23f3eebb7277"), 46, "Hattie Littel" },
                    { new Guid("8972d043-a8ce-dc90-2c9e-ef015b8efe08"), new Guid("5e8fa248-3f1d-a14e-c52a-23f3eebb7277"), 36, "Geneva Schroeder" },
                    { new Guid("7646d1f1-65a1-6660-05f7-d906063c7a18"), new Guid("5e8fa248-3f1d-a14e-c52a-23f3eebb7277"), 37, "Gretchen Zieme" },
                    { new Guid("a530769f-a571-bb84-c061-b33ecade6f0d"), new Guid("5e8fa248-3f1d-a14e-c52a-23f3eebb7277"), 42, "Rudy Rice" },
                    { new Guid("a138e342-6efc-2117-d99e-67b5e694cf3d"), new Guid("5e8fa248-3f1d-a14e-c52a-23f3eebb7277"), 34, "Tasha Koepp" },
                    { new Guid("eff78a89-914f-4c56-840d-d44956d025a9"), new Guid("566d0be6-67a2-592a-d8bd-60a31dcffc71"), 23, "Jake Mitchell" },
                    { new Guid("f9291e63-cf4f-03b8-3c5b-656dbd6e7285"), new Guid("e2987b0a-7d6e-50d8-51b3-89b846be1046"), 36, "Sophie Breitenberg" },
                    { new Guid("91093ea1-a27f-f98b-3326-9d66ea5ad5e9"), new Guid("e2987b0a-7d6e-50d8-51b3-89b846be1046"), 40, "Elena Erdman" },
                    { new Guid("261e391d-e2be-e2e1-fb3a-56b3cd2fae1d"), new Guid("69fef9c5-5554-3ae6-3b18-9758c324276d"), 52, "Silvia Dach" },
                    { new Guid("245a78c9-6d37-ff3f-c4cf-00a6e1b047a1"), new Guid("69fef9c5-5554-3ae6-3b18-9758c324276d"), 57, "Dana Fay" },
                    { new Guid("2a3f4c78-2df2-2e1e-7692-67e7af1e8fcc"), new Guid("69fef9c5-5554-3ae6-3b18-9758c324276d"), 20, "Ralph O'Connell" },
                    { new Guid("52cb3e54-8d2c-9a9c-f772-148d44d2ba41"), new Guid("69fef9c5-5554-3ae6-3b18-9758c324276d"), 65, "Caroline Bins" },
                    { new Guid("8207d629-4763-bce3-d96f-d990297880b3"), new Guid("69fef9c5-5554-3ae6-3b18-9758c324276d"), 68, "Ella Cronin" },
                    { new Guid("d220b046-0e8c-96a6-1fd1-9bdddc5a31db"), new Guid("69fef9c5-5554-3ae6-3b18-9758c324276d"), 35, "Tanya Schinner" },
                    { new Guid("2b541bff-10c2-b279-1100-248ce8055b9a"), new Guid("407e9314-7abc-e99b-a15e-82f8f1f50cc6"), 23, "Mario Tromp" },
                    { new Guid("b5dad5cc-b74a-cf6f-eec6-98c2cc6654b6"), new Guid("e2987b0a-7d6e-50d8-51b3-89b846be1046"), 30, "Harold Koelpin" },
                    { new Guid("535bc65a-7afe-a866-0772-1ab1664e26dc"), new Guid("8243c599-1c1a-76e3-a229-633f2270620d"), 40, "Bridget Bartell" },
                    { new Guid("f6180ab4-051a-e1d9-c886-24206aee08f2"), new Guid("8243c599-1c1a-76e3-a229-633f2270620d"), 60, "Judy Kilback" },
                    { new Guid("171764c1-1eca-ebc6-4f32-6b0f2f500668"), new Guid("8243c599-1c1a-76e3-a229-633f2270620d"), 29, "Warren Ryan" },
                    { new Guid("86d6a52f-6528-fbfe-9c12-9da2010a605a"), new Guid("56d430cb-e068-f9d3-97d6-af2b275141e5"), 21, "Micheal Schaden" },
                    { new Guid("c877fa5c-b17c-1a5a-74d3-e726b232b3cd"), new Guid("5dc3f409-d89e-f611-629d-47d3d34373b8"), 26, "Lynda Hane" },
                    { new Guid("7646ab53-6a43-5ad9-f072-76d87dd34ae9"), new Guid("5dc3f409-d89e-f611-629d-47d3d34373b8"), 65, "Kurt Robel" },
                    { new Guid("5e18d3fb-fbc6-6591-71e9-89662f9a29c8"), new Guid("1c359940-9f15-d584-cbfd-6fa98aa52275"), 40, "Sherman Olson" },
                    { new Guid("e053aafd-f807-4e69-fa86-1ec3358cf01e"), new Guid("6c14193f-9078-71cd-7549-3639e12355d5"), 56, "Mathew Skiles" },
                    { new Guid("3489e534-59b7-44f4-5789-d5aa7a80293d"), new Guid("6c14193f-9078-71cd-7549-3639e12355d5"), 50, "Hope Heidenreich" },
                    { new Guid("425d539c-46ca-6f4d-34fc-ee6d739babc1"), new Guid("6c14193f-9078-71cd-7549-3639e12355d5"), 63, "Danny Romaguera" },
                    { new Guid("974a24a1-fa5c-42ab-7201-373dda21c6ae"), new Guid("6c14193f-9078-71cd-7549-3639e12355d5"), 62, "Kristin Wintheiser" },
                    { new Guid("33e46022-5f32-cd15-fd3e-a2cd00a5b7fd"), new Guid("56d430cb-e068-f9d3-97d6-af2b275141e5"), 26, "Owen Nader" },
                    { new Guid("14bb9805-1dc4-396e-159f-0f099ab7850d"), new Guid("6c14193f-9078-71cd-7549-3639e12355d5"), 30, "Todd Murazik" },
                    { new Guid("8decf065-1c37-9faa-550e-70edda968bc4"), new Guid("6c14193f-9078-71cd-7549-3639e12355d5"), 37, "Karen Feest" },
                    { new Guid("6213c500-0683-59ae-a272-9332829eba75"), new Guid("6c14193f-9078-71cd-7549-3639e12355d5"), 22, "Alonzo Turcotte" },
                    { new Guid("0b30d53d-f4ea-40be-b658-da9d391b1c84"), new Guid("6c14193f-9078-71cd-7549-3639e12355d5"), 52, "Evan Kling" },
                    { new Guid("e4158f6a-cb4d-3211-a807-0cd9a65f2e32"), new Guid("e99bdb95-b9a3-ed8f-e1d4-661d84a022eb"), 42, "Vivian Becker" },
                    { new Guid("635b4c07-479a-1a69-608f-0726b4f13eb7"), new Guid("e99bdb95-b9a3-ed8f-e1d4-661d84a022eb"), 28, "Freda Block" },
                    { new Guid("fdebfba6-d9bb-4e04-be72-31a640a8dceb"), new Guid("e99bdb95-b9a3-ed8f-e1d4-661d84a022eb"), 24, "Cesar Schuppe" },
                    { new Guid("6a0b99fb-0878-ef9c-b15b-af9f019ac11d"), new Guid("14ccc38f-0c7c-8ff9-86b9-9abc2fbf56e0"), 62, "Betsy Kshlerin" },
                    { new Guid("f77f1d7b-692c-339d-227d-14880dd67f1b"), new Guid("47adabd1-376c-2467-12c3-1c5e649a5bff"), 67, "Yvette Thompson" },
                    { new Guid("2782ad9c-feea-b293-8514-22e5f3903c5f"), new Guid("6c14193f-9078-71cd-7549-3639e12355d5"), 53, "Franklin Labadie" },
                    { new Guid("5d256276-91b8-f8a3-7616-609c32c7c00f"), new Guid("47adabd1-376c-2467-12c3-1c5e649a5bff"), 24, "Garry Mueller" },
                    { new Guid("42b4aab8-eee5-315e-266b-e6f668e4120c"), new Guid("0c90664c-b077-6534-6d89-5f85248b91b0"), 28, "Marty Gutkowski" },
                    { new Guid("8d69268f-06ec-e854-b8c7-15985ddbeeac"), new Guid("0c90664c-b077-6534-6d89-5f85248b91b0"), 22, "Brandy Ondricka" },
                    { new Guid("05ae0867-edab-1516-859f-9fe29e1963b3"), new Guid("4934ae52-7807-e943-5121-dbc0ca599c96"), 49, "Traci Pouros" },
                    { new Guid("fdb625a1-413d-f9ae-e0cb-d1d13c099808"), new Guid("4934ae52-7807-e943-5121-dbc0ca599c96"), 45, "Tommy Effertz" },
                    { new Guid("8d367ad8-3425-416b-d512-74eaa0a9c5d0"), new Guid("4934ae52-7807-e943-5121-dbc0ca599c96"), 69, "Eula Friesen" },
                    { new Guid("2c212257-1502-fd66-ba69-98c2d8d5bbf0"), new Guid("4934ae52-7807-e943-5121-dbc0ca599c96"), 30, "Estelle Bruen" },
                    { new Guid("820a1307-4ec4-ae66-c390-2690ed7636df"), new Guid("83971da9-8a89-9f61-eb46-d61ff46d9e05"), 61, "Franklin Dietrich" },
                    { new Guid("42037930-031f-868e-1a50-f460e2dc7954"), new Guid("83971da9-8a89-9f61-eb46-d61ff46d9e05"), 64, "Boyd Hoppe" },
                    { new Guid("b3c4facb-4215-a2a3-1b21-d8474c256b3a"), new Guid("83971da9-8a89-9f61-eb46-d61ff46d9e05"), 27, "Blanca Wiza" },
                    { new Guid("878cc5d4-2b29-1e98-3378-006903e70346"), new Guid("83971da9-8a89-9f61-eb46-d61ff46d9e05"), 50, "Wendell Jast" },
                    { new Guid("411b8957-0656-234d-58e0-da605a692d47"), new Guid("0c90664c-b077-6534-6d89-5f85248b91b0"), 62, "Rick McGlynn" },
                    { new Guid("efed4dad-cb47-109c-71b4-2d19b5ed768d"), new Guid("83971da9-8a89-9f61-eb46-d61ff46d9e05"), 63, "Isaac Jacobi" },
                    { new Guid("5873334f-6e32-8f0a-f604-9668f164768b"), new Guid("de841c5c-dd61-2125-849f-0c7bf1fb9f43"), 65, "Cecelia Nader" },
                    { new Guid("348f07be-992d-5e3c-f4e8-89a43dff1c70"), new Guid("de841c5c-dd61-2125-849f-0c7bf1fb9f43"), 58, "Billy Brown" },
                    { new Guid("e0a3ada6-1a21-e5dd-71e8-92e9c997ccb8"), new Guid("de841c5c-dd61-2125-849f-0c7bf1fb9f43"), 27, "Elmer Considine" },
                    { new Guid("19401a6d-066d-a064-98e0-7447c3854741"), new Guid("de841c5c-dd61-2125-849f-0c7bf1fb9f43"), 51, "Stuart Gerlach" },
                    { new Guid("da40dbd5-b78e-4fd9-27bb-8e2ab49c0954"), new Guid("117b1a14-7df1-9367-d42a-1a90e892ab4e"), 27, "Emanuel Crist" },
                    { new Guid("5b633d2c-f1e1-6b3c-f248-af64e62bdd88"), new Guid("117b1a14-7df1-9367-d42a-1a90e892ab4e"), 30, "Diane Gutmann" },
                    { new Guid("0df94e0a-7db9-103e-def8-268c1f2ff803"), new Guid("117b1a14-7df1-9367-d42a-1a90e892ab4e"), 34, "Everett Gottlieb" },
                    { new Guid("9e9fc4e2-ce4f-326c-5c80-3e9f83192c5a"), new Guid("117b1a14-7df1-9367-d42a-1a90e892ab4e"), 35, "Randall Shields" },
                    { new Guid("7d922ca9-6d4d-9a13-7fc1-fd2965782412"), new Guid("de841c5c-dd61-2125-849f-0c7bf1fb9f43"), 67, "Gwen Tromp" },
                    { new Guid("523781c6-bce5-5e9b-2372-535c62152cc1"), new Guid("47adabd1-376c-2467-12c3-1c5e649a5bff"), 68, "Dorothy Rutherford" },
                    { new Guid("58d43316-0561-ab5f-7a01-cce4368cee30"), new Guid("47adabd1-376c-2467-12c3-1c5e649a5bff"), 37, "Kara Huels" },
                    { new Guid("24213ba9-2662-af89-b324-56db7ecd6428"), new Guid("db8d403f-9e6c-f24c-8759-419636d7fa75"), 66, "Myra Schiller" },
                    { new Guid("ac069af2-32c4-123c-a1dc-568523e34b76"), new Guid("80573226-7fc4-7c45-1695-2b1875980efa"), 28, "Orville Feil" },
                    { new Guid("1c950e08-6e23-10af-c2dc-fd562629c149"), new Guid("8bb30461-36c9-385d-d48b-9c5b294c969a"), 56, "Karen Lesch" },
                    { new Guid("dc0bf655-565d-c063-ec58-cc86b1620fe0"), new Guid("8bb30461-36c9-385d-d48b-9c5b294c969a"), 65, "Monique Kuphal" },
                    { new Guid("96d49fbe-5232-e39c-34c9-12956f7a81a2"), new Guid("8bb30461-36c9-385d-d48b-9c5b294c969a"), 62, "Kathryn Balistreri" },
                    { new Guid("a2558ac8-364b-e4a5-a993-9a247c43d95c"), new Guid("8bb30461-36c9-385d-d48b-9c5b294c969a"), 59, "Ruth D'Amore" },
                    { new Guid("dd1d0610-ad4c-017e-9dca-89cfdbcc72a7"), new Guid("8bb30461-36c9-385d-d48b-9c5b294c969a"), 33, "Faith Wehner" },
                    { new Guid("b234226e-a0e6-7921-e733-7a13ef38aa6c"), new Guid("7979cd93-994c-4fc3-e1cf-4650308071db"), 26, "Joe Kutch" },
                    { new Guid("4258de66-96f7-7dd4-f1cb-9cc88b058585"), new Guid("f6ef6383-10c6-f7e6-2f47-b695cb3557b2"), 53, "Mamie Kub" },
                    { new Guid("ff04bd04-816d-2bce-243b-352d2864513c"), new Guid("80573226-7fc4-7c45-1695-2b1875980efa"), 35, "Perry Schinner" },
                    { new Guid("2ef51218-2fa2-fc9f-5ba0-defe0da7df4d"), new Guid("f6ef6383-10c6-f7e6-2f47-b695cb3557b2"), 51, "Lila Stracke" },
                    { new Guid("41a0430c-6b09-90b5-d232-764457e4b861"), new Guid("f6ef6383-10c6-f7e6-2f47-b695cb3557b2"), 49, "Priscilla Steuber" },
                    { new Guid("eb26121b-feee-2943-1980-6b05294cb797"), new Guid("93d3279a-686f-73a1-f9bd-abf7b5372d3a"), 23, "Celia Stiedemann" },
                    { new Guid("51018f41-43b8-4287-a02c-210e891d7e0f"), new Guid("93d3279a-686f-73a1-f9bd-abf7b5372d3a"), 55, "Enrique Oberbrunner" },
                    { new Guid("946e2717-5328-e8bf-f702-3aa54c60bccf"), new Guid("f22f1d28-ea09-3122-fc9a-8bc9a3be4904"), 37, "Sheri Kirlin" },
                    { new Guid("e2fd194f-8dc8-25aa-a242-fc6bb19be719"), new Guid("f22f1d28-ea09-3122-fc9a-8bc9a3be4904"), 24, "Jean Mraz" },
                    { new Guid("ba351d16-1852-43a8-4b16-fac5ad7b9a06"), new Guid("f22f1d28-ea09-3122-fc9a-8bc9a3be4904"), 41, "Julius Carter" },
                    { new Guid("fea40ea2-6c2d-5f03-030d-3ce1081f4e9b"), new Guid("d220318d-1f66-f544-61c3-8e1f56aa2722"), 49, "Sabrina Cassin" },
                    { new Guid("d93cc535-2deb-83a1-1be7-b741d5f80fbe"), new Guid("d220318d-1f66-f544-61c3-8e1f56aa2722"), 55, "Alexander Jacobson" },
                    { new Guid("8784acd7-2abe-2d04-b0ed-c9ac2369bcc7"), new Guid("f6ef6383-10c6-f7e6-2f47-b695cb3557b2"), 56, "Sheldon Gusikowski" },
                    { new Guid("3890624b-d6c5-43f1-f42c-53840849eac9"), new Guid("78cc8e48-0f69-29b9-dcdc-1f8c5971b598"), 37, "Theodore Murray" },
                    { new Guid("d0d5c647-5795-3c4b-cbf3-6ab35a629904"), new Guid("724e0121-50dd-132d-2192-0c0ff1f707dc"), 25, "Henry Baumbach" },
                    { new Guid("6c95df28-5b01-d118-345d-b517abf4d1b8"), new Guid("724e0121-50dd-132d-2192-0c0ff1f707dc"), 27, "Marc Auer" },
                    { new Guid("97a5e3d3-0a1a-6147-bb9d-11f79c3c8e21"), new Guid("db8d403f-9e6c-f24c-8759-419636d7fa75"), 41, "Javier Kirlin" },
                    { new Guid("71cf3b53-a9e2-e821-9a09-e3471a16d108"), new Guid("db8d403f-9e6c-f24c-8759-419636d7fa75"), 62, "Wilma Funk" },
                    { new Guid("888e9978-b516-0d46-0335-5ba0e0b117b3"), new Guid("db8d403f-9e6c-f24c-8759-419636d7fa75"), 67, "Ruth Block" },
                    { new Guid("1f298ba4-79d1-beb3-b460-44f4cb935113"), new Guid("db8d403f-9e6c-f24c-8759-419636d7fa75"), 40, "Ken Bailey" },
                    { new Guid("1fbf0c7d-4d5e-fb6a-081b-187b643c75a7"), new Guid("db8d403f-9e6c-f24c-8759-419636d7fa75"), 60, "Daniel Kling" },
                    { new Guid("a444170e-c9f7-a767-871c-788385a0f7bb"), new Guid("a59e5a01-3627-0d6c-421b-201f3ddac69b"), 23, "Hugh Treutel" },
                    { new Guid("92c5c7c1-3962-4075-683a-06654a22e17a"), new Guid("91976174-a075-2c9d-5421-f0d3a6c50f86"), 43, "Lisa DuBuque" },
                    { new Guid("af3ddeaf-f3eb-854f-1a06-f4081cd328a4"), new Guid("91976174-a075-2c9d-5421-f0d3a6c50f86"), 61, "Don Klocko" },
                    { new Guid("88d05ffc-3deb-ff2a-65c3-ede76426013c"), new Guid("91976174-a075-2c9d-5421-f0d3a6c50f86"), 64, "Alton Schamberger" },
                    { new Guid("74535622-682c-92e0-f584-e757063c1f0d"), new Guid("91976174-a075-2c9d-5421-f0d3a6c50f86"), 52, "Marsha Swaniawski" },
                    { new Guid("d267a812-abd0-b01f-b142-44acfb654dbc"), new Guid("91976174-a075-2c9d-5421-f0d3a6c50f86"), 23, "Beulah Stehr" },
                    { new Guid("3922f048-471e-4fc1-19bc-1f4cd27cac65"), new Guid("9381cfc1-729f-1157-6727-9f4a2e2f11e6"), 43, "Shelley Rath" },
                    { new Guid("4ff0775b-1202-f6b2-e1b8-33220fe46fec"), new Guid("9381cfc1-729f-1157-6727-9f4a2e2f11e6"), 59, "Luis Crist" },
                    { new Guid("5c90eefd-3073-02ea-7e62-0586164c4062"), new Guid("a2b2b1a1-5928-f8ae-cbf5-9ae879644e31"), 38, "Patsy Barton" },
                    { new Guid("d82e84ce-97fa-f8e0-8823-e186e2d3e90d"), new Guid("a2b2b1a1-5928-f8ae-cbf5-9ae879644e31"), 55, "Leticia Stokes" },
                    { new Guid("9a86f5da-816a-aa4d-fa89-ff4dc6570f00"), new Guid("a2b2b1a1-5928-f8ae-cbf5-9ae879644e31"), 49, "Jenny Morar" },
                    { new Guid("fdee1529-c8d4-766e-faa6-38384e051d5f"), new Guid("eb6389b4-e2df-0eb4-604b-5aab771a9ddb"), 44, "Timmy West" },
                    { new Guid("3b5d5b22-5e03-b34a-8522-3b4db80a485f"), new Guid("eb6389b4-e2df-0eb4-604b-5aab771a9ddb"), 54, "Homer Lesch" },
                    { new Guid("72ff0943-7ab0-6128-632f-86478615394d"), new Guid("eb6389b4-e2df-0eb4-604b-5aab771a9ddb"), 24, "Ralph Kunde" },
                    { new Guid("ec8fb892-1fce-ae69-173c-553d075725e8"), new Guid("8243c599-1c1a-76e3-a229-633f2270620d"), 44, "Gustavo Feil" },
                    { new Guid("fa093154-fe6e-b36e-ce65-88274244af53"), new Guid("40ff49d6-51db-0a74-cd06-dd31da551897"), 33, "Shane McCullough" },
                    { new Guid("95fba5b8-117e-ccb1-9169-5202c7c072e0"), new Guid("4934ae52-7807-e943-5121-dbc0ca599c96"), 65, "Carol Von" },
                    { new Guid("8eb5cf78-334f-ac67-40b1-416534688780"), new Guid("72125c3b-f073-e1bb-9f76-035eff073867"), 39, "Hugh Cronin" },
                    { new Guid("8b10d801-218d-6f75-333c-bcda2f62aa5a"), new Guid("f372bbe0-3bf0-c700-ed61-9fbff71c8089"), 68, "Ollie McDermott" },
                    { new Guid("e041989c-182a-1f79-0a73-67b4e5345d05"), new Guid("f372bbe0-3bf0-c700-ed61-9fbff71c8089"), 35, "Noah Hegmann" },
                    { new Guid("7b3769e0-fe78-2333-cdcf-cefd7159f19a"), new Guid("8e4600ca-a906-8270-68c3-acd0d5be34d3"), 31, "Candice Dietrich" },
                    { new Guid("c9663694-7e9a-2383-f22d-4c888b1c39c8"), new Guid("8e4600ca-a906-8270-68c3-acd0d5be34d3"), 33, "Archie Friesen" },
                    { new Guid("ba0a13af-a15c-ae75-883a-0bffd9578cc8"), new Guid("8e4600ca-a906-8270-68c3-acd0d5be34d3"), 47, "Alfonso Feeney" },
                    { new Guid("8185c1a8-e11a-3aa2-b69e-6b1be9a3427a"), new Guid("8e4600ca-a906-8270-68c3-acd0d5be34d3"), 20, "Gilberto Crist" },
                    { new Guid("cb7766ae-c355-fc90-8f47-6f4439f1b1da"), new Guid("8e4600ca-a906-8270-68c3-acd0d5be34d3"), 35, "Inez Powlowski" },
                    { new Guid("43da4639-e4b4-fe23-b1d8-cdca07cb16fb"), new Guid("8e4600ca-a906-8270-68c3-acd0d5be34d3"), 22, "Ronald Hauck" },
                    { new Guid("b637178f-b6c7-79d9-3f98-123c57740767"), new Guid("8e4600ca-a906-8270-68c3-acd0d5be34d3"), 38, "Melinda Kuhn" },
                    { new Guid("99b8f8a4-fd16-e5f8-42b8-65810c0fff73"), new Guid("c069a70f-aa3e-3287-0ab6-44e85da60896"), 64, "Roderick Hermann" },
                    { new Guid("3476f12d-05b7-c258-4eee-062f4aaf7bc0"), new Guid("c069a70f-aa3e-3287-0ab6-44e85da60896"), 49, "Hattie Klocko" },
                    { new Guid("2a58f9a9-887b-86b7-1bf3-baa4f7212932"), new Guid("c069a70f-aa3e-3287-0ab6-44e85da60896"), 51, "Edwin Lemke" },
                    { new Guid("580a21b7-2818-e84d-ea85-643c016be069"), new Guid("c069a70f-aa3e-3287-0ab6-44e85da60896"), 32, "Hector Mante" },
                    { new Guid("d50efdc5-c407-5e6d-3bb8-0548e6b3534c"), new Guid("c069a70f-aa3e-3287-0ab6-44e85da60896"), 24, "Guadalupe Pfannerstill" },
                    { new Guid("e14db289-7264-681c-0b12-c1009134d9e5"), new Guid("c069a70f-aa3e-3287-0ab6-44e85da60896"), 36, "Darrin Bayer" },
                    { new Guid("9c0b6b03-a6ca-08fb-33e5-c69395f8f1a5"), new Guid("7ddf4877-f528-c711-44db-e74fb78c8f86"), 49, "Luz Borer" },
                    { new Guid("b04f3dfc-e118-8316-e415-95453a8e9aef"), new Guid("7ddf4877-f528-c711-44db-e74fb78c8f86"), 59, "Greg Shanahan" },
                    { new Guid("8a3f187b-1a26-f389-964d-a2c6cf8f4f29"), new Guid("f372bbe0-3bf0-c700-ed61-9fbff71c8089"), 41, "Roosevelt Kuhic" },
                    { new Guid("839db9af-fac4-ce13-0183-2f20e0184826"), new Guid("e6c627d7-2af5-ad44-565c-15ad4b377c92"), 44, "Dallas Pagac" },
                    { new Guid("9da905b6-b9a4-8a17-c1c4-c4b7bbe64042"), new Guid("e6c627d7-2af5-ad44-565c-15ad4b377c92"), 61, "Kathryn Mitchell" },
                    { new Guid("50f6957c-e83a-6021-4a7b-5f66a680f102"), new Guid("e6c627d7-2af5-ad44-565c-15ad4b377c92"), 41, "Lori Collins" },
                    { new Guid("ae2442b4-626b-a373-aecc-c2a4912fc8e2"), new Guid("1692a923-8f41-231d-22fe-c351b0262cb6"), 38, "Cindy Osinski" },
                    { new Guid("b9052b42-6167-f541-9dc4-ea2eaa7f50c3"), new Guid("1692a923-8f41-231d-22fe-c351b0262cb6"), 31, "Virgil Sporer" },
                    { new Guid("4140c0be-10a5-eb42-f86d-6251a92dfb13"), new Guid("1692a923-8f41-231d-22fe-c351b0262cb6"), 36, "Carl Torphy" },
                    { new Guid("ab26f7a5-b270-377c-5252-45d4cf717073"), new Guid("1692a923-8f41-231d-22fe-c351b0262cb6"), 66, "Pam Greenholt" },
                    { new Guid("8bf4e141-78bd-c309-6801-78c8d3bb420a"), new Guid("cb62316f-7802-1b4f-9f56-cce4b4c56a42"), 59, "Elbert Marvin" },
                    { new Guid("73b52d1b-b5b9-8199-0850-56662fb90ece"), new Guid("cb62316f-7802-1b4f-9f56-cce4b4c56a42"), 34, "Raquel Feil" },
                    { new Guid("c39a6000-d4c3-c375-a624-ea01c807d587"), new Guid("cb62316f-7802-1b4f-9f56-cce4b4c56a42"), 61, "Clifford Jacobson" },
                    { new Guid("5722ca46-fa5a-b9ca-22c0-3e5ffccc3666"), new Guid("e1c1d586-f889-97b9-2867-65b593554d8a"), 68, "Ross Rogahn" },
                    { new Guid("282f086d-ee94-977e-ab47-983c8ac79f4f"), new Guid("40ff49d6-51db-0a74-cd06-dd31da551897"), 44, "Erika Dickinson" },
                    { new Guid("6e249742-1ac6-8c4a-6a84-4fe1d4e74a45"), new Guid("e1c1d586-f889-97b9-2867-65b593554d8a"), 31, "Hector Hammes" },
                    { new Guid("5eadf71d-7291-e6bd-6d69-29d6351158b9"), new Guid("6aa79251-8689-cc4c-72b5-6c3ad7ac83b6"), 27, "Margie Lindgren" },
                    { new Guid("b81c19bb-f965-9340-e536-f1b741dca96b"), new Guid("b7d768b0-3a48-d7c0-11fa-9107ce25c2e9"), 63, "Benjamin Lockman" },
                    { new Guid("d41ef493-1d85-0fc3-9eda-10c5e43bace0"), new Guid("b7d768b0-3a48-d7c0-11fa-9107ce25c2e9"), 38, "Rosemary Kessler" },
                    { new Guid("5948d8fb-2310-ec5e-82c6-d4a6cf3bb235"), new Guid("a21d5135-63ae-f1cb-beb7-b2eae5b90a01"), 24, "Joann Klein" },
                    { new Guid("7584341d-8e81-e362-9e41-1c34de9e2eb4"), new Guid("a21d5135-63ae-f1cb-beb7-b2eae5b90a01"), 69, "Saul Walter" },
                    { new Guid("63d7d4a6-e11e-cfe4-5487-9d33d1c7c72d"), new Guid("e6c627d7-2af5-ad44-565c-15ad4b377c92"), 23, "Pam Brown" },
                    { new Guid("b4d3e9d7-7451-27d7-aaec-7a4daf2d217b"), new Guid("e6c627d7-2af5-ad44-565c-15ad4b377c92"), 34, "Paulette Labadie" },
                    { new Guid("1aa9aad4-d6b3-03fc-d491-7e0cade6b5d9"), new Guid("e6c627d7-2af5-ad44-565c-15ad4b377c92"), 22, "Phyllis Goyette" },
                    { new Guid("a08aec8b-da52-5ce8-daa8-9c6a1f4aa2ab"), new Guid("6aa79251-8689-cc4c-72b5-6c3ad7ac83b6"), 37, "Alexander Balistreri" },
                    { new Guid("0b934957-afa3-a261-0d4a-d92381899731"), new Guid("7ddf4877-f528-c711-44db-e74fb78c8f86"), 33, "Ashley Ziemann" },
                    { new Guid("50423e25-8633-f154-1599-67db13763f0d"), new Guid("7ddf4877-f528-c711-44db-e74fb78c8f86"), 24, "Fred Reichel" },
                    { new Guid("33f0e870-e1bf-d308-a38a-acdbf48daeb3"), new Guid("a55febc4-8586-52bf-abcb-f7af0996828d"), 44, "Jeanne Romaguera" },
                    { new Guid("bf4bf248-a2e6-da4a-c591-a0ee6e741d0c"), new Guid("a55febc4-8586-52bf-abcb-f7af0996828d"), 64, "Kerry Kerluke" },
                    { new Guid("7cea0f51-aa91-68fb-eb59-5cba50dcad16"), new Guid("fddbb79f-95fc-6dae-eb4a-f1d87198d61d"), 68, "Belinda Metz" },
                    { new Guid("4f50af03-fb25-0e02-02fd-4073df01a5a2"), new Guid("fddbb79f-95fc-6dae-eb4a-f1d87198d61d"), 26, "Oscar Renner" },
                    { new Guid("e112dcfb-52ef-4902-d221-69f64bd8215c"), new Guid("fddbb79f-95fc-6dae-eb4a-f1d87198d61d"), 56, "Al Marks" },
                    { new Guid("b7169929-6eb5-fd91-81eb-1c5dc3a32e9c"), new Guid("fddbb79f-95fc-6dae-eb4a-f1d87198d61d"), 40, "Geraldine Frami" },
                    { new Guid("6b154acf-06f0-3515-9df6-1d66db7dbd55"), new Guid("fddbb79f-95fc-6dae-eb4a-f1d87198d61d"), 34, "Harvey Torp" },
                    { new Guid("922dd9ff-842e-9c3e-8e60-27da7166b9ab"), new Guid("fddbb79f-95fc-6dae-eb4a-f1d87198d61d"), 61, "Douglas Brekke" },
                    { new Guid("8cd86c45-e9a7-7379-1a3c-816f52f5d10c"), new Guid("569a3b8f-bbf1-2384-4e34-503169870eae"), 35, "Ethel Grimes" },
                    { new Guid("a656517a-9f26-d53c-5f00-6ad3d682167a"), new Guid("76029197-52cb-dcab-844c-e6fb9e15be87"), 54, "Diana Rodriguez" },
                    { new Guid("4c7c90f1-9741-f7ae-7f5e-77b7e336860f"), new Guid("569a3b8f-bbf1-2384-4e34-503169870eae"), 59, "Kayla Ritchie" },
                    { new Guid("0d8f0b86-f704-50ce-77e3-030051179ad7"), new Guid("569a3b8f-bbf1-2384-4e34-503169870eae"), 38, "Stephen Collins" },
                    { new Guid("3c7a7b70-5bb1-ccf4-9848-21b32f77378b"), new Guid("ac680941-2c32-d80e-446b-c4e3c8df0119"), 48, "Benjamin Grimes" },
                    { new Guid("f9198401-49da-1c40-22f5-cd2f2369e227"), new Guid("ac680941-2c32-d80e-446b-c4e3c8df0119"), 68, "May Rolfson" },
                    { new Guid("087f3742-1883-51a8-3a77-977b9c268970"), new Guid("ac680941-2c32-d80e-446b-c4e3c8df0119"), 61, "Marion Kautzer" },
                    { new Guid("58b0d23f-8f14-3700-634d-c713710c4940"), new Guid("ac680941-2c32-d80e-446b-c4e3c8df0119"), 63, "Gloria White" },
                    { new Guid("79170613-ca29-39a7-801b-95a1d600002b"), new Guid("ac680941-2c32-d80e-446b-c4e3c8df0119"), 26, "Conrad Bernhard" },
                    { new Guid("eaebe05a-6dbd-579a-434d-5ad7b66822d3"), new Guid("72125c3b-f073-e1bb-9f76-035eff073867"), 29, "Lauren Mosciski" },
                    { new Guid("678168b8-60b9-73e1-19d7-c7659cccebe5"), new Guid("72125c3b-f073-e1bb-9f76-035eff073867"), 27, "Cecelia Murray" },
                    { new Guid("93c163d4-05d5-ee35-b1a0-7b5fcff043e7"), new Guid("569a3b8f-bbf1-2384-4e34-503169870eae"), 32, "May Hirthe" },
                    { new Guid("760bc1ca-74a8-978f-7e9a-0c3d1cdb9bc1"), new Guid("76029197-52cb-dcab-844c-e6fb9e15be87"), 25, "Bernadette Crist" },
                    { new Guid("4b804d43-4928-83a6-cfdd-84add23fb998"), new Guid("fddbb79f-95fc-6dae-eb4a-f1d87198d61d"), 24, "Noah Lindgren" },
                    { new Guid("bee1aff3-f322-c0dc-1c85-daa8a413d787"), new Guid("76029197-52cb-dcab-844c-e6fb9e15be87"), 29, "Johanna Sauer" },
                    { new Guid("01c8a695-8315-a40c-c246-23eb97b16b17"), new Guid("a55febc4-8586-52bf-abcb-f7af0996828d"), 61, "Alan Frami" },
                    { new Guid("faadf1f6-2a3e-9199-3476-63628986cd76"), new Guid("a314b3c0-35ec-480d-c8a2-360aab4a183e"), 26, "Laura Schmeler" },
                    { new Guid("d361019c-76bf-cbea-80e3-4dae05363eb2"), new Guid("bc6f8d53-25aa-0a79-2213-7a6443b12292"), 23, "Donnie Kuhlman" },
                    { new Guid("9fa1b1e1-c35f-0398-84cd-cf5ba224cf2f"), new Guid("bc6f8d53-25aa-0a79-2213-7a6443b12292"), 43, "Brittany Dare" },
                    { new Guid("fdc7a927-4e6e-1163-6860-e4e99b103889"), new Guid("bc6f8d53-25aa-0a79-2213-7a6443b12292"), 47, "Brad Bartoletti" },
                    { new Guid("20d4fca3-3512-205f-9b70-3b4b7f40a7a5"), new Guid("bc6f8d53-25aa-0a79-2213-7a6443b12292"), 48, "Yvette Hamill" },
                    { new Guid("398603ee-bfb3-44e0-139a-6929a6f64ca9"), new Guid("385d0737-d5b9-12e9-c61e-e2645f2f079c"), 32, "Emanuel Terry" },
                    { new Guid("657383e3-9722-2d28-450e-fc9ad0b87dde"), new Guid("76029197-52cb-dcab-844c-e6fb9e15be87"), 20, "Vernon Waelchi" },
                    { new Guid("814dede0-4de2-b689-fd15-7cada5fe5453"), new Guid("385d0737-d5b9-12e9-c61e-e2645f2f079c"), 32, "Ellen Schmidt" },
                    { new Guid("9e60b0fa-88d3-fdca-9d02-894b3d53946c"), new Guid("8be9f827-0421-c677-5455-0ec6d4cf3e24"), 46, "Shannon Wisozk" },
                    { new Guid("072b57eb-d369-5759-2447-5612e23ba4a2"), new Guid("385d0737-d5b9-12e9-c61e-e2645f2f079c"), 64, "Julio Effertz" },
                    { new Guid("b2b73cc2-b5ab-eb21-0197-8da4984b7b80"), new Guid("385d0737-d5b9-12e9-c61e-e2645f2f079c"), 65, "Valerie Kerluke" },
                    { new Guid("169ed15c-7096-51c2-0385-8f0e9caf6d5f"), new Guid("4a9b169d-5a0e-cd4b-a527-09446bfa1fe3"), 35, "Myra Morar" },
                    { new Guid("03579208-f3fd-1bc2-b727-11df173fbbc5"), new Guid("4a9b169d-5a0e-cd4b-a527-09446bfa1fe3"), 59, "Winston O'Kon" },
                    { new Guid("84bd1db0-1b17-5eca-a30f-465463e883a3"), new Guid("4a9b169d-5a0e-cd4b-a527-09446bfa1fe3"), 42, "Rachel Dooley" },
                    { new Guid("c230e225-63c9-8366-0c40-d408cb293bab"), new Guid("4a9b169d-5a0e-cd4b-a527-09446bfa1fe3"), 25, "Samantha Kiehn" },
                    { new Guid("205eddd8-63a5-2e20-4580-96875682f95e"), new Guid("4a9b169d-5a0e-cd4b-a527-09446bfa1fe3"), 52, "Ernesto Greenfelder" },
                    { new Guid("fa36ce16-f58f-0f17-73b3-7a757a17c7d8"), new Guid("4a9b169d-5a0e-cd4b-a527-09446bfa1fe3"), 44, "Brenda Witting" },
                    { new Guid("2cee7bf9-ceb2-f6bb-f311-5e127c581790"), new Guid("385d0737-d5b9-12e9-c61e-e2645f2f079c"), 25, "Ella Wyman" }
                });

            migrationBuilder.InsertData(
                table: "Universities",
                columns: new[] { "Id", "AddressId", "EstablishmentDate", "Name" },
                values: new object[,]
                {
                    { new Guid("88a31570-3356-da9d-895a-afefe9b729e6"), new Guid("b7d768b0-3a48-d7c0-11fa-9107ce25c2e9"), new DateTime(2022, 8, 8, 15, 24, 43, 924, DateTimeKind.Local).AddTicks(4306), "Murray - Lesch" },
                    { new Guid("57f40310-0083-eb5d-707f-96e0c239257e"), new Guid("40f6ceaf-2005-f654-b0dd-4f40df1fbb11"), new DateTime(2022, 11, 29, 8, 7, 24, 715, DateTimeKind.Local).AddTicks(5407), "Grimes Inc" },
                    { new Guid("4f2d1645-13d8-6acf-38c0-ace60fef8edd"), new Guid("f38e06d6-992b-1e8d-8136-d5918e086482"), new DateTime(2022, 7, 21, 23, 47, 51, 356, DateTimeKind.Local).AddTicks(3546), "Murphy and Sons" },
                    { new Guid("94eba7ca-3b16-e141-3980-b3736012af31"), new Guid("b6454d1b-2238-6d80-5b38-f950fe0c0307"), new DateTime(2022, 8, 29, 14, 31, 3, 121, DateTimeKind.Local).AddTicks(9782), "Harris, Gusikowski and Von" },
                    { new Guid("260e18db-037e-a768-86a4-a062e7384d6b"), new Guid("6aa79251-8689-cc4c-72b5-6c3ad7ac83b6"), new DateTime(2022, 3, 5, 6, 29, 33, 677, DateTimeKind.Local).AddTicks(3552), "Connelly LLC" }
                });

            migrationBuilder.InsertData(
                table: "StudySubjects",
                columns: new[] { "Id", "Name", "ProfessorId", "UniversityId" },
                values: new object[,]
                {
                    { new Guid("99efa5d7-4d3d-f4e4-7bd7-49be8e8051e9"), "Introductory Econometrics", new Guid("58d43316-0561-ab5f-7a01-cce4368cee30"), new Guid("88a31570-3356-da9d-895a-afefe9b729e6") },
                    { new Guid("f3a6d29d-a967-ebda-8855-2153328a692e"), "Introduction to Biological Anthropology", new Guid("d6c89ba6-cb65-3dda-c591-df47ecabd9aa"), new Guid("57f40310-0083-eb5d-707f-96e0c239257e") },
                    { new Guid("bfa9f4cb-1264-89af-c83f-a51e6fd2c469"), "American Literature", new Guid("20d4fca3-3512-205f-9b70-3b4b7f40a7a5"), new Guid("57f40310-0083-eb5d-707f-96e0c239257e") },
                    { new Guid("4a4236a0-d3bf-ee05-2281-f4f61a874a19"), "Human Ecology: Social and Cultural Dimensions", new Guid("92c5c7c1-3962-4075-683a-06654a22e17a"), new Guid("57f40310-0083-eb5d-707f-96e0c239257e") },
                    { new Guid("fa982cb5-676e-53db-ef32-92ea5ea09057"), "Introductory Macroeconomics", new Guid("0838b21d-d973-f654-6a9f-aec89ac59c10"), new Guid("57f40310-0083-eb5d-707f-96e0c239257e") },
                    { new Guid("1df665fd-a195-a390-3764-f735753702c8"), "Biological Diversity in Human Populations", new Guid("9553be24-4172-771a-3d81-8c0ddac81e58"), new Guid("57f40310-0083-eb5d-707f-96e0c239257e") },
                    { new Guid("b33ad938-12db-7911-d962-c5e5491e458b"), "BA Economics Subjects", new Guid("a0747cd0-2964-e25a-2b0c-088a31971127"), new Guid("57f40310-0083-eb5d-707f-96e0c239257e") },
                    { new Guid("6b47868e-0996-b4a9-8d3b-c2de15aca87b"), "Spatial Dimensions of Development", new Guid("cbd47658-945b-ac6e-7594-cb76d8e2e00d"), new Guid("4f2d1645-13d8-6acf-38c0-ace60fef8edd") },
                    { new Guid("605fa570-c233-7b70-6436-e5548bd0d448"), "Literary Criticism", new Guid("2d1f6744-4f14-a9d3-6da3-0cfd05ed4118"), new Guid("4f2d1645-13d8-6acf-38c0-ace60fef8edd") },
                    { new Guid("04e4da50-5577-1316-a1dc-73f82cb77568"), "Postcolonial Literature", new Guid("eaebe05a-6dbd-579a-434d-5ad7b66822d3"), new Guid("4f2d1645-13d8-6acf-38c0-ace60fef8edd") },
                    { new Guid("ad57d2f4-035d-359c-afa4-e41ded03b2e1"), "Mathematical Methods for Economics", new Guid("258edced-c4c2-976b-ad61-a29e6855f7cd"), new Guid("4f2d1645-13d8-6acf-38c0-ace60fef8edd") },
                    { new Guid("65b7fe9a-0d76-f4e3-c95e-9705a6cfad63"), "Cartographic Techniques", new Guid("a138e342-6efc-2117-d99e-67b5e694cf3d"), new Guid("57f40310-0083-eb5d-707f-96e0c239257e") },
                    { new Guid("4ebab688-70a1-7aa4-9895-e4dfd583c9f0"), "Traditional Kannada Grammar", new Guid("4140c0be-10a5-eb42-f86d-6251a92dfb13"), new Guid("4f2d1645-13d8-6acf-38c0-ace60fef8edd") },
                    { new Guid("3afee780-7fde-786f-e90c-1085a7d8c991"), "Environmental Geography", new Guid("0a0b91da-4ead-6498-7890-dea87509e885"), new Guid("88a31570-3356-da9d-895a-afefe9b729e6") },
                    { new Guid("4862a584-784b-fec1-3825-1fd8474618a3"), "Educational Psychology", new Guid("97a5e3d3-0a1a-6147-bb9d-11f79c3c8e21"), new Guid("94eba7ca-3b16-e141-3980-b3736012af31") },
                    { new Guid("e401e3e5-7d56-e92f-7f0a-f827e6bc6ad9"), "Human Ecology: Social and Cultural Dimensions", new Guid("d0d5c647-5795-3c4b-cbf3-6ab35a629904"), new Guid("94eba7ca-3b16-e141-3980-b3736012af31") },
                    { new Guid("74c85808-c3e6-6d46-823f-6c0d2787b03a"), "Guidance and Counselling", new Guid("6b154acf-06f0-3515-9df6-1d66db7dbd55"), new Guid("94eba7ca-3b16-e141-3980-b3736012af31") },
                    { new Guid("0eee0b2a-06af-6f97-5cec-b00c7cf2c2bc"), "Methods of Sociological Enquiry", new Guid("3489e534-59b7-44f4-5789-d5aa7a80293d"), new Guid("94eba7ca-3b16-e141-3980-b3736012af31") },
                    { new Guid("c9a9bea9-ee6d-587f-2b4d-57c335fdad93"), "British Romantic Literature", new Guid("33f0e870-e1bf-d308-a38a-acdbf48daeb3"), new Guid("94eba7ca-3b16-e141-3980-b3736012af31") },
                    { new Guid("5dbab613-4e22-6105-8f72-c656e92d13b2"), "BA Kannada Subjects", new Guid("6b154acf-06f0-3515-9df6-1d66db7dbd55"), new Guid("260e18db-037e-a768-86a4-a062e7384d6b") },
                    { new Guid("99684b08-2f15-dff0-8984-cbb862229ee3"), "Spatial Dimensions of Development", new Guid("d0d5c647-5795-3c4b-cbf3-6ab35a629904"), new Guid("260e18db-037e-a768-86a4-a062e7384d6b") },
                    { new Guid("0109470b-8d47-88e7-68ed-12c782011602"), "Anthropology of religion, politics & economy", new Guid("fa36ce16-f58f-0f17-73b3-7a757a17c7d8"), new Guid("260e18db-037e-a768-86a4-a062e7384d6b") },
                    { new Guid("5f3e1a3a-6d3a-53a4-768d-a0845a8bfb96"), "BA Anthropology Subjects", new Guid("b81c19bb-f965-9340-e536-f1b741dca96b"), new Guid("88a31570-3356-da9d-895a-afefe9b729e6") },
                    { new Guid("1ebbc2e0-5f20-e86b-8f53-ab7dfdf85228"), "Kannada Folk Literature", new Guid("471deb5b-97b1-2967-949f-15ea6e8e678e"), new Guid("88a31570-3356-da9d-895a-afefe9b729e6") },
                    { new Guid("b7a51989-d306-ff79-24e0-999142417a0b"), "Field Work", new Guid("4a5c50af-6676-32c6-f440-e0de2f7893bb"), new Guid("57f40310-0083-eb5d-707f-96e0c239257e") }
                });

            migrationBuilder.InsertData(
                table: "PersonsStudySubjects",
                columns: new[] { "StudentId", "SubjectId" },
                values: new object[,]
                {
                    { new Guid("72cd3096-64a5-c30c-894a-66cd07c446e8"), new Guid("99efa5d7-4d3d-f4e4-7bd7-49be8e8051e9") },
                    { new Guid("0d8f0b86-f704-50ce-77e3-030051179ad7"), new Guid("605fa570-c233-7b70-6436-e5548bd0d448") },
                    { new Guid("1fbf0c7d-4d5e-fb6a-081b-187b643c75a7"), new Guid("605fa570-c233-7b70-6436-e5548bd0d448") },
                    { new Guid("e3ce283c-24c3-30c1-7e60-8defc6a26ac1"), new Guid("6b47868e-0996-b4a9-8d3b-c2de15aca87b") },
                    { new Guid("6b1e1cf1-41cb-b9b0-5f72-3ea121b9bfcc"), new Guid("6b47868e-0996-b4a9-8d3b-c2de15aca87b") },
                    { new Guid("57c60047-488b-5972-f409-0bb975d716e7"), new Guid("6b47868e-0996-b4a9-8d3b-c2de15aca87b") },
                    { new Guid("bee1aff3-f322-c0dc-1c85-daa8a413d787"), new Guid("6b47868e-0996-b4a9-8d3b-c2de15aca87b") },
                    { new Guid("fdc7a927-4e6e-1163-6860-e4e99b103889"), new Guid("6b47868e-0996-b4a9-8d3b-c2de15aca87b") },
                    { new Guid("42037930-031f-868e-1a50-f460e2dc7954"), new Guid("6b47868e-0996-b4a9-8d3b-c2de15aca87b") },
                    { new Guid("b5f703bf-55ca-bf21-c622-bfc3f942009d"), new Guid("6b47868e-0996-b4a9-8d3b-c2de15aca87b") },
                    { new Guid("7584341d-8e81-e362-9e41-1c34de9e2eb4"), new Guid("605fa570-c233-7b70-6436-e5548bd0d448") },
                    { new Guid("d15d2f8d-6774-619c-706d-9da8fab9b59a"), new Guid("6b47868e-0996-b4a9-8d3b-c2de15aca87b") },
                    { new Guid("39f0254f-4d52-4d4c-2a34-faa809d2126c"), new Guid("6b47868e-0996-b4a9-8d3b-c2de15aca87b") },
                    { new Guid("98ebbb69-f5d9-5ade-14cf-eb538c42b14e"), new Guid("6b47868e-0996-b4a9-8d3b-c2de15aca87b") },
                    { new Guid("ae2442b4-626b-a373-aecc-c2a4912fc8e2"), new Guid("6b47868e-0996-b4a9-8d3b-c2de15aca87b") },
                    { new Guid("99664518-a47a-a1a5-3889-ecc2b246cc28"), new Guid("6b47868e-0996-b4a9-8d3b-c2de15aca87b") },
                    { new Guid("ff6df3c6-1aa2-6cf7-4816-791ce813c02f"), new Guid("b33ad938-12db-7911-d962-c5e5491e458b") },
                    { new Guid("578e302a-03a4-fa48-3bc5-d14abb332fbc"), new Guid("b33ad938-12db-7911-d962-c5e5491e458b") },
                    { new Guid("914878d0-2dc7-fddd-e716-7d3cfe7a6584"), new Guid("b33ad938-12db-7911-d962-c5e5491e458b") },
                    { new Guid("92285dfa-f21c-3951-340d-cc403eb9133f"), new Guid("b33ad938-12db-7911-d962-c5e5491e458b") },
                    { new Guid("c2b46550-3c43-ea85-83f6-5f87cadedd4f"), new Guid("b33ad938-12db-7911-d962-c5e5491e458b") },
                    { new Guid("b1e062b8-e5ce-2c2a-5ae1-5ca16499216b"), new Guid("6b47868e-0996-b4a9-8d3b-c2de15aca87b") },
                    { new Guid("6903b5da-4a3a-3c58-220f-635c5c8f5493"), new Guid("605fa570-c233-7b70-6436-e5548bd0d448") },
                    { new Guid("0fdfb4af-36c1-f984-4f99-6019530686c9"), new Guid("605fa570-c233-7b70-6436-e5548bd0d448") },
                    { new Guid("11c965eb-2a58-643f-678c-8b63238bac20"), new Guid("605fa570-c233-7b70-6436-e5548bd0d448") },
                    { new Guid("80bf46cc-2043-89ab-da06-7c33529ac72f"), new Guid("ad57d2f4-035d-359c-afa4-e41ded03b2e1") },
                    { new Guid("22344500-14e1-698b-2387-84b352497452"), new Guid("ad57d2f4-035d-359c-afa4-e41ded03b2e1") },
                    { new Guid("26b7a2dd-4903-ed3d-9f48-53638662fa19"), new Guid("ad57d2f4-035d-359c-afa4-e41ded03b2e1") },
                    { new Guid("2b541bff-10c2-b279-1100-248ce8055b9a"), new Guid("ad57d2f4-035d-359c-afa4-e41ded03b2e1") },
                    { new Guid("5d256276-91b8-f8a3-7616-609c32c7c00f"), new Guid("ad57d2f4-035d-359c-afa4-e41ded03b2e1") },
                    { new Guid("c877fa5c-b17c-1a5a-74d3-e726b232b3cd"), new Guid("ad57d2f4-035d-359c-afa4-e41ded03b2e1") },
                    { new Guid("efed4dad-cb47-109c-71b4-2d19b5ed768d"), new Guid("ad57d2f4-035d-359c-afa4-e41ded03b2e1") },
                    { new Guid("8c212b3d-63c1-77e8-7ac6-76cc4aa6b2b7"), new Guid("ad57d2f4-035d-359c-afa4-e41ded03b2e1") },
                    { new Guid("35c255ea-76b9-5cb8-cf45-79698da9e361"), new Guid("ad57d2f4-035d-359c-afa4-e41ded03b2e1") },
                    { new Guid("e703f4b3-a667-c43c-0f03-739c76618796"), new Guid("04e4da50-5577-1316-a1dc-73f82cb77568") },
                    { new Guid("bf4bf248-a2e6-da4a-c591-a0ee6e741d0c"), new Guid("04e4da50-5577-1316-a1dc-73f82cb77568") },
                    { new Guid("087f3742-1883-51a8-3a77-977b9c268970"), new Guid("04e4da50-5577-1316-a1dc-73f82cb77568") },
                    { new Guid("657383e3-9722-2d28-450e-fc9ad0b87dde"), new Guid("04e4da50-5577-1316-a1dc-73f82cb77568") },
                    { new Guid("75dc147d-8cb1-219c-8fa0-5e15a8fa850f"), new Guid("04e4da50-5577-1316-a1dc-73f82cb77568") },
                    { new Guid("d220b046-0e8c-96a6-1fd1-9bdddc5a31db"), new Guid("04e4da50-5577-1316-a1dc-73f82cb77568") },
                    { new Guid("171764c1-1eca-ebc6-4f32-6b0f2f500668"), new Guid("605fa570-c233-7b70-6436-e5548bd0d448") },
                    { new Guid("b1f45667-03b5-1141-5f1b-1f8296424b44"), new Guid("605fa570-c233-7b70-6436-e5548bd0d448") },
                    { new Guid("5c90eefd-3073-02ea-7e62-0586164c4062"), new Guid("605fa570-c233-7b70-6436-e5548bd0d448") },
                    { new Guid("cda99cb9-254d-91ce-9d9c-e0e1a2d0806f"), new Guid("605fa570-c233-7b70-6436-e5548bd0d448") },
                    { new Guid("05257d60-ef9e-9abf-8045-6a678974c6cf"), new Guid("605fa570-c233-7b70-6436-e5548bd0d448") },
                    { new Guid("e2fd194f-8dc8-25aa-a242-fc6bb19be719"), new Guid("605fa570-c233-7b70-6436-e5548bd0d448") },
                    { new Guid("635b4c07-479a-1a69-608f-0726b4f13eb7"), new Guid("b33ad938-12db-7911-d962-c5e5491e458b") },
                    { new Guid("ba0a13af-a15c-ae75-883a-0bffd9578cc8"), new Guid("b33ad938-12db-7911-d962-c5e5491e458b") },
                    { new Guid("c8b6392b-9d16-bd13-3ff3-be5a388d0da6"), new Guid("b33ad938-12db-7911-d962-c5e5491e458b") },
                    { new Guid("b637178f-b6c7-79d9-3f98-123c57740767"), new Guid("b33ad938-12db-7911-d962-c5e5491e458b") },
                    { new Guid("6b1e1cf1-41cb-b9b0-5f72-3ea121b9bfcc"), new Guid("bfa9f4cb-1264-89af-c83f-a51e6fd2c469") },
                    { new Guid("cd5afc59-99dc-80b5-c431-6c64bf1b1676"), new Guid("bfa9f4cb-1264-89af-c83f-a51e6fd2c469") },
                    { new Guid("789ba0b8-c88b-eed3-25c0-353616f77c27"), new Guid("bfa9f4cb-1264-89af-c83f-a51e6fd2c469") },
                    { new Guid("2ee3f52e-0467-bde0-26ad-d0a0ad7054f7"), new Guid("bfa9f4cb-1264-89af-c83f-a51e6fd2c469") },
                    { new Guid("e0bb938c-c81c-6de0-f8a2-b475d3cdfa81"), new Guid("bfa9f4cb-1264-89af-c83f-a51e6fd2c469") },
                    { new Guid("d15d2f8d-6774-619c-706d-9da8fab9b59a"), new Guid("f3a6d29d-a967-ebda-8855-2153328a692e") },
                    { new Guid("cd5afc59-99dc-80b5-c431-6c64bf1b1676"), new Guid("f3a6d29d-a967-ebda-8855-2153328a692e") },
                    { new Guid("3890624b-d6c5-43f1-f42c-53840849eac9"), new Guid("f3a6d29d-a967-ebda-8855-2153328a692e") },
                    { new Guid("7881eef1-4fda-65c2-a760-daeccee0d29f"), new Guid("f3a6d29d-a967-ebda-8855-2153328a692e") },
                    { new Guid("ff04bd04-816d-2bce-243b-352d2864513c"), new Guid("65b7fe9a-0d76-f4e3-c95e-9705a6cfad63") },
                    { new Guid("153d939d-9fc0-33eb-8acf-c199759390dc"), new Guid("65b7fe9a-0d76-f4e3-c95e-9705a6cfad63") },
                    { new Guid("efed4dad-cb47-109c-71b4-2d19b5ed768d"), new Guid("65b7fe9a-0d76-f4e3-c95e-9705a6cfad63") },
                    { new Guid("b637178f-b6c7-79d9-3f98-123c57740767"), new Guid("65b7fe9a-0d76-f4e3-c95e-9705a6cfad63") },
                    { new Guid("fa9270b5-7883-c7b2-b471-9e40d99e430e"), new Guid("65b7fe9a-0d76-f4e3-c95e-9705a6cfad63") },
                    { new Guid("fdb625a1-413d-f9ae-e0cb-d1d13c099808"), new Guid("65b7fe9a-0d76-f4e3-c95e-9705a6cfad63") },
                    { new Guid("205eddd8-63a5-2e20-4580-96875682f95e"), new Guid("65b7fe9a-0d76-f4e3-c95e-9705a6cfad63") },
                    { new Guid("8207d629-4763-bce3-d96f-d990297880b3"), new Guid("b7a51989-d306-ff79-24e0-999142417a0b") },
                    { new Guid("98f1fd09-e491-513c-7122-01a2fd694459"), new Guid("b7a51989-d306-ff79-24e0-999142417a0b") },
                    { new Guid("dc0bf655-565d-c063-ec58-cc86b1620fe0"), new Guid("b7a51989-d306-ff79-24e0-999142417a0b") },
                    { new Guid("b4d3e9d7-7451-27d7-aaec-7a4daf2d217b"), new Guid("b7a51989-d306-ff79-24e0-999142417a0b") },
                    { new Guid("ba351d16-1852-43a8-4b16-fac5ad7b9a06"), new Guid("b7a51989-d306-ff79-24e0-999142417a0b") },
                    { new Guid("2ef51218-2fa2-fc9f-5ba0-defe0da7df4d"), new Guid("bfa9f4cb-1264-89af-c83f-a51e6fd2c469") },
                    { new Guid("2ef51218-2fa2-fc9f-5ba0-defe0da7df4d"), new Guid("4ebab688-70a1-7aa4-9895-e4dfd583c9f0") },
                    { new Guid("da5527e0-e3d3-1648-c477-fba61204ac2f"), new Guid("bfa9f4cb-1264-89af-c83f-a51e6fd2c469") },
                    { new Guid("99664518-a47a-a1a5-3889-ecc2b246cc28"), new Guid("bfa9f4cb-1264-89af-c83f-a51e6fd2c469") },
                    { new Guid("f16c94f9-4b07-2a1e-bf61-cf7496034a31"), new Guid("b33ad938-12db-7911-d962-c5e5491e458b") },
                    { new Guid("a444170e-c9f7-a767-871c-788385a0f7bb"), new Guid("1df665fd-a195-a390-3764-f735753702c8") },
                    { new Guid("4e45e7ec-97e4-5714-2d34-4f0d9ad8e654"), new Guid("1df665fd-a195-a390-3764-f735753702c8") },
                    { new Guid("2b541bff-10c2-b279-1100-248ce8055b9a"), new Guid("1df665fd-a195-a390-3764-f735753702c8") },
                    { new Guid("ff6df3c6-1aa2-6cf7-4816-791ce813c02f"), new Guid("1df665fd-a195-a390-3764-f735753702c8") },
                    { new Guid("7f07a411-3d4d-da40-c2e2-98397f58996a"), new Guid("fa982cb5-676e-53db-ef32-92ea5ea09057") },
                    { new Guid("3c7a7b70-5bb1-ccf4-9848-21b32f77378b"), new Guid("fa982cb5-676e-53db-ef32-92ea5ea09057") },
                    { new Guid("cdc773eb-b471-25b0-98d0-0b53f6fcc396"), new Guid("fa982cb5-676e-53db-ef32-92ea5ea09057") },
                    { new Guid("a138e342-6efc-2117-d99e-67b5e694cf3d"), new Guid("fa982cb5-676e-53db-ef32-92ea5ea09057") },
                    { new Guid("580a21b7-2818-e84d-ea85-643c016be069"), new Guid("fa982cb5-676e-53db-ef32-92ea5ea09057") },
                    { new Guid("261e391d-e2be-e2e1-fb3a-56b3cd2fae1d"), new Guid("fa982cb5-676e-53db-ef32-92ea5ea09057") },
                    { new Guid("e0bb938c-c81c-6de0-f8a2-b475d3cdfa81"), new Guid("fa982cb5-676e-53db-ef32-92ea5ea09057") },
                    { new Guid("99b8f8a4-fd16-e5f8-42b8-65810c0fff73"), new Guid("fa982cb5-676e-53db-ef32-92ea5ea09057") },
                    { new Guid("03e6aca1-3a22-b536-2b98-1c255dfe1e78"), new Guid("fa982cb5-676e-53db-ef32-92ea5ea09057") },
                    { new Guid("e43d82b4-ab7f-1ad7-f50b-d39e4dd0e429"), new Guid("4a4236a0-d3bf-ee05-2281-f4f61a874a19") },
                    { new Guid("e0bb6aa6-572a-ecad-3946-bfc55cedf874"), new Guid("4a4236a0-d3bf-ee05-2281-f4f61a874a19") },
                    { new Guid("eff78a89-914f-4c56-840d-d44956d025a9"), new Guid("4a4236a0-d3bf-ee05-2281-f4f61a874a19") },
                    { new Guid("814dede0-4de2-b689-fd15-7cada5fe5453"), new Guid("4a4236a0-d3bf-ee05-2281-f4f61a874a19") },
                    { new Guid("2ee3f52e-0467-bde0-26ad-d0a0ad7054f7"), new Guid("4a4236a0-d3bf-ee05-2281-f4f61a874a19") },
                    { new Guid("57c60047-488b-5972-f409-0bb975d716e7"), new Guid("4a4236a0-d3bf-ee05-2281-f4f61a874a19") },
                    { new Guid("96d49fbe-5232-e39c-34c9-12956f7a81a2"), new Guid("bfa9f4cb-1264-89af-c83f-a51e6fd2c469") },
                    { new Guid("4a5c50af-6676-32c6-f440-e0de2f7893bb"), new Guid("bfa9f4cb-1264-89af-c83f-a51e6fd2c469") },
                    { new Guid("73b52d1b-b5b9-8199-0850-56662fb90ece"), new Guid("b7a51989-d306-ff79-24e0-999142417a0b") },
                    { new Guid("d50efdc5-c407-5e6d-3bb8-0548e6b3534c"), new Guid("4ebab688-70a1-7aa4-9895-e4dfd583c9f0") },
                    { new Guid("35c255ea-76b9-5cb8-cf45-79698da9e361"), new Guid("4ebab688-70a1-7aa4-9895-e4dfd583c9f0") },
                    { new Guid("878cc5d4-2b29-1e98-3378-006903e70346"), new Guid("5dbab613-4e22-6105-8f72-c656e92d13b2") },
                    { new Guid("6b154acf-06f0-3515-9df6-1d66db7dbd55"), new Guid("5dbab613-4e22-6105-8f72-c656e92d13b2") },
                    { new Guid("2ee3f52e-0467-bde0-26ad-d0a0ad7054f7"), new Guid("5dbab613-4e22-6105-8f72-c656e92d13b2") },
                    { new Guid("995f58e8-4fc4-c8c9-b892-7ddc07fd90dd"), new Guid("5dbab613-4e22-6105-8f72-c656e92d13b2") },
                    { new Guid("c2b46550-3c43-ea85-83f6-5f87cadedd4f"), new Guid("5dbab613-4e22-6105-8f72-c656e92d13b2") },
                    { new Guid("b7169929-6eb5-fd91-81eb-1c5dc3a32e9c"), new Guid("5dbab613-4e22-6105-8f72-c656e92d13b2") },
                    { new Guid("f6180ab4-051a-e1d9-c886-24206aee08f2"), new Guid("c9a9bea9-ee6d-587f-2b4d-57c335fdad93") },
                    { new Guid("c39a6000-d4c3-c375-a624-ea01c807d587"), new Guid("c9a9bea9-ee6d-587f-2b4d-57c335fdad93") },
                    { new Guid("eaebe05a-6dbd-579a-434d-5ad7b66822d3"), new Guid("c9a9bea9-ee6d-587f-2b4d-57c335fdad93") },
                    { new Guid("471deb5b-97b1-2967-949f-15ea6e8e678e"), new Guid("5dbab613-4e22-6105-8f72-c656e92d13b2") },
                    { new Guid("63d7d4a6-e11e-cfe4-5487-9d33d1c7c72d"), new Guid("c9a9bea9-ee6d-587f-2b4d-57c335fdad93") },
                    { new Guid("6e249742-1ac6-8c4a-6a84-4fe1d4e74a45"), new Guid("c9a9bea9-ee6d-587f-2b4d-57c335fdad93") },
                    { new Guid("a0747cd0-2964-e25a-2b0c-088a31971127"), new Guid("0eee0b2a-06af-6f97-5cec-b00c7cf2c2bc") },
                    { new Guid("e14db289-7264-681c-0b12-c1009134d9e5"), new Guid("0eee0b2a-06af-6f97-5cec-b00c7cf2c2bc") },
                    { new Guid("e4158f6a-cb4d-3211-a807-0cd9a65f2e32"), new Guid("0eee0b2a-06af-6f97-5cec-b00c7cf2c2bc") },
                    { new Guid("5489e5af-dc3d-4819-afe7-008395f1001e"), new Guid("0eee0b2a-06af-6f97-5cec-b00c7cf2c2bc") },
                    { new Guid("e1499051-79d5-9488-fa57-3c7ad804edf2"), new Guid("0eee0b2a-06af-6f97-5cec-b00c7cf2c2bc") },
                    { new Guid("cfeb6d91-ba80-b81c-7fc6-fd52351726ab"), new Guid("0eee0b2a-06af-6f97-5cec-b00c7cf2c2bc") },
                    { new Guid("789ba0b8-c88b-eed3-25c0-353616f77c27"), new Guid("0eee0b2a-06af-6f97-5cec-b00c7cf2c2bc") },
                    { new Guid("914878d0-2dc7-fddd-e716-7d3cfe7a6584"), new Guid("0eee0b2a-06af-6f97-5cec-b00c7cf2c2bc") },
                    { new Guid("8972d043-a8ce-dc90-2c9e-ef015b8efe08"), new Guid("c9a9bea9-ee6d-587f-2b4d-57c335fdad93") },
                    { new Guid("398603ee-bfb3-44e0-139a-6929a6f64ca9"), new Guid("5dbab613-4e22-6105-8f72-c656e92d13b2") },
                    { new Guid("a2558ac8-364b-e4a5-a993-9a247c43d95c"), new Guid("5dbab613-4e22-6105-8f72-c656e92d13b2") },
                    { new Guid("6213c500-0683-59ae-a272-9332829eba75"), new Guid("99684b08-2f15-dff0-8984-cbb862229ee3") },
                    { new Guid("760bc1ca-74a8-978f-7e9a-0c3d1cdb9bc1"), new Guid("99efa5d7-4d3d-f4e4-7bd7-49be8e8051e9") },
                    { new Guid("e4158f6a-cb4d-3211-a807-0cd9a65f2e32"), new Guid("99efa5d7-4d3d-f4e4-7bd7-49be8e8051e9") },
                    { new Guid("d504fae7-fc50-e57b-1131-3438086cf4f6"), new Guid("99efa5d7-4d3d-f4e4-7bd7-49be8e8051e9") },
                    { new Guid("2782ad9c-feea-b293-8514-22e5f3903c5f"), new Guid("99efa5d7-4d3d-f4e4-7bd7-49be8e8051e9") },
                    { new Guid("72cd3096-64a5-c30c-894a-66cd07c446e8"), new Guid("5f3e1a3a-6d3a-53a4-768d-a0845a8bfb96") },
                    { new Guid("e4158f6a-cb4d-3211-a807-0cd9a65f2e32"), new Guid("5f3e1a3a-6d3a-53a4-768d-a0845a8bfb96") },
                    { new Guid("601b6fe7-34d3-7a4a-eee8-8daa20bc4223"), new Guid("5f3e1a3a-6d3a-53a4-768d-a0845a8bfb96") },
                    { new Guid("4140c0be-10a5-eb42-f86d-6251a92dfb13"), new Guid("5f3e1a3a-6d3a-53a4-768d-a0845a8bfb96") },
                    { new Guid("5cccfc8f-b67a-553a-bc77-5b008b3d28fa"), new Guid("5f3e1a3a-6d3a-53a4-768d-a0845a8bfb96") },
                    { new Guid("79170613-ca29-39a7-801b-95a1d600002b"), new Guid("0109470b-8d47-88e7-68ed-12c782011602") },
                    { new Guid("57c60047-488b-5972-f409-0bb975d716e7"), new Guid("0109470b-8d47-88e7-68ed-12c782011602") },
                    { new Guid("4ca3b01c-2ebf-2798-ce6c-c0dc422b5f68"), new Guid("0109470b-8d47-88e7-68ed-12c782011602") },
                    { new Guid("a2558ac8-364b-e4a5-a993-9a247c43d95c"), new Guid("0109470b-8d47-88e7-68ed-12c782011602") },
                    { new Guid("26b7a2dd-4903-ed3d-9f48-53638662fa19"), new Guid("0109470b-8d47-88e7-68ed-12c782011602") },
                    { new Guid("5d87ddb7-c738-e08c-a6fd-41e008d6681a"), new Guid("0109470b-8d47-88e7-68ed-12c782011602") },
                    { new Guid("fdebfba6-d9bb-4e04-be72-31a640a8dceb"), new Guid("0109470b-8d47-88e7-68ed-12c782011602") },
                    { new Guid("80bf46cc-2043-89ab-da06-7c33529ac72f"), new Guid("0109470b-8d47-88e7-68ed-12c782011602") },
                    { new Guid("8aa1f68f-9152-c7b6-a21a-722fd834753e"), new Guid("99684b08-2f15-dff0-8984-cbb862229ee3") },
                    { new Guid("153d939d-9fc0-33eb-8acf-c199759390dc"), new Guid("99684b08-2f15-dff0-8984-cbb862229ee3") },
                    { new Guid("b234226e-a0e6-7921-e733-7a13ef38aa6c"), new Guid("99684b08-2f15-dff0-8984-cbb862229ee3") },
                    { new Guid("b5f703bf-55ca-bf21-c622-bfc3f942009d"), new Guid("99684b08-2f15-dff0-8984-cbb862229ee3") },
                    { new Guid("153d939d-9fc0-33eb-8acf-c199759390dc"), new Guid("74c85808-c3e6-6d46-823f-6c0d2787b03a") },
                    { new Guid("42b4aab8-eee5-315e-266b-e6f668e4120c"), new Guid("74c85808-c3e6-6d46-823f-6c0d2787b03a") },
                    { new Guid("7d922ca9-6d4d-9a13-7fc1-fd2965782412"), new Guid("74c85808-c3e6-6d46-823f-6c0d2787b03a") },
                    { new Guid("577cef87-4929-41ea-60fe-b74d2ab5a0e5"), new Guid("74c85808-c3e6-6d46-823f-6c0d2787b03a") },
                    { new Guid("b81c19bb-f965-9340-e536-f1b741dca96b"), new Guid("3afee780-7fde-786f-e90c-1085a7d8c991") },
                    { new Guid("cbd47658-945b-ac6e-7594-cb76d8e2e00d"), new Guid("3afee780-7fde-786f-e90c-1085a7d8c991") },
                    { new Guid("2ee3f52e-0467-bde0-26ad-d0a0ad7054f7"), new Guid("3afee780-7fde-786f-e90c-1085a7d8c991") },
                    { new Guid("95fba5b8-117e-ccb1-9169-5202c7c072e0"), new Guid("3afee780-7fde-786f-e90c-1085a7d8c991") },
                    { new Guid("974a24a1-fa5c-42ab-7201-373dda21c6ae"), new Guid("3afee780-7fde-786f-e90c-1085a7d8c991") },
                    { new Guid("fd5f3019-71e3-b5fc-fdd2-81726410a929"), new Guid("3afee780-7fde-786f-e90c-1085a7d8c991") },
                    { new Guid("523781c6-bce5-5e9b-2372-535c62152cc1"), new Guid("1ebbc2e0-5f20-e86b-8f53-ab7dfdf85228") },
                    { new Guid("41312180-c2ee-b91f-007f-095ff7c6eed5"), new Guid("1ebbc2e0-5f20-e86b-8f53-ab7dfdf85228") },
                    { new Guid("7646ab53-6a43-5ad9-f072-76d87dd34ae9"), new Guid("1ebbc2e0-5f20-e86b-8f53-ab7dfdf85228") },
                    { new Guid("5daa1735-5fc6-3db2-828f-75edcc432e78"), new Guid("1ebbc2e0-5f20-e86b-8f53-ab7dfdf85228") },
                    { new Guid("a2558ac8-364b-e4a5-a993-9a247c43d95c"), new Guid("1ebbc2e0-5f20-e86b-8f53-ab7dfdf85228") },
                    { new Guid("2782ad9c-feea-b293-8514-22e5f3903c5f"), new Guid("1ebbc2e0-5f20-e86b-8f53-ab7dfdf85228") },
                    { new Guid("10ff5be3-ebd1-0a90-dc76-03a8e75794f0"), new Guid("1ebbc2e0-5f20-e86b-8f53-ab7dfdf85228") },
                    { new Guid("52cb3e54-8d2c-9a9c-f772-148d44d2ba41"), new Guid("1ebbc2e0-5f20-e86b-8f53-ab7dfdf85228") },
                    { new Guid("8942a7e5-15a8-305a-dd77-c61bd44f1537"), new Guid("1ebbc2e0-5f20-e86b-8f53-ab7dfdf85228") },
                    { new Guid("9f10afc4-799a-99d5-f799-e7ed11400435"), new Guid("1ebbc2e0-5f20-e86b-8f53-ab7dfdf85228") },
                    { new Guid("f7605d24-76bb-7e75-de6e-86e66168b47b"), new Guid("1ebbc2e0-5f20-e86b-8f53-ab7dfdf85228") },
                    { new Guid("5cccfc8f-b67a-553a-bc77-5b008b3d28fa"), new Guid("4ebab688-70a1-7aa4-9895-e4dfd583c9f0") },
                    { new Guid("b234226e-a0e6-7921-e733-7a13ef38aa6c"), new Guid("4ebab688-70a1-7aa4-9895-e4dfd583c9f0") },
                    { new Guid("0fdfb4af-36c1-f984-4f99-6019530686c9"), new Guid("4ebab688-70a1-7aa4-9895-e4dfd583c9f0") },
                    { new Guid("fdb625a1-413d-f9ae-e0cb-d1d13c099808"), new Guid("4ebab688-70a1-7aa4-9895-e4dfd583c9f0") },
                    { new Guid("8c65a0a7-9c74-a1e1-8502-ae2a7e5eb5fb"), new Guid("3afee780-7fde-786f-e90c-1085a7d8c991") },
                    { new Guid("bcc7d45a-47a3-540d-7993-af83a8220043"), new Guid("4ebab688-70a1-7aa4-9895-e4dfd583c9f0") },
                    { new Guid("981b3c2a-f654-424d-a875-6f19dec0e8a4"), new Guid("3afee780-7fde-786f-e90c-1085a7d8c991") },
                    { new Guid("e1499051-79d5-9488-fa57-3c7ad804edf2"), new Guid("3afee780-7fde-786f-e90c-1085a7d8c991") },
                    { new Guid("3f44859c-d028-d76e-d8e4-9b72c3de33a4"), new Guid("74c85808-c3e6-6d46-823f-6c0d2787b03a") },
                    { new Guid("93f3f7b8-43f1-f0c8-042f-a8fba6fa53cb"), new Guid("74c85808-c3e6-6d46-823f-6c0d2787b03a") },
                    { new Guid("05257d60-ef9e-9abf-8045-6a678974c6cf"), new Guid("74c85808-c3e6-6d46-823f-6c0d2787b03a") },
                    { new Guid("8942a7e5-15a8-305a-dd77-c61bd44f1537"), new Guid("74c85808-c3e6-6d46-823f-6c0d2787b03a") },
                    { new Guid("8d367ad8-3425-416b-d512-74eaa0a9c5d0"), new Guid("74c85808-c3e6-6d46-823f-6c0d2787b03a") },
                    { new Guid("8185c1a8-e11a-3aa2-b69e-6b1be9a3427a"), new Guid("e401e3e5-7d56-e92f-7f0a-f827e6bc6ad9") },
                    { new Guid("c39a6000-d4c3-c375-a624-ea01c807d587"), new Guid("e401e3e5-7d56-e92f-7f0a-f827e6bc6ad9") },
                    { new Guid("8c57d5d3-8650-fb1e-fd76-6d7c70db1963"), new Guid("e401e3e5-7d56-e92f-7f0a-f827e6bc6ad9") },
                    { new Guid("7646ab53-6a43-5ad9-f072-76d87dd34ae9"), new Guid("e401e3e5-7d56-e92f-7f0a-f827e6bc6ad9") },
                    { new Guid("c9663694-7e9a-2383-f22d-4c888b1c39c8"), new Guid("e401e3e5-7d56-e92f-7f0a-f827e6bc6ad9") },
                    { new Guid("0e3d8826-0775-8d40-4cc4-95fc42439892"), new Guid("4862a584-784b-fec1-3825-1fd8474618a3") },
                    { new Guid("bee1aff3-f322-c0dc-1c85-daa8a413d787"), new Guid("4862a584-784b-fec1-3825-1fd8474618a3") },
                    { new Guid("c21c927d-c994-116f-0975-ce6ef6e4200f"), new Guid("4862a584-784b-fec1-3825-1fd8474618a3") },
                    { new Guid("ab26f7a5-b270-377c-5252-45d4cf717073"), new Guid("4862a584-784b-fec1-3825-1fd8474618a3") },
                    { new Guid("b3226088-bc9a-0db9-e9ff-0611d2d1e885"), new Guid("4862a584-784b-fec1-3825-1fd8474618a3") },
                    { new Guid("2a58f9a9-887b-86b7-1bf3-baa4f7212932"), new Guid("4862a584-784b-fec1-3825-1fd8474618a3") },
                    { new Guid("74535622-682c-92e0-f584-e757063c1f0d"), new Guid("4862a584-784b-fec1-3825-1fd8474618a3") },
                    { new Guid("a444170e-c9f7-a767-871c-788385a0f7bb"), new Guid("4862a584-784b-fec1-3825-1fd8474618a3") },
                    { new Guid("01c8a695-8315-a40c-c246-23eb97b16b17"), new Guid("3afee780-7fde-786f-e90c-1085a7d8c991") },
                    { new Guid("0ec870e9-4275-9bb4-0963-2a74004494f3"), new Guid("3afee780-7fde-786f-e90c-1085a7d8c991") },
                    { new Guid("9a86f5da-816a-aa4d-fa89-ff4dc6570f00"), new Guid("3afee780-7fde-786f-e90c-1085a7d8c991") },
                    { new Guid("c1ea820d-06fc-fda6-26f4-535ff6445907"), new Guid("3afee780-7fde-786f-e90c-1085a7d8c991") },
                    { new Guid("e0bb6aa6-572a-ecad-3946-bfc55cedf874"), new Guid("b7a51989-d306-ff79-24e0-999142417a0b") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("203c00dc-6443-7f98-800b-889acc29550b"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("4edc314e-b723-ffc5-ad97-7bf72dca81a8"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("01e75e69-9fc2-5a3b-866a-3bdea47de707"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("03579208-f3fd-1bc2-b727-11df173fbbc5"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("05ae0867-edab-1516-859f-9fe29e1963b3"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("067c6d10-8ddc-4fd2-5061-fcb2ebb9c565"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("072b57eb-d369-5759-2447-5612e23ba4a2"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("0b30d53d-f4ea-40be-b658-da9d391b1c84"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("0b934957-afa3-a261-0d4a-d92381899731"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("0bb4b4ec-327f-ca9e-6e91-fa65c0c209bc"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("0cdd36fc-9837-1339-68d7-67949bad08ae"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("0deeeb68-0a65-43bd-d465-d197990ccc44"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("0df94e0a-7db9-103e-def8-268c1f2ff803"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("0e87e07c-f09f-dc6d-ef99-065c440d5e56"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("0f4bc2ed-6bd4-7b8d-0969-a4131a5d62c6"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("101734ff-e355-5e16-fc22-93560e045021"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("13c380a7-5504-d2f8-a0bc-44e4e6d7de6a"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("14bb9805-1dc4-396e-159f-0f099ab7850d"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("1593d445-eab7-47d4-491e-e877b18a30b1"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("169ed15c-7096-51c2-0385-8f0e9caf6d5f"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("1782a408-0f84-cd36-6361-43a6d3206a66"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("18260010-f0d4-7088-a1e9-d3f055a3b659"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("19401a6d-066d-a064-98e0-7447c3854741"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("1aa9aad4-d6b3-03fc-d491-7e0cade6b5d9"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("1b317623-71a8-f5d2-7dba-6ea52eea24ce"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("1c950e08-6e23-10af-c2dc-fd562629c149"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("1f298ba4-79d1-beb3-b460-44f4cb935113"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("239fead2-116c-a8c3-0fbc-bed5fd7a3085"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("24213ba9-2662-af89-b324-56db7ecd6428"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("245a78c9-6d37-ff3f-c4cf-00a6e1b047a1"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("2558013e-d068-5521-a94c-59032679740d"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("282f086d-ee94-977e-ab47-983c8ac79f4f"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("295d048b-e5a7-8275-937b-8c846f698b24"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("2a34007c-e3c0-a1e0-d769-da06679f5f88"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("2a3f4c78-2df2-2e1e-7692-67e7af1e8fcc"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("2a847ccb-f748-4580-5a07-ee3c55e13f3a"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("2c212257-1502-fd66-ba69-98c2d8d5bbf0"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("2ce1df9b-e540-b0f5-8df0-d431c424098e"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("2cee7bf9-ceb2-f6bb-f311-5e127c581790"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("31731833-36d9-7c2c-2e37-da059892bf29"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("321a86c3-bed0-0191-ffa5-29320f26c019"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("33478c7c-e0f3-85c6-2a5e-603de17a4222"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("3355a1d3-ef40-3eec-d634-46ac790bf864"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("33dc5c06-58de-f196-65eb-0829bf19accd"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("33e46022-5f32-cd15-fd3e-a2cd00a5b7fd"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("342ee9ed-3646-b426-38b4-df86b41eaf57"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("3476f12d-05b7-c258-4eee-062f4aaf7bc0"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("348f07be-992d-5e3c-f4e8-89a43dff1c70"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("3922f048-471e-4fc1-19bc-1f4cd27cac65"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("39c0a829-6e82-f5e5-7ddd-d9998db44518"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("3b5d5b22-5e03-b34a-8522-3b4db80a485f"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("3c0ea13a-9dfc-447c-59b0-dc6a72efeb6f"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("3c8d652c-84bf-cfb3-d0f9-bf7df7337d29"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("3e515d81-9f05-f214-a62b-3e1a09bc0e28"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("3fdd5941-89ae-bfde-97d6-b8050e61636b"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("40880f0d-a1e4-51e6-0f75-f1897fd4edb8"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("4113eebf-3374-c531-5627-1523930b6b8b"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("411b8957-0656-234d-58e0-da605a692d47"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("41a0430c-6b09-90b5-d232-764457e4b861"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("4258de66-96f7-7dd4-f1cb-9cc88b058585"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("425d539c-46ca-6f4d-34fc-ee6d739babc1"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("43da4639-e4b4-fe23-b1d8-cdca07cb16fb"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("475b913c-5b5c-8b04-4bd2-dfcc67e23635"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("4b804d43-4928-83a6-cfdd-84add23fb998"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("4c7c90f1-9741-f7ae-7f5e-77b7e336860f"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("4f50af03-fb25-0e02-02fd-4073df01a5a2"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("4fe28145-63a4-f594-1c8c-9ecde5f64141"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("4ff0775b-1202-f6b2-e1b8-33220fe46fec"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("50423e25-8633-f154-1599-67db13763f0d"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("50f6957c-e83a-6021-4a7b-5f66a680f102"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("51018f41-43b8-4287-a02c-210e891d7e0f"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("53193611-8a16-6a4b-b454-f110ec17e3ce"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("535bc65a-7afe-a866-0772-1ab1664e26dc"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("54301b0d-7916-1fa2-2950-ee03a697a7fb"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("5722ca46-fa5a-b9ca-22c0-3e5ffccc3666"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("5873334f-6e32-8f0a-f604-9668f164768b"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("58b0d23f-8f14-3700-634d-c713710c4940"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("5948d8fb-2310-ec5e-82c6-d4a6cf3bb235"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("5afd57b8-ea76-b91c-09f2-fa61be6e5f8d"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("5b633d2c-f1e1-6b3c-f248-af64e62bdd88"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("5e18d3fb-fbc6-6591-71e9-89662f9a29c8"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("5eadf71d-7291-e6bd-6d69-29d6351158b9"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("65d98d6e-6b55-fb6e-244f-f283674ca4d9"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("678168b8-60b9-73e1-19d7-c7659cccebe5"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("6a0b99fb-0878-ef9c-b15b-af9f019ac11d"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("6c95df28-5b01-d118-345d-b517abf4d1b8"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("712fd99a-7161-94fb-8819-d16084d9b741"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("71cf3b53-a9e2-e821-9a09-e3471a16d108"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("72ff0943-7ab0-6128-632f-86478615394d"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("73720723-85de-b7ee-4237-22dcdbf2faae"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("7404a7b6-db70-aa9f-e5ea-aee62ce056fd"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("7646d1f1-65a1-6660-05f7-d906063c7a18"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("78ea669f-b6ca-8de5-010d-3f1e7f679d78"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("7ac7a55b-e077-f2ca-256a-992b806018d3"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("7b3769e0-fe78-2333-cdcf-cefd7159f19a"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("7b7237b6-da5c-5f28-07f5-54950176bdaa"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("7cea0f51-aa91-68fb-eb59-5cba50dcad16"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("820a1307-4ec4-ae66-c390-2690ed7636df"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("822b667f-554b-825a-4d92-83e892e5233c"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("839db9af-fac4-ce13-0183-2f20e0184826"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("84bd1db0-1b17-5eca-a30f-465463e883a3"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("84e201fc-3101-51f5-acee-1e2b5f4ca3a9"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("86d6a52f-6528-fbfe-9c12-9da2010a605a"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("87343c94-ac24-b356-83ef-5208e52fe04e"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("8784acd7-2abe-2d04-b0ed-c9ac2369bcc7"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("888e9978-b516-0d46-0335-5ba0e0b117b3"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("88d05ffc-3deb-ff2a-65c3-ede76426013c"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("89b459b3-6912-27d3-8ad6-328330875e14"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("8a3f187b-1a26-f389-964d-a2c6cf8f4f29"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("8b10d801-218d-6f75-333c-bcda2f62aa5a"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("8bf4e141-78bd-c309-6801-78c8d3bb420a"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("8cd86c45-e9a7-7379-1a3c-816f52f5d10c"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("8d69268f-06ec-e854-b8c7-15985ddbeeac"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("8decf065-1c37-9faa-550e-70edda968bc4"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("8eb5cf78-334f-ac67-40b1-416534688780"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("8ecba3e0-7897-ff3d-84a9-0e74054e3bd1"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("8eda1f81-015f-af2d-7e4a-6eecf6fda0e8"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("91093ea1-a27f-f98b-3326-9d66ea5ad5e9"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("922dd9ff-842e-9c3e-8e60-27da7166b9ab"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("93c163d4-05d5-ee35-b1a0-7b5fcff043e7"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("946e2717-5328-e8bf-f702-3aa54c60bccf"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("94f5f4a0-2763-9289-09b2-b3326b7dbb86"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("965b0076-fce5-0afa-a816-660bbb62ff81"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("994f640c-6cdf-2cdf-c7fc-7f12b185b42e"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("9a83971b-9ad9-0525-56c2-4ea8a0d8a3b5"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("9b693e5d-69ef-190b-0041-535dbebd9f0c"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("9c0b6b03-a6ca-08fb-33e5-c69395f8f1a5"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("9da905b6-b9a4-8a17-c1c4-c4b7bbe64042"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("9dfdb4e6-4e13-6703-7a43-fc1bc16eadf3"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("9e60b0fa-88d3-fdca-9d02-894b3d53946c"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("9e9fc4e2-ce4f-326c-5c80-3e9f83192c5a"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("9fa1b1e1-c35f-0398-84cd-cf5ba224cf2f"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("a08aec8b-da52-5ce8-daa8-9c6a1f4aa2ab"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("a1e1d455-c951-42cf-acc0-835fae149b78"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("a530769f-a571-bb84-c061-b33ecade6f0d"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("a656517a-9f26-d53c-5f00-6ad3d682167a"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("aa380649-ba36-52c3-8d6b-a378f947a8f0"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("ac069af2-32c4-123c-a1dc-568523e34b76"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("af3ddeaf-f3eb-854f-1a06-f4081cd328a4"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("b04f3dfc-e118-8316-e415-95453a8e9aef"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("b153b2ef-a97d-201a-8f3b-353a4c5e668d"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("b2b73cc2-b5ab-eb21-0197-8da4984b7b80"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("b3c4facb-4215-a2a3-1b21-d8474c256b3a"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("b597af37-bc4c-44d7-072a-75e81cc8d91c"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("b5dad5cc-b74a-cf6f-eec6-98c2cc6654b6"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("b77f3476-7e4d-2b63-3f03-fdefd68de137"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("b9052b42-6167-f541-9dc4-ea2eaa7f50c3"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("c230e225-63c9-8366-0c40-d408cb293bab"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("c24586b8-adf0-be2b-4816-cf6abb7bf70c"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("c71fd2e4-d8bb-1da5-2c8b-2e58d8f3bf69"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("c7ab409b-3ea1-ebef-a82f-63d564c56730"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("cb7766ae-c355-fc90-8f47-6f4439f1b1da"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("d267a812-abd0-b01f-b142-44acfb654dbc"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("d35933d2-931d-f39b-8924-db34b7030549"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("d361019c-76bf-cbea-80e3-4dae05363eb2"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("d3965e2c-679c-74fa-fd86-f4f2d8a12b27"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("d41ef493-1d85-0fc3-9eda-10c5e43bace0"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("d6b6632f-6cca-59f5-d3af-2e687808e101"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("d7fa2873-0e14-d046-31ba-51ffde3a1f7d"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("d82e84ce-97fa-f8e0-8823-e186e2d3e90d"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("d8dd53f5-fb1b-a009-222d-6597fe8dcf57"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("d93cc535-2deb-83a1-1be7-b741d5f80fbe"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("da40dbd5-b78e-4fd9-27bb-8e2ab49c0954"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("dd1d0610-ad4c-017e-9dca-89cfdbcc72a7"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("e041989c-182a-1f79-0a73-67b4e5345d05"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("e053aafd-f807-4e69-fa86-1ec3358cf01e"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("e0a3ada6-1a21-e5dd-71e8-92e9c997ccb8"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("e112dcfb-52ef-4902-d221-69f64bd8215c"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("e59cfd0d-c83b-0767-9896-b37275074866"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("e78a6167-ead9-1549-c2af-2a6de062ac28"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("eb26121b-feee-2943-1980-6b05294cb797"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("ec8fb892-1fce-ae69-173c-553d075725e8"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("f74f3318-0ae7-7a7c-8ce0-500c608e9a41"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("f77f1d7b-692c-339d-227d-14880dd67f1b"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("f8064226-daf7-0448-e4a6-069c130d7bda"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("f9198401-49da-1c40-22f5-cd2f2369e227"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("f9291e63-cf4f-03b8-3c5b-656dbd6e7285"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("fa093154-fe6e-b36e-ce65-88274244af53"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("faadf1f6-2a3e-9199-3476-63628986cd76"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("fb239e1f-0520-7175-c622-e166b9bb73f8"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("fdee1529-c8d4-766e-faa6-38384e051d5f"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("fe6afccd-ed67-c07c-fce6-75eb831efffa"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("fea40ea2-6c2d-5f03-030d-3ce1081f4e9b"));

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("01c8a695-8315-a40c-c246-23eb97b16b17"), new Guid("3afee780-7fde-786f-e90c-1085a7d8c991") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("03e6aca1-3a22-b536-2b98-1c255dfe1e78"), new Guid("fa982cb5-676e-53db-ef32-92ea5ea09057") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("05257d60-ef9e-9abf-8045-6a678974c6cf"), new Guid("605fa570-c233-7b70-6436-e5548bd0d448") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("05257d60-ef9e-9abf-8045-6a678974c6cf"), new Guid("74c85808-c3e6-6d46-823f-6c0d2787b03a") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("087f3742-1883-51a8-3a77-977b9c268970"), new Guid("04e4da50-5577-1316-a1dc-73f82cb77568") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("0d8f0b86-f704-50ce-77e3-030051179ad7"), new Guid("605fa570-c233-7b70-6436-e5548bd0d448") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("0e3d8826-0775-8d40-4cc4-95fc42439892"), new Guid("4862a584-784b-fec1-3825-1fd8474618a3") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("0ec870e9-4275-9bb4-0963-2a74004494f3"), new Guid("3afee780-7fde-786f-e90c-1085a7d8c991") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("0fdfb4af-36c1-f984-4f99-6019530686c9"), new Guid("4ebab688-70a1-7aa4-9895-e4dfd583c9f0") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("0fdfb4af-36c1-f984-4f99-6019530686c9"), new Guid("605fa570-c233-7b70-6436-e5548bd0d448") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("10ff5be3-ebd1-0a90-dc76-03a8e75794f0"), new Guid("1ebbc2e0-5f20-e86b-8f53-ab7dfdf85228") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("11c965eb-2a58-643f-678c-8b63238bac20"), new Guid("605fa570-c233-7b70-6436-e5548bd0d448") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("153d939d-9fc0-33eb-8acf-c199759390dc"), new Guid("65b7fe9a-0d76-f4e3-c95e-9705a6cfad63") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("153d939d-9fc0-33eb-8acf-c199759390dc"), new Guid("74c85808-c3e6-6d46-823f-6c0d2787b03a") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("153d939d-9fc0-33eb-8acf-c199759390dc"), new Guid("99684b08-2f15-dff0-8984-cbb862229ee3") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("171764c1-1eca-ebc6-4f32-6b0f2f500668"), new Guid("605fa570-c233-7b70-6436-e5548bd0d448") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("1fbf0c7d-4d5e-fb6a-081b-187b643c75a7"), new Guid("605fa570-c233-7b70-6436-e5548bd0d448") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("205eddd8-63a5-2e20-4580-96875682f95e"), new Guid("65b7fe9a-0d76-f4e3-c95e-9705a6cfad63") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("22344500-14e1-698b-2387-84b352497452"), new Guid("ad57d2f4-035d-359c-afa4-e41ded03b2e1") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("261e391d-e2be-e2e1-fb3a-56b3cd2fae1d"), new Guid("fa982cb5-676e-53db-ef32-92ea5ea09057") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("26b7a2dd-4903-ed3d-9f48-53638662fa19"), new Guid("0109470b-8d47-88e7-68ed-12c782011602") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("26b7a2dd-4903-ed3d-9f48-53638662fa19"), new Guid("ad57d2f4-035d-359c-afa4-e41ded03b2e1") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("2782ad9c-feea-b293-8514-22e5f3903c5f"), new Guid("1ebbc2e0-5f20-e86b-8f53-ab7dfdf85228") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("2782ad9c-feea-b293-8514-22e5f3903c5f"), new Guid("99efa5d7-4d3d-f4e4-7bd7-49be8e8051e9") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("2a58f9a9-887b-86b7-1bf3-baa4f7212932"), new Guid("4862a584-784b-fec1-3825-1fd8474618a3") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("2b541bff-10c2-b279-1100-248ce8055b9a"), new Guid("1df665fd-a195-a390-3764-f735753702c8") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("2b541bff-10c2-b279-1100-248ce8055b9a"), new Guid("ad57d2f4-035d-359c-afa4-e41ded03b2e1") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("2ee3f52e-0467-bde0-26ad-d0a0ad7054f7"), new Guid("3afee780-7fde-786f-e90c-1085a7d8c991") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("2ee3f52e-0467-bde0-26ad-d0a0ad7054f7"), new Guid("4a4236a0-d3bf-ee05-2281-f4f61a874a19") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("2ee3f52e-0467-bde0-26ad-d0a0ad7054f7"), new Guid("5dbab613-4e22-6105-8f72-c656e92d13b2") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("2ee3f52e-0467-bde0-26ad-d0a0ad7054f7"), new Guid("bfa9f4cb-1264-89af-c83f-a51e6fd2c469") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("2ef51218-2fa2-fc9f-5ba0-defe0da7df4d"), new Guid("4ebab688-70a1-7aa4-9895-e4dfd583c9f0") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("2ef51218-2fa2-fc9f-5ba0-defe0da7df4d"), new Guid("bfa9f4cb-1264-89af-c83f-a51e6fd2c469") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("35c255ea-76b9-5cb8-cf45-79698da9e361"), new Guid("4ebab688-70a1-7aa4-9895-e4dfd583c9f0") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("35c255ea-76b9-5cb8-cf45-79698da9e361"), new Guid("ad57d2f4-035d-359c-afa4-e41ded03b2e1") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("3890624b-d6c5-43f1-f42c-53840849eac9"), new Guid("f3a6d29d-a967-ebda-8855-2153328a692e") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("398603ee-bfb3-44e0-139a-6929a6f64ca9"), new Guid("5dbab613-4e22-6105-8f72-c656e92d13b2") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("39f0254f-4d52-4d4c-2a34-faa809d2126c"), new Guid("6b47868e-0996-b4a9-8d3b-c2de15aca87b") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("3c7a7b70-5bb1-ccf4-9848-21b32f77378b"), new Guid("fa982cb5-676e-53db-ef32-92ea5ea09057") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("3f44859c-d028-d76e-d8e4-9b72c3de33a4"), new Guid("74c85808-c3e6-6d46-823f-6c0d2787b03a") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("41312180-c2ee-b91f-007f-095ff7c6eed5"), new Guid("1ebbc2e0-5f20-e86b-8f53-ab7dfdf85228") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("4140c0be-10a5-eb42-f86d-6251a92dfb13"), new Guid("5f3e1a3a-6d3a-53a4-768d-a0845a8bfb96") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("42037930-031f-868e-1a50-f460e2dc7954"), new Guid("6b47868e-0996-b4a9-8d3b-c2de15aca87b") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("42b4aab8-eee5-315e-266b-e6f668e4120c"), new Guid("74c85808-c3e6-6d46-823f-6c0d2787b03a") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("471deb5b-97b1-2967-949f-15ea6e8e678e"), new Guid("5dbab613-4e22-6105-8f72-c656e92d13b2") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("4a5c50af-6676-32c6-f440-e0de2f7893bb"), new Guid("bfa9f4cb-1264-89af-c83f-a51e6fd2c469") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("4ca3b01c-2ebf-2798-ce6c-c0dc422b5f68"), new Guid("0109470b-8d47-88e7-68ed-12c782011602") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("4e45e7ec-97e4-5714-2d34-4f0d9ad8e654"), new Guid("1df665fd-a195-a390-3764-f735753702c8") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("523781c6-bce5-5e9b-2372-535c62152cc1"), new Guid("1ebbc2e0-5f20-e86b-8f53-ab7dfdf85228") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("52cb3e54-8d2c-9a9c-f772-148d44d2ba41"), new Guid("1ebbc2e0-5f20-e86b-8f53-ab7dfdf85228") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("5489e5af-dc3d-4819-afe7-008395f1001e"), new Guid("0eee0b2a-06af-6f97-5cec-b00c7cf2c2bc") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("577cef87-4929-41ea-60fe-b74d2ab5a0e5"), new Guid("74c85808-c3e6-6d46-823f-6c0d2787b03a") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("578e302a-03a4-fa48-3bc5-d14abb332fbc"), new Guid("b33ad938-12db-7911-d962-c5e5491e458b") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("57c60047-488b-5972-f409-0bb975d716e7"), new Guid("0109470b-8d47-88e7-68ed-12c782011602") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("57c60047-488b-5972-f409-0bb975d716e7"), new Guid("4a4236a0-d3bf-ee05-2281-f4f61a874a19") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("57c60047-488b-5972-f409-0bb975d716e7"), new Guid("6b47868e-0996-b4a9-8d3b-c2de15aca87b") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("580a21b7-2818-e84d-ea85-643c016be069"), new Guid("fa982cb5-676e-53db-ef32-92ea5ea09057") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("5c90eefd-3073-02ea-7e62-0586164c4062"), new Guid("605fa570-c233-7b70-6436-e5548bd0d448") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("5cccfc8f-b67a-553a-bc77-5b008b3d28fa"), new Guid("4ebab688-70a1-7aa4-9895-e4dfd583c9f0") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("5cccfc8f-b67a-553a-bc77-5b008b3d28fa"), new Guid("5f3e1a3a-6d3a-53a4-768d-a0845a8bfb96") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("5d256276-91b8-f8a3-7616-609c32c7c00f"), new Guid("ad57d2f4-035d-359c-afa4-e41ded03b2e1") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("5d87ddb7-c738-e08c-a6fd-41e008d6681a"), new Guid("0109470b-8d47-88e7-68ed-12c782011602") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("5daa1735-5fc6-3db2-828f-75edcc432e78"), new Guid("1ebbc2e0-5f20-e86b-8f53-ab7dfdf85228") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("601b6fe7-34d3-7a4a-eee8-8daa20bc4223"), new Guid("5f3e1a3a-6d3a-53a4-768d-a0845a8bfb96") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("6213c500-0683-59ae-a272-9332829eba75"), new Guid("99684b08-2f15-dff0-8984-cbb862229ee3") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("635b4c07-479a-1a69-608f-0726b4f13eb7"), new Guid("b33ad938-12db-7911-d962-c5e5491e458b") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("63d7d4a6-e11e-cfe4-5487-9d33d1c7c72d"), new Guid("c9a9bea9-ee6d-587f-2b4d-57c335fdad93") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("657383e3-9722-2d28-450e-fc9ad0b87dde"), new Guid("04e4da50-5577-1316-a1dc-73f82cb77568") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("6903b5da-4a3a-3c58-220f-635c5c8f5493"), new Guid("605fa570-c233-7b70-6436-e5548bd0d448") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("6b154acf-06f0-3515-9df6-1d66db7dbd55"), new Guid("5dbab613-4e22-6105-8f72-c656e92d13b2") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("6b1e1cf1-41cb-b9b0-5f72-3ea121b9bfcc"), new Guid("6b47868e-0996-b4a9-8d3b-c2de15aca87b") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("6b1e1cf1-41cb-b9b0-5f72-3ea121b9bfcc"), new Guid("bfa9f4cb-1264-89af-c83f-a51e6fd2c469") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("6e249742-1ac6-8c4a-6a84-4fe1d4e74a45"), new Guid("c9a9bea9-ee6d-587f-2b4d-57c335fdad93") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("72cd3096-64a5-c30c-894a-66cd07c446e8"), new Guid("5f3e1a3a-6d3a-53a4-768d-a0845a8bfb96") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("72cd3096-64a5-c30c-894a-66cd07c446e8"), new Guid("99efa5d7-4d3d-f4e4-7bd7-49be8e8051e9") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("73b52d1b-b5b9-8199-0850-56662fb90ece"), new Guid("b7a51989-d306-ff79-24e0-999142417a0b") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("74535622-682c-92e0-f584-e757063c1f0d"), new Guid("4862a584-784b-fec1-3825-1fd8474618a3") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("7584341d-8e81-e362-9e41-1c34de9e2eb4"), new Guid("605fa570-c233-7b70-6436-e5548bd0d448") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("75dc147d-8cb1-219c-8fa0-5e15a8fa850f"), new Guid("04e4da50-5577-1316-a1dc-73f82cb77568") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("760bc1ca-74a8-978f-7e9a-0c3d1cdb9bc1"), new Guid("99efa5d7-4d3d-f4e4-7bd7-49be8e8051e9") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("7646ab53-6a43-5ad9-f072-76d87dd34ae9"), new Guid("1ebbc2e0-5f20-e86b-8f53-ab7dfdf85228") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("7646ab53-6a43-5ad9-f072-76d87dd34ae9"), new Guid("e401e3e5-7d56-e92f-7f0a-f827e6bc6ad9") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("7881eef1-4fda-65c2-a760-daeccee0d29f"), new Guid("f3a6d29d-a967-ebda-8855-2153328a692e") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("789ba0b8-c88b-eed3-25c0-353616f77c27"), new Guid("0eee0b2a-06af-6f97-5cec-b00c7cf2c2bc") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("789ba0b8-c88b-eed3-25c0-353616f77c27"), new Guid("bfa9f4cb-1264-89af-c83f-a51e6fd2c469") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("79170613-ca29-39a7-801b-95a1d600002b"), new Guid("0109470b-8d47-88e7-68ed-12c782011602") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("7d922ca9-6d4d-9a13-7fc1-fd2965782412"), new Guid("74c85808-c3e6-6d46-823f-6c0d2787b03a") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("7f07a411-3d4d-da40-c2e2-98397f58996a"), new Guid("fa982cb5-676e-53db-ef32-92ea5ea09057") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("80bf46cc-2043-89ab-da06-7c33529ac72f"), new Guid("0109470b-8d47-88e7-68ed-12c782011602") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("80bf46cc-2043-89ab-da06-7c33529ac72f"), new Guid("ad57d2f4-035d-359c-afa4-e41ded03b2e1") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("814dede0-4de2-b689-fd15-7cada5fe5453"), new Guid("4a4236a0-d3bf-ee05-2281-f4f61a874a19") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("8185c1a8-e11a-3aa2-b69e-6b1be9a3427a"), new Guid("e401e3e5-7d56-e92f-7f0a-f827e6bc6ad9") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("8207d629-4763-bce3-d96f-d990297880b3"), new Guid("b7a51989-d306-ff79-24e0-999142417a0b") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("878cc5d4-2b29-1e98-3378-006903e70346"), new Guid("5dbab613-4e22-6105-8f72-c656e92d13b2") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("8942a7e5-15a8-305a-dd77-c61bd44f1537"), new Guid("1ebbc2e0-5f20-e86b-8f53-ab7dfdf85228") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("8942a7e5-15a8-305a-dd77-c61bd44f1537"), new Guid("74c85808-c3e6-6d46-823f-6c0d2787b03a") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("8972d043-a8ce-dc90-2c9e-ef015b8efe08"), new Guid("c9a9bea9-ee6d-587f-2b4d-57c335fdad93") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("8aa1f68f-9152-c7b6-a21a-722fd834753e"), new Guid("99684b08-2f15-dff0-8984-cbb862229ee3") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("8c212b3d-63c1-77e8-7ac6-76cc4aa6b2b7"), new Guid("ad57d2f4-035d-359c-afa4-e41ded03b2e1") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("8c57d5d3-8650-fb1e-fd76-6d7c70db1963"), new Guid("e401e3e5-7d56-e92f-7f0a-f827e6bc6ad9") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("8c65a0a7-9c74-a1e1-8502-ae2a7e5eb5fb"), new Guid("3afee780-7fde-786f-e90c-1085a7d8c991") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("8d367ad8-3425-416b-d512-74eaa0a9c5d0"), new Guid("74c85808-c3e6-6d46-823f-6c0d2787b03a") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("914878d0-2dc7-fddd-e716-7d3cfe7a6584"), new Guid("0eee0b2a-06af-6f97-5cec-b00c7cf2c2bc") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("914878d0-2dc7-fddd-e716-7d3cfe7a6584"), new Guid("b33ad938-12db-7911-d962-c5e5491e458b") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("92285dfa-f21c-3951-340d-cc403eb9133f"), new Guid("b33ad938-12db-7911-d962-c5e5491e458b") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("93f3f7b8-43f1-f0c8-042f-a8fba6fa53cb"), new Guid("74c85808-c3e6-6d46-823f-6c0d2787b03a") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("95fba5b8-117e-ccb1-9169-5202c7c072e0"), new Guid("3afee780-7fde-786f-e90c-1085a7d8c991") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("96d49fbe-5232-e39c-34c9-12956f7a81a2"), new Guid("bfa9f4cb-1264-89af-c83f-a51e6fd2c469") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("974a24a1-fa5c-42ab-7201-373dda21c6ae"), new Guid("3afee780-7fde-786f-e90c-1085a7d8c991") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("981b3c2a-f654-424d-a875-6f19dec0e8a4"), new Guid("3afee780-7fde-786f-e90c-1085a7d8c991") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("98ebbb69-f5d9-5ade-14cf-eb538c42b14e"), new Guid("6b47868e-0996-b4a9-8d3b-c2de15aca87b") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("98f1fd09-e491-513c-7122-01a2fd694459"), new Guid("b7a51989-d306-ff79-24e0-999142417a0b") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("995f58e8-4fc4-c8c9-b892-7ddc07fd90dd"), new Guid("5dbab613-4e22-6105-8f72-c656e92d13b2") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("99664518-a47a-a1a5-3889-ecc2b246cc28"), new Guid("6b47868e-0996-b4a9-8d3b-c2de15aca87b") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("99664518-a47a-a1a5-3889-ecc2b246cc28"), new Guid("bfa9f4cb-1264-89af-c83f-a51e6fd2c469") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("99b8f8a4-fd16-e5f8-42b8-65810c0fff73"), new Guid("fa982cb5-676e-53db-ef32-92ea5ea09057") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("9a86f5da-816a-aa4d-fa89-ff4dc6570f00"), new Guid("3afee780-7fde-786f-e90c-1085a7d8c991") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("9f10afc4-799a-99d5-f799-e7ed11400435"), new Guid("1ebbc2e0-5f20-e86b-8f53-ab7dfdf85228") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("a0747cd0-2964-e25a-2b0c-088a31971127"), new Guid("0eee0b2a-06af-6f97-5cec-b00c7cf2c2bc") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("a138e342-6efc-2117-d99e-67b5e694cf3d"), new Guid("fa982cb5-676e-53db-ef32-92ea5ea09057") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("a2558ac8-364b-e4a5-a993-9a247c43d95c"), new Guid("0109470b-8d47-88e7-68ed-12c782011602") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("a2558ac8-364b-e4a5-a993-9a247c43d95c"), new Guid("1ebbc2e0-5f20-e86b-8f53-ab7dfdf85228") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("a2558ac8-364b-e4a5-a993-9a247c43d95c"), new Guid("5dbab613-4e22-6105-8f72-c656e92d13b2") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("a444170e-c9f7-a767-871c-788385a0f7bb"), new Guid("1df665fd-a195-a390-3764-f735753702c8") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("a444170e-c9f7-a767-871c-788385a0f7bb"), new Guid("4862a584-784b-fec1-3825-1fd8474618a3") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("ab26f7a5-b270-377c-5252-45d4cf717073"), new Guid("4862a584-784b-fec1-3825-1fd8474618a3") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("ae2442b4-626b-a373-aecc-c2a4912fc8e2"), new Guid("6b47868e-0996-b4a9-8d3b-c2de15aca87b") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("b1e062b8-e5ce-2c2a-5ae1-5ca16499216b"), new Guid("6b47868e-0996-b4a9-8d3b-c2de15aca87b") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("b1f45667-03b5-1141-5f1b-1f8296424b44"), new Guid("605fa570-c233-7b70-6436-e5548bd0d448") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("b234226e-a0e6-7921-e733-7a13ef38aa6c"), new Guid("4ebab688-70a1-7aa4-9895-e4dfd583c9f0") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("b234226e-a0e6-7921-e733-7a13ef38aa6c"), new Guid("99684b08-2f15-dff0-8984-cbb862229ee3") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("b3226088-bc9a-0db9-e9ff-0611d2d1e885"), new Guid("4862a584-784b-fec1-3825-1fd8474618a3") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("b4d3e9d7-7451-27d7-aaec-7a4daf2d217b"), new Guid("b7a51989-d306-ff79-24e0-999142417a0b") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("b5f703bf-55ca-bf21-c622-bfc3f942009d"), new Guid("6b47868e-0996-b4a9-8d3b-c2de15aca87b") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("b5f703bf-55ca-bf21-c622-bfc3f942009d"), new Guid("99684b08-2f15-dff0-8984-cbb862229ee3") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("b637178f-b6c7-79d9-3f98-123c57740767"), new Guid("65b7fe9a-0d76-f4e3-c95e-9705a6cfad63") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("b637178f-b6c7-79d9-3f98-123c57740767"), new Guid("b33ad938-12db-7911-d962-c5e5491e458b") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("b7169929-6eb5-fd91-81eb-1c5dc3a32e9c"), new Guid("5dbab613-4e22-6105-8f72-c656e92d13b2") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("b81c19bb-f965-9340-e536-f1b741dca96b"), new Guid("3afee780-7fde-786f-e90c-1085a7d8c991") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("ba0a13af-a15c-ae75-883a-0bffd9578cc8"), new Guid("b33ad938-12db-7911-d962-c5e5491e458b") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("ba351d16-1852-43a8-4b16-fac5ad7b9a06"), new Guid("b7a51989-d306-ff79-24e0-999142417a0b") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("bcc7d45a-47a3-540d-7993-af83a8220043"), new Guid("4ebab688-70a1-7aa4-9895-e4dfd583c9f0") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("bee1aff3-f322-c0dc-1c85-daa8a413d787"), new Guid("4862a584-784b-fec1-3825-1fd8474618a3") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("bee1aff3-f322-c0dc-1c85-daa8a413d787"), new Guid("6b47868e-0996-b4a9-8d3b-c2de15aca87b") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("bf4bf248-a2e6-da4a-c591-a0ee6e741d0c"), new Guid("04e4da50-5577-1316-a1dc-73f82cb77568") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("c1ea820d-06fc-fda6-26f4-535ff6445907"), new Guid("3afee780-7fde-786f-e90c-1085a7d8c991") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("c21c927d-c994-116f-0975-ce6ef6e4200f"), new Guid("4862a584-784b-fec1-3825-1fd8474618a3") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("c2b46550-3c43-ea85-83f6-5f87cadedd4f"), new Guid("5dbab613-4e22-6105-8f72-c656e92d13b2") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("c2b46550-3c43-ea85-83f6-5f87cadedd4f"), new Guid("b33ad938-12db-7911-d962-c5e5491e458b") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("c39a6000-d4c3-c375-a624-ea01c807d587"), new Guid("c9a9bea9-ee6d-587f-2b4d-57c335fdad93") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("c39a6000-d4c3-c375-a624-ea01c807d587"), new Guid("e401e3e5-7d56-e92f-7f0a-f827e6bc6ad9") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("c877fa5c-b17c-1a5a-74d3-e726b232b3cd"), new Guid("ad57d2f4-035d-359c-afa4-e41ded03b2e1") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("c8b6392b-9d16-bd13-3ff3-be5a388d0da6"), new Guid("b33ad938-12db-7911-d962-c5e5491e458b") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("c9663694-7e9a-2383-f22d-4c888b1c39c8"), new Guid("e401e3e5-7d56-e92f-7f0a-f827e6bc6ad9") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("cbd47658-945b-ac6e-7594-cb76d8e2e00d"), new Guid("3afee780-7fde-786f-e90c-1085a7d8c991") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("cd5afc59-99dc-80b5-c431-6c64bf1b1676"), new Guid("bfa9f4cb-1264-89af-c83f-a51e6fd2c469") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("cd5afc59-99dc-80b5-c431-6c64bf1b1676"), new Guid("f3a6d29d-a967-ebda-8855-2153328a692e") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("cda99cb9-254d-91ce-9d9c-e0e1a2d0806f"), new Guid("605fa570-c233-7b70-6436-e5548bd0d448") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("cdc773eb-b471-25b0-98d0-0b53f6fcc396"), new Guid("fa982cb5-676e-53db-ef32-92ea5ea09057") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("cfeb6d91-ba80-b81c-7fc6-fd52351726ab"), new Guid("0eee0b2a-06af-6f97-5cec-b00c7cf2c2bc") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("d15d2f8d-6774-619c-706d-9da8fab9b59a"), new Guid("6b47868e-0996-b4a9-8d3b-c2de15aca87b") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("d15d2f8d-6774-619c-706d-9da8fab9b59a"), new Guid("f3a6d29d-a967-ebda-8855-2153328a692e") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("d220b046-0e8c-96a6-1fd1-9bdddc5a31db"), new Guid("04e4da50-5577-1316-a1dc-73f82cb77568") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("d504fae7-fc50-e57b-1131-3438086cf4f6"), new Guid("99efa5d7-4d3d-f4e4-7bd7-49be8e8051e9") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("d50efdc5-c407-5e6d-3bb8-0548e6b3534c"), new Guid("4ebab688-70a1-7aa4-9895-e4dfd583c9f0") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("da5527e0-e3d3-1648-c477-fba61204ac2f"), new Guid("bfa9f4cb-1264-89af-c83f-a51e6fd2c469") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("dc0bf655-565d-c063-ec58-cc86b1620fe0"), new Guid("b7a51989-d306-ff79-24e0-999142417a0b") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("e0bb6aa6-572a-ecad-3946-bfc55cedf874"), new Guid("4a4236a0-d3bf-ee05-2281-f4f61a874a19") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("e0bb6aa6-572a-ecad-3946-bfc55cedf874"), new Guid("b7a51989-d306-ff79-24e0-999142417a0b") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("e0bb938c-c81c-6de0-f8a2-b475d3cdfa81"), new Guid("bfa9f4cb-1264-89af-c83f-a51e6fd2c469") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("e0bb938c-c81c-6de0-f8a2-b475d3cdfa81"), new Guid("fa982cb5-676e-53db-ef32-92ea5ea09057") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("e1499051-79d5-9488-fa57-3c7ad804edf2"), new Guid("0eee0b2a-06af-6f97-5cec-b00c7cf2c2bc") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("e1499051-79d5-9488-fa57-3c7ad804edf2"), new Guid("3afee780-7fde-786f-e90c-1085a7d8c991") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("e14db289-7264-681c-0b12-c1009134d9e5"), new Guid("0eee0b2a-06af-6f97-5cec-b00c7cf2c2bc") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("e2fd194f-8dc8-25aa-a242-fc6bb19be719"), new Guid("605fa570-c233-7b70-6436-e5548bd0d448") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("e3ce283c-24c3-30c1-7e60-8defc6a26ac1"), new Guid("6b47868e-0996-b4a9-8d3b-c2de15aca87b") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("e4158f6a-cb4d-3211-a807-0cd9a65f2e32"), new Guid("0eee0b2a-06af-6f97-5cec-b00c7cf2c2bc") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("e4158f6a-cb4d-3211-a807-0cd9a65f2e32"), new Guid("5f3e1a3a-6d3a-53a4-768d-a0845a8bfb96") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("e4158f6a-cb4d-3211-a807-0cd9a65f2e32"), new Guid("99efa5d7-4d3d-f4e4-7bd7-49be8e8051e9") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("e43d82b4-ab7f-1ad7-f50b-d39e4dd0e429"), new Guid("4a4236a0-d3bf-ee05-2281-f4f61a874a19") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("e703f4b3-a667-c43c-0f03-739c76618796"), new Guid("04e4da50-5577-1316-a1dc-73f82cb77568") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("eaebe05a-6dbd-579a-434d-5ad7b66822d3"), new Guid("c9a9bea9-ee6d-587f-2b4d-57c335fdad93") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("efed4dad-cb47-109c-71b4-2d19b5ed768d"), new Guid("65b7fe9a-0d76-f4e3-c95e-9705a6cfad63") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("efed4dad-cb47-109c-71b4-2d19b5ed768d"), new Guid("ad57d2f4-035d-359c-afa4-e41ded03b2e1") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("eff78a89-914f-4c56-840d-d44956d025a9"), new Guid("4a4236a0-d3bf-ee05-2281-f4f61a874a19") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("f16c94f9-4b07-2a1e-bf61-cf7496034a31"), new Guid("b33ad938-12db-7911-d962-c5e5491e458b") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("f6180ab4-051a-e1d9-c886-24206aee08f2"), new Guid("c9a9bea9-ee6d-587f-2b4d-57c335fdad93") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("f7605d24-76bb-7e75-de6e-86e66168b47b"), new Guid("1ebbc2e0-5f20-e86b-8f53-ab7dfdf85228") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("fa9270b5-7883-c7b2-b471-9e40d99e430e"), new Guid("65b7fe9a-0d76-f4e3-c95e-9705a6cfad63") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("fd5f3019-71e3-b5fc-fdd2-81726410a929"), new Guid("3afee780-7fde-786f-e90c-1085a7d8c991") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("fdb625a1-413d-f9ae-e0cb-d1d13c099808"), new Guid("4ebab688-70a1-7aa4-9895-e4dfd583c9f0") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("fdb625a1-413d-f9ae-e0cb-d1d13c099808"), new Guid("65b7fe9a-0d76-f4e3-c95e-9705a6cfad63") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("fdc7a927-4e6e-1163-6860-e4e99b103889"), new Guid("6b47868e-0996-b4a9-8d3b-c2de15aca87b") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("fdebfba6-d9bb-4e04-be72-31a640a8dceb"), new Guid("0109470b-8d47-88e7-68ed-12c782011602") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("ff04bd04-816d-2bce-243b-352d2864513c"), new Guid("65b7fe9a-0d76-f4e3-c95e-9705a6cfad63") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("ff6df3c6-1aa2-6cf7-4816-791ce813c02f"), new Guid("1df665fd-a195-a390-3764-f735753702c8") });

            migrationBuilder.DeleteData(
                table: "PersonsStudySubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("ff6df3c6-1aa2-6cf7-4816-791ce813c02f"), new Guid("b33ad938-12db-7911-d962-c5e5491e458b") });

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("117b1a14-7df1-9367-d42a-1a90e892ab4e"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("14ccc38f-0c7c-8ff9-86b9-9abc2fbf56e0"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("1c359940-9f15-d584-cbfd-6fa98aa52275"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("40ff49d6-51db-0a74-cd06-dd31da551897"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("56d430cb-e068-f9d3-97d6-af2b275141e5"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("7ddf4877-f528-c711-44db-e74fb78c8f86"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("9381cfc1-729f-1157-6727-9f4a2e2f11e6"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("93d3279a-686f-73a1-f9bd-abf7b5372d3a"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("a314b3c0-35ec-480d-c8a2-360aab4a183e"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("e2987b0a-7d6e-50d8-51b3-89b846be1046"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("eb6389b4-e2df-0eb4-604b-5aab771a9ddb"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("f372bbe0-3bf0-c700-ed61-9fbff71c8089"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("fe6050e3-dc94-85f2-e286-b92ef22de44b"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("01c8a695-8315-a40c-c246-23eb97b16b17"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("03e6aca1-3a22-b536-2b98-1c255dfe1e78"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("05257d60-ef9e-9abf-8045-6a678974c6cf"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("087f3742-1883-51a8-3a77-977b9c268970"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("0d8f0b86-f704-50ce-77e3-030051179ad7"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("0e3d8826-0775-8d40-4cc4-95fc42439892"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("0ec870e9-4275-9bb4-0963-2a74004494f3"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("0fdfb4af-36c1-f984-4f99-6019530686c9"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("10ff5be3-ebd1-0a90-dc76-03a8e75794f0"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("11c965eb-2a58-643f-678c-8b63238bac20"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("153d939d-9fc0-33eb-8acf-c199759390dc"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("171764c1-1eca-ebc6-4f32-6b0f2f500668"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("1fbf0c7d-4d5e-fb6a-081b-187b643c75a7"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("205eddd8-63a5-2e20-4580-96875682f95e"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("22344500-14e1-698b-2387-84b352497452"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("261e391d-e2be-e2e1-fb3a-56b3cd2fae1d"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("26b7a2dd-4903-ed3d-9f48-53638662fa19"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("2782ad9c-feea-b293-8514-22e5f3903c5f"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("2a58f9a9-887b-86b7-1bf3-baa4f7212932"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("2b541bff-10c2-b279-1100-248ce8055b9a"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("2ee3f52e-0467-bde0-26ad-d0a0ad7054f7"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("2ef51218-2fa2-fc9f-5ba0-defe0da7df4d"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("35c255ea-76b9-5cb8-cf45-79698da9e361"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("3890624b-d6c5-43f1-f42c-53840849eac9"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("398603ee-bfb3-44e0-139a-6929a6f64ca9"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("39f0254f-4d52-4d4c-2a34-faa809d2126c"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("3c7a7b70-5bb1-ccf4-9848-21b32f77378b"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("3f44859c-d028-d76e-d8e4-9b72c3de33a4"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("41312180-c2ee-b91f-007f-095ff7c6eed5"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("42037930-031f-868e-1a50-f460e2dc7954"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("42b4aab8-eee5-315e-266b-e6f668e4120c"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("4ca3b01c-2ebf-2798-ce6c-c0dc422b5f68"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("4e45e7ec-97e4-5714-2d34-4f0d9ad8e654"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("523781c6-bce5-5e9b-2372-535c62152cc1"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("52cb3e54-8d2c-9a9c-f772-148d44d2ba41"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("5489e5af-dc3d-4819-afe7-008395f1001e"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("577cef87-4929-41ea-60fe-b74d2ab5a0e5"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("578e302a-03a4-fa48-3bc5-d14abb332fbc"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("57c60047-488b-5972-f409-0bb975d716e7"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("580a21b7-2818-e84d-ea85-643c016be069"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("5c90eefd-3073-02ea-7e62-0586164c4062"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("5cccfc8f-b67a-553a-bc77-5b008b3d28fa"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("5d256276-91b8-f8a3-7616-609c32c7c00f"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("5d87ddb7-c738-e08c-a6fd-41e008d6681a"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("5daa1735-5fc6-3db2-828f-75edcc432e78"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("601b6fe7-34d3-7a4a-eee8-8daa20bc4223"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("6213c500-0683-59ae-a272-9332829eba75"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("635b4c07-479a-1a69-608f-0726b4f13eb7"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("63d7d4a6-e11e-cfe4-5487-9d33d1c7c72d"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("657383e3-9722-2d28-450e-fc9ad0b87dde"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("6903b5da-4a3a-3c58-220f-635c5c8f5493"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("6b1e1cf1-41cb-b9b0-5f72-3ea121b9bfcc"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("6e249742-1ac6-8c4a-6a84-4fe1d4e74a45"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("72cd3096-64a5-c30c-894a-66cd07c446e8"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("73b52d1b-b5b9-8199-0850-56662fb90ece"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("74535622-682c-92e0-f584-e757063c1f0d"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("7584341d-8e81-e362-9e41-1c34de9e2eb4"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("75dc147d-8cb1-219c-8fa0-5e15a8fa850f"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("760bc1ca-74a8-978f-7e9a-0c3d1cdb9bc1"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("7646ab53-6a43-5ad9-f072-76d87dd34ae9"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("7881eef1-4fda-65c2-a760-daeccee0d29f"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("789ba0b8-c88b-eed3-25c0-353616f77c27"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("79170613-ca29-39a7-801b-95a1d600002b"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("7d922ca9-6d4d-9a13-7fc1-fd2965782412"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("7f07a411-3d4d-da40-c2e2-98397f58996a"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("80bf46cc-2043-89ab-da06-7c33529ac72f"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("814dede0-4de2-b689-fd15-7cada5fe5453"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("8185c1a8-e11a-3aa2-b69e-6b1be9a3427a"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("8207d629-4763-bce3-d96f-d990297880b3"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("878cc5d4-2b29-1e98-3378-006903e70346"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("8942a7e5-15a8-305a-dd77-c61bd44f1537"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("8972d043-a8ce-dc90-2c9e-ef015b8efe08"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("8aa1f68f-9152-c7b6-a21a-722fd834753e"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("8c212b3d-63c1-77e8-7ac6-76cc4aa6b2b7"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("8c57d5d3-8650-fb1e-fd76-6d7c70db1963"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("8c65a0a7-9c74-a1e1-8502-ae2a7e5eb5fb"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("8d367ad8-3425-416b-d512-74eaa0a9c5d0"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("914878d0-2dc7-fddd-e716-7d3cfe7a6584"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("92285dfa-f21c-3951-340d-cc403eb9133f"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("93f3f7b8-43f1-f0c8-042f-a8fba6fa53cb"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("95fba5b8-117e-ccb1-9169-5202c7c072e0"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("96d49fbe-5232-e39c-34c9-12956f7a81a2"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("974a24a1-fa5c-42ab-7201-373dda21c6ae"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("981b3c2a-f654-424d-a875-6f19dec0e8a4"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("98ebbb69-f5d9-5ade-14cf-eb538c42b14e"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("98f1fd09-e491-513c-7122-01a2fd694459"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("995f58e8-4fc4-c8c9-b892-7ddc07fd90dd"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("99664518-a47a-a1a5-3889-ecc2b246cc28"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("99b8f8a4-fd16-e5f8-42b8-65810c0fff73"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("9a86f5da-816a-aa4d-fa89-ff4dc6570f00"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("9f10afc4-799a-99d5-f799-e7ed11400435"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("a2558ac8-364b-e4a5-a993-9a247c43d95c"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("a444170e-c9f7-a767-871c-788385a0f7bb"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("ab26f7a5-b270-377c-5252-45d4cf717073"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("ae2442b4-626b-a373-aecc-c2a4912fc8e2"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("b1e062b8-e5ce-2c2a-5ae1-5ca16499216b"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("b1f45667-03b5-1141-5f1b-1f8296424b44"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("b234226e-a0e6-7921-e733-7a13ef38aa6c"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("b3226088-bc9a-0db9-e9ff-0611d2d1e885"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("b4d3e9d7-7451-27d7-aaec-7a4daf2d217b"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("b5f703bf-55ca-bf21-c622-bfc3f942009d"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("b637178f-b6c7-79d9-3f98-123c57740767"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("b7169929-6eb5-fd91-81eb-1c5dc3a32e9c"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("ba0a13af-a15c-ae75-883a-0bffd9578cc8"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("ba351d16-1852-43a8-4b16-fac5ad7b9a06"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("bcc7d45a-47a3-540d-7993-af83a8220043"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("bee1aff3-f322-c0dc-1c85-daa8a413d787"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("bf4bf248-a2e6-da4a-c591-a0ee6e741d0c"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("c1ea820d-06fc-fda6-26f4-535ff6445907"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("c21c927d-c994-116f-0975-ce6ef6e4200f"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("c2b46550-3c43-ea85-83f6-5f87cadedd4f"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("c39a6000-d4c3-c375-a624-ea01c807d587"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("c877fa5c-b17c-1a5a-74d3-e726b232b3cd"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("c8b6392b-9d16-bd13-3ff3-be5a388d0da6"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("c9663694-7e9a-2383-f22d-4c888b1c39c8"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("cd5afc59-99dc-80b5-c431-6c64bf1b1676"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("cda99cb9-254d-91ce-9d9c-e0e1a2d0806f"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("cdc773eb-b471-25b0-98d0-0b53f6fcc396"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("cfeb6d91-ba80-b81c-7fc6-fd52351726ab"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("d15d2f8d-6774-619c-706d-9da8fab9b59a"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("d220b046-0e8c-96a6-1fd1-9bdddc5a31db"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("d504fae7-fc50-e57b-1131-3438086cf4f6"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("d50efdc5-c407-5e6d-3bb8-0548e6b3534c"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("da5527e0-e3d3-1648-c477-fba61204ac2f"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("dc0bf655-565d-c063-ec58-cc86b1620fe0"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("e0bb6aa6-572a-ecad-3946-bfc55cedf874"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("e0bb938c-c81c-6de0-f8a2-b475d3cdfa81"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("e1499051-79d5-9488-fa57-3c7ad804edf2"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("e14db289-7264-681c-0b12-c1009134d9e5"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("e2fd194f-8dc8-25aa-a242-fc6bb19be719"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("e3ce283c-24c3-30c1-7e60-8defc6a26ac1"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("e4158f6a-cb4d-3211-a807-0cd9a65f2e32"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("e43d82b4-ab7f-1ad7-f50b-d39e4dd0e429"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("e703f4b3-a667-c43c-0f03-739c76618796"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("efed4dad-cb47-109c-71b4-2d19b5ed768d"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("eff78a89-914f-4c56-840d-d44956d025a9"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("f16c94f9-4b07-2a1e-bf61-cf7496034a31"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("f6180ab4-051a-e1d9-c886-24206aee08f2"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("f7605d24-76bb-7e75-de6e-86e66168b47b"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("fa9270b5-7883-c7b2-b471-9e40d99e430e"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("fd5f3019-71e3-b5fc-fdd2-81726410a929"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("fdb625a1-413d-f9ae-e0cb-d1d13c099808"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("fdc7a927-4e6e-1163-6860-e4e99b103889"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("fdebfba6-d9bb-4e04-be72-31a640a8dceb"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("ff04bd04-816d-2bce-243b-352d2864513c"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("ff6df3c6-1aa2-6cf7-4816-791ce813c02f"));

            migrationBuilder.DeleteData(
                table: "StudySubjects",
                keyColumn: "Id",
                keyValue: new Guid("0109470b-8d47-88e7-68ed-12c782011602"));

            migrationBuilder.DeleteData(
                table: "StudySubjects",
                keyColumn: "Id",
                keyValue: new Guid("04e4da50-5577-1316-a1dc-73f82cb77568"));

            migrationBuilder.DeleteData(
                table: "StudySubjects",
                keyColumn: "Id",
                keyValue: new Guid("0eee0b2a-06af-6f97-5cec-b00c7cf2c2bc"));

            migrationBuilder.DeleteData(
                table: "StudySubjects",
                keyColumn: "Id",
                keyValue: new Guid("1df665fd-a195-a390-3764-f735753702c8"));

            migrationBuilder.DeleteData(
                table: "StudySubjects",
                keyColumn: "Id",
                keyValue: new Guid("1ebbc2e0-5f20-e86b-8f53-ab7dfdf85228"));

            migrationBuilder.DeleteData(
                table: "StudySubjects",
                keyColumn: "Id",
                keyValue: new Guid("3afee780-7fde-786f-e90c-1085a7d8c991"));

            migrationBuilder.DeleteData(
                table: "StudySubjects",
                keyColumn: "Id",
                keyValue: new Guid("4862a584-784b-fec1-3825-1fd8474618a3"));

            migrationBuilder.DeleteData(
                table: "StudySubjects",
                keyColumn: "Id",
                keyValue: new Guid("4a4236a0-d3bf-ee05-2281-f4f61a874a19"));

            migrationBuilder.DeleteData(
                table: "StudySubjects",
                keyColumn: "Id",
                keyValue: new Guid("4ebab688-70a1-7aa4-9895-e4dfd583c9f0"));

            migrationBuilder.DeleteData(
                table: "StudySubjects",
                keyColumn: "Id",
                keyValue: new Guid("5dbab613-4e22-6105-8f72-c656e92d13b2"));

            migrationBuilder.DeleteData(
                table: "StudySubjects",
                keyColumn: "Id",
                keyValue: new Guid("5f3e1a3a-6d3a-53a4-768d-a0845a8bfb96"));

            migrationBuilder.DeleteData(
                table: "StudySubjects",
                keyColumn: "Id",
                keyValue: new Guid("605fa570-c233-7b70-6436-e5548bd0d448"));

            migrationBuilder.DeleteData(
                table: "StudySubjects",
                keyColumn: "Id",
                keyValue: new Guid("65b7fe9a-0d76-f4e3-c95e-9705a6cfad63"));

            migrationBuilder.DeleteData(
                table: "StudySubjects",
                keyColumn: "Id",
                keyValue: new Guid("6b47868e-0996-b4a9-8d3b-c2de15aca87b"));

            migrationBuilder.DeleteData(
                table: "StudySubjects",
                keyColumn: "Id",
                keyValue: new Guid("74c85808-c3e6-6d46-823f-6c0d2787b03a"));

            migrationBuilder.DeleteData(
                table: "StudySubjects",
                keyColumn: "Id",
                keyValue: new Guid("99684b08-2f15-dff0-8984-cbb862229ee3"));

            migrationBuilder.DeleteData(
                table: "StudySubjects",
                keyColumn: "Id",
                keyValue: new Guid("99efa5d7-4d3d-f4e4-7bd7-49be8e8051e9"));

            migrationBuilder.DeleteData(
                table: "StudySubjects",
                keyColumn: "Id",
                keyValue: new Guid("ad57d2f4-035d-359c-afa4-e41ded03b2e1"));

            migrationBuilder.DeleteData(
                table: "StudySubjects",
                keyColumn: "Id",
                keyValue: new Guid("b33ad938-12db-7911-d962-c5e5491e458b"));

            migrationBuilder.DeleteData(
                table: "StudySubjects",
                keyColumn: "Id",
                keyValue: new Guid("b7a51989-d306-ff79-24e0-999142417a0b"));

            migrationBuilder.DeleteData(
                table: "StudySubjects",
                keyColumn: "Id",
                keyValue: new Guid("bfa9f4cb-1264-89af-c83f-a51e6fd2c469"));

            migrationBuilder.DeleteData(
                table: "StudySubjects",
                keyColumn: "Id",
                keyValue: new Guid("c9a9bea9-ee6d-587f-2b4d-57c335fdad93"));

            migrationBuilder.DeleteData(
                table: "StudySubjects",
                keyColumn: "Id",
                keyValue: new Guid("e401e3e5-7d56-e92f-7f0a-f827e6bc6ad9"));

            migrationBuilder.DeleteData(
                table: "StudySubjects",
                keyColumn: "Id",
                keyValue: new Guid("f3a6d29d-a967-ebda-8855-2153328a692e"));

            migrationBuilder.DeleteData(
                table: "StudySubjects",
                keyColumn: "Id",
                keyValue: new Guid("fa982cb5-676e-53db-ef32-92ea5ea09057"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("0c90664c-b077-6534-6d89-5f85248b91b0"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("151c4f70-738c-cb3b-1c61-05f15a3452f0"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("16d37f02-e42d-a5d8-75f4-81ab0295fbfb"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("180c058a-defa-a61b-be1b-b46d0c3fe05a"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("2aa64f66-272b-2c67-3bed-4e1b5725c85d"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("3585c031-add6-f6fe-475a-617007527de5"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("385d0737-d5b9-12e9-c61e-e2645f2f079c"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("3878f47e-d214-eb44-60f8-cd5b2e6d75c3"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("39aa1956-0302-a964-e51d-fef27518bcad"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("407e9314-7abc-e99b-a15e-82f8f1f50cc6"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("43b6a79d-7692-bddd-e4ab-6b1fc1b970dd"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("43c1cbbc-1d2c-a88a-5188-66ccd72d3d7f"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("4934ae52-7807-e943-5121-dbc0ca599c96"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("566d0be6-67a2-592a-d8bd-60a31dcffc71"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("569a3b8f-bbf1-2384-4e34-503169870eae"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("5c96d583-27f9-2d2e-51af-faf6ca6a2592"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("5dc3f409-d89e-f611-629d-47d3d34373b8"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("6743208a-18e3-f813-0e36-aeaf4f480d9c"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("69fef9c5-5554-3ae6-3b18-9758c324276d"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("6d283440-8f0b-c3bc-fc32-d4d9ab827726"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("76029197-52cb-dcab-844c-e6fb9e15be87"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("78cc8e48-0f69-29b9-dcdc-1f8c5971b598"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("7979cd93-994c-4fc3-e1cf-4650308071db"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("80573226-7fc4-7c45-1695-2b1875980efa"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("808c3f78-fa78-725b-ad57-dd7b8315a05f"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("8243c599-1c1a-76e3-a229-633f2270620d"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("83971da9-8a89-9f61-eb46-d61ff46d9e05"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("85c102d7-34cf-7793-f3ae-00124fc33b08"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("8bb30461-36c9-385d-d48b-9c5b294c969a"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("8be9f827-0421-c677-5455-0ec6d4cf3e24"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("8e4600ca-a906-8270-68c3-acd0d5be34d3"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("92032847-da22-ed68-36e8-0df8f28db002"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("9207cac4-9163-4bf1-5927-537f9f63ba71"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("9b5a475f-98ca-def1-6442-ea085d85d850"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("a14a1030-567f-1f04-cfab-bb41c401b12c"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("a21d5135-63ae-f1cb-beb7-b2eae5b90a01"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("a2b2b1a1-5928-f8ae-cbf5-9ae879644e31"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("a4b74f0e-a6fc-b2ed-5174-74ea1bb63ba7"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("a59e5a01-3627-0d6c-421b-201f3ddac69b"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("aa3ae8e6-3ed7-cb79-55fc-8eadc16c8e39"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("abb10a6c-6c8e-9f09-f551-8e9220eecaf1"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("ac680941-2c32-d80e-446b-c4e3c8df0119"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("b0a87fcc-a540-ecc7-079c-3352a5e1e7f2"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("b81e76f5-87f5-1e12-eeaa-ca3c62d06698"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("bb37af07-f39f-5f48-2142-99dd9ec8eff2"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("c069a70f-aa3e-3287-0ab6-44e85da60896"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("cb62316f-7802-1b4f-9f56-cce4b4c56a42"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("d220318d-1f66-f544-61c3-8e1f56aa2722"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("de841c5c-dd61-2125-849f-0c7bf1fb9f43"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("df93e2ac-63fc-6963-1ef5-5555dfc1ade2"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("e1c1d586-f889-97b9-2867-65b593554d8a"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("e657df55-53f6-86f6-3a25-944b881c8934"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("e6c627d7-2af5-ad44-565c-15ad4b377c92"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("e99bdb95-b9a3-ed8f-e1d4-661d84a022eb"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("f22f1d28-ea09-3122-fc9a-8bc9a3be4904"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("f6ef6383-10c6-f7e6-2f47-b695cb3557b2"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("fb25472b-e281-e001-61d9-81ff818b3322"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("fc9b05aa-90de-64d9-856f-101818ba2d6d"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("fee36535-8081-9bdc-2d27-aeb56be6090a"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("0838b21d-d973-f654-6a9f-aec89ac59c10"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("0a0b91da-4ead-6498-7890-dea87509e885"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("20d4fca3-3512-205f-9b70-3b4b7f40a7a5"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("258edced-c4c2-976b-ad61-a29e6855f7cd"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("2d1f6744-4f14-a9d3-6da3-0cfd05ed4118"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("33f0e870-e1bf-d308-a38a-acdbf48daeb3"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("3489e534-59b7-44f4-5789-d5aa7a80293d"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("4140c0be-10a5-eb42-f86d-6251a92dfb13"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("471deb5b-97b1-2967-949f-15ea6e8e678e"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("4a5c50af-6676-32c6-f440-e0de2f7893bb"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("58d43316-0561-ab5f-7a01-cce4368cee30"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("6b154acf-06f0-3515-9df6-1d66db7dbd55"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("92c5c7c1-3962-4075-683a-06654a22e17a"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("9553be24-4172-771a-3d81-8c0ddac81e58"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("97a5e3d3-0a1a-6147-bb9d-11f79c3c8e21"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("a0747cd0-2964-e25a-2b0c-088a31971127"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("a138e342-6efc-2117-d99e-67b5e694cf3d"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("b81c19bb-f965-9340-e536-f1b741dca96b"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("cbd47658-945b-ac6e-7594-cb76d8e2e00d"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("d0d5c647-5795-3c4b-cbf3-6ab35a629904"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("d6c89ba6-cb65-3dda-c591-df47ecabd9aa"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("eaebe05a-6dbd-579a-434d-5ad7b66822d3"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("fa36ce16-f58f-0f17-73b3-7a757a17c7d8"));

            migrationBuilder.DeleteData(
                table: "Universities",
                keyColumn: "Id",
                keyValue: new Guid("260e18db-037e-a768-86a4-a062e7384d6b"));

            migrationBuilder.DeleteData(
                table: "Universities",
                keyColumn: "Id",
                keyValue: new Guid("4f2d1645-13d8-6acf-38c0-ace60fef8edd"));

            migrationBuilder.DeleteData(
                table: "Universities",
                keyColumn: "Id",
                keyValue: new Guid("57f40310-0083-eb5d-707f-96e0c239257e"));

            migrationBuilder.DeleteData(
                table: "Universities",
                keyColumn: "Id",
                keyValue: new Guid("88a31570-3356-da9d-895a-afefe9b729e6"));

            migrationBuilder.DeleteData(
                table: "Universities",
                keyColumn: "Id",
                keyValue: new Guid("94eba7ca-3b16-e141-3980-b3736012af31"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("1692a923-8f41-231d-22fe-c351b0262cb6"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("253ccd3f-c789-3ed0-2cef-64d01c29fc0a"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("40f6ceaf-2005-f654-b0dd-4f40df1fbb11"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("47adabd1-376c-2467-12c3-1c5e649a5bff"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("4a9b169d-5a0e-cd4b-a527-09446bfa1fe3"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("5e8fa248-3f1d-a14e-c52a-23f3eebb7277"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("6a5ab17b-51d3-0633-4935-677c1837bc5c"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("6aa79251-8689-cc4c-72b5-6c3ad7ac83b6"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("6b2b7e7f-cf5e-6e4c-3343-fef96d613d40"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("6c14193f-9078-71cd-7549-3639e12355d5"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("72125c3b-f073-e1bb-9f76-035eff073867"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("724e0121-50dd-132d-2192-0c0ff1f707dc"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("7360d064-4c5f-54ec-429c-30acd1a04351"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("860da56c-aeb0-d4f8-0712-433f2a2253d6"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("91976174-a075-2c9d-5421-f0d3a6c50f86"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("a55febc4-8586-52bf-abcb-f7af0996828d"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("b56a1ecf-3da4-1226-99d9-48fb5a132ecc"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("b6454d1b-2238-6d80-5b38-f950fe0c0307"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("b7d768b0-3a48-d7c0-11fa-9107ce25c2e9"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("bc6f8d53-25aa-0a79-2213-7a6443b12292"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("c085a2c9-fd94-db4e-3005-bed4b7b99d88"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("d077b7aa-8542-90b5-b7fc-393567cec158"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("db8d403f-9e6c-f24c-8759-419636d7fa75"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("f38e06d6-992b-1e8d-8136-d5918e086482"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("f4c76b7f-63eb-e504-8f5f-53000fc7782d"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("fddbb79f-95fc-6dae-eb4a-f1d87198d61d"));
        }
    }
}
