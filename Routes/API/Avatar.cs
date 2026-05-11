using MongoDB.Driver;
using Stella.Models;

namespace Stella.Routes.API
{
    public class AvatarHelper
    {
        #region Clothing

        public const string Hair_AngledBob = "0088603e-ec3b-4478-8694-e6fb1989b3f2";
        public const string Hat_Wizard = "01689baf-405e-4b38-9f09-b624e03865b8";
        public const string Shirt_Artist = "02077915-57d3-4e26-b4fe-8e0399cbb293";
        public const string Neck_JackFrostWings = "022ce375-ed02-479d-b87d-9d72d126bbd4";
        public const string Eye_SafariMonocle = "02a5b48c-abba-4385-967b-ba900424829e";
        public const string shirt_sherlock = "033e328f-d9d2-4e53-af20-44f18e3ea208";
        public const string Hat_Angler = "03f8c394-28fa-4087-978b-8d108f0bd969";
        public const string Neck_Tie_Gold_Sequin = "05ec4e87-088f-4281-a118-2e63c2585200";
        public const string Glasses_Pointy = "06306723-ca20-4aa6-b7b3-917113f41ac3";
        public const string Hat_Conductor = "07205057-0804-41de-abe4-bd4027fee1df";
        public const string Hair_Fonzie = "0753d7a4-8247-4fca-a6fc-359c26086140";
        public const string Wrist_Mobster = "08d56627-4500-4724-8692-a23c96ddb3ec";
        public const string Hair_FlatTop = "09177621-9ecd-4f6a-b6a5-64490139141d";
        public const string Shirt_InternationalThiefShirt = "097a3266-4aab-4b23-8f56-373c9b1bc837";
        public const string Shirt_Quiltedcoat = "0ab5790f-a537-4306-ba66-5eb87c02ec7d";
        public const string shirt_royalLady = "0ab6c95c-e157-48bd-a172-2642896b4ffc";
        public const string SeaCaptainTorso = "0bc6bd1b-8b7e-4945-a1d6-c26b9c043318";
        public const string Hat_PB_TruckerHat = "0c537a84-9095-406f-8c87-1464f3a774ba";
        public const string Neck_TieSequin = "0d4e7ebe-efd9-4e68-9900-5645916e7596";
        public const string Hat_Tourist = "0QOlT9c5xUuinpfZaoEe8Q";
        public const string Shirt_TutorialGown_3 = "0yFzgVESokC3gFd3hrS8bg";
        public const string Hat_TopHat = "102c625b-b988-4bf8-a2aa-a31ad7029cdc";
        public const string Shirt_Safari = "1041d745-c5e9-4218-a3e1-198f5c9c418c";
        public const string Shirt_JackFrost = "105a5100-cb57-410f-a26b-1ee21002f067";
        public const string Glasses_Scientist = "11e508a7-fe7d-470e-b270-2dba33e2f7a1";
        public const string Hat_LaserTag = "123de433-a005-4994-8a11-d2d84ad66b11";
        public const string Wrist_Aviator = "125a3a62-1005-47dc-9fd8-ee09ea803e9f";
        public const string Hat_Shark = "13e70c80-69a4-4ad5-90e5-4dd5e03da677";
        public const string Hat_Baseball = "14ef6b00-debf-4a85-9755-b4d37df496d3";
        public const string Hat_Luchador = "1596c113-aa3a-4f5c-b398-e5c3575548e7";
        public const string Shirt_80sSpandex = "17236d76-e3b6-42f6-9179-6fcf0479436f";
        public const string Eye_SciFiVisor_Glow = "1736a60b-6fb6-49bd-948a-fd3f3fc1be50";
        public const string Hat_ArtistBeret = "17aed0a0-70ed-49da-ad09-5bc4746f7718";
        public const string Shirt_Barbershop = "18cd3470-2dd9-4a0a-98bd-eae2d5f5d522";
        public const string Hat_FlapperHeadband = "18feb3c2-049f-4f91-9f4e-6b5fcb4ab70c";
        public const string Hair_Emo = "193a3bf9-abc0-4d78-8d63-92046908b1c5";
        public const string Wrist_WitchHunterGlove = "1974dd48-aa44-434f-879a-eaff0c7c06e6";
        public const string Hat_DrumMajor = "1a028850-64ee-40ab-b547-ebbcfa1b04b3";
        public const string Hair_Shagg = "1a71064b-794f-40fa-9109-8ad36602b6e1";
        public const string FirefighterTorso = "1b37d6cd-0a89-4604-a046-e5cff55b0cf6";
        public const string Wrist_HarnessGloves = "1beaf288-b5a5-475c-8149-c8f3d1146083";
        public const string Hair_Afro = "1d27b674-f9e2-4ffc-9d8c-a58a1be06457";
        public const string Hat_Bow = "1e504fee-b593-4037-bd8f-b88025147991";
        public const string Shirt_Beekeeper = "1ebbfdfc-f72b-4d70-99d4-4d527f896aa7";
        public const string Shirt_Scarecrow = "1fcaf4fd-9012-407e-b691-fbc3ccf22421";
        public const string Hair_Ponytail = "1fd69ef8-0b74-4962-af5a-67f0bf0358f2";
        public const string Belt_WaitressApron = "204bc384-e6d2-41b8-8ce9-0b26be5d85b7";
        public const string Hat_BogMonsterHat = "20b424a9-861a-4d39-a583-22d7b7348c14";
        public const string Hair_Lori = "21599b51-c50f-43d8-ac5f-62c30cd02ca5";
        public const string TennisSkirt = "21caa68e-c3fa-474c-af5e-af1e742b7a60";
        public const string YellowBlueDress = "2296ed0d-df56-4d46-b33a-aae9230a47fc";
        public const string Wrist_Wizard = "22ef1089-d073-4fe8-b038-6f34adf0b85f";
        public const string Eye_Snorkeler_Goggles = "22pyI3Kz-UullhcebC6DLQ";
        public const string Hair_HalfUp = "241506f6-bf88-4b46-b5fe-513a225421f4";
        public const string Hair_ManBun = "24a240f4-1574-420b-b898-a7e91f170759";
        public const string Jersey_Team_Emissive = "24b8b757-4168-4b3b-ba11-46f29d19044d";
        public const string Hat_Winter = "24c4404a-839f-46bd-98b6-6848d747a98b";
        public const string Shirt_LaserTag = "24d94673-f394-42e6-a3c8-276f8b8aa722";
        public const string Shirt_Smuggler = "25d4c652-1730-4925-925e-31a290a2272a";
        public const string Hat_Saija_Helmet = "274cb9b2-2f59-47ea-9a8d-a5b656d148c6";
        public const string Hat_Bee = "2786fc22-3d6c-440d-afcc-15890c061577";
        public const string Neck_ButterflyWings_TheBlueOne = "27c2eb7f-9fac-4c42-90c7-44e7a33d5303";
        public const string Mouth_WizardBeard = "27cdecd2-88f1-40a8-80a9-87abd827c3c5";
        public const string Shirt_Doctor = "27e742bf-3081-4274-ba70-301f0edeb4f1";
        public const string Wrist_Punk = "28374ebc-4050-4ea0-b3b6-41ebe75cedf7";
        public const string Eye_Skeleton_Mask = "28e5dd74-7963-42cf-aa68-f8005aaf312e";
        public const string Hat_BaseballHelmet = "293e7ad3-01c9-43af-96e3-06c34145ff12";
        public const string Hat_Flowers = "2b2eb9e5-d52e-4004-bdb2-0bcf6910992d";
        public const string Hair_Mullet = "2b7f4dae-51da-4af0-b009-12d6005c85c6";
        public const string Hat_Rainhat = "2bd53190-46f8-4956-9388-87c5a04efc4f";
        public const string Eye_2020Glasses = "2c3773a5-a0b4-41c5-a4df-6572dff516c9";
        public const string Shirt_Saija = "2c679f89-c76e-4cfb-94e9-448c8fd44d55";
        public const string Hat_Unicorn = "2caHvVQ1vECrPv-YcdxdyA";
        public const string Hair_PunkGirl = "2cb4f372-3372-4583-8b57-c4e3988e3c28";
        public const string Wrist_Letterman = "2dFMy4zc7ky_Fd5fzfgInw";
        public const string CollarShirt = "2e59d8d0-91a0-4449-bfdc-a5d663fd9343";
        public const string KnightCape = "2e5afc40-7e25-418c-8b1b-316b8ef479a7";
        public const string BaseballTorso = "2f8518fc-c989-40de-98b4-c6f09b304166";
        public const string Hat_Golfer = "2faa26b6-f7c3-4b0d-8f70-1f9454e64a54";
        public const string Dress_FormalDress = "30380607-8b54-4b63-81d3-cb3f08e452c1";
        public const string Wrist_LaserTagGlove = "3044adce-90c0-4f66-81f5-39c4fca86fdf";
        public const string Glasses_Paintball = "34144f4c-f6ef-49e5-a286-1781e82e6782";
        public const string Hat_Electrician = "34654303-9760-447f-8614-1c26506db994";
        public const string Basketball_Tee = "348ac48b-986e-4d42-a0f7-1aea16b88271";
        public const string FootBallShoulderPads = "34d45669-b319-4c7d-bd05-078961d70d0b";
        public const string Shirt_Lumberjack = "350c5c1e-318b-4233-a7e5-1f49909d8e65";
        public const string Shirt_ScoutSkirt = "35f60d27-22cf-4e17-8f39-c9e3a9fa2291";
        public const string Shirt_Winter = "3757149b-f478-4975-81e5-d808a1bed8d5";
        public const string Neck_Bee = "37668d3d-c9f4-4bd6-81d4-a4f64ba2d61b";
        public const string Neck_PirateCaptain = "38b38e24-d636-41c6-b80e-a285ae3106dc";
        public const string Shirt_Lacrosse = "39278302-b52a-48a8-a566-ed756a5fa1a9";
        public const string Wrist_Winter = "3a790be3-2937-44d4-be01-b5d65353bd3d";
        public const string Neck_Scallywag_Belt = "3af4c506-d49c-4126-9437-1d3bb1658863";
        public const string Shirt_PirateCaptain = "3b00c71f-79c2-4a04-9fc0-a23b4c85562f";
        public const string Wrist_ConstructionGlove = "3bb50a88-09ae-48c7-a42c-df5879680eff";
        public const string Wrist_Scarecrow = "3c9acb9e-3353-4359-aa5a-ae9512b086b4";
        public const string Hat_CatEars = "3d5184e1-0201-4476-bf4b-4eb28190de62";
        public const string Shirt_Vest = "3d9d52cb-6a3d-436b-90e7-e76f238329ee";
        public const string Shirt_Electrician = "3dc003c5-428b-47d6-80fb-6520b63119e8";
        public const string Wrist_Smuggler = "3dec4865-cf23-4c19-a460-dd2db80ee851";
        public const string Hat_PirateCaptain = "3df394de-9c3e-4141-aba4-12eac4742102";
        public const string CopStache = "3e139dd9-4757-43a8-8546-8da70dc17f0a";
        public const string Shirt_SleevelessDenimJacket = "3e3f5ed5-d810-4054-b648-d93167b90033";
        public const string Shirt_IceQueenGown = "3R_zf8xliEiurVU8GwaItg";
        public const string Wrist_Beekeeper = "4025e4c4-abaa-4729-a2a3-a7175313e5ed";
        public const string Hat_HeadBand = "40528de7-38a3-4a7c-8f93-6d3bfa5573f2";
        public const string hat_royalCrown = "40734c4d-e1fe-426c-8921-930f7463d8e8";
        public const string Shirt_WitchHunter = "418db0e0-c7af-40c2-9cac-d461ce41e210";
        public const string Hat_Safari = "418ed21e-766f-4c69-9d57-6f866dcc7feb";
        public const string Shirt_Aviator = "42aa7888-f0b9-4584-9cc1-966585c6b36e";
        public const string Shirt_Mobster = "4308da04-af84-40bb-845a-7a9e1a2726ec";
        public const string Eye_MardiGrasEyes2 = "43354e59-4938-44bc-81e0-4fba47d0ac12";
        public const string Shirt_50sDress = "439d1e24-d67f-4b8a-8fb3-8bf589d5a8ee";
        public const string Hat_HarnessHelmet = "459ec62c-67db-4b72-9e29-0ad3ecd0b737";
        public const string Hair_Pompadour = "45eaab67-19c2-4601-8f80-3565a4dceba4";
        public const string SeventiesStache = "45f5e714-8a5f-4385-a97f-675066167011";
        public const string Wrist_FlapperGlove = "473c672d-2b79-48a2-a49d-fd68160c5bde";
        public const string Hat_BaseBall_FlatBill = "474db08a-d4dc-4625-9f5a-1a6ae0b70827";
        public const string Eye_AviatorGoggles = "47629ed1-5378-427c-ad61-4b44d2fe90cc";
        public const string Wrist_SpaceMarineGlove = "4763436c-2dcc-482a-bf37-a6b16d7aae6e";
        public const string Hair_Jazzercise = "49397e16-1027-4286-9bc4-b59eae565ff0";
        public const string Hat_DinoHat = "4abc2ac4-e60c-49b1-9ac8-4d4751ed78ae";
        public const string Shirt_SpaceMarine = "4ce7a70f-15a0-4cad-98ee-5cbb40827338";
        public const string FemaleTank = "4d507dfa-4a99-4ac0-8537-229e9dc0eb4a";
        public const string Wrist_DrumMajor_Glove = "4d533b3a-b5fa-446a-842d-92798ad5b493";
        public const string Wrist_BogMonsterWrist = "4e42e02e-33fd-4ff9-b74e-9bde26253c35";
        public const string Hat_DeepSeaDiver = "4fcb5b84-13a9-43e6-9680-72b17874ae53";
        public const string Wrist_Saija_Glove = "50c9c6f8-2963-4ef3-95d5-e999a898269f";
        public const string Shirt_Conductor_Contest = "5154be09-bb8a-4917-95a0-51c91b6a4e09";
        public const string RedFlowerDress = "515dfc36-7f7b-47bc-abee-380d68f41be6";
        public const string Glasses_Smuggler = "529015c7-3b4a-4a73-b2c3-33103339b6e3";
        public const string Wrist_80sWindbreaker = "52VsI_lKlkSUAOJlfDnyrQ";
        public const string Shirt_GalaxyHoodie = "5362d685-fc55-4b43-85a5-cc3d6cad3f69";
        public const string Shirt_Scuba = "57552652-d902-43b7-a68e-5c7da87582bc";
        public const string Wrist_FighterPilot = "5800d2b5-75b8-442f-8b10-63bd3d73a1b8";
        public const string Neck_Doctor = "587ca2bb-dd42-42bf-833f-4e2a97349866";
        public const string Hat_SpaceMarineHelmet = "59d9560d-e5af-4205-b860-3afea1cc31a9";
        public const string Hat_FootBall = "5a38f864-7d1c-4989-8558-40b9668f78ef";
        public const string Hat_Doctor = "5ac25e5a-8c8e-445c-82a4-7272baec1eb5";
        public const string CowboyScarf = "5accb7dc-90a3-46ee-bad2-8fd1861d50f1";
        public const string Wrist_Archer_Glove = "5b01eaa3-0cac-40c0-b72a-b3f6a868ae0c";
        public const string Neck_Scuba = "5b3dc472-773e-4714-a9d0-7e7bbf6bc695";
        public const string ArcherQuiver = "5b6535f0-86cd-417a-bcce-a1ace9a5f260";
        public const string Hat_Sherlock = "5bde836f-9343-4934-b01a-606f707020ef";
        public const string Neck_MaleCheerSash = "5cd08cfb-c729-4c30-96d9-6a99bb934d91";
        public const string TiedScarf = "5d1c42a0-7e36-431a-8e78-a8b74046d153";
        public const string Hat_FlatCap = "5e3929d3-d291-4e91-a0ba-2ef203e407d3";
        public const string Neck_NecklaceGold = "5e9bbda6-d681-42b1-9cc4-5758acf34bc0";
        public const string Wrist_Zombie = "5f1bc3c2-dfbb-4258-9b10-608535e34db2";
        public const string Jazzercise = "5f492f8f-ab61-484a-9587-747132b54309";
        public const string Shirt_Flapper = "5f600892-aa67-484a-afc7-14c219d89c52";
        public const string Eye_SkiBuddy = "5fwjFQoC_Uu9ChvF6uNGZw";
        public const string Shirt_FigureSkaterDress = "5PUja-WX00Sme9yBwvDq-g";
        public const string Neck_FemaleCheerSash = "60067e91-18b8-43ab-ae20-a8ea74c757bf";
        public const string Beard_Lumberjack = "61ba3c90-c81e-4deb-bc79-50c0f1fe3e83";
        public const string BlueJacket = "62ce4109-8dee-4895-bf1b-bfa143db4c7e";
        public const string Glasses_Sun = "6427bd57-fcb2-420f-8b3e-d1da43470b84";
        public const string Wrist_PaintballGlove = "64ad8789-1645-45f7-819a-a413ff7c9622";
        public const string FemaleCheerTorso = "657efe89-620a-46a2-8b58-cafd855c7cd5";
        public const string Shirt_Scallywag = "664485e9-a159-4fcb-b32c-2b114b4a1218";
        public const string Hat_Green_Sequin_HeadBackBow = "66f8f55d-cad4-4afb-93e8-b6bdf04b37b3";
        public const string LuchadorCape = "67117b3d-0669-4cf3-8a4f-066cabd4d8b1";
        public const string Shirt_Bishop = "6930ce13-4be4-4ab9-9817-667bd261ffc3";
        public const string Wrist_Skeleton_FingerlessGlove = "6a98bbb6-bbe0-4dc3-97a9-e253dc506a2b";
        public const string Mouth_CurlyMustache = "6b337a35-95d9-4b3a-9891-d9fbb06262aa";
        public const string LongScarf = "6b9e022c-0b68-48fd-8eca-da8573c18900";
        public const string Hat_WitchHunter = "6d36091e-7083-4e3d-8729-94612602c8cb";
        public const string WristBand_Team = "6d48c545-22bb-46c1-a29d-0a38af387143";
        public const string OrangeCollarDress = "6d815b35-6f68-4ed4-817d-70f141e1a571";
        public const string Neck_Bowtie_Gold_Sequin = "6dd261d8-9806-4dac-81c4-a58f6d6a7f9a";
        public const string Hat_SkiBuddy = "6QT99hx6DE6t9cKAs61i3w";
        public const string Shirt_SkiBuddy = "6RhwWExXekaYpK0NGHSXGQ";
        public const string Hat_Sun = "703f1987-2b31-4b6f-bab7-1939b1105ac0";
        public const string Hat_Bike = "71014872-d879-4858-9d68-58da3c673d8b";
        public const string Hat_LacrosseHelmet = "7134c60b-0640-463a-8d97-caa9184bef93";
        public const string Wrist_WristTape = "71921831-ba6f-408b-a00e-2fd97663636f";
        public const string Hat_BunnyEars = "71fd5353-b439-4a23-b471-bfb99b8154d7";
        public const string Shirt_KnightTorso = "739fd42a-8a8c-44a5-afa3-e0974802c6ae";
        public const string Dress_FormalDress_RedSequin = "73a119ab-d2c8-4da9-98b2-29edbb38e2c2";
        public const string Dress_FormalDress_SilverSequin = "73c0e2ba-cba1-482a-89d5-1508997aceeb";
        public const string Wrist_SafariGlove = "74365234-cb72-409d-8cf5-9a7209f707e1";
        public const string PurpleJacket = "745c5110-104e-4b37-aabf-7c690fd54811";
        public const string Shirt_Tennis = "74b91f2b-d4d3-4e41-8946-b1296ab7a773";
        public const string Shirt_MartyRecFly = "74c65554-0d15-409b-b9a8-0b2620a7d7e2";
        public const string PartyBand = "74e6878f-94e0-41f2-93ea-de6412238385";
        public const string Mouth_BeardFarmer = "7553d851-1986-4325-870d-e425dfb7d007";
        public const string Belt_PoolFloatie = "75-HXZBOAEiDBqclnOn8YQ";
        public const string Hat_Mobster = "76369aef-aeda-46d2-996a-cd00594d0543";
        public const string FurCoat = "77c37481-a185-47ff-af55-65f9fdfcf9e5";
        public const string Hair_Spiky = "77d3c585-4928-4471-a425-89036efe7299";
        public const string Hair_PigTails = "79b90274-6eec-4664-acfb-4a123334661e";
        public const string Wrist_BikeGlove = "7a6fe0e6-f930-4fb8-9b2f-4c857a273dd9";
        public const string Jersey_Dev = "7a730848-ab20-445d-b416-1a72cab49324";
        public const string Hat_Aviator = "7a7d8a06-7982-4bcb-b7bd-4d03b48889b4";
        public const string Shirt_Jersey = "7b857a8c-92ad-4028-a2c2-b3c20cdab5f2";
        public const string Neck_Pearls = "7be2eafc-21ea-4266-ae64-8888c06798d6";
        public const string Hat_ScoutRaccoon = "7c1552a6-bc36-46e6-884c-1de6b8111a92";
        public const string Eye_MirroredGlasses = "7db6b49f-3e2a-4da8-bdfa-e9ad9ebc5ba6";
        public const string Hat_TopHat_Contest = "7dc6c916-b887-4929-93b5-dcea3022e6a9";
        public const string Hair_WavyShort = "7dd6f7b0-7ba0-429f-a04f-e32d3a79ee61";
        public const string Shirt_Turtleneck = "7e22a4bd-3e87-4d50-8843-9e2e3cf45285";
        public const string Shirt_Witch = "7LSm-xCYakmgcAr--Fn-JA";
        public const string Shirt_BrideofFrank = "7VQvz9sbzUWvGalxd9rISg";
        public const string Hat_Construction = "8263a9ca-8c57-4e81-b3e3-24f2ca19a70a";
        public const string Bowtie = "83be5ba4-525a-4781-a5f6-839c22e4d1d3";
        public const string BikeJacket = "843e3364-a743-4dfc-a990-0436e47b8c10";
        public const string PinkStollDress = "84cd594c-1cd8-4b4d-8409-85c8fd5fb02a";
        public const string Neck_GreenSequin_Bowtie = "86af3a97-18d8-4dda-a2f2-cfd3b4224254";
        public const string Neck_NewYearsSash = "86dd9ff9-643f-4f11-8243-93ad948db4cc";
        public const string Eye_MirrorShades_PinkGreen = "87792b6e-1468-45e1-b28c-83f27ada7299";
        public const string Hair_Bob = "880a3cc0-7407-4b61-b759-f9dd890fe9e5";
        public const string Wrist_AstronautGlove = "88739d79-aeb9-471a-b25b-776f46bba9f6";
        public const string EquestrianJacket = "896c2491-2f96-4986-9cbd-b3b31ef5d8c5";
        public const string Hat_Squid = "899f1d17-eee1-4b7d-a112-fbbba597e738";
        public const string FemaleTShirt = "8aa79563-ace1-4ba7-ad0c-f3210a78142f";
        public const string Shirt_TruckerJacket = "8b065e2a-b106-4f11-b415-4c47ce87993e";
        public const string Hair_PulpFiction = "8b9f1413-e786-4a30-946c-9292f207875a";
        public const string Hat_Visor = "8c51fc1a-b1ad-4002-a13c-4313abd92c7f";
        public const string Beard_Close = "8d10cc78-6b00-45f3-affb-205e9cc5b03f";
        public const string Hat_Scallywag = "8d17031a-c0a5-4145-92b7-1f0c2d8f0ce6";
        public const string Hat_Hockey = "8d703940-224a-4b0c-a04d-f365550071e1";
        public const string Neck_DeepSeaDiver = "8d97303c-5138-4da1-a74d-378da19d11cb";
        public const string Hat_NewYearsHat = "8df990d9-141a-4757-b4f2-138d5e68ab74";
        public const string Wrist_Conductor = "8fc7aaef-adec-4534-8f91-445e4e7095d5";
        public const string MaleCheerTorso = "9073d6a0-3bc1-4c82-aeb3-d4ee195538b4";
        public const string Hat_Zombie = "9168b3f9-c7e5-40b6-bb2c-9e708596e675";
        public const string Hair_Part = "92302d9d-c527-418c-ac5d-1fa869727505";
        public const string Wrist_Soccer = "94eb7ef3-528f-4f59-92a0-48b0ec287527";
        public const string Hair_GordonGekko = "95ab7a7c-c35d-4da5-9955-0921064470b6";
        public const string Shirt_Farmer = "967187b8-df20-4f4f-b48f-10b9ea75cedf";
        public const string Hat_Beekeeper = "96bc2f9f-ce3a-4c4c-b92c-cfed4ed4594f";
        public const string Wrist_TruckerJacket = "973d84ee-5b88-475c-b579-a76c34a7c533";
        public const string Eye_MirrorShades_Red = "973dc863-b9a5-40d8-8f15-4096e75bd2cb";
        public const string Shirt_Wizard = "97eae086-cfea-45ff-9b77-1d184256d493";
        public const string Neck_Bowtie_Silver_Sequin = "988e4069-4341-428b-bbf5-023309891385";
        public const string Dress_FormalDress_GoldSequin = "9a366f8b-ea5b-49ae-a98c-f6b282e9bf14";
        public const string Hat_Turkey = "9b5406c4-8589-47e4-9f69-4fa4733615e7";
        public const string Mouth_GoateeThick = "9bf5d259-7774-4cbe-a90f-7f188cc0dce7";
        public const string Wrist_Knight_Gauntlet = "9bf9d502-8a3c-4b24-9565-0a2c2d9864fd";
        public const string Eye_Scuba = "9c28e450-8e12-455c-a4c8-c0a2160d4190";
        public const string LuchadorTorso = "9c34c2c1-07d7-4180-94a2-be8c9caaae84";
        public const string ButtonTop = "9c8fc7f0-8f99-4aad-a34f-8d979f6ae352";
        public const string Hat_SmallBrim = "9cdb4965-6f00-4304-afed-e301e73a2b3a";
        public const string Hat_QueenCrown = "9d395a84-4342-4b1c-940c-213ec2eb56f9";
        public const string Wrist_ScientistGlove = "9d68e9f4-6ea0-4717-bb78-f2783a14a6b6";
        public const string Hair_MeatballBuns = "9d9fadb6-97eb-480e-a224-4e0179082071";
        public const string Shirt_Raincoat = "9e6397dd-b7b0-4d32-8c86-1910106a8478";
        public const string Wrist_CowboyGlove = "9eb7f505-5afd-4b28-9886-7996d38c59c6";
        public const string Shirt_FigureSkaterCollar = "9o0gWLJjREG552gxRreT8A";
        public const string Hair_Undercut = "a12f724f-4a73-4ab8-aad4-6bfc662b4dd6";
        public const string Hat_Cloche = "a16d59da-caa5-4388-af67-315bfcb16f64";
        public const string YellowPoofyDress = "a302741d-313b-4682-82e5-ac76764e662c";
        public const string neck_royalCape = "a44766dc-19ad-4476-849c-5113a5faabd0";
        public const string Eye_MirrorShades = "a4c26527-8f75-44da-b150-7aaf8ef739c1";
        public const string Hat_DiscoBall = "a5b747b8-c1a5-4bce-999f-e13dbe77bde6";
        public const string Hat_Hibiscus = "a61e86cd-f7e7-4ac7-a6e8-df269bc5cb01";
        public const string Hat_Equestrian = "a628d62c-fa30-4405-bcbc-3e646e3a3434";
        public const string Hair_BaldTop = "a6cbfe76-534a-4655-a8a8-3fed13d001c7";
        public const string Shirt_DrumMajor = "a6f1825e-1647-4d06-85d7-ac2d139612c0";
        public const string Shirt_ScoutNeckerchief = "a96e168c-0c4d-4c70-9f8a-c8f07164ce99";
        public const string FieldHockey = "a986ff33-9e16-4219-8ebb-2e7b4c772ca7";
        public const string Shirt_Peacoat = "ab15ef15-a97c-4ab1-896b-bd4d7e1cd9f5";
        public const string Wrist_BishopGlove = "abc25091-ed5f-4c72-9364-fffeef1bc239";
        public const string Hat_AntlerHeadband = "AbYdU7O_9U-Lwg7zFVZzXQ";
        public const string Hat_Cowboy = "ad0bdec5-f767-42e7-99e0-221473464a85";
        public const string Hat_Chef = "af33bdb1-b7fa-4fe6-b37a-b1fe6a420879";
        public const string Shirt_80sWindbreaker = "AIpF1QUeMUWytpHYBDBAkg";
        public const string Hat_Headphones_Gold = "akAhnN0cFkecj8q3spixkw";
        public const string Shirt_TutorialGown_1 = "ASHnWS0h9kOJhbOUwxWKFQ";
        public const string Belt_PoolFloatie_AnimalHead = "awOFE0_GSECr8GBNBo6a_w";
        public const string BlackCheerDress = "b02053b3-013f-42b0-8881-85f5be2b8cda";
        public const string Shirt_TruckerOveralls = "b080e2f4-c699-4cca-bb9e-7cfc4bafcbfc";
        public const string Hair_ChunkyAfro = "b148cb1e-df81-442f-aea6-ab1727aad00e";
        public const string Shirt_Angler = "b1bfe0b4-1ff6-420f-acfc-2331d34246dc";
        public const string Wrist_DeepSeaDiver = "b1c3ccc8-91d7-434e-b9cc-bd632fffc01b";
        public const string Jersey_Team = "b33dbeee-5bdd-443d-aa6a-761248054e08";
        public const string Hat_Lumberjack = "b537c30c-faef-4649-9a1f-be3985936f93";
        public const string Shirt_Soccer = "b6610b7b-3978-46fd-9af6-41b4568c9b4d";
        public const string Shirt_Hoodie = "b6rLwzD4NkKV7xKn9ZYVkA";
        public const string Neck_StringLights = "b795c631-f075-4d32-ac87-c732b36cb932";
        public const string Hair_Bishop = "b861e5f3-fc6d-43b3-9861-c1b45cb493a8";
        public const string Glasses_SciFiVisor = "b89be768-a169-4b24-8022-751e7b817865";
        public const string Wrist_Boxing_Glove = "b904304b-cce0-466f-8569-c621eeadd4f7";
        public const string Neck_NecklaceSilver = "b95678aa-351a-4929-8a0e-0274a183eb18";
        public const string Hat_BoxingHelmet = "b99a89c7-38c5-4196-9862-4e1bf9cb0ce1";
        public const string Neck_WinterCloak = "b9d08f9a-b23d-4d7e-978b-a0cd8adbfe9c";
        public const string Wrist_Scallywag_Bracelet = "b9e0f03b-2609-4911-82e9-1e324dbbe8be";
        public const string CowboyTorso = "ba84b23e-01ee-4668-a7ef-2e3e0eca2f23";
        public const string Hat_Firefighter = "bb54e0e9-5d90-41f3-94c0-8e82f1791af1";
        public const string Shirt_Bee = "bb8602d4-f91f-4e35-9c88-1cdf3a04ff0a";
        public const string Hat_InternationalThiefHat = "bc3f8ab4-cdb1-4e63-bda5-ba5a4b1f4a43";
        public const string Eye_RoundGlasses = "bc7299ac-be2b-404f-b8e6-402e2c0660f0";
        public const string GoldMedal = "bf13fa1c-f991-4aaa-9402-aac109be9562";
        public const string Neck_ScoutSash = "bf9dc196-5727-4752-8126-7ad5fcd96d55";
        public const string Hat_Bowler = "bfd9c70b-9ad8-4f47-a840-c03231f9ad41";
        public const string Hair_FemaleCheerleader = "BJ2XrGvl40iIl28IbTfbKg";
        public const string Neck_QpidQuiver = "BqpRbr_T1kO_YJqB1787kA";
        public const string Wrist_Thriller = "BR0mZKsKaE-t4R8CzEwuyg";
        public const string Hat_80sShutterShades = "bu9tb-K7NEiocvZY3o7ukw";
        public const string Shirt_Archer = "c0e59f27-a13d-4bd9-b3b8-a38a360f649b";
        public const string SeaCaptainBeard = "c161dc73-6ce3-49c4-8d15-45e6911f84e4";
        public const string Shirt_DeepSeaDiver = "c3745cee-d87e-4a23-b6e2-64ebf05c8b11";
        public const string Hair_ManPony = "c45ed7b8-99bd-4a4b-a9ff-e16edf5d7a18";
        public const string Shirt_Letterman = "C4uuztTiYUe20PACMARksA";
        public const string Neck_ButterflyWings_Monarch = "c506feae-be73-437b-b18a-1152bb9906e9";
        public const string BusinessTie = "c6c08eb5-381a-4193-9722-80da95d62abe";
        public const string Glasses_Red = "c70005d5-6276-4a98-acb3-6a77bc19379a";
        public const string Hair_DutchBraid = "c855dcc3-96cb-470d-b159-d37a025a47d1";
        public const string Hat_Viking = "c87239ca-a255-4b13-bbc5-1b38236fb4cc";
        public const string Hair_Malibu = "c8a97aeb-e8dc-40ba-b6bc-a7c7be907381";
        public const string Shirt_Harness = "ca7a3ccb-2bc9-4c93-a6a8-6f22b38526af";
        public const string Eye_TouristGlasses = "cbN5e-t_jEKa4hzir5JAxQ";
        public const string Beard_Thick = "cc96f8a5-bc5b-4f89-83b7-ecd53905ada7";
        public const string CowboyStache = "cca7ab3d-5609-4700-92fd-3280fcea9b77";
        public const string Eye_SteampunkFemmeSpex = "CdeM6RJmPUumXtdmdM3RXA";
        public const string Hair_Punk = "ce250e13-8137-4f62-9e52-2b1cebe7d0ad";
        public const string Wrist_Barbershop = "ce81210f-8eb8-4cd2-95d5-046d4da229c8";
        public const string Hat_Farmer = "cea5c141-32d8-4dae-80d9-6fb74834a79c";
        public const string Hat_Froggyheadband = "cec9cfac-a45b-4edb-b26d-7453cc2bfaf2";
        public const string Shirt_Bowling = "CQuKKNpan0O7rhR1fr14-Q";
        public const string Hair_RecedingHairline = "CTcrvbo3OEepIV4oW8bx4w";
        public const string MaleTShirt = "d0a9262f-5504-46a7-bb10-7507503db58e";
        public const string Hat_Archer = "d2d3264b-fbf6-40b5-9f10-c85ec737d112";
        public const string Hat_GreenVelvet_TopHat = "d3b8bd7b-ca9a-4f5d-b115-3659dc294a03";
        public const string Shirt_Dodgeball = "d3d69bee-60bc-44a3-ad7c-65b3b69d1e59";
        public const string Eye_MirrorShades_PinkClear = "d57cf97e-b5d2-4e47-8231-a226a161f6e3";
        public const string HockeyShirt = "d6b0a1e7-e918-43e5-8191-3a8d9d01df7c";
        public const string TrackSuit = "d766c8d3-76e8-4021-b0a4-24b78fb7eaba";
        public const string Hair_Rhianna = "d8280c0c-d803-4513-be10-a0ba96d8821e";
        public const string Hair_GiantAfro = "d84c0ff9-8fbe-4ed8-abf3-7996e81888ab";
        public const string Shirt_SeaCaptain_Contest = "d86e2e65-5d87-466d-b885-8c52ac2eeeb0";
        public const string PaintballVest = "d8f408f0-78f5-4e8a-b42a-e7b09632d1fd";
        public const string Hat_Scarecrow = "d960b47d-f8bd-4c2e-813c-a6a09876ea18";
        public const string Hair_Buzz = "da4e7b34-2095-4a9e-801e-4f409039e0dd";
        public const string BabydollDress = "da55bfc3-47b7-46f6-b548-7fb2c2a5e0bf";
        public const string Hat_Barbershop = "dcf9012d-f9e9-4f15-872e-f130af3b2efa";
        public const string Blazer = "de0ac50d-2adb-4114-bd2e-68953b13d706";
        public const string Shirt_Zombie = "de19b239-3ed0-4f03-acb6-da69b5aa52ea";
        public const string Shirt_BogMonsterShirt = "dedd2e98-2721-4de6-92f2-9d399f34e8fe";
        public const string Shirt_Skeleton_Hoodie = "df0e06c4-8ba6-4d7a-bfb2-3759d8fe88c7";
        public const string Shirt_FuschiaMarine = "e042433a-40a2-4758-8074-3b9d407835ec";
        public const string shirt_royalLord = "e13f6558-d49c-4314-820c-962ef48eb0c6";
        public const string Neck_Winter = "e15b13a7-9e9a-4b32-ba2c-0cb31ed55a8c";
        public const string Eye_Pirate_Eyepatch = "e1a13235-e3b3-4b39-8e6f-e6449d4321b7";
        public const string Eye_MirrorShades_TealRed = "e2620c2c-c28e-45ce-a83c-0588329b9c81";
        public const string Hair_FauxHawk = "e286863c-2967-4d00-b837-b49487b9484a";
        public const string Hat_QpidLaurel = "e2ObiQFqCUOdKniKL9a1EA";
        public const string Hair_Bob_Bangs = "e36bcd98-7e85-43fa-89f8-57e4ec33823a";
        public const string WristBand_Team_Emissive = "e41c32ac-61b7-4e59-9d0e-b231ebdc2a68";
        public const string Hair_Mohawk = "e49d5d78-157e-4bc8-b878-ff7c4963fdc4";
        public const string Shirt_Punk = "e4ba395e-f291-4e7b-8193-45f4422f41ce";
        public const string Hair_WavyLong = "e5b83dfc-b2e1-4dcb-a4ab-9d3a4c8a34ae";
        public const string Shirt_Conductor = "e60fccda-8711-463d-b8a3-7cd5e76903b2";
        public const string Hat_Knight_Helmet = "e614df5d-3cfe-4bca-b9c2-30c267b9c94e";
        public const string Hat_JackfrostHair = "e6216087-fb37-46f1-bda4-a88c4640f339";
        public const string Shirt_Construction = "e9913b06-58cb-4b90-bd08-981a3f19f352";
        public const string Shirt_SteamPunk = "E9VTiIVFPEa-OuQRto0e_Q";
        public const string Wrist_Golfer = "eada710d-ea0c-473f-b9c6-23e210607b24";
        public const string Eye_MardiGrasEyes = "eb830b12-c1b5-4796-b9cf-ccf0f0e1d4f1";
        public const string Hair_DreadsLong = "eb9611c6-bb50-41a2-93e9-7f959815a846";
        public const string AstronautTorso = "ec5255d5-edaf-4888-9fe1-e89ac0e0d300";
        public const string Hat_FighterPilot = "ec836d2a-b1b8-4566-b8eb-123ae2845956";
        public const string Wrist_WristBand = "ecc1dbe6-ca06-4564-b2a6-30956194d1e9";
        public const string Wrist_PirateCaptain = "eceb7d49-be41-4228-86a9-2973d62e7135";
        public const string Belt_PaintballBelt = "eda29bce-5a07-4439-a2a7-cafa11e2ed62";
        public const string Hat_Bearhat = "ef7771eb-c5f3-44fd-8c27-f581b035ef10";
        public const string Hat_Beret = "ef84cb35-5e25-4aa6-82c9-17f01a5040c7";
        public const string Belt_PoolFloatie_BirdHead = "EJFGAW-TnUCaeD59parEHg";
        public const string Wrist_MagicalGirl = "eS_or4AnMka9M_bD7YN28g";
        public const string Hat_LettermanShades = "exQz9Zr3HEyOR9nDDrimlQ";
        public const string Hair_Scientist = "f17a2f9e-1eab-44e8-b10a-1f53c5d0778c";
        public const string Hat_AstronautHelmet = "f218e2de-46fd-45b9-9e0e-670b6bb905e7";
        public const string Hat_Ranger = "f277af6a-0807-4716-8948-1bee236ffb74";
        public const string FlowerSwimsuit = "f41653f9-ae02-443c-aaf4-1c6f4e49035d";
        public const string Neck_Safari = "f47f81e7-fcdd-4687-9b99-013147bef30f";
        public const string RedBeltDress = "f51a7ed5-52ea-485f-a430-303697f6fec9";
        public const string Glasses_Square = "f527ffaf-da03-4519-82ed-46a9cb981dc3";
        public const string Hat_SeaCaptain = "f5c9743f-e77c-42f2-ba63-9843342cbf8e";
        public const string Hat_ScoutGarrison = "f60e093f-33be-4527-b827-060adc77b1f4";
        public const string Eye_MirrorShades_YellowBlue = "f684d86f-4a75-4a9a-bc0a-cf58f36c91c5";
        public const string Dress_WaitressDress = "f6caeb89-dbb4-4471-92fe-100bf48cd5ce";
        public const string Shirt_Golfer = "f76b709c-b173-426e-81f2-279a67d2fde1";
        public const string Hair_UnderCutSheet = "f9dd08f8-16d3-4c39-af4f-89f7bb6e80d3";
        public const string Shirt_Ranger = "fb907eb2-91c8-45ff-84a5-462bb86ea7de";
        public const string Hair_JackFrostNoCrystalsHair = "fbdca48d-4ae6-41ad-8c33-b70a9e33fd77";
        public const string Neck_ButterflyWings = "fc96ea5d-b49b-479b-a963-92f1eab44b2c";
        public const string Hair_Bun = "fcfcaf63-deb4-45f7-b711-c051c9ea45cb";
        public const string Shirt_Scientist = "fe34adaf-47d3-435b-b2fd-b2fee05fceae";
        public const string Shirt_Boxer = "ff15e25d-d467-47a8-9ecc-e415d5acb90c";
        public const string Shirt_Chef = "ff5c62b3-4f41-4acd-bfd8-8db00de4f36c";
        public const string Shirt_FighterPilot = "ff7e6d41-5c27-4516-930c-ad0e9a23cce2";
        public const string Hair_LongBangs = "ffea7a65-613f-4835-921e-6dd15f357b7e";
        public const string Shirt_50sDressValentine = "FHKZvPFMLkO8iAIPPQzu1A";
        public const string Shirt_BowlingSweater = "GAWURQSqrEW4G5slrPMgZA";
        public const string Hat_SteamPunk = "gwLiwmqBIk6glFxvaTzxeA";
        public const string Neck_DraculaCape = "h_To9WQYdEusYQxlbMmMmQ";
        public const string Hat_MagicalGirl = "hT7nSD7Ts06F_1SNlOMLwg";
        public const string Shirt_Thriller = "hTHM3Kjqy0ykqBD8UCRQJw";
        public const string Shirt_SodaJerk = "iai6P7dDTUq8S4hqQmY1YA";
        public const string Neck_SteampunkSatchel = "iBQ-v6xaqkipUlfzkSHEeQ";
        public const string Wrist_IceQueen = "ilDgmey2ZUWlFiuEAN7YoQ";
        public const string Neck_TreasureHunterBelt = "ImwG0snB9ECc_gqRRBoz6A";
        public const string Hat_HeadbandTied = "J6IQt4G1zUeN8v9Wn50BUw";
        public const string Neck_VampireHunter = "jiBzrzDPkkuL6DqIFKpcCw";
        public const string Hat_HeadBackBow = "JTrfBXhIT02o2-ssP94zew";
        public const string Shirt_Tuxedo = "jUpFzO5MPEGTbS-E0a99Nw";
        public const string Hat_SteampunkFemme = "JWanxvOHyESg9F_HlmTOfA";
        public const string Shirt_VampireHunter = "JWfs9IiQs0Weu8MmyGpqLQ";
        public const string Eye_SquareWide = "kghEf_iMKUSxPO-h5iRhSQ";
        public const string Eye_SciFiVisor_Contest = "KNZ1DvCLC0WHyH4opYAXtw";
        public const string Hat_GraduationCap = "KPmC_wyX_ECe7fdKwoLMGg";
        public const string Shirt_SteampunkFemme = "LK8jt9zCuUGwLRccgOOvjA";
        public const string Hat_Mummy = "Lli8-aqt1EmCmyXwBRQaYA";
        public const string Shirt_GuardiansJacket = "m5Plrduzr0yj_9mTn1x3Vw";
        public const string Hat_TutorialCap = "M9weaekvIUimiJSVJqZl-w";
        public const string Hat_LaurelCrown = "mfFLpKQRE0anhrmeUvW0bA";
        public const string Shirt_MagicalGirl = "MJkDYDH510izAab13ZfXQw";
        public const string Shirt_TutorialGown_2 = "MJQiQ3LATEOymxCC8wfSjw";
        public const string Shirt_Biker = "n52um7A-b0utGxixd1ESvA";
        public const string Neck_TutorialSash_3 = "O8VqC11xNkSKpDh6Omp_0w";
        public const string Shirt_Mummy = "oRUh266ohkWQil14uxcEdQ";
        public const string Hat_Frankenstein = "OTnfT-4NQU6Gd_iVPDx8eg";
        public const string Neck_FannyPack = "oYvOo47DJE-DEPlpn5xNUw";
        public const string Neck_ShortFatNecktie = "pNOfTDOgJUGQvGAlTjBoCg";
        public const string Shirt_Suspenders = "pQqNvrhDJ0uuipKHA2qUOA";
        public const string shirt_QpidToga = "PryEX4MEvkGKwST6dqJHjA";
        public const string Wrist_Grillmaster = "q7pSsRMNHkqEJmYHuhhG6g";
        public const string Shirt_Countess = "QCtqxbvYOkan79YFugH_Cw";
        public const string Shirt_TreasureHunter = "QK6lBlX_wUCiSbJ9RkIwdA";
        public const string Wrist_SteamPunk = "qxovV6Vym0ufL2cTCyKjOQ";
        public const string Hat_TruckerHat = "ReqOfohe6UamzaiHG1x3Ow";
        public const string Shirt_Snorkeler = "rJ9zPPGdlk2i24sxLfkqng";
        public const string Hat_Witch = "s6mUIqiPCk6e57UYCx3SZA";
        public const string Hat_BrideofFrank = "sL7iHCnjyEuQKzrTvciEzQ";
        public const string Neck_SteamPunk = "sOREgAGs-06CeGGsG-WIkw";
        public const string Hat_TreasureHunter = "-SQLtL4rdEWTJdw2IroQCQ";
        public const string Neck_TreasureHunterBandolier = "t_66r_j5oUSh9awIPmdUKg";
        public const string Wrist_Countess = "t9co2516nkuJO4LIJA1bJA";
        public const string Eye_Clubmasters = "TcgHS_0aPkehrBg7ytMOMQ";
        public const string Shirt_TreasureHunterTank = "TjrFi6TFhUC5tQXWkZiK9A";
        public const string Wrist_Frankenstein = "tkbHKZ9wu0W00VGeUbIaaw";
        public const string Neck_Grillmaster = "tTKv7eRODka2KC_hsY2O3Q";
        public const string Mouth_VanDyke = "-twtjyBdQ02EAdOfBGTiEw";
        public const string Shirt_GraduationGown = "U_H976qYRUmg9e2clsAflg";
        public const string Hat_Headphones = "UcPo9SsF3EGTCBB2J-Efdw";
        public const string Belt_PoolFloatie_Unicorn = "UGkQa4atNUe1cE5TN79s4Q";
        public const string Neck_DraculaMedal = "uubY_Cn9A0-Ww4lsIRCF6w";
        public const string Shirt_Tourist = "vDSlMnayzEqWXwT-lkcKSA";
        public const string Neck_TutorialSash_2 = "vP9EKTMXP0yni8U7uCz2-g";
        public const string Hat_CowboyHairy = "vpP2ZvnL0Uy3n-I_Jv3eeQ";
        public const string Hat_BikerHelmet = "VQnoLstCyEGDPy1c38-GvA";
        public const string Hat_IceQueen = "W7AJ4UYlVkWF5nLbmpmRBg";
        public const string Hat_SodaJerk = "Wua43ED71UqL71ATtyS0iQ";
        public const string Neck_MagicalGirl = "WuShlrJnHUKuscn8e6Rt2g";
        public const string Wrist_Witch = "wy2cfgb8mUqjMrIOwHH2ew";
        public const string Wrist_Mummy = "zpjkkb1HtUORoPaODFuuxg";
        public const string Shirt_Frankenstein = "ZsggwOJ8XUOGfaJltM418g";

        #endregion

        #region Colors

        public const string BlackAndYellow = "5864d23d-1a86-40a6-a52c-46ee670e4508";
        public const string BlackAndWhite = "48abd952-214f-48b2-a8f1-1146f6f69aa2";
        public const string RedAndGreen = "bd4a84e2-b67a-4269-a26a-17fb23ddb09e";
        public const string BlackAndRed = "7221132e-053a-4c58-b719-ed3c8558907d";
        public const string Purple = "071d1bf3-86dc-4a31-b54a-e6579fab8649";
        public const string WhiteAndBlue = "ba6b6e1a-a09a-4ba0-9523-552869f03336";
        public const string BlackAndGold = "4398ce1a-e6ee-4da4-ad0d-7abfab41020c";
        public const string Pink = "cbe29e9f-f2ac-47fb-97e1-8bad16abb89d";
        public const string WhiteAndBlueBetter = "fcbdfbfd-254a-4538-b119-43e23404b8b5";
        public const string Golden = "bc4254be-60e0-4cc5-a233-6a0bd4137118";

        #endregion
    }

    public class Avatar
    {
        [ServerAPI.GET("/api/avatar/v2")]
        [ServerAPI.UseAuthorization]
        public AvatarDTO? ReturnAvatar(MongoDB.User user)
        {
            return user.OtherData.Avatar;
        }

        [ServerAPI.GET("/api/avatar/v4/items")]
        [ServerAPI.UseAuthorization]
        public List<UnlockedAvatarItem>? ReturnAvatarItems(MongoDB.User user)
        {
            return [
                new() { AvatarItemDesc = $"{AvatarHelper.Hair_AngledBob},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Angled Bob", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Hat_Wizard},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Wizard", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Shirt_Artist},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Artist", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Neck_JackFrostWings},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Jack Frost Wings", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Eye_SafariMonocle},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Safari Monocle", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.shirt_sherlock},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "sherlock", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Hat_Angler},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Angler", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Neck_Tie_Gold_Sequin},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Sequin", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Glasses_Pointy},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Pointy", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Hat_Conductor},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Conductor", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Hair_Fonzie},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Fonzie", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Wrist_Mobster},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Mobster", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Hair_FlatTop},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Flat Top", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Shirt_InternationalThiefShirt},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "International Thief Shirt", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Shirt_Quiltedcoat},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Quiltedcoat", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.shirt_royalLady},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "royal Lady", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.SeaCaptainTorso},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Sea Captain Torso", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Hat_PB_TruckerHat},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Trucker Hat", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Neck_TieSequin},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Tie Sequin", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Hat_Tourist},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Tourist", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Shirt_TutorialGown_3},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "TutorialGown 3", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Hat_TopHat},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Top Hat", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Shirt_Safari},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Safari", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Shirt_JackFrost},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Jack Frost", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Glasses_Scientist},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Scientist", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Hat_LaserTag},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Laser Tag", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Wrist_Aviator},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Aviator", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Hat_Shark},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Shark", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Hat_Baseball},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Baseball", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Hat_Luchador},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Luchador", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Shirt_80sSpandex},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "80s Spandex", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Eye_SciFiVisor_Glow},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Glow", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Hat_ArtistBeret},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Artist Beret", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Shirt_Barbershop},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Barbershop", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Hat_FlapperHeadband},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Flapper Headband", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Hair_Emo},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Emo", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Wrist_WitchHunterGlove},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Witch Hunter Glove", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Hat_DrumMajor},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Drum Major", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Hair_Shagg},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Shagg", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.FirefighterTorso},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Firefighter Torso", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Wrist_HarnessGloves},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Harness Gloves", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Hair_Afro},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Afro", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Hat_Bow},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Bow", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Shirt_Beekeeper},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Beekeeper", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Shirt_Scarecrow},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Scarecrow", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Hair_Ponytail},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Ponytail", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Belt_WaitressApron},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Waitress Apron", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Hat_BogMonsterHat},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Bog Monster Hat", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Hair_Lori},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Lori", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.TennisSkirt},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Tennis Skirt", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.YellowBlueDress},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Yellow Blue Dress", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Wrist_Wizard},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Wizard", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Eye_Snorkeler_Goggles},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Goggles", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Hair_HalfUp},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Half Up", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Hair_ManBun},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Man Bun", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Jersey_Team_Emissive},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Emissive", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Hat_Winter},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Winter", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Shirt_LaserTag},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Laser Tag", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Shirt_Smuggler},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Smuggler", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Hat_Saija_Helmet},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Helmet", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Hat_Bee},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Bee", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Neck_ButterflyWings_TheBlueOne},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "The Blue One", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Mouth_WizardBeard},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Wizard Beard", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Shirt_Doctor},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Doctor", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Wrist_Punk},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Punk", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Eye_Skeleton_Mask},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Mask", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Hat_BaseballHelmet},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Baseball Helmet", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Hat_Flowers},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Flowers", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Hair_Mullet},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Mullet", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Hat_Rainhat},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Rainhat", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Eye_2020Glasses},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "2020 Glasses", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Shirt_Saija},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Saija", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Hat_Unicorn},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Unicorn", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Hair_PunkGirl},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Punk Girl", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Wrist_Letterman},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Letterman", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.CollarShirt},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Collar Shirt", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.KnightCape},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Knight Cape", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.BaseballTorso},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Baseball Torso", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Hat_Golfer},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Golfer", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Dress_FormalDress},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Formal Dress", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Wrist_LaserTagGlove},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Laser Tag Glove", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Glasses_Paintball},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Paintball", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Hat_Electrician},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Electrician", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Basketball_Tee},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Tee", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.FootBallShoulderPads},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Foot Ball Shoulder Pads", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Shirt_Lumberjack},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Lumberjack", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Shirt_ScoutSkirt},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Scout Skirt", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Shirt_Winter},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Winter", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Neck_Bee},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Bee", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Neck_PirateCaptain},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Pirate Captain", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Shirt_Lacrosse},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Lacrosse", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Wrist_Winter},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Winter", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Neck_Scallywag_Belt},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Belt", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Shirt_PirateCaptain},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Pirate Captain", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Wrist_ConstructionGlove},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Construction Glove", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Wrist_Scarecrow},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Scarecrow", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Hat_CatEars},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Cat Ears", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Shirt_Vest},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Vest", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Shirt_Electrician},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Electrician", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Wrist_Smuggler},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Smuggler", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Hat_PirateCaptain},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Pirate Captain", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.CopStache},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Cop Stache", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Shirt_SleevelessDenimJacket},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Sleeveless Denim Jacket", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Shirt_IceQueenGown},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Ice Queen Gown", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Wrist_Beekeeper},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Beekeeper", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Hat_HeadBand},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Head Band", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.hat_royalCrown},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "royal Crown", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Shirt_WitchHunter},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Witch Hunter", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Hat_Safari},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Safari", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Shirt_Aviator},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Aviator", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Shirt_Mobster},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Mobster", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Eye_MardiGrasEyes2},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Mardi Gras Eyes2", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Shirt_50sDress},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "50s Dress", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Hat_HarnessHelmet},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Harness Helmet", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Hair_Pompadour},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Pompadour", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.SeventiesStache},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Seventies Stache", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Wrist_FlapperGlove},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Flapper Glove", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Hat_BaseBall_FlatBill},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Flat Bill", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Eye_AviatorGoggles},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Aviator Goggles", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Wrist_SpaceMarineGlove},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Space Marine Glove", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Hair_Jazzercise},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Jazzercise", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Hat_DinoHat},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Dino Hat", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Shirt_SpaceMarine},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Space Marine", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.FemaleTank},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Female Tank", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Wrist_DrumMajor_Glove},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Glove", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Wrist_BogMonsterWrist},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Bog Monster Wrist", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Hat_DeepSeaDiver},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Deep Sea Diver", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Wrist_Saija_Glove},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Glove", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Shirt_Conductor_Contest},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Contest", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.RedFlowerDress},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Red Flower Dress", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Glasses_Smuggler},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Smuggler", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Wrist_80sWindbreaker},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "80s Windbreaker", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Shirt_GalaxyHoodie},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Galaxy Hoodie", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Shirt_Scuba},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Scuba", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Wrist_FighterPilot},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Fighter Pilot", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Neck_Doctor},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Doctor", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Hat_SpaceMarineHelmet},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Space Marine Helmet", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Hat_FootBall},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Foot Ball", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Hat_Doctor},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Doctor", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.CowboyScarf},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Cowboy Scarf", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Wrist_Archer_Glove},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Glove", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Neck_Scuba},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Scuba", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.ArcherQuiver},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Archer Quiver", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Hat_Sherlock},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Sherlock", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Neck_MaleCheerSash},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Male Cheer Sash", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.TiedScarf},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Tied Scarf", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Hat_FlatCap},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Flat Cap", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Neck_NecklaceGold},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Necklace Gold", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Wrist_Zombie},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Zombie", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Jazzercise},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Jazzercise", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Shirt_Flapper},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Flapper", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Eye_SkiBuddy},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Ski Buddy", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Shirt_FigureSkaterDress},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Figure Skater Dress", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Neck_FemaleCheerSash},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Female Cheer Sash", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Beard_Lumberjack},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Lumberjack", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.BlueJacket},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Blue Jacket", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Glasses_Sun},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Sun", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Wrist_PaintballGlove},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Paintball Glove", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.FemaleCheerTorso},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Female Cheer Torso", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Shirt_Scallywag},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Scallywag", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Hat_Green_Sequin_HeadBackBow},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Head Back Bow", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.LuchadorCape},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Luchador Cape", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Shirt_Bishop},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Bishop", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Wrist_Skeleton_FingerlessGlove},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Fingerless Glove", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Mouth_CurlyMustache},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Curly Mustache", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.LongScarf},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Long Scarf", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Hat_WitchHunter},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Witch Hunter", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.WristBand_Team},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Team", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.OrangeCollarDress},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Orange Collar Dress", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Neck_Bowtie_Gold_Sequin},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Sequin", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Hat_SkiBuddy},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Ski Buddy", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Shirt_SkiBuddy},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Ski Buddy", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Hat_Sun},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Sun", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Hat_Bike},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Bike", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Hat_LacrosseHelmet},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Lacrosse Helmet", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Wrist_WristTape},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Wrist Tape", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Hat_BunnyEars},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Bunny Ears", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Shirt_KnightTorso},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Knight Torso", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Dress_FormalDress_RedSequin},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Red Sequin", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Dress_FormalDress_SilverSequin},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Silver Sequin", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Wrist_SafariGlove},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Safari Glove", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.PurpleJacket},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Purple Jacket", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Shirt_Tennis},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Tennis", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Shirt_MartyRecFly},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Marty Rec Fly", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.PartyBand},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Party Band", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Mouth_BeardFarmer},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Beard Farmer", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Belt_PoolFloatie},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Pool Floatie", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Hat_Mobster},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Mobster", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.FurCoat},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Fur Coat", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Hair_Spiky},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Spiky", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Hair_PigTails},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Pig Tails", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Wrist_BikeGlove},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Bike Glove", Rarity = GiftRarity.Common, Tooltip = "" },
               // new() { AvatarItemDesc = $"{AvatarHelper.Jersey_Dev},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Dev", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Hat_Aviator},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Aviator", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Shirt_Jersey},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Jersey", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Neck_Pearls},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Pearls", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Hat_ScoutRaccoon},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Scout Raccoon", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Eye_MirroredGlasses},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Mirrored Glasses", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Hat_TopHat_Contest},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Contest", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Hair_WavyShort},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Wavy Short", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Shirt_Turtleneck},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Turtleneck", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Shirt_Witch},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Witch", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Shirt_BrideofFrank},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Brideof Frank", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Hat_Construction},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Construction", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Bowtie},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Bowtie", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.BikeJacket},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Bike Jacket", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.PinkStollDress},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Pink Stoll Dress", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Neck_GreenSequin_Bowtie},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Bowtie", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Neck_NewYearsSash},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "New Years Sash", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Eye_MirrorShades_PinkGreen},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Pink Green", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Hair_Bob},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Bob", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Wrist_AstronautGlove},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Astronaut Glove", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.EquestrianJacket},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Equestrian Jacket", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Hat_Squid},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Squid", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.FemaleTShirt},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Female T Shirt", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Shirt_TruckerJacket},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Trucker Jacket", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Hair_PulpFiction},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Pulp Fiction", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Hat_Visor},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Visor", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Beard_Close},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Close", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Hat_Scallywag},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Scallywag", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Hat_Hockey},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Hockey", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Neck_DeepSeaDiver},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Deep Sea Diver", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Hat_NewYearsHat},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "New Years Hat", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Wrist_Conductor},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Conductor", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.MaleCheerTorso},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Male Cheer Torso", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Hat_Zombie},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Zombie", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Hair_Part},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Part", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Wrist_Soccer},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Soccer", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Hair_GordonGekko},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Gordon Gekko", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Shirt_Farmer},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Farmer", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Hat_Beekeeper},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Beekeeper", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Wrist_TruckerJacket},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Trucker Jacket", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Eye_MirrorShades_Red},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Red", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Shirt_Wizard},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Wizard", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Neck_Bowtie_Silver_Sequin},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Sequin", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Dress_FormalDress_GoldSequin},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Gold Sequin", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Hat_Turkey},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Turkey", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Mouth_GoateeThick},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Goatee Thick", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Wrist_Knight_Gauntlet},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Gauntlet", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Eye_Scuba},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Scuba", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.LuchadorTorso},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Luchador Torso", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.ButtonTop},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Button Top", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Hat_SmallBrim},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Small Brim", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Hat_QueenCrown},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Queen Crown", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Wrist_ScientistGlove},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Scientist Glove", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Hair_MeatballBuns},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Meatball Buns", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Shirt_Raincoat},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Raincoat", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Wrist_CowboyGlove},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Cowboy Glove", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Shirt_FigureSkaterCollar},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Figure Skater Collar", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Hair_Undercut},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Undercut", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Hat_Cloche},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Cloche", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.YellowPoofyDress},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Yellow Poofy Dress", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.neck_royalCape},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "royal Cape", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Eye_MirrorShades},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Mirror Shades", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Hat_DiscoBall},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Disco Ball", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Hat_Hibiscus},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Hibiscus", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Hat_Equestrian},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Equestrian", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Hair_BaldTop},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Bald Top", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Shirt_DrumMajor},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Drum Major", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Shirt_ScoutNeckerchief},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Scout Neckerchief", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.FieldHockey},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Field Hockey", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Shirt_Peacoat},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Peacoat", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Wrist_BishopGlove},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Bishop Glove", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Hat_AntlerHeadband},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Antler Headband", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Hat_Cowboy},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Cowboy", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Hat_Chef},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Chef", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Shirt_80sWindbreaker},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "80s Windbreaker", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Hat_Headphones_Gold},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Gold", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Shirt_TutorialGown_1},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Tutorial Gown 1", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Belt_PoolFloatie_AnimalHead},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Animal Head", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.BlackCheerDress},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Black Cheer Dress", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Shirt_TruckerOveralls},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Trucker Overalls", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Hair_ChunkyAfro},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Chunky Afro", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Shirt_Angler},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Angler", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Wrist_DeepSeaDiver},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Deep Sea Diver", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Jersey_Team},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Team", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Hat_Lumberjack},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Lumberjack", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Shirt_Soccer},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Soccer", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Shirt_Hoodie},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Hoodie", Rarity = GiftRarity.Epic, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Shirt_Hoodie},u_Gzj9Nro0WS48xKnH9few,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Hoodie", Rarity = GiftRarity.Epic, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Neck_StringLights},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "String Lights", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Hair_Bishop},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Bishop", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Glasses_SciFiVisor},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Sci Fi Visor", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Wrist_Boxing_Glove},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Glove", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Neck_NecklaceSilver},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Necklace Silver", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Hat_BoxingHelmet},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Boxing Helmet", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Neck_WinterCloak},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Winter Cloak", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Wrist_Scallywag_Bracelet},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Bracelet", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.CowboyTorso},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Cowboy Torso", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Hat_Firefighter},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Firefighter", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Shirt_Bee},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Bee", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Hat_InternationalThiefHat},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "International Thief Hat", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Eye_RoundGlasses},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Round Glasses", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.GoldMedal},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Gold Medal", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Neck_ScoutSash},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Scout Sash", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Hat_Bowler},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Bowler", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Hair_FemaleCheerleader},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Female Cheerleader", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Neck_QpidQuiver},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Qpid Quiver", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Wrist_Thriller},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Thriller", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Hat_80sShutterShades},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "80s Shutter Shades", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Shirt_Archer},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Archer", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.SeaCaptainBeard},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Sea Captain Beard", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Shirt_DeepSeaDiver},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Deep Sea Diver", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Hair_ManPony},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Man Pony", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Shirt_Letterman},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Letterman", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Neck_ButterflyWings_Monarch},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Monarch", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.BusinessTie},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Business Tie", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Glasses_Red},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Red", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Hair_DutchBraid},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Dutch Braid", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Hat_Viking},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Viking", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Hair_Malibu},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Malibu", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Shirt_Harness},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Harness", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Eye_TouristGlasses},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Tourist Glasses", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Beard_Thick},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Thick", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.CowboyStache},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Cowboy Stache", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Eye_SteampunkFemmeSpex},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Steampunk Femme Spex", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Hair_Punk},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Punk", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Wrist_Barbershop},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Barbershop", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Hat_Farmer},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Farmer", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Hat_Froggyheadband},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Froggyheadband", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Shirt_Bowling},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Bowling", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Hair_RecedingHairline},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Receding Hairline", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.MaleTShirt},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Male T Shirt", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Hat_Archer},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Archer", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Hat_GreenVelvet_TopHat},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Top Hat", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Shirt_Dodgeball},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Dodgeball", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Eye_MirrorShades_PinkClear},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Pink Clear", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.HockeyShirt},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Hockey Shirt", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.TrackSuit},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Track Suit", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Hair_Rhianna},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Rhianna", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Hair_GiantAfro},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Giant Afro", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Shirt_SeaCaptain_Contest},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Contest", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.PaintballVest},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Paintball Vest", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Hat_Scarecrow},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Scarecrow", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Hair_Buzz},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Buzz", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.BabydollDress},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Babydoll Dress", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Hat_Barbershop},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Barbershop", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Blazer},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Blazer", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Shirt_Zombie},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Zombie", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Shirt_BogMonsterShirt},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Bog Monster Shirt", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Shirt_Skeleton_Hoodie},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Hoodie", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Shirt_FuschiaMarine},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Fuschia Marine", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.shirt_royalLord},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "royal Lord", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Neck_Winter},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Winter", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Eye_Pirate_Eyepatch},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Eyepatch", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Eye_MirrorShades_TealRed},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Teal Red", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Hair_FauxHawk},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Faux Hawk", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Hat_QpidLaurel},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Qpid Laurel", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Hair_Bob_Bangs},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Bangs", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.WristBand_Team_Emissive},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Emissive", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Hair_Mohawk},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Mohawk", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Shirt_Punk},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Punk", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Hair_WavyLong},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Wavy Long", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Shirt_Conductor},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Conductor", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Hat_Knight_Helmet},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Helmet", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Hat_JackfrostHair},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Jackfrost Hair", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Shirt_Construction},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Construction", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Shirt_SteamPunk},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Steam Punk", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Wrist_Golfer},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Golfer", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Eye_MardiGrasEyes},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Mardi Gras Eyes", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Hair_DreadsLong},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Dreads Long", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.AstronautTorso},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Astronaut Torso", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Hat_FighterPilot},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Fighter Pilot", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Wrist_WristBand},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Wrist Band", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Wrist_PirateCaptain},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Pirate Captain", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Belt_PaintballBelt},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Paintball Belt", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Hat_Bearhat},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Bearhat", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Hat_Beret},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Beret", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Belt_PoolFloatie_BirdHead},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Bird Head", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Wrist_MagicalGirl},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Magical Girl", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Hat_LettermanShades},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Letterman Shades", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Hair_Scientist},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Scientist", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Hat_AstronautHelmet},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Astronaut Helmet", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Hat_Ranger},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Ranger", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.FlowerSwimsuit},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Flower Swimsuit", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Neck_Safari},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Safari", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.RedBeltDress},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Red Belt Dress", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Glasses_Square},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Square", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Hat_SeaCaptain},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Sea Captain", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Hat_ScoutGarrison},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Scout Garrison", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Eye_MirrorShades_YellowBlue},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Yellow Blue", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Dress_WaitressDress},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Waitress Dress", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Shirt_Golfer},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Golfer", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Hair_UnderCutSheet},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Under Cut Sheet", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Shirt_Ranger},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Ranger", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Hair_JackFrostNoCrystalsHair},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Jack Frost No Crystals Hair", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Neck_ButterflyWings},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Butterfly Wings", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Hair_Bun},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Bun", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Shirt_Scientist},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Scientist", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Shirt_Boxer},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Boxer", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Shirt_Chef},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Chef", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Shirt_FighterPilot},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Fighter Pilot", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Hair_LongBangs},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Long Bangs", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Shirt_50sDressValentine},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "50s Dress Valentine", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Shirt_BowlingSweater},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Bowling Sweater", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Hat_SteamPunk},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Steam Punk", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Neck_DraculaCape},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Dracula Cape", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Hat_MagicalGirl},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Magical Girl", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Shirt_Thriller},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Thriller", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Shirt_SodaJerk},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Soda Jerk", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Neck_SteampunkSatchel},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Steampunk Satchel", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Wrist_IceQueen},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Ice Queen", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Neck_TreasureHunterBelt},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Treasure Hunter Belt", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Hat_HeadbandTied},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Headband Tied", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Neck_VampireHunter},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Vampire Hunter", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Hat_HeadBackBow},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Head Back Bow", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Shirt_Tuxedo},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Tuxedo", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Hat_SteampunkFemme},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Steampunk Femme", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Shirt_VampireHunter},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Vampire Hunter", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Eye_SquareWide},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Square Wide", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Eye_SciFiVisor_Contest},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Contest", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Hat_GraduationCap},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Graduation Cap", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Shirt_SteampunkFemme},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Steampunk Femme", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Hat_Mummy},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Mummy", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Shirt_GuardiansJacket},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Guardians Jacket", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Hat_TutorialCap},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Tutorial Cap", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Hat_LaurelCrown},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Laurel Crown", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Shirt_MagicalGirl},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Magical Girl", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Shirt_TutorialGown_2},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Tutorial Gown 2", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Shirt_Biker},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Biker", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Neck_TutorialSash_3},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Tutorial Sash 3", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Shirt_Mummy},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Mummy", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Hat_Frankenstein},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Frankenstein", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Neck_FannyPack},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Fanny Pack", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Neck_ShortFatNecktie},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Short Fat Necktie", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Shirt_Suspenders},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Suspenders", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.shirt_QpidToga},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Qpid Toga", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Wrist_Grillmaster},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Grillmaster", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Shirt_Countess},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Countess", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Shirt_TreasureHunter},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Treasure Hunter", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Wrist_SteamPunk},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Steam Punk", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Hat_TruckerHat},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Trucker Hat", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Shirt_Snorkeler},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Snorkeler", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Hat_Witch},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Witch", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Hat_BrideofFrank},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Brideof Frank", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Neck_SteamPunk},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Steam Punk", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Hat_TreasureHunter},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Treasure Hunter", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Neck_TreasureHunterBandolier},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Treasure Hunter Bandolier", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Wrist_Countess},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Countess", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Eye_Clubmasters},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Clubmasters", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Shirt_TreasureHunterTank},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Treasure Hunter Tank", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Wrist_Frankenstein},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Frankenstein", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Neck_Grillmaster},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Grillmaster", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Mouth_VanDyke},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Van Dyke", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Shirt_GraduationGown},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Graduation Gown", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Hat_Headphones},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Headphones", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Belt_PoolFloatie_Unicorn},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Unicorn", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Neck_DraculaMedal},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Dracula Medal", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Shirt_Tourist},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Tourist", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Neck_TutorialSash_2},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Tutorial Sash 2", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Hat_CowboyHairy},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Cowboy Hairy", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Hat_BikerHelmet},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Biker Helmet", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Hat_IceQueen},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Ice Queen", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Hat_SodaJerk},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Soda Jerk", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Neck_MagicalGirl},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Magical Girl", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Wrist_Witch},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Witch", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Wrist_Mummy},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Mummy", Rarity = GiftRarity.Common, Tooltip = "" },
                new() { AvatarItemDesc = $"{AvatarHelper.Shirt_Frankenstein},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Frankenstein", Rarity = GiftRarity.Common, Tooltip = "" }
            ];
        }

        [ServerAPI.POST("/api/avatar/v2/set")]
        [ServerAPI.UseAuthorization]
        public async Task<IResult> ReturnSetAvatar(HttpContext ctx, MongoDB.User user)
        {
            AvatarDTO? avatar = await ctx.Request.GetJson<AvatarDTO>();
            if (avatar == null)
            {
                return Results.Forbid();
            }

            MongoDB.usersCollection.UpdateOne(
                u => u.AccountId == user.AccountId,
                Builders<MongoDB.User>.Update.Set(u => u.OtherData.Avatar, avatar)
            );

            return Results.Ok();
        }

        [ServerAPI.GET("/api/avatar/v3/saved")]
        [ServerAPI.UseAuthorization]
        public List<object> ReturnGetSavedAvatars(MongoDB.User user)
        {
            return [];
        }

        [ServerAPI.GET("/api/avatar/v2/gifts")]
        [ServerAPI.UseAuthorization]
        public List<object> ReturnGetGifts(MongoDB.User user)
        {
            return [];
        }
    }
}