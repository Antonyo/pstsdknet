﻿namespace pstsdk.test.mocks.MockPropBagConstants
{
    public static class NameIdConstants
    {
        public static byte[] EntryStreamBytes = new byte[] 
        {
            0x82, 0x16, 0x00, 0x00, //PropertyId (Numerical Value)
            0x00, 0x00, // Numerical ID Type, No Guid (0x00)
            0x00, 0x00, // PropertyIndex = 0x8000 (0x00)

            0x00, 0x00, 0x00, 0x00, //PropertyId (String Offset)
            0x81, 0x00, //String ID Type, MAPI_GUID
            0x01, 0x00, // PropertyIndex = 0x8001 (0x01)

            0x73, 0x24, 0x12, 0x00, //PropertyId (Numerical Value)
            0x02, 0x00, //Numerical ID Type, GUID_PUBLIC_STRINGS
            0x02, 0x00, // PropertyIndex = 0x8002 (0x02)

            0x10, 0x00, 0x00, 0x00, //PropertyId (String Offset)
            0x83, 0x00, //String ID Type, Custom GUID (Index: 0 (0x03))
            0x03, 0x00, // PropertyIndex = 0x8003 (0x03)

            0x18, 0x00, 0x00, 0x00, //PropertyId (String Offset)
            0x84, 0x00, //String ID Type, Custom GUID (Index: 1 (0x04))
            0x04, 0x00, // PropertyIndex = 0x8004 (0x04)

            0x28, 0x00, 0x00, 0x00, //PropertyId (String Offset)
            0x85, 0x00, //String ID Type, Custom GUID (Index: 2 (0x04))
            0x05, 0x00, // PropertyIndex = 0x8005 (0x05)
        };

        public static byte[] StringStreamBytes = new byte[]
        {
            0x0A, 0x00, 0x00, 0x00, //String Length (10)
            0x68, 0x00, 0x65, 0x00, 0x6c, 0x00, 0x6c, 0x00, 0x6f, 0x00, //hello
            0x00, 0x00, //padding

            0x02, 0x00, 0x00, 0x00, //String Length (2)
            0x61, 0x00, //a
            0x00, 0x00, //padding

            0x0C, 0x00, 0x00, 0x00, //String Length (12)
            0x62, 0x00, 0x63, 0x00, 0x62, 0x00, 0x63, 0x00, 0x62, 0x00, 0x63, 0x00, //bcbcbc
            //LOL NO PADDING

            0x04, 0x00, 0x00, 0x00, //String Length (4)
            0x64, 0x00, 0x61, 0x00 //da
        };

        public static byte[] GuidStreamBytes = new byte[]
        {
            0x4C, 0xE0, 0x14, 0xC3, 0x0A, 0xBB, 0x4a, 0x4d, //Guid 1
            0xB8, 0x83, 0x0B, 0x77, 0xE7, 0x92, 0x72, 0x3A, //c314e04cbb0a4d4ab8830b77e792723a

            0x65, 0xF1, 0x9C, 0x35, 0xD9, 0x06, 0x46, 0x62, //Guid 2
            0xA8, 0xC7, 0xC7, 0xAA, 0x9A, 0xDA, 0x79, 0x98,

            0x69, 0xF6, 0x1B, 0xE8, 0xEA, 0x0F, 0x45, 0x6e, //Guid 3
            0xB0, 0x86, 0xAA, 0x7C, 0xBF, 0xFA, 0x35, 0x2D
        };
    }
}
