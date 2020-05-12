using Microsoft.EntityFrameworkCore.Migrations;

namespace FriendFinderAPI.Migrations
{
    public partial class PopulateHobbies : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1,
                columns: new[] { "HobbyActivationLevel", "HobbyName" },
                values: new object[] { 0, "3D printing" });

            migrationBuilder.UpdateData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 2,
                columns: new[] { "HobbyActivationLevel", "HobbyName" },
                values: new object[] { 0, "Abseiling" });

            migrationBuilder.InsertData(
                table: "Hobbies",
                columns: new[] { "HobbyID", "HobbyActivationLevel", "HobbyName", "LocationID", "UserID" },
                values: new object[,]
                {
                    { 1362, 0, "Zui quan", null, null },
                    { 915, 0, "Rafting", null, null },
                    { 914, 0, "Radio-controlled car", null, null },
                    { 913, 0, "Radio-controlled aerobatics", null, null },
                    { 912, 0, "Radio control", null, null },
                    { 911, 0, "Racquetball", null, null },
                    { 910, 0, "Racing Pigeons", null, null },
                    { 909, 0, "Racewalking", null, null },
                    { 908, 0, "Race of Champions", null, null },
                    { 907, 0, "R/C Planes", null, null },
                    { 906, 0, "R/C Helicopters", null, null },
                    { 905, 0, "R/C Cars", null, null },
                    { 904, 0, "R/C Boats", null, null },
                    { 903, 0, "Quizzing", null, null },
                    { 902, 0, "Quilting", null, null },
                    { 901, 0, "Quidditch", null, null },
                    { 900, 0, "Pétanque", null, null },
                    { 899, 0, "Pyrotechnics", null, null },
                    { 916, 0, "Railfans", null, null },
                    { 898, 0, "Pyraminx", null, null },
                    { 917, 0, "Rally raid", null, null },
                    { 919, 0, "Rallying", null, null },
                    { 936, 0, "Rhythmic gymnastics", null, null },
                    { 935, 0, "Reversi", null, null },
                    { 934, 0, "Rescuing Abused Or Abandoned Animals", null, null },
                    { 933, 0, "Requiring little or no physical exertion or agility mind sports are often not considered true sports. Some mind sports are recognised by sporting federations.", null, null },
                    { 932, 0, "Renting movies", null, null },
                    { 931, 0, "Renaissance Faire", null, null },
                    { 930, 0, "Relaxing", null, null },
                    { 929, 0, "Reining", null, null },
                    { 928, 0, "Regularity rally", null, null },
                    { 927, 0, "Reduced variants", null, null },
                    { 926, 0, "Red rover", null, null },
                    { 925, 0, "Record collecting", null, null },
                    { 924, 0, "Rec footy", null, null },
                    { 923, 0, "Reading To The Elderly", null, null },
                    { 922, 0, "Reading", null, null },
                    { 921, 0, "Rapping", null, null },
                    { 920, 0, "Rappelling", null, null },
                    { 918, 0, "Rallycross", null, null },
                    { 897, 0, "Puzzle", null, null },
                    { 896, 0, "Puppetry", null, null },
                    { 895, 0, "Punto, raffa, volo", null, null },
                    { 872, 0, "Pole Dancing", null, null },
                    { 871, 0, "Poker", null, null },
                    { 870, 0, "Poi", null, null },
                    { 869, 0, "Pocket billiards", null, null },
                    { 868, 0, "Pocket Cube", null, null },
                    { 867, 0, "Playing team sports", null, null },
                    { 866, 0, "Playing music", null, null },
                    { 865, 0, "Platform tennis", null, null },
                    { 864, 0, "Plate spinning", null, null },
                    { 863, 0, "Planking", null, null },
                    { 862, 0, "Pitch and putt", null, null },
                    { 861, 0, "Pipe Smoking", null, null },
                    { 860, 0, "Pinochle", null, null },
                    { 859, 0, "Pigeon racing", null, null },
                    { 858, 0, "Pickup truck racing", null, null },
                    { 857, 0, "Pickleball", null, null },
                    { 856, 0, "Piano", null, null },
                    { 873, 0, "Pole climbing", null, null },
                    { 874, 0, "Pole vault", null, null },
                    { 875, 0, "Polo", null, null },
                    { 876, 0, "Polocrosse", null, null },
                    { 894, 0, "Punchball", null, null },
                    { 893, 0, "Protesting", null, null },
                    { 892, 0, "Professional wrestling", null, null },
                    { 891, 0, "Production car racing", null, null },
                    { 890, 0, "Pressed flower craft", null, null },
                    { 889, 0, "Pradal serey", null, null },
                    { 888, 0, "Practical shooting", null, null },
                    { 887, 0, "Powerlifting", null, null },
                    { 937, 0, "Ribbon", null, null },
                    { 886, 0, "Powered paragliding", null, null },
                    { 884, 0, "Powerchair Football", null, null },
                    { 883, 0, "Powerboking", null, null },
                    { 882, 0, "Powerbocking", null, null },
                    { 881, 0, "Power hockey", null, null },
                    { 880, 0, "Pottery", null, null },
                    { 879, 0, "Popinjay", null, null },
                    { 878, 0, "Pond hockey", null, null },
                    { 877, 0, "Pommel horse", null, null },
                    { 885, 0, "Powered hang glider", null, null },
                    { 855, 0, "Photography", null, null },
                    { 938, 0, "Ringball", null, null },
                    { 940, 0, "Ringo", null, null },
                    { 1000, 0, "Savate", null, null },
                    { 999, 0, "Sanshou", null, null },
                    { 998, 0, "Sandboarding", null, null },
                    { 997, 0, "Sand art and play", null, null },
                    { 996, 0, "Sand Castles", null, null },
                    { 995, 0, "San shou", null, null },
                    { 994, 0, "Samoa rules", null, null },
                    { 993, 0, "Sambo", null, null },
                    { 992, 0, "Saltwater Aquariums", null, null },
                    { 991, 0, "Sailing", null, null },
                    { 990, 0, "Sack race", null, null },
                    { 989, 0, "Russian pyramid", null, null },
                    { 988, 0, "Running", null, null },
                    { 987, 0, "Rundown", null, null },
                    { 986, 0, "Rugby union", null, null },
                    { 985, 0, "Rugby tens", null, null },
                    { 984, 0, "Rugby sevens", null, null },
                    { 1001, 0, "Schwingen", null, null },
                    { 983, 0, "Rugby league sevens", null, null },
                    { 1002, 0, "Scouting", null, null },
                    { 1004, 0, "Scrapbooking", null, null },
                    { 1021, 0, "Shidōkan Karate", null, null },
                    { 1020, 0, "Shark Fishing", null, null },
                    { 1019, 0, "Shaolin kung fu", null, null },
                    { 1018, 0, "Sewing", null, null },
                    { 1017, 0, "Seven-ball", null, null },
                    { 1016, 0, "Sepak takraw", null, null },
                    { 1015, 0, "Self Defense", null, null },
                    { 1014, 0, "Segway polo", null, null },
                    { 1013, 0, "Second-language acquisition", null, null },
                    { 1012, 0, "Seashell", null, null },
                    { 1011, 0, "Sea kayaking", null, null },
                    { 1010, 0, "Sea glass", null, null },
                    { 1009, 0, "Sculpting", null, null },
                    { 1008, 0, "Sculling", null, null },
                    { 1007, 0, "Scuba diving", null, null },
                    { 1006, 0, "Scuba Diving", null, null },
                    { 1005, 0, "Scrub baseball", null, null },
                    { 1003, 0, "Scrabble", null, null },
                    { 982, 0, "Rugby league nines", null, null },
                    { 981, 0, "Rugby league", null, null },
                    { 980, 0, "Rugby football", null, null },
                    { 957, 0, "Rockets", null, null },
                    { 956, 0, "Rock fishing", null, null },
                    { 955, 0, "Rock climbing", null, null },
                    { 954, 0, "Rock balancing", null, null },
                    { 953, 0, "Rock Collecting", null, null },
                    { 952, 0, "Rock Balancing", null, null },
                    { 951, 0, "Robotics", null, null },
                    { 950, 0, "Robot combat", null, null },
                    { 949, 0, "Road running", null, null },
                    { 948, 0, "Road racing", null, null },
                    { 947, 0, "Road bicycle racing", null, null },
                    { 946, 0, "Riverboarding", null, null },
                    { 945, 0, "Risk", null, null },
                    { 944, 0, "Rinkball", null, null },
                    { 943, 0, "Rink hockey", null, null },
                    { 942, 0, "Rink bandy", null, null },
                    { 941, 0, "Rings", null, null },
                    { 958, 0, "Rocking AIDS Babies", null, null },
                    { 959, 0, "Rodeo", null, null },
                    { 960, 0, "Rogaining", null, null },
                    { 961, 0, "Roleplaying", null, null },
                    { 979, 0, "Rugby Fives", null, null },
                    { 978, 0, "Rubik's Revenge", null, null },
                    { 977, 0, "Rubik's Cube with Feet", null, null },
                    { 976, 0, "Rubik's Cube blindfolded", null, null },
                    { 975, 0, "Rubik's Cube One Handed", null, null },
                    { 974, 0, "Rubik's Cube", null, null },
                    { 973, 0, "Rubik's Clock", null, null },
                    { 972, 0, "Royal Shrovetide Football", null, null },
                    { 939, 0, "Ringette", null, null },
                    { 971, 0, "Royak", null, null },
                    { 969, 0, "Rounders", null, null },
                    { 968, 0, "Rotation", null, null },
                    { 967, 0, "Rossall Hockey", null, null },
                    { 966, 0, "Rope climbing", null, null },
                    { 965, 0, "Rope", null, null },
                    { 964, 0, "Roller skating", null, null },
                    { 963, 0, "Roller hockey", null, null },
                    { 962, 0, "Roller derby", null, null },
                    { 970, 0, "Rowing", null, null },
                    { 1022, 0, "Shinty", null, null },
                    { 854, 0, "Peteca", null, null },
                    { 852, 0, "Pesäpallo", null, null },
                    { 745, 0, "Metal detector", null, null },
                    { 744, 0, "Metal detecting", null, null },
                    { 743, 0, "Metal Detecting", null, null },
                    { 742, 0, "Mesoamerican ballgame", null, null },
                    { 741, 0, "Megaminx", null, null },
                    { 740, 0, "Medley swimming", null, null },
                    { 739, 0, "Meditation", null, null },
                    { 738, 0, "Medieval football", null, null },
                    { 737, 0, "Matchstick Modeling", null, null },
                    { 736, 0, "Match play", null, null },
                    { 735, 0, "Matball", null, null },
                    { 734, 0, "Masters Rugby League", null, null },
                    { 733, 0, "Masters Football", null, null },
                    { 732, 0, "Martial arts", null, null },
                    { 731, 0, "Martial Arts", null, null },
                    { 730, 0, "Marn Grook", null, null },
                    { 729, 0, "Marksmanship", null, null },
                    { 746, 0, "Metallic silhouette", null, null },
                    { 728, 0, "Marching band", null, null },
                    { 747, 0, "Metallic silhouette shooting", null, null },
                    { 749, 0, "Meteorology", null, null },
                    { 766, 0, "Modeling Ships", null, null },
                    { 765, 0, "Model yachting", null, null },
                    { 764, 0, "Model building", null, null },
                    { 763, 0, "Model aircraft", null, null },
                    { 762, 0, "Model Rockets", null, null },
                    { 761, 0, "Model Railroading", null, null },
                    { 760, 0, "Mod league", null, null },
                    { 759, 0, "Mob football", null, null },
                    { 758, 0, "Mixed martial arts", null, null },
                    { 757, 0, "Mixed climbing", null, null },
                    { 756, 0, "Miniature golf", null, null },
                    { 755, 0, "Mini rugby", null, null },
                    { 754, 0, "Mini footy", null, null },
                    { 753, 0, "Mineral collecting", null, null },
                    { 752, 0, "Midget car racing", null, null },
                    { 751, 0, "Microscopy", null, null },
                    { 750, 0, "Metro footy", null, null },
                    { 748, 0, "Metalworking", null, null },
                    { 727, 0, "Marbles", null, null },
                    { 726, 0, "Marathon", null, null },
                    { 725, 0, "Mancala", null, null },
                    { 702, 0, "Legos", null, null },
                    { 701, 0, "Lego", null, null },
                    { 700, 0, "Legends car racing", null, null },
                    { 699, 0, "Leathercrafting", null, null },
                    { 698, 0, "Leather crafting", null, null },
                    { 697, 0, "Learning To Pilot A Plane", null, null },
                    { 696, 0, "Learning An Instrument", null, null },
                    { 695, 0, "Learning A Foreign Language", null, null },
                    { 694, 0, "Learning", null, null },
                    { 693, 0, "Learn to Play Poker", null, null },
                    { 692, 0, "Lawn Darts", null, null },
                    { 691, 0, "Lasers", null, null },
                    { 690, 0, "Laser tag", null, null },
                    { 689, 0, "Lapta", null, null },
                    { 688, 0, "Lapidary club", null, null },
                    { 687, 0, "Land windsurfing", null, null },
                    { 686, 0, "Land speed records", null, null },
                    { 703, 0, "Lelo burti", null, null },
                    { 704, 0, "Lethwei", null, null },
                    { 705, 0, "Letterboxing", null, null },
                    { 706, 0, "Limited overs cricket", null, null },
                    { 724, 0, "Malla-yuddha", null, null },
                    { 723, 0, "Making Model Cars", null, null },
                    { 722, 0, "Mahjong", null, null },
                    { 721, 0, "Magic", null, null },
                    { 720, 0, "Macramé", null, null },
                    { 719, 0, "Macrame", null, null },
                    { 718, 0, "Machining", null, null },
                    { 717, 0, "MCMAP", null, null },
                    { 767, 0, "Models", null, null },
                    { 716, 0, "Lumberjack", null, null },
                    { 714, 0, "Losing chess", null, null },
                    { 713, 0, "Longboarding", null, null },
                    { 712, 0, "Long jump", null, null },
                    { 711, 0, "Logrolling", null, null },
                    { 710, 0, "Locksport", null, null },
                    { 709, 0, "Lockpicking", null, null },
                    { 708, 0, "Listening to music", null, null },
                    { 707, 0, "List of types of games", null, null },
                    { 715, 0, "Luge", null, null },
                    { 853, 0, "Pet", null, null },
                    { 768, 0, "Modern Arnis", null, null },
                    { 770, 0, "Mongolian wrestling", null, null },
                    { 830, 0, "Palla", null, null },
                    { 829, 0, "Pall mall", null, null },
                    { 828, 0, "Palant", null, null },
                    { 827, 0, "Painting", null, null },
                    { 826, 0, "Paintball", null, null },
                    { 825, 0, "Padiddling", null, null },
                    { 824, 0, "Oztag", null, null },
                    { 823, 0, "Owning An Antique Car", null, null },
                    { 822, 0, "Over-the-line", null, null },
                    { 821, 0, "Outrigger canoeing", null, null },
                    { 820, 0, "Other", null, null },
                    { 819, 0, "Origami", null, null },
                    { 818, 0, "Orienteering", null, null },
                    { 817, 0, "One-pocket", null, null },
                    { 816, 0, "One Day International", null, null },
                    { 815, 0, "Olympic weightlifting", null, null },
                    { 814, 0, "Old cat", null, null },
                    { 831, 0, "Pankration", null, null },
                    { 813, 0, "Okinawan kobudō", null, null },
                    { 832, 0, "Papermache", null, null },
                    { 834, 0, "Papi fut", null, null },
                    { 851, 0, "Personal water craft", null, null },
                    { 850, 0, "People watching", null, null },
                    { 849, 0, "People Watching", null, null },
                    { 848, 0, "Pentathlon", null, null },
                    { 847, 0, "Pencak Silat", null, null },
                    { 846, 0, "Pehlwani", null, null },
                    { 845, 0, "Pato", null, null },
                    { 844, 0, "Patball", null, null },
                    { 843, 0, "Parkour", null, null },
                    { 842, 0, "Parasailing", null, null },
                    { 841, 0, "Paramotoring", null, null },
                    { 840, 0, "Paralympic volleyball", null, null },
                    { 839, 0, "Paralympic association football", null, null },
                    { 838, 0, "Parallel bars", null, null },
                    { 837, 0, "Paragliding or Power Paragliding", null, null },
                    { 836, 0, "Paragliding", null, null },
                    { 835, 0, "Parachuting", null, null },
                    { 833, 0, "Papermaking", null, null },
                    { 812, 0, "Oina", null, null },
                    { 811, 0, "Offshore powerboat racing", null, null },
                    { 810, 0, "Off-roading", null, null },
                    { 787, 0, "Mushroom hunting", null, null },
                    { 786, 0, "Mud bogging", null, null },
                    { 785, 0, "Muay Thai", null, null },
                    { 784, 0, "Movies", null, null },
                    { 783, 0, "Mountaineering", null, null },
                    { 782, 0, "Mountainboarding", null, null },
                    { 781, 0, "Mountain unicycling", null, null },
                    { 780, 0, "Mountain biking", null, null },
                    { 779, 0, "Mountain Climbing", null, null },
                    { 778, 0, "Mountain Biking", null, null },
                    { 777, 0, "Motorcycles", null, null },
                    { 776, 0, "Motorcycle speedway", null, null },
                    { 775, 0, "Motorcycle drag racing", null, null },
                    { 774, 0, "Motor sports", null, null },
                    { 773, 0, "Motocross", null, null },
                    { 772, 0, "Moscow broomball", null, null },
                    { 771, 0, "Monster truck", null, null },
                    { 788, 0, "Music", null, null },
                    { 789, 0, "Musical Instruments", null, null },
                    { 790, 0, "Naginatajutsu", null, null },
                    { 791, 0, "Nail Art", null, null },
                    { 809, 0, "Off-road racing", null, null },
                    { 808, 0, "Obstacle variations", null, null },
                    { 807, 0, "Object spinning", null, null },
                    { 806, 0, "Novuss", null, null },
                    { 805, 0, "Northern Praying Mantis", null, null },
                    { 804, 0, "Nordic skiing", null, null },
                    { 803, 0, "Nordic skating", null, null },
                    { 802, 0, "Nordic combined", null, null },
                    { 769, 0, "Modern pentathlon", null, null },
                    { 801, 0, "Noodling", null, null },
                    { 799, 0, "Nine-man football", null, null },
                    { 798, 0, "Nine-ball", null, null },
                    { 797, 0, "Nine-a-side footy", null, null },
                    { 796, 0, "Nguni stick-fighting", null, null },
                    { 795, 0, "Newcomb ball", null, null },
                    { 794, 0, "Netball", null, null },
                    { 793, 0, "Neppis", null, null },
                    { 792, 0, "Needlepoint", null, null },
                    { 800, 0, "Ninjutsu", null, null },
                    { 1363, 0, "Zumba", null, null },
                    { 1023, 0, "Shogi", null, null },
                    { 1025, 0, "Shoot boxing", null, null },
                    { 1255, 0, "Tutoring Children", null, null },
                    { 1254, 0, "Tumbling", null, null },
                    { 1253, 0, "Tug-o-war", null, null },
                    { 1252, 0, "Trugo", null, null },
                    { 1251, 0, "Truck racing", null, null },
                    { 1250, 0, "Trophy hunting", null, null },
                    { 1249, 0, "Triple jump", null, null },
                    { 1248, 0, "Trick shot", null, null },
                    { 1247, 0, "Triathlon", null, null },
                    { 1246, 0, "Trial", null, null },
                    { 1245, 0, "Trekkie", null, null },
                    { 1244, 0, "Treasure Hunting", null, null },
                    { 1243, 0, "Traveling", null, null },
                    { 1242, 0, "Trapeze", null, null },
                    { 1241, 0, "Trap shooting", null, null },
                    { 1240, 0, "Trampolining", null, null },
                    { 1239, 0, "Trainspotting", null, null },
                    { 1256, 0, "Twenty20", null, null },
                    { 1238, 0, "Train Spotting", null, null },
                    { 1257, 0, "Ultimate", null, null },
                    { 1259, 0, "Ultimate Frisbee", null, null },
                    { 1276, 0, "Uppies and Downies", null, null },
                    { 1275, 0, "Universal football", null, null },
                    { 1274, 0, "Unicycling", null, null },
                    { 1273, 0, "Unicycle trials", null, null },
                    { 1272, 0, "Unicycle hockey", null, null },
                    { 1271, 0, "Unicycle basketball", null, null },
                    { 1270, 0, "Uneven bars", null, null },
                    { 1269, 0, "Underwater target shooting", null, null },
                    { 1268, 0, "Underwater rugby", null, null },
                    { 1267, 0, "Underwater photography", null, null },
                    { 1266, 0, "Underwater orienteering", null, null },
                    { 1265, 0, "Underwater ice hockey", null, null },
                    { 1264, 0, "Underwater hockey", null, null },
                    { 1263, 0, "Underwater football", null, null },
                    { 1262, 0, "Underwater cycling", null, null },
                    { 1261, 0, "Ultramarathon", null, null },
                    { 1260, 0, "Ultralight aviation", null, null },
                    { 1258, 0, "Ultimate Disc ", null, null },
                    { 1237, 0, "Train Collecting", null, null },
                    { 1236, 0, "Traditional climbing", null, null },
                    { 1235, 0, "Tractor pulling", null, null },
                    { 1212, 0, "Three-ball", null, null },
                    { 1211, 0, "Three sided football", null, null },
                    { 1210, 0, "Texting", null, null },
                    { 1209, 0, "Textiles", null, null },
                    { 1208, 0, "Tetris", null, null },
                    { 1207, 0, "Tetherball", null, null },
                    { 1206, 0, "Test cricket", null, null },
                    { 1205, 0, "Tesla Coils", null, null },
                    { 1204, 0, "Tent pegging", null, null },
                    { 1203, 0, "Tennis polo", null, null },
                    { 1202, 0, "Tennis", null, null },
                    { 1201, 0, "Tennikoit", null, null },
                    { 1200, 0, "Ten-ball", null, null },
                    { 1199, 0, "Telemark skiing", null, null },
                    { 1198, 0, "Tee-ball", null, null },
                    { 1197, 0, "Team sport", null, null },
                    { 1196, 0, "Team play", null, null },
                    { 1213, 0, "Three-cushion", null, null },
                    { 1214, 0, "Three-legged race", null, null },
                    { 1215, 0, "Throwball", null, null },
                    { 1216, 0, "Throwing", null, null },
                    { 1234, 0, "Track racing", null, null },
                    { 1233, 0, "Track cycling", null, null },
                    { 1232, 0, "Toy Collecting", null, null },
                    { 1231, 0, "Town ball", null, null },
                    { 1230, 0, "Tower running", null, null },
                    { 1229, 0, "Touring car racing", null, null },
                    { 1228, 0, "Tour skating", null, null },
                    { 1227, 0, "Touch rugby", null, null },
                    { 1277, 0, "Urban Exploration", null, null },
                    { 1226, 0, "Touch football", null, null },
                    { 1224, 0, "Torball", null, null },
                    { 1223, 0, "Topiary", null, null },
                    { 1222, 0, "Tool Collecting", null, null },
                    { 1221, 0, "Tombstone Rubbing", null, null }
                });

            migrationBuilder.InsertData(
                table: "Hobbies",
                columns: new[] { "HobbyID", "HobbyActivationLevel", "HobbyName", "LocationID", "UserID" },
                values: new object[,]
                {
                    { 1220, 0, "Toe wrestling", null, null },
                    { 1219, 0, "Toboggan", null, null },
                    { 1218, 0, "Time attack", null, null },
                    { 1217, 0, "Thumb wrestling", null, null },
                    { 1225, 0, "Toss juggling", null, null },
                    { 1195, 0, "Team penning", null, null },
                    { 1278, 0, "Urban exploration", null, null },
                    { 1280, 0, "V-Cube 7", null, null },
                    { 1340, 0, "Woodsman", null, null },
                    { 1339, 0, "Woodball", null, null },
                    { 1338, 0, "Wood splitting", null, null },
                    { 1337, 0, "Wood chopping", null, null },
                    { 1336, 0, "Wood carving", null, null },
                    { 1335, 0, "Women's lacrosse", null, null },
                    { 1334, 0, "Wolf hunting", null, null },
                    { 1333, 0, "Woggabaliri", null, null },
                    { 1332, 0, "Wireball", null, null },
                    { 1331, 0, "Wingsuit flying", null, null },
                    { 1330, 0, "Wingsuit Flying", null, null },
                    { 1329, 0, "Wing Chun", null, null },
                    { 1328, 0, "Wine Making", null, null },
                    { 1327, 0, "Windsurfing", null, null },
                    { 1326, 0, "Wiffleball", null, null },
                    { 1325, 0, "Whittling", null, null },
                    { 1324, 0, "Whitewater kayaking", null, null },
                    { 1341, 0, "Woodworking", null, null },
                    { 1323, 0, "Wheelstand competition", null, null },
                    { 1342, 0, "Working In A Food Pantry", null, null },
                    { 1344, 0, "World Record Breaking", null, null },
                    { 1361, 0, "Zourkhaneh", null, null },
                    { 1360, 0, "Ziplining", null, null },
                    { 1359, 0, "Yukigassen", null, null },
                    { 1358, 0, "Yubi lakpi", null, null },
                    { 1357, 0, "Yoga", null, null },
                    { 1356, 0, "YoYo", null, null },
                    { 1355, 0, "Yo-yoing", null, null },
                    { 1354, 0, "Yağlı Güreş", null, null },
                    { 1353, 0, "Yak polo", null, null },
                    { 1352, 0, "Xingyiquan", null, null },
                    { 1351, 0, "Xiangqi", null, null },
                    { 1350, 0, "Wushu", null, null },
                    { 1349, 0, "Writing Songs", null, null },
                    { 1348, 0, "Writing Music", null, null },
                    { 1347, 0, "Writing", null, null },
                    { 1346, 0, "Wrestling", null, null },
                    { 1345, 0, "Worldbuilding", null, null },
                    { 1343, 0, "Working on cars", null, null },
                    { 1322, 0, "Wheelchair rugby league", null, null },
                    { 1321, 0, "Wheelchair racing", null, null },
                    { 1320, 0, "Wheelchair basketball", null, null },
                    { 1297, 0, "Volata", null, null },
                    { 1296, 0, "Violin", null, null },
                    { 1295, 0, "Vintage cars", null, null },
                    { 1294, 0, "Vigoro", null, null },
                    { 1293, 0, "Videophile", null, null },
                    { 1292, 0, "Video gaming", null, null },
                    { 1291, 0, "Video game collecting", null, null },
                    { 1290, 0, "Video game", null, null },
                    { 1289, 0, "Video Games", null, null },
                    { 1288, 0, "Vehicle restoration", null, null },
                    { 1287, 0, "Vault", null, null },
                    { 1286, 0, "Varzesh-e Pahlavani", null, null },
                    { 1285, 0, "Valencian pilota", null, null },
                    { 1284, 0, "Valencian frontó", null, null },
                    { 1283, 0, "Vale tudo", null, null },
                    { 1282, 0, "Vajra-mushti", null, null },
                    { 1281, 0, "Vacation", null, null },
                    { 1298, 0, "Volleyball", null, null },
                    { 1299, 0, "Volunteer", null, null },
                    { 1300, 0, "Vovinam", null, null },
                    { 1301, 0, "Waboba", null, null },
                    { 1319, 0, "Whale Watching", null, null },
                    { 1318, 0, "Western pleasure", null, null },
                    { 1317, 0, "Weightlifting", null, null },
                    { 1316, 0, "Weight training", null, null },
                    { 1315, 0, "Web surfing", null, null },
                    { 1314, 0, "Weather Watcher", null, null },
                    { 1313, 0, "Waymarking", null, null },
                    { 1312, 0, "Water volleyball", null, null },
                    { 1279, 0, "V-Cube 6", null, null },
                    { 1311, 0, "Water sports", null, null },
                    { 1309, 0, "Water basketball", null, null },
                    { 1308, 0, "Watching sporting events", null, null },
                    { 1307, 0, "Warhammer", null, null },
                    { 1306, 0, "Wallyball", null, null },
                    { 1305, 0, "Wallball", null, null },
                    { 1304, 0, "Walking", null, null },
                    { 1303, 0, "Wakesurfing", null, null },
                    { 1302, 0, "Wakeboarding", null, null },
                    { 1310, 0, "Water polo", null, null },
                    { 685, 0, "Land sailing", null, null },
                    { 1194, 0, "Tea Tasting", null, null },
                    { 1192, 0, "Taxidermy", null, null },
                    { 1085, 0, "Snorkeling", null, null },
                    { 1084, 0, "Snooker plus", null, null },
                    { 1083, 0, "Snooker", null, null },
                    { 1082, 0, "Snail racing", null, null },
                    { 1081, 0, "Slot car racing", null, null },
                    { 1080, 0, "Slot Car Racing", null, null },
                    { 1079, 0, "Slingshots", null, null },
                    { 1078, 0, "Sleeping", null, null },
                    { 1077, 0, "Slamball", null, null },
                    { 1076, 0, "Slacklining", null, null },
                    { 1075, 0, "Slack Lining", null, null },
                    { 1074, 0, "Skysurfing", null, null },
                    { 1073, 0, "Skydiving", null, null },
                    { 1072, 0, "Sky Diving", null, null },
                    { 1071, 0, "Skittles", null, null },
                    { 1070, 0, "Skins game", null, null },
                    { 1069, 0, "Skimboarding", null, null },
                    { 1086, 0, "Snorkelling", null, null },
                    { 1068, 0, "Skijoring", null, null },
                    { 1087, 0, "Snow kiting", null, null },
                    { 1089, 0, "Snowboarding", null, null },
                    { 1106, 0, "Speedball", null, null },
                    { 1105, 0, "Speed skiing", null, null },
                    { 1104, 0, "Speed skating", null, null },
                    { 1103, 0, "Speed pool", null, null },
                    { 1102, 0, "Speed golf", null, null },
                    { 1101, 0, "Speed Cubing", null, null },
                    { 1100, 0, "Spearfishing", null, null },
                    { 1099, 0, "Sogo", null, null },
                    { 1098, 0, "Softball", null, null },
                    { 1097, 0, "Socializing with friends/neighbors", null, null },
                    { 1096, 0, "Soccer", null, null },
                    { 1095, 0, "Soapmaking", null, null },
                    { 1094, 0, "Soap shoes", null, null },
                    { 1093, 0, "Soap Making", null, null },
                    { 1092, 0, "Snowshoeing", null, null },
                    { 1091, 0, "Snowmobile", null, null },
                    { 1090, 0, "Snowkiting", null, null },
                    { 1088, 0, "Snow rugby", null, null },
                    { 1067, 0, "Skiing", null, null },
                    { 1066, 0, "Skibobbing", null, null },
                    { 1065, 0, "Skibob", null, null },
                    { 1042, 0, "Sikaran", null, null },
                    { 1041, 0, "Shōrin-ryū Shidōkan", null, null },
                    { 1040, 0, "Shurikenjutsu", null, null },
                    { 1039, 0, "Shuffleboard", null, null },
                    { 1038, 0, "Shuai Jiao", null, null },
                    { 1037, 0, "Show jumping", null, null },
                    { 1036, 0, "Shotgun start", null, null },
                    { 1035, 0, "Shot put", null, null },
                    { 1034, 0, "Shortwave listening", null, null },
                    { 1033, 0, "Short track speed skating", null, null },
                    { 1032, 0, "Short track motor racing", null, null },
                    { 1031, 0, "Shorinji Kempo", null, null },
                    { 1030, 0, "Shopping", null, null },
                    { 1029, 0, "Shooting sports", null, null },
                    { 1028, 0, "Shooting sport", null, null },
                    { 1027, 0, "Shooting", null, null },
                    { 1026, 0, "Shootfighting", null, null },
                    { 1043, 0, "Silambam", null, null },
                    { 1044, 0, "Silat", null, null },
                    { 1045, 0, "Singing", null, null },
                    { 1046, 0, "Singing In Choir", null, null },
                    { 1064, 0, "Skiboarding", null, null },
                    { 1063, 0, "Ski touring", null, null },
                    { 1062, 0, "Ski jumping", null, null },
                    { 1061, 0, "Ski flying", null, null },
                    { 1060, 0, "Skewb", null, null },
                    { 1059, 0, "Sketching", null, null },
                    { 1058, 0, "Sketch", null, null },
                    { 1057, 0, "Skeleton", null, null },
                    { 1107, 0, "Speedcubing", null, null },
                    { 1056, 0, "Skeet shooting", null, null },
                    { 1054, 0, "Skee ball", null, null },
                    { 1053, 0, "Skater hockey", null, null },
                    { 1052, 0, "Skateboarding", null, null },
                    { 1051, 0, "Six-red snooker", null, null },
                    { 1050, 0, "Six-man football", null, null },
                    { 1049, 0, "Sipa", null, null },
                    { 1048, 0, "Sinuca brasileira", null, null },
                    { 1047, 0, "Single scull", null, null },
                    { 1055, 0, "Skeet Shooting", null, null },
                    { 1193, 0, "Tchoukball", null, null },
                    { 1108, 0, "Spelunkering", null, null },
                    { 1110, 0, "Spongee", null, null },
                    { 1170, 0, "Survival", null, null },
                    { 1169, 0, "Surfing", null, null },
                    { 1168, 0, "Surfboat", null, null },
                    { 1167, 0, "Surf kayaking", null, null },
                    { 1166, 0, "Surf fishing", null, null },
                    { 1165, 0, "Surf Fishing", null, null },
                    { 1164, 0, "Superside", null, null },
                    { 1163, 0, "Supermoto", null, null },
                    { 1162, 0, "Supercross", null, null },
                    { 1161, 0, "Superbike racing", null, null },
                    { 1160, 0, "Super sport", null, null },
                    { 1159, 0, "Sumo", null, null },
                    { 1158, 0, "Suicide", null, null },
                    { 1157, 0, "Sudoku", null, null },
                    { 1156, 0, "Subbuteo", null, null },
                    { 1155, 0, "Subak", null, null },
                    { 1154, 0, "Strongman", null, null },
                    { 1171, 0, "Swamp football", null, null },
                    { 1153, 0, "Stroke play", null, null },
                    { 1172, 0, "Swimming", null, null },
                    { 1174, 0, "Synchronized skating", null, null },
                    { 1191, 0, "Tatting", null, null },
                    { 1190, 0, "Target shooting", null, null },
                    { 1189, 0, "Target archery", null, null },
                    { 1188, 0, "Tang Soo Do", null, null },
                    { 1187, 0, "Taido", null, null },
                    { 1186, 0, "Tai chi", null, null },
                    { 1185, 0, "Tag rugby", null, null },
                    { 1184, 0, "Tag", null, null },
                    { 1183, 0, "Taekwondo", null, null },
                    { 1182, 0, "Taekkyeon", null, null },
                    { 1181, 0, "Table tennis", null, null },
                    { 1180, 0, "Table football", null, null },
                    { 1179, 0, "TV watching", null, null },
                    { 1178, 0, "T'ai chi ch'uan", null, null },
                    { 1177, 0, "Sōjutsu", null, null },
                    { 1176, 0, "Systema", null, null },
                    { 1175, 0, "Synchronized swimming", null, null },
                    { 1173, 0, "Sword fighting", null, null },
                    { 1152, 0, "String Figures", null, null },
                    { 1151, 0, "Strength athletics", null, null },
                    { 1150, 0, "Streetluge", null, null },
                    { 1127, 0, "Ssireum", null, null },
                    { 1126, 0, "Squirt boating", null, null },
                    { 1125, 0, "Squash tennis", null, null },
                    { 1124, 0, "Squash", null, null },
                    { 1123, 0, "Square", null, null },
                    { 1122, 0, "Sprint football", null, null },
                    { 1121, 0, "Sprint car racing", null, null },
                    { 1120, 0, "Sprint", null, null },
                    { 1119, 0, "Sports car racing", null, null },
                    { 1118, 0, "Sports aerobics", null, null },
                    { 1117, 0, "Sports acrobatics", null, null },
                    { 1116, 0, "Sporting clays", null, null },
                    { 1115, 0, "Sport stacking", null, null },
                    { 1114, 0, "Sport kite", null, null },
                    { 1113, 0, "Sport fishing", null, null },
                    { 1112, 0, "Sport diving", null, null },
                    { 1111, 0, "Sport climbing", null, null },
                    { 1128, 0, "Stamp Collecting", null, null },
                    { 1129, 0, "Stamp collecting", null, null },
                    { 1130, 0, "Stand up paddle boarding", null, null },
                    { 1131, 0, "Stand-up comedy", null, null },
                    { 1149, 0, "Streetboarding", null, null },
                    { 1148, 0, "Streetball", null, null },
                    { 1147, 0, "Street racing", null, null },
                    { 1146, 0, "Street hockey", null, null },
                    { 1145, 0, "Street football", null, null },
                    { 1144, 0, "Stratego", null, null },
                    { 1143, 0, "Straight pool", null, null },
                    { 1142, 0, "Storytelling", null, null },
                    { 1109, 0, "Spending time with family/kids", null, null },
                    { 1141, 0, "Storm Chasing", null, null },
                    { 1139, 0, "Stone skipping", null, null },
                    { 1138, 0, "Stone collecting", null, null },
                    { 1137, 0, "Stock car racing", null, null },
                    { 1136, 0, "Stihl Timbersports Series", null, null },
                    { 1135, 0, "Stickball", null, null },
                    { 1134, 0, "Steinstossen", null, null },
                    { 1133, 0, "Steeplechase", null, null },
                    { 1132, 0, "Static trapeze", null, null },
                    { 1140, 0, "Stool ball", null, null },
                    { 1024, 0, "Sholo Guti", null, null },
                    { 684, 0, "Lancashire wrestling", null, null },
                    { 682, 0, "Lacrosse", null, null },
                    { 234, 0, "Cloud Watching", null, null },
                    { 233, 0, "Climbing", null, null },
                    { 232, 0, "Clay pigeon shooting", null, null },
                    { 231, 0, "Cirit", null, null },
                    { 230, 0, "Cigar Smoking", null, null },
                    { 229, 0, "Church/church activities", null, null },
                    { 228, 0, "Choi Kwang-Do", null, null },
                    { 227, 0, "Chinlone", null, null },
                    { 226, 0, "Chinese martial arts", null, null },
                    { 225, 0, "Chinese handball", null, null },
                    { 224, 0, "Chinese checkers", null, null },
                    { 223, 0, "Chilean rodeo", null, null },
                    { 222, 0, "Chicago", null, null },
                    { 221, 0, "Chester-le-Street", null, null },
                    { 220, 0, "Chess960", null, null },
                    { 219, 0, "Chess boxing", null, null },
                    { 218, 0, "Chess", null, null },
                    { 235, 0, "Cluster ballooning", null, null },
                    { 217, 0, "Cheerleading", null, null },
                    { 236, 0, "Cnapan", null, null },
                    { 238, 0, "Coasteering", null, null },
                    { 255, 0, "Comic book collecting", null, null },
                    { 254, 0, "Combat sport is a competitive contact sport", null, null },
                    { 253, 0, "Combat robot", null, null },
                    { 252, 0, "Coloring book", null, null },
                    { 251, 0, "Coloring", null, null },
                    { 250, 0, "Color guard", null, null },
                    { 249, 0, "Collecting Swords", null, null },
                    { 248, 0, "Collecting Sports Cards", null, null },
                    { 247, 0, "Collecting RPM Records", null, null },
                    { 246, 0, "Collecting Music Albums", null, null },
                    { 245, 0, "Collecting Hats", null, null },
                    { 244, 0, "Collecting Artwork", null, null },
                    { 243, 0, "Collecting Antiques", null, null },
                    { 242, 0, "Collecting", null, null },
                    { 241, 0, "Coin collecting", null, null },
                    { 240, 0, "Coin Collecting", null, null },
                    { 239, 0, "Cockfighting", null, null },
                    { 237, 0, "Coastal and ocean rowing", null, null },
                    { 216, 0, "Checkers", null, null },
                    { 215, 0, "Charreada", null, null },
                    { 214, 0, "Chariot racing", null, null },
                    { 191, 0, "Camogie", null, null },
                    { 190, 0, "Cammag", null, null },
                    { 189, 0, "Calvinball", null, null },
                    { 188, 0, "Calva", null, null },
                    { 187, 0, "Calligraphy", null, null },
                    { 186, 0, "Calcio Fiorentino", null, null },
                    { 185, 0, "Cake Decorating", null, null },
                    { 184, 0, "Caid", null, null },
                    { 183, 0, "Cabaret", null, null },
                    { 182, 0, "Buzkashi", null, null },
                    { 181, 0, "Butts Up", null, null },
                    { 180, 0, "Button Collecting", null, null },
                    { 179, 0, "Butterfly stroke", null, null },
                    { 178, 0, "Butterfly Watching", null, null },
                    { 177, 0, "Bus spotting", null, null },
                    { 176, 0, "Bunnock", null, null },
                    { 175, 0, "Bungee jumping", null, null },
                    { 192, 0, "Campdrafting", null, null },
                    { 193, 0, "Camping", null, null },
                    { 194, 0, "Canadian football", null, null },
                    { 195, 0, "Candle Making", null, null },
                    { 213, 0, "Cestoball", null, null },
                    { 212, 0, "Ceramics", null, null },
                    { 211, 0, "Cave Diving", null, null },
                    { 210, 0, "Category:Sports-related lists", null, null },
                    { 209, 0, "Catch wrestling", null, null },
                    { 208, 0, "Casting", null, null },
                    { 207, 0, "Casterboarding", null, null },
                    { 206, 0, "Casino Gambling", null, null },
                    { 256, 0, "Community", null, null },
                    { 205, 0, "Cartooning", null, null },
                    { 203, 0, "Card collecting", null, null },
                    { 202, 0, "Car Racing", null, null },
                    { 201, 0, "Capture the flag", null, null },
                    { 200, 0, "Capoeira", null, null },
                    { 199, 0, "Canyoning", null, null },
                    { 198, 0, "Canoeing", null, null },
                    { 197, 0, "Canoe polo", null, null },
                    { 196, 0, "Candle making", null, null },
                    { 204, 0, "Carom billiards", null, null },
                    { 174, 0, "Bumper pool", null, null },
                    { 257, 0, "Competitive dance", null, null },
                    { 259, 0, "Compose Music", null, null },
                    { 319, 0, "Dice stacking", null, null },
                    { 318, 0, "Desert racing", null, null },
                    { 317, 0, "Demolition derby", null, null },
                    { 316, 0, "Deltiology", null, null },
                    { 315, 0, "Deer hunting", null, null },
                    { 314, 0, "Deep-water soloing", null, null },
                    { 313, 0, "Decathlon", null, null },
                    { 312, 0, "Debate", null, null },
                    { 311, 0, "Deaf basketball", null, null },
                    { 310, 0, "Darts", null, null },
                    { 309, 0, "Danish longball", null, null },
                    { 308, 0, "Dancing", null, null },
                    { 307, 0, "Dance", null, null },
                    { 306, 0, "Daitō-ryū Aiki-jūjutsu", null, null },
                    { 305, 0, "Czech handball", null, null },
                    { 304, 0, "Cyclo-cross", null, null },
                    { 303, 0, "Cycling", null, null },
                    { 320, 0, "Die-cast toy", null, null },
                    { 302, 0, "Cycle speedway", null, null },
                    { 321, 0, "Diecast Collectibles", null, null },
                    { 323, 0, "Digital art", null, null },
                    { 340, 0, "Dowsing", null, null },
                    { 339, 0, "Downhill mountain biking", null, null },
                    { 338, 0, "Double disc court", null, null },
                    { 337, 0, "Dominoes", null, null },
                    { 336, 0, "Dolls", null, null },
                    { 335, 0, "Dog sport", null, null },
                    { 334, 0, "Dodgeball", null, null },
                    { 333, 0, "Dodge disc", null, null },
                    { 332, 0, "Do it yourself", null, null },
                    { 331, 0, "Diving", null, null },
                    { 330, 0, "Discus throw", null, null },
                    { 329, 0, "Disc golf", null, null },
                    { 328, 0, "Disc dog", null, null },
                    { 327, 0, "Dirt track racing", null, null },
                    { 326, 0, "Dirt jumping", null, null },
                    { 325, 0, "Diplomacy", null, null },
                    { 324, 0, "Dinghy sailing", null, null },
                    { 322, 0, "Digital Photography", null, null },
                    { 301, 0, "Cycle polo", null, null },
                    { 300, 0, "Cutting", null, null },
                    { 299, 0, "Cutthroat", null, null },
                    { 276, 0, "Cowboy polo", null, null },
                    { 275, 0, "Cowboy action shooting", null, null },
                    { 274, 0, "Cowboy", null, null },
                    { 273, 0, "Couponing", null, null },
                    { 272, 0, "Cosplaying", null, null },
                    { 271, 0, "Cosplay", null, null },
                    { 270, 0, "Cornish hurling", null, null },
                    { 269, 0, "Cornhole", null, null },
                    { 268, 0, "Corkball", null, null },
                    { 267, 0, "Cooking", null, null },
                    { 266, 0, "Conworlding", null, null },
                    { 265, 0, "Contract Bridge", null, null },
                    { 264, 0, "Contesting", null, null },
                    { 263, 0, "Connect Four", null, null },
                    { 262, 0, "Computer programming", null, null },
                    { 261, 0, "Computer activities", null, null },
                    { 260, 0, "Composite rules shinty-hurling", null, null },
                    { 277, 0, "Crafts", null, null },
                    { 278, 0, "Creative writing", null, null },
                    { 279, 0, "Creeking", null, null },
                    { 280, 0, "Cribbage", null, null },
                    { 298, 0, "Cushion caroms", null, null },
                    { 297, 0, "Curling", null, null },
                    { 296, 0, "Cuju", null, null },
                    { 295, 0, "Cue sports", null, null },
                    { 294, 0, "Cryptography", null, null },
                    { 293, 0, "Crossword puzzles", null, null },
                    { 292, 0, "Crossword Puzzles", null, null },
                    { 291, 0, "Cross-country skiing", null, null }
                });

            migrationBuilder.InsertData(
                table: "Hobbies",
                columns: new[] { "HobbyID", "HobbyActivationLevel", "HobbyName", "LocationID", "UserID" },
                values: new object[,]
                {
                    { 258, 0, "Competitive eating", null, null },
                    { 290, 0, "Cross-country running", null, null },
                    { 288, 0, "Cross-country mountain biking", null, null },
                    { 287, 0, "Cross-country equestrianism", null, null },
                    { 286, 0, "Cross-Stitch", null, null },
                    { 285, 0, "Cross country running", null, null },
                    { 284, 0, "Croquet", null, null },
                    { 283, 0, "Crocheting", null, null },
                    { 282, 0, "Crochet", null, null },
                    { 281, 0, "Cricket", null, null },
                    { 289, 0, "Cross-country rally", null, null },
                    { 173, 0, "Bujinkan", null, null },
                    { 172, 0, "Building Dollhouses", null, null },
                    { 171, 0, "Building A House For Habitat For Humanity", null, null },
                    { 63, 0, "Autograss", null, null },
                    { 62, 0, "Autocross", null, null },
                    { 61, 0, "Auto racing", null, null },
                    { 60, 0, "Auto audiophilia", null, null },
                    { 59, 0, "Auto Race", null, null },
                    { 58, 0, "Austus", null, null },
                    { 57, 0, "Australian rules football", null, null },
                    { 56, 0, "Australian handball", null, null },
                    { 55, 0, "Australian football", null, null },
                    { 54, 0, "Atlatl", null, null },
                    { 53, 0, "Astronomy", null, null },
                    { 52, 0, "Astrology", null, null },
                    { 51, 0, "Association football", null, null },
                    { 50, 0, "Arts", null, null },
                    { 49, 0, "Artistic roller skating", null, null },
                    { 48, 0, "Artistic pool", null, null },
                    { 47, 0, "Artistic gymnastics", null, null },
                    { 64, 0, "Aviation", null, null },
                    { 46, 0, "Artistic cycling", null, null },
                    { 65, 0, "Axe throwing", null, null },
                    { 67, 0, "BMX", null, null },
                    { 84, 0, "Banzai skydiving", null, null },
                    { 83, 0, "Bank pool", null, null },
                    { 82, 0, "Banger racing", null, null },
                    { 81, 0, "Bandy", null, null },
                    { 80, 0, "Bando", null, null },
                    { 79, 0, "Ball hockey", null, null },
                    { 78, 0, "Ball badminton", null, null },
                    { 77, 0, "Ball", null, null },
                    { 76, 0, "Balkline and straight rail", null, null },
                    { 75, 0, "Balance beam", null, null },
                    { 74, 0, "Baguazhang", null, null },
                    { 73, 0, "Bagatelle", null, null },
                    { 72, 0, "Badminton", null, null },
                    { 71, 0, "Backstroke", null, null },
                    { 70, 0, "Backpacking", null, null },
                    { 69, 0, "Backgammon", null, null },
                    { 68, 0, "Ba game", null, null },
                    { 66, 0, "BASE jumping", null, null },
                    { 45, 0, "Artistic billiards", null, null },
                    { 44, 0, "Art collecting", null, null },
                    { 43, 0, "Arm wrestling", null, null },
                    { 20, 0, "Amateur Astronomy", null, null },
                    { 19, 0, "Alpine skiing", null, null },
                    { 18, 0, "Aizkolaritza", null, null },
                    { 17, 0, "Airsofting", null, null },
                    { 16, 0, "Airsoft", null, null },
                    { 15, 0, "Aircraft Spotting", null, null },
                    { 14, 0, "Airbrushing", null, null },
                    { 13, 0, "Air sports", null, null },
                    { 12, 0, "Air racing", null, null },
                    { 11, 0, "Air hockey", null, null },
                    { 10, 0, "Aikido", null, null },
                    { 9, 0, "Aid climbing", null, null },
                    { 8, 0, "Aggressive inline skating", null, null },
                    { 7, 0, "Aeromodeling", null, null },
                    { 6, 0, "Aerobatics", null, null },
                    { 5, 0, "Adventure racing", null, null },
                    { 4, 0, "Action figure", null, null },
                    { 21, 0, "Amateur Radio", null, null },
                    { 22, 0, "Amateur astronomy", null, null },
                    { 23, 0, "Amateur geology", null, null },
                    { 24, 0, "Amateur pankration", null, null },
                    { 42, 0, "Arimaa", null, null },
                    { 41, 0, "Arena football", null, null },
                    { 40, 0, "Archery", null, null },
                    { 39, 0, "Aquathlon", null, null },
                    { 38, 0, "Aquarium", null, null },
                    { 37, 0, "Aqua-lung", null, null },
                    { 36, 0, "Antiquities", null, null },
                    { 35, 0, "Antiquing", null, null },
                    { 85, 0, "Bar billiards", null, null },
                    { 34, 0, "Animals/pets/dogs", null, null },
                    { 32, 0, "Angling", null, null },
                    { 31, 0, "Ancient games", null, null },
                    { 30, 0, "American snooker", null, null },
                    { 29, 0, "American handball", null, null },
                    { 28, 0, "American football", null, null },
                    { 27, 0, "American flag rugby", null, null },
                    { 26, 0, "Amateur wrestling", null, null },
                    { 25, 0, "Amateur radio", null, null },
                    { 33, 0, "Animal fancy", null, null },
                    { 86, 0, "Barrel racing", null, null },
                    { 87, 0, "Bartitsu", null, null },
                    { 88, 0, "Base Jumping", null, null },
                    { 148, 0, "Bookbinding", null, null },
                    { 147, 0, "Book restoration", null, null },
                    { 146, 0, "Book collecting", null, null },
                    { 145, 0, "Bonsai Tree", null, null },
                    { 144, 0, "Boli Khela", null, null },
                    { 143, 0, "Bolas criollas", null, null },
                    { 142, 0, "Bokator", null, null },
                    { 141, 0, "Bodybuilding", null, null },
                    { 140, 0, "Bodyboarding", null, null },
                    { 139, 0, "Body Building", null, null },
                    { 138, 0, "Boccia", null, null },
                    { 137, 0, "Bocce volo", null, null },
                    { 136, 0, "Bocce", null, null },
                    { 135, 0, "Bobsleigh", null, null },
                    { 134, 0, "Boating", null, null },
                    { 133, 0, "Boardercross", null, null },
                    { 132, 0, "BoardGames", null, null },
                    { 149, 0, "Boomerangs", null, null },
                    { 150, 0, "Bossaball", null, null },
                    { 151, 0, "Bottle pool", null, null },
                    { 152, 0, "Bouldering", null, null },
                    { 170, 0, "Bucketball", null, null },
                    { 169, 0, "Brännboll", null, null },
                    { 168, 0, "Broomball", null, null },
                    { 167, 0, "British baseball", null, null },
                    { 166, 0, "British Bulldogs", null, null },
                    { 165, 0, "Bringing Food To The Disabled", null, null },
                    { 164, 0, "Bridge Building", null, null },
                    { 163, 0, "Brewing Beer", null, null },
                    { 131, 0, "Board track racing", null, null },
                    { 162, 0, "Breaststroke", null, null },
                    { 160, 0, "Brazilian jiu-jitsu", null, null },
                    { 159, 0, "Brazilian Jiu-Jitsu", null, null },
                    { 158, 0, "Boxing", null, null },
                    { 157, 0, "Box lacrosse", null, null },
                    { 156, 0, "Bowls", null, null },
                    { 155, 0, "Bowlliards", null, null },
                    { 154, 0, "Bowling", null, null },
                    { 153, 0, "Boules", null, null },
                    { 161, 0, "Breakdancing", null, null },
                    { 341, 0, "Drag boat racing", null, null },
                    { 130, 0, "Board sports", null, null },
                    { 128, 0, "Blogging", null, null },
                    { 105, 0, "Beach volleyball", null, null },
                    { 104, 0, "Beach soccer", null, null },
                    { 103, 0, "Beach rugby", null, null },
                    { 102, 0, "Beach handball", null, null },
                    { 101, 0, "Beach basketball", null, null },
                    { 100, 0, "Beach Volleyball", null, null },
                    { 99, 0, "Battōjutsu", null, null },
                    { 98, 0, "Battle gaming", null, null },
                    { 97, 0, "Baton twirling", null, null },
                    { 96, 0, "Baton Twirling", null, null },
                    { 95, 0, "Bat-and-ball games", null, null },
                    { 94, 0, "Bat and trap", null, null },
                    { 93, 0, "Basque rural sports", null, null },
                    { 92, 0, "Basque pelota", null, null },
                    { 91, 0, "Basketball", null, null },
                    { 90, 0, "Baseball pocket billiards", null, null },
                    { 89, 0, "Baseball", null, null },
                    { 106, 0, "Beach/Sun tanning", null, null },
                    { 107, 0, "Beachcombing", null, null },
                    { 108, 0, "Beadwork", null, null },
                    { 109, 0, "Beagling", null, null },
                    { 127, 0, "Blacksmithing", null, null },
                    { 126, 0, "Blackball", null, null },
                    { 125, 0, "Biribol", null, null },
                    { 124, 0, "Birdwatching", null, null },
                    { 123, 0, "Birding", null, null },
                    { 122, 0, "Bird watching", null, null },
                    { 121, 0, "Big-game fishing", null, null },
                    { 120, 0, "Bicycling", null, null },
                    { 129, 0, "Board games", null, null },
                    { 119, 0, "Bicycle polo", null, null },
                    { 117, 0, "Biathlon", null, null },
                    { 116, 0, "Benchrest shooting", null, null },
                    { 115, 0, "Belly Dancing", null, null },
                    { 114, 0, "Bell Ringing", null, null },
                    { 113, 0, "Beer Pong", null, null },
                    { 112, 0, "Beekeeping", null, null },
                    { 111, 0, "Becoming A Child Advocate", null, null },
                    { 110, 0, "Beatboxing", null, null },
                    { 118, 0, "Bicycle Polo", null, null },
                    { 683, 0, "Ladies' Gaelic football", null, null },
                    { 342, 0, "Drag racing", null, null },
                    { 344, 0, "Drama", null, null },
                    { 575, 0, "Ice sledge hockey", null, null },
                    { 574, 0, "Ice skating", null, null },
                    { 573, 0, "Ice racing", null, null },
                    { 572, 0, "Ice hockey", null, null },
                    { 571, 0, "Ice fishing", null, null },
                    { 570, 0, "Ice dancing", null, null },
                    { 569, 0, "Ice climbing", null, null },
                    { 568, 0, "Iaijutsu", null, null },
                    { 567, 0, "Iaidō", null, null },
                    { 566, 0, "ITHF table hockey", null, null },
                    { 565, 0, "Hydroplane racing", null, null },
                    { 564, 0, "Hybrid codes", null, null },
                    { 563, 0, "Hybrid carom–pocket games", null, null },
                    { 562, 0, "Hwa Rang Do", null, null },
                    { 561, 0, "Hurling", null, null },
                    { 560, 0, "Hurdles", null, null },
                    { 559, 0, "Hunting", null, null },
                    { 576, 0, "Ice speedway", null, null },
                    { 558, 0, "Hunter-jumpers", null, null },
                    { 577, 0, "Ice yachting", null, null },
                    { 579, 0, "Icosathlon", null, null },
                    { 596, 0, "International rules football", null, null },
                    { 595, 0, "International fronton", null, null },
                    { 594, 0, "Intercrosse", null, null },
                    { 593, 0, "Insect collecting", null, null },
                    { 592, 0, "Inline speed skating", null, null },
                    { 591, 0, "Inline skating", null, null },
                    { 590, 0, "Inline hockey", null, null },
                    { 589, 0, "Indoor soccer", null, null },
                    { 588, 0, "Indoor percussion ensemble", null, null },
                    { 587, 0, "Indoor netball", null, null },
                    { 586, 0, "Indoor field hockey", null, null },
                    { 585, 0, "Indoor enduro", null, null },
                    { 584, 0, "Indoor cricket", null, null },
                    { 583, 0, "Indoor archery", null, null },
                    { 582, 0, "Indoor American football", null, null },
                    { 581, 0, "Impersonations", null, null },
                    { 580, 0, "Illusion", null, null },
                    { 578, 0, "Iceskating", null, null },
                    { 557, 0, "Hunter", null, null },
                    { 556, 0, "Human swimming", null, null },
                    { 555, 0, "Human powered aircraft", null, null },
                    { 532, 0, "Home Brewing", null, null },
                    { 531, 0, "Hojōjutsu", null, null },
                    { 530, 0, "Hockey", null, null },
                    { 529, 0, "Historic motorsport", null, null },
                    { 528, 0, "Hillclimbing", null, null },
                    { 527, 0, "Hiking", null, null },
                    { 526, 0, "Highland games", null, null },
                    { 525, 0, "High power rifle", null, null },
                    { 524, 0, "High jump", null, null },
                    { 523, 0, "Hide and seek", null, null },
                    { 522, 0, "Herping", null, null },
                    { 521, 0, "Heptathlon", null, null },
                    { 520, 0, "Headis", null, null },
                    { 519, 0, "Haxey Hood", null, null },
                    { 518, 0, "Harrow football", null, null },
                    { 517, 0, "Harpastum", null, null },
                    { 516, 0, "Harness racing", null, null },
                    { 533, 0, "Home Repair", null, null },
                    { 534, 0, "Home Theater", null, null },
                    { 535, 0, "Home roasting coffee", null, null },
                    { 536, 0, "Homebrewing", null, null },
                    { 554, 0, "Hula Hooping", null, null },
                    { 553, 0, "House of cards", null, null },
                    { 552, 0, "Hot box", null, null },
                    { 551, 0, "Hot air ballooning", null, null },
                    { 550, 0, "Hot Air Balloon Racing", null, null },
                    { 549, 0, "Horseshoes", null, null },
                    { 548, 0, "Horseshoe", null, null },
                    { 547, 0, "Horseball", null, null },
                    { 597, 0, "Internet", null, null },
                    { 546, 0, "Horseback riding", null, null },
                    { 544, 0, "Horse racing", null, null },
                    { 543, 0, "Horse polo", null, null },
                    { 542, 0, "Hornussen", null, null },
                    { 541, 0, "Horizontal bar", null, null },
                    { 540, 0, "Hopper balloon", null, null },
                    { 539, 0, "Hooverball", null, null },
                    { 538, 0, "Hooping", null, null },
                    { 537, 0, "Hoop", null, null },
                    { 545, 0, "Horse riding", null, null },
                    { 515, 0, "Hare coursing", null, null },
                    { 598, 0, "Inventing", null, null },
                    { 600, 0, "Jacquet", null, null },
                    { 660, 0, "Kitesurfing", null, null },
                    { 659, 0, "Kites", null, null },
                    { 658, 0, "Kite landboarding", null, null },
                    { 657, 0, "Kite flying", null, null },
                    { 656, 0, "Kite fighting", null, null },
                    { 655, 0, "Kite buggy", null, null },
                    { 654, 0, "Kite Boarding", null, null },
                    { 653, 0, "Kite", null, null },
                    { 652, 0, "Kitchen Chemistry", null, null },
                    { 651, 0, "Kinomichi", null, null },
                    { 650, 0, "Kin-Ball", null, null },
                    { 649, 0, "Killer", null, null },
                    { 648, 0, "Kilikiti", null, null },
                    { 647, 0, "Kickboxing", null, null },
                    { 646, 0, "Kickball", null, null },
                    { 645, 0, "Kick the can", null, null },
                    { 644, 0, "Ki-o-rahi", null, null },
                    { 661, 0, "Knapping", null, null },
                    { 643, 0, "Kho kho", null, null },
                    { 662, 0, "Knattleikr", null, null },
                    { 664, 0, "Knife making", null, null },
                    { 681, 0, "Lace", null, null },
                    { 680, 0, "La soule", null, null },
                    { 679, 0, "LARPing", null, null },
                    { 678, 0, "Kyūjutsu", null, null },
                    { 677, 0, "Kyūdō", null, null },
                    { 676, 0, "Kurash", null, null },
                    { 675, 0, "Kumdo", null, null },
                    { 674, 0, "Kuk Sool Won", null, null },
                    { 673, 0, "Kubb", null, null },
                    { 672, 0, "Kronum", null, null },
                    { 671, 0, "Krav Maga", null, null },
                    { 670, 0, "Krabi-krabong", null, null },
                    { 669, 0, "Korfball", null, null },
                    { 668, 0, "Kombucha", null, null },
                    { 667, 0, "Knotting", null, null },
                    { 666, 0, "Knitting", null, null },
                    { 665, 0, "Knife throwing", null, null },
                    { 663, 0, "Kneeboarding", null, null },
                    { 642, 0, "Kenpō", null, null },
                    { 641, 0, "Kenjutsu", null, null },
                    { 640, 0, "Kendo", null, null },
                    { 617, 0, "Judo", null, null },
                    { 616, 0, "Jousting", null, null },
                    { 615, 0, "Jorkyball", null, null },
                    { 614, 0, "Jogo do pau", null, null },
                    { 613, 0, "Jogging", null, null },
                    { 612, 0, "Jigsaw puzzles", null, null },
                    { 611, 0, "Jigsaw Puzzles", null, null },
                    { 610, 0, "Jewelry making", null, null },
                    { 609, 0, "Jewelry Making", null, null },
                    { 608, 0, "Jeu provençal", null, null },
                    { 607, 0, "Jeu de paume", null, null },
                    { 606, 0, "Jet sprint boat racing", null, null },
                    { 605, 0, "Jet Engines", null, null },
                    { 604, 0, "Jeet Kune Do", null, null },
                    { 603, 0, "Javelin throw", null, null },
                    { 602, 0, "Janggi", null, null },
                    { 601, 0, "Jai alai", null, null },
                    { 618, 0, "Jugger", null, null },
                    { 619, 0, "Juggling", null, null },
                    { 620, 0, "Juggling club", null, null },
                    { 621, 0, "Jujutsu", null, null },
                    { 639, 0, "Kemari", null, null },
                    { 638, 0, "Kelly pool", null, null },
                    { 637, 0, "Keepie uppie", null, null },
                    { 636, 0, "Keep away", null, null },
                    { 635, 0, "Keep A Journal", null, null },
                    { 634, 0, "Kayaking", null, null },
                    { 633, 0, "Kart racing", null, null },
                    { 632, 0, "Karate", null, null },
                    { 599, 0, "Isle of Man TT", null, null },
                    { 631, 0, "Kalarippayattu", null, null },
                    { 629, 0, "Kabaddi", null, null },
                    { 628, 0, "Jūkendō", null, null },
                    { 627, 0, "Jōdō", null, null },
                    { 626, 0, "Juttejutsu", null, null },
                    { 625, 0, "Jumping", null, null },
                    { 624, 0, "Jump rope", null, null },
                    { 623, 0, "Jump Roping", null, null },
                    { 622, 0, "Jukskei", null, null },
                    { 630, 0, "Kajukenbo", null, null },
                    { 514, 0, "Hardcourt Bike Polo", null, null },
                    { 513, 0, "Hapsagai", null, null },
                    { 512, 0, "Hapkido", null, null },
                    { 404, 0, "Fistball", null, null },
                    { 403, 0, "Fishkeeping", null, null },
                    { 402, 0, "Fishing", null, null },
                    { 401, 0, "Fire baton twirling", null, null },
                    { 400, 0, "Fire Poi", null, null },
                    { 399, 0, "Finswimming", null, null },
                    { 398, 0, "Film memorabilia", null, null },
                    { 397, 0, "Figure skating", null, null },
                    { 396, 0, "Field target", null, null },
                    { 395, 0, "Field lacrosse", null, null },
                    { 394, 0, "Field hockey", null, null },
                    { 393, 0, "Field handball", null, null },
                    { 392, 0, "Field archery", null, null },
                    { 391, 0, "Fencing", null, null },
                    { 390, 0, "Felting", null, null },
                    { 389, 0, "Fastnet", null, null },
                    { 388, 0, "Fast-pitch softball", null, null },
                    { 405, 0, "Five-a-side football", null, null },
                    { 387, 0, "Fast cars", null, null },
                    { 406, 0, "Five-pins", null, null },
                    { 408, 0, "Flag Football", null, null },
                    { 425, 0, "Footbag", null, null },
                    { 424, 0, "Folkrace", null, null },
                    { 423, 0, "Folk wrestling", null, null },
                    { 422, 0, "Flying trapeze", null, null },
                    { 421, 0, "Flying disc games", null, null },
                    { 420, 0, "Flying disc freestyle", null, null },
                    { 419, 0, "Flying disc", null, null },
                    { 418, 0, "Flyak", null, null },
                    { 417, 0, "Fly fishing", null, null },
                    { 416, 0, "Fly Tying", null, null },
                    { 415, 0, "Flutterguts", null, null },
                    { 414, 0, "Flower arranging", null, null },
                    { 413, 0, "Floral Arrangements", null, null },
                    { 412, 0, "Floorball", null, null },
                    { 411, 0, "Floor", null, null },
                    { 410, 0, "Flight archery", null, null },
                    { 409, 0, "Flag football", null, null },
                    { 407, 0, "Fives", null, null },
                    { 386, 0, "Fashion", null, null },
                    { 385, 0, "Falconry", null, null },
                    { 384, 0, "F1 Powerboat World Championship", null, null },
                    { 361, 0, "Element collecting", null, null },
                    { 360, 0, "Electronics", null, null },
                    { 359, 0, "Eight-man football", null, null },
                    { 358, 0, "Eight-ball", null, null },
                    { 357, 0, "Egyptian stick fencing", null, null },
                    { 356, 0, "Egg and spoon race", null, null },
                    { 355, 0, "Educational Courses", null, null },
                    { 354, 0, "Eating out", null, null },
                    { 353, 0, "Dumpster Diving", null, null },
                    { 352, 0, "Dumog", null, null },
                    { 351, 0, "Duathlon", null, null },
                    { 350, 0, "Drum and bugle corps", null, null },
                    { 349, 0, "Driving", null, null },
                    { 348, 0, "Drifting", null, null },
                    { 347, 0, "Dressage", null, null },
                    { 346, 0, "Drawing", null, null },
                    { 345, 0, "Draughts", null, null },
                    { 362, 0, "Elephant polo", null, null },
                    { 363, 0, "Embroidery", null, null },
                    { 364, 0, "Endurance", null, null },
                    { 365, 0, "Endurance racing", null, null },
                    { 383, 0, "Extreme ironing", null, null }
                });

            migrationBuilder.InsertData(
                table: "Hobbies",
                columns: new[] { "HobbyID", "HobbyActivationLevel", "HobbyName", "LocationID", "UserID" },
                values: new object[,]
                {
                    { 382, 0, "Exhibition drill", null, null },
                    { 381, 0, "Exercise", null, null },
                    { 380, 0, "Eventing", null, null },
                    { 379, 0, "Eton wall game", null, null },
                    { 378, 0, "Eton field game", null, null },
                    { 377, 0, "Eton Fives", null, null },
                    { 376, 0, "Eton College", null, null },
                    { 426, 0, "Footbag net", null, null },
                    { 375, 0, "Eskrima", null, null },
                    { 373, 0, "Equestrianism", null, null },
                    { 372, 0, "Equestrian vaulting", null, null },
                    { 371, 0, "Episkyros", null, null },
                    { 370, 0, "Entertaining", null, null },
                    { 369, 0, "English pleasure", null, null },
                    { 368, 0, "English billiards", null, null },
                    { 367, 0, "Enduro", null, null },
                    { 366, 0, "Endurance riding", null, null },
                    { 374, 0, "Equitation", null, null },
                    { 427, 0, "Football", null, null },
                    { 428, 0, "Football tennis", null, null },
                    { 429, 0, "Footvolley", null, null },
                    { 489, 0, "Graffiti", null, null },
                    { 488, 0, "Gongoozler", null, null },
                    { 487, 0, "Golf", null, null },
                    { 486, 0, "Going to movies", null, null },
                    { 485, 0, "Goaltimate", null, null },
                    { 484, 0, "Goalball", null, null },
                    { 483, 0, "Go-Moku", null, null },
                    { 482, 0, "Go Kart Racing", null, null },
                    { 481, 0, "Go", null, null },
                    { 480, 0, "Gnoming", null, null },
                    { 479, 0, "Glowsticking", null, null },
                    { 478, 0, "Glima", null, null },
                    { 477, 0, "Gliding", null, null },
                    { 476, 0, "Glassblowing", null, null },
                    { 475, 0, "Gig racing", null, null },
                    { 474, 0, "Ghost hunting", null, null },
                    { 473, 0, "Ghost Hunting", null, null },
                    { 490, 0, "Grand Prix motorcycle racing", null, null },
                    { 491, 0, "Grasstrack", null, null },
                    { 492, 0, "Greco-Roman wrestling", null, null },
                    { 493, 0, "Greek wrestling", null, null },
                    { 511, 0, "Hang gliding", null, null },
                    { 510, 0, "Handwriting Analysis", null, null },
                    { 509, 0, "Handball", null, null },
                    { 508, 0, "Hana Ichi Monme", null, null },
                    { 507, 0, "Hammer throw", null, null },
                    { 506, 0, "Half marathon", null, null },
                    { 505, 0, "Hala", null, null },
                    { 504, 0, "Haggis hurling", null, null },
                    { 472, 0, "Geocaching", null, null },
                    { 503, 0, "Gyotaku", null, null },
                    { 501, 0, "Gymkhana", null, null },
                    { 500, 0, "Guts", null, null },
                    { 499, 0, "Gunsmithing", null, null },
                    { 498, 0, "Gungdo", null, null },
                    { 497, 0, "Gun Collecting", null, null },
                    { 496, 0, "Guitar", null, null },
                    { 495, 0, "Grip Strength", null, null },
                    { 494, 0, "Gridiron football", null, null },
                    { 502, 0, "Gymnastics", null, null },
                    { 343, 0, "Dragon boat", null, null },
                    { 471, 0, "Geo caching", null, null },
                    { 469, 0, "Gatka", null, null },
                    { 446, 0, "Freestyle football", null, null },
                    { 445, 0, "Freestyle footbag", null, null },
                    { 444, 0, "Freestyle Motocross", null, null },
                    { 443, 0, "Freestyle BMX", null, null },
                    { 442, 0, "Freediving", null, null },
                    { 441, 0, "Freeboating", null, null },
                    { 440, 0, "Freeboard", null, null },
                    { 439, 0, "Free running", null, null },
                    { 438, 0, "Fox hunting", null, null },
                    { 437, 0, "Four-ball billiards", null, null },
                    { 436, 0, "Four square", null, null },
                    { 435, 0, "Four Wheeling", null, null },
                    { 434, 0, "Fossil hunting", null, null },
                    { 433, 0, "Formula racing", null, null },
                    { 432, 0, "Formula Student", null, null },
                    { 431, 0, "Formula Libre", null, null },
                    { 430, 0, "Foraging", null, null },
                    { 447, 0, "Freestyle scootering", null, null },
                    { 448, 0, "Freestyle skiing", null, null },
                    { 449, 0, "Freestyle slalom skating", null, null },
                    { 450, 0, "Freestyle snowboarding", null, null },
                    { 468, 0, "Gateball", null, null },
                    { 467, 0, "Gardening", null, null },
                    { 466, 0, "Garage Saleing", null, null },
                    { 465, 0, "Games involving opponents hitting a ball against a wall/walls using a racket, or other piece of equipment, or merely gloved/barehanded.", null, null },
                    { 464, 0, "Games", null, null },
                    { 463, 0, "Gambling", null, null },
                    { 462, 0, "Gaelic handball", null, null },
                    { 461, 0, "Gaelic football", null, null },
                    { 470, 0, "Genealogy", null, null },
                    { 460, 0, "Ga-ga", null, null },
                    { 458, 0, "Fullbore target rifle", null, null },
                    { 457, 0, "Fujian White Crane", null, null },
                    { 456, 0, "Frisian handball", null, null },
                    { 455, 0, "Frisbee Golf – Frolf", null, null },
                    { 454, 0, "Fricket", null, null },
                    { 453, 0, "Freshwater Aquariums", null, null },
                    { 452, 0, "Freestyle wrestling", null, null },
                    { 451, 0, "Freestyle swimming", null, null },
                    { 459, 0, "Futsal", null, null },
                    { 3, 0, "Acting", null, null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 288);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 292);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 294);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 295);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 296);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 297);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 298);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 299);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 304);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 305);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 306);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 307);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 308);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 309);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 310);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 311);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 312);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 313);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 314);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 315);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 316);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 317);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 318);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 319);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 320);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 321);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 322);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 323);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 324);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 325);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 326);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 327);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 328);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 329);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 330);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 331);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 332);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 333);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 334);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 335);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 336);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 337);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 338);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 339);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 340);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 341);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 342);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 343);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 344);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 345);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 346);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 347);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 348);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 349);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 350);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 351);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 352);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 353);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 354);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 355);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 356);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 357);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 358);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 359);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 360);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 361);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 362);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 363);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 364);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 365);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 366);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 367);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 368);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 369);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 370);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 371);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 372);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 373);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 374);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 375);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 376);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 377);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 378);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 379);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 380);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 381);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 382);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 383);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 384);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 385);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 386);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 387);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 388);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 389);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 390);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 391);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 392);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 393);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 394);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 395);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 396);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 397);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 398);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 399);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 400);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 401);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 402);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 403);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 404);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 405);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 406);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 407);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 408);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 409);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 410);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 411);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 412);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 413);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 414);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 415);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 416);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 417);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 418);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 419);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 420);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 421);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 422);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 423);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 424);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 425);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 426);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 427);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 428);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 429);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 430);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 431);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 432);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 433);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 434);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 435);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 436);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 437);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 438);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 439);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 440);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 441);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 442);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 443);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 444);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 445);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 446);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 447);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 448);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 449);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 450);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 451);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 452);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 453);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 454);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 455);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 456);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 457);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 458);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 459);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 460);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 461);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 462);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 463);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 464);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 465);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 466);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 467);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 468);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 469);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 470);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 471);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 472);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 473);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 474);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 475);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 476);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 477);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 478);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 479);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 480);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 481);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 482);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 483);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 484);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 485);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 486);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 487);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 488);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 489);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 490);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 491);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 492);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 493);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 494);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 495);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 496);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 497);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 498);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 499);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 500);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 501);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 502);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 503);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 504);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 505);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 506);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 507);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 508);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 509);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 510);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 511);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 512);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 513);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 514);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 515);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 516);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 517);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 518);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 519);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 520);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 521);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 522);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 523);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 524);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 525);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 526);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 527);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 528);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 529);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 530);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 531);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 532);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 533);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 534);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 535);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 536);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 537);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 538);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 539);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 540);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 541);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 542);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 543);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 544);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 545);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 546);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 547);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 548);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 549);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 550);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 551);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 552);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 553);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 554);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 555);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 556);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 557);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 558);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 559);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 560);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 561);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 562);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 563);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 564);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 565);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 566);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 567);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 568);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 569);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 570);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 571);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 572);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 573);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 574);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 575);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 576);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 577);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 578);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 579);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 580);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 581);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 582);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 583);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 584);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 585);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 586);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 587);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 588);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 589);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 590);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 591);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 592);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 593);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 594);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 595);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 596);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 597);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 598);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 599);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 600);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 601);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 602);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 603);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 604);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 605);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 606);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 607);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 608);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 609);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 610);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 611);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 612);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 613);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 614);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 615);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 616);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 617);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 618);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 619);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 620);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 621);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 622);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 623);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 624);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 625);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 626);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 627);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 628);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 629);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 630);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 631);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 632);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 633);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 634);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 635);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 636);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 637);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 638);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 639);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 640);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 641);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 642);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 643);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 644);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 645);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 646);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 647);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 648);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 649);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 650);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 651);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 652);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 653);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 654);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 655);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 656);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 657);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 658);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 659);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 660);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 661);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 662);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 663);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 664);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 665);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 666);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 667);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 668);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 669);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 670);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 671);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 672);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 673);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 674);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 675);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 676);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 677);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 678);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 679);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 680);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 681);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 682);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 683);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 684);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 685);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 686);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 687);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 688);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 689);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 690);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 691);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 692);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 693);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 694);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 695);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 696);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 697);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 698);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 699);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 700);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 701);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 702);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 703);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 704);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 705);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 706);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 707);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 708);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 709);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 710);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 711);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 712);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 713);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 714);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 715);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 716);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 717);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 718);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 719);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 720);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 721);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 722);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 723);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 724);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 725);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 726);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 727);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 728);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 729);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 730);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 731);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 732);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 733);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 734);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 735);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 736);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 737);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 738);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 739);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 740);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 741);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 742);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 743);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 744);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 745);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 746);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 747);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 748);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 749);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 750);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 751);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 752);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 753);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 754);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 755);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 756);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 757);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 758);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 759);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 760);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 761);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 762);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 763);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 764);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 765);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 766);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 767);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 768);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 769);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 770);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 771);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 772);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 773);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 774);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 775);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 776);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 777);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 778);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 779);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 780);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 781);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 782);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 783);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 784);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 785);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 786);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 787);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 788);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 789);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 790);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 791);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 792);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 793);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 794);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 795);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 796);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 797);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 798);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 799);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 800);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 801);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 802);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 803);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 804);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 805);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 806);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 807);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 808);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 809);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 810);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 811);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 812);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 813);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 814);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 815);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 816);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 817);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 818);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 819);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 820);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 821);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 822);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 823);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 824);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 825);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 826);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 827);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 828);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 829);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 830);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 831);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 832);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 833);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 834);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 835);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 836);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 837);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 838);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 839);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 840);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 841);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 842);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 843);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 844);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 845);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 846);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 847);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 848);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 849);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 850);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 851);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 852);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 853);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 854);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 855);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 856);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 857);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 858);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 859);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 860);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 861);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 862);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 863);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 864);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 865);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 866);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 867);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 868);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 869);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 870);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 871);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 872);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 873);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 874);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 875);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 876);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 877);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 878);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 879);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 880);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 881);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 882);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 883);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 884);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 885);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 886);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 887);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 888);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 889);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 890);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 891);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 892);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 893);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 894);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 895);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 896);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 897);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 898);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 899);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 900);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 901);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 902);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 903);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 904);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 905);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 906);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 907);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 908);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 909);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 910);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 911);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 912);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 913);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 914);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 915);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 916);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 917);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 918);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 919);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 920);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 921);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 922);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 923);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 924);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 925);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 926);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 927);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 928);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 929);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 930);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 931);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 932);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 933);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 934);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 935);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 936);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 937);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 938);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 939);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 940);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 941);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 942);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 943);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 944);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 945);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 946);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 947);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 948);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 949);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 950);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 951);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 952);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 953);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 954);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 955);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 956);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 957);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 958);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 959);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 960);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 961);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 962);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 963);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 964);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 965);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 966);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 967);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 968);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 969);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 970);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 971);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 972);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 973);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 974);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 975);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 976);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 977);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 978);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 979);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 980);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 981);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 982);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 983);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 984);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 985);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 986);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 987);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 988);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 989);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 990);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 991);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 992);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 993);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 994);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 995);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 996);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 997);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 998);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 999);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1000);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1001);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1002);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1003);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1004);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1005);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1006);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1007);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1008);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1009);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1010);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1011);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1012);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1013);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1014);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1015);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1016);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1017);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1018);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1019);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1020);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1021);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1022);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1023);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1024);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1025);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1026);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1027);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1028);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1029);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1030);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1031);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1032);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1033);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1034);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1035);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1036);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1037);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1038);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1039);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1040);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1041);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1042);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1043);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1044);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1045);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1046);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1047);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1048);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1049);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1050);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1051);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1052);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1053);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1054);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1055);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1056);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1057);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1058);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1059);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1060);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1061);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1062);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1063);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1064);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1065);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1066);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1067);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1068);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1069);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1070);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1071);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1072);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1073);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1074);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1075);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1076);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1077);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1078);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1079);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1080);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1081);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1082);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1083);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1084);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1085);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1086);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1087);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1088);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1089);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1090);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1091);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1092);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1093);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1094);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1095);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1096);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1097);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1098);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1099);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1100);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1101);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1102);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1103);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1104);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1105);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1106);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1107);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1108);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1109);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1110);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1111);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1112);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1113);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1114);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1115);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1116);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1117);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1118);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1119);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1120);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1121);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1122);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1123);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1124);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1125);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1126);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1127);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1128);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1129);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1130);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1131);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1132);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1133);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1134);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1135);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1136);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1137);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1138);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1139);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1140);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1141);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1142);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1143);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1144);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1145);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1146);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1147);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1148);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1149);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1150);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1151);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1152);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1153);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1154);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1155);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1156);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1157);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1158);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1159);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1160);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1161);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1162);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1163);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1164);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1165);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1166);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1167);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1168);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1169);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1170);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1171);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1172);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1173);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1174);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1175);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1176);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1177);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1178);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1179);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1180);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1181);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1182);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1183);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1184);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1185);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1186);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1187);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1188);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1189);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1190);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1191);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1192);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1193);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1194);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1195);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1196);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1197);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1198);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1199);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1200);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1201);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1202);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1203);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1204);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1205);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1206);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1207);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1208);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1209);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1210);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1211);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1212);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1213);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1214);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1215);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1216);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1217);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1218);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1219);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1220);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1221);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1222);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1223);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1224);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1225);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1226);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1227);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1228);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1229);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1230);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1231);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1232);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1233);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1234);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1235);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1236);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1237);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1238);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1239);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1240);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1241);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1242);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1243);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1244);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1245);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1246);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1247);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1248);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1249);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1250);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1251);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1252);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1253);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1254);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1255);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1256);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1257);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1258);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1259);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1260);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1261);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1262);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1263);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1264);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1265);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1266);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1267);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1268);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1269);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1270);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1271);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1272);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1273);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1274);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1275);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1276);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1277);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1278);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1279);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1280);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1281);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1282);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1283);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1284);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1285);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1286);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1287);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1288);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1289);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1290);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1291);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1292);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1293);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1294);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1295);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1296);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1297);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1298);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1299);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1300);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1301);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1302);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1303);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1304);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1305);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1306);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1307);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1308);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1309);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1310);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1311);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1312);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1313);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1314);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1315);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1316);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1317);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1318);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1319);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1320);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1321);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1322);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1323);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1324);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1325);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1326);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1327);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1328);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1329);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1330);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1331);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1332);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1333);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1334);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1335);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1336);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1337);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1338);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1339);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1340);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1341);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1342);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1343);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1344);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1345);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1346);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1347);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1348);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1349);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1350);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1351);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1352);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1353);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1354);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1355);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1356);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1357);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1358);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1359);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1360);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1361);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1362);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1363);

            migrationBuilder.UpdateData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1,
                columns: new[] { "HobbyActivationLevel", "HobbyName" },
                values: new object[] { 2, "Badminton" });

            migrationBuilder.UpdateData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 2,
                columns: new[] { "HobbyActivationLevel", "HobbyName" },
                values: new object[] { 2, "Tennis" });
        }
    }
}
