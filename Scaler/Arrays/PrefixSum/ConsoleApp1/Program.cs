﻿using ArraysDSA;
using ConsoleApp1;

class Solution
{
    static void Main() {
        //  ArrayPrograms.rangeSum(new List<int> { 1, 2, 3, 4, 5 }, new List<List<int>>() { new List<int>() { 0,3 }, new List<int>() { 1, 2 } });
        // ArrayPrograms.calculateSpecialIndex(new List<int> { 1, 2, 3, 7,1,2,3 });
        ArrayPrograms.calculateSpecialSequence("ABCGAG");
        ArrayPrograms.PickFromBothSides(new List<int>() { 5, -2, 3, 1, 2 }, 3);
        ArrayPrograms2.GenerateSubArrays(new List<int>() { 1, 2, 3 });
        ArrayPrograms2.GenerateSubArraysInRange(new List<int>() { 4, 3, 2, 6 },1,3);
        ArrayPrograms2.CountUniqueSubarrays(new List<int>() { 93, 9, 12, 32, 97, 75, 32, 77, 40, 79, 61, 42, 57, 19, 64, 16, 86, 47, 41, 67, 76, 63, 24, 10, 25, 96, 1, 30, 73, 91, 70, 65, 53, 75, 5, 19, 65, 6, 96, 33, 73, 55, 4, 90, 72, 83, 54, 78, 67, 56, 8, 70, 43, 63 });
        ArrayPrograms2.CountingSubArrays(new List<int>() { 3, 12, 11, 11, 11, 15 }, 12);
        ArrayPrograms2.ClosestMinMax(new List<int>() { 834, 563, 606, 221, 165 });
        ArrayPrograms2.BestTimeToBuyStock(new List<int>() { 4194445, 5755801, 2855639, 4681951, 642183, 9606207, 6539770, 2929563, 2371075, 2065991, 4734767, 3035028, 9844237, 9859030, 5366228, 7126800, 3093826, 2064333, 4794134, 6009455, 1554282, 1141024, 9008908, 5564577, 5670584, 3701388, 305389, 9988838, 7607445, 8689404, 4606240, 721493, 8358372, 7969247, 2005188, 9381407, 9640526, 1257732, 3128856, 5674956, 7212588, 5699639, 3391536, 9223297, 303612, 246025, 4664705, 5533721, 1254106, 6723049, 7092956, 9115027, 4029515, 8682821, 3075505, 2455402, 8685967, 7823073, 8138079, 5223844, 7204268, 8388370, 4932424, 1163737, 5251626, 5026560, 5050075, 444693, 8416089, 6533127, 8849938, 9195466, 6912747, 318446, 2255659, 1324379, 1091239, 7558075, 9314612, 7170906, 3222755, 3626629, 184898, 4602309, 1596067, 2979905, 5350257, 2919884, 9904801, 722970, 8136001, 1391045, 6414844, 2205953, 4755182, 2798289, 5134693, 9826047, 432014, 6805799, 6827969, 7032606, 4696237, 5731657, 2733376, 4768391, 2782129, 4632527, 4485247, 9064703, 3372660, 9420437, 4193640, 2612882, 2867493, 8068152, 3907859, 124864, 5942858, 5168681, 5242568, 474474, 8675032, 1368145, 5358739, 4107643, 1657155, 9175880, 8535311, 8277280, 7462655, 5984330, 7676367, 498783, 9495820, 3076391, 3546466, 3806366, 1312460, 652185, 9729605, 2472157, 913603, 78321, 7611113, 6599149, 4055264, 8831043, 2431665, 6773353, 262124, 8150637, 3198010, 9990139, 811941, 7829764, 5725450, 223476, 4615776, 9894103, 5906398, 906269, 3967342, 1543460, 4301996, 1787414, 8254232, 1789655, 4230800, 5969792, 905489, 3258010, 9454136, 4249389, 6467504, 6519664, 4001349, 5026632, 5014202, 6667981, 3817855, 5034444, 6930070, 1349637, 1035425, 9252606, 6607642, 2524617, 1006652, 3528601, 2690079, 9721966, 4199938, 5762348, 128435, 4118901, 6892353, 2989545, 666501, 5888056, 8654317, 4248490, 762635, 5111086, 5764247, 1866872, 4293692, 9257206, 6891118, 6087668, 941907, 8810109, 6646582, 3630739, 446420, 351840, 4011717, 3143139, 7749114, 6392659, 9048202, 7016084, 2382421, 4446109, 8485561, 5782000, 3949229, 5221723, 8561121, 9303285, 1543066, 6108565, 2722519, 7758442, 6163843, 2755475, 1023498, 5443927, 312752, 9196009, 3221496, 2914945, 2653161, 4489388, 1959263, 5623432, 9971827, 3785009, 7319090, 7630374, 5217607, 8044924, 8769872, 8185537, 1597610, 7814177, 1029537, 7567770, 2258460, 5576548, 482655, 2612813, 3224455, 2585241, 1092094, 9877649, 7498080, 5699558, 2951043, 6086409, 9542232, 661452, 5836164, 4345098, 8307895, 6637498, 6272548, 6046123, 3646645, 774039, 2892326, 8990224, 7423970, 1974660, 2915143, 3225108, 7089874, 6573037, 562334, 4269980, 489996, 1186345, 8226531, 816581, 768322, 8850738, 4660865, 816794, 6128349, 9412437, 8816780, 8379353, 3537553, 4864852, 5573468, 79518, 6575334, 7596536, 6889113, 9602795, 6640332, 2332107, 6535110, 7488014, 9995147, 3170250, 5091560, 1360125, 7509497, 1121503, 7358828, 4794661, 7027205, 3332651, 9573810, 4093855, 7576965, 2998873, 7914729, 1092664, 1802541, 8724368, 558214, 2857902, 2716188, 2003935, 7168482, 6012254, 3643378, 6074238, 6647950, 6389831, 5109285, 866253, 381182, 1164871, 6275734, 1373355, 7017631, 5325732, 255703, 8151488, 9133852, 5909110, 3275900, 6061125, 475435, 3611189, 2999139, 4638073, 8973840, 2561265, 3769187, 6653732, 8312926, 8824383, 1472759, 4821429, 1483913, 862658, 5331434, 5223163, 9257756, 1027441, 4445934, 8306958, 9852026, 203971, 5610515, 9554829, 2882366, 5159575, 5463819, 2912256, 1762629, 2822314, 1863502, 3884780, 3574742, 8568504, 1253111, 503241, 6109333, 7496262, 7489733, 4319399, 9349740, 3945259, 8884655, 7607110, 8608523, 4386536, 9292660, 9617100, 5400748, 5880352, 8878708, 4242669, 7471856, 7150688, 9502486, 3485539, 2421557, 1965130, 7403648, 8796538, 6717060, 259999, 6321534, 2791184, 4094667, 4931963, 1782625, 497135, 931841, 7789116, 9062312, 1314376, 4186203, 2781984, 6351555, 6433207, 5584677, 6332921, 1563685, 1553136, 2297922, 8427601, 1826430, 3253257, 1884767, 5263589, 7242437, 4136563, 2669239, 4890360, 7994097, 3243588, 3024004, 6227582, 4667341, 5951200, 7625344, 5601489, 525262, 9273359, 6532814, 5958471, 4875336, 1980311, 2047533, 1693741, 5059206, 1441267, 8561945, 9413927, 267932, 9767893, 5708235, 8490874, 5875232, 4514791, 122809, 8169308, 5485225, 1258832, 6423197, 7401453, 63428, 6242952, 3935999, 5627757, 7677399, 7549112, 7071403, 1269499, 6408877, 4263892, 2386645, 2142089, 9680907, 8958646, 787007, 7100373, 3563871, 9002573, 369222, 2707131, 9279796, 2847105, 7396262, 8662258, 2403065, 8174614, 5792694, 6292058, 3741998, 2806982, 9193909, 4390354, 5450971, 9800176, 9442318, 848643, 3667121, 6013064, 7078994, 864441, 2124755, 987795, 3904413, 4436411, 3207605, 4372015, 400985, 3196209, 8094432, 1053017, 710448, 349168, 6789123, 7444730, 3441905, 3933247, 6882550, 6867729, 9164628, 165786, 716556, 1109737, 3671507, 6671443, 1236642, 1664765, 9329820, 5442137, 6931445, 3808660, 2034565, 8492007, 1031792, 2348823, 7364453, 4999931, 4322960, 8340199, 639089, 135093, 4657084, 8368461, 8517539, 6231696, 8261869, 8247731, 7867767, 7266041, 6158750, 7335486, 8035170, 4269642, 7393800, 7019543, 4434206, 3330723, 6580929, 4449142, 8067766, 3682033, 3698348, 3067274, 9752295, 1121939, 7713186, 1157402, 2462787, 8355113, 3140410, 3159795, 1928352, 5335266, 5919865, 505504, 2750149, 2786405, 2165156, 7275716, 2443565, 7820731, 3257234, 3943777, 3295474, 173055, 6809788, 6093159, 264240, 3204306, 9165393, 6552803, 8654172, 2492684, 2467027, 126724, 6043336, 3988090, 1145326, 9919194, 4786559, 1544896, 9566382, 6783344, 9457825, 8712145, 5598821, 2627075, 7848949, 4073282, 5164981, 5966346, 4412603, 7695179, 9612711, 3863295, 6957529, 7419982, 7950638, 9746913, 8971977, 6977344, 7509979 });
        ArrayPrograms2.GoodSubArrays(new List<int>() { 3, 12, 11, 11, 11, 15 }, 12);
       // ArrayPrograms2.SubarrayWithLeastAverage(new List<int>() { 3, 7, 90, 20, 10, 50, 40 }, 3);
        ArrayPrograms2.SubarrayWithLeastAverage(new List<int>() { 20, 3, 13, 5, 10, 14, 8, 5, 11, 9, 1, 11 }, 9);
        ArrayPrograms3.LengthOfLongestConsecutiveOnes("111000");
        ArrayPrograms3.CountIncreasingTriplets(new List<int> { 18, 26, 17, 30, 13, 30, 20, 13, 10, 19 });
        ArrayPrograms3.RepeatN3Numbers(new List<int> { 1 });
        ArrayPrograms3.MajorityElement(new List<int> { 1, 1, 1, 2, 3, 5, 7 });
        ArrayPrograms3.MaximumSubArray(new List<int> { -2, 1, -3, 4, -1, 2, 1, -5, 4 });
        ArrayPrograms3.ContinuousSumQuery(5, new List<List<int>>() { new List<int>{ 1, 2, 10 }, new List<int> { 2, 3, 20 }, new List<int> { 2, 5, 25 } });
        ArrayPrograms3.RainWaterTrap(new List<int>() { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 });
        ArrayPrograms3.AddOneToNumber(new List<int>() { 0,0, 3, 7, 6, 4, 0, 5, 5, 5 });
        ArrayPrograms3.FirstMissingPositiveInteger(new List<int>() { 948, 20, 84, 710, 471, 606, 995, 581, -4, 428, 149, 832, 740, 943, 450, 974, 829, 721, 821, 476, 763, 4, 523, 937, 814, 624, 935, 87, 127, 816, 239, 33, 561, 999, 904, 282, 844, 923, 750, 551, 432, 9, 373, 387, 114, 376, 265, 801, 228, 454, 474, 764, 268, 680, 472, 431, 133, 785, 752, 643, 441, 151, 969, 395, 437, 94, 259, 973, 535, 272, 456, 546, 79, 677, 0, 109, 522, 295, 466, 956, 723, 157, 772, 865, 997, 771, 922, 980, 567, 939, 651, 478, 852, 926, 913, 494, 882, 207, 915, 645, 754, 385, 874, 554, 706, 722, 10, 374, 96, 647, 280, 418, 737, 538, 867, 850, 600, 23, 730, 742, 224, 511, 361, 251, 809, 907, 271, 319, 866, 848, 594, 566, 113, 211, 334, 644, 826, 430, 929, 603, 165, 147, 788, 529, 539, 633, 275, 602, 544, 540, 853, 123, -1, 443, 942, 386, 68, 465, 782, 250, 458, 174, 70, 919, 462, 347, 26, 589, 880, 648, 237, 294, 641, 707, 516, 507, 802, 989, 779, 519, 62, 619, 584, 358, 362, 277, 43, 198, 467, 625, 611, 212, 468, 767, 778, 173, 791, 331, 11, 461, 572, 97, 902, 558, 413, 28, 179, 370, 842, 568, 500, 311, 550, 464, 345, 411, 274, 181, 396, 339, 39, 760, 575, 327, 889, 579, 840, 734, 254, 934, 532, 29, 622, 780, 73, 479, 322, 2, 599, 227, 685, 65, 510, 716, 289, 912, 574, 262, 916, 924, 304, 57, 353, 40, 341, 521, 131, 307, 526, 398, 225, 63, 776 });
        ArrayPrograms3.MergeIntervalsWithGivenInterval(new List<List<int>>() { new List<int> { 1, 2 }, new List<int> { 3, 6 }}, new List<int>() { 8, 10 });
        ArrayPrograms3.FlipUsingMaximumSubArraySum("1101");
        ArrayPrograms3.NextPermuatationInTheList(new List<int>() { 769, 533 });

        _2DArray.ColumnSum(new List<List<int>> { new List<int> { 1, 2, 3, 4 }, new List<int> { 5, 6, 7, 8 }, new List<int> { 9, 2, 3, 4 } });
        _2DArray.RowSum(new List<List<int>> { new List<int> { 1, 2, 3, 4 }, new List<int> { 5, 6, 7, 8 }, new List<int> { 9, 2, 3, 4 } });
        _2DArray.MatrixTranspose(new List<List<int>> { new List<int> { 1, 2, 3 }, new List<int> { 4, 5, 6 }, new List<int> { 7, 8, 9 } });
        _2DArray.MinimumSwaps(new List<int>() { 5, 17, 100, 11 }, 20);
        _2DArray.GenarateSpiralMatrix(5);

        StringProblems.ReverseAString("scaler");
        StringProblems.ToggleTheString("FbxdWdoKwrezJPP");
        StringProblems.LongestPalindrome("aaaabaaa");
        StringProblems.CountOccurences("rbobobbobljzjdbobbobpncbobobobadbobvlrrbobmypibobbqiycbobdcpbobybobgjqgbobuccboboybobmbob");
        StringProblems.LongestCommonPrefix(new List<string>() { "abab", "ab", "acbcd" });

        Scaler1stTest.FindtheMinimumAverageSubArray(new List<int>() { 46,10,15,44,45,29,39,7,50,33,3,7,25,50,5,22,30,23,0 }, 1,22);
        Scaler1stTest.PositiveInRangeWithQQueries(new List<int>() { 1, -1, 0 }, new List<List<int>>() { new List<int> { 0,2 }, new List<int> { 1,2 } });

        Scaler2ndTest.RainWaterTrap(new List<int>() { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 });
       // Scaler2ndTest.MaxPossibleSumOfAnArray(new List<int>() { 1, 1, 6, 11, 14, 14, 17, 18, 18, 1 });
        //Scaler2ndTest.MaxPossibleSumOfAnArray(new List<int>() {9,2,4,2 });
        Scaler2ndTest.MaxPossibleSumOfAnArray(new List<int>() { 4,6,9,11,12,13,16,20,20,6 });
        Scaler3rdTest.CheckIfStringCanBeConvertedToPalindromeAfterMultipleSwaps("swxslszkzygsrawregxcefnlvyfkyxysntxacvsts");

        Hashing.CommonElements(new List<int> { 19, 19, 3, 5, 6 }, new List<int> { 2, 8, 2, 12, 16, 3 });
        Hashing.LongestSubArrayZeroSum(new List<int>() { 9, -20, -11, -8, -4, 2, -12, 14, 1});

        //QuickSortWithComparator.FactorsSort(new List<int> { 36, 13, 13, 26, 37, 28, 27, 43, 7 });
        QuickSortWithComparator.FactorsSort(new List<int> { 36, 13, 13 });
        QuickSortWithComparator.FactorsSortUsingInbuilt(new List<int> { 36, 13, 13, 26, 37, 28, 27, 43, 7 });

        BinarySearch1.SingleElementInSortedArray(new List<int> { 1, 1, 7, 7, 8,9,9 });
        BinarySearch1.RotatedSortedArraySearch(new List<int> { 1, 7, 67, 133, 178 }, 1);

        BinarySearch2.PainterPartion(4, 10, new List<int>() { 884, 228, 442, 889 });

        Stacks.EvalReversePolishNotation(new List<string>() { "2", "2", "/" });
        Stacks.BalancedParenthesis("{([])}");
        Stacks.DoubleCharacterTrouble("aaaaa");

        Stacks.NearestSmallestELement(new List<int> { 34, 35, 27, 42, 5, 28, 39, 20, 28 });
        Stacks.MaxAndMinInSubarrays(new List<int> { 994390, 986616, 976849, 979707, 950477, 968402, 992171, 937674, 933065, 960863, 980981, 937319, 951236, 959547, 991052, 991799, 992213, 941294, 978103, 997198, 960759, 988476, 963517, 980366, 921767, 979757, 977912, 983761, 981869, 947454, 930202, 999086, 973538, 999798, 996446, 944001, 974217, 951595, 942688, 975075, 970973, 970130, 897109, 927660, 862233, 997130, 986068, 954098, 978175, 889682, 988973, 996036, 969675, 985751, 977724, 881538, 988613, 924230, 906475, 915565, 986952, 975702, 994316, 964011, 986848, 983699, 949076, 989673, 981788, 929094, 988310, 926471, 994763, 999736, 980762, 973560, 996622, 934475, 998365, 966255, 998697, 998700, 911868, 983245, 996382, 996992, 953142, 994104, 987303, 853837, 960626, 904203, 998063, 977596, 977868, 996012, 946345, 949255, 988138, 996298, 954933, 965036, 886976, 998628, 990878, 953725, 916744, 985233, 919661, 970903, 986066 });
    }

}