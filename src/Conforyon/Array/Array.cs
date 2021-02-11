﻿using System.Collections.Generic;

namespace Conforyon.Array
{
    /// <summary>
    /// 
    /// </summary>
    public class Array
    {
        #region Arrays
        /// <summary>
        /// 
        /// </summary>
        public static readonly string[] SymbolsMath = {
            "-",
            "+"
        };

        /// <summary>
        /// 
        /// </summary>
        public static readonly string[] SymbolsCalc = {
            "E",
            "B",
            "+",
            "-"
        };

        /// <summary>
        /// 
        /// </summary>
        internal static readonly Dictionary<string, Dictionary<string, Dictionary<string, string>>> UnitValues = new()
        {
            {
                "DataStorage",
                new Dictionary<string, Dictionary<string, string>>()
                {
                    {
                        "Bit", new Dictionary<string, string>()
                        {
                            {
                                "Byte", "8"
                            },
                            {
                                "KB", "8192"
                            },
                            {
                                "MB", "8388608"
                            },
                            {
                                "GB", "8589934592"
                            },
                            {
                                "TB", "8796093022208"
                            },
                            {
                                "PB", "9007199254740992"
                            },
                            {
                                "EB", "18014398509481984"
                            },
                            {
                                "ZB", "27021597764222976"
                            },
                            {
                                "YB", "36028797018963970"
                            }
                        }
                    },
                    {
                        "Byte", new Dictionary<string, string>()
                        {
                            {
                                "Bit", "8"
                            },
                            {
                                "KB", "1024"
                            },
                            {
                                "MB", "1048576"
                            },
                            {
                                "GB", "1073741824"
                            },
                            {
                                "TB", "1099511627776"
                            },
                            {
                                "PB", "1125899906842624"
                            },
                            {
                                "EB", "1152921504606846976"
                            },
                            {
                                "ZB", "2305843009213694000"
                            },
                            {
                                "YB", "3458764513820541000"
                            }
                        }
                    },
                    {
                        "KB", new Dictionary<string, string>()
                        {
                            {
                                "Bit", "8192"
                            },
                            {
                                "Byte", "1024"
                            },
                            {
                                "MB", "1024"
                            },
                            {
                                "GB", "1048576"
                            },
                            {
                                "TB", "1073741824"
                            },
                            {
                                "PB", "1099511627776"
                            },
                            {
                                "EB", "1125899906842624"
                            },
                            {
                                "ZB", "1152921504606846976"
                            },
                            {
                                "YB", "2305843009213694000"
                            }
                        }
                    },
                    {
                        "MB", new Dictionary<string, string>()
                        {
                            {
                                "Bit", "8388608"
                            },
                            {
                                "Byte", "1048576"
                            },
                            {
                                "KB", "1024"
                            },
                            {
                                "GB", "1024"
                            },
                            {
                                "TB", "1048576"
                            },
                            {
                                "PB", "1073741824"
                            },
                            {
                                "EB", "1099511627776"
                            },
                            {
                                "ZB", "1125899906842624"
                            },
                            {
                                "YB", "1152921504606847000"
                            }
                        }
                    },
                    {
                        "GB", new Dictionary<string, string>()
                        {
                            {
                                "Bit", "8589934592"
                            },
                            {
                                "Byte", "1073741824"
                            },
                            {
                                "KB", "1048576"
                            },
                            {
                                "MB", "1024"
                            },
                            {
                                "TB", "1024"
                            },
                            {
                                "PB", "1048576"
                            },
                            {
                                "EB", "1073741824"
                            },
                            {
                                "ZB", "1099511627776"
                            },
                            {
                                "YB", "1125899906842624"
                            }
                        }
                    },
                    {
                        "TB", new Dictionary<string, string>()
                        {
                            {
                                "Bit", "8796093022208"
                            },
                            {
                                "Byte", "1099511627776"
                            },
                            {
                                "KB", "1073741824"
                            },
                            {
                                "MB", "1048576"
                            },
                            {
                                "GB", "1024"
                            },
                            {
                                "PB", "1024"
                            },
                            {
                                "EB", "1048576"
                            },
                            {
                                "ZB", "1073741824"
                            },
                            {
                                "YB", "1099511627776"
                            }
                        }
                    },
                    {
                        "PB", new Dictionary<string, string>()
                        {
                            {
                                "Bit", "9007199254740992"
                            },
                            {
                                "Byte", "1125899906842624"
                            },
                            {
                                "KB", "1099511627776"
                            },
                            {
                                "MB", "1073741824"
                            },
                            {
                                "GB", "1048576"
                            },
                            {
                                "TB", "1024"
                            },
                            {
                                "EB", "1024"
                            },
                            {
                                "ZB", "1048576"
                            },
                            {
                                "YB", "1073741824"
                            }
                        }
                    },
                    {
                        "EB", new Dictionary<string, string>()
                        {
                            {
                                "Bit", "9223372036854775808"
                            },
                            {
                                "Byte", "1152921504606846976"
                            },
                            {
                                "KB", "1125899906842624"
                            },
                            {
                                "MB", "1099511627776"
                            },
                            {
                                "GB", "1073741824"
                            },
                            {
                                "TB", "1048576"
                            },
                            {
                                "PB", "1024"
                            },
                            {
                                "ZB", "1024"
                            },
                            {
                                "YB", "1048576"
                            }
                        }
                    },
                    {
                        "ZB", new Dictionary<string, string>()
                        {
                            {
                                "Bit", "9444732965739290427392"
                            },
                            {
                                "Byte", "1180591620717411303424"
                            },
                            {
                                "KB", "1152921504606846976"
                            },
                            {
                                "MB", "1125899906842624"
                            },
                            {
                                "GB", "1099511627776"
                            },
                            {
                                "TB", "1073741824"
                            },
                            {
                                "PB", "1048576"
                            },
                            {
                                "EB", "1024"
                            },
                            {
                                "YB", "1024"
                            }
                        }
                    },
                    {
                        "YB", new Dictionary<string, string>()
                        {
                            {
                                "Bit", "9671406556917033397649408"
                            },
                            {
                                "Byte", "1208925819614629174706176"
                            },
                            {
                                "KB", "1180591620717411303424"
                            },
                            {
                                "MB", "1152921504606846976"
                            },
                            {
                                "GB", "1125899906842624"
                            },
                            {
                                "TB", "1099511627776"
                            },
                            {
                                "PB", "1073741824"
                            },
                            {
                                "EB", "1048576"
                            },
                            {
                                "ZB", "1024"
                            }
                        }
                    }
                }
            },
            {
                "Speed",
                new Dictionary<string, Dictionary<string, string>>()
                {
                    {
                        "MPH", new Dictionary<string, string>()
                        {
                            {
                                "KPH", "1,609344"
                            }
                        }
                    },
                    {
                        "KPH", new Dictionary<string, string>()
                        {
                            {
                                "MPH", "0,621371192"
                            }
                        }
                    }
                }
            },
            {
                "Temperature",
                new Dictionary<string, Dictionary<string, string>>()
                {
                    {
                        "Celsius", new Dictionary<string, string>()
                        {
                            {
                                "Divide", "5"
                            },
                            {
                                "Multipy", "9"
                            },
                            {
                                "Add", "32"
                            }
                        }
                    },
                    {
                        "Fahrenheit", new Dictionary<string, string>()
                        {
                            {
                                "Deduct", "32"
                            },
                            {
                                "Multipy", "5"
                            },
                            {
                                "Divide", "9"
                            }
                        }
                    }
                }
            },
            {
                "Time",
                new Dictionary<string, Dictionary<string, string>>()
                {
                    {
                        "Nanosecond", new Dictionary<string, string>()
                        {
                            {
                                "Microsecond", "0,001"
                            },
                            {
                                "Millisecond", "0,000001"
                            },
                            {
                                "Second", "1,E-9"
                            },
                            {
                                "Minute", "1,666666666E-11"
                            },
                            {
                                "Hour", "2,777777777E-13"
                            },
                            {
                                "Day", "1,157407407E-14"
                            },
                            {
                                "Week", "1,653439153E-15"
                            },
                            {
                                "Year", "3,168808781E-17"
                            },
                            {
                                "Century", "3,170979198E-19"
                            },
                            {
                                "Millennium", "3,170979198E-20"
                            }
                        }
                    },
                    {
                        "Microsecond", new Dictionary<string, string>()
                        {
                            {
                                "Nanosecond", "1000"
                            },
                            {
                                "Millisecond", "0,001"
                            },
                            {
                                "Second", "0,000001"
                            },
                            {
                                "Minute", "1,666666666E-8"
                            },
                            {
                                "Hour", "2,777777777E-10"
                            },
                            {
                                "Day", "1,157407407E-11"
                            },
                            {
                                "Week", "1,653439153E-12"
                            },
                            {
                                "Year", "3,168808781E-14"
                            },
                            {
                                "Century", "3,170979198E-16"
                            },
                            {
                                "Millennium", "3,170979198E-17"
                            }
                        }
                    },
                    {
                        "Millisecond", new Dictionary<string, string>()
                        {
                            {
                                "Nanosecond", "1000000"
                            },
                            {
                                "Microsecond", "1000"
                            },
                            {
                                "Second", "0,001"
                            },
                            {
                                "Minute", "0,0000166667"
                            },
                            {
                                "Hour", "2,777777777E-7"
                            },
                            {
                                "Day", "1,157407407E-8"
                            },
                            {
                                "Week", "1,653439153E-9"
                            },
                            {
                                "Year", "3,168808781E-11"
                            },
                            {
                                "Century", "3,170979198E-13"
                            },
                            {
                                "Millennium", "3,170979198E-14"
                            }
                        }
                    },
                    {
                        "Second", new Dictionary<string, string>()
                        {
                            {
                                "Nanosecond", "1000000000"
                            },
                            {
                                "Microsecond", "1000000"
                            },
                            {
                                "Millisecond", "1000"
                            },
                            {
                                "Minute", "0,0166666667"
                            },
                            {
                                "Hour", "0,0002777778"
                            },
                            {
                                "Day", "0,0000115741"
                            },
                            {
                                "Week", "0,0000016534"
                            },
                            {
                                "Year", "3,168808781E-8"
                            },
                            {
                                "Century", "3,170979198E-10"
                            },
                            {
                                "Millennium", "3,170979198E-11"
                            }
                        }
                    },
                    {
                        "Minute", new Dictionary<string, string>()
                        {
                            {
                                "Nanosecond", "60000000000"
                            },
                            {
                                "Microsecond", "60000000"
                            },
                            {
                                "Millisecond", "60000"
                            },
                            {
                                "Second", "60"
                            },
                            {
                                "Hour", "0,0166666667"
                            },
                            {
                                "Day", "0,0006944444"
                            },
                            {
                                "Week", "0,0000992063"
                            },
                            {
                                "Year", "0,0000019013"
                            },
                            {
                                "Century", "1,902587519E-8"
                            },
                            {
                                "Millennium", "1,902587519E-9"
                            }
                        }
                    },
                    {
                        "Hour", new Dictionary<string, string>()
                        {
                            {
                                "Nanosecond", "3600000000000"
                            },
                            {
                                "Microsecond", "3600000000000"
                            },
                            {
                                "Millisecond", "3600000"
                            },
                            {
                                "Second", "3600"
                            },
                            {
                                "Minute", "60"
                            },
                            {
                                "Day", "0,0416666667"
                            },
                            {
                                "Week", "0,005952381"
                            },
                            {
                                "Year", "0,0001140771"
                            },
                            {
                                "Century", "0,0000011416"
                            },
                            {
                                "Millennium", "1,141552511E-7"
                            }
                        }
                    },
                    {
                        "Day", new Dictionary<string, string>()
                        {
                            {
                                "Nanosecond", "86400000000000"
                            },
                            {
                                "Microsecond", "86400000000"
                            },
                            {
                                "Millisecond", "86400000"
                            },
                            {
                                "Second", "86400"
                            },
                            {
                                "Minute", "1440"
                            },
                            {
                                "Hour", "24"
                            },
                            {
                                "Week", "0,1428571429"
                            },
                            {
                                "Year", "0,0027378508"
                            },
                            {
                                "Century", "0,0000273973"
                            },
                            {
                                "Millennium", "0,0000027397"
                            }
                        }
                    },
                    {
                        "Week", new Dictionary<string, string>()
                        {
                            {
                                "Nanosecond", "604800000000002"
                            },
                            {
                                "Microsecond", "604800000000"
                            },
                            {
                                "Millisecond", "604800000"
                            },
                            {
                                "Second", "604800"
                            },
                            {
                                "Minute", "10080"
                            },
                            {
                                "Hour", "168"
                            },
                            {
                                "Day", "7"
                            },
                            {
                                "Year", "0,0191649555"
                            },
                            {
                                "Century", "0,0001917808"
                            },
                            {
                                "Millennium", "0,0000191781"
                            }
                        }
                    },
                    {
                        "Year", new Dictionary<string, string>()
                        {
                            {
                                "Nanosecond", "31557599999999904"
                            },
                            {
                                "Microsecond", "31557600000000"
                            },
                            {
                                "Millisecond", "31557600000"
                            },
                            {
                                "Second", "31557600"
                            },
                            {
                                "Minute", "525960"
                            },
                            {
                                "Hour", "8766"
                            },
                            {
                                "Day", "365,25"
                            },
                            {
                                "Week", "52,178571429"
                            },
                            {
                                "Century", "0,0100068493"
                            },
                            {
                                "Millennium", "0,0010006849"
                            }
                        }
                    },
                    {
                        "Century", new Dictionary<string, string>()
                        {
                            {
                                "Nanosecond", "3153600000000000000"
                            },
                            {
                                "Microsecond", "3153600000000000"
                            },
                            {
                                "Millisecond", "3153600000000"
                            },
                            {
                                "Second", "3153600000"
                            },
                            {
                                "Minute", "52560000"
                            },
                            {
                                "Hour", "876000"
                            },
                            {
                                "Day", "36500"
                            },
                            {
                                "Week", "5214,2857143"
                            },
                            {
                                "Year", "99,93155373"
                            },
                            {
                                "Millennium", "0,1"
                            }
                        }
                    },
                    {
                        "Millennium", new Dictionary<string, string>()
                        {
                            {
                                "Nanosecond", "31536000000000000000"
                            },
                            {
                                "Microsecond", "31536000000000000"
                            },
                            {
                                "Millisecond", "31536000000000"
                            },
                            {
                                "Second", "31536000000"
                            },
                            {
                                "Minute", "525600000"
                            },
                            {
                                "Hour", "8760000"
                            },
                            {
                                "Day", "365000"
                            },
                            {
                                "Week", "52142,857143"
                            },
                            {
                                "Year", "999,3155373"
                            },
                            {
                                "Century", "10"
                            }
                        }
                    }
                }
            },
            {
                "Typography",
                new Dictionary<string, Dictionary<string, string>>()
                {
                    {
                        "INCH", new Dictionary<string, string>()
                        {
                            {
                                "CM", "2,54"
                            },
                            {
                                "PX", "96"
                            }
                        }
                    },
                    {
                        "CM", new Dictionary<string, string>()
                        {
                            {
                                "INCH", "0,3937007874"
                            },
                            {
                                "PX", "37,795275591"
                            }
                        }
                    },
                    {
                        "PX", new Dictionary<string, string>()
                        {
                            {
                                "INCH", "0,0104166667"
                            },
                            {
                                "CM", "0,0264583333"
                            }
                        }
                    }
                }
            }
        };
        #endregion
    }
}