using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje_1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Şehir indekslerinin plaka numarası ile aynı olması için sıfırıncı indeks boş.
            string[] provinces = new string[]
            {
            " ", "Adana", "Adıyaman", "Afyonkarahisar", "Ağrı", "Amasya", "Ankara", "Antalya", "Artvin", "Aydın",
            "Balıkesir", "Bilecik", "Bingöl", "Bitlis", "Bolu", "Burdur", "Bursa", "Çanakkale", "Çankırı", "Çorum",
            "Denizli", "Diyarbakır", "Edirne", "Elazığ", "Erzincan", "Erzurum", "Eskişehir", "Gaziantep", "Giresun",
            "Gümüşhane", "Hakkari", "Hatay", "Isparta", "Mersin", "Istanbul", "Izmir", "Kars", "Kastamonu", "Kayseri",
            "Kırklareli", "Kırşehir", "Kocaeli", "Konya", "Kütahya", "Malatya", "Manisa", "Kahramanmaraş", "Mardin",
            "Muğla", "Muş", "Nevşehir", "Niğde", "Ordu", "Rize", "Sakarya", "Samsun", "Siirt", "Sinop", "Sivas",
            "Tekirdağ", "Tokat", "Trabzon", "Tunceli", "Şanlıurfa", "Uşak", "Van", "Yozgat", "Zonguldak", "Aksaray",
            "Bayburt", "Karaman", "Kırıkkale", "Batman", "Şırnak", "Bartın", "Ardahan", "Iğdır", "Yalova", "Karabük",
            "Kilis", "Osmaniye", "Düzce"
            };
            

            int[][] distances = new int[81][];

            distances [0] = new int[0] { };
            distances [1] = new int[1] { 337 };
            distances [2] = new int[2] { 578, 915 };
            distances [3] = new int[3] { 973, 642, 1320 };
            distances [4] = new int[4] { 603, 627, 596, 740 };
            distances [5] = new int[5] { 492, 732, 255, 1055, 331 };
            distances [6] = new int[6] { 547, 884, 287, 1424, 823, 542 };
            distances [7] = new int[7] { 1001, 715, 1224, 364, 679, 960, 1430 };
            distances [8] = new int[8] { 880, 1217, 340, 1634, 935, 595, 345, 1564 };
            distances [9] = new int[9] { 902, 1239, 324, 1579, 845, 536, 505, 1454, 291 };

            distances [10] = new int[10] { 785, 1032, 207, 1361, 626, 314, 472, 1236, 525, 257 };
            distances [11] = new int[11] { 631, 347, 1096, 352, 641, 887, 1188, 371, 1398, 1410, 1187 };
            distances [12] = new int[12] { 741, 410, 1287, 232, 832, 1078, 1288, 545, 1589, 1601, 1378, 192 };
            distances [13] = new int[13] { 688, 920, 417, 1146, 411, 190, 682, 1021, 735, 434, 215, 1075, 1266 };
            distances [14] = new int[14] { 648, 985, 166, 1402, 761, 421, 121, 1390, 286, 393, 351, 1166, 1357, 561 };
            distances [15] = new int[15] { 856, 1104, 278, 1418, 683, 385, 543, 1293, 441, 152, 95, 1259, 1450, 272, 422 };
            distances [16] = new int[16] { 1096, 1383, 517, 1697, 962, 665, 695, 1572, 448, 194, 374, 1538, 1729, 551, 588, 269 };
            distances [17] = new int[17] { 587, 763, 398, 986, 247, 131, 685, 881, 737, 666, 447, 918, 1109, 233, 564, 504, 783 };
            distances [18] = new int[18] { 582, 697, 504, 831, 91, 240, 732, 720, 844, 785, 563, 762, 953, 349, 670, 634, 914, 155 };
            distances [19] = new int[19] { 762, 1099, 222, 1516, 817, 477, 227, 1446, 131, 292, 407, 1280, 1471, 617, 168, 442, 482, 620, 726 };

            distances [20] = new int[20] { 537, 206, 1108, 436, 706, 898, 1084, 509, 1409, 1421, 1199, 141, 204, 1086, 1177, 1270, 1550, 929, 773, 1291 };
            distances [21] = new int[21] { 1183, 1415, 682, 1641, 906, 685, 922, 1516, 667, 419, 480, 1570, 1761, 495, 826, 428, 232, 727, 844, 709, 1581 };
            distances [22] = new int[22] { 494, 283, 959, 492, 538, 749, 1051, 511, 1260, 1272, 1050, 141, 332, 937, 1028, 1121, 1401, 780, 605, 1142, 152, 1432 };
            distances [23] = new int[23] { 676, 546, 955, 370, 375, 690, 1059, 376, 1269, 1214, 996, 272, 463, 781, 1037, 1053, 1332, 621, 466, 1151, 407, 1276, 267 };
            distances [24] = new int[24] { 807, 521, 1140, 182, 560, 876, 1244, 194, 1454, 1400, 1181, 177, 351, 966, 1222, 1238, 1517, 807, 651, 1336, 315, 1461, 317, 191 };
            distances [25] = new int[25] { 690, 952, 141, 1298, 574, 233, 421, 1202, 474, 303, 80, 1107, 1298, 290, 300, 152, 431, 376, 482, 356, 1119, 555, 970, 933, 1118 };
            distances [26] = new int[26] { 216, 151, 794, 757, 577, 647, 763, 846, 1096, 1118, 948, 476, 525, 836, 864, 1020, 1299, 678, 613, 978, 321, 1330, 338, 602, 652, 868 };
            distances [27] = new int[27] { 720, 705, 867, 538, 322, 603, 1094, 357, 1207, 1098, 879, 536, 710, 664, 1033, 936, 1215, 524, 363, 1089, 674, 1159, 555, 294, 359, 845, 694 };
            distances [28] = new int[28] { 789, 686, 1026, 390, 431, 762, 1172, 320, 1366, 1256, 1038, 388, 562, 823, 1150, 1095, 1374, 683, 522, 1248, 526, 1318, 407, 145, 211, 1004, 763, 159 };
            distances [29] = new int[29] { 901, 654, 1480, 424, 1164, 1333, 1448, 755, 1781, 1804, 1633, 492, 324, 1521, 1550, 1705, 1984, 1364, 1252, 1663, 483, 2016, 631, 794, 606, 1553, 685, 963, 814 };

            distances [30] = new int[30] { 196, 316, 774, 951, 675, 688, 743, 980, 1076, 1098, 981, 610, 720, 884, 844, 1052, 1291, 776, 711, 958, 515, 1379, 472, 748, 786, 886, 194, 791, 861, 880 };
            distances [31] = new int[31] { 618, 956, 167, 1372, 723, 383, 131, 1352, 288, 395, 352, 1136, 1327, 562, 30, 423, 590, 526, 632, 170, 1148, 828, 999, 1007, 1192, 301, 834, 995, 1120, 1520, 814 };
            distances [32] = new int[32] { 70, 407, 571, 1043, 636, 484, 466, 1071, 810, 895, 778, 701, 811, 681, 574, 849, 1088, 580, 575, 693, 606, 1176, 564, 746, 877, 683, 286, 790, 859, 971, 265, 563 };
            distances [33] = new int[33] { 951, 1183, 450, 1409, 674, 453, 715, 1284, 682, 393, 248, 1338, 1529, 263, 594, 244, 316, 495, 612, 650, 1349, 232, 1200, 1044, 1229, 323, 1098, 927, 1086, 1784, 1147, 595, 943 };
            distances [34] = new int[34] { 907, 1244, 328, 1648, 924, 584, 448, 1552, 128, 175, 430, 1425, 1616, 607, 389, 325, 327, 726, 833, 234, 1436, 546, 1287, 1283, 1468, 413, 1123, 1195, 1354, 1808, 1102, 391, 899, 566 };
            distances [35] = new int[35] { 1012, 726, 1342, 214, 762, 1078, 1447, 203, 1656, 1602, 1383, 382, 447, 1168, 1425, 1440, 1719, 1009, 854, 1538, 520, 1663, 522, 393, 205, 1321, 857, 561, 413, 554, 991, 1395, 1082, 1431, 1671 };
            distances [36] = new int[36] { 693, 868, 503, 990, 255, 237, 790, 846, 843, 680, 462, 892, 1083, 247, 669, 518, 798, 106, 193, 725, 959, 741, 791, 625, 810, 482, 784, 489, 648, 1414, 882, 631, 686, 509, 832, 1013 };
            distances [37] = new int[37] { 335, 414, 523, 816, 343, 315, 615, 822, 824, 847, 616, 569, 760, 504, 593, 688, 967, 346, 281, 706, 581, 998, 432, 451, 636, 536, 330, 494, 564, 1015, 428, 563, 328, 766, 851, 838, 452 };
            distances [38] = new int[38] { 1159, 1391, 659, 1617, 883, 662, 924, 1492, 681, 433, 457, 1547, 1738, 471, 803, 443, 246, 704, 821, 723, 1558, 68, 1409, 1252, 1438, 532, 1307, 1135, 1294, 1992, 1355, 804, 1152, 209, 560, 1640, 718, 975 };
            distances [39] = new int[39] { 377, 549, 425, 940, 312, 183, 568, 941, 765, 706, 483, 704, 895, 371, 546, 555, 834, 214, 221, 647, 715, 866, 566, 575, 760, 403, 465, 584, 688, 1150, 562, 516, 369, 634, 753, 962, 319, 133, 842 };

            distances [40] = new int[40] { 840, 1072, 340, 1298, 563, 342, 605, 1173, 569, 280, 138, 1227, 1418, 152, 483, 131, 398, 385, 502, 540, 1239, 345, 1090, 933, 1118, 213, 988, 816, 975, 1673, 1036, 485, 833, 113, 453, 1321, 399, 656, 321, 523 };
            distances [41] = new int[41] { 357, 695, 226, 1111, 510, 259, 320, 1117, 527, 550, 433, 875, 1066, 455, 296, 504, 743, 354, 419, 410, 887, 908, 738, 746, 932, 337, 573, 781, 859, 1259, 553, 266, 350, 676, 554, 1134, 460, 302, 885, 255, 566 };
            distances [42] = new int[42] { 675, 1012, 97, 1377, 652, 312, 361, 1281, 414, 227, 110, 1193, 1384, 321, 240, 182, 421, 455, 561, 296, 1204, 586, 1055, 1012, 1197, 79, 891, 924, 1083, 1576, 871, 242, 668, 354, 335, 1399, 567, 619, 562, 482, 243, 323 };
            distances [43] = new int[43] { 397, 186, 861, 585, 460, 652, 953, 605, 1163, 1175, 953, 235, 426, 840, 931, 1024, 1304, 683, 527, 1045, 246, 1335, 97, 361, 411, 872, 241, 538, 501, 725, 375, 901, 466, 1103, 1190, 615, 713, 335, 1312, 469, 993, 641, 958 };
            distances [44] = new int[44] { 886, 1223, 307, 1627, 903, 562, 427, 1531, 152, 138, 393, 1403, 1594, 570, 368, 288, 328, 705, 812, 213, 1415, 556, 1266, 1262, 1447, 392, 1102, 1174, 1333, 1787, 1081, 370, 878, 529, 37, 1650, 811, 830, 570, 732, 417, 533, 314, 1169 };
            distances [45] = new int[45] { 197, 162, 776, 807, 501, 572, 744, 827, 1077, 1095, 873, 457, 573, 760, 846, 944, 1224, 603, 538, 959, 368, 1255, 319, 575, 633, 792, 78, 618, 688, 764, 176, 816, 267, 1023, 1104, 837, 709, 255, 1232, 389, 913, 555, 872, 222, 1083 };
            distances [46] = new int[46] { 542, 294, 1120, 513, 800, 974, 1089, 604, 1422, 1444, 1274, 236, 281, 1162, 1190, 1346, 1625, 1004, 868, 1304, 94, 1657, 247, 501, 410, 1194, 326, 769, 620, 388, 521, 1160, 612, 1424, 1449, 615, 1054, 656, 1633, 791, 1314, 900, 1217, 341, 1428, 404 };
            distances [47] = new int[47] { 856, 1193, 348, 1642, 944, 604, 309, 1572, 98, 389, 533, 1406, 1597, 743, 240, 539, 547, 746, 853, 151, 1418, 766, 1269, 1277, 1463, 482, 1072, 1215, 1374, 1757, 1051, 270, 775, 776, 226, 1665, 852, 833, 780, 773, 666, 536, 423, 1172, 251, 1053, 1398 };
            distances [48] = new int[48] { 741, 455, 1206, 241, 751, 997, 1298, 464, 1507, 1520, 1297, 111, 81, 1185, 1276, 1369, 1648, 1027, 872, 1390, 249, 1680, 251, 381, 270, 1217, 586, 629, 480, 381, 720, 1246, 811, 1447, 1534, 347, 1001, 679, 1656, 814, 1337, 985, 1302, 344, 1513, 566, 362, 1516 };
            distances [49] = new int[49] { 287, 497, 444, 888, 357, 275, 536, 894, 745, 768, 576, 652, 843, 463, 514, 647, 927, 306, 295, 628, 664, 958, 515, 523, 709, 496, 413, 567, 636, 1098, 483, 484, 280, 726, 772, 911, 412, 79, 935, 92, 616, 223, 540, 418, 751, 338, 739, 754, 762 };

            distances [50] = new int[50] { 210, 548, 464, 939, 439, 339, 544, 945, 765, 787, 637, 703, 894, 546, 533, 709, 981, 389, 377, 647, 715, 1041, 566, 574, 760, 557, 426, 618, 687, 1111, 405, 504, 202, 809, 792, 962, 494, 130, 1017, 175, 698, 243, 560, 469, 771, 389, 752, 774, 813, 83 };
            distances [51] = new int[51] { 707, 731, 823, 583, 278, 558, 1050, 402, 1162, 1053, 835, 581, 755, 620, 988, 891, 1171, 480, 319, 1045, 719, 1115, 600, 339, 404, 801, 681, 45, 204, 1007, 779, 951, 777, 882, 1151, 606, 445, 481, 1091, 540, 772, 737, 880, 564, 1130, 605, 814, 1171, 674, 614, 605 };
            distances [52] = new int[52] { 917, 772, 1076, 430, 531, 811, 1303, 148, 1415, 1306, 1088, 428, 602, 873, 1241, 1144, 1424, 733, 572, 1298, 566, 1368, 568, 306, 250, 1054, 891, 209, 172, 854, 989, 1204, 987, 1135, 1404, 344, 698, 692, 1344, 793, 1025, 990, 1133, 662, 1383, 816, 660, 1424, 520, 764, 815, 254 };
            distances [53] = new int[53] { 803, 1035, 302, 1261, 526, 305, 567, 1136, 620, 319, 100, 1190, 1381, 115, 446, 157, 436, 347, 464, 502, 1201, 380, 1052, 896, 1081, 176, 950, 779, 938, 1636, 999, 448, 796, 148, 492, 1283, 361, 618, 357, 486, 37, 528, 206, 955, 455, 875, 1277, 629, 1300, 578, 661, 734, 988 };
            distances [54] = new int[54] { 754, 756, 676, 730, 131, 411, 903, 548, 1016, 906, 688, 718, 909, 473, 842, 745, 1024, 333, 172, 898, 835, 968, 667, 451, 550, 654, 706, 191, 350, 1154, 804, 804, 746, 736, 1004, 752, 298, 453, 944, 393, 625, 590, 733, 589, 983, 630, 929, 1024, 827, 467, 549, 147, 400, 588 };
            distances [55] = new int[55] { 715, 384, 1295, 328, 893, 1085, 1262, 641, 1596, 1608, 1386, 288, 96, 1273, 1364, 1457, 1737, 1116, 960, 1478, 187, 1768, 339, 558, 447, 1306, 499, 806, 658, 291, 694, 1335, 785, 1536, 1623, 542, 1146, 768, 1745, 902, 1426, 1074, 1391, 433, 1602, 547, 235, 1605, 177, 851, 902, 851, 697, 1388, 1022 };
            distances [56] = new int[56] { 865, 882, 675, 893, 257, 409, 962, 711, 1015, 861, 642, 862, 1053, 427, 841, 699, 978, 278, 264, 897, 961, 922, 793, 595, 713, 654, 832, 354, 513, 1317, 929, 803, 857, 690, 1004, 915, 182, 545, 899, 491, 580, 632, 748, 715, 983, 756, 1055, 1024, 971, 584, 666, 310, 563, 542, 163, 1148 };
            distances [57] = new int[57] { 428, 413, 706, 618, 222, 442, 810, 624, 1020, 987, 764, 480, 671, 630, 788, 836, 1115, 444, 289, 902, 492, 1125, 324, 253, 438, 684, 402, 296, 366, 971, 499, 758, 497, 893, 1034, 640, 475, 202, 1101, 326, 782, 498, 763, 246, 1013, 326, 586, 1029, 590, 275, 326, 307, 494, 745, 351, 679, 477 };
            distances [58] = new int[58] { 1082, 1313, 581, 1539, 805, 584, 846, 1414, 617, 369, 379, 1469, 1660, 393, 725, 379, 182, 626, 743, 659, 1480, 148, 1331, 1174, 1360, 454, 1229, 1057, 1216, 1914, 1277, 726, 1074, 131, 496, 1562, 640, 897, 124, 764, 243, 807, 484, 1234, 506, 1154, 1555, 716, 1578, 857, 939, 1013, 1266, 279, 866, 1667, 821, 1023 };
            distances [59] = new int[59] { 492, 516, 645, 674, 113, 380, 872, 616, 984, 926, 703, 584, 775, 522, 810, 775, 1054, 335, 180, 866, 595, 1017, 427, 309, 494, 623, 466, 259, 365, 1074, 564, 772, 562, 785, 973, 696, 366, 267, 994, 332, 674, 559, 701, 349, 952, 391, 689, 993, 693, 339, 390, 215, 468, 637, 242, 782, 368, 111, 916 };

            distances [60] = new int[60] { 838, 778, 997, 482, 452, 733, 1224, 227, 1337, 1228, 1009, 479, 653, 794, 1163, 1066, 1345, 654, 493, 1219, 617, 1289, 499, 237, 302, 975, 812, 130, 102, 906, 910, 1125, 908, 1057, 1325, 422, 619, 613, 1265, 714, 946, 911, 1054, 592, 1304, 737, 712, 1345, 572, 685, 736, 175, 79, 909, 321, 749, 484, 415, 1187, 389 };
            distances [61] = new int[61] { 630, 419, 1078, 418, 498, 813, 1182, 424, 1392, 1338, 1119, 145, 336, 904, 1160, 1176, 1455, 745, 589, 1274, 280, 1399, 140, 128, 239, 1056, 475, 417, 268, 635, 609, 1130, 700, 1167, 1406, 441, 748, 574, 1375, 698, 1056, 869, 1135, 233, 1385, 455, 374, 1400, 254, 646, 697, 462, 430, 1019, 574, 431, 718, 376, 1297, 432, 360 };
            distances [62] = new int[62] { 355, 111, 933, 613, 710, 786, 902, 686, 1234, 1257, 1087, 318, 381, 974, 1003, 1158, 1438, 817, 752, 1117, 177, 1469, 318, 573, 492, 1006, 139, 788, 713, 547, 333, 973, 424, 1237, 1261, 697, 923, 468, 1446, 603, 1127, 712, 1030, 269, 1240, 217, 188, 1210, 426, 552, 564, 814, 742, 1089, 839, 355, 965, 496, 1368, 599, 804, 445 };
            distances [63] = new int[63] { 690, 1027, 112, 1432, 707, 367, 290, 1336, 272, 224, 249, 1208, 1399, 459, 169, 320, 420, 510, 616, 154, 1219, 642, 1070, 1067, 1252, 217, 906, 979, 1138, 1592, 886, 170, 683, 492, 216, 1454, 615, 635, 656, 537, 381, 338, 138, 973, 195, 888, 1232, 280, 1318, 556, 575, 935, 1188, 344, 788, 1406, 787, 818, 592, 756, 1109, 1190, 1045 };
            distances [64] = new int[64] { 900, 569, 1422, 227, 967, 1212, 1447, 558, 1723, 1735, 1513, 327, 159, 1373, 1491, 1584, 1864, 1214, 1058, 1605, 363, 1868, 466, 598, 410, 1433, 684, 766, 618, 197, 879, 1462, 970, 1636, 1750, 357, 1217, 895, 1845, 1029, 1526, 1201, 1518, 560, 1729, 732, 440, 1732, 216, 978, 1029, 811, 657, 1488, 957, 255, 1120, 806, 1767, 901, 709, 470, 540, 1533 };
            distances [65] = new int[65] { 490, 613, 479, 841, 199, 214, 681, 828, 818, 760, 537, 700, 891, 402, 644, 609, 888, 245, 108, 700, 712, 897, 544, 476, 661, 457, 529, 471, 589, 1191, 626, 606, 482, 665, 807, 864, 298, 197, 874, 113, 555, 368, 536, 466, 786, 453, 806, 827, 810, 205, 288, 427, 680, 517, 280, 899, 372, 227, 796, 219, 601, 599, 667, 591, 1026 };
            distances [66] = new int[66] { 764, 996, 483, 1205, 471, 266, 748, 1058, 801, 500, 281, 1107, 1298, 158, 627, 338, 617, 292, 409, 683, 1163, 561, 1014, 841, 1026, 356, 912, 701, 860, 1630, 960, 629, 757, 329, 673, 1228, 214, 580, 538, 447, 218, 531, 387, 916, 636, 836, 1238, 810, 1217, 540, 622, 657, 910, 181, 510, 1350, 394, 691, 460, 582, 831, 964, 1050, 525, 1433, 479 };
            distances [67] = new int[67] { 268, 573, 368, 964, 421, 224, 460, 970, 669, 692, 522, 728, 919, 420, 438, 594, 873, 319, 330, 552, 740, 915, 591, 599, 785, 442, 484, 693, 712, 1169, 464, 408, 261, 683, 696, 987, 425, 155, 891, 108, 572, 147, 464, 494, 675, 414, 810, 678, 838, 76, 116, 648, 840, 535, 501, 927, 597, 351, 813, 415, 761, 722, 623, 480, 1054, 221, 496 };
            distances [68] = new int[68] { 801, 674, 1079, 304, 457, 815, 1183, 310, 1393, 1297, 1078, 302, 476, 863, 1161, 1135, 1414, 704, 548, 1275, 440, 1358, 395, 157, 125, 1057, 730, 234, 86, 728, 872, 1131, 870, 1126, 1407, 327, 723, 575, 1335, 699, 1015, 871, 1136, 489, 1386, 699, 535, 1402, 395, 648, 699, 279, 247, 978, 425, 572, 588, 377, 1257, 391, 177, 256, 617, 1191, 532, 600, 923, 724 };
            distances [69] = new int[69] { 293, 630, 339, 1112, 621, 370, 376, 1118, 641, 663, 546, 876, 1034, 566, 409, 617, 857, 465, 530, 523, 829, 1022, 739, 747, 933, 451, 508, 791, 860, 1194, 488, 379, 233, 789, 668, 1135, 571, 303, 998, 320, 679, 118, 436, 642, 646, 490, 835, 649, 986, 256, 178, 848, 988, 642, 702, 1008, 743, 499, 920, 563, 909, 870, 647, 451, 1202, 433, 642, 212, 872 };

            distances [70] = new int[70] { 483, 658, 338, 985, 260, 74, 562, 889, 678, 619, 397, 813, 1004, 262, 504, 468, 748, 105, 169, 560, 824, 757, 676, 620, 805, 316, 574, 532, 691, 1259, 671, 459, 475, 525, 667, 1007, 210, 242, 733, 109, 414, 250, 395, 578, 645, 498, 900, 687, 923, 201, 284, 488, 741, 377, 341, 1011, 382, 371, 655, 309, 662, 743, 712, 450, 1139, 143, 338, 215, 744, 361 };
            distances [71] = new int[71] { 628, 297, 1207, 365, 805, 998, 1175, 563, 1508, 1521, 1298, 195, 133, 1186, 1277, 1370, 1649, 1029, 873, 1391, 99, 1681, 252, 467, 369, 1218, 412, 728, 580, 374, 607, 1247, 698, 1449, 1535, 580, 1059, 680, 1657, 815, 1338, 986, 1304, 346, 1514, 460, 148, 1517, 214, 763, 814, 773, 620, 1301, 934, 87, 1060, 591, 1579, 694, 671, 340, 268, 1319, 292, 811, 1262, 839, 494, 921, 924 };
            distances [72] = new int[72] { 712, 464, 1290, 424, 998, 1143, 1258, 737, 1591, 1614, 1444, 384, 192, 1331, 1360, 1515, 1794, 1174, 1066, 1474, 293, 1826, 445, 654, 543, 1363, 496, 902, 753, 192, 690, 1330, 781, 1594, 1618, 638, 1280, 825, 1803, 960, 1483, 1069, 1387, 539, 1597, 574, 198, 1567, 273, 909, 921, 947, 793, 1446, 1128, 99, 1253, 784, 1725, 888, 845, 527, 357, 1402, 351, 1004, 1407, 980, 668, 1004, 1069, 183 };
            distances [73] = new int[73] { 784, 1016, 518, 1171, 436, 286, 805, 1026, 858, 589, 370, 1072, 1263, 177, 684, 427, 706, 278, 374, 740, 1140, 650, 972, 806, 991, 446, 932, 669, 828, 1595, 980, 646, 777, 418, 762, 1193, 181, 600, 627, 467, 308, 551, 476, 894, 725, 856, 1235, 866, 1182, 559, 642, 624, 877, 270, 478, 1327, 361, 656, 549, 547, 799, 929, 1070, 630, 1398, 498, 89, 516, 903, 662, 358, 1240, 1427 };
            distances [74] = new int[74] { 1037, 751, 1361, 305, 781, 1097, 1465, 117, 1675, 1564, 1345, 407, 484, 1130, 1443, 1402, 1681, 990, 829, 1557, 545, 1625, 546, 412, 230, 1339, 881, 466, 432, 641, 1015, 1413, 1107, 1393, 1689, 89, 955, 857, 1602, 981, 1282, 1153, 1418, 640, 1668, 862, 639, 1684, 403, 930, 981, 511, 257, 1245, 657, 580, 820, 659, 1524, 715, 336, 460, 721, 1473, 444, 882, 1168, 1006, 346, 1154, 1026, 599, 676, 1135 };
            distances [75] = new int[75] { 1077, 746, 1464, 144, 884, 1199, 1568, 336, 1777, 1723, 1505, 495, 336, 1290, 1546, 1562, 1841, 1130, 975, 1660, 540, 1785, 635, 514, 326, 1442, 861, 682, 534, 418, 1055, 1516, 1146, 1553, 1792, 135, 1134, 960, 1761, 1084, 1442, 1255, 1521, 729, 1771, 908, 616, 1786, 384, 1032, 1083, 727, 477, 1405, 874, 432, 1037, 762, 1683, 818, 556, 562, 716, 1576, 222, 985, 1349, 1108, 448, 1256, 1129, 469, 527, 1315, 222 };
            distances [76] = new int[76] { 905, 1137, 346, 1363, 629, 407, 610, 1238, 507, 218, 124, 1292, 1483, 217, 489, 69, 335, 450, 567, 508, 1304, 410, 1155, 998, 1184, 219, 1053, 881, 1040, 1738, 1101, 491, 898, 178, 391, 1386, 464, 721, 387, 588, 65, 572, 249, 1058, 354, 978, 1379, 605, 1402, 681, 763, 837, 1090, 103, 690, 1491, 645, 847, 309, 739, 1011, 1121, 1192, 387, 1591, 620, 284, 637, 1080, 685, 479, 1403, 1549, 373, 1347, 1507 };
            distances [77] = new int[77] { 714, 946, 449, 1106, 371, 216, 735, 958, 788, 567, 349, 1007, 1198, 134, 614, 405, 685, 192, 309, 670, 1075, 629, 907, 741, 926, 427, 862, 601, 760, 1530, 910, 576, 707, 396, 740, 1128, 113, 530, 605, 397, 286, 481, 454, 829, 704, 787, 1169, 797, 1117, 490, 572, 557, 810, 249, 410, 1262, 294, 591, 527, 482, 731, 864, 1001, 560, 1333, 429, 101, 446, 823, 593, 288, 1174, 1358, 86, 1067, 1250, 351 };
            distances [78] = new int[78] { 251, 210, 830, 812, 640, 711, 798, 885, 1131, 1154, 1011, 517, 580, 899, 900, 1083, 1362, 742, 677, 1014, 375, 1394, 402, 665, 691, 931, 63, 757, 827, 740, 146, 870, 321, 1162, 1158, 896, 847, 393, 1370, 528, 1051, 609, 926, 305, 1137, 141, 381, 1107, 625, 476, 461, 744, 954, 1014, 769, 554, 895, 465, 1292, 529, 876, 538, 193, 942, 739, 592, 975, 520, 793, 544, 637, 467, 550, 995, 920, 915, 1116, 925 };
            distances [79] = new int[79] { 89, 244, 667, 880, 603, 581, 636, 909, 969, 991, 874, 539, 648, 777, 737, 945, 1185, 676, 640, 851, 444, 1272, 401, 677, 715, 779, 123, 720, 790, 809, 127, 707, 159, 1040, 995, 919, 782, 356, 1248, 465, 929, 446, 764, 304, 974, 105, 449, 944, 648, 376, 299, 707, 917, 892, 732, 623, 858, 428, 1170, 492, 839, 537, 262, 779, 807, 555, 853, 357, 801, 381, 571, 535, 619, 873, 944, 984, 994, 803, 159 };

            distances [80] = new int[80] { 735, 966, 371, 1192, 458, 237, 636, 1067, 688, 387, 168, 1122, 1313, 47, 514, 225, 504, 279, 396, 571, 1133, 448, 984, 827, 1013, 244, 882, 710, 869, 1567, 930, 516, 727, 216, 560, 1215, 293, 550, 425, 417, 106, 501, 274, 887, 523, 807, 1208, 697, 1231, 510, 592, 666, 919, 68, 519, 1320, 474, 676, 347, 569, 840, 950, 1021, 412, 1420, 449, 113, 466, 910, 613, 308, 1232, 1378, 202, 1177, 1336, 171, 180, 945, 823 };

            int choice;

            do
            {

                Console.WriteLine("Menü:");
                Console.WriteLine("1. Verilen ilden belli bir uzaklığa kadar olan illerin ve uzaklıklarının listelenmesi.");
                Console.WriteLine("2. Türkiye’deki birbirine en yakın iki ilin ve en uzak iki ilin bulunması.");
                Console.WriteLine("3. Verilen ilden verilen mesafe kullanılarak en fazla kaç il dolaşılabildiğinin bulunması.");
                Console.WriteLine("4. Rastgele beş ilin arasındaki uzaklıkların matris şeklinde ekrana yazdırılması.");
                Console.WriteLine("0. Çıkış.");
                Console.Write("Lütfen seçiminizi yapınız (0-4): ");

                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Hatalı giriş, lütfen (0-4) aralığında bir sayı giriniz: ");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        Console.WriteLine();
                        Console.WriteLine("1. seçeneği seçtiniz.");
                        Console.WriteLine();

                        Console.Write("Bir ilin adını veya plaka numarasını giriniz (Türkçe karakterlere dikkat ediniz): ");
                        string userInput = Console.ReadLine();
                        Console.Write("Aranacak uzaklığı giriniz: ");
                        int distance = int.Parse(Console.ReadLine());

                        try
                        {
                            // Girilen değeri integer'a çevirmeyi dene
                            int plateNumber1 = int.Parse(userInput);
                            PrintProvincesUpToACertainDistance(provinces, distances, plateNumber1, distance);
                        }
                        catch (FormatException)
                        {
                            // Eğer integer'a çeviremezse, ilin adını dizide arayarak indexini bul
                            int index = Array.IndexOf(provinces, userInput);
                            if (index != -1)
                            {
                                PrintProvincesUpToACertainDistance(provinces, distances, index, distance);
                            }
                            else
                            {
                                Console.WriteLine("Geçersiz giriş. Lütfen geçerli bir il adı veya plaka numarası girin.");
                            }
                        }
                        break;

                    case 2:
                        Console.WriteLine();
                        Console.WriteLine("2. seçeneği seçtiniz.");
                        Console.WriteLine();
                        PrintClosestandFarthestProvinces(provinces, distances);
                        break;

                    case 3:
                        Console.WriteLine();
                        Console.WriteLine("3. seçeneği seçtiniz.");
                        Console.WriteLine();
                        Console.Write("Bir ilin adını veya plaka numarasını giriniz (Türkçe karakterlere dikkat ediniz): ");
                        string startingProvince = Console.ReadLine();
                        Console.Write("Aranacak uzaklığı giriniz: ");
                        int distance2 = int.Parse(Console.ReadLine());

                        try
                        {
                            // Girilen değeri integer'a çevirmeyi dene
                            int plateNumber2 = int.Parse(startingProvince);
                            int maxProvinces1 = CalculateMaxProvinces(distances, provinces, plateNumber2, distance2);
                            Console.WriteLine();
                            Console.WriteLine("Dolaşılabilen maksimum il sayısı: " + maxProvinces1);
                        }
                        catch (FormatException)
                        {
                            // Eğer integer'a çeviremezse, ilin adını dizide arayarak indexini bul
                            int index = Array.IndexOf(provinces, startingProvince);
                            if (index != -1)
                            {
                                int maxProvinces2 = CalculateMaxProvinces(distances, provinces, index, distance2);
                                Console.WriteLine();
                                Console.WriteLine("Dolaşılabilen maksimum il sayısı: " + maxProvinces2);
                            }
                            else
                            {
                                Console.WriteLine("Geçersiz giriş. Lütfen geçerli bir il adı veya plaka numarası girin.");
                            }
                        }
                        break;

                    case 4:
                        Console.WriteLine();
                        Console.WriteLine("4. seçeneği seçtiniz.");
                        Console.WriteLine();
                        PrintRandomFiveProvinceDistances(provinces, distances);
                        break;

                    case 0:
                        Console.WriteLine("Programdan çıkılıyor.");
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("Hatalı giriş. Lütfen (0-4) aralığında bir sayı giriniz.");
                        break;
                }

                Console.WriteLine();

            } while (choice != 0);
                     
        }

        // B - Verilen ilden belli bir uzaklığa kadar olan illeri ve uzaklıkları listeleyen fonksiyon.
        static void PrintProvincesUpToACertainDistance(string[] provinces, int[][] distances, int province_index, int distance)
        {

            if (province_index >= 0 && province_index < distances.Length)
            {
                Console.WriteLine("Provinces that are up to " + distance + " kilometers away from " + provinces[province_index] + " (" + province_index + ")");
                Console.WriteLine();

                int[] chosen_province = distances[province_index-1];

                for (int i = 0; i < chosen_province.Length; i++)
                {
                    if (chosen_province[i] <= distance)
                    {
                        Console.WriteLine("Province: " + provinces[i+1]);
                        Console.WriteLine("Distance: " + chosen_province[i]);
                        Console.WriteLine();
                    }
                }
            }

            else
            {
                Console.WriteLine("Invalid province index.");
            }
        }


        // C - Türkiye’deki birbirine en yakın ve en uzak iki ili bulup yazdıran fonksiyon.
        static void PrintClosestandFarthestProvinces(string[] provinces, int[][] distances)
        {

            // En yakın iki il.
            int min = int.MaxValue;
            int rowIndex2 = -1;
            int colIndex2 = -1;

            for (int x = 0; x < distances.Length; x++)
            {
                for (int y = 0; y < distances[x].Length; y++)
                {
                    if (distances[x][y] < min)
                    {
                        min = distances[x][y];
                        rowIndex2 = x;
                        colIndex2 = y;
                    }
                }
            }

            Console.WriteLine("Closest Two Provinces: " + provinces[rowIndex2 + 1] + " - " + provinces[colIndex2 + 1]); // Şehir indekslerinin plaka numarası ile aynı olması için indekslere +1 eklenmeli.
            Console.WriteLine("Distance: " + min);
            Console.WriteLine();

            // En uzak iki il.
            int max = int.MinValue;
            int rowIndex1 = -1;
            int colIndex1 = -1;

            for (int i = 0; i < distances.Length; i++)
            {
                for (int j = 0; j < distances[i].Length; j++)
                {
                    if (distances[i][j] > max)
                    {
                        max = distances[i][j];
                        rowIndex1 = i;
                        colIndex1 = j;
                    }
                }
            }

            Console.WriteLine("Farthest Two Provinces: " + provinces[rowIndex1 + 1] + " - " + provinces[colIndex1 + 1]); // Şehir indekslerinin plaka numarası ile aynı olması için indekslere +1 eklenmeli.
            Console.WriteLine("Distance: " + max);
        }

        // D - Verilen ilden verilen mesafe kullanılarak en fazla kaç il dolaşılabildiğini bulan fonksiyon.
        static int CalculateMaxProvinces(int[][] distances, string[] provinces, int startingProvinceIndex, int distanceLimit)
        {
            int maxProvinces = 0;
            int currentDistance = 0;
            int currentProvinceIndex = startingProvinceIndex - 1;

            // Düzensiz matristen kare matris oluşturma
            int[,] squareDistanceMatrix = new int[81, 81];
            for (int i = 0; i < squareDistanceMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < squareDistanceMatrix.GetLength(1); j++)
                {

                    if (i == j)
                    {
                        squareDistanceMatrix[i, j] = 9999;
                    }

                    else if (i > j)
                    {
                        squareDistanceMatrix[i, j] = distances[i][j];
                        squareDistanceMatrix[j, i] = squareDistanceMatrix[i, j];
                    }
                }
            }

            // Daha önce dolaşılan illeri tutan liste
            List<int> visitedProvinces = new List<int>();
            Console.WriteLine();

            while (currentDistance <= distanceLimit)
            {
                int nextProvinceIndex = -1;
                int minDistance = int.MaxValue;

                // Dolaşılacak sonraki ili bulma
                for (int i = 0; i < squareDistanceMatrix.GetLength(1); i++)
                {
                    if (i != currentProvinceIndex && squareDistanceMatrix[currentProvinceIndex,i] < minDistance)
                    if (!visitedProvinces.Contains(i) && squareDistanceMatrix[currentProvinceIndex, i] < minDistance)
                    {
                        minDistance = squareDistanceMatrix[currentProvinceIndex,i];
                        nextProvinceIndex = i;
                    }
                }

                // Uygun il bulunamazsa döngüden çıkma
                if (nextProvinceIndex == -1)
                {
                    break;
                }

                // Limit aşılırsa döngüden çıkma
                if (currentDistance + minDistance > distanceLimit)
                {
                    break;
                }

                Console.WriteLine($"{provinces[currentProvinceIndex+1]} -> {provinces[nextProvinceIndex+1]}: {minDistance} km");

                // Bir il dolaşıldıktan sonra indeksleri ve listeyi güncelleme
                currentDistance += minDistance;
                visitedProvinces.Add(currentProvinceIndex);
                currentProvinceIndex = nextProvinceIndex;

                // Dolaşılan il sayısını artırma
                maxProvinces++;
            }

            Console.WriteLine();
            Console.WriteLine($"Toplam Uzaklık: {currentDistance} km");

            return maxProvinces;
        }

        // E -  Rastgele 5 ilin birbirine olan uzaklıklarını yazdıran fonksiyon.
        static void PrintRandomFiveProvinceDistances(string[] provinces, int[][] distances)
        {
            Random random = new Random();

            List<int> randomIndexes = new List<int>();

            // Üretilen sayıların farklı olmasını sağlar
            while (randomIndexes.Count < 5)
            {
                int randomNumber = random.Next(1, 82);
                if (!randomIndexes.Contains(randomNumber))
                {
                    randomIndexes.Add(randomNumber);
                }
            }

            randomIndexes.Sort(); // Küçükten büyüğe sıralama.

            int[,] randomDistanceMatrix = new int[5, 5];

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {

                    if (i == j)
                    {
                        randomDistanceMatrix[i, j] = 0;
                    }

                    else if (i > j)
                    {
                        randomDistanceMatrix[i, j] = distances[randomIndexes[i]][randomIndexes[j]]; // Rastgele üretilen sayılardan en az ikisi eşit üretilmişse index hatası verir.
                        randomDistanceMatrix[j, i] = randomDistanceMatrix[i,j];
                    }
                  
                }
            }

            Console.WriteLine("Distance Matrix:");
            Console.WriteLine();
            int columnWidth = 15;
            Console.Write("".PadRight(columnWidth));

            for (int i = 0; i < randomDistanceMatrix.GetLength(1); i++)
            {
                Console.Write(provinces[randomIndexes[i] + 1].PadRight(columnWidth) + "   ");
            }
            Console.WriteLine();

            // Uzaklık matrisini yazdırma
            for (int i = 0; i < randomDistanceMatrix.GetLength(0); i++)
            {
                Console.Write(provinces[randomIndexes[i] + 1].PadRight(columnWidth) + "   ");

                for (int j = 0; j < randomDistanceMatrix.GetLength(1); j++)
                {
                    Console.Write(randomDistanceMatrix[i, j].ToString().PadRight(columnWidth) + "   ");
                }

                Console.WriteLine();
            }

        }
        
    }
}
