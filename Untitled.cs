public static bool isUniqueChars2(String str) {
        bool[] char_set = new bool[256];
        for (int i = 0; (i < str.length()); i++) {
            int val = str.charAt(i);
            if (char_set[val]) {
                return false;
            }
            char_set[val] = true;
        } 
        return true;
    }
