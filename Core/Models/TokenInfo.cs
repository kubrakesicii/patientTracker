﻿using System;

namespace Core.Models
{
    public class TokenInfo
    {
        public string Token { get; set; }
        public string RefreshToken { get; set; }
        public DateTime TokenExpiration { get; set; }
        public DateTime RefreshTokenExpiration { get; set; }
    }
}