﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace page
{
    class UserInput
    {
        public static ArrayList FIFOArrayList = new ArrayList();
        public static ArrayList LRUArrayList = new ArrayList();
        public static ArrayList OPTArrayList = new ArrayList();
        public static bool TLB = false;
        public static int pageNum = 5;
        public static int timeOfMemory = 100;
        public static int timeOfTLB = 5;
        public static int timeOfBreak = 500;
        public static int memoryNum = 10;
        public static string address = "7000H,0000H,1YYYH,2HHHH,0UUUH,3HHHH,0TTTH,4TTTH,2TTTH,3TTTH,0EEEH,3YYYH,2TTTH,1UUUH,2TTTH,0TTTH,1YYYH,7TTTH,0RRRH,1IIIH";
    }
}