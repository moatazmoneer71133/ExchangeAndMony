﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ExchangeAndMony.model;

namespace ExchangeAndMony.data
{
    class conection
    {
    
        
        
        public static SqlConnection con = new SqlConnection(@"Server =DESKTOP-8TSV5U7;DataBase=DBTAEM;Trusted_Connection=yes");

    }
}
