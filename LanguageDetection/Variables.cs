namespace LanguageDetection
{
    public class Variables
    {
        // the values of letter frequencies refers to en.wikipedia.org/wiki/Letter_frequency

        public IDictionary<int, string> capitalAndLowercaseLettersInTurkishAlphabet = new Dictionary<int, string> { {0, "Aa"}, {1, "Bb"}, {2, "Cc"}, {3, "Çç"}, {4, "Dd"}, {5, "Ee"}, {6,"Ff" }, {7, "Gg"}, {8, "Ğğ" },  {9, "Hh"}, {10, "Iı"}, {11, "İi"}, {12, "Jj"}, {13, "Kk"}, {14, "Ll"}, {15, "Mm"}, {16, "Nn"}, {17, "Oo"}, {18, "Öö"}, {19, "Pp"}, {20, "Rr"}, {21, "Ss"}, {22, "Şş"}, {23, "Tt"}, {24, "Uu"}, {25, "Üü"}, {26, "Vv"}, {27,"Yy"}, {28, "Zz"} };
        public IDictionary<int, string> capitalAndLowercaseLettersInEnglishAlphabet = new Dictionary<int, string> { { 0, "Aa" }, { 1, "Bb" }, { 2, "Cc" }, { 3, "Dd" }, { 4, "Ee" }, { 5, "Ff" }, { 6, "Gg" }, { 7, "Hh" }, { 8, "Ii" }, { 9, "Jj" }, { 10, "Kk" }, { 11, "Ll" }, { 12, "Mm" }, { 13, "Nn" }, { 14, "Oo" }, { 15, "Pp" }, { 16, "Qq" }, { 17, "Rr" }, { 18, "Ss" }, { 19, "Tt" }, { 20, "Uu" }, { 21, "Vv" }, { 22, "Ww" }, { 23, "Xx" }, { 24, "Yy" }, { 25, "Zz" } };
        public IDictionary<int, string> capitalAndLowercaseLettersInSpanishAlphabet = new Dictionary<int, string> { { 0, "Aa" } , { 1, "Bb" }, { 2, "Cc"}, { 3, "Dd"}, { 4, "Ee"}, { 5, "Ff"}, { 6, "Gg"}, { 7, "Hh"}, { 8, "Ii"}, { 9, "Jj"}, { 10, "Kk"}, { 11, "Ll"}, { 12, "Mm"}, { 13, "Nn"}, { 14, "Oo"}, { 15, "Pp"}, { 16, "Qq"}, { 17, "Rr"}, { 18, "Ss"}, { 19, "Tt"}, { 20, "Uu"}, { 21, "Vv"}, { 22, "Ww"}, { 23, "Xx"}, { 24, "Yy"}, { 25, "Zz"}, { 26, "Ññ"} };
        public IDictionary<int, string> capitalAndLowercaseLettersInItalianAlphabet = new Dictionary<int, string> { { 0, "Aa" } , { 1, "Bb" }, { 2, "Cc" }, { 3, "Dd"}, { 4, "Ee"}, { 5, "Ff"}, { 6, "Gg"}, { 7, "Hh"}, { 8, "Ii"}, { 9, "Jj"}, { 10, "Kk"}, { 11, "Ll"}, { 12, "Mm"}, { 13, "Nn"}, { 14, "Oo"}, { 15, "Pp"}, { 16, "Qq"}, { 17, "Rr"}, { 18, "Ss"}, { 19, "Tt"}, { 20, "Uu"}, { 21, "Vv"}, { 22, "Ww"}, { 23, "Xx"}, { 24, "Yy"}, { 25, "Zz"}, { 26, "Èè"}, { 27, "Éé"}, { 28, "Ìì"}, { 29, "Íí"}, { 30, "Òò"}, { 31, "Óó"}, { 32, "Ùù"}, { 33, "Úú"} };
        public IDictionary<int, string> capitalAndLowercaseLettersInGermanAlphabet = new Dictionary<int, string> { { 0, "Aa" } , { 1, "Bb" }, { 2, "Cc" }, { 3, "Dd"}, { 4, "Ee"}, { 5, "Ff"}, { 6, "Gg"}, { 7, "Hh"}, { 8, "Ii"}, { 9, "Jj"}, { 10, "Kk"}, { 11, "Ll"}, { 12, "Mm"}, { 13, "Nn"}, { 14, "Oo"}, { 15, "Pp"}, { 16, "Qq"}, { 17, "Rr"}, { 18, "Ss"}, { 19, "Tt"}, { 20, "Uu"}, { 21, "Vv"}, { 22, "Ww"}, { 23, "Xx"}, { 24, "Yy"}, { 25, "Zz"}, { 26, "Ää"}, { 27, "Öö"}, { 28, "Üü"}, { 29, "ßß"} }; 
        public IDictionary<int, string> capitalAndLowercaseLettersInFrenchAlphabet = new Dictionary<int, string> { { 0, "Aa" }  , { 1, "Bb" }, { 2, "Cc" }, { 3, "Dd"}, { 4, "Ee"}, { 5, "Ff"}, { 6, "Gg"}, { 7, "Hh"}, { 8, "Ii"}, { 9, "Jj"}, { 10, "Kk"}, { 11, "Ll"}, { 12, "Mm"}, { 13, "Nn"}, { 14, "Oo"}, { 15, "Pp"}, { 16, "Qq"}, { 17, "Rr"}, { 18, "Ss"}, { 19, "Tt"}, { 20, "Uu"}, { 21, "Vv"}, { 22, "Ww"}, { 23, "Xx"}, { 24, "Yy"}, { 25, "Zz"}, { 26, "Àà"}, { 27, "Ââ"}, { 28, "Çç"}, { 29, "Èè"}, { 30, "Éé"}, { 31, "Êê"}, { 32, "Ëë"}, { 33, "Îî"}, { 34, "Ïï"}, { 35, "Ôô"}, { 36, "Ùù"}, { 37, "Ûû"}, { 38, "Üü"}, { 39, "Ÿÿ"} };   
        public IDictionary<int, string> capitalAndLowercaseLettersInDutchAlphabet = new Dictionary<int, string> { {0, "Aa"}, {1, "Bb"}, {2, "Cc"}, {3, "Dd"}, {4, "Ee"}, {5, "Ff"}, {6, "Gg"}, {7, "Hh"}, {8, "Ii"}, {9, "Jj"}, {10, "Kk"}, {11, "Ll"}, {12, "Mm"}, {13, "Nn"}, {14, "Oo"}, {15, "Pp"}, {16, "Qq"}, {17, "Rr"}, {18, "Ss"}, {19, "Tt"}, {20, "Uu"}, {21, "Vv"}, {22, "Ww"}, {23, "Xx"}, {24, "Yy"}, {25, "Zz"} };   

        public IDictionary<char, int> totalCapitalLettersInTurkishEnglishSpanishItalianGermanFrenchDutchAlphabets= new Dictionary<char, int> { {'A',0 }, {'B',0}, {'C',0}, {'D',0}, { 'E', 0 }, { 'F',0}, {'G',0}, {'H',0}, {'I',0}, {'J',0}, {'K',0}, {'L',0}, {'M',0}, {'N',0}, {'O',0}, {'P',0}, {'Q',0}, {'R',0}, {'S',0}, { 'Ş', 0 }, { 'T',0}, {'U',0}, {'V',0}, {'W',0}, {'X',0}, {'Y',0}, {'Z',0}, { 'Ğ', 0 }, { 'İ', 0 }, { 'Ñ',0}, {'È',0}, {'É',0}, {'Ì',0}, {'Í',0}, {'Ò',0}, {'Ó',0}, {'Ù',0}, {'Ú',0}, {'Ä',0}, {'Ö',0}, {'Ü',0}, {'ß',0}, {'À',0}, {'Â',0}, {'Ç',0}, {'Ê',0}, {'Ë',0}, {'Î',0}, {'Ï',0}, {'Ô',0}, {'Û',0}, {'Ÿ',0} };
        public IDictionary<char, double> totalFrequenciesofLettersinInputText = new Dictionary<char, double> { { 'A', 0.00 }, { 'B', 0.00 }, { 'C', 0 }, { 'D', 0 }, { 'E', 0 }, { 'F', 0 }, { 'G', 0 }, { 'H', 0 }, { 'I', 0 }, { 'J', 0 }, { 'K', 0 }, { 'L', 0 }, { 'M', 0 }, { 'N', 0 }, { 'O', 0 }, { 'P', 0 }, { 'Q', 0 }, { 'R', 0 }, { 'S', 0 }, { 'Ş', 0 }, { 'T', 0 }, { 'U', 0 }, { 'V', 0 }, { 'W', 0 }, { 'X', 0 }, { 'Y', 0 }, { 'Z', 0 }, { 'Ğ', 0 }, { 'İ', 0 }, { 'Ñ', 0 }, { 'È', 0 }, { 'É', 0 }, { 'Ì', 0 }, { 'Í', 0 }, { 'Ò', 0 }, { 'Ó', 0 }, { 'Ù', 0 }, { 'Ú', 0 }, { 'Ä', 0 }, { 'Ö', 0 }, { 'Ü', 0 }, { 'ß', 0 }, { 'À', 0 }, { 'Â', 0 }, { 'Ç', 0 }, { 'Ê', 0 }, { 'Ë', 0 }, { 'Î', 0 }, { 'Ï', 0 }, { 'Ô', 0 }, { 'Û', 0 }, { 'Ÿ', 0 } };


        public string inputText="";
        public List<char> inputTextArray =new List<char>();

        public string turkishLettersOrderdFrequency = "AEİRNKLDOIUMTSBYÜVŞGZÇHĞPÖFJ";
        public string englishLettersOrderdFrequency = "ETAOINSHRDLCUMWFGYPBVKJXQZ";
        public string spanishLettersOrderdFrequency = "EAOSNRILDTUCMPBGVQHFZJXYKW";
        public string italianLettersOrderdFrequency = "EAIONLRTSCDUMPBGHVZFQKJXYW";
        public string germanLettersOrderdFrequency = "ENISRATDHULCGMBOVKWZPFJXYQ";
        public string frenchLettersOrderdFrequency = "ESAITNRULODCMPFBGVHQYXJZK";
        public string dutchLettersOrderdFrequency = "ENATORDISLGHKMVUWZPBCFJYX";
        public string theLetterInTheTextOrderdByFrequency = "";

        public IDictionary<char, double> letterFrequenciesOfTheTurkishAlphabet = new Dictionary<char, double> {
    { 'A', 11.92 },
    { 'B', 2.84 },
    { 'C', 0.96 },
    { 'Ç', 1.16 },
    { 'D', 4.71 },
    { 'E', 8.91 },
    { 'F', 0.46 },
    { 'G', 1.25 },
    { 'Ğ', 1.13 },
    { 'H', 1.21 },
    { 'I', 8.60 },
    { 'İ', 5.11 },
    { 'J', 0.03 },
    { 'K', 4.68 },
    { 'L', 5.92 },
    { 'M', 3.75 },
    { 'N', 7.48 },
    { 'O', 2.48 },
    { 'Ö', 0.78 },
    { 'P', 0.89 },
    { 'R', 6.72 },
    { 'S', 3.01 },
    { 'Ş', 1.78 },
    { 'T', 3.31 },
    { 'U', 3.24 },
    { 'Ü', 1.85 },
    { 'V', 0.96 },
    { 'Y', 3.34 },
    { 'Z', 1.50 }};



    public IDictionary<char, double> letterFrequenciesOfTheEnglishAlphabet = new Dictionary<char, double> {
    { 'A', 8.17 },
    { 'B', 1.49 },
    { 'C', 2.78 },
    { 'D', 4.25 },
    { 'E', 12.70 },
    { 'F', 2.23 },
    { 'G', 2.02 },
    { 'H', 6.09 },
    { 'I', 6.97 },
    { 'J', 0.15 },
    { 'K', 0.77 },
    { 'L', 4.03 },
    { 'M', 2.41 },
    { 'N', 6.75 },
    { 'O', 7.51 },
    { 'P', 1.93 },
    { 'Q', 0.10 },
    { 'R', 5.99 },
    { 'S', 6.33 },
    { 'T', 9.06 },
    { 'U', 2.76 },
    { 'V', 0.98 },
    { 'W', 2.36 },
    { 'X', 0.15 },
    { 'Y', 1.97 },
    { 'Z', 0.07 }};

    public IDictionary<char, double> letterFrequenciesOfTheFrenchAlphabet = new Dictionary<char, double> {
    {'A', 7.64},
    {'B', 0.90},
    { 'C', 3.26},
    { 'D', 3.67},
    { 'E', 14.72},
    { 'F', 1.07},
    { 'G', 0.87},
    { 'H', 0.74},
    { 'I', 7.53},
    { 'J', 0.61},
    { 'K', 0.07},
    { 'L', 5.46},
    { 'M', 2.97},
    { 'N', 7.10},
    { 'O', 5.80},
    { 'P', 2.52},
    { 'Q', 1.36},
    { 'R', 6.69},
    { 'S', 7.95},
    { 'T', 7.24},
    { 'U', 6.31},
    { 'V', 1.84},
    { 'W', 0.05},
    { 'X', 0.43},
    { 'Y', 0.13},
    { 'Z', 0.33},
    {'à', 0.49},
    {'â', 0.05},
    {'ç', 0.09},
    {'è', 0.27},
    {'é', 1.50},
    {'ê', 0.22},
    {'ë', 0.01},
    {'î', 0.04},
    {'ï', 0.01},
    {'ô', 0.02},
    {'œ', 0.02},
    {'ù', 0.06},
    {'û', 0.06} };



        public IDictionary<char, double> letterFrequenciesOfTheGermanAlphabet = new Dictionary<char, double> {
    { 'A', 6.52 },
{ 'B', 1.89 },
{ 'C', 2.73 },
{ 'D', 5.08 },
{ 'E', 16.40 },
{ 'F', 1.66 },
{ 'G', 3.01 },
{ 'H', 4.58 },
{ 'I', 6.55 },
{ 'J', 0.27 },
{ 'K', 1.42 },
{ 'L', 3.44 },
{ 'M', 2.53 },
{ 'N', 9.78 },
{ 'O', 2.59 },
{ 'P', 0.67 },
{ 'Q', 0.02 },
{ 'R', 7.00 },
{ 'S', 7.27 },
{ 'T', 6.15 },
{ 'U', 4.17 },
{ 'V', 0.85 },
{ 'W', 1.92 },
{ 'X', 0.03 },
{ 'Y', 0.04 },
{ 'Z', 1.13 },
{ 'Ä', 0.58 },
{ 'Ö', 0.44 },
{ 'Ü', 1.00 },
{ 'ẞ', 0.31 } };


        public IDictionary<char, double> letterFrequenciesOfTheSpanishAlphabet = new Dictionary<char, double> {
    { 'A', 11.53 }, 
{ 'B', 2.22 },
{ 'C', 4.02 },
{ 'D', 5.01 },
{ 'E', 12.18 },
{ 'F', 0.69 },
{ 'G', 1.77 },
{ 'H', 0.70 },
{ 'I', 6.25 },
{ 'J', 0.49 },
{ 'K', 0.01 },
{ 'L', 4.97 },
{ 'M', 3.16 },
{ 'N', 6.71 },
{ 'Ñ', 0.31 },
{ 'O', 8.68 },
{ 'P', 2.51 },
{ 'Q', 0.88 },
{ 'R', 6.87 },
{ 'S', 7.98 },
{ 'T', 4.63 },
{ 'U', 2.93 },
{ 'Ú', 0.17 },
{ 'V', 1.14 },
{ 'W', 0.02 },
{ 'X', 0.22 },
{ 'Y', 1.01 },
{ 'Z', 0.47 },
{ 'Á', 0.50 },
{ 'É', 0.43 },
{ 'Í', 0.73 },
{ 'Ó', 0.83 },
{ 'Ü', 0.01 } 
        };


        public IDictionary<char, double> letterFrequenciesOfTheItalianAlphabet = new Dictionary<char, double> {
    { 'A', 11.74 },
{ 'B', 0.93 },
{ 'C', 4.50 },
{ 'D', 3.74 },
{ 'E', 11.79 },
{ 'F', 1.15 },
{ 'G', 1.64 },
{ 'H', 0.64 },
{ 'I', 10.14 },
{ 'J', 0.02 },
{ 'K', 0.07 },
{ 'L', 6.51 },
{ 'M', 2.51 },
{ 'N', 6.88 },
{ 'O', 9.83 },
{ 'P', 3.06 },
{ 'Q', 0.00 },
{ 'R', 6.37 },
{ 'S', 4.98 },
{ 'T', 5.62 },
{ 'U', 3.01 },
{ 'V', 2.10 },
{ 'W', 0.03 },
{ 'X', 0.03 },
{ 'Y', 0.02 },
{ 'Z', 1.18 } };


        public IDictionary<char, double> letterFrequenciesOfTheDutchAlphabet = new Dictionary<char, double> {
{ 'A', 7.49 },
{ 'B', 1.58 },
{ 'C', 1.24 },
{ 'D', 5.93 },
{ 'E', 18.91 },
{ 'F', 0.81 },
{ 'G', 3.40 },
{ 'H', 2.38 },
{ 'I', 6.50 },
{ 'J', 1.46 },
{ 'K', 2.25 },
{ 'L', 3.57 },
{ 'M', 2.21 },
{ 'N', 10.03 },
{ 'O', 6.06 },
{ 'P', 1.57 },
{ 'Q', 0.09 },
{ 'R', 6.41 },
{ 'S', 3.73 },
{ 'T', 6.79 },
{ 'U', 1.99 },
{ 'V', 2.85 },
{ 'W', 1.52 },
{ 'X', 0.04 },
{ 'Y', 0.04 },
{ 'Z', 1.39 } };


    }
}
