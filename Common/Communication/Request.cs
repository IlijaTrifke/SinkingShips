using System;

namespace Common.Communication
{
    [Serializable]
    public class Request
    {
        public int Pozicija { get; set; }
        public Operation Operacija { get; set; }
    }
}
