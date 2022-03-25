using System;

namespace CP_CW_7417.BLL.Helpers
{
    public class IpGenerator
    {
        private Random _random;

        public IpGenerator(Random random) =>
            _random = random;

        // Generate random Ip address 
        public string GetRandomIpAddress() =>
            $"{_random.Next(1, 255)}.{_random.Next(0, 255)}.{_random.Next(0, 255)}.{_random.Next(0, 255)}";

    }
}
