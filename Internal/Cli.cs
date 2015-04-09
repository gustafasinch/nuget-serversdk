﻿using Sinch.Callback.Request;

namespace Sinch.Callback.Internal
{
    internal class Cli : ICli
    {
        public CliMode Mode { get; set; }
        public string Numeric { get; set; }
        public string AlphaNumeric { get; set; }
        public string Full { get; set; }

        public override string ToString()
        {
            return Full;
        }
    }
}
