﻿namespace NonStopMarket.App.Core.IO.Contracts
{
    public interface IWriter
    {
        void Write(string text);

        void WriteLine(string text);
    }
}